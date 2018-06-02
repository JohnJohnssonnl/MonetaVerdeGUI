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
    public partial class AboutMonetaVerde : Form
    {
        public AboutMonetaVerde()
        {
            InitializeComponent();
        }

        private void GotoMonetaVerdeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://getmonetaverde.org");

        }
    }
}
