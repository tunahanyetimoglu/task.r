using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetimApplication.Controller.LoginController;
using System.Collections;

namespace yonetimApplication
{
    public partial class Login : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        private int userId;
        private string email;
        private string password;
        private string role;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }
              
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "" && textBoxUsername.Text == "")
            {
                MessageBox.Show("fields cannot be empty");
            }
            else
            {
                email = textBoxUsername.Text;
                password = textBoxPassword.Text;
                if (LoginController.loginControl(email, password))
                {
                    userId = LoginController.getUserIdByMail(email);
                    role = LoginController.getRoleByUserId(userId);
                    if (LoginController.checkFirstLogin(email, password))
                    {
                        MessageBox.Show("First Login");
                        MessageBox.Show("Redirecting to password change");
                        Hide();
                        using (var cp = new PasswordChange(password, userId))
                            cp.ShowDialog();
                        cleartextBox();
                        Show();
                    }
                    else
                    {
                        Hide();
                        using (var mf = new mainForm(role, userId,this))
                            mf.ShowDialog();
                        cleartextBox();
                        Show();
                    }
                }
                else
                {
                    MessageBox.Show("Access failed");
                }
            }
        }
        private void cleartextBox()
        {
            textBoxPassword.Clear();
            textBoxUsername.Clear();
        }

        private void buttonLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

    }
}
