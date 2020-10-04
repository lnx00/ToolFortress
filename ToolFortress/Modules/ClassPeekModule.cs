using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolFortress.TF2;
using static ToolFortress.TF2.Interpreter;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.Modules
{
    class ClassPeekModule : IModule
    {
        private Dictionary<string, Class> playerClassList;

        public delegate void ClassUpdateHandler(Dictionary<string, Class> playerClassList);
        public event ClassUpdateHandler OnClassUpdate = delegate { };

        public void Enable()
        {
            Reset();
            Game.LogParser.OnKillFeed += HandleKillFeed;
            Game.LogParser.OnLobbyUpdate += Reset;
        }

        public void Disable()
        {
            Game.LogParser.OnKillFeed -= HandleKillFeed;
        }

        private void HandleKillFeed(KillFeed killFeed)
        {
            Class playerClass = Interpreter.GetClassByWeapon(killFeed.Weapon);

            if (playerClass != Class.Unknown)
            {
                if (playerClassList.ContainsKey(killFeed.Killer))
                {
                    playerClassList[killFeed.Killer] = playerClass;
                } else
                {
                    playerClassList.Add(killFeed.Killer, playerClass);
                }

                OnClassUpdate(playerClassList);
            }
        }

        public void Reset()
        {
            playerClassList = new Dictionary<string, Class>();
            OnClassUpdate(playerClassList);
        }
    }
}
