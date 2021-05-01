using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ToolFortress.TF2;
using static ToolFortress.TF2.Interpreter;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.Modules
{
    class BotDetectorModule : IModule
    {
        private List<Player> knownPlayers;
        private List<Player> detectedPlayers;
        private List<string> bannedPlayers;

        private bool isActive = false;
        private int timeSinceLastAction = 0;

        public delegate void LogUpdateHandler(string message);
        public event LogUpdateHandler OnLogUpdate = delegate { };

        public void Enable()
        {
            knownPlayers = new List<Player>();
            detectedPlayers = new List<Player>();
            bannedPlayers = new List<string>();

            Game.LogParser.OnStatusUpdate += HandleStats;
            Game.LogParser.OnLobbyUpdate += Reset;

            isActive = true;
            new Thread(DownloadLists).Start();
            new Thread(DoWork).Start();
        }

        public void Disable()
        {
            Game.LogParser.OnLobbyUpdate -= Reset;

            isActive = false;
        }

        public void Reset()
        {
            knownPlayers = new List<Player>();
            detectedPlayers = new List<Player>();
        }

        /* Handle stat update */
        private void HandleStats(List<Player> playerList)
        {
            /*foreach (Player player in Game.GetPlayers())
            {
                if (knownPlayers.Contains(player) || detectedPlayers.Contains(player)) { continue; }

                if (bannedPlayers.Contains(player.UniqueID))
                {
                    detectedPlayers.Add(player);
                    OnLogUpdate("Marked '" + player.Name + "' as a cheater!");
                }

                knownPlayers.Add(player);
            }*/

            foreach (Player player in Game.GetPlayers())
            {
                // Yes, we'll have a problem with name changing bots
                if (detectedPlayers.Contains(player))
                {
                    continue;
                }

                if (bannedPlayers.Contains(player.UniqueID))
                {
                    detectedPlayers.Add(player);
                    OnLogUpdate("Marked '" + player.Name + "' as a cheater!");
                }
            }
        }

        /* Alert enemies and/or kick players */
        private void DoWork()
        {
            while (isActive)
            {
                if (detectedPlayers.Count > 0)
                {
                    Player targetPlayer = detectedPlayers.First();

                    if (timeSinceLastAction > Settings.M_BD_DELAY)
                    {
                        if (Settings.M_BD_ENEMYNOTIFY)
                        {
                            Game.SendChatMessage(Utils.BotAlertPlaceholder(Settings.M_BD_ENEMYMSG, targetPlayer.Name));
                        }

                        if (Settings.M_BD_VOTEKICK)
                        {
                            Game.SendCommand("callvote kick " + targetPlayer.UserID + " cheating");
                        }

                        timeSinceLastAction = 0;
                    }
                }

                timeSinceLastAction += 1000;
                Thread.Sleep(1000);
            }
        }

        /* Download the latest cheater lists */
        private void DownloadLists()
        {
            WebClient wc = new WebClient();

            foreach (string listUrl in Settings.M_BD_SOURCES)
            {
                try
                {
                    string currentList = wc.DownloadString(listUrl);
                    dynamic jsonData = JsonConvert.DeserializeObject(currentList);

                    if (jsonData.players != null && jsonData.players.Count > 0)
                    {
                        OnLogUpdate("Adding " + jsonData.players.Count + " known cheaters...");
                        foreach (dynamic player in jsonData.players)
                        {
                            if (player.steamid != null && player.steamid.ToString().Length > 6)
                            {
                                if (!bannedPlayers.Contains(player.steamid.ToString()))
                                {
                                    bannedPlayers.Add(player.steamid.ToString());
                                }
                            }
                        }
                    }
                } catch (Exception ex)
                {
                    OnLogUpdate("Couldn't download list '" + listUrl + "': " + ex.Message);
                }
            }
        }
    }
}
