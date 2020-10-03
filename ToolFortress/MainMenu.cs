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

namespace ToolFortress
{
    public partial class MainMenu : MaterialForm
    {
        private bool retryConnection = false;

        public MainMenu()
        {
            InitializeComponent();

            // Initilaize Material Skin
            MaterialSkinManager msManager = MaterialSkinManager.Instance;
            msManager.AddFormToManage(this);
            msManager.Theme = MaterialSkinManager.Themes.LIGHT;
            msManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Pink200, TextShade.WHITE);

            // Check if TF2 is already running
            if (Process.GetProcessesByName("hl2").Length > 0)
            {
                btnStartGame.Enabled = false;
                MessageBox.Show("You need to start ToolFortress before Team Fortress 2.\nThis program will most likely not work.", "ToolFortress", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Load Settings
            txtRconIP.Text = Settings.RCON_IP;
            txtRconPort.Text = Settings.RCON_PORT.ToString();
            txtRconPassword.Text = Settings.RCON_PASSWORD;
            txtTFPath.Text = Settings.TF2_FOLDER;
            txtSteamID3.Text = Settings.TF2_STEAMID3;
            chkMirrorConsole.Checked = Settings.F_CONSOLE_MIRROR;
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
                + " +con_timestamp 1 +alias con_timestamp"
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
            Game.RconClient.Disconnect();
            Game.LogReader.Stop();
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

        private void Connected()
        {
            Game.LogParser.OnKillFeed += (kf) =>
            {
                Console.WriteLine("[KILL] " + kf.Killer + " killed " + kf.Target + " with " + kf.Weapon + ", Crit: " + ((kf.Crit) ? "Yes" : "No"));
            };
        }

        private void chkMirrorConsole_CheckedChanged(object sender, EventArgs e)
        {
            Settings.F_CONSOLE_MIRROR = chkMirrorConsole.Checked;
        }
    }
}
