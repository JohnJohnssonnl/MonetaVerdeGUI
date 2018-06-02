namespace MonetaVerdeWalletGUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Password = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LabelLoginToWallet = new System.Windows.Forms.Label();
            this.CreateWalletCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(160, 174);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(276, 26);
            this.Password.TabIndex = 0;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(210, 137);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(184, 23);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Please enter password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.Location = new System.Drawing.Point(210, 63);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(185, 23);
            this.UserNameLabel.TabIndex = 3;
            this.UserNameLabel.Text = "Please enter username";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(160, 99);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(276, 26);
            this.UserName.TabIndex = 2;
            this.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(160, 294);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(276, 36);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LabelLoginToWallet
            // 
            this.LabelLoginToWallet.AutoSize = true;
            this.LabelLoginToWallet.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLoginToWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LabelLoginToWallet.Location = new System.Drawing.Point(177, 9);
            this.LabelLoginToWallet.Name = "LabelLoginToWallet";
            this.LabelLoginToWallet.Size = new System.Drawing.Size(250, 36);
            this.LabelLoginToWallet.TabIndex = 5;
            this.LabelLoginToWallet.Text = "Login to your wallet";
            // 
            // CreateWalletCheckbox
            // 
            this.CreateWalletCheckbox.AutoSize = true;
            this.CreateWalletCheckbox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateWalletCheckbox.Location = new System.Drawing.Point(136, 233);
            this.CreateWalletCheckbox.Name = "CreateWalletCheckbox";
            this.CreateWalletCheckbox.Size = new System.Drawing.Size(327, 27);
            this.CreateWalletCheckbox.TabIndex = 6;
            this.CreateWalletCheckbox.Text = "Create wallet (check if if does not exist)";
            this.CreateWalletCheckbox.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 384);
            this.Controls.Add(this.CreateWalletCheckbox);
            this.Controls.Add(this.LabelLoginToWallet);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.Password);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LabelLoginToWallet;
        private System.Windows.Forms.CheckBox CreateWalletCheckbox;
    }
}