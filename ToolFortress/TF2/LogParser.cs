using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static ToolFortress.TF2.Interpreter;

namespace ToolFortress.TF2
{
    class LogParser
    {
        #region STRUCTS
        public struct KillFeed
        {
            public string Killer;
            public string Target;
            public string Weapon;
            public bool Crit;

            public KillFeed(string pKiller, string pTarget, string pWeapon, bool pCrit)
            {
                Killer = pKiller;
                Target = pTarget;
                Weapon = pWeapon;
                Crit = pCrit;
            }
        }
        public struct ChatMessage
        {
            public string Sender;
            public string Message;
            public bool Team;
            public bool Dead;

            public ChatMessage(string pSender, string pMessage, bool pTeam, bool pDead)
            {
                Sender = pSender;
                Message = pMessage;
                Team = pTeam;
                Dead = pDead;
            }
        }

        public struct MapData
        {
            public string Map;
            public int X;
            public int Y;
            public int Z;

            public MapData(string pMap, int pX, int pY, int pZ)
            {
                Map = pMap;
                X = pX;
                Y = pY;
                Z = pZ;
            }
        }
        #endregion

        #region EVENTS
        public delegate void KillFeedHandler(KillFeed killFeed);
        public event KillFeedHandler OnKillFeed = delegate { };

        public delegate void CommandHandler(string command);
        public event CommandHandler OnCommand = delegate { };

        public delegate void ChatMessageHandler(ChatMessage chatMessage);
        public event ChatMessageHandler OnChatMessage = delegate { };

        public delegate void PlayerConnectHandler(string playerName, bool connected);
        public event PlayerConnectHandler OnPlayerConnect = delegate { };

        public delegate void LobbyUpdateHandler();
        public event LobbyUpdateHandler OnLobbyUpdate = delegate { };

        public delegate void StatusUpdateHandler(List<Player> playerList);
        public event StatusUpdateHandler OnStatusUpdate = delegate { };
        #endregion

        private int playerCount = 0;
        private List<Player> playerList = new List<Player>();

        public LogParser() { }

        public LogParser(LogReader pLogReader)
        {
            pLogReader.OnLogUpdate += ParseLine;
        }

        /* Parse console message */
        public void ParseLine(string pLine)
        {
            if (pLine.StartsWith("Attempted")) { return; }

            if (Regex.IsMatch(pLine, Settings.REGEX_KILL))
            {
                ParseKill(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_COMMAND))
            {
                ParseCommand(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_STATUS_HEADER))
            {
                ParseStatusHeader(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_PLAYER_STATUS))
            {
                ParseStatus(pLine);
            }
            else if (pLine == "Team Fortress")
            {
                OnLobbyUpdate();
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_CHAT))
            {
                ParseChat(pLine);
            }
            else if (Settings.F_SOLVE_MATH && Regex.IsMatch(pLine, Settings.REGEX_MATH))
            {
                ParseMath(pLine);
            }
        }

        /* Parse kill message */
        private void ParseKill(string pLine)
        {
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_KILL);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 5)
                {
                    OnKillFeed(new KillFeed(match.Groups[1].Value, match.Groups[2].Value, match.Groups[3].Value, match.Groups[4].Success));
                }
            }
        }

        /* Parse custom console command */
        private void ParseCommand(string pLine)
        {
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_COMMAND);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 3)
                {
                    OnCommand(match.Groups[2].Value);
                }
            }
        }


        /* Parse chat message */
        private void ParseChat(string pLine)
        {
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_CHAT);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 5)
                {
                    OnChatMessage(new ChatMessage(Utils.FilterChatMessage(match.Groups[3].Value), Utils.FilterChatMessage(match.Groups[4].Value), match.Groups[2].Success, match.Groups[1].Success));
                }
            }
        }

        /* Parse server status header */
        private void ParseStatusHeader(string pLine)
        {
            // Status header (Players, Bots, Max)
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_STATUS_HEADER);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 4)
                {
                    int sPlayers = int.Parse(match.Groups[1].Value);
                    int sBots = int.Parse(match.Groups[2].Value);
                    int sMax = int.Parse(match.Groups[3].Value);

                    // Reset player buffer (This ignores bots)
                    playerCount = sPlayers;
                    playerList = new List<Player>();

                    Console.WriteLine("[i] Players: " + sPlayers + ", Bots: " + sBots + " (Max: " + sMax + ")");
                }
            }
        }

        /* Parse player status */
        private void ParseStatus(string pLine)
        {
            // Player status (Name, Playtime, Status)
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_PLAYER_STATUS);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 7)
                {
                    string pUserID = match.Groups[1].Value;
                    string pName = match.Groups[2].Value;
                    string pUniqueID = match.Groups[3].Value;
                    string pPlaytime = match.Groups[4].Value;
                    string pPing = match.Groups[5].Value;
                    string pState = match.Groups[6].Value;

                    playerList.Add(new Player(pUserID, pName, pUniqueID, pPlaytime, pPing, pState));
                    if (playerCount != 0 && playerList.Count >= playerCount)
                    {
                        Game.SetPlayers(playerList);
                        OnStatusUpdate(playerList);
                    }
                }
            }
        }

        /* Parse math quiz */
        private void ParseMath(string pLine)
        {
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_MATH);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 4)
                {
                    int n1 = int.Parse(match.Groups[1].Value);
                    int n2 = int.Parse(match.Groups[3].Value);
                    char op = match.Groups[2].Value[0];

                    int result = Utils.CalcExpression(n1, n2, op);
                    if (Settings.F_SOLVE_MATH_LEGIT)
                    {
                        // Don't be too quick
                        new Thread(() =>
                        {
                            if (result == 0)
                            {
                                Thread.Sleep(500);
                            } else
                            {
                                Thread.Sleep(Math.Abs(result) * 2 + new Random().Next(400, 1000));
                            }
                            
                            Game.SendChatMessage(result.ToString());
                        }).Start();
                    } else
                    {
                        Game.SendChatMessage(result.ToString());
                    }
                }
            }
        }
    }
}
