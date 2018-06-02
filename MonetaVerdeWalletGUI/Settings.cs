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
    public partial class Settings : Form
    {
        Wallet Caller;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        public void parmSettings(Boolean UseRemoteDaemon, string remoteDaemonIPPlusPort, ListBox _ExclNodesList)
        {
            UseRemoteDaemonInsteadOfLocal.Checked = UseRemoteDaemon;
            RemoteDaemonIP.Text = remoteDaemonIPPlusPort;
            if (_ExclNodesList!=null)
            {
                DaemonSeedNodesList.Items.AddRange(_ExclNodesList.Items);
            }
        }

        public Wallet parmCaller(Wallet _caller)
        {
            //Connect to the parent Object
            Caller = _caller;

            return Caller;
        }

        private void SettingsSaveAndClose_Click(object sender, EventArgs e)
        {
            //Save settings etc. then close
            Caller.setSettings(UseRemoteDaemonInsteadOfLocal.Checked, RemoteDaemonIP.Text, DaemonSeedNodesList);
            this.Close();
        }

        private void DaemonSeedNodesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddDaemonList_Click(object sender, EventArgs e)
        {
            DaemonSeedNodesList.Items.Add(NewDaemonSeed.Text);
        }
    }
}
