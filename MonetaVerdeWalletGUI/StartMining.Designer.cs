namespace MonetaVerdeWalletGUI
{
    partial class StartMining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMining));
            this.StartMiningButton = new System.Windows.Forms.Button();
            this.NumOfThreadsLabel = new System.Windows.Forms.Label();
            this.NumOfThreadsBox = new System.Windows.Forms.TextBox();
            this.CaptionHeaderText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartMiningButton
            // 
            this.StartMiningButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartMiningButton.FlatAppearance.BorderSize = 0;
            this.StartMiningButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartMiningButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartMiningButton.ForeColor = System.Drawing.Color.White;
            this.StartMiningButton.Location = new System.Drawing.Point(241, 192);
            this.StartMiningButton.Name = "StartMiningButton";
            this.StartMiningButton.Size = new System.Drawing.Size(276, 36);
            this.StartMiningButton.TabIndex = 7;
            this.StartMiningButton.Text = "Start mining!";
            this.StartMiningButton.UseVisualStyleBackColor = false;
            this.StartMiningButton.Click += new System.EventHandler(this.StartMiningButton_Click);
            // 
            // NumOfThreadsLabel
            // 
            this.NumOfThreadsLabel.AutoSize = true;
            this.NumOfThreadsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfThreadsLabel.Location = new System.Drawing.Point(24, 103);
            this.NumOfThreadsLabel.Name = "NumOfThreadsLabel";
            this.NumOfThreadsLabel.Size = new System.Drawing.Size(682, 23);
            this.NumOfThreadsLabel.TabIndex = 6;
            this.NumOfThreadsLabel.Text = "Number of threads at the same time (should never be more than your number of core" +
    "s)";
            // 
            // NumOfThreadsBox
            // 
            this.NumOfThreadsBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumOfThreadsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumOfThreadsBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfThreadsBox.Location = new System.Drawing.Point(241, 143);
            this.NumOfThreadsBox.Name = "NumOfThreadsBox";
            this.NumOfThreadsBox.Size = new System.Drawing.Size(276, 26);
            this.NumOfThreadsBox.TabIndex = 5;
            this.NumOfThreadsBox.Text = "1";
            this.NumOfThreadsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CaptionHeaderText
            // 
            this.CaptionHeaderText.AutoSize = true;
            this.CaptionHeaderText.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionHeaderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.CaptionHeaderText.Location = new System.Drawing.Point(60, 28);
            this.CaptionHeaderText.Name = "CaptionHeaderText";
            this.CaptionHeaderText.Size = new System.Drawing.Size(616, 36);
            this.CaptionHeaderText.TabIndex = 8;
            this.CaptionHeaderText.Text = "One more second, we need one more piece of info!";
            // 
            // StartMining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(787, 264);
            this.Controls.Add(this.CaptionHeaderText);
            this.Controls.Add(this.StartMiningButton);
            this.Controls.Add(this.NumOfThreadsLabel);
            this.Controls.Add(this.NumOfThreadsBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartMining";
            this.Text = "Prepare to start mining";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartMiningButton;
        private System.Windows.Forms.Label NumOfThreadsLabel;
        private System.Windows.Forms.TextBox NumOfThreadsBox;
        private System.Windows.Forms.Label CaptionHeaderText;
    }
}