using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetimApplication.Controller.ProjectController;

namespace yonetimApplication
{
    public partial class ProjectModal : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();      
        private string role;
        private int id;   
        private string state;
        private List<int> pmIds = new List<int>();
        public ProjectModal()
        {
            InitializeComponent();
        }
        public ProjectModal(string state)
        {
            InitializeComponent();
            this.state = state;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }
        public ProjectModal(int id,string role, string state)
        {
            InitializeComponent();
            this.id = id;
            this.role = role;
            this.state = state;

        }

        private void ProjectModal_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            setProjectManager();
            if (state == "edit")
            {           
            setProject(id);
                editable();
            }else if (state == "new")
            {
                projectId.Visible = false;
                editable();
                comboBoxManager.Text = "Select Project Manager";
                comboBoxStatus.Text = "Select Status";
                textBoxProjectName.Enabled = true;
                comboBoxManager.Enabled = true;
            }
            else
            {
                comboBoxManager.Enabled = false;
                setProject(id);
            }
        
        }

        private void setProject(int id)
        {
            var project = ProjectController.listProjectById(id);
            
            projectIDs.Text = project.projectId.ToString();
            textBoxProjectName.Text = project.projectName;
            richTBDescription.Text = project.projectDescription;
            comboBoxStatus.Text = project.projectStatus;
            comboBoxManager.Text = getProjectManager();
            dateTimePickerStartDate.Value = project.projectStartDate;
            dateTimePickerLastUpdate.Value = project.projectLastUpdated;
            dateTimePickerDeadline.Value = project.projectDeadLine;
        }
        private void editable()
        {
            richTBDescription.Enabled = true;
            comboBoxStatus.Enabled = true;
            dateTimePickerDeadline.Enabled = true;
            buttonSave.Visible = true;
        }
        private string getProjectManager()
        {
             var x = from personel in db.tbl_ProjectManager
                           from project in db.tbl_Project
                           where project.projectId == id && project.projectProjectManagerId == personel.projectManagerId
                           select new
                           {
                               ProjectManagerName = personel.projectManagerName,
                               ProjectManagerSurname = personel.projectManagerSurname

                           };
            var projectManager = x.ToList();
            return projectManager[0].ProjectManagerName + " " + projectManager[0].ProjectManagerSurname;      
        }
        private void setProjectManager()
        {
            var projectManagerList = db.tbl_ProjectManager.ToList();
            foreach (var projectManager in projectManagerList)
            {
                pmIds.Add(projectManager.projectManagerId);
                comboBoxManager.Items.Add(projectManager.projectManagerName + " " + projectManager.projectManagerSurname);
            }
        }
        private Boolean control()
        {
            if (textBoxProjectName.Text != "" && richTBDescription.Text != "" 
                && comboBoxManager.SelectedIndex != -1 && comboBoxStatus.SelectedIndex != -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (control())
            {
                if (state == "new")
                {
                    ProjectController.createProject(textBoxProjectName.Text, richTBDescription.Text, dateTimePickerDeadline.Value,
                                                    comboBoxStatus.SelectedItem.ToString(), pmIds[comboBoxManager.SelectedIndex]);
                    this.Close();
                }
                ProjectController.updateProject(textBoxProjectName.Text, richTBDescription.Text, dateTimePickerDeadline.Value,
                                                    comboBoxStatus.SelectedItem.ToString(), pmIds[comboBoxManager.SelectedIndex]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
        }

        private void comboBoxManager_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxStatus_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }
    }
}
