namespace MonetaVerdeWalletGUI
{
    partial class AboutMonetaVerde
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMonetaVerde));
            this.About2Label = new System.Windows.Forms.Label();
            this.AboutVer = new System.Windows.Forms.Label();
            this.AboutMonWalGuiWrap = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GotoMonetaVerdeLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // About2Label
            // 
            this.About2Label.AutoSize = true;
            this.About2Label.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About2Label.Location = new System.Drawing.Point(12, 163);
            this.About2Label.Name = "About2Label";
            this.About2Label.Size = new System.Drawing.Size(164, 15);
            this.About2Label.TabIndex = 7;
            this.About2Label.Text = "The MonetaVerde developers";
            // 
            // AboutVer
            // 
            this.AboutVer.AutoSize = true;
            this.AboutVer.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutVer.Location = new System.Drawing.Point(12, 83);
            this.AboutVer.Name = "AboutVer";
            this.AboutVer.Size = new System.Drawing.Size(442, 15);
            this.AboutVer.TabIndex = 6;
            this.AboutVer.Text = "Version: Rolling release, get the latest builds from the MonetaVerde software at:" +
    "";
            // 
            // AboutMonWalGuiWrap
            // 
            this.AboutMonWalGuiWrap.AutoSize = true;
            this.AboutMonWalGuiWrap.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutMonWalGuiWrap.Location = new System.Drawing.Point(12, 35);
            this.AboutMonWalGuiWrap.Name = "AboutMonWalGuiWrap";
            this.AboutMonWalGuiWrap.Size = new System.Drawing.Size(255, 15);
            this.AboutMonWalGuiWrap.TabIndex = 5;
            this.AboutMonWalGuiWrap.Text = "About the MonetaVerde Wallet GUI Wrapper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(484, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 79);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // GotoMonetaVerdeLabel
            // 
            this.GotoMonetaVerdeLabel.AutoSize = true;
            this.GotoMonetaVerdeLabel.Location = new System.Drawing.Point(12, 127);
            this.GotoMonetaVerdeLabel.Name = "GotoMonetaVerdeLabel";
            this.GotoMonetaVerdeLabel.Size = new System.Drawing.Size(138, 13);
            this.GotoMonetaVerdeLabel.TabIndex = 9;
            this.GotoMonetaVerdeLabel.TabStop = true;
            this.GotoMonetaVerdeLabel.Text = "https://getmonetaverde.org";
            this.GotoMonetaVerdeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GotoMonetaVerdeLabel_LinkClicked);
            // 
            // AboutMonetaVerde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 203);
            this.Controls.Add(this.GotoMonetaVerdeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.About2Label);
            this.Controls.Add(this.AboutVer);
            this.Controls.Add(this.AboutMonWalGuiWrap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutMonetaVerde";
            this.Text = "About MonetaVerde";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label About2Label;
        private System.Windows.Forms.Label AboutVer;
        private System.Windows.Forms.Label AboutMonWalGuiWrap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel GotoMonetaVerdeLabel;
    }
}