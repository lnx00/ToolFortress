﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using TFRcon;
using static ToolFortress.TF2.Interpreter;
using static ToolFortress.TF2.LogParser;

namespace ToolFortress.TF2
{
    static class Game
    {
        private static bool infoRequest = false;

        public static LogReader LogReader { get; }
        public static LogParser LogParser { get; }
        public static RconClient RconClient { get; }

        private static List<Player> Players = new List<Player>();

        static Game()
        {
            LogReader = new LogReader(Settings.TF2_FOLDER);
            LogParser = new LogParser(LogReader);
            RconClient = new RconClient();
        }

        public static bool IsRunning()
        {
            return Process.GetProcessesByName("hl2").Length > 0;
        }

        public static void Disconnect()
        {
            LogReader.Stop();
            RconClient.Disconnect();
            infoRequest = false;
        }

        public static void StartInfoRequest()
        {
            infoRequest = true;
            Thread infoThread = new Thread(RequestInfo);
            infoThread.Start();
        }

        public static string SendCommand(string pCommand)
        {
            try
            {
                return RconClient.SendCommand(pCommand); ;
            } catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        public static void SendChatMessage(string pMessage)
        {
            SendCommand("say \"" + Utils.EscapeChatMessage(pMessage) + "\"");
        }

        public static void SendTeamMessage(string pMessage)
        {
            SendCommand("say_team \"" + Utils.EscapeChatMessage(pMessage) + "\"");
        }

        public static void SendPartyMessage(string pMessage)
        {
            SendCommand("tf_party_chat \"" + Utils.EscapeChatMessage(pMessage) + "\"");
        }

        /* Update the player list */
        public static void SetPlayers(List<Player> pPlayerList)
        {
            Players = pPlayerList;
        }

        /* Returns all players */
        public static Player[] GetPlayers()
        {
            return Players.ToArray();
        }

        /* Returns a player via a given Player-ID or SteamID3 */
        public static Player GetPlayer(string pID)
        {
            Player player = Players.Where(p => p.UserID == pID || p.UniqueID == pID).First();
            return player;
        }

        /* Returns the local player */
        public static Player GetLocalPlayer()
        {
            try
            {
                Player player = Players.Where(p => p.UniqueID == Settings.TF2_STEAMID3).First();
                return player;
            } catch (Exception)
            {
                return new Player("0", "Unknown", "0", "00:00", "0", "invalid");
            } 
        }

        /* Periodically requests the server status */
        public static void RequestInfo()
        {
            while (infoRequest)
            {
                if (RconClient.IsConnected())
                {
                    SendCommand("status");
                }
                Thread.Sleep(Settings.F_STATUS_DELAY);
            }
        }
    }
}
