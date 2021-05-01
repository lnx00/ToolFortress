using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolFortress.TF2;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.Modules
{
    class KillsayModule : IModule
    {
        public void Enable()
        {
            Game.LogParser.OnKillFeed += OnKillfeed;
        }

        public void Disable()
        {
            Game.LogParser.OnKillFeed -= OnKillfeed;
        }

        /* Handle killfeed update */
        private void OnKillfeed(KillFeed killFeed)
        {
            string localPlayer = Game.GetLocalPlayer().Name;

            if (killFeed.Killer == localPlayer)
            {
                if (Settings.M_KILLSAY_CRITONLY && !killFeed.Crit) { return; }

                // Taunt Kill
                if (Settings.M_KILLSAY_TAUNTKILL)
                {
                    Game.SendCommand(Interpreter.GetTauntCommand(Settings.M_KILLSAY_TAUNT));
                }

                // Kill Message
                if (Settings.M_KILLSAY_KILL)
                {
                    Game.SendChatMessage(Utils.KillsayPlaceholder(Settings.M_KILLSAY_KILLMSG, killFeed));
                }
            }

            if (Settings.M_KILLSAY_DEATH && killFeed.Target == localPlayer)
            {
                // Death message
                if (Settings.M_KILLSAY_CRITONLY && !killFeed.Crit) { return; }
                if (Settings.M_KILLSAY_CLASSONLY && Interpreter.GetClassByWeapon(killFeed.Weapon) != Settings.M_KILLSAY_CLASS) { return; }

                Game.SendChatMessage(Utils.KillsayPlaceholder(Settings.M_KILLSAY_DEATHMSG, killFeed));
            }
        }
    }
}
