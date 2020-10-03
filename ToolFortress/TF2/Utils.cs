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

        public static string KillfeedPlaceholder(string msg, KillFeed killFeed)
        {
            msg = msg.Replace("%1", killFeed.Killer);
            msg = msg.Replace("%2", killFeed.Target);
            return msg;
        }

    }
}
