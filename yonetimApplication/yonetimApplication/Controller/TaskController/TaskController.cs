using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller.TaskController
{
    public class TaskController
    {
        static ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        static tbl_TaskforPersonel taskPersonel = new tbl_TaskforPersonel();
        static tbl_TaskforProjectManager taskProjectManager = new tbl_TaskforProjectManager();

        public static tbl_TaskforPersonel getPersonTaskById(int id) 
        {
            taskPersonel = db.tbl_TaskforPersonel.First(p => p.taskId == id);
            return taskPersonel;
        }
        public static tbl_TaskforProjectManager getProjectManagerTaskById(int id)
        {
            taskProjectManager = db.tbl_TaskforProjectManager.First(p => p.taskId == id);
            return taskProjectManager;
        }
        public static List<tbl_TaskforPersonel> listTaskforPersonelById(int id)
        {
            return db.tbl_TaskforPersonel.Where(p => p.taskProjectId == id).ToList();
        }
        public static List<sp_report_TaskinProject_Result> reportTaskinProject(int id)
        {
            return db.sp_report_TaskinProject(id).ToList();
        }
        public static List<tbl_TaskforPersonel> listTaskForPersonelByPersonelId(int id)
        {
            return db.tbl_TaskforPersonel.Where(p => p.taskPersonId == id).ToList();
        }
        public static tbl_TaskforPersonel getTaskPersonel(int id)
        {
            taskPersonel = db.tbl_TaskforPersonel.First(p => p.taskId == id);
            return taskPersonel;
        }
        public static List<tbl_TaskforProjectManager> listTaskforProjectManagerById(int id)
        {
            return db.tbl_TaskforProjectManager.Where(p => p.taskProjectManagerId == id).ToList();
        }
        public static void createTaskforPersonel(int personId,int projectId,string name, string desc, DateTime deadline, string status)
        {
            try
            {
                var now = DateTime.Now;
                taskPersonel.taskName = name;
                taskPersonel.taskDescription = desc;
                taskPersonel.taskStatus = status;
                taskPersonel.taskProjectId = projectId;
                taskPersonel.taskPersonId = personId;
                taskPersonel.taskDeadLine = deadline;
                taskPersonel.taskLastUpdated = now;

                db.tbl_TaskforPersonel.Add(taskPersonel);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
            }
        }
        public static void createTaskforProjectManager(int managerId, int projectId, string name, string desc, DateTime deadline, string status)
        {
            try
            {
                var now = DateTime.Now;
                taskProjectManager.taskName = name;
                taskProjectManager.taskDescription = desc;
                taskProjectManager.taskStatus = status;
                taskProjectManager.taskProjectId = projectId;
                taskProjectManager.taskProjectManagerId = managerId;
                taskProjectManager.taskDeadLine = deadline;
                taskProjectManager.taskLastUpdated = now;

                db.tbl_TaskforProjectManager.Add(taskProjectManager);
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
            }
        }
        public static void updateTaskforPersonel(int personId, int projectId, string name, string desc, DateTime deadline, string status)
        {
            Console.WriteLine(personId + "  " + projectId + " " + deadline + " " + status + " " + desc + " " + name);
            try
            {
                var now = DateTime.Now;
                taskPersonel.taskName = name;
                taskPersonel.taskDescription = desc;
                taskPersonel.taskStatus = status;
                taskPersonel.taskProjectId = projectId;
                taskPersonel.taskPersonId = personId;
                taskPersonel.taskDeadLine = deadline;
                taskPersonel.taskLastUpdated = now;

                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Update Error");
            }
        }
        public static void updateTaskForProjectManager(int id, int projectId, string name, string desc, DateTime deadline, string status)
        {
            try
            {
                var now = DateTime.Now;
                taskProjectManager.taskName = name;
                taskProjectManager.taskDescription = desc;
                taskProjectManager.taskStatus = status;
                taskProjectManager.taskProjectId = projectId;
                taskProjectManager.taskProjectManagerId = id;
                taskProjectManager.taskDeadLine = deadline;
                taskProjectManager.taskLastUpdated = now;

                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Update Error");
            }
        }
        public static void taskDeleteFromPersonel(int id)
        {
            taskPersonel = db.tbl_TaskforPersonel.First(p => p.taskId == id);
            db.tbl_TaskforPersonel.Remove(taskPersonel);
            db.SaveChanges();
        }
        public static void taskDeleteFromProjectManager(int id)
        {
            taskProjectManager = db.tbl_TaskforProjectManager.First(p => p.taskId == id);
            db.tbl_TaskforProjectManager.Remove(taskProjectManager);
            db.SaveChanges();
        }
        public static bool checkStatus(int id)
        {
            var task = db.tbl_TaskforPersonel.First(p => p.taskId == id).taskStatus;
            if (task == "personnel should be assigned") return false;
            return true;
        }
    }
}
