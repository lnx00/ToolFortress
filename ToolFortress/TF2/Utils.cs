using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.TF2
{
    static class Utils
    {

        public static string EscapeChatMessage(string msg)
        {
            msg = msg.Replace("\"", "'");
            msg = msg.Replace("\\", "");
            return msg;
        }

        public static string FilterChatMessage(string msg)
        {
            msg = msg.Replace("\u200d", "");
            msg = msg.Replace("\u2060", "");
            msg = msg.Replace("\u200b", "");
            msg = msg.Replace("\u200c", "");
            return msg;
        }

        public static string KillsayPlaceholder(string msg, KillFeed killFeed)
        {
            msg = msg.Replace("%1", killFeed.Killer);
            msg = msg.Replace("%2", killFeed.Target);
            return msg;
        }

        public static string BotAlertPlaceholder(string msg, string name, bool filterSlurs = false)
        {
            if (filterSlurs)
            {
                name = name.Replace("nigga", "n****");
                name = name.Replace("fuck", "f***");
                name = name.Replace("faggot", "f*****");
            }

            msg = msg.Replace("%1", name);
            return msg;
        }

        public static string ConvertToID3(long id64)
        {
            return "[U:1:" + (id64 ^ 76561197960265728).ToString() + "]";
        }

        public static long ConvertToID64(string id3)
        {
            string idPars = id3.Substring(5, id3.Length - 6);
            return long.Parse(idPars) + 76561197960265728;
        }

        public static int CalcExpression(int n1, int n2, char op)
        {
            switch (op)
            {
                case '+':
                    return n1 + n2;

                case '-':
                    return n1 - n2;

                case '*':
                    return n1 * n2;

                case '/':
                    return n1 / n2;
            }

            return 1;
        }
    }
}
