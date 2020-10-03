using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /* FEATURES */
        public static bool F_CONSOLE_MIRROR = true;

        /* REGEX */
        public const string CHAT_REGEX = @"(\*DEAD\*)?\s*(\(TEAM\))?\s*(.{1,33}) :  ((?:.|[\r\n])*)";
        public const string KILL_REGEX = @"(.*) killed (.*) with (.*)\.( \(crit\))?";
        public const string PLAYER_STATUS_REGEX = @".*#\s+(\d+)\s\u0022(.*)\u0022\s+(\[U:1:\d+\])\s+(\d+:\d+)\s+(\d+).*(challenging|active|connecting|spawning)";
        public const string MAP_POS_REGEX = @".*map\s+:\s+(.*_.*)\s+at:\s(-?\d+)\sx,\s(-?\d+)\sy,\s(-?\d+)\sz";
        public const string COMMAND_REGEX = ".*Unknown command \"(!|\\/)(.*)\"";

    }
}
