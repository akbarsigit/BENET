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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            var MainMenu = new MainMenu();
            MainMenu.Show();
            this.Hide();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == User.username && tb_Password.Text == User.password)
            {
                string message = "Selamat anda telah login ke BENET";
                string title = "Berhasil Login";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Login lagi?";
                string title = "GAGAL LOGIN";
                MessageBox.Show("Username atau Password salah");
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
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
