using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolFortress.TF2;

namespace ToolFortress.Modules
{
    class CommandModule : Module
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
            Console.WriteLine("CMD: " + pCommand);
            if (pCommand == "no") { Disable(); }
        }
    }
}
