using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TFRcon;
using System.Threading;
using ToolFortress.TF2;
using ToolFortress.Modules;
using static ToolFortress.TF2.Interpreter;
using System.IO;

namespace ToolFortress
{
    public partial class MainMenu : MaterialForm
    {
        private bool retryConnection = false;
        private MaterialSkinManager msManager = MaterialSkinManager.Instance;

        // Modules
        private CommandModule commandModule = new CommandModule();
        private KillsayModule killsayModule = new KillsayModule();
        private StatTrakModule statTrakModule = new StatTrakModule();
        private ClassPeekModule classPeekModule = new ClassPeekModule();
        private CommandSpamModule cmdSpamModule = new CommandSpamModule();
        private ConnectModule connectModule = new ConnectModule();
        private PointFarmModule farmModule = new PointFarmModule();
        private BotDetectorModule bdModule = new BotDetectorModule();

        public MainMenu()
        {
            Thread.Sleep(1000);
            InitializeComponent();

            // Initilaize Material Skin
            msManager.AddFormToManage(this);

            // Check if TF2 is already running
            if (Process.GetProcessesByName("hl2").Length > 0)
            {
                btnStartGame.Enabled = false;
                MessageBox.Show("You need to start ToolFortress before Team Fortress 2.\nThis program will most likely not work.", "ToolFortress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Load Settings
            Settings.Load();
            if (String.IsNullOrEmpty(Settings.TF2_FOLDER) || !Directory.Exists(Settings.TF2_FOLDER))
            {
                SetupDialog setupDialog = new SetupDialog();
                setupDialog.ShowDialog();
                Settings.TF2_FOLDER = setupDialog.TfPath;
                Settings.TF2_STEAMID3 = setupDialog.SteamID;
                Settings.Save();
                setupDialog.Dispose();
            }

            txtRconIP.Text = Settings.RCON_IP;
            txtRconPort.Text = Settings.RCON_PORT.ToString();
            txtRconPassword.Text = Settings.RCON_PASSWORD;
            txtTFPath.Text = Settings.TF2_FOLDER;
            txtSteamID3.Text = Settings.TF2_STEAMID3;
            chkMirrorConsole.Checked = Settings.F_CONSOLE_MIRROR;
            comboTheme.SelectedIndex = Settings.F_THEME_ID;

            txtBdEnemyMsg.Text = Settings.M_BD_ENEMYMSG;
            txtBdTeamMessage.Text = Settings.M_BD_TEAMMSG;

            if (Settings.FB_USERNAME.Length < 3)
            {
                Settings.FB_USERNAME = "Guest #" + new Random().Next(100, 999);
            }
            txtConnectName.Text = Settings.FB_USERNAME;

            // Load constants
            comboKillsayTaunt.DataSource = Interpreter.Taunts;
            comboCnTaunt.DataSource = Interpreter.Taunts;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Initialize LogReader
            Game.LogReader.OnLogUpdate += OnLogMessage;
            Game.LogReader.Start();

            // Initialize RconClient
            retryConnection = true;
            progRconConnect.Visible = true;
            Thread rconThread = new Thread(TryRconConnection);
            rconThread.Start();
        }

        /* Run TF2 with the required args */
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Start TF2 and start a Rcon-Server
            Process.Start("steam://run/440//"
                + " -usercon"
                + " +developer 1 +alias developer"
                + " +contimes 0 +alias contimes"
                + " +ip 0.0.0.0 +alias ip"
                + " +sv_rcon_whitelist_address " + Settings.RCON_IP + " +alias sv_rcon_whitelist_address"
                + " +sv_quota_stringcmdspersecond 1000000 +alias sv_quota_stringcmdspersecond"
                + " +rcon_password " + Settings.RCON_PASSWORD + " +alias rcon_password"
                + " +hostport " + Settings.RCON_PORT + " +alias hostport"
                + " +alias cl_reload_localization_files"
                + " +net_start"
                + " +con_timestamp 0 +alias con_timestamp"
                + " +con_logfile console.log"
                + " -condebug"
                + " -conclearlog");
        }

        private void OnLogMessage(string line)
        {
            if (Settings.F_CONSOLE_MIRROR)
            {
                try
                {
                    txtConsoleOutput.Invoke((MethodInvoker)delegate
                    {
                        txtConsoleOutput.AppendText("[<] " + line + "\r\n");
                    });
                }
                catch (Exception) { }
            }
        }

        private void btnSendConsole_Click(object sender, EventArgs e)
        {
            SendConsoleCommand(txtConsoleInput.Text);
        }

        private void txtConsoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendConsoleCommand(txtConsoleInput.Text);
            }
        }

        private void SendConsoleCommand(string pCommand)
        {
            txtConsoleOutput.AppendText("[>] " + txtConsoleInput.Text + "\r\n");

            // Send command and split response for correct formatting
            string conResponse = Game.SendCommand(txtConsoleInput.Text);
            if (!String.IsNullOrEmpty(conResponse))
            {
                string[] resLines = conResponse.Split('\n');
                foreach (string line in resLines)
                {
                    txtConsoleOutput.AppendText("[<] " + line + "\r\n");
                }
            }
        }

        private void btnRconReconnect_Click(object sender, EventArgs e)
        {
            // Reconnect to the game
            Game.RconClient.Reconnect(txtRconIP.Text, ushort.Parse(txtRconPort.Text), txtRconPassword.Text);
        }

        private void btnGamePicker_Click(object sender, EventArgs e)
        {
            // Open the FolderBrowserDialog to choose the TF2-Folder
            if (tfFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtTFPath.Text = tfFolderBrowser.SelectedPath;
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop all Modules
            commandModule.Disable();
            killsayModule.Disable();
            statTrakModule.Disable();
            classPeekModule.Disable();
            cmdSpamModule.Disable();
            connectModule.Disable();
            farmModule.Disable();
            bdModule.Disable();

            // Stop all Threads and disconnect from the game
            retryConnection = false;
            Game.Disconnect();
        }

        /* Retry Rcon connection until it succeeds */
        private void TryRconConnection()
        {
            // Try to connect to the game
            while (retryConnection)
            {
                // Check if tf2 is running. There is no reason to connect to the game if it isn't running
                if (Process.GetProcessesByName("hl2").Length > 0)
                {
                    // Show ProgressBar
                    progRconConnect.Invoke((MethodInvoker)delegate
                    {
                        progRconConnect.Visible = true;
                        btnStartGame.Enabled = false;
                    });

                    try
                    {
                        // Check Rcon connection
                        if (Game.RconClient.Connect(Settings.RCON_IP, Settings.RCON_PORT, Settings.RCON_PASSWORD))
                        {
                            retryConnection = false;
                            progRconConnect.Invoke((MethodInvoker)delegate
                            {
                                progRconConnect.Visible = false;
                                mainTabSelector.Enabled = true;
                                Connected();
                            });

                            break;
                        }
                    }
                    catch (Exception) { }
                } else
                {
                    // TF2 is no longer running. Hide the progress bar
                    progRconConnect.Invoke((MethodInvoker)delegate
                    {
                        progRconConnect.Visible = false;
                        btnStartGame.Enabled = true;
                    });
                }

                Thread.Sleep(1500);
            }
        }

        /* Initlilize Tools (Rcon successfull) */
        private void Connected()
        {
            Game.StartInfoRequest();

            // Enable Modules
            commandModule.Enable();
            statTrakModule.Enable();

            // Stat Tracker Update
            statTrakModule.OnStatUpdate += (kills, deaths) =>
            {
                lblKillCount.Invoke((MethodInvoker)delegate
                {
                    lblKillCount.Text = kills.Count.ToString();
                    lblDeathCounter.Text = deaths.Count.ToString();
                    if (kills.Count > 0 && deaths.Count > 0)
                    {
                        lblKDCounter.Text = Math.Round((double)(kills.Count / deaths.Count), 2).ToString();
                    }
                });
            };

            // Class Peek Update
            classPeekModule.OnClassUpdate += (playerList) =>
            {
                lvClassPeek.Invoke((MethodInvoker)delegate
                {
                    List<ListViewItem> lvItemList = new List<ListViewItem>();
                    foreach (Player p in playerList)
                    {
                        ListViewItem item = new ListViewItem(new String[] { p.Name, p.Class.ToString(), p.Playtime, p.State, p.Ping });
                        item.BackColor = (p.Team == Team.Unknown) ? Color.Gray : ((p.Team == Team.Red) ? Color.Red : Color.Blue);
                        lvItemList.Add(item);
                    }

                    lvClassPeek.Items.Clear();
                    lvClassPeek.Items.AddRange(lvItemList.ToArray());
                });
            };
        }

        private void chkMirrorConsole_CheckedChanged(object sender, EventArgs e)
        {
            Settings.F_CONSOLE_MIRROR = chkMirrorConsole.Checked;
        }

        private void comboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTheme(comboTheme.SelectedIndex);
        }

        /* Change UI Theme */
        private void SetTheme(int pThemeID)
        {
            switch (pThemeID)
            {
                case 0:
                    msManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    msManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.Pink200, TextShade.WHITE);
                    break;

                case 1:
                    msManager.Theme = MaterialSkinManager.Themes.LIGHT;
                    msManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Pink200, TextShade.WHITE);
                    break;

                case 2:
                    msManager.Theme = MaterialSkinManager.Themes.DARK;
                    msManager.ColorScheme = new ColorScheme(Primary.BlueGrey600, Primary.BlueGrey700, Primary.BlueGrey300, Accent.Red400, TextShade.WHITE);
                    break;
            }
        }

        /* Toggle ClassPeek Module */
        private void chkClassPeek_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClassPeek.Checked)
            {
                classPeekModule.Enable();
            } else
            {
                classPeekModule.Disable();
            }
        }

        private void btnClearStats_Click(object sender, EventArgs e)
        {
            statTrakModule.Reset();
            lblKDCounter.Text = "0";
        }

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            mainTabControl.SelectedTab = tabSettings;
        }

        /* Save Settings */
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.RCON_IP = txtRconIP.Text;
            Settings.RCON_PORT = ushort.Parse(txtRconPort.Text);
            Settings.RCON_PASSWORD = txtRconPassword.Text;

            Settings.TF2_FOLDER = txtTFPath.Text;
            Settings.TF2_STEAMID3 = txtSteamID3.Text;

            Settings.F_CONSOLE_MIRROR = chkMirrorConsole.Checked;
            Settings.F_THEME_ID = comboTheme.SelectedIndex;

            Settings.FB_USERNAME = txtConnectName.Text;
            Settings.Save();
        }

        private void btnSvTaunt_Click(object sender, EventArgs e)
        {
            connectModule.BroadcastMessage("cmd", Interpreter.GetTauntCommand(comboCnTaunt.SelectedItem.ToString()));
        }

        // Toggle Chatspam Module
        private void chkSpamEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpamEnable.Checked)
            {
                cmdSpamModule.Enable();
            } else
            {
                cmdSpamModule.Disable();
            }
        }

        private void txtSpamCommand_TextChanged(object sender, EventArgs e)
        {
            Settings.M_SPAM_COMMAND = txtSpamCommand.Text;
        }

        private void trackSpamSpeed_Scroll(object sender, EventArgs e)
        {
            Settings.M_SPAM_DELAY = trackSpamSpeed.Value;
        }

        /* Quit the game ("quit" command) */
        private void btnGameQuit_Click(object sender, EventArgs e)
        {
            Game.SendCommand("quit");
            mainTabControl.SelectedTab = tabHome;
            mainTabControl.Enabled = false;
            btnStartGame.Enabled = true;
            btnStartGame.Refresh();
        }

        /* Kill the game (End the Process) */
        private void btnGameKill_Click(object sender, EventArgs e)
        {
            try
            {
                Process.GetProcessesByName("hl2").First().Kill();
            } catch (Exception ex)
            {
                Console.WriteLine("Error @ KillGame: " + ex.Message);
            }

            mainTabControl.SelectedTab = tabHome;
            mainTabControl.Enabled = false;
            btnStartGame.Enabled = true;
            btnStartGame.Refresh();
        }

        #region Connect Features
        /* Toggle Connect-Feature */
        private void switchCnEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (switchCnEnable.Checked)
            {
                connectModule.Enable();
                connectModule.OnUserUpdate += UpdateUserList;
                pnlCnLobby.Enabled = true;
            } else
            {
                connectModule.Disable();
                connectModule.OnUserUpdate -= UpdateUserList;
                pnlCnLobby.Enabled = false;
                pnlCnTools.Enabled = false;
            }
        }

        /* Update Connect-Lobbys */
        private void UpdateLobbyList()
        {
            Dictionary<string, string> lobbyDict = connectModule.GetLobbys();
            if (lobbyDict.Count == 0) { return; }

            comboCnLobby.Invoke((MethodInvoker)delegate
            {
                comboCnLobby.DataSource = new BindingSource(lobbyDict, null);
                comboCnLobby.DisplayMember = "Value";
                comboCnLobby.ValueMember = "Key";
            });
        }

        private void UpdateUserList()
        {
            Dictionary<string, string> userDict = connectModule.GetUsers();
            listCnUsers.Invoke((MethodInvoker)delegate
            {
                listCnUsers.DataSource = new BindingSource(userDict, null);
                listCnUsers.DisplayMember = "Value";
                listCnUsers.ValueMember = "Key";
            });
        }

        private void btnCnJoin_Click(object sender, EventArgs e)
        {
            connectModule.JoinLobby((string) comboCnLobby.SelectedValue);

            pnlCnTools.Enabled = true;
            btnCnDestroy.Enabled = true;
        }

        private void btnCnCreate_Click(object sender, EventArgs e)
        {
            string lobbyName = "Lobby #" + new Random().Next(100, 999);
            connectModule.CreateLobby(lobbyName);
            Console.WriteLine("Creating: " + lobbyName);

            UpdateLobbyList();
            connectModule.GetUsers();

            pnlCnTools.Enabled = true;
            btnCnDestroy.Enabled = true;
        }

        private void comboCnLobby_MouseDown(object sender, MouseEventArgs e)
        {
            UpdateLobbyList();
        }

        private void btnCnDisonnect_Click(object sender, EventArgs e)
        {
            connectModule.Disconnect();
            pnlCnTools.Enabled = false;
            btnCnDestroy.Enabled = false;
            listCnUsers.DataSource = null;
            listCnUsers.Refresh();
        }

        private void btnCnDestroy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will disconnect you and destroy the current Lobby.", "Are you sure?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                connectModule.DestroyLobby();
                pnlCnTools.Enabled = false;
                btnCnDestroy.Enabled = false;
                listCnUsers.DataSource = null;
                listCnUsers.Refresh();
            }
        }

        private void btnCnMessage_Click(object sender, EventArgs e)
        {
            Game.SendPartyMessage("Saying '" + txtCnMessage.Text + "' on all clients...");
            connectModule.BroadcastMessage("say", txtCnMessage.Text);
        }

        private void btnCnLeaveMatch_Click(object sender, EventArgs e)
        {
            connectModule.BroadcastMessage("cmd", "disconnect");
        }

        private void btnCnInviteParty_Click(object sender, EventArgs e)
        {
            connectModule.BroadcastMessage("cmd", "tf_party_request_join_user " + Utils.ConvertToID64(Settings.TF2_STEAMID3));
        }
        #endregion

        #region Misc Features
        private void btnMiscVote1_Click(object sender, EventArgs e)
        {
            Game.SendCommand("next_map_vote 0");
        }

        private void btnMiscVote2_Click(object sender, EventArgs e)
        {
            Game.SendCommand("next_map_vote 1");
        }

        private void btnMiscVote3_Click(object sender, EventArgs e)
        {
            Game.SendCommand("next_map_vote 2");
        }

        private void comboMiscExec_MouseDown(object sender, MouseEventArgs e)
        {
            comboMiscExec.Items.Clear();

            string[] scriptFiles = Directory.GetFiles(Settings.TF2_FOLDER + @"\tf\cfg\", "*.cfg");
            foreach (string file in scriptFiles)
            {
                comboMiscExec.Items.Add(Path.GetFileName(file));
            }
        }

        private void btnMiscExec_Click(object sender, EventArgs e)
        {
            string response = Game.SendCommand("exec " + comboMiscExec.SelectedItem.ToString());
            if (!String.IsNullOrEmpty(response))
            {
                Game.SendPartyMessage(response);
            }
        }

        private void chkMiscPointsMode_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_POINTFARM_MODE = chkMiscPointsMode.Checked;
        }

        private void chkMiscPoints_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMiscPoints.Checked)
            {
                farmModule.Enable();
            }
            else
            {
                farmModule.Disable();
            }
        }

        private void chkMiscMath_CheckedChanged(object sender, EventArgs e)
        {
            Settings.F_SOLVE_MATH = chkMiscMath.Checked;
        }

        private void chkMiscMathLegit_CheckedChanged(object sender, EventArgs e)
        {
            Settings.F_SOLVE_MATH_LEGIT = chkMiscMathLegit.Checked;
        }
        #endregion

        #region Fun Features
        /* Toogle Killsay Module */
        private void chkFunKillsay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFunKillsay.Checked)
            {
                killsayModule.Enable();
            }
            else
            {
                killsayModule.Disable();
            }
        }

        private void chkKillsayKill_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_KILL = chkKillsayKill.Checked;
        }

        private void chkKillsayDeath_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_DEATH = chkKillsayDeath.Checked;
        }

        private void chkKillsayCrit_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_CRITONLY = chkKillsayCrit.Checked;
        }

        private void txtKillsayMsg_TextChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_KILLMSG = txtKillsayMsg.Text;
        }

        private void txtKillsayDeathMsg_TextChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_DEATHMSG = txtKillsayDeathMsg.Text;
        }

        private void chkKillsayClass_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_CLASSONLY = chkKillsayClass.Checked;
            comboKillsayClass.Enabled = chkKillsayClass.Checked;
        }

        private void comboKillsayClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_CLASS = (Class)comboKillsayClass.SelectedIndex;
        }

        private void chkKillsayTaunt_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_TAUNTKILL = chkKillsayTaunt.Checked;
            comboKillsayTaunt.Enabled = chkKillsayTaunt.Checked;
        }

        private void comboKillsayTaunt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_TAUNT = comboKillsayTaunt.SelectedItem.ToString();
        }
        #endregion

        #region Bot-Detector Features
        private void trackBdDelay_Scroll(object sender, EventArgs e)
        {
            Settings.M_BD_DELAY = trackBdDelay.Value * 1000;
            lblBdDelay.Text = "Message Interval: " + trackBdDelay.Value + " seconds";
        }

        private void chkBdVotekick_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_BD_VOTEKICK = chkBdVotekick.Checked;
        }

        private void chkBdNotfiy_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_BD_ENEMYNOTIFY = chkBdNotfiy.Checked;
        }

        private void chkBdNotifyTeam_CheckedChanged(object sender, EventArgs e)
        {
            Settings.M_BD_TEAMNOTIFY = chkBdNotifyTeam.Checked;
        }

        private void btnBdReset_Click(object sender, EventArgs e)
        {
            bdModule.Reset();
            listBdLog.Items.Clear();
        }

        private void chkBdEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBdEnable.Checked)
            {
                bdModule.OnLogUpdate += PrintBDMessage;
                bdModule.Enable();
            }
            else
            {
                bdModule.OnLogUpdate -= PrintBDMessage;
                bdModule.Disable();
                listBdLog.Items.Clear();
            }

            cardBdTools.Enabled = chkBdEnable.Checked;
        }

        private void PrintBDMessage(string message)
        {
            listBdLog.Invoke((MethodInvoker)delegate
            {
                listBdLog.Items.Add(message);
            });
        }
        #endregion

        private void txtConnectName_TextChanged(object sender, EventArgs e)
        {
            if (txtConnectName.Text.Length > 3)
            {
                Settings.FB_USERNAME = txtConnectName.Text;
            }
        }
    }
}
