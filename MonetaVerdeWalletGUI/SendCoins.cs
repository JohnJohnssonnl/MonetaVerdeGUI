using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonetaVerdeWalletGUI
{
    public partial class SendCoins : Form
    {
        Wallet  caller;
        String  sendToAddress;
        String  PaymentId;
        String  coinsToSend;

        public SendCoins()
        {
            InitializeComponent();
        }

        private void SendCoins_Load(object sender, EventArgs e)
        {

        }

        public Wallet parmCaller(Wallet _caller)
        {
            caller = _caller;

            return caller;
        }

        //Generate Payment ID
        private static string GenPaymId()
        {
            // 64 character precision or 256-bits
            Random rdm = new Random();
            string hexValue = string.Empty;
            int num;

            for (int i = 0; i < 8; i++)
            {
                num = rdm.Next(0, int.MaxValue);
                hexValue += num.ToString("X8");
            }

            return hexValue;
        }

        public void WriteSuccess(string _result)
        {
            //Money transferred succesfully
            MessageBox.Show("Coins sent OK: " + _result);
        }

        private void GeneratePaymentButton_Click(object sender, EventArgs e)
        {
            PaymentId = GenPaymId();
            Clipboard.SetText(PaymentId);
            PaymentIdBox.Text = PaymentId;
            MessageBox.Show("Payment ID copied to clipboard, save it for yourself");
        }

        private void SendCoinsButton_Click(object sender, EventArgs e)
        {
            if (sendToAddress != "" && coinsToSend != "")
            {
                caller.PerformSendCoins(sendToAddress, PaymentId, coinsToSend);
                this.Close();
            }
            else
            {
                MessageBox.Show("You need to fill in at least the send to address and the number of coins ");
            }
        }

        private void SendToAddressBox_TextChanged(object sender, EventArgs e)
        {
            sendToAddress = SendToAddressBox.Text;
        }

        private void NumOfCoinsToSend_TextChanged(object sender, EventArgs e)
        {
            coinsToSend = NumOfCoinsToSend.Text;
        }
    }
}
