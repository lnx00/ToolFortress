namespace ToolFortress
{
    partial class MainMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.lblHomeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtConsoleInput = new System.Windows.Forms.TextBox();
            this.btnSendConsole = new MaterialSkin.Controls.MaterialButton();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cardLog = new MaterialSkin.Controls.MaterialCard();
            this.btnGamePicker = new MaterialSkin.Controls.MaterialButton();
            this.txtTFPath = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cardRcon = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnRconReconnect = new MaterialSkin.Controls.MaterialButton();
            this.txtRconIP = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRconPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtRconPort = new MaterialSkin.Controls.MaterialTextBox();
            this.mainTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.tfFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.mainTabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.cardLog.SuspendLayout();
            this.cardRcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabHome);
            this.mainTabControl.Controls.Add(this.tabConsole);
            this.mainTabControl.Controls.Add(this.tabSettings);
            this.mainTabControl.Depth = 0;
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabControl.Location = new System.Drawing.Point(0, 100);
            this.mainTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabControl.Multiline = true;
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(900, 450);
            this.mainTabControl.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.SystemColors.Control;
            this.tabHome.Controls.Add(this.lblHomeTitle);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(892, 424);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // lblHomeTitle
            // 
            this.lblHomeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHomeTitle.AutoSize = true;
            this.lblHomeTitle.Depth = 0;
            this.lblHomeTitle.Font = new System.Drawing.Font("Roboto", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblHomeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
            this.lblHomeTitle.Location = new System.Drawing.Point(310, 12);
            this.lblHomeTitle.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblHomeTitle.Name = "lblHomeTitle";
            this.lblHomeTitle.Size = new System.Drawing.Size(273, 58);
            this.lblHomeTitle.TabIndex = 0;
            this.lblHomeTitle.Text = "ToolFortress";
            // 
            // tabConsole
            // 
            this.tabConsole.BackColor = System.Drawing.SystemColors.Control;
            this.tabConsole.Controls.Add(this.materialCard1);
            this.tabConsole.Controls.Add(this.txtConsoleOutput);
            this.tabConsole.Location = new System.Drawing.Point(4, 22);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Size = new System.Drawing.Size(892, 424);
            this.tabConsole.TabIndex = 2;
            this.tabConsole.Text = "Console";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtConsoleInput);
            this.materialCard1.Controls.Add(this.btnSendConsole);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 375);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(892, 49);
            this.materialCard1.TabIndex = 5;
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.BackColor = System.Drawing.Color.White;
            this.txtConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleInput.Font = new System.Drawing.Font("Roboto", 20F);
            this.txtConsoleInput.Location = new System.Drawing.Point(8, 9);
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(731, 33);
            this.txtConsoleInput.TabIndex = 3;
            // 
            // btnSendConsole
            // 
            this.btnSendConsole.AutoSize = false;
            this.btnSendConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendConsole.Depth = 0;
            this.btnSendConsole.DrawShadows = true;
            this.btnSendConsole.HighEmphasis = true;
            this.btnSendConsole.Icon = null;
            this.btnSendConsole.Location = new System.Drawing.Point(746, 9);
            this.btnSendConsole.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendConsole.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendConsole.Name = "btnSendConsole";
            this.btnSendConsole.Size = new System.Drawing.Size(137, 33);
            this.btnSendConsole.TabIndex = 2;
            this.btnSendConsole.Text = "Send";
            this.btnSendConsole.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSendConsole.UseAccentColor = false;
            this.btnSendConsole.UseVisualStyleBackColor = true;
            this.btnSendConsole.Click += new System.EventHandler(this.btnSendConsole_Click);
            // 
            // txtConsoleOutput
            // 
            this.txtConsoleOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txtConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtConsoleOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsoleOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsoleOutput.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtConsoleOutput.Location = new System.Drawing.Point(0, 0);
            this.txtConsoleOutput.Multiline = true;
            this.txtConsoleOutput.Name = "txtConsoleOutput";
            this.txtConsoleOutput.ReadOnly = true;
            this.txtConsoleOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsoleOutput.Size = new System.Drawing.Size(892, 424);
            this.txtConsoleOutput.TabIndex = 4;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabSettings.Controls.Add(this.cardLog);
            this.tabSettings.Controls.Add(this.cardRcon);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(892, 424);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // cardLog
            // 
            this.cardLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardLog.Controls.Add(this.btnGamePicker);
            this.cardLog.Controls.Add(this.txtTFPath);
            this.cardLog.Controls.Add(this.materialLabel2);
            this.cardLog.Depth = 0;
            this.cardLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardLog.Location = new System.Drawing.Point(14, 266);
            this.cardLog.Margin = new System.Windows.Forms.Padding(14);
            this.cardLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardLog.Name = "cardLog";
            this.cardLog.Padding = new System.Windows.Forms.Padding(14);
            this.cardLog.Size = new System.Drawing.Size(369, 139);
            this.cardLog.TabIndex = 6;
            // 
            // btnGamePicker
            // 
            this.btnGamePicker.AutoSize = false;
            this.btnGamePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGamePicker.Depth = 0;
            this.btnGamePicker.DrawShadows = true;
            this.btnGamePicker.HighEmphasis = true;
            this.btnGamePicker.Icon = null;
            this.btnGamePicker.Location = new System.Drawing.Point(17, 97);
            this.btnGamePicker.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGamePicker.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGamePicker.Name = "btnGamePicker";
            this.btnGamePicker.Size = new System.Drawing.Size(335, 32);
            this.btnGamePicker.TabIndex = 5;
            this.btnGamePicker.Text = "Select...";
            this.btnGamePicker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnGamePicker.UseAccentColor = false;
            this.btnGamePicker.UseVisualStyleBackColor = true;
            this.btnGamePicker.Click += new System.EventHandler(this.btnGamePicker_Click);
            // 
            // txtTFPath
            // 
            this.txtTFPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTFPath.Depth = 0;
            this.txtTFPath.DetectUrls = false;
            this.txtTFPath.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtTFPath.Hint = "Team Fortress 2 Folder";
            this.txtTFPath.Location = new System.Drawing.Point(17, 41);
            this.txtTFPath.MaxLength = 200;
            this.txtTFPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTFPath.Multiline = false;
            this.txtTFPath.Name = "txtTFPath";
            this.txtTFPath.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtTFPath.Size = new System.Drawing.Size(335, 50);
            this.txtTFPath.TabIndex = 5;
            this.txtTFPath.Text = "G:\\Steam\\steamapps\\common\\Team Fortress 2\\";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(20, 14);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(54, 24);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Game";
            // 
            // cardRcon
            // 
            this.cardRcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardRcon.Controls.Add(this.materialLabel1);
            this.cardRcon.Controls.Add(this.btnRconReconnect);
            this.cardRcon.Controls.Add(this.txtRconIP);
            this.cardRcon.Controls.Add(this.txtRconPassword);
            this.cardRcon.Controls.Add(this.txtRconPort);
            this.cardRcon.Depth = 0;
            this.cardRcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardRcon.Location = new System.Drawing.Point(14, 14);
            this.cardRcon.Margin = new System.Windows.Forms.Padding(14);
            this.cardRcon.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardRcon.Name = "cardRcon";
            this.cardRcon.Padding = new System.Windows.Forms.Padding(14);
            this.cardRcon.Size = new System.Drawing.Size(369, 224);
            this.cardRcon.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(78, 41);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Rcon";
            // 
            // btnRconReconnect
            // 
            this.btnRconReconnect.AutoSize = false;
            this.btnRconReconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRconReconnect.Depth = 0;
            this.btnRconReconnect.DrawShadows = true;
            this.btnRconReconnect.HighEmphasis = true;
            this.btnRconReconnect.Icon = null;
            this.btnRconReconnect.Location = new System.Drawing.Point(17, 171);
            this.btnRconReconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRconReconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRconReconnect.Name = "btnRconReconnect";
            this.btnRconReconnect.Size = new System.Drawing.Size(335, 32);
            this.btnRconReconnect.TabIndex = 4;
            this.btnRconReconnect.Text = "Reconnect";
            this.btnRconReconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnRconReconnect.UseAccentColor = true;
            this.btnRconReconnect.UseVisualStyleBackColor = true;
            this.btnRconReconnect.Click += new System.EventHandler(this.btnRconReconnect_Click);
            // 
            // txtRconIP
            // 
            this.txtRconIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRconIP.Depth = 0;
            this.txtRconIP.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRconIP.Hint = "IP-Adress";
            this.txtRconIP.Location = new System.Drawing.Point(17, 58);
            this.txtRconIP.MaxLength = 20;
            this.txtRconIP.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRconIP.Multiline = false;
            this.txtRconIP.Name = "txtRconIP";
            this.txtRconIP.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtRconIP.Size = new System.Drawing.Size(238, 50);
            this.txtRconIP.TabIndex = 0;
            this.txtRconIP.Text = "127.0.0.1";
            // 
            // txtRconPassword
            // 
            this.txtRconPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRconPassword.Depth = 0;
            this.txtRconPassword.DetectUrls = false;
            this.txtRconPassword.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRconPassword.Hint = "Password";
            this.txtRconPassword.Location = new System.Drawing.Point(17, 114);
            this.txtRconPassword.MaxLength = 100;
            this.txtRconPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRconPassword.Multiline = false;
            this.txtRconPassword.Name = "txtRconPassword";
            this.txtRconPassword.Password = true;
            this.txtRconPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtRconPassword.Size = new System.Drawing.Size(335, 50);
            this.txtRconPassword.TabIndex = 3;
            this.txtRconPassword.Text = "abc";
            // 
            // txtRconPort
            // 
            this.txtRconPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRconPort.Depth = 0;
            this.txtRconPort.DetectUrls = false;
            this.txtRconPort.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtRconPort.Hint = "Port";
            this.txtRconPort.Location = new System.Drawing.Point(261, 58);
            this.txtRconPort.MaxLength = 5;
            this.txtRconPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRconPort.Multiline = false;
            this.txtRconPort.Name = "txtRconPort";
            this.txtRconPort.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtRconPort.Size = new System.Drawing.Size(91, 50);
            this.txtRconPort.TabIndex = 2;
            this.txtRconPort.Text = "2541";
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.BaseTabControl = this.mainTabControl;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mainTabSelector.Location = new System.Drawing.Point(0, 64);
            this.mainTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.mainTabSelector.Name = "mainTabSelector";
            this.mainTabSelector.Size = new System.Drawing.Size(900, 30);
            this.mainTabSelector.TabIndex = 1;
            this.mainTabSelector.Text = "materialTabSelector1";
            // 
            // tfFolderBrowser
            // 
            this.tfFolderBrowser.Description = "Select your \"Team Fortress 2\" Folder...";
            this.tfFolderBrowser.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.mainTabSelector);
            this.Controls.Add(this.mainTabControl);
            this.DrawerTabControl = this.mainTabControl;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolFortress";
            this.TopMost = true;
            this.mainTabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.cardLog.ResumeLayout(false);
            this.cardLog.PerformLayout();
            this.cardRcon.ResumeLayout(false);
            this.cardRcon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl mainTabControl;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabSettings;
        private MaterialSkin.Controls.MaterialTabSelector mainTabSelector;
        private MaterialSkin.Controls.MaterialTextBox txtRconIP;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtRconPassword;
        private MaterialSkin.Controls.MaterialTextBox txtRconPort;
        private System.Windows.Forms.TabPage tabConsole;
        private MaterialSkin.Controls.MaterialButton btnSendConsole;
        private MaterialSkin.Controls.MaterialButton btnRconReconnect;
        private System.Windows.Forms.TextBox txtConsoleInput;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private MaterialSkin.Controls.MaterialLabel lblHomeTitle;
        private MaterialSkin.Controls.MaterialCard cardLog;
        private MaterialSkin.Controls.MaterialTextBox txtTFPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard cardRcon;
        private MaterialSkin.Controls.MaterialButton btnGamePicker;
        private System.Windows.Forms.FolderBrowserDialog tfFolderBrowser;
    }
}

