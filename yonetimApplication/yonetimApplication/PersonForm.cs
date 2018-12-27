using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetimApplication.Controller.PersonelController;
using yonetimApplication.Controller.LoginController;
using yonetimApplication.Controller.ProjectManagerController;
using yonetimApplication.Controller.ManagerController;
using yonetimApplication.Controller.ProjectController;
using yonetimApplication.Controller.TaskController;

namespace yonetimApplication
{
    public partial class PersonForm : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        string role;

        private int userId, projectId, taskId;
        public PersonForm(int id, string role)
        {
            InitializeComponent();
            this.userId = id;
            this.role = role;
        }
        private void PersonForm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            userCheck(role);
        }

        private bool editControl()
        {
            if (textBoxName.Text == "" || textBoxSurname.Text == "" || textBoxLocation.Text == "")
            {
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Edit")
            {
                openEdit();
                button1.Text = "Save";
            }
            else
            {
                if (editControl())
                {
                    update();
                    db.SaveChanges();
                    button1.Text = "Edit";
                    closeEdit();
                }
                else
                {
                    MessageBox.Show("Lütfen bütün alanları doldurunuz.");
                }
            }
        }
        private void closeEdit()
        {
            textBoxName.Enabled = false;
            textBoxSurname.Enabled = false;
            textBoxLocation.Enabled = false;
            textBoxTeam.Enabled = false;
            textBoxEmail.Enabled = false;
        }
        private void openEdit()
        {
            textBoxName.Enabled = true;
            textBoxSurname.Enabled = true;
            textBoxLocation.Enabled = true;
            textBoxTeam.Enabled = true;
            if(role == "m")
            {
                textBoxEmail.Enabled = true;
            }
        }
        private void userCheck(string role)
        {
            if (role == "p")
            {
                var x = PersonelController.setPersonelById(userId);
                setUser(x.personelId, x.personelName, x.personelSurname, x.personelMail, x.personelTeam, x.personelStartDate, x.personelLocation);
                setPersonProjects(userId);
                setPersonTasks(userId);
            }
            else if (role == "pm")
            {
                var x = ProjectManagerController.setProjectManagerByUserId(userId);
                setUser(x.projectManagerId, x.projectManagerName, x.projectManagerSurname
                   , x.projectManagerEmail, x.projectManagerTeam, x.projectManagerStartDate,
                   x.projectManagerLocation);
                setProjectManagerProjects(userId);
                setProjectManagerTasks(userId);
            }
            else
            {
                var x = ManagerController.setManager(userId);
                setUser(x.managerId, x.managerName, x.managerSurname, x.managerMail,
                    x.managerTeam, x.managerStartDate, x.managerLocation);
                setProjects();
                tabControl1.TabPages.Remove(tabPage2);
            }
        }
        private void setUser(int id, string name, string surname, string email, string team, DateTime date, string location)
        {
            personId.Text = id.ToString();
            textBoxName.Text = name;
            textBoxSurname.Text = surname;
            textBoxEmail.Text = email;
            textBoxTeam.Text = team;
            dateTimePickerSD.Value = date;
            textBoxLocation.Text = location;
        }
        private void update()
        {
            if (role == "pm")
            {
                ProjectManagerController.updateProjectManager(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxLocation.Text);
                MessageBox.Show("Successful");
            }
            else if (role == "p")
            {
                PersonelController.updatePersonel(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxLocation.Text);
                MessageBox.Show("Successful");
            }
            else
            {
                ManagerController.updateManager(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, textBoxTeam.Text, textBoxLocation.Text);
                MessageBox.Show("Successful");
            }
        }
        private void setPersonProjects(int id)
        {
            dataGridViewProjects.DataSource = ProjectController.getProjectsByPersonelId(userId);
            this.dataGridViewProjects.Columns["projectProjectManagerId"].Visible = false;
            //  this.dataGridViewProjects.Columns["tbl_Personel"].Visible = false;
            this.dataGridViewProjects.Columns["projectStartDate"].Visible = false;
            this.dataGridViewProjects.Columns["projectDeadLine"].Visible = false;
            this.dataGridViewProjects.Columns["projectLastUpdated"].Visible = false;
            //this.dataGridViewProjects.Columns["tbl_TaskForPersonel"].Visible = false;
            //this.dataGridViewProjects.Columns["tbl_ProjectManager"].Visible = false;
            //this.dataGridViewProjects.Columns["tbl_TaskforProjectManager"].Visible = false;
        }
        private void setProjectManagerProjects(int id)
        {
            dataGridViewProjects.DataSource = ProjectController.listProjectByProjectManagerId(id);
            this.dataGridViewProjects.Columns["projectProjectManagerId"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_Personel"].Visible = false;
            this.dataGridViewProjects.Columns["projectStartDate"].Visible = false;
            this.dataGridViewProjects.Columns["projectDeadLine"].Visible = false;
            this.dataGridViewProjects.Columns["projectLastUpdated"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_TaskForPersonel"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_ProjectManager"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_TaskforProjectManager"].Visible = false;
        }
        private void setProjects()
        {
            dataGridViewProjects.DataSource = ProjectController.listProject();
            this.dataGridViewProjects.Columns["projectProjectManagerId"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_Personel"].Visible = false;
            this.dataGridViewProjects.Columns["projectStartDate"].Visible = false;
            this.dataGridViewProjects.Columns["projectDeadLine"].Visible = false;
            this.dataGridViewProjects.Columns["projectLastUpdated"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_TaskForPersonel"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_ProjectManager"].Visible = false;
            this.dataGridViewProjects.Columns["tbl_TaskforProjectManager"].Visible = false;
        }
        private void setPersonTasks(int id)
        {
            dataGridViewTasks.DataSource = TaskController.listTaskForPersonelByPersonelId(id);
            dataGridViewTasks.Columns["taskID"].Visible = false;
            dataGridViewTasks.Columns["tbl_Personel"].Visible = false;
            dataGridViewTasks.Columns["tbl_Project"].Visible = false;
            dataGridViewTasks.Columns["taskPersonId"].Visible = false;
            dataGridViewTasks.Columns["taskProjectId"].Visible = false;
        }
        private void setProjectManagerTasks(int id)
        {
            dataGridViewTasks.DataSource = TaskController.listTaskforProjectManagerById(id);
            dataGridViewTasks.Columns["taskID"].Visible = false;
            dataGridViewTasks.Columns["taskProjectManagerId"].Visible = false;
            dataGridViewTasks.Columns["taskProjectId"].Visible = false;
        }
        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            using (var cp = new PasswordChange(LoginController.getPassByUserId(userId), userId))
                cp.ShowDialog();
        }
        private void setProjectId()
        {
            try
            {
                if (role == "p")
                {
                    projectId = ProjectController.getProjectIdByTaskPersonelId(taskId);
                }
                else if (role == "pm")
                {
                    projectId = ProjectController.getProjectIdByTaskProjectManagerId(taskId);
                }
            }
            catch (Exception)
            {
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            setProjectId();
            try
            {
                var nt = new TaskModal(role,"edit",userId, taskId, projectId, "pf");
                nt.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Task");
            }
            finally
            {
                userCheck(role);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (role == "p")
                {
                    TaskController.taskDeleteFromPersonel(taskId);
                }
                else
                {
                    TaskController.taskDeleteFromProjectManager(taskId);
                }
                MessageBox.Show("Successful");
                userCheck(role);
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
            }
        }
        private void dataGridViewProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            using (var pm = new ProjectModal(projectId, role, "info"))
                pm.ShowDialog();
        }

        private void buttonNew_Click_1(object sender, EventArgs e)
        {
            try
            {
                var nt = new TaskModal(role, "new",userId , "pf");
                nt.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Add Failed");
            }
            finally
            {
                userCheck(role);
            }
        }

        private void dataGridViewTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tm = new TaskModal(role, "info",userId, taskId, projectId, "pf");
            tm.ShowDialog();
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            taskId = (int)dataGridViewTasks.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dataGridViewProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                projectId = (int)dataGridViewProjects.Rows[e.RowIndex].Cells[0].Value;
            }
        }
    }
}
