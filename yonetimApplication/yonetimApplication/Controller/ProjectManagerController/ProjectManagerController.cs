using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller.ProjectManagerController
{
    public class ProjectManagerController
    {
        static ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        static tbl_ProjectManager projectManager = new tbl_ProjectManager();

        public static List<tbl_ProjectManager> listProjectManager()
        {
            return db.tbl_ProjectManager.ToList();
        }
        public static tbl_ProjectManager setProjectManagerByUserId(int id)
        {
            projectManager = db.tbl_ProjectManager.First(p => p.projectManagerId == id);
            return projectManager;
        }
        public static string getProjectManagerNameByProjectId(int id)
        {
            int pmid = db.tbl_Project.First(p => p.projectId == id).projectProjectManagerId;
            var pm = db.tbl_ProjectManager.First(p => p.projectManagerId == pmid);
            string name = pm.projectManagerName + " " + pm.projectManagerSurname;
            return name;
        }
        public static void deleteProjectManager(int id)
        {
            try {
                db.sp_delete_ProjectManager(id);
            db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete failed");
            }
}
        public static void updateProjectManager(string name, string surname, string mail, string location)
        {
            projectManager.projectManagerName = name;
            projectManager.projectManagerSurname = surname;
            projectManager.projectManagerLocation = location;
            projectManager.projectManagerEmail = mail;
            db.SaveChanges();
        }
        public static void createProjectManager(string name, string surname,string email, string team, string location)
        {
            var now = DateTime.Now;
            projectManager.projectManagerName = name;
            projectManager.projectManagerSurname = surname;
            projectManager.projectManagerTeam = team;
            projectManager.projectManagerLocation = location;
            projectManager.projectManagerStartDate = now;
            projectManager.projectManagerEmail = email;

            db.tbl_ProjectManager.Add(projectManager);
            db.SaveChanges();
        }
        public static void editProjectManager(string name, string surname,string mail, string team, string location)
        {
            projectManager.projectManagerName = name;
            projectManager.projectManagerEmail = mail;
            projectManager.projectManagerSurname = surname;
            projectManager.projectManagerTeam = team;
            projectManager.projectManagerLocation = location;

            db.SaveChanges();
        }
    }
}
