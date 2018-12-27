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
using yonetimApplication.Controller.ProjectController;
using yonetimApplication.Controller.TaskController;

namespace yonetimApplication
{
    public partial class AddPersonToProject : Form
    {
        ProjeGorevTakipSistemiEntities db = new ProjeGorevTakipSistemiEntities();
        tbl_TaskforPersonel tfp = new tbl_TaskforPersonel();
        private List<string> taskDesc = new List<string>();
        private List<string> taskStatus = new List<string>();
        private List<DateTime> taskDeadline = new List<DateTime>();
        private List<int> taskIDs = new List<int>();
        private int id;
        private int userId;
        private int kontrol = 0;
        public AddPersonToProject(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AddPersonToProject_Load(object sender, EventArgs e)
        {
            listPeople(id);
        }
        private void listPeople(int id)
        {
            dataGridViewAP.DataSource = PersonelController.listAvailablePersonel(id);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (control())
            {             
                ProjectController.includePersonToProject(userId , id);
                Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
            }
        }

        private void dataGridViewAP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kontrol = 1;
            if (e.RowIndex != -1)
            {
                userId = (int)dataGridViewAP.Rows[e.RowIndex].Cells[0].Value;
            }           
        }
        private bool control()
        {
            if (kontrol != 0)
            {
                return true;
            }
            {

                return false;
            }
        }
    }
}
