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
using yonetimApplication.Controller.ProjectManagerController;
using yonetimApplication.Controller.ManagerController;

namespace yonetimApplication
{
    public partial class UserModal : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        private string role;
        private string state;
        private int id;
        private string name,surname,team,mail,location;
        
        public UserModal(string role)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.role = role;
            this.state = "new";
        }
        public UserModal(int id,string role)
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.id = id;
            this.role = role;
            this.state = "edit";
            setUser(id);
        }


        private void AddUser_Load(object sender, EventArgs e)
        {
            if(state == "edit")
            {
                buttonSave.Text = "Save";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (control())
            {
                setProperty();
                if (role == "p") {
                    if(state == "new")
                    {
                        PersonelController.createPersonel(name, surname, team, mail, location);
                        this.Close();
                    }
                    PersonelController.editPersonel(name, surname, mail, team, location);
                    this.Close();                  
                }
                else if(role == "pm")
                {
                    if(state == "new") {
                        ProjectManagerController.createProjectManager(name, surname, mail, team, location);
                        this.Close();
                    }
                    ProjectManagerController.editProjectManager(name, surname, mail, team, location);
                    this.Close();
                }
                else
                {
                    if(state == "new")
                    {
                        ManagerController.createManager(name, surname, team,mail, location);
                        this.Close();
                    }
                    ManagerController.updateManager(name, surname, mail, team, location);
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
        }
        private void setUser(int id)
        {
            if(role == "p")
            {
                var person = PersonelController.setPersonelById(id);
                textBoxName.Text = person.personelName;
                textBoxSurname.Text = person.personelSurname;
                textBoxTeam.Text = person.personelTeam;
                textBoxEmail.Text = person.personelMail;
                textBoxLocation.Text = person.personelLocation;
                dateTimePickerSD.Value = person.personelStartDate;
            }else if(role == "pm")
            {
                var pm = ProjectManagerController.setProjectManagerByUserId(id);
                textBoxName.Text = pm.projectManagerName;
                textBoxSurname.Text = pm.projectManagerSurname;
                textBoxTeam.Text = pm.projectManagerTeam;
                textBoxEmail.Text = pm.projectManagerEmail;
                textBoxLocation.Text = pm.projectManagerLocation;
                dateTimePickerSD.Value = pm.projectManagerStartDate;
            }
            else
            {
                var m = ManagerController.setManager(id);
                textBoxName.Text = m.managerName;
                textBoxSurname.Text = m.managerSurname;
                textBoxTeam.Text = m.managerTeam;
                textBoxEmail.Text = m.managerMail;
                textBoxLocation.Text = m.managerLocation;
                dateTimePickerSD.Value = m.managerStartDate;
            }
        }
        private void setProperty()
        {
            name = textBoxName.Text;
            surname = textBoxSurname.Text;
            location = textBoxLocation.Text;
            team = textBoxTeam.Text;
            mail = textBoxEmail.Text;
        }
        private Boolean control()
        {
            if (textBoxEmail.Text != "" && textBoxLocation.Text != ""
                && textBoxTeam.Text != "" && textBoxName.Text != ""
                && textBoxSurname.Text != "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
