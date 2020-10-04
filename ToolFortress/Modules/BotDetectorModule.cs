using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolFortress.TF2;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.Modules
{
    class BotDetectorModule : IModule
    {
        private List<StatPlayer> knownPlayers;

        public void Enable()
        {
            knownPlayers = new List<StatPlayer>();

            Game.LogParser.OnStatusUpdate += HandleStats;
            Game.LogParser.OnLobbyUpdate += Reset;
        }

        public void Disable()
        {
            Game.LogParser.OnLobbyUpdate -= Reset;
        }

        public void Reset()
        {
              
        }

        private void HandleStats()
        {

        }
    }
}
