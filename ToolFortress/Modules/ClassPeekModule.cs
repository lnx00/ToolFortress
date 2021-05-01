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
        public delegate void ClassUpdateHandler(Player[] playerList);
        public event ClassUpdateHandler OnClassUpdate = delegate { };

        private Player[] _classBuffer;

        public void Enable()
        {
            Game.LogParser.OnKillFeed += HandleKillFeed;
            Game.LogParser.OnStatusUpdate += HandleStatusUpdate;
            Game.LogParser.OnLobbyUpdate += Reset;

            Reset(); // Initial Reset
        }

        public void Disable()
        {
            Game.LogParser.OnKillFeed -= HandleKillFeed;
        }

        public void Reset()
        {
            _classBuffer = Game.GetPlayers();
            OnClassUpdate(_classBuffer);
        }

        /* Handle killfeed updates */
        private void HandleKillFeed(KillFeed killFeed)
        {
            Class playerClass = Interpreter.GetClassByWeapon(killFeed.Weapon);

            Console.WriteLine("Detected Class: " + playerClass.ToString());

            if (playerClass != Class.Unknown)
            {
                for (int i = 0; i < _classBuffer.Length; i++)
                {
                    if (_classBuffer[i].Name == killFeed.Killer)
                    {
                        _classBuffer[i].Class = playerClass;
                        OnClassUpdate(_classBuffer);
                    }
                }
            }
        }

        /* Handle status updates */
        private void HandleStatusUpdate(List<Player> playerList)
        {
            Player[] oldClassBuffer = _classBuffer;
            Player[] newClassBuffer = playerList.ToArray();
            
            for (int i = 0; i < oldClassBuffer.Length; i++)
            {
                for (int j = 0; j < newClassBuffer.Length; j++)
                {
                    if (newClassBuffer[j].UserID == oldClassBuffer[i].UserID)
                    {
                        newClassBuffer[j].Class = oldClassBuffer[i].Class;
                    }
                }
            }

            // Return a distinct array just in case...
            _classBuffer = newClassBuffer;
        }
    }
}
