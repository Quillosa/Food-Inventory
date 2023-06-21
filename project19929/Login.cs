using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project19929
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string adminname = "admin";
            string adminpass = "admin";

            if (nametb.Text == adminname || passtb.Text == adminpass)
            {
                this.Hide();
                MainMenu menu = new MainMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }


        }
    }
}
