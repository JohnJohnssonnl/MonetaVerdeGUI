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
    public partial class StartMining : Form
    {
        Wallet Caller;

        public StartMining()
        {
            InitializeComponent();
        }

        public Wallet parmCaller(Wallet _caller)
        {
            //Connect to the parent Object
            Caller = _caller;

            return Caller;
        }

        private void StartMiningButton_Click(object sender, EventArgs e)
        {
            Caller.StartMiningFromGUI(Convert.ToInt32(NumOfThreadsBox.Text));
            this.Close();
        }
    }
}
