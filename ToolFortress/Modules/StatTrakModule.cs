using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolFortress.TF2;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.Modules
{
    class StatTrakModule : IModule
    {
        private List<KillFeed> myKills;
        private List<KillFeed> myDeaths;

        public delegate void StatUpdateHandler(List<KillFeed> kills, List<KillFeed> deaths);
        public event StatUpdateHandler OnStatUpdate = delegate { };

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
            string localPlayer = Game.GetLocalPlayer().Name;

            if (killFeed.Killer == localPlayer)
            {
                myKills.Add(killFeed);
                OnStatUpdate(myKills, myDeaths);
            } else if (killFeed.Target == localPlayer)
            {
                myDeaths.Add(killFeed);
                OnStatUpdate(myKills, myDeaths);
            }
        }

        public int GetKills()
        {
            return myKills.Count;
        }

        public int GetDeaths()
        {
            return myDeaths.Count;
        }

        public void Reset()
        {
            myKills = new List<KillFeed>();
            myDeaths = new List<KillFeed>();
            OnStatUpdate(myKills, myDeaths);
        }
    }
}
