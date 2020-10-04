using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToolFortress.TF2;

namespace ToolFortress.Modules
{
    class PointFarmModule : IModule
    {
        private bool isFarming = false;

        public void Enable()
        {
            isFarming = true;
            Thread farmThread = new Thread(DoFarming);
            farmThread.Start();
        }

        public void Disable()
        {
            isFarming = false;
        }

        public void DoFarming()
        {
            int lastTask = 0;

            Game.SendCommand("+attack");

            while (isFarming)
            {
                if (Settings.M_POINTFARM_MODE)
                {
                    // Engineer Mode
                    if (lastTask == 0)
                    {
                        Game.SendCommand("build 1 0");
                        lastTask = 1;
                    } else
                    {
                        Game.SendCommand("build 1 1");
                        lastTask = 0;
                    }
                    Thread.Sleep(500);
                }
            }

            Game.SendCommand("-attack");
        }
    }
}
