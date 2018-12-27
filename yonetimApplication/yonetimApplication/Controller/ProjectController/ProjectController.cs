using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller.ProjectController
{
    public class ProjectController
    {
        static ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        static tbl_Project project = new tbl_Project();
        public static List<tbl_Project> listProjectByProjectManagerId(int id)
        {
            return db.tbl_Project.Where(p => p.projectProjectManagerId == id).ToList();
        }
        public static List<sp_getProjectsByPersonelId_Result> getProjectsByPersonelId(int id)
        {
            return db.sp_getProjectsByPersonelId(id).ToList();
        }
        public static List<tbl_Project> listProject()
        {
            return db.tbl_Project.ToList();
        }
        public static tbl_Project listProjectById(int id)
        {
            project = db.tbl_Project.First(p => p.projectId == id);
            return project;
        }
        public static string getProjectNameByPersonTaskId(int id)
        {
            return db.tbl_TaskforPersonel.First(p => p.taskId == id).tbl_Project.projectName;
        }
        public static string getProjectNameByProjectManagerTaskId(int id)
        {
            return db.tbl_TaskforProjectManager.First(p => p.taskId == id).tbl_Project.projectName;
        }
        public static void excludePersonFromProject(int personId, int projectId)
        {
            if (personId == 0 || projectId == 0)
            {
                MessageBox.Show("Please, select the person");
            }
            else
            {
                db.sp_excludePersonelFromProject(personId, projectId);
                db.SaveChanges();
            }
        }
        public static void includePersonToProject(int personId, int projectId)
        {
            db.sp_includePersoneltoProject(personId, projectId);
            db.SaveChanges();
        }
        public static int getProjectIdByName(string name)
        {
            return db.tbl_Project.First(p => p.projectName == name).projectId;
        }
        public static string getProjectNameById(int id)
        {
            return db.tbl_Project.First(p => p.projectId == id).projectName;
        }
        public static int getProjectIdByTaskPersonelId(int id)
        {
            return db.tbl_TaskforPersonel.First(p => p.taskId == id).taskProjectId;
        }
        public static int getProjectIdByTaskProjectManagerId(int id)
        {
            return db.tbl_TaskforProjectManager.First(p => p.taskId == id).taskProjectId;
        }
        public static void createProject(string name, string desc, DateTime deadline, string status, int pmid)
        {
            try
            {
                var now = DateTime.Now;
                project.projectName = name;
                project.projectDescription = desc;
                project.projectDeadLine = deadline;
                project.projectStatus = status;
                project.projectProjectManagerId = pmid;
                project.projectStartDate = now;
                project.projectLastUpdated = now;

                db.tbl_Project.Add(project);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Create Error");
            }
        }
        public static void updateProject(string name, string desc, DateTime deadline, string status, int pmid)
        {
            try
            {
                var now = DateTime.Now;
                project.projectName = name;
                project.projectDescription = desc;
                project.projectDeadLine = deadline;
                project.projectStatus = status;
                project.projectProjectManagerId = pmid;
                project.projectStartDate = now;
                project.projectLastUpdated = now;

                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Update Error");
            }

        }
        public static void deleteProject(int id)
        {
            try
            {
                db.sp_tbl_Project_InsteadOfDelete(id);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Delete Error");
            }
        }
    }
}
