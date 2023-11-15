using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mokkiprojekti_ryhma10.Views
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            string username = "admin";
            string password = "1111";
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Give username and password.");
                return;
            }
            if (tbUsername.Text == username & tbPassword.Text == password)
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
