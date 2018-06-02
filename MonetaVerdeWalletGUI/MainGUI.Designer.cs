namespace MonetaVerdeWalletGUI
{
    partial class Wallet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallet));
            this.Copy_Address = new System.Windows.Forms.Button();
            this.ShowAddress = new System.Windows.Forms.Label();
            this.YourWalletLabel = new System.Windows.Forms.Label();
            this.TotalBalance = new System.Windows.Forms.Label();
            this.BalanceStr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RecentTransactionsLabel = new System.Windows.Forms.Label();
            this.RecTransAmountLab = new System.Windows.Forms.Label();
            this.RecTransAddressLab = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.DeamonStatusLabel = new System.Windows.Forms.Label();
            this.HashRateLabel = new System.Windows.Forms.Label();
            this.HashRateStr = new System.Windows.Forms.Label();
            this.BlockHeightSyncedLabel = new System.Windows.Forms.Label();
            this.DeamonStreamReaderLatestComment = new System.Windows.Forms.Label();
            this.DeamonStatus = new System.Windows.Forms.Button();
            this.StreamConsoleWriter = new System.Windows.Forms.TextBox();
            this.DeamonInterfaceLabel = new System.Windows.Forms.Label();
            this.UnconfBalance = new System.Windows.Forms.Label();
            this.UnconfirmedBalanceLab = new System.Windows.Forms.Label();
            this.BlockHeightWallet = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SendCoins = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ToggleMining = new System.Windows.Forms.Button();
            this.AboutButton = new System.Windows.Forms.Button();
            this.TXAmounts = new System.Windows.Forms.ListBox();
            this.InOutLabel = new System.Windows.Forms.Label();
            this.TXInOut = new System.Windows.Forms.ListBox();
            this.TXId = new System.Windows.Forms.ListBox();
            this.startWalletMessage = new System.Windows.Forms.PictureBox();
            this.ProgressSyncWallet = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startWalletMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // Copy_Address
            // 
            this.Copy_Address.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Copy_Address.FlatAppearance.BorderSize = 0;
            this.Copy_Address.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.Copy_Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Copy_Address.Font = new System.Drawing.Font("Calibri", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.Copy_Address.ForeColor = System.Drawing.Color.LightBlue;
            this.Copy_Address.Location = new System.Drawing.Point(9, 74);
            this.Copy_Address.Name = "Copy_Address";
            this.Copy_Address.Size = new System.Drawing.Size(335, 27);
            this.Copy_Address.TabIndex = 0;
            this.Copy_Address.Text = "Copy address to clipboard";
            this.Copy_Address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Copy_Address.UseVisualStyleBackColor = false;
            this.Copy_Address.Click += new System.EventHandler(this.Get_Address_Click);
            // 
            // ShowAddress
            // 
            this.ShowAddress.AutoSize = true;
            this.ShowAddress.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ShowAddress.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowAddress.ForeColor = System.Drawing.Color.White;
            this.ShowAddress.Location = new System.Drawing.Point(13, 50);
            this.ShowAddress.Name = "ShowAddress";
            this.ShowAddress.Size = new System.Drawing.Size(64, 13);
            this.ShowAddress.TabIndex = 1;
            this.ShowAddress.Text = "Please login";
            // 
            // YourWalletLabel
            // 
            this.YourWalletLabel.AutoSize = true;
            this.YourWalletLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.YourWalletLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourWalletLabel.ForeColor = System.Drawing.Color.White;
            this.YourWalletLabel.Location = new System.Drawing.Point(12, 20);
            this.YourWalletLabel.Name = "YourWalletLabel";
            this.YourWalletLabel.Size = new System.Drawing.Size(165, 23);
            this.YourWalletLabel.TabIndex = 2;
            this.YourWalletLabel.Text = "Your wallet address";
            // 
            // TotalBalance
            // 
            this.TotalBalance.AutoSize = true;
            this.TotalBalance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalBalance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBalance.ForeColor = System.Drawing.Color.White;
            this.TotalBalance.Location = new System.Drawing.Point(933, 20);
            this.TotalBalance.Name = "TotalBalance";
            this.TotalBalance.Size = new System.Drawing.Size(80, 26);
            this.TotalBalance.TabIndex = 3;
            this.TotalBalance.Text = "Balance";
            // 
            // BalanceStr
            // 
            this.BalanceStr.AutoSize = true;
            this.BalanceStr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BalanceStr.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceStr.ForeColor = System.Drawing.Color.White;
            this.BalanceStr.Location = new System.Drawing.Point(1080, 23);
            this.BalanceStr.Name = "BalanceStr";
            this.BalanceStr.Size = new System.Drawing.Size(45, 23);
            this.BalanceStr.TabIndex = 4;
            this.BalanceStr.Text = "0.00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(156, 439);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 96);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1264, 116);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // RecentTransactionsLabel
            // 
            this.RecentTransactionsLabel.AutoSize = true;
            this.RecentTransactionsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentTransactionsLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.RecentTransactionsLabel.Location = new System.Drawing.Point(187, 163);
            this.RecentTransactionsLabel.Name = "RecentTransactionsLabel";
            this.RecentTransactionsLabel.Size = new System.Drawing.Size(181, 26);
            this.RecentTransactionsLabel.TabIndex = 8;
            this.RecentTransactionsLabel.Text = "Recent Transactions";
            // 
            // RecTransAmountLab
            // 
            this.RecTransAmountLab.AutoSize = true;
            this.RecTransAmountLab.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecTransAmountLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RecTransAmountLab.Location = new System.Drawing.Point(189, 198);
            this.RecTransAmountLab.Name = "RecTransAmountLab";
            this.RecTransAmountLab.Size = new System.Drawing.Size(49, 14);
            this.RecTransAmountLab.TabIndex = 9;
            this.RecTransAmountLab.Text = "Amount";
            // 
            // RecTransAddressLab
            // 
            this.RecTransAddressLab.AutoSize = true;
            this.RecTransAddressLab.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecTransAddressLab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RecTransAddressLab.Location = new System.Drawing.Point(511, 198);
            this.RecTransAddressLab.Name = "RecTransAddressLab";
            this.RecTransAddressLab.Size = new System.Drawing.Size(34, 14);
            this.RecTransAddressLab.TabIndex = 10;
            this.RecTransAddressLab.Text = "TX ID";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.pictureBox3.Location = new System.Drawing.Point(0, 536);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1264, 31);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // DeamonStatusLabel
            // 
            this.DeamonStatusLabel.AutoSize = true;
            this.DeamonStatusLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.DeamonStatusLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeamonStatusLabel.ForeColor = System.Drawing.Color.White;
            this.DeamonStatusLabel.Location = new System.Drawing.Point(6, 543);
            this.DeamonStatusLabel.Name = "DeamonStatusLabel";
            this.DeamonStatusLabel.Size = new System.Drawing.Size(92, 15);
            this.DeamonStatusLabel.TabIndex = 13;
            this.DeamonStatusLabel.Text = "Deamon status:";
            // 
            // HashRateLabel
            // 
            this.HashRateLabel.AutoSize = true;
            this.HashRateLabel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.HashRateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashRateLabel.ForeColor = System.Drawing.Color.White;
            this.HashRateLabel.Location = new System.Drawing.Point(975, 543);
            this.HashRateLabel.Name = "HashRateLabel";
            this.HashRateLabel.Size = new System.Drawing.Size(82, 15);
            this.HashRateLabel.TabIndex = 15;
            this.HashRateLabel.Text = "Miner output:";
            // 
            // HashRateStr
            // 
            this.HashRateStr.AutoSize = true;
            this.HashRateStr.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.HashRateStr.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashRateStr.ForeColor = System.Drawing.Color.White;
            this.HashRateStr.Location = new System.Drawing.Point(1081, 543);
            this.HashRateStr.Name = "HashRateStr";
            this.HashRateStr.Size = new System.Drawing.Size(61, 15);
            this.HashRateStr.TabIndex = 17;
            this.HashRateStr.Text = "Not active";
            // 
            // BlockHeightSyncedLabel
            // 
            this.BlockHeightSyncedLabel.AutoSize = true;
            this.BlockHeightSyncedLabel.BackColor = System.Drawing.Color.White;
            this.BlockHeightSyncedLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockHeightSyncedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BlockHeightSyncedLabel.Location = new System.Drawing.Point(6, 573);
            this.BlockHeightSyncedLabel.Name = "BlockHeightSyncedLabel";
            this.BlockHeightSyncedLabel.Size = new System.Drawing.Size(260, 18);
            this.BlockHeightSyncedLabel.TabIndex = 21;
            this.BlockHeightSyncedLabel.Text = "Blockheight (blocks since Genesis block):";
            // 
            // DeamonStreamReaderLatestComment
            // 
            this.DeamonStreamReaderLatestComment.AutoSize = true;
            this.DeamonStreamReaderLatestComment.Location = new System.Drawing.Point(919, 454);
            this.DeamonStreamReaderLatestComment.Name = "DeamonStreamReaderLatestComment";
            this.DeamonStreamReaderLatestComment.Size = new System.Drawing.Size(0, 13);
            this.DeamonStreamReaderLatestComment.TabIndex = 22;
            // 
            // DeamonStatus
            // 
            this.DeamonStatus.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.DeamonStatus.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.DeamonStatus.FlatAppearance.BorderSize = 0;
            this.DeamonStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.DeamonStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeamonStatus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeamonStatus.ForeColor = System.Drawing.Color.LightBlue;
            this.DeamonStatus.Location = new System.Drawing.Point(101, 536);
            this.DeamonStatus.Name = "DeamonStatus";
            this.DeamonStatus.Size = new System.Drawing.Size(79, 27);
            this.DeamonStatus.TabIndex = 23;
            this.DeamonStatus.Text = "Disabled";
            this.DeamonStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeamonStatus.UseVisualStyleBackColor = false;
            this.DeamonStatus.Click += new System.EventHandler(this.DeamonStatus_Click);
            // 
            // StreamConsoleWriter
            // 
            this.StreamConsoleWriter.BackColor = System.Drawing.Color.White;
            this.StreamConsoleWriter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StreamConsoleWriter.Font = new System.Drawing.Font("Calibri", 8F);
            this.StreamConsoleWriter.ForeColor = System.Drawing.Color.Silver;
            this.StreamConsoleWriter.Location = new System.Drawing.Point(463, 454);
            this.StreamConsoleWriter.Multiline = true;
            this.StreamConsoleWriter.Name = "StreamConsoleWriter";
            this.StreamConsoleWriter.Size = new System.Drawing.Size(790, 76);
            this.StreamConsoleWriter.TabIndex = 25;
            // 
            // DeamonInterfaceLabel
            // 
            this.DeamonInterfaceLabel.AutoSize = true;
            this.DeamonInterfaceLabel.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeamonInterfaceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.DeamonInterfaceLabel.Location = new System.Drawing.Point(463, 439);
            this.DeamonInterfaceLabel.Name = "DeamonInterfaceLabel";
            this.DeamonInterfaceLabel.Size = new System.Drawing.Size(128, 13);
            this.DeamonInterfaceLabel.TabIndex = 26;
            this.DeamonInterfaceLabel.Text = "Deamon / miner interface";
            // 
            // UnconfBalance
            // 
            this.UnconfBalance.AutoSize = true;
            this.UnconfBalance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UnconfBalance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnconfBalance.ForeColor = System.Drawing.Color.DarkGray;
            this.UnconfBalance.Location = new System.Drawing.Point(1080, 59);
            this.UnconfBalance.Name = "UnconfBalance";
            this.UnconfBalance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UnconfBalance.Size = new System.Drawing.Size(37, 19);
            this.UnconfBalance.TabIndex = 28;
            this.UnconfBalance.Text = "0.00";
            // 
            // UnconfirmedBalanceLab
            // 
            this.UnconfirmedBalanceLab.AutoSize = true;
            this.UnconfirmedBalanceLab.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UnconfirmedBalanceLab.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnconfirmedBalanceLab.ForeColor = System.Drawing.Color.DarkGray;
            this.UnconfirmedBalanceLab.Location = new System.Drawing.Point(934, 59);
            this.UnconfirmedBalanceLab.Name = "UnconfirmedBalanceLab";
            this.UnconfirmedBalanceLab.Size = new System.Drawing.Size(123, 19);
            this.UnconfirmedBalanceLab.TabIndex = 29;
            this.UnconfirmedBalanceLab.Text = "Unlocked balance";
            // 
            // BlockHeightWallet
            // 
            this.BlockHeightWallet.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.BlockHeightWallet.BackColor = System.Drawing.Color.White;
            this.BlockHeightWallet.FlatAppearance.BorderSize = 0;
            this.BlockHeightWallet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BlockHeightWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlockHeightWallet.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlockHeightWallet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BlockHeightWallet.Location = new System.Drawing.Point(272, 569);
            this.BlockHeightWallet.Name = "BlockHeightWallet";
            this.BlockHeightWallet.Size = new System.Drawing.Size(256, 27);
            this.BlockHeightWallet.TabIndex = 30;
            this.BlockHeightWallet.Text = "Unretrieved";
            this.BlockHeightWallet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BlockHeightWallet.UseVisualStyleBackColor = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LoginButton.Location = new System.Drawing.Point(19, 137);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(116, 35);
            this.LoginButton.TabIndex = 31;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.White;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Settings.Location = new System.Drawing.Point(19, 198);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(79, 35);
            this.Settings.TabIndex = 32;
            this.Settings.Text = "Settings";
            this.Settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(0, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 431);
            this.pictureBox4.TabIndex = 33;
            this.pictureBox4.TabStop = false;
            // 
            // SendCoins
            // 
            this.SendCoins.BackColor = System.Drawing.Color.White;
            this.SendCoins.Enabled = false;
            this.SendCoins.FlatAppearance.BorderSize = 0;
            this.SendCoins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendCoins.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SendCoins.Location = new System.Drawing.Point(19, 265);
            this.SendCoins.Name = "SendCoins";
            this.SendCoins.Size = new System.Drawing.Size(100, 35);
            this.SendCoins.TabIndex = 34;
            this.SendCoins.Text = "Send coins";
            this.SendCoins.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SendCoins.UseVisualStyleBackColor = false;
            this.SendCoins.Click += new System.EventHandler(this.SendCoins_Click);
            // 
            // ToggleMining
            // 
            this.ToggleMining.BackColor = System.Drawing.Color.White;
            this.ToggleMining.Enabled = false;
            this.ToggleMining.FlatAppearance.BorderSize = 0;
            this.ToggleMining.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToggleMining.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToggleMining.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ToggleMining.Location = new System.Drawing.Point(19, 339);
            this.ToggleMining.Name = "ToggleMining";
            this.ToggleMining.Size = new System.Drawing.Size(116, 35);
            this.ToggleMining.TabIndex = 35;
            this.ToggleMining.Text = "Start mining";
            this.ToggleMining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToggleMining.UseVisualStyleBackColor = false;
            this.ToggleMining.Click += new System.EventHandler(this.ToggleMining_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.BackColor = System.Drawing.Color.White;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AboutButton.Location = new System.Drawing.Point(19, 439);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(116, 35);
            this.AboutButton.TabIndex = 36;
            this.AboutButton.Text = "About";
            this.AboutButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutButton.UseVisualStyleBackColor = false;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // TXAmounts
            // 
            this.TXAmounts.BackColor = System.Drawing.Color.White;
            this.TXAmounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXAmounts.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXAmounts.ForeColor = System.Drawing.Color.Gray;
            this.TXAmounts.FormattingEnabled = true;
            this.TXAmounts.ItemHeight = 19;
            this.TXAmounts.Location = new System.Drawing.Point(192, 230);
            this.TXAmounts.Name = "TXAmounts";
            this.TXAmounts.Size = new System.Drawing.Size(110, 190);
            this.TXAmounts.TabIndex = 7;
            // 
            // InOutLabel
            // 
            this.InOutLabel.AutoSize = true;
            this.InOutLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InOutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.InOutLabel.Location = new System.Drawing.Point(356, 198);
            this.InOutLabel.Name = "InOutLabel";
            this.InOutLabel.Size = new System.Drawing.Size(46, 14);
            this.InOutLabel.TabIndex = 38;
            this.InOutLabel.Text = "IN/OUT";
            // 
            // TXInOut
            // 
            this.TXInOut.BackColor = System.Drawing.Color.White;
            this.TXInOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXInOut.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXInOut.ForeColor = System.Drawing.Color.Gray;
            this.TXInOut.FormattingEnabled = true;
            this.TXInOut.ItemHeight = 19;
            this.TXInOut.Location = new System.Drawing.Point(359, 230);
            this.TXInOut.Name = "TXInOut";
            this.TXInOut.Size = new System.Drawing.Size(110, 190);
            this.TXInOut.TabIndex = 39;
            // 
            // TXId
            // 
            this.TXId.BackColor = System.Drawing.Color.White;
            this.TXId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXId.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXId.ForeColor = System.Drawing.Color.Gray;
            this.TXId.FormattingEnabled = true;
            this.TXId.ItemHeight = 19;
            this.TXId.Location = new System.Drawing.Point(513, 230);
            this.TXId.Name = "TXId";
            this.TXId.Size = new System.Drawing.Size(726, 190);
            this.TXId.TabIndex = 40;
            // 
            // startWalletMessage
            // 
            this.startWalletMessage.Image = ((System.Drawing.Image)(resources.GetObject("startWalletMessage.Image")));
            this.startWalletMessage.Location = new System.Drawing.Point(156, 122);
            this.startWalletMessage.Name = "startWalletMessage";
            this.startWalletMessage.Size = new System.Drawing.Size(1024, 276);
            this.startWalletMessage.TabIndex = 41;
            this.startWalletMessage.TabStop = false;
            // 
            // ProgressSyncWallet
            // 
            this.ProgressSyncWallet.Location = new System.Drawing.Point(534, 570);
            this.ProgressSyncWallet.Name = "ProgressSyncWallet";
            this.ProgressSyncWallet.Size = new System.Drawing.Size(730, 23);
            this.ProgressSyncWallet.TabIndex = 42;
            // 
            // Wallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 597);
            this.Controls.Add(this.Copy_Address);
            this.Controls.Add(this.ProgressSyncWallet);
            this.Controls.Add(this.startWalletMessage);
            this.Controls.Add(this.TXId);
            this.Controls.Add(this.TXInOut);
            this.Controls.Add(this.InOutLabel);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.ToggleMining);
            this.Controls.Add(this.SendCoins);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BlockHeightWallet);
            this.Controls.Add(this.UnconfirmedBalanceLab);
            this.Controls.Add(this.UnconfBalance);
            this.Controls.Add(this.DeamonInterfaceLabel);
            this.Controls.Add(this.StreamConsoleWriter);
            this.Controls.Add(this.DeamonStatus);
            this.Controls.Add(this.DeamonStreamReaderLatestComment);
            this.Controls.Add(this.BlockHeightSyncedLabel);
            this.Controls.Add(this.HashRateStr);
            this.Controls.Add(this.HashRateLabel);
            this.Controls.Add(this.DeamonStatusLabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.RecTransAddressLab);
            this.Controls.Add(this.RecTransAmountLab);
            this.Controls.Add(this.RecentTransactionsLabel);
            this.Controls.Add(this.TXAmounts);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BalanceStr);
            this.Controls.Add(this.TotalBalance);
            this.Controls.Add(this.YourWalletLabel);
            this.Controls.Add(this.ShowAddress);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wallet";
            this.Text = "MonetaVerde GUI Wallet (ALPHA BUILD) ";
            this.Load += new System.EventHandler(this.Wallet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startWalletMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Copy_Address;
        private System.Windows.Forms.Label ShowAddress;
        private System.Windows.Forms.Label YourWalletLabel;
        private System.Windows.Forms.Label TotalBalance;
        private System.Windows.Forms.Label BalanceStr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label RecentTransactionsLabel;
        private System.Windows.Forms.Label RecTransAmountLab;
        private System.Windows.Forms.Label RecTransAddressLab;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label DeamonStatusLabel;
        private System.Windows.Forms.Label HashRateLabel;
        private System.Windows.Forms.Label HashRateStr;
        private System.Windows.Forms.Label BlockHeightSyncedLabel;
        private System.Windows.Forms.Label DeamonStreamReaderLatestComment;
        private System.Windows.Forms.Button DeamonStatus;
        private System.Windows.Forms.TextBox StreamConsoleWriter;
        private System.Windows.Forms.Label DeamonInterfaceLabel;
        private System.Windows.Forms.Label UnconfBalance;
        private System.Windows.Forms.Label UnconfirmedBalanceLab;
        private System.Windows.Forms.Button BlockHeightWallet;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button SendCoins;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ToggleMining;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.ListBox TXAmounts;
        private System.Windows.Forms.Label InOutLabel;
        private System.Windows.Forms.ListBox TXInOut;
        private System.Windows.Forms.ListBox TXId;
        private System.Windows.Forms.PictureBox startWalletMessage;
        private System.Windows.Forms.ProgressBar ProgressSyncWallet;
    }
}

