using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ToolFortress.TF2.Interpreter;

namespace ToolFortress
{
    static class Settings
    {
        /* OPTIONS */
        public static int LOG_READ_INTERVAL = 200;
        public static string RCON_IP = "127.0.0.1";
        public static string RCON_PASSWORD = "toolfortress";
        public static ushort RCON_PORT = 2541;
        public static string TF2_FOLDER = @"G:\Steam\steamapps\common\Team Fortress 2\";
        public static string TF2_STEAMID3 = "[U:1:347654006]";
        public static string TFC_IP = "185.239.236.169";
        public static int TFC_Port = 2063;
        public static string TFC_Username = "Guest";

        /* FEATURES */
        public static bool F_CONSOLE_MIRROR = true;
        public static int F_THEME_ID = 0;

        /* MODULES */
        public static bool M_KILLSAY_CRITONLY = false;
        public static bool M_KILLSAY_KILL = false;
        public static bool M_KILLSAY_DEATH = false;
        public static bool M_KILLSAY_CLASSONLY = false;
        public static Class M_KILLSAY_CLASS = Class.Scout;
        public static string M_KILLSAY_KILLMSG = "";
        public static string M_KILLSAY_DEATHMSG = "";

        public static string M_SPAM_COMMAND = "";
        public static int M_SPAM_DELAY = 1000;

        /* REGEX */
        public const string REGEX_CHAT = @"(\*DEAD\*)?\s*(\(TEAM\))?\s*(.{1,33}) :  ((?:.|[\r\n])*)";
        public const string REGEX_KILL = @"(.*) killed (.*) with (.*)\.( \(crit\))?";
        public const string REGEX_PLAYER_STATUS = @".*#\s+(\d+)\s\u0022(.*)\u0022\s+(\[U:1:\d+\])\s+(\d+:\d+)\s+(\d+).*(challenging|active|connecting|spawning)";
        public const string REGEX_MAP_POS = @".*map\s+:\s+(.*_.*)\s+at:\s(-?\d+)\sx,\s(-?\d+)\sy,\s(-?\d+)\sz";
        public const string REGEX_COMMAND = ".*Unknown command.*(!|\\/)([^\"]*)";
        public const string REGEX_CONNECT = "(.*) (connected|disconnected)";
        public const string REGEX_LOBBY = @"CTFLobbyShared: ID:([0-9a-f]*)\s+(\d+) member\(s\), (\d+) pending";
        public const string REGEX_ID3 = @"\[U:\d:\d*\]";

        public static void Load()
        {
            Properties.Settings.Default.Reload();

            RCON_IP = Properties.Settings.Default.RCON_IP;
            RCON_PASSWORD = Properties.Settings.Default.RCON_PASSWORD;
            RCON_PORT = Properties.Settings.Default.RCON_PORT;
            TF2_FOLDER = Properties.Settings.Default.TF2_FOLDER;
            TF2_STEAMID3 = Properties.Settings.Default.TF2_STEAMID3;

            F_CONSOLE_MIRROR = Properties.Settings.Default.F_CONSOLE_MIRROR;
            F_THEME_ID = Properties.Settings.Default.F_THEME_ID;
        }

        public static void Save()
        {
            Properties.Settings.Default.RCON_IP = RCON_IP;
            Properties.Settings.Default.RCON_PASSWORD = RCON_PASSWORD;
            Properties.Settings.Default.RCON_PORT = RCON_PORT;
            Properties.Settings.Default.TF2_FOLDER = TF2_FOLDER;
            Properties.Settings.Default.TF2_STEAMID3 = TF2_STEAMID3;

            Properties.Settings.Default.F_CONSOLE_MIRROR = F_CONSOLE_MIRROR;
            Properties.Settings.Default.F_THEME_ID = F_THEME_ID;

            Properties.Settings.Default.Save();
        }
    }
}
