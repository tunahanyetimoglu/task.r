using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetimApplication.Controller.TaskController;
using yonetimApplication.Controller.ProjectController;
using yonetimApplication.Controller.PersonelController;
using System.Threading;
using Microsoft.Office.Interop.Excel;

namespace yonetimApplication
{
    public partial class mainForm : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        tbl_Personel personel = new tbl_Personel();
        tbl_Project project = new tbl_Project();
        private Login loginForm;
        private string role;
        private string projectName;
        private int personId;
        private int userId;
        private int managerId;
        private int projectId = 1;
        private int taskId;


        public mainForm(string role, int userId, Form callingForm)
        {
            loginForm = callingForm as Login;
            InitializeComponent();
            this.role = role;
            this.userId = userId;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            roleController(role);
            listProject();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit application?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                this.FormClosing += mainForm_FormClosing;
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void listPersonelTasks(int id)
        {
            dataGridViewTasks.DataSource = TaskController.listTaskforPersonelById(id);
            dataGridViewTasks.Columns["taskID"].Visible = false;
            dataGridViewTasks.Columns["tbl_Personel"].Visible = false;
            dataGridViewTasks.Columns["tbl_Project"].Visible = false;
            dataGridViewTasks.Columns["taskPersonId"].Visible = false;
            dataGridViewTasks.Columns["taskProjectId"].Visible = false;
        }
        private void listProject()
        {
            dataGridViewProject.DataSource = ProjectController.listProject();
            this.dataGridViewProject.Columns["projectProjectManagerId"].Visible = false;
            this.dataGridViewProject.Columns["tbl_Personel"].Visible = false;
            this.dataGridViewProject.Columns["projectStartDate"].Visible = false;
            this.dataGridViewProject.Columns["projectDeadLine"].Visible = false;
            this.dataGridViewProject.Columns["projectLastUpdated"].Visible = false;
            this.dataGridViewProject.Columns["tbl_TaskForPersonel"].Visible = false;
            this.dataGridViewProject.Columns["tbl_ProjectManager"].Visible = false;
            this.dataGridViewProject.Columns["tbl_TaskforProjectManager"].Visible = false;

        }
        private void listPeople(int id)
        {

            dataGridViewPeople.DataSource = PersonelController.listPersonelByProjectId(id);

        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listProject();
            listPersonelTasks(projectId);
            listPeople(projectId);
        }

        private void dataGridViewProject_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex != -1)
            {
                projectName = (string)dataGridViewProject.Rows[e.RowIndex].Cells[2].Value;
                projectId = (int)dataGridViewProject.Rows[e.RowIndex].Cells[0].Value;
                managerId = (int)dataGridViewProject.Rows[e.RowIndex].Cells[1].Value;
            }
            listPeople(projectId);
            listPersonelTasks(projectId);
            peopleController(managerId);
        }
        private void peopleController(int id)
        {
            if (id == userId)
            {
                buttonExclude.Enabled = true;
                buttonInclude.Enabled = true;
                buttonProjectEdit.Enabled = true;
                buttonTaskDelete.Enabled = true;
                buttonTaskEdit.Enabled = true;
                buttonTaskNew.Enabled = true;
            }
            else
            {
                if (role != "m")
                {
                    buttonExclude.Enabled = false;
                    buttonInclude.Enabled = false;
                    buttonProjectEdit.Enabled = false;
                }
            }
        }
        private void roleController(string role)
        {
            if (role == "m")
            {
                buttonOn();
            }
            else if (role == "pm")
            {
                buttonProjectDelete.Visible = false;
                buttonManagePeople.Visible = false;
                buttonProjectNew.Visible = false;
                buttonExclude.Enabled = false;
                buttonInclude.Enabled = false;
                buttonProjectEdit.Enabled = false;
            }
            else
            {
                buttonOff();
            }
        }
        private void buttonOff()
        {
            buttonProjectDelete.Visible = false;
            buttonProjectEdit.Visible = false;
            buttonManagePeople.Visible = false;
            buttonExclude.Visible = false;
            buttonInclude.Visible = false;
            buttonProjectNew.Visible = false;
            buttonTaskNew.Visible = false;
            buttonTaskEdit.Visible = false;
            buttonTaskDelete.Visible = false;
        }
        private void buttonOn()
        {
            buttonProjectDelete.Visible = true;
            buttonProjectEdit.Visible = true;
            buttonManagePeople.Visible = true;
            buttonExclude.Visible = true;
            buttonInclude.Visible = true;
            buttonProjectNew.Visible = true;
            buttonInclude.Enabled = true;
            buttonExclude.Enabled = true;
            buttonTaskNew.Enabled = true;
            buttonTaskDelete.Enabled = true;
            buttonTaskEdit.Enabled = true;
        }
        private void buttonProjectEdit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var pm = new ProjectModal(projectId, role, "edit"))
                    pm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Project");
            }
        }

        private void buttonProjectNew_Click(object sender, EventArgs e)
        {
            using (var pm = new ProjectModal("new"))
                pm.ShowDialog();
            listProject();
        }

        private void dataGridViewProject_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var pm = new ProjectModal(projectId, role, "info"))
                pm.ShowDialog();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            using (var mp = new PersonForm(userId, role))
                mp.ShowDialog();
        }
        private void buttonManagePeople_Click(object sender, EventArgs e)
        {
            using (var pl = new ManagePeople())
                pl.ShowDialog();
            listPersonelTasks(projectId);
            listPeople(projectId);
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            try
            {
                using (var aptp = new AddPersonToProject(projectId))
                    aptp.ShowDialog();
                listPeople(projectId);
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Project");
            }
        }

        private void buttonExclude_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.question())
            {
                try
                {
                    ProjectController.excludePersonFromProject(personId, projectId);
                    listPeople(projectId);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void dataGridViewPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                personId = (int)dataGridViewPeople.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void buttonProjectDelete_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.question())
            {
                try
                {
                    ProjectController.deleteProject(projectId);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed");
                }
                finally
                {
                    listProject();
                }
            }
        }

        private void buttonTaskDelete_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.question())
            {
                try
                {
                    TaskController.taskDeleteFromPersonel(taskId);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed");
                }
                finally
                {
                    listPersonelTasks(projectId);
                }
            }
        }

        private void buttonTaskNew_Click(object sender, EventArgs e)
        {
            try
            {
                var nt = new TaskModal(role, "new", projectId);
                nt.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
            }
            finally
            {
                listPersonelTasks(projectId);
            }
        }

        private void buttonTaskEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var nt = new TaskModal(role, "edit", taskId, projectId);
                nt.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Task");
            }
            finally
            {
                listPersonelTasks(projectId);
            }
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                taskId = (int)dataGridViewTasks.Rows[e.RowIndex].Cells[0].Value;
            }
        }

        private void dataGridViewTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TaskController.checkStatus(taskId))
            {
            var nt = new TaskModal(role, "info", taskId, projectId);
            nt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Add Person for this Tasks");
            }
        }
        private void buttonDetail_Click(object sender, EventArgs e)
        {
            try
            {
                var pd = new ProjectDetails(projectId);
                pd.ShowDialog();
            }
            catch (Exception)
            {
            }
        }
    }
}
