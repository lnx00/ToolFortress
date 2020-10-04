using MaterialSkin.Controls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolFortress
{
    public partial class SetupDialog : MaterialForm
    {
        public string TfPath;
        public string SteamID;

        public SetupDialog()
        {
            InitializeComponent();
        }

        private void SetupDialog_Load(object sender, EventArgs e)
        {
            // Try to get the TF2 folder path
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam\ActiveProcess");
            if (key != null)
            {
                object activeUser = key.GetValue("ActiveUser");
                if (activeUser != null)
                {
                    txtSteamID.Text = "[U:1:" + activeUser.ToString() + "]";
                }
            }
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            if (tfFolderDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = tfFolderDialog.SelectedPath;
            }
        }

        private void SetupDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtFolderPath_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFolderPath.Text) && Regex.Match(txtSteamID.Text, Settings.REGEX_ID3).Success)
            {
                btnSave.Enabled = true;
            } else
            {
                btnSave.Enabled = false;
            }
        }

        private void txtSteamID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFolderPath.Text) && Regex.Match(txtSteamID.Text, Settings.REGEX_ID3).Success)
            {
                btnSave.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtFolderPath.Text) && Regex.Match(txtSteamID.Text, Settings.REGEX_ID3).Success)
            {
                TfPath = txtFolderPath.Text;
                SteamID = txtSteamID.Text;
                this.Close();
            }
            else
            {
                btnSave.Enabled = false;
                MessageBox.Show("Your settings are invalid! Please recheck them.", "Invalid Settings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
