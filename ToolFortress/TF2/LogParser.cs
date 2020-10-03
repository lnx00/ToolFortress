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

        // Events
        public delegate void KillFeedHandler(KillFeed killFeed);
        public event KillFeedHandler OnKillFeed = delegate { };

        public delegate void CommandHandler(string command);
        public event CommandHandler OnCommand = delegate { };

        public delegate void ChatMessageHandler(ChatMessage chatMessage);
        public event ChatMessageHandler OnChatMessage = delegate { };

        public LogParser() { }

        public LogParser(LogReader pLogReader)
        {
            pLogReader.OnLogUpdate += ParseLine;
        }

        public void ParseLine(string pLine)
        {
            if (Regex.IsMatch(pLine, Settings.KILL_REGEX))
            {
                ParseKill(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.COMMAND_REGEX))
            {
                ParseCommand(pLine);
            }
            else if (Regex.IsMatch(pLine, Settings.CHAT_REGEX))
            {
                ParseChat(pLine);
            }
        }

        private void ParseKill(string pLine)
        {
            MatchCollection matches = Regex.Matches(pLine, Settings.KILL_REGEX);
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
            MatchCollection matches = Regex.Matches(pLine, Settings.COMMAND_REGEX);
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
            MatchCollection matches = Regex.Matches(pLine, Settings.CHAT_REGEX);
            if (matches.Count == 1)
            {
                Match match = matches[0];
                if (match.Groups.Count == 5)
                {
                    OnChatMessage(new ChatMessage(Utils.FilterChatMessage(match.Groups[3].Value), Utils.FilterChatMessage(match.Groups[4].Value), match.Groups[2].Success, match.Groups[1].Success));
                }
            }
        }
    }
}
