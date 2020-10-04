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
        private TFConnect tfConnect = new TFConnect();

        // Modules
        private CommandModule commandModule = new CommandModule();
        private KillsayModule killsayModule = new KillsayModule();
        private StatTrakModule statTrakModule = new StatTrakModule();
        private ClassPeekModule classPeekModule = new ClassPeekModule();
        private CommandSpamModule cmdSpamModule = new CommandSpamModule();

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
            txtConsoleOutput.AppendText("[>] " + txtConsoleInput.Text + "\r\n");

            try
            {
                // Send command and split response for correct formatting
                string conResponse = Game.RconClient.SendCommand(txtConsoleInput.Text);
                string[] resLines = conResponse.Split('\n');
                foreach (string line in resLines)
                {
                    txtConsoleOutput.AppendText("[<] " + line + "\r\n");
                }
            } catch (Exception ex)
            {
                txtConsoleOutput.AppendText("[!] Failed to execute commands:\n" + ex.Message);
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
            // Stop all Threads and disconnect from the game
            retryConnection = false;
            tfConnect.Disconnect();
            Game.Disconnect();
        }

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

        private string Chiffre(string input, int stellen)
        {
            string output = string.Empty;

            foreach (char c in input)
            {
                char x = (char)(c + stellen);
                output += x.ToString();
            }

            return output;
        }

        private void Connected()
        {
            Game.StartInfoRequest();

            // Handle KillFeed event
            Game.LogParser.OnKillFeed += (kf) =>
            {
                listKillfeed.Invoke((MethodInvoker)delegate
                {
                    listKillfeed.Items.Add(kf.Killer + " killed " + kf.Target + " with " + kf.Weapon + (kf.Crit ? " (Crit)" : ""));
                });
            };

            Game.LogParser.OnChatMessage += (msg) =>
            {
                //Console.WriteLine("MSG: " + msg.Message + " by " + msg.Sender);
                if (msg.Message.StartsWith(" "))
                {
                    Game.SendPartyMessage(Chiffre(msg.Message.Substring(1), -3));
                }
            };

            // Handle modules
            commandModule.Enable();

            statTrakModule.Enable();
            statTrakModule.OnStatUpdate += (kills, deaths) =>
            {
                lblKillCount.Invoke((MethodInvoker)delegate {
                    lblKillCount.Text = kills.Count.ToString();
                    lblDeathCounter.Text = deaths.Count.ToString();
                    if (kills.Count > 0 && deaths.Count > 0)
                    {
                        lblKDCounter.Text = Math.Round((double)(kills.Count / deaths.Count), 2).ToString();
                    }
                });
            };

            classPeekModule.OnClassUpdate += (classList) =>
            {
                listClassPeek.Invoke((MethodInvoker)delegate
                {
                    listClassPeek.Items.Clear();
                    foreach (KeyValuePair<string, Class> player in classList)
                    {
                        listClassPeek.Items.Add(player.Key + " - " + player.Value.ToString());
                    }
                });
            };
        }

        private void chkMirrorConsole_CheckedChanged(object sender, EventArgs e)
        {
            Settings.F_CONSOLE_MIRROR = chkMirrorConsole.Checked;
        }

        // Change UI Theme
        private void comboTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboTheme.SelectedIndex)
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

        private void chkFunKillsay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFunKillsay.Checked)
            {
                killsayModule.Enable();
            } else
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
        }

        private void comboKillsayClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.M_KILLSAY_CLASS = (Class)comboKillsayClass.SelectedIndex;
        }

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
        }

        private void btnClearFeed_Click(object sender, EventArgs e)
        {
            listKillfeed.Items.Clear();
        }

        private void btnShowSettings_Click(object sender, EventArgs e)
        {
            Game.SendChatMessage(" " + Chiffre("Test lol", 3));
            mainTabControl.SelectedTab = tabSettings;
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Settings.RCON_IP = txtRconIP.Text;
            Settings.RCON_PORT = ushort.Parse(txtRconPort.Text);
            Settings.RCON_PASSWORD = txtRconPassword.Text;

            Settings.TF2_FOLDER = txtTFPath.Text;
            Settings.TF2_STEAMID3 = txtSteamID3.Text;

            Settings.F_CONSOLE_MIRROR = chkMirrorConsole.Checked;
            Settings.F_THEME_ID = comboTheme.SelectedIndex;
        }

        private void btnSvConnect_Click(object sender, EventArgs e)
        {
            //tfConnect.Connect("185.239.236.169", 2063);
            if (tfConnect.Connect("127.0.0.1", 2063))
            {
                btnSvConnect.Enabled = false;
                btnSvDisconnect.Enabled = true;
            }

            tfConnect.OnNetworkData += (data) =>
            {
                if (data[0] == 3)
                {
                    string pText = Encoding.UTF8.GetString(data.Skip(2).Take(data[1]).ToArray());
                    Console.WriteLine("Broadcast: " + pText);
                } else if (data[0] == 4)
                {
                    int tauntID = data[2];
                    byte[] timeData = data.Skip(3).Take(data[1]).ToArray();
                    long binTime = BitConverter.ToInt64(timeData, 0);
                    DateTime tauntTime = DateTime.FromBinary(binTime);
                    Console.WriteLine("Taunt " + tauntID + " at " + tauntTime.ToString());

                    Game.RconClient.SendCommand("taunt");
                    Game.RconClient.SendCommand("say \"Tes" + Environment.NewLine + "t\"");
                }
            };
        }

        private void btnSvDisconnect_Click(object sender, EventArgs e)
        {
            if (tfConnect.Disconnect())
            {
                btnSvConnect.Enabled = true;
                btnSvDisconnect.Enabled = false;
            }
        }

        private void btnSvUsername_Click(object sender, EventArgs e)
        {
            tfConnect.SetUsername(txtSvUsername.Text);
        }

        private void btnSvTaunt_Click(object sender, EventArgs e)
        {
            byte selectedTaunt = (byte) comboSvTaunt.SelectedIndex;
            DateTime tauntTime = DateTime.Now.AddSeconds(5);
            long binTaunTime = tauntTime.ToBinary();

            byte[] timeData = BitConverter.GetBytes(binTaunTime);
            byte dataLength = (byte)(2 + timeData.Length);
            byte[] data = new byte[1024];
            data[0] = 4;
            data[1] = dataLength;
            data[2] = selectedTaunt;
            timeData.CopyTo(data, 3);
            tfConnect.SendData(data);
        }

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
    }
}
