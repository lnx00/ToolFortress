﻿namespace ToolFortress
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
            this.btnShowSettings = new MaterialSkin.Controls.MaterialButton();
            this.progRconConnect = new System.Windows.Forms.ProgressBar();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btnStartGame = new MaterialSkin.Controls.MaterialButton();
            this.lblHomeTitle = new MaterialSkin.Controls.MaterialLabel();
            this.tabFun = new System.Windows.Forms.TabPage();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.trackSpamSpeed = new System.Windows.Forms.TrackBar();
            this.chkSpamEnable = new MaterialSkin.Controls.MaterialSwitch();
            this.txtSpamCommand = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.comboKillsayClass = new MaterialSkin.Controls.MaterialComboBox();
            this.chkKillsayClass = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtKillsayDeathMsg = new MaterialSkin.Controls.MaterialTextBox();
            this.txtKillsayMsg = new MaterialSkin.Controls.MaterialTextBox();
            this.chkKillsayCrit = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkKillsayDeath = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkKillsayKill = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkFunKillsay = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.tabConnect = new System.Windows.Forms.TabPage();
            this.comboSvTaunt = new MaterialSkin.Controls.MaterialComboBox();
            this.btnSvTaunt = new MaterialSkin.Controls.MaterialButton();
            this.btnSvUsername = new MaterialSkin.Controls.MaterialButton();
            this.txtSvUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.listSvUsers = new System.Windows.Forms.ListBox();
            this.btnSvDisconnect = new MaterialSkin.Controls.MaterialButton();
            this.btnSvConnect = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.tabConsole = new System.Windows.Forms.TabPage();
            this.txtConsoleOutput = new System.Windows.Forms.TextBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtConsoleInput = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSendConsole = new MaterialSkin.Controls.MaterialButton();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.lblKDCounter = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.btnClearFeed = new MaterialSkin.Controls.MaterialButton();
            this.btnClearStats = new MaterialSkin.Controls.MaterialButton();
            this.listClassPeek = new System.Windows.Forms.ListBox();
            this.chkClassPeek = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblDeathCounter = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.lblKillCount = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.listKillfeed = new System.Windows.Forms.ListBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.btnSaveSettings = new MaterialSkin.Controls.MaterialFloatingActionButton();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.comboTheme = new MaterialSkin.Controls.MaterialComboBox();
            this.chkMirrorConsole = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.cardLog = new MaterialSkin.Controls.MaterialCard();
            this.txtSteamID3 = new MaterialSkin.Controls.MaterialTextBox();
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
            this.tabBotDetector = new System.Windows.Forms.TabPage();
            this.mainTabControl.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabFun.SuspendLayout();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpamSpeed)).BeginInit();
            this.materialCard3.SuspendLayout();
            this.tabConnect.SuspendLayout();
            this.tabConsole.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabStats.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.cardLog.SuspendLayout();
            this.cardRcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabHome);
            this.mainTabControl.Controls.Add(this.tabFun);
            this.mainTabControl.Controls.Add(this.tabConnect);
            this.mainTabControl.Controls.Add(this.tabStats);
            this.mainTabControl.Controls.Add(this.tabBotDetector);
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
            this.tabHome.Controls.Add(this.btnShowSettings);
            this.tabHome.Controls.Add(this.progRconConnect);
            this.tabHome.Controls.Add(this.materialLabel3);
            this.tabHome.Controls.Add(this.btnStartGame);
            this.tabHome.Controls.Add(this.lblHomeTitle);
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(892, 424);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            // 
            // btnShowSettings
            // 
            this.btnShowSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnShowSettings.AutoSize = false;
            this.btnShowSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowSettings.Depth = 0;
            this.btnShowSettings.DrawShadows = true;
            this.btnShowSettings.HighEmphasis = true;
            this.btnShowSettings.Icon = null;
            this.btnShowSettings.Location = new System.Drawing.Point(347, 158);
            this.btnShowSettings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnShowSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowSettings.Name = "btnShowSettings";
            this.btnShowSettings.Size = new System.Drawing.Size(198, 36);
            this.btnShowSettings.TabIndex = 5;
            this.btnShowSettings.Text = "Settings";
            this.btnShowSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnShowSettings.UseAccentColor = false;
            this.btnShowSettings.UseVisualStyleBackColor = true;
            this.btnShowSettings.Click += new System.EventHandler(this.btnShowSettings_Click);
            // 
            // progRconConnect
            // 
            this.progRconConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progRconConnect.Location = new System.Drawing.Point(347, 251);
            this.progRconConnect.MarqueeAnimationSpeed = 40;
            this.progRconConnect.Name = "progRconConnect";
            this.progRconConnect.Size = new System.Drawing.Size(198, 8);
            this.progRconConnect.Step = 1;
            this.progRconConnect.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progRconConnect.TabIndex = 4;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.Location = new System.Drawing.Point(347, 61);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(204, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Improve your TF2 experience";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartGame.AutoSize = false;
            this.btnStartGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStartGame.Depth = 0;
            this.btnStartGame.DrawShadows = true;
            this.btnStartGame.HighEmphasis = true;
            this.btnStartGame.Icon = null;
            this.btnStartGame.Location = new System.Drawing.Point(347, 206);
            this.btnStartGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStartGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(198, 36);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Start Team Fortress 2";
            this.btnStartGame.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStartGame.UseAccentColor = true;
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
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
            // tabFun
            // 
            this.tabFun.BackColor = System.Drawing.SystemColors.Control;
            this.tabFun.Controls.Add(this.materialCard4);
            this.tabFun.Controls.Add(this.materialCard3);
            this.tabFun.Location = new System.Drawing.Point(4, 22);
            this.tabFun.Name = "tabFun";
            this.tabFun.Size = new System.Drawing.Size(892, 424);
            this.tabFun.TabIndex = 4;
            this.tabFun.Text = "Fun";
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.trackSpamSpeed);
            this.materialCard4.Controls.Add(this.chkSpamEnable);
            this.materialCard4.Controls.Add(this.txtSpamCommand);
            this.materialCard4.Controls.Add(this.materialLabel13);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(460, 14);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(413, 137);
            this.materialCard4.TabIndex = 1;
            // 
            // trackSpamSpeed
            // 
            this.trackSpamSpeed.Location = new System.Drawing.Point(134, 84);
            this.trackSpamSpeed.Maximum = 2000;
            this.trackSpamSpeed.Minimum = 10;
            this.trackSpamSpeed.Name = "trackSpamSpeed";
            this.trackSpamSpeed.Size = new System.Drawing.Size(262, 45);
            this.trackSpamSpeed.SmallChange = 10;
            this.trackSpamSpeed.TabIndex = 12;
            this.trackSpamSpeed.Value = 1000;
            this.trackSpamSpeed.Scroll += new System.EventHandler(this.trackSpamSpeed_Scroll);
            // 
            // chkSpamEnable
            // 
            this.chkSpamEnable.AutoSize = true;
            this.chkSpamEnable.Depth = 0;
            this.chkSpamEnable.Location = new System.Drawing.Point(14, 84);
            this.chkSpamEnable.Margin = new System.Windows.Forms.Padding(0);
            this.chkSpamEnable.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSpamEnable.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSpamEnable.Name = "chkSpamEnable";
            this.chkSpamEnable.Ripple = true;
            this.chkSpamEnable.Size = new System.Drawing.Size(106, 37);
            this.chkSpamEnable.TabIndex = 11;
            this.chkSpamEnable.Text = "Enable";
            this.chkSpamEnable.UseVisualStyleBackColor = true;
            this.chkSpamEnable.CheckedChanged += new System.EventHandler(this.chkSpamEnable_CheckedChanged);
            // 
            // txtSpamCommand
            // 
            this.txtSpamCommand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSpamCommand.Depth = 0;
            this.txtSpamCommand.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSpamCommand.Hint = "Command";
            this.txtSpamCommand.Location = new System.Drawing.Point(17, 45);
            this.txtSpamCommand.MaxLength = 50;
            this.txtSpamCommand.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSpamCommand.Multiline = false;
            this.txtSpamCommand.Name = "txtSpamCommand";
            this.txtSpamCommand.Size = new System.Drawing.Size(379, 36);
            this.txtSpamCommand.TabIndex = 10;
            this.txtSpamCommand.Text = "";
            this.txtSpamCommand.UseTallSize = false;
            this.txtSpamCommand.TextChanged += new System.EventHandler(this.txtSpamCommand_TextChanged);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel13.Location = new System.Drawing.Point(17, 14);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(148, 24);
            this.materialLabel13.TabIndex = 1;
            this.materialLabel13.Text = "Command Spam";
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.comboKillsayClass);
            this.materialCard3.Controls.Add(this.chkKillsayClass);
            this.materialCard3.Controls.Add(this.materialLabel9);
            this.materialCard3.Controls.Add(this.txtKillsayDeathMsg);
            this.materialCard3.Controls.Add(this.txtKillsayMsg);
            this.materialCard3.Controls.Add(this.chkKillsayCrit);
            this.materialCard3.Controls.Add(this.chkKillsayDeath);
            this.materialCard3.Controls.Add(this.chkKillsayKill);
            this.materialCard3.Controls.Add(this.chkFunKillsay);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 14);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(418, 273);
            this.materialCard3.TabIndex = 0;
            // 
            // comboKillsayClass
            // 
            this.comboKillsayClass.AutoResize = false;
            this.comboKillsayClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboKillsayClass.Depth = 0;
            this.comboKillsayClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboKillsayClass.DropDownHeight = 118;
            this.comboKillsayClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKillsayClass.DropDownWidth = 121;
            this.comboKillsayClass.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboKillsayClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboKillsayClass.FormattingEnabled = true;
            this.comboKillsayClass.Hint = "Class";
            this.comboKillsayClass.IntegralHeight = false;
            this.comboKillsayClass.ItemHeight = 29;
            this.comboKillsayClass.Items.AddRange(new object[] {
            "Scout",
            "Soldier",
            "Pyro",
            "Demoman",
            "Heavy",
            "Engineer",
            "Medic",
            "Sniper",
            "Spy"});
            this.comboKillsayClass.Location = new System.Drawing.Point(21, 115);
            this.comboKillsayClass.MaxDropDownItems = 4;
            this.comboKillsayClass.MouseState = MaterialSkin.MouseState.OUT;
            this.comboKillsayClass.Name = "comboKillsayClass";
            this.comboKillsayClass.Size = new System.Drawing.Size(380, 35);
            this.comboKillsayClass.TabIndex = 9;
            this.comboKillsayClass.UseTallSize = false;
            this.comboKillsayClass.SelectedIndexChanged += new System.EventHandler(this.comboKillsayClass_SelectedIndexChanged);
            // 
            // chkKillsayClass
            // 
            this.chkKillsayClass.AutoSize = true;
            this.chkKillsayClass.Depth = 0;
            this.chkKillsayClass.Location = new System.Drawing.Point(117, 75);
            this.chkKillsayClass.Margin = new System.Windows.Forms.Padding(0);
            this.chkKillsayClass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkKillsayClass.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkKillsayClass.Name = "chkKillsayClass";
            this.chkKillsayClass.Ripple = true;
            this.chkKillsayClass.Size = new System.Drawing.Size(192, 37);
            this.chkKillsayClass.TabIndex = 8;
            this.chkKillsayClass.Text = "For Class (Death only)";
            this.chkKillsayClass.UseVisualStyleBackColor = true;
            this.chkKillsayClass.CheckedChanged += new System.EventHandler(this.chkKillsayClass_CheckedChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.FontType = MaterialSkin.MaterialSkinManager.fontType.Caption;
            this.materialLabel9.Location = new System.Drawing.Point(23, 245);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(196, 14);
            this.materialLabel9.TabIndex = 7;
            this.materialLabel9.Text = "Placeholder: %1 = Killer, %2 = Target";
            // 
            // txtKillsayDeathMsg
            // 
            this.txtKillsayDeathMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKillsayDeathMsg.Depth = 0;
            this.txtKillsayDeathMsg.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtKillsayDeathMsg.Hint = "Death Message";
            this.txtKillsayDeathMsg.Location = new System.Drawing.Point(21, 206);
            this.txtKillsayDeathMsg.MaxLength = 50;
            this.txtKillsayDeathMsg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKillsayDeathMsg.Multiline = false;
            this.txtKillsayDeathMsg.Name = "txtKillsayDeathMsg";
            this.txtKillsayDeathMsg.Size = new System.Drawing.Size(380, 36);
            this.txtKillsayDeathMsg.TabIndex = 6;
            this.txtKillsayDeathMsg.Text = "";
            this.txtKillsayDeathMsg.UseTallSize = false;
            this.txtKillsayDeathMsg.TextChanged += new System.EventHandler(this.txtKillsayDeathMsg_TextChanged);
            // 
            // txtKillsayMsg
            // 
            this.txtKillsayMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKillsayMsg.Depth = 0;
            this.txtKillsayMsg.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtKillsayMsg.Hint = "Kill Message";
            this.txtKillsayMsg.Location = new System.Drawing.Point(21, 164);
            this.txtKillsayMsg.MaxLength = 50;
            this.txtKillsayMsg.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKillsayMsg.Multiline = false;
            this.txtKillsayMsg.Name = "txtKillsayMsg";
            this.txtKillsayMsg.Size = new System.Drawing.Size(380, 36);
            this.txtKillsayMsg.TabIndex = 5;
            this.txtKillsayMsg.Text = "";
            this.txtKillsayMsg.UseTallSize = false;
            this.txtKillsayMsg.TextChanged += new System.EventHandler(this.txtKillsayMsg_TextChanged);
            // 
            // chkKillsayCrit
            // 
            this.chkKillsayCrit.AutoSize = true;
            this.chkKillsayCrit.Depth = 0;
            this.chkKillsayCrit.Location = new System.Drawing.Point(14, 75);
            this.chkKillsayCrit.Margin = new System.Windows.Forms.Padding(0);
            this.chkKillsayCrit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkKillsayCrit.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkKillsayCrit.Name = "chkKillsayCrit";
            this.chkKillsayCrit.Ripple = true;
            this.chkKillsayCrit.Size = new System.Drawing.Size(93, 37);
            this.chkKillsayCrit.TabIndex = 4;
            this.chkKillsayCrit.Text = "Crit only";
            this.chkKillsayCrit.UseVisualStyleBackColor = true;
            this.chkKillsayCrit.CheckedChanged += new System.EventHandler(this.chkKillsayCrit_CheckedChanged);
            // 
            // chkKillsayDeath
            // 
            this.chkKillsayDeath.AutoSize = true;
            this.chkKillsayDeath.Depth = 0;
            this.chkKillsayDeath.Location = new System.Drawing.Point(256, 38);
            this.chkKillsayDeath.Margin = new System.Windows.Forms.Padding(0);
            this.chkKillsayDeath.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkKillsayDeath.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkKillsayDeath.Name = "chkKillsayDeath";
            this.chkKillsayDeath.Ripple = true;
            this.chkKillsayDeath.Size = new System.Drawing.Size(145, 37);
            this.chkKillsayDeath.TabIndex = 3;
            this.chkKillsayDeath.Text = "Death Message";
            this.chkKillsayDeath.UseVisualStyleBackColor = true;
            this.chkKillsayDeath.CheckedChanged += new System.EventHandler(this.chkKillsayDeath_CheckedChanged);
            // 
            // chkKillsayKill
            // 
            this.chkKillsayKill.AutoSize = true;
            this.chkKillsayKill.Depth = 0;
            this.chkKillsayKill.Location = new System.Drawing.Point(117, 38);
            this.chkKillsayKill.Margin = new System.Windows.Forms.Padding(0);
            this.chkKillsayKill.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkKillsayKill.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkKillsayKill.Name = "chkKillsayKill";
            this.chkKillsayKill.Ripple = true;
            this.chkKillsayKill.Size = new System.Drawing.Size(125, 37);
            this.chkKillsayKill.TabIndex = 2;
            this.chkKillsayKill.Text = "Kill Message";
            this.chkKillsayKill.UseVisualStyleBackColor = true;
            this.chkKillsayKill.CheckedChanged += new System.EventHandler(this.chkKillsayKill_CheckedChanged);
            // 
            // chkFunKillsay
            // 
            this.chkFunKillsay.AutoSize = true;
            this.chkFunKillsay.Depth = 0;
            this.chkFunKillsay.Location = new System.Drawing.Point(14, 38);
            this.chkFunKillsay.Margin = new System.Windows.Forms.Padding(0);
            this.chkFunKillsay.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkFunKillsay.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkFunKillsay.Name = "chkFunKillsay";
            this.chkFunKillsay.Ripple = true;
            this.chkFunKillsay.Size = new System.Drawing.Size(83, 37);
            this.chkFunKillsay.TabIndex = 1;
            this.chkFunKillsay.Text = "Enable";
            this.chkFunKillsay.UseVisualStyleBackColor = true;
            this.chkFunKillsay.CheckedChanged += new System.EventHandler(this.chkFunKillsay_CheckedChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel7.Location = new System.Drawing.Point(17, 14);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(187, 24);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Kill/Death Messages";
            // 
            // tabConnect
            // 
            this.tabConnect.BackColor = System.Drawing.SystemColors.Control;
            this.tabConnect.Controls.Add(this.comboSvTaunt);
            this.tabConnect.Controls.Add(this.btnSvTaunt);
            this.tabConnect.Controls.Add(this.btnSvUsername);
            this.tabConnect.Controls.Add(this.txtSvUsername);
            this.tabConnect.Controls.Add(this.materialLabel12);
            this.tabConnect.Controls.Add(this.listSvUsers);
            this.tabConnect.Controls.Add(this.btnSvDisconnect);
            this.tabConnect.Controls.Add(this.btnSvConnect);
            this.tabConnect.Controls.Add(this.materialLabel10);
            this.tabConnect.Location = new System.Drawing.Point(4, 22);
            this.tabConnect.Name = "tabConnect";
            this.tabConnect.Size = new System.Drawing.Size(892, 424);
            this.tabConnect.TabIndex = 5;
            this.tabConnect.Text = "Connect";
            // 
            // comboSvTaunt
            // 
            this.comboSvTaunt.AutoResize = false;
            this.comboSvTaunt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboSvTaunt.Depth = 0;
            this.comboSvTaunt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboSvTaunt.DropDownHeight = 118;
            this.comboSvTaunt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSvTaunt.DropDownWidth = 121;
            this.comboSvTaunt.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboSvTaunt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboSvTaunt.FormattingEnabled = true;
            this.comboSvTaunt.Hint = "Sync Taunt";
            this.comboSvTaunt.IntegralHeight = false;
            this.comboSvTaunt.ItemHeight = 29;
            this.comboSvTaunt.Items.AddRange(new object[] {
            "Default",
            "Conga"});
            this.comboSvTaunt.Location = new System.Drawing.Point(8, 198);
            this.comboSvTaunt.MaxDropDownItems = 4;
            this.comboSvTaunt.MouseState = MaterialSkin.MouseState.OUT;
            this.comboSvTaunt.Name = "comboSvTaunt";
            this.comboSvTaunt.Size = new System.Drawing.Size(281, 35);
            this.comboSvTaunt.TabIndex = 9;
            this.comboSvTaunt.UseTallSize = false;
            // 
            // btnSvTaunt
            // 
            this.btnSvTaunt.AutoSize = false;
            this.btnSvTaunt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSvTaunt.Depth = 0;
            this.btnSvTaunt.DrawShadows = true;
            this.btnSvTaunt.HighEmphasis = true;
            this.btnSvTaunt.Icon = null;
            this.btnSvTaunt.Location = new System.Drawing.Point(8, 242);
            this.btnSvTaunt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSvTaunt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSvTaunt.Name = "btnSvTaunt";
            this.btnSvTaunt.Size = new System.Drawing.Size(281, 36);
            this.btnSvTaunt.TabIndex = 8;
            this.btnSvTaunt.Text = "Sync Taunt";
            this.btnSvTaunt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSvTaunt.UseAccentColor = false;
            this.btnSvTaunt.UseVisualStyleBackColor = true;
            this.btnSvTaunt.Click += new System.EventHandler(this.btnSvTaunt_Click);
            // 
            // btnSvUsername
            // 
            this.btnSvUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSvUsername.Depth = 0;
            this.btnSvUsername.DrawShadows = true;
            this.btnSvUsername.HighEmphasis = true;
            this.btnSvUsername.Icon = null;
            this.btnSvUsername.Location = new System.Drawing.Point(242, 135);
            this.btnSvUsername.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSvUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSvUsername.Name = "btnSvUsername";
            this.btnSvUsername.Size = new System.Drawing.Size(47, 36);
            this.btnSvUsername.TabIndex = 7;
            this.btnSvUsername.Text = "Set";
            this.btnSvUsername.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSvUsername.UseAccentColor = false;
            this.btnSvUsername.UseVisualStyleBackColor = true;
            this.btnSvUsername.Click += new System.EventHandler(this.btnSvUsername_Click);
            // 
            // txtSvUsername
            // 
            this.txtSvUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSvUsername.Depth = 0;
            this.txtSvUsername.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSvUsername.Hint = "Username";
            this.txtSvUsername.Location = new System.Drawing.Point(8, 135);
            this.txtSvUsername.MaxLength = 50;
            this.txtSvUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSvUsername.Multiline = false;
            this.txtSvUsername.Name = "txtSvUsername";
            this.txtSvUsername.Size = new System.Drawing.Size(227, 36);
            this.txtSvUsername.TabIndex = 6;
            this.txtSvUsername.Text = "";
            this.txtSvUsername.UseAccent = false;
            this.txtSvUsername.UseTallSize = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(730, 113);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(89, 19);
            this.materialLabel12.TabIndex = 4;
            this.materialLabel12.Text = "Online Users";
            // 
            // listSvUsers
            // 
            this.listSvUsers.FormattingEnabled = true;
            this.listSvUsers.Location = new System.Drawing.Point(662, 135);
            this.listSvUsers.Name = "listSvUsers";
            this.listSvUsers.Size = new System.Drawing.Size(222, 277);
            this.listSvUsers.TabIndex = 3;
            // 
            // btnSvDisconnect
            // 
            this.btnSvDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSvDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSvDisconnect.Depth = 0;
            this.btnSvDisconnect.DrawShadows = true;
            this.btnSvDisconnect.Enabled = false;
            this.btnSvDisconnect.HighEmphasis = true;
            this.btnSvDisconnect.Icon = null;
            this.btnSvDisconnect.Location = new System.Drawing.Point(479, 52);
            this.btnSvDisconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSvDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSvDisconnect.Name = "btnSvDisconnect";
            this.btnSvDisconnect.Size = new System.Drawing.Size(112, 36);
            this.btnSvDisconnect.TabIndex = 2;
            this.btnSvDisconnect.Text = "Disconnect";
            this.btnSvDisconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnSvDisconnect.UseAccentColor = false;
            this.btnSvDisconnect.UseVisualStyleBackColor = true;
            this.btnSvDisconnect.Click += new System.EventHandler(this.btnSvDisconnect_Click);
            // 
            // btnSvConnect
            // 
            this.btnSvConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSvConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSvConnect.Depth = 0;
            this.btnSvConnect.DrawShadows = true;
            this.btnSvConnect.HighEmphasis = true;
            this.btnSvConnect.Icon = null;
            this.btnSvConnect.Location = new System.Drawing.Point(302, 52);
            this.btnSvConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSvConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSvConnect.Name = "btnSvConnect";
            this.btnSvConnect.Size = new System.Drawing.Size(169, 36);
            this.btnSvConnect.TabIndex = 1;
            this.btnSvConnect.Text = "Connect to Server";
            this.btnSvConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSvConnect.UseAccentColor = false;
            this.btnSvConnect.UseVisualStyleBackColor = true;
            this.btnSvConnect.Click += new System.EventHandler(this.btnSvConnect_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel10.Location = new System.Drawing.Point(330, 17);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(233, 29);
            this.materialLabel10.TabIndex = 0;
            this.materialLabel10.Text = "ToolFortress Connect";
            // 
            // tabConsole
            // 
            this.tabConsole.BackColor = System.Drawing.SystemColors.Control;
            this.tabConsole.Controls.Add(this.txtConsoleOutput);
            this.tabConsole.Controls.Add(this.materialCard1);
            this.tabConsole.Location = new System.Drawing.Point(4, 22);
            this.tabConsole.Name = "tabConsole";
            this.tabConsole.Size = new System.Drawing.Size(892, 424);
            this.tabConsole.TabIndex = 2;
            this.tabConsole.Text = "Console";
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
            this.txtConsoleOutput.Size = new System.Drawing.Size(892, 355);
            this.txtConsoleOutput.TabIndex = 4;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtConsoleInput);
            this.materialCard1.Controls.Add(this.btnSendConsole);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 355);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(892, 69);
            this.materialCard1.TabIndex = 5;
            // 
            // txtConsoleInput
            // 
            this.txtConsoleInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConsoleInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConsoleInput.Depth = 0;
            this.txtConsoleInput.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtConsoleInput.Location = new System.Drawing.Point(8, 11);
            this.txtConsoleInput.MaxLength = 50;
            this.txtConsoleInput.MouseState = MaterialSkin.MouseState.OUT;
            this.txtConsoleInput.Multiline = false;
            this.txtConsoleInput.Name = "txtConsoleInput";
            this.txtConsoleInput.Size = new System.Drawing.Size(751, 50);
            this.txtConsoleInput.TabIndex = 3;
            this.txtConsoleInput.Text = "";
            // 
            // btnSendConsole
            // 
            this.btnSendConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendConsole.AutoSize = false;
            this.btnSendConsole.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSendConsole.Depth = 0;
            this.btnSendConsole.DrawShadows = true;
            this.btnSendConsole.HighEmphasis = true;
            this.btnSendConsole.Icon = null;
            this.btnSendConsole.Location = new System.Drawing.Point(766, 11);
            this.btnSendConsole.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSendConsole.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSendConsole.Name = "btnSendConsole";
            this.btnSendConsole.Size = new System.Drawing.Size(117, 47);
            this.btnSendConsole.TabIndex = 2;
            this.btnSendConsole.Text = "Send";
            this.btnSendConsole.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSendConsole.UseAccentColor = false;
            this.btnSendConsole.UseVisualStyleBackColor = true;
            this.btnSendConsole.Click += new System.EventHandler(this.btnSendConsole_Click);
            // 
            // tabStats
            // 
            this.tabStats.BackColor = System.Drawing.SystemColors.Control;
            this.tabStats.Controls.Add(this.lblKDCounter);
            this.tabStats.Controls.Add(this.materialLabel11);
            this.tabStats.Controls.Add(this.btnClearFeed);
            this.tabStats.Controls.Add(this.btnClearStats);
            this.tabStats.Controls.Add(this.listClassPeek);
            this.tabStats.Controls.Add(this.chkClassPeek);
            this.tabStats.Controls.Add(this.lblDeathCounter);
            this.tabStats.Controls.Add(this.materialLabel8);
            this.tabStats.Controls.Add(this.lblKillCount);
            this.tabStats.Controls.Add(this.materialLabel6);
            this.tabStats.Controls.Add(this.materialLabel4);
            this.tabStats.Controls.Add(this.listKillfeed);
            this.tabStats.Location = new System.Drawing.Point(4, 22);
            this.tabStats.Name = "tabStats";
            this.tabStats.Size = new System.Drawing.Size(892, 424);
            this.tabStats.TabIndex = 3;
            this.tabStats.Text = "Stats";
            // 
            // lblKDCounter
            // 
            this.lblKDCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKDCounter.Depth = 0;
            this.lblKDCounter.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblKDCounter.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblKDCounter.Location = new System.Drawing.Point(283, 50);
            this.lblKDCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKDCounter.Name = "lblKDCounter";
            this.lblKDCounter.Size = new System.Drawing.Size(90, 30);
            this.lblKDCounter.TabIndex = 12;
            this.lblKDCounter.Text = "0";
            this.lblKDCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel11
            // 
            this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel11.Location = new System.Drawing.Point(312, 31);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(29, 19);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "K/D";
            // 
            // btnClearFeed
            // 
            this.btnClearFeed.AutoSize = false;
            this.btnClearFeed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearFeed.Depth = 0;
            this.btnClearFeed.DrawShadows = true;
            this.btnClearFeed.HighEmphasis = true;
            this.btnClearFeed.Icon = null;
            this.btnClearFeed.Location = new System.Drawing.Point(315, 83);
            this.btnClearFeed.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearFeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearFeed.Name = "btnClearFeed";
            this.btnClearFeed.Size = new System.Drawing.Size(128, 37);
            this.btnClearFeed.TabIndex = 10;
            this.btnClearFeed.Text = "Clear Feed";
            this.btnClearFeed.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClearFeed.UseAccentColor = false;
            this.btnClearFeed.UseVisualStyleBackColor = true;
            this.btnClearFeed.Click += new System.EventHandler(this.btnClearFeed_Click);
            // 
            // btnClearStats
            // 
            this.btnClearStats.AutoSize = false;
            this.btnClearStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearStats.Depth = 0;
            this.btnClearStats.DrawShadows = true;
            this.btnClearStats.HighEmphasis = true;
            this.btnClearStats.Icon = null;
            this.btnClearStats.Location = new System.Drawing.Point(179, 83);
            this.btnClearStats.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearStats.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearStats.Name = "btnClearStats";
            this.btnClearStats.Size = new System.Drawing.Size(128, 37);
            this.btnClearStats.TabIndex = 9;
            this.btnClearStats.Text = "Reset Stats";
            this.btnClearStats.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnClearStats.UseAccentColor = false;
            this.btnClearStats.UseVisualStyleBackColor = true;
            this.btnClearStats.Click += new System.EventHandler(this.btnClearStats_Click);
            // 
            // listClassPeek
            // 
            this.listClassPeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listClassPeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listClassPeek.FormattingEnabled = true;
            this.listClassPeek.Location = new System.Drawing.Point(8, 129);
            this.listClassPeek.Name = "listClassPeek";
            this.listClassPeek.Size = new System.Drawing.Size(436, 286);
            this.listClassPeek.TabIndex = 8;
            // 
            // chkClassPeek
            // 
            this.chkClassPeek.AutoSize = true;
            this.chkClassPeek.Depth = 0;
            this.chkClassPeek.Location = new System.Drawing.Point(5, 84);
            this.chkClassPeek.Margin = new System.Windows.Forms.Padding(0);
            this.chkClassPeek.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkClassPeek.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkClassPeek.Name = "chkClassPeek";
            this.chkClassPeek.Ripple = true;
            this.chkClassPeek.Size = new System.Drawing.Size(164, 37);
            this.chkClassPeek.TabIndex = 7;
            this.chkClassPeek.Text = "Enable Class Peek";
            this.chkClassPeek.UseVisualStyleBackColor = true;
            this.chkClassPeek.CheckedChanged += new System.EventHandler(this.chkClassPeek_CheckedChanged);
            // 
            // lblDeathCounter
            // 
            this.lblDeathCounter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDeathCounter.Depth = 0;
            this.lblDeathCounter.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeathCounter.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblDeathCounter.Location = new System.Drawing.Point(172, 50);
            this.lblDeathCounter.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeathCounter.Name = "lblDeathCounter";
            this.lblDeathCounter.Size = new System.Drawing.Size(90, 30);
            this.lblDeathCounter.TabIndex = 5;
            this.lblDeathCounter.Text = "0";
            this.lblDeathCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel8.Location = new System.Drawing.Point(191, 31);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(51, 19);
            this.materialLabel8.TabIndex = 4;
            this.materialLabel8.Text = "Deaths";
            // 
            // lblKillCount
            // 
            this.lblKillCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKillCount.Depth = 0;
            this.lblKillCount.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblKillCount.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lblKillCount.Location = new System.Drawing.Point(61, 50);
            this.lblKillCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblKillCount.Name = "lblKillCount";
            this.lblKillCount.Size = new System.Drawing.Size(90, 30);
            this.lblKillCount.TabIndex = 3;
            this.lblKillCount.Text = "0";
            this.lblKillCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel6.Location = new System.Drawing.Point(89, 31);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(31, 19);
            this.materialLabel6.TabIndex = 2;
            this.materialLabel6.Text = "Kills";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(645, 9);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Killfeed";
            // 
            // listKillfeed
            // 
            this.listKillfeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listKillfeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listKillfeed.FormattingEnabled = true;
            this.listKillfeed.Location = new System.Drawing.Point(450, 31);
            this.listKillfeed.Name = "listKillfeed";
            this.listKillfeed.Size = new System.Drawing.Size(439, 390);
            this.listKillfeed.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Controls.Add(this.materialCard2);
            this.tabSettings.Controls.Add(this.cardLog);
            this.tabSettings.Controls.Add(this.cardRcon);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(892, 424);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveSettings.AnimateShowHideButton = false;
            this.btnSaveSettings.Depth = 0;
            this.btnSaveSettings.DrawShadows = true;
            this.btnSaveSettings.Icon = global::ToolFortress.Properties.Resources.SaveIcon;
            this.btnSaveSettings.Location = new System.Drawing.Point(800, 340);
            this.btnSaveSettings.Mini = false;
            this.btnSaveSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(64, 64);
            this.btnSaveSettings.TabIndex = 8;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.comboTheme);
            this.materialCard2.Controls.Add(this.chkMirrorConsole);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 266);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(369, 158);
            this.materialCard2.TabIndex = 7;
            // 
            // comboTheme
            // 
            this.comboTheme.AutoResize = false;
            this.comboTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboTheme.Depth = 0;
            this.comboTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboTheme.DropDownHeight = 118;
            this.comboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTheme.DropDownWidth = 121;
            this.comboTheme.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboTheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboTheme.FormattingEnabled = true;
            this.comboTheme.Hint = "Theme";
            this.comboTheme.IntegralHeight = false;
            this.comboTheme.ItemHeight = 29;
            this.comboTheme.Items.AddRange(new object[] {
            "Sky",
            "Aqua",
            "Deep Night"});
            this.comboTheme.Location = new System.Drawing.Point(17, 78);
            this.comboTheme.MaxDropDownItems = 4;
            this.comboTheme.MouseState = MaterialSkin.MouseState.OUT;
            this.comboTheme.Name = "comboTheme";
            this.comboTheme.Size = new System.Drawing.Size(335, 35);
            this.comboTheme.TabIndex = 8;
            this.comboTheme.UseTallSize = false;
            this.comboTheme.SelectedIndexChanged += new System.EventHandler(this.comboTheme_SelectedIndexChanged);
            // 
            // chkMirrorConsole
            // 
            this.chkMirrorConsole.AutoSize = true;
            this.chkMirrorConsole.Depth = 0;
            this.chkMirrorConsole.Location = new System.Drawing.Point(17, 38);
            this.chkMirrorConsole.Margin = new System.Windows.Forms.Padding(0);
            this.chkMirrorConsole.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMirrorConsole.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMirrorConsole.Name = "chkMirrorConsole";
            this.chkMirrorConsole.Ripple = true;
            this.chkMirrorConsole.Size = new System.Drawing.Size(190, 37);
            this.chkMirrorConsole.TabIndex = 7;
            this.chkMirrorConsole.Text = "Mirror Console Output";
            this.chkMirrorConsole.UseVisualStyleBackColor = true;
            this.chkMirrorConsole.CheckedChanged += new System.EventHandler(this.chkMirrorConsole_CheckedChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(17, 14);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 24);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "General";
            // 
            // cardLog
            // 
            this.cardLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardLog.Controls.Add(this.txtSteamID3);
            this.cardLog.Controls.Add(this.btnGamePicker);
            this.cardLog.Controls.Add(this.txtTFPath);
            this.cardLog.Controls.Add(this.materialLabel2);
            this.cardLog.Depth = 0;
            this.cardLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardLog.Location = new System.Drawing.Point(411, 14);
            this.cardLog.Margin = new System.Windows.Forms.Padding(14);
            this.cardLog.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardLog.Name = "cardLog";
            this.cardLog.Padding = new System.Windows.Forms.Padding(14);
            this.cardLog.Size = new System.Drawing.Size(467, 203);
            this.cardLog.TabIndex = 6;
            // 
            // txtSteamID3
            // 
            this.txtSteamID3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteamID3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSteamID3.Depth = 0;
            this.txtSteamID3.DetectUrls = false;
            this.txtSteamID3.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSteamID3.Hint = "Your SteamID3 (ex. [U:1:123456])";
            this.txtSteamID3.Location = new System.Drawing.Point(17, 138);
            this.txtSteamID3.MaxLength = 200;
            this.txtSteamID3.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSteamID3.Multiline = false;
            this.txtSteamID3.Name = "txtSteamID3";
            this.txtSteamID3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtSteamID3.Size = new System.Drawing.Size(433, 50);
            this.txtSteamID3.TabIndex = 6;
            this.txtSteamID3.Text = "";
            // 
            // btnGamePicker
            // 
            this.btnGamePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnGamePicker.Size = new System.Drawing.Size(432, 32);
            this.btnGamePicker.TabIndex = 5;
            this.btnGamePicker.Text = "Select...";
            this.btnGamePicker.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGamePicker.UseAccentColor = false;
            this.btnGamePicker.UseVisualStyleBackColor = true;
            this.btnGamePicker.Click += new System.EventHandler(this.btnGamePicker_Click);
            // 
            // txtTFPath
            // 
            this.txtTFPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtTFPath.Size = new System.Drawing.Size(433, 50);
            this.txtTFPath.TabIndex = 5;
            this.txtTFPath.Text = "";
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
            this.txtRconIP.Text = "";
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
            this.txtRconPassword.Text = "";
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
            this.txtRconPort.Text = "";
            // 
            // mainTabSelector
            // 
            this.mainTabSelector.BaseTabControl = this.mainTabControl;
            this.mainTabSelector.Depth = 0;
            this.mainTabSelector.Enabled = false;
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
            // tabBotDetector
            // 
            this.tabBotDetector.Location = new System.Drawing.Point(4, 22);
            this.tabBotDetector.Name = "tabBotDetector";
            this.tabBotDetector.Size = new System.Drawing.Size(892, 424);
            this.tabBotDetector.TabIndex = 6;
            this.tabBotDetector.Text = "Bot Detector";
            this.tabBotDetector.UseVisualStyleBackColor = true;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolFortress";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.mainTabControl.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            this.tabFun.ResumeLayout(false);
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpamSpeed)).EndInit();
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tabConnect.ResumeLayout(false);
            this.tabConnect.PerformLayout();
            this.tabConsole.ResumeLayout(false);
            this.tabConsole.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.tabStats.ResumeLayout(false);
            this.tabStats.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox txtConsoleOutput;
        private MaterialSkin.Controls.MaterialLabel lblHomeTitle;
        private MaterialSkin.Controls.MaterialCard cardLog;
        private MaterialSkin.Controls.MaterialTextBox txtTFPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCard cardRcon;
        private MaterialSkin.Controls.MaterialButton btnGamePicker;
        private System.Windows.Forms.FolderBrowserDialog tfFolderBrowser;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnStartGame;
        private MaterialSkin.Controls.MaterialTextBox txtConsoleInput;
        private System.Windows.Forms.ProgressBar progRconConnect;
        private System.Windows.Forms.TabPage tabStats;
        private MaterialSkin.Controls.MaterialTextBox txtSteamID3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ListBox listKillfeed;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCheckbox chkMirrorConsole;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel lblKillCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel lblDeathCounter;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialComboBox comboTheme;
        private System.Windows.Forms.TabPage tabFun;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCheckbox chkFunKillsay;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCheckbox chkKillsayDeath;
        private MaterialSkin.Controls.MaterialCheckbox chkKillsayKill;
        private MaterialSkin.Controls.MaterialCheckbox chkKillsayCrit;
        private MaterialSkin.Controls.MaterialTextBox txtKillsayMsg;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialTextBox txtKillsayDeathMsg;
        private MaterialSkin.Controls.MaterialButton btnClearFeed;
        private MaterialSkin.Controls.MaterialButton btnClearStats;
        private System.Windows.Forms.ListBox listClassPeek;
        private MaterialSkin.Controls.MaterialCheckbox chkClassPeek;
        private MaterialSkin.Controls.MaterialButton btnShowSettings;
        private MaterialSkin.Controls.MaterialFloatingActionButton btnSaveSettings;
        private MaterialSkin.Controls.MaterialLabel lblKDCounter;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.TabPage tabConnect;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialButton btnSvDisconnect;
        private MaterialSkin.Controls.MaterialButton btnSvConnect;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.ListBox listSvUsers;
        private MaterialSkin.Controls.MaterialButton btnSvUsername;
        private MaterialSkin.Controls.MaterialTextBox txtSvUsername;
        private MaterialSkin.Controls.MaterialComboBox comboSvTaunt;
        private MaterialSkin.Controls.MaterialButton btnSvTaunt;
        private MaterialSkin.Controls.MaterialComboBox comboKillsayClass;
        private MaterialSkin.Controls.MaterialCheckbox chkKillsayClass;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialSwitch chkSpamEnable;
        private MaterialSkin.Controls.MaterialTextBox txtSpamCommand;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.TrackBar trackSpamSpeed;
        private System.Windows.Forms.TabPage tabBotDetector;
    }
}

