namespace ToolFortress
{
    partial class SetupDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetupDialog));
            this.txtFolderPath = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnChoosePath = new MaterialSkin.Controls.MaterialButton();
            this.txtSteamID = new MaterialSkin.Controls.MaterialTextBox();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.tfFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGetID = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFolderPath.Depth = 0;
            this.txtFolderPath.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtFolderPath.Hint = "Team Fortress 2 folder";
            this.txtFolderPath.Location = new System.Drawing.Point(12, 137);
            this.txtFolderPath.MaxLength = 50;
            this.txtFolderPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFolderPath.Multiline = false;
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(383, 36);
            this.txtFolderPath.TabIndex = 0;
            this.txtFolderPath.Text = "";
            this.txtFolderPath.UseTallSize = false;
            this.txtFolderPath.TextChanged += new System.EventHandler(this.txtFolderPath_TextChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(211, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(88, 41);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Setup";
            // 
            // btnChoosePath
            // 
            this.btnChoosePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChoosePath.AutoSize = false;
            this.btnChoosePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChoosePath.Depth = 0;
            this.btnChoosePath.DrawShadows = true;
            this.btnChoosePath.HighEmphasis = true;
            this.btnChoosePath.Icon = null;
            this.btnChoosePath.Location = new System.Drawing.Point(403, 136);
            this.btnChoosePath.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnChoosePath.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChoosePath.Name = "btnChoosePath";
            this.btnChoosePath.Size = new System.Drawing.Size(95, 37);
            this.btnChoosePath.TabIndex = 2;
            this.btnChoosePath.Text = "Choose...";
            this.btnChoosePath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnChoosePath.UseAccentColor = false;
            this.btnChoosePath.UseVisualStyleBackColor = true;
            this.btnChoosePath.Click += new System.EventHandler(this.btnChoosePath_Click);
            // 
            // txtSteamID
            // 
            this.txtSteamID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSteamID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSteamID.Depth = 0;
            this.txtSteamID.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtSteamID.Hint = "Steam ID 3 (ex. [U:1:123456])";
            this.txtSteamID.Location = new System.Drawing.Point(12, 179);
            this.txtSteamID.MaxLength = 50;
            this.txtSteamID.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSteamID.Multiline = false;
            this.txtSteamID.Name = "txtSteamID";
            this.txtSteamID.Size = new System.Drawing.Size(383, 36);
            this.txtSteamID.TabIndex = 3;
            this.txtSteamID.Text = "";
            this.txtSteamID.UseTallSize = false;
            this.txtSteamID.TextChanged += new System.EventHandler(this.txtSteamID_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = false;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Depth = 0;
            this.btnSave.DrawShadows = true;
            this.btnSave.Enabled = false;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(12, 224);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(486, 37);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save and continue";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tfFolderDialog
            // 
            this.tfFolderDialog.Description = "Choose you \"Team Fortress 2\" folder...";
            this.tfFolderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // btnGetID
            // 
            this.btnGetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetID.AutoSize = false;
            this.btnGetID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGetID.Depth = 0;
            this.btnGetID.DrawShadows = true;
            this.btnGetID.HighEmphasis = true;
            this.btnGetID.Icon = null;
            this.btnGetID.Location = new System.Drawing.Point(403, 178);
            this.btnGetID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGetID.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGetID.Name = "btnGetID";
            this.btnGetID.Size = new System.Drawing.Size(95, 37);
            this.btnGetID.TabIndex = 5;
            this.btnGetID.Text = "Get...";
            this.btnGetID.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnGetID.UseAccentColor = false;
            this.btnGetID.UseVisualStyleBackColor = true;
            this.btnGetID.Click += new System.EventHandler(this.btnGetID_Click);
            // 
            // SetupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 281);
            this.Controls.Add(this.btnGetID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSteamID);
            this.Controls.Add(this.btnChoosePath);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtFolderPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolFortress";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SetupDialog_FormClosing);
            this.Load += new System.EventHandler(this.SetupDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtFolderPath;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnChoosePath;
        private MaterialSkin.Controls.MaterialTextBox txtSteamID;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private System.Windows.Forms.FolderBrowserDialog tfFolderDialog;
        private MaterialSkin.Controls.MaterialButton btnGetID;
    }
}