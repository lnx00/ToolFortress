using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolFortress.TF2
{
    static class Interpreter
    {
        // TODO: More data mining...
        public static readonly string[] SCOUT_WEAPONS = { "scattergun", "pep_brawlerblaster", "soda_popper", "back_scatter", "shortstop", "force_a_nature", "pistol_scout", "the_winger", "pep_pistol", "guillotine" };
        public static readonly string[] SOLDIER_WEAPONS = { "cow_mangler", "quake_rl", "rocketlauncher_directhit", "blackbox", "liberty_launcher", "airstrike", "dumpster_device" };
        public static readonly string[] PYRO_WEAPONS = { "ai_flamethrower", "backburner", "degreaser", "phlogistinator", "rainblower", "dragons_fury_bonus", "flaregun", "scorch_shot" };
        public static readonly string[] DEMO_WEAPONS = { "iron_bomber", "tf_projectile_pipe", "loch_n_load", "loose_cannon", "tf_projectile_pipe_remote", "quickiebomb_launcher", "sticky_resistance", "demokatana", "sword", "bottle", "scotland_shard", "ullapool_caber", "battleaxe", "claidheamohmor", "nessieclub" };
        public static readonly string[] HEAVY_WEAPONS = { "iron_curtain", "minigun", "brass_beast", "long_heatmaker", "tomislav", "natascha", "family_business", "taunt_heavy", "holiday_punch" };
        public static readonly string[] ENGINEER_WEAPONS = { "obj_sentrygun", "obj_sentrygun2", "obj_sentrygun3", "obj_minisentry", "robot_arm", "wrench", "widowmaker", "pomson", "frontier_justice", "drescue_ranger" };
        public static readonly string[] MEDIC_WEAPONS = { "crusaders_crossbow", "syringegun_medic", "blutsauger", "proto_syringe", "ubersaw", "bonesaw", "amputator", "battleneedle", "solemn_vow" };
        public static readonly string[] SNIPER_WEAPONS = { "machina", "sniperrifle", "the_classic", "pro_rifle", "bazaar_bargain", "tf_projectile_arrow", "awper_hand", "sydney_sleeper", "smg", "pro_smg", "club", "tribalkukri", "shahanshah", "bushwacka" };
        public static readonly string[] SPY_WEAPONS = { "spy_cicle", "knife", "eternal_reward", "big_earner", "kunai", "letranger", "revolver", "enforcer", "diamondback", "ambassador" };

        public struct Player
        {
            public string UserID;
            public string Name;
            public string UniqueID;
            public string Playtime;
            public string Ping;
            public string State;
            public Class Class;
            public Team Team;

            public Player(string pUserID, string pName, string pUniqueID, string pPlaytime, string pPing, string pState, Class pClass = Class.Unknown, Team pTeam = Team.Unknown)
            {
                UserID = pUserID;
                Name = pName;
                UniqueID = pUniqueID;
                Playtime = pPlaytime;
                Ping = pPing;
                State = pState;
                Class = pClass;
                Team = pTeam;
            }

            public override string ToString()
            {
                return Name + " - " + Class.ToString();
            }
        }

        public enum Class
        {
            Scout, Soldier, Pyro, Demoman, Heavy, Engineer, Medic, Sniper, Spy, Unknown
        }

        public enum Team
        {
            Red, Blu, Unknown
        }

        public static readonly string[] Taunts = { "Default", "Fresh Brewed Victory", "The High Five!", "Flippin' Awesome", "Square Dance", "Kazotsky Kick",
        "Conga", "Rock, Paper, Scissors", "The Director's Vision" };

        public static Class GetClassByWeapon(string pWeapon)
        {
            pWeapon = pWeapon.Trim();
            if (SCOUT_WEAPONS.Contains(pWeapon)) { return Class.Scout; }
            if (SOLDIER_WEAPONS.Contains(pWeapon)) { return Class.Soldier; }
            if (PYRO_WEAPONS.Contains(pWeapon)) { return Class.Pyro; }
            if (DEMO_WEAPONS.Contains(pWeapon)) { return Class.Demoman; }
            if (HEAVY_WEAPONS.Contains(pWeapon)) { return Class.Heavy; }
            if (ENGINEER_WEAPONS.Contains(pWeapon)) { return Class.Engineer; }
            if (MEDIC_WEAPONS.Contains(pWeapon)) { return Class.Medic; }
            if (SNIPER_WEAPONS.Contains(pWeapon)) { return Class.Sniper; }
            if (SPY_WEAPONS.Contains(pWeapon)) { return Class.Spy; }
            return Class.Unknown;
        }

        public static string GetTauntCommand(string pTaunt)
        {
            string tauntName = pTaunt.Trim();
            if (tauntName == "Default")
            {
                return "taunt";
            } else if (tauntName.StartsWith("Taunt: "))
            {
                return "taunt_by_name " + tauntName;
            } else
            {
                return "taunt_by_name Taunt: " + tauntName;
            }
        }
    }
}
