using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller.PersonelController
{
    public class PersonelController
    {
        static ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        static tbl_Personel personel = new tbl_Personel();
        public static tbl_Personel setPersonelById(int id)
        {
            personel = db.tbl_Personel.First(p => p.personelId == id);
            return personel;
        }
        public static List<sp_getPersonelByProjectId_Result> listPersonelByProjectId(int id)
        {
            return db.sp_getPersonelByProjectId(id).ToList();
            
        }
        public static List<sp_report_PersonnelinProject_Result> reportPersosProject(int id)
        {
            return db.sp_report_PersonnelinProject(id).ToList();
        }
        public static List<sp_getAvailablePersonelByProjectId_Result> listAvailablePersonel(int id)
        {
            return db.sp_getAvailablePersonelByProjectId(id).ToList();
        }
        public static List<tbl_Personel> listPersonel()
        {
            return db.tbl_Personel.ToList();
        }
        public static int getPersonIdByTaskId(int id)
        {
            return db.tbl_TaskforPersonel.First(p => p.taskId == id).taskPersonId;
        }
        public static void updatePersonel(string name, string surname,string mail, string location)
        {
            personel.personelName = name;
            personel.personelMail = mail;
            personel.personelSurname = surname;
            personel.personelLocation = location;
            db.SaveChanges();
        }
        public static void createPersonel(string name, string surname, string team, string mail, string location)
        {
            var now = DateTime.Now;
            personel.personelName = name;
            personel.personelSurname = surname;
            personel.personelTeam = team;
            personel.personelMail = mail;
            personel.personelLocation = location;
            personel.personelStartDate = now;
            db.tbl_Personel.Add(personel);
            db.SaveChanges();
        }
        public static void deletePersonel(int id)
        {
            try
            {
                db.sp_delete_Personel(id);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete failed");
            }
        }
        public static void editPersonel(string name, string surname,string mail, string team, string location)
        {
            personel.personelName = name;
            personel.personelMail = mail;
            personel.personelSurname = surname;
            personel.personelTeam = team;
            personel.personelLocation = location;
            db.SaveChanges();
        }
    }
}

