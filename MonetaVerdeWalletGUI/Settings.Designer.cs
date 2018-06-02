namespace MonetaVerdeWalletGUI
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.DaemonSeedNodesList = new System.Windows.Forms.ListBox();
            this.DaemonSeedNodesListLabel = new System.Windows.Forms.Label();
            this.SettingsSaveAndClose = new System.Windows.Forms.Button();
            this.RemoteDaemonIPLabel = new System.Windows.Forms.Label();
            this.RemoteDaemonIP = new System.Windows.Forms.TextBox();
            this.UseRemoteDaemonInsteadOfLocal = new System.Windows.Forms.CheckBox();
            this.NewDaemonSeed = new System.Windows.Forms.TextBox();
            this.AddDaemonList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DaemonSeedNodesList
            // 
            this.DaemonSeedNodesList.FormattingEnabled = true;
            this.DaemonSeedNodesList.Location = new System.Drawing.Point(42, 122);
            this.DaemonSeedNodesList.Name = "DaemonSeedNodesList";
            this.DaemonSeedNodesList.Size = new System.Drawing.Size(449, 30);
            this.DaemonSeedNodesList.TabIndex = 0;
            this.DaemonSeedNodesList.SelectedIndexChanged += new System.EventHandler(this.DaemonSeedNodesList_SelectedIndexChanged);
            // 
            // DaemonSeedNodesListLabel
            // 
            this.DaemonSeedNodesListLabel.AutoSize = true;
            this.DaemonSeedNodesListLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DaemonSeedNodesListLabel.Location = new System.Drawing.Point(42, 32);
            this.DaemonSeedNodesListLabel.Name = "DaemonSeedNodesListLabel";
            this.DaemonSeedNodesListLabel.Size = new System.Drawing.Size(117, 13);
            this.DaemonSeedNodesListLabel.TabIndex = 1;
            this.DaemonSeedNodesListLabel.Text = "Daemon seednodes list";
            // 
            // SettingsSaveAndClose
            // 
            this.SettingsSaveAndClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SettingsSaveAndClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsSaveAndClose.ForeColor = System.Drawing.Color.White;
            this.SettingsSaveAndClose.Location = new System.Drawing.Point(45, 311);
            this.SettingsSaveAndClose.Name = "SettingsSaveAndClose";
            this.SettingsSaveAndClose.Size = new System.Drawing.Size(446, 48);
            this.SettingsSaveAndClose.TabIndex = 2;
            this.SettingsSaveAndClose.Text = "Save and close";
            this.SettingsSaveAndClose.UseVisualStyleBackColor = false;
            this.SettingsSaveAndClose.Click += new System.EventHandler(this.SettingsSaveAndClose_Click);
            // 
            // RemoteDaemonIPLabel
            // 
            this.RemoteDaemonIPLabel.AutoSize = true;
            this.RemoteDaemonIPLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RemoteDaemonIPLabel.Location = new System.Drawing.Point(39, 181);
            this.RemoteDaemonIPLabel.Name = "RemoteDaemonIPLabel";
            this.RemoteDaemonIPLabel.Size = new System.Drawing.Size(144, 13);
            this.RemoteDaemonIPLabel.TabIndex = 4;
            this.RemoteDaemonIPLabel.Text = "Remote daemon IP (IP : port)";
            // 
            // RemoteDaemonIP
            // 
            this.RemoteDaemonIP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoteDaemonIP.Location = new System.Drawing.Point(42, 210);
            this.RemoteDaemonIP.Name = "RemoteDaemonIP";
            this.RemoteDaemonIP.Size = new System.Drawing.Size(449, 27);
            this.RemoteDaemonIP.TabIndex = 5;
            // 
            // UseRemoteDaemonInsteadOfLocal
            // 
            this.UseRemoteDaemonInsteadOfLocal.AutoSize = true;
            this.UseRemoteDaemonInsteadOfLocal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseRemoteDaemonInsteadOfLocal.Location = new System.Drawing.Point(42, 262);
            this.UseRemoteDaemonInsteadOfLocal.Name = "UseRemoteDaemonInsteadOfLocal";
            this.UseRemoteDaemonInsteadOfLocal.Size = new System.Drawing.Size(263, 23);
            this.UseRemoteDaemonInsteadOfLocal.TabIndex = 6;
            this.UseRemoteDaemonInsteadOfLocal.Text = "Use remote daemon instead of local";
            this.UseRemoteDaemonInsteadOfLocal.UseVisualStyleBackColor = true;
            // 
            // NewDaemonSeed
            // 
            this.NewDaemonSeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDaemonSeed.Location = new System.Drawing.Point(42, 68);
            this.NewDaemonSeed.Name = "NewDaemonSeed";
            this.NewDaemonSeed.Size = new System.Drawing.Size(449, 27);
            this.NewDaemonSeed.TabIndex = 7;
            // 
            // AddDaemonList
            // 
            this.AddDaemonList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AddDaemonList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDaemonList.ForeColor = System.Drawing.Color.White;
            this.AddDaemonList.Location = new System.Drawing.Point(497, 68);
            this.AddDaemonList.Name = "AddDaemonList";
            this.AddDaemonList.Size = new System.Drawing.Size(186, 27);
            this.AddDaemonList.TabIndex = 8;
            this.AddDaemonList.Text = "Add to daemon list";
            this.AddDaemonList.UseVisualStyleBackColor = false;
            this.AddDaemonList.Click += new System.EventHandler(this.AddDaemonList_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 477);
            this.Controls.Add(this.AddDaemonList);
            this.Controls.Add(this.NewDaemonSeed);
            this.Controls.Add(this.UseRemoteDaemonInsteadOfLocal);
            this.Controls.Add(this.RemoteDaemonIP);
            this.Controls.Add(this.RemoteDaemonIPLabel);
            this.Controls.Add(this.SettingsSaveAndClose);
            this.Controls.Add(this.DaemonSeedNodesListLabel);
            this.Controls.Add(this.DaemonSeedNodesList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DaemonSeedNodesList;
        private System.Windows.Forms.Label DaemonSeedNodesListLabel;
        private System.Windows.Forms.Button SettingsSaveAndClose;
        private System.Windows.Forms.Label RemoteDaemonIPLabel;
        private System.Windows.Forms.TextBox RemoteDaemonIP;
        private System.Windows.Forms.CheckBox UseRemoteDaemonInsteadOfLocal;
        private System.Windows.Forms.TextBox NewDaemonSeed;
        private System.Windows.Forms.Button AddDaemonList;
    }
}