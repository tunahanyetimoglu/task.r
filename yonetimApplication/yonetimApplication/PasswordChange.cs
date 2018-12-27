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
using yonetimApplication.Controller.PersonelController;

namespace yonetimApplication
{
    public partial class PasswordChange : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        private string oldPass;
        private int id;
        public PasswordChange(string password,int id)
        {
            InitializeComponent();
            this.oldPass = password;
            this.id = id;
        }

        private void buttonRP_Click(object sender, EventArgs e)
        {
            if (checkPassword())
            {
                var x = LoginController.getUserLoginById(id);
                LoginController.updatePassword(textBoxNP.Text,id);
                MessageBox.Show("Your password has been reset.");
                if (routeControl(oldPass))
                {
                    MessageBox.Show("Redirecting to login page");
                }              
                this.Close();          
            }
        }
        private bool checkPassword()
        {
            if(oldPass != textBoxOP.Text)
            {
                MessageBox.Show("Wrong old password");
                return false;
            }
            else
            {
                if (textBoxNP.Text != textBoxCNP.Text)
                {
                    MessageBox.Show("Please, enter the same passwword as above");
                    return false;
                }
                return true;
            }           
        }
        private bool routeControl(string pass)
        {
            string email = LoginController.getMailByUserId(id);
            if (email != pass) return false;
                return true;        
        }

    }
}
