using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using TFRcon;

namespace ToolFortress
{
    public partial class MainMenu : MaterialForm
    {
        private RconClient rconClient;

        public MainMenu()
        {
            InitializeComponent();

            // Initilaize Material Skin
            MaterialSkinManager msManager = MaterialSkinManager.Instance;
            msManager.AddFormToManage(this);
            msManager.Theme = MaterialSkinManager.Themes.LIGHT;
            msManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.LightBlue200, TextShade.WHITE);

            // Initialize RconClient
            rconClient = new RconClient(txtRconIP.Text, ushort.Parse(txtRconPort.Text), txtRconPassword.Text);
            rconClient.SendCommand("con_logfile console.log");
        }

        private void btnSendConsole_Click(object sender, EventArgs e)
        {
            txtConsoleOutput.AppendText("[>] " + txtConsoleInput.Text + "\r\n");

            try
            {
                string conResponse = rconClient.SendCommand(txtConsoleInput.Text);
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
            rconClient.Reconnect(txtRconIP.Text, ushort.Parse(txtRconPort.Text), txtRconPassword.Text);
        }

        private void btnGamePicker_Click(object sender, EventArgs e)
        {
            if (tfFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                txtTFPath.Text = tfFolderBrowser.SelectedPath;
            }
        }
    }
}
