using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller.LoginController
{
    public class LoginController
    {
        static ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        static tbl_Login user;
        public static tbl_Login getUserLoginById(int id)
        {
            user = db.tbl_Login.First(p => p.id == id);
            return user;

        }
        public static string getPassByUserMail(string mail)
        {
            try
            {
                return db.tbl_Login.First(x => x.mail == mail).password;
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Mail");
                return "";
            }
        }
        public static string getPassByUserId(int id)
        {
            try
            {
                return db.tbl_Login.First(x => x.id == id).password;
            }
            catch (Exception)
            {
                MessageBox.Show("failed");
                return "";
            }
        }
        public static string getMailByUserId(int id)
        {
            try
            {
                return db.tbl_Login.First(x => x.id == id).mail;
            }
            catch (Exception)
            {
                MessageBox.Show("failed");
                return "";
            }
        }
        public static bool checkFirstLogin(string mail, string pass)
        {
            if (mail != pass) return false;
            return true;
        }
        public static int getUserIdByMail(string mail)
        {
            try
            {
                return db.tbl_Login.First(x => x.mail == mail).id;
            }
            catch (Exception)
            {
                MessageBox.Show("failed");
                return 0;
            }

        }
        public static string getRoleByUserId(int id)
        {
            try
            {
                return db.tbl_Login.First(x => x.id == id).role;
            }
            catch (Exception)
            {
                MessageBox.Show("failed");
                return "";
            }
        }
        public static bool loginControl(string mail, string pass)
        {
            try
            {
                if (getPassByUserMail(mail) != pass) return false;
                return true;
            }
            catch
            {
                MessageBox.Show("Login Error");
                return false;
            }
            
        }
        public static void updatePassword(string password, int id)
        {
            try
            {
                db.sp_update_PASSWORD(id, password);
                db.SaveChanges();
                MessageBox.Show("Successful!");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
            }

        }
    }
}
