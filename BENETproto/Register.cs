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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Show();
            this.Hide();
        }


        private void btn_Register_Click(object sender, EventArgs e)
        {
            User.username = tb_Username.Text;
            User.password = tb_Password.Text;
            string message = "Silakan login";
            string title = "Berhasil Register";
            MessageBox.Show("Berhasil Register dengan Username " + User.username);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                var Login = new Login();
                Login.Show();
                this.Close();
            }
            else
            {
                var Register = new Register();
                Register.Show();
                this.Hide();
            }

        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
