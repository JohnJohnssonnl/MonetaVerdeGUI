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
    public partial class Login : Form
    {
        string userNameLocal;
        string passWordLocal;
        Wallet Caller;

        public Login()
        {
            InitializeComponent();
        }

        public Wallet parmCaller(Wallet _caller)
        {
            //Connect to the parent Object
            Caller = _caller;

            return Caller;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            userNameLocal = UserName.Text;
            LoginButton.Enabled = passWordLocal != "" && userNameLocal != "" ? true : false;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            passWordLocal = Password.Text;

            LoginButton.Enabled = passWordLocal != "" && userNameLocal != "" ? true : false;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            Caller.Login(userNameLocal, passWordLocal, CreateWalletCheckbox.Checked);
            this.Close();
        }
    }
}
