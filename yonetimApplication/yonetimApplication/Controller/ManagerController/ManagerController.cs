using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller.ManagerController
{
    public class ManagerController
    {
        static ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        static tbl_Manager manager = new tbl_Manager();

        public static List<tbl_Manager> listManager()
        {
            return db.tbl_Manager.ToList();
        }
        public static tbl_Manager setManager(int id)
        {
            manager = db.tbl_Manager.First(p => p.managerId == id);
            return manager;
        }
        public static void deleteManager(int id)
        {
            try
            {
                manager = db.tbl_Manager.First(p => p.managerId == id);
                db.tbl_Manager.Remove(manager);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete failed");
            }
        }
        public static void updateManager(string name, string surname, string mail, string team,string location)
        {
            manager.managerName = name;
            manager.managerTeam = team;
            manager.managerMail = mail;
            manager.managerSurname = surname;
            manager.managerLocation = location;
            db.SaveChanges();
        }
        public static void createManager(string name, string surname, string team, string mail, string location)
        {
            var now = DateTime.Now;
            manager.managerName = name;
            manager.managerSurname = surname;
            manager.managerTeam = team;
            manager.managerMail = mail;
            manager.managerLocation = location;
            manager.managerStartDate = now;
            db.tbl_Manager.Add(manager);
            db.SaveChanges();
        }
    }
}
