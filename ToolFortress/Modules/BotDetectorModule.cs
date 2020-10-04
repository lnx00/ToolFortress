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
        private List<Player> knownPlayers;
        private List<Player> detectedPlayers;
        private List<string> bannedPlayers;

        public void Enable()
        {
            knownPlayers = new List<Player>();
            detectedPlayers = new List<Player>();
            bannedPlayers = new List<string>();

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
            foreach (Player player in Game.StatPlayers)
            {
                if (knownPlayers.Contains(player)) { continue; }

                if (bannedPlayers.Contains(player.UniqueID))
                {
                    detectedPlayers.Add(player);
                }

                knownPlayers.Add(player);
            }
        }
    }
}
