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
using yonetimApplication.Controller.PersonelController;
using yonetimApplication.Controller.ProjectController;
using yonetimApplication.Controller.ProjectManagerController;

namespace yonetimApplication
{
    public partial class TaskModal : Form
    {
        List<int> pID = new List<int>();
        List<int> projectIDL = new List<int>();
        private string role, state;
        private int id, userId, projectId, perId;
        private string name, desc, status, page;
        private DateTime deadline;
        public TaskModal(string role, string state, int projectId) // MainForm New Task
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.state = state;
            this.role = role;
            this.projectId = projectId;
        }
        public TaskModal(string role, string state, int taskId, int projectId)  // MainForm Edit / İnfo Task
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.state = state;
            this.role = role;
            this.id = taskId;
            this.projectId = projectId;
        }
        public TaskModal(string role, string state, int userId, string page) // PersonForm new Task
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.state = state;
            this.role = role;
            this.userId = userId;
            this.page = page;
            this.perId = userId;
        }
        public TaskModal(string role, string state, int userId, int taskId, int projectId, string page)  // PersonForm Edit
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.projectId = projectId;
            this.role = role;
            this.id = taskId;
            this.page = page;
            this.perId = userId;
            this.state = state;
        }
        private void TaskModal_Load(object sender, EventArgs e)
        {
            try
            {
                setComboBoxProject();
                if (page == "pf")
                {
                    comboBoxPersonel.Enabled = false;
                    if (state == "edit")
                    {
                        editable();
                        if (role == "p")
                        {
                            setComboBoxPersonel();
                            comboBoxProject.Text = ProjectController.getProjectNameByPersonTaskId(id);
                            setPersonTask(id);
                        }
                        else if (role == "pm")
                        {
                            setComboBoxProjectManager();
                            comboBoxProject.Text = ProjectController.getProjectNameByProjectManagerTaskId(id);
                            setProjectManagerTask(id);

                        }
                    }
                    else if (state == "new")
                    {
                        editable();
                        setComboBoxPersonText(userId, role);
                        comboBoxProject.Enabled = true;
                        if (role == "p")
                        {
                            setComboBoxPersonel();
                            buttonSave.Text = "Add";
                        }
                        else if (role == "pm")
                        {
                            setComboBoxProjectManager();
                            buttonSave.Text = "Add";
                        }
                    }
                    else
                    {
                        closeEdit();
                        if (role == "p")
                        {
                            comboBoxProject.Text = ProjectController.getProjectNameByPersonTaskId(id);
                            setPersonTask(id);
                        }
                        else if (role == "pm")
                        {
                            comboBoxProject.Text = ProjectController.getProjectNameByProjectManagerTaskId(id);
                            setProjectManagerTask(id);
                        }
                    }
                }
                else
                {
                    projectIDs.Text = id.ToString();
                    comboBoxProject.Text = getProjectName(projectId);
                    setComboBoxPersonel();
                    if (state == "edit")
                    {
                        editable();
                        setPersonTask(id);
                    }
                    else if (state == "new")
                    {
                        buttonSave.Text = "Add";
                        editable();
                    }
                    else
                    {
                        setPersonTask(id);
                        closeEdit();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Form Load Failed");
                this.Close();
            }
        }
        private int setPersonId(int id)
        {
            return PersonelController.getPersonIdByTaskId(id);
        }
        private void setPersonTask(int id)
        {
            try
            {
                var task = TaskController.getPersonTaskById(id);

                textBoxTaskName.Text = task.taskName;
                richTBDescription.Text = task.taskDescription;
                comboBoxPersonel.Text = task.tbl_Personel.personelName + " " + task.tbl_Personel.personelSurname;
                comboBoxStatus.SelectedItem = task.taskStatus;
                dateTimePickerLastUpdate.Value = task.taskLastUpdated;
                dateTimePickerDeadline.Value = task.taskDeadLine;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Task");
                this.Close();
            }
        }
        private void setComboBoxPersonText(int id, string role)
        {
            if (role == "p")
            {
                var user = PersonelController.setPersonelById(id);
                comboBoxPersonel.Text = user.personelName + " " + user.personelSurname;
            }
            else
            {
                var user = ProjectManagerController.setProjectManagerByUserId(id);
                comboBoxPersonel.Text = user.projectManagerName + " " + user.projectManagerSurname;
            }
        }
        private void setProjectManagerTask(int id)
        {
            try
            {
                var task = TaskController.getProjectManagerTaskById(id);

                textBoxTaskName.Text = task.taskName;
                richTBDescription.Text = task.taskDescription;
                comboBoxPersonel.Text = task.tbl_ProjectManager.projectManagerName + " " + task.tbl_ProjectManager.projectManagerSurname;
                comboBoxStatus.SelectedItem = task.taskStatus;
                dateTimePickerLastUpdate.Value = task.taskLastUpdated;
                dateTimePickerDeadline.Value = task.taskDeadLine;
            }
            catch (Exception)
            {
                MessageBox.Show("Choose Task");
                this.Close();
            }
        }
        private string getProjectName(int id)
        {
            try
            {
                return ProjectController.listProjectById(id).projectName;
            }
            catch (Exception)
            {
                this.Close();
                return "";
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (control())
                {
                    if (page != "pf")
                    {
                        if (state == "edit")
                        {
                            setProperty();
                            TaskController.updateTaskforPersonel(userId, projectId, name, desc, deadline, status);
                        }
                        else if (state == "new")
                        {
                            setProperty();
                            TaskController.createTaskforPersonel(userId, projectId, name, desc, deadline, status);
                        }
                    }
                    else
                    {
                        if (role == "p")
                        {

                            if (state == "edit")
                            {
                                setProperty();
                                TaskController.updateTaskforPersonel(perId, projectId, name, desc, deadline, status);
                            }
                            else if (state == "new")
                            {
                                setProperty();
                                projectId = projectIDL[comboBoxProject.SelectedIndex];
                                TaskController.createTaskforPersonel(perId, projectId, name, desc, deadline, status);
                            }
                        }
                        else
                        {
                            if (state == "edit")
                            {
                                setProperty();
                                TaskController.updateTaskForProjectManager(perId, projectId, name, desc, deadline, status);
                            }
                            else if (state == "new")
                            {
                                setProperty();
                                projectId = projectIDL[comboBoxProject.SelectedIndex];
                                TaskController.createTaskforProjectManager(perId, projectId, name, desc, deadline, status);
                            }
                        }
                    }
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Failed");
            }
        }
        private void comboBoxProject_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxPersonel_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxStatus_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void setProperty()
        {
            name = textBoxTaskName.Text;
            desc = richTBDescription.Text;
            status = comboBoxStatus.Text;
            deadline = dateTimePickerDeadline.Value;
            userId = pID[comboBoxPersonel.SelectedIndex];
        }
        private void setComboBoxPersonel()
        {
            var personellist = PersonelController.listPersonel();
            foreach (var personel in personellist)
            {
                pID.Add(personel.personelId);
                comboBoxPersonel.Items.Add(personel.personelName + " " + personel.personelSurname);
            }
        }
        private void setComboBoxProjectManager()
        {
            var pmList = ProjectManagerController.listProjectManager();
            foreach (var personel in pmList)
            {
                pID.Add(personel.projectManagerId);
                comboBoxPersonel.Items.Add(personel.projectManagerName + " " + personel.projectManagerSurname);
            }
        }
        private void setComboBoxProject()
        {
            var projectList = ProjectController.listProject();
            foreach (var project in projectList)
            {
                projectIDL.Add(project.projectId);
                comboBoxProject.Items.Add(project.projectName);
            }
        }
        private void editable()
        {
            textBoxTaskName.Enabled = true;
            comboBoxPersonel.Enabled = true;
        }
        private void closeEdit()
        {
            textBoxTaskName.Enabled = false;
            comboBoxPersonel.Enabled = false;
            richTBDescription.Enabled = false;
            comboBoxStatus.Enabled = false;
            buttonSave.Visible = false;
            dateTimePickerDeadline.Enabled = false;
            dateTimePickerLastUpdate.Enabled = false;
        }
        private bool control()
        {
            if (comboBoxPersonel.SelectedIndex != 0 && comboBoxStatus.SelectedIndex != 0 && comboBoxPersonel.SelectedIndex != 0
                && textBoxTaskName.Text != "" && richTBDescription.Text != "" ) return true;
            return false;
        }
    }
}
