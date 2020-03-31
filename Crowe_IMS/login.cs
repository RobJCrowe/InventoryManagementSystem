using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crowe_IMS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(tbPassword.TextLength==0 || tbUsername.TextLength == 0) { MessageBox.Show("Both the username and password must be filled out."); return; }
            if (!dbHelper.userExists(tbUsername.Text)) return;
            if (!dbHelper.isPassword(tbUsername.Text, tbPassword.Text)) return;
            Form1 formNew = new Form1(this);
            formNew.Show();
            tbUsername.Text = ""; tbPassword.Text = "";
            this.Hide();
        }

        private void closeBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = tbUsername;
        }
    }
}
