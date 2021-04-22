using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENETproto
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            var Register = new Register();
            Register.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
