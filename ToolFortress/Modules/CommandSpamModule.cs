using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToolFortress.TF2;

namespace ToolFortress.Modules
{
    class CommandSpamModule : IModule
    {
        private bool spamActive = false;

        public void Enable()
        {
            spamActive = true;
            Thread spamThread = new Thread(DoSpam);
            spamThread.Start();
        }

        public void Disable()
        {
            spamActive = false;
        }

        private void DoSpam()
        {
            while (spamActive)
            {
                Game.RconClient.SendCommand(Settings.M_SPAM_COMMAND);
                Thread.Sleep(Settings.M_SPAM_DELAY);
            }
        }
    }
}
