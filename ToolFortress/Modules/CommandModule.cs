using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolFortress.TF2;

namespace ToolFortress.Modules
{
    class CommandModule : IModule
    {
        public void Enable()
        {
            Game.LogParser.OnCommand += ParseCommand;
        }

        public void Disable()
        {
            Game.LogParser.OnCommand -= ParseCommand;
        }

        private void ParseCommand(string pCommand)
        {
            switch (pCommand)
            {
                case "disable":
                    Game.SendPartyMessage("Console Commands disabled.");
                    Disable();
                    break;

                case "exit":
                case "quit":
                    Game.SendPartyMessage("Closing ToolFortress...");
                    Application.Exit();
                    break;

                case "help":
                    Game.SendPartyMessage("========== ToolFortress ==========");
                    Game.SendPartyMessage("!disable - Disabled custom commands");
                    Game.SendPartyMessage("!exit - Closes ToolFortress");
                    Game.SendPartyMessage("!help - Shows this menu");
                    break;

                case "test":
                    Game.SendPartyMessage("Me: " + Game.GetLocalPlayer().Name);
                    break;

                default:
                    Game.SendPartyMessage("Unknown command: '" + pCommand + "'");
                    break;
            }
        }
    }
}
