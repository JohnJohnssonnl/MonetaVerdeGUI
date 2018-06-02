namespace MonetaVerdeWalletGUI
{
    partial class SendCoins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendCoins));
            this.PaymentIdBox = new System.Windows.Forms.TextBox();
            this.SendToAddressBox = new System.Windows.Forms.TextBox();
            this.PaymentIdLabel = new System.Windows.Forms.Label();
            this.SendToAddressLabel = new System.Windows.Forms.Label();
            this.SendCoinsButton = new System.Windows.Forms.Button();
            this.GeneratePaymentButton = new System.Windows.Forms.Button();
            this.NumOfCoinsToSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaymentIdBox
            // 
            this.PaymentIdBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PaymentIdBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentIdBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentIdBox.Location = new System.Drawing.Point(166, 199);
            this.PaymentIdBox.Name = "PaymentIdBox";
            this.PaymentIdBox.Size = new System.Drawing.Size(527, 19);
            this.PaymentIdBox.TabIndex = 0;
            this.PaymentIdBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SendToAddressBox
            // 
            this.SendToAddressBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SendToAddressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SendToAddressBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToAddressBox.Location = new System.Drawing.Point(47, 106);
            this.SendToAddressBox.Name = "SendToAddressBox";
            this.SendToAddressBox.Size = new System.Drawing.Size(785, 16);
            this.SendToAddressBox.TabIndex = 2;
            this.SendToAddressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SendToAddressBox.TextChanged += new System.EventHandler(this.SendToAddressBox_TextChanged);
            // 
            // PaymentIdLabel
            // 
            this.PaymentIdLabel.AutoSize = true;
            this.PaymentIdLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentIdLabel.Location = new System.Drawing.Point(275, 161);
            this.PaymentIdLabel.Name = "PaymentIdLabel";
            this.PaymentIdLabel.Size = new System.Drawing.Size(309, 23);
            this.PaymentIdLabel.TabIndex = 4;
            this.PaymentIdLabel.Text = "Please generate payment ID if required";
            // 
            // SendToAddressLabel
            // 
            this.SendToAddressLabel.AutoSize = true;
            this.SendToAddressLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendToAddressLabel.Location = new System.Drawing.Point(293, 70);
            this.SendToAddressLabel.Name = "SendToAddressLabel";
            this.SendToAddressLabel.Size = new System.Drawing.Size(276, 23);
            this.SendToAddressLabel.TabIndex = 5;
            this.SendToAddressLabel.Text = "Please enter the receiver\'s address";
            // 
            // SendCoinsButton
            // 
            this.SendCoinsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SendCoinsButton.FlatAppearance.BorderSize = 0;
            this.SendCoinsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendCoinsButton.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendCoinsButton.ForeColor = System.Drawing.Color.White;
            this.SendCoinsButton.Location = new System.Drawing.Point(297, 361);
            this.SendCoinsButton.Name = "SendCoinsButton";
            this.SendCoinsButton.Size = new System.Drawing.Size(276, 36);
            this.SendCoinsButton.TabIndex = 6;
            this.SendCoinsButton.Text = "Send coins now";
            this.SendCoinsButton.UseVisualStyleBackColor = false;
            this.SendCoinsButton.Click += new System.EventHandler(this.SendCoinsButton_Click);
            // 
            // GeneratePaymentButton
            // 
            this.GeneratePaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GeneratePaymentButton.FlatAppearance.BorderSize = 0;
            this.GeneratePaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GeneratePaymentButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeneratePaymentButton.ForeColor = System.Drawing.Color.White;
            this.GeneratePaymentButton.Location = new System.Drawing.Point(717, 199);
            this.GeneratePaymentButton.Name = "GeneratePaymentButton";
            this.GeneratePaymentButton.Size = new System.Drawing.Size(115, 27);
            this.GeneratePaymentButton.TabIndex = 7;
            this.GeneratePaymentButton.Text = "Generate";
            this.GeneratePaymentButton.UseVisualStyleBackColor = false;
            this.GeneratePaymentButton.Click += new System.EventHandler(this.GeneratePaymentButton_Click);
            // 
            // NumOfCoinsToSend
            // 
            this.NumOfCoinsToSend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NumOfCoinsToSend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumOfCoinsToSend.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumOfCoinsToSend.Location = new System.Drawing.Point(297, 289);
            this.NumOfCoinsToSend.Name = "NumOfCoinsToSend";
            this.NumOfCoinsToSend.Size = new System.Drawing.Size(276, 26);
            this.NumOfCoinsToSend.TabIndex = 8;
            this.NumOfCoinsToSend.Text = "0.00000000";
            this.NumOfCoinsToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumOfCoinsToSend.TextChanged += new System.EventHandler(this.NumOfCoinsToSend_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of coins to send";
            // 
            // SendCoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 424);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfCoinsToSend);
            this.Controls.Add(this.GeneratePaymentButton);
            this.Controls.Add(this.SendCoinsButton);
            this.Controls.Add(this.SendToAddressLabel);
            this.Controls.Add(this.PaymentIdLabel);
            this.Controls.Add(this.SendToAddressBox);
            this.Controls.Add(this.PaymentIdBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SendCoins";
            this.Text = "Send coins dialog";
            this.Load += new System.EventHandler(this.SendCoins_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PaymentIdBox;
        private System.Windows.Forms.TextBox SendToAddressBox;
        private System.Windows.Forms.Label PaymentIdLabel;
        private System.Windows.Forms.Label SendToAddressLabel;
        private System.Windows.Forms.Button SendCoinsButton;
        private System.Windows.Forms.Button GeneratePaymentButton;
        private System.Windows.Forms.TextBox NumOfCoinsToSend;
        private System.Windows.Forms.Label label1;
    }
}