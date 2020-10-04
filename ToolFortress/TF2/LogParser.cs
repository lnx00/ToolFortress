using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ToolFortress.TF2
{
    class LogParser
    {
        // Structs
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

        public struct StatPlayer
        {
            public string UserID;
            public string Name;
            public string UniqueID;
            public string Playtime;
            public string Ping;
            public string State;

            public StatPlayer(string pUserID, string pName, string pUniqueID, string pPlaytime, string pPing, string pState)
            {
                UserID = pUserID;
                Name = pName;
                UniqueID = pUniqueID;
                Playtime = pPlaytime;
                Ping = pPing;
                State = pState;
            }
        }

        // Events
        public delegate void KillFeedHandler(KillFeed killFeed);
        public event KillFeedHandler OnKillFeed = delegate { };

        public delegate void CommandHandler(string command);
        public event CommandHandler OnCommand = delegate { };

        public delegate void ChatMessageHandler(ChatMessage chatMessage);
        public event ChatMessageHandler OnChatMessage = delegate { };

        public delegate void PlayerConnectHandler(string playerName, bool connected);
        public event PlayerConnectHandler OnPlayerConnect = delegate { };

        public delegate void MapUpdateHandler(MapData mapData);
        public event MapUpdateHandler OnMapUpdate = delegate { };

        public delegate void LobbyUpdateHandler();
        public event LobbyUpdateHandler OnLobbyUpdate = delegate { };

        public LogParser() { }

        public LogParser(LogReader pLogReader)
        {
            pLogReader.OnLogUpdate += ParseLine;
        }

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
            else if (Regex.IsMatch(pLine, Settings.REGEX_MAP_POS))
            {
                ParseMapPos(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_PLAYER_STATUS))
            {
                ParseStatus(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_LOBBY))
            {
                OnLobbyUpdate();
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_CONNECT))
            {
                ParseConnect(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.REGEX_CHAT))
            {
                ParseChat(pLine);
            }
        }

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

        private void ParseConnect(string pLine)
        {
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_CONNECT);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 3)
                {
                    OnPlayerConnect(match.Groups[1].Value, match.Groups[2].Value == "connected");
                }
            }
        }

        private void ParseMapPos(string pLine)
        {
            Game.StatPlayers.Clear();

            // Game info (Map, Position)
            MatchCollection matches = Regex.Matches(pLine, Settings.REGEX_MAP_POS);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 5)
                {
                    string mMap = match.Groups[1].Value;
                    int mX = int.Parse(match.Groups[2].Value);
                    int mY = int.Parse(match.Groups[3].Value);
                    int mZ = int.Parse(match.Groups[4].Value);

                    OnMapUpdate(new MapData(mMap, mX, mY, mZ));
                }
            }
        }

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

                    Game.StatPlayers.Add(new StatPlayer(pUserID, pName, pUniqueID, pPlaytime, pPing, pState));
                }
            }
        }

        // Parse 'status' response
        /*public void ParseStatus(string pStatus)
        {
            if (String.IsNullOrEmpty(pStatus)) { return; }
            Game.StatPlayers.Clear();

            string[] statusLines = pStatus.Split('\n');
            foreach (string line in statusLines)
            {
                MatchCollection matches;

                // Game info (Map, Position)
                matches = Regex.Matches(line, Settings.REGEX_MAP_POS);
                if (matches.Count == 1)
                {
                    Match match = matches[0];
                    if (match.Groups.Count == 5)
                    {
                        Console.WriteLine("Map info!");
                        // OnChatMessage(new ChatMessage(Utils.FilterChatMessage(match.Groups[3].Value), Utils.FilterChatMessage(match.Groups[4].Value), match.Groups[2].Success, match.Groups[1].Success));
                        continue;
                    }
                }

                // Player status (Name, Playtime, Status)
                matches = Regex.Matches(line, Settings.REGEX_MAP_POS);
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

                        Game.StatPlayers.Add(new StatPlayer(pUserID, pName, pUniqueID, pPlaytime, pPing, pState));
                        Console.WriteLine("Player info!");
                        continue;
                    }
                }
            }
        }*/
    }
}
