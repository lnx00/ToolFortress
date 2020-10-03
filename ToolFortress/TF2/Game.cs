using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TFRcon;

namespace ToolFortress.TF2
{
    static class Game
    {
        public static LogReader LogReader { get; }
        public static LogParser LogParser { get; }
        public static RconClient RconClient { get; }

        static Game()
        {
            LogReader = new LogReader(Settings.TF2_FOLDER);
            LogParser = new LogParser(LogReader);
            RconClient = new RconClient();
        }

        public static void SendChatMessage(string pMessage)
        {
            RconClient.SendCommand("say \"" + Utils.EscapeChatMessage(pMessage) + "\"");
        }

        public static void SendTeamMessage(string pMessage)
        {
            RconClient.SendCommand("say_team \"" + Utils.EscapeChatMessage(pMessage) + "\"");
        }

        public static void SendPartyMessage(string pMessage)
        {
            RconClient.SendCommand("tf_party_chat \"" + Utils.EscapeChatMessage(pMessage) + "\"");
        }
    }
}
