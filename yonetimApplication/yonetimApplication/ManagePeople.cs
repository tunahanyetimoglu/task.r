using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetimApplication.Controller;
using yonetimApplication.Controller.PersonelController;
using yonetimApplication.Controller.ProjectManagerController;
using yonetimApplication.Controller.ManagerController;

namespace yonetimApplication
{
    public partial class ManagePeople : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        private int userId, projectManagerId, managerId;
        public ManagePeople()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void ManagePeople_Load(object sender, EventArgs e)
        {
            listPeople();
            listManager();
            listProjectManager();

        }

        private void listManager()
        {
            dataGridViewM.DataSource = ManagerController.listManager();
        }
        private void listPeople()
        {
            dataGridViewPeople.DataSource = PersonelController.listPersonel();
            this.dataGridViewPeople.Columns["tbl_TaskforPersonel"].Visible = false;
            this.dataGridViewPeople.Columns["tbl_Project"].Visible = false;
        }
        private void listProjectManager()
        {
            dataGridViewPM.DataSource = ProjectManagerController.listProjectManager();
            this.dataGridViewPM.Columns["tbl_Project"].Visible = false;
            this.dataGridViewPM.Columns["tbl_TaskforProjectManager"].Visible = false;      
        }

        private void dataGridViewPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                userId = (int)dataGridViewPeople.Rows[e.RowIndex].Cells[0].Value;
            }
        }
        private void dataGridViewM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                managerId = (int)dataGridViewM.Rows[e.RowIndex].Cells[0].Value;
            }
        }
        private void dataGridViewPM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                projectManagerId = (int)dataGridViewPM.Rows[e.RowIndex].Cells[0].Value;
            }
        }
        private void buttonNewP_Click(object sender, EventArgs e)
        {
            Hide();
            using (var x = new UserModal("p"))
                x.ShowDialog();
            Show();
            listPeople();
        }

        private void buttonNewPM_Click(object sender, EventArgs e)
        {
            Hide();
            using (var x = new UserModal("pm"))
                x.ShowDialog();
            Show();
            listProjectManager();
        }
        private void ButtonNewM_Click(object sender, EventArgs e)
        {
            Hide();
            using (var x = new UserModal("m"))
                x.ShowDialog();
            Show();
            listManager();
        }

        private void buttonEditP_Click(object sender, EventArgs e)
        {
            Hide();
            using (var x = new UserModal(userId, "p"))
                x.ShowDialog();
            Show();
            listManager();
        }

        private void buttonEditPM_Click(object sender, EventArgs e)
        {
            Hide();
            using (var x = new UserModal(projectManagerId, "pm"))
                x.ShowDialog();
            Show();
            listManager();
        }
        private void buttonEditM_Click(object sender, EventArgs e)
        {
            Hide();
            using (var x = new UserModal(managerId, "m"))
                x.ShowDialog();
            Show();
            listManager();
        }

        private void buttonDeletePM_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.question())
            {
                ProjectManagerController.deleteProjectManager(projectManagerId);
                listProjectManager();
            }
        }

        private void buttonDeleteM_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.question())
            {
                ManagerController.deleteManager(managerId);
                MessageBox.Show("Successful");
                listManager();
            }
        }
        private void buttonDeleteP_Click(object sender, EventArgs e)
        {
            if (Controller.Controller.question())
            {
                PersonelController.deletePersonel(userId);
                listPeople();
            }
        }

    }
}
