using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using yonetimApplication.Controller.PersonelController;
using yonetimApplication.Controller.ProjectController;
using yonetimApplication.Controller.ProjectManagerController;
using yonetimApplication.Controller.TaskController;

namespace yonetimApplication
{
    public partial class ProjectDetails : Form
    {
        struct PersonData
        {
            public List<sp_report_PersonnelinProject_Result> PersonList;
            public string FileName { get; set; }
        }
        struct TaskData
        {
            public List<sp_report_TaskinProject_Result> TaskList;
            public string FileName { get; set; }
        }
        PersonData _inputPerson;
        TaskData _inputTask;

        private int id;

        public ProjectDetails(int pID)
        {
            this.id = pID;
            InitializeComponent();
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            listView(id);
            setLabel(id);

        }

        private void listView(int id)
        {
            dataGridViewPerson.DataSource = PersonelController.reportPersosProject(id);
            dataGridViewTask.DataSource = TaskController.reportTaskinProject(id);
        }
        private void setLabel(int id)
        {
            labelP.Text = ProjectController.getProjectNameById(id);
            labelPM.Text = ProjectManagerController.getProjectManagerNameByProjectId(id);
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            List<sp_report_PersonnelinProject_Result> listPerson = ((PersonData)e.Argument).PersonList;
            string fileName = ((PersonData)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = listPerson.Count;

            //Add Column
            ws.Cells[1, 1] = "Name";
            ws.Cells[1, 2] = "Surname";
            ws.Cells[1, 3] = "Location";

            foreach (var p in listPerson)
            {
                if (!backgroundWorker.CancellationPending)
                {
                    backgroundWorker.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = p.personelName;
                    ws.Cells[index, 2] = p.personelSurname;
                    ws.Cells[index, 3] = p.personelLocation;
                }
            }
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            labelStatus.Text = string.Format("Processing...{0}", e.ProgressPercentage);
            progressBar.Update();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                Thread.Sleep(100);
                labelStatus.Text = "Your data has been succesfully exported.";
            }
        }
        private void buttonProjectReport_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            labelStatus.Visible = true;
            if (backgroundWorker.IsBusy)
                return;
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Excel Workbook| *.xls"
            })
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    _inputPerson.FileName = sfd.FileName;
                    sfd.Title = "Save Persons";
                    _inputPerson.PersonList = dataGridViewPerson.DataSource as List<sp_report_PersonnelinProject_Result>;
                    progressBar.Minimum = 0;
                    progressBar.Value = 0;
                    backgroundWorker.RunWorkerAsync(_inputPerson);
                }
            //using (SaveFileDialog sfd = new SaveFileDialog()
            //{
            //    Filter = "Excel Workbook| *.xls"
            //})
            //    if (sfd.ShowDialog() == DialogResult.OK)
            //    {
            //        _inputTask.FileName = sfd.FileName;
            //        sfd.Title = "Save Tasks";
            //        _inputTask.TaskList = dataGridViewTask.DataSource as List<sp_report_TaskinProject_Result>;;
            //        backgroundWorker2.RunWorkerAsync(_inputTask);
            //    }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            List<sp_report_TaskinProject_Result> listTask = ((TaskData)e.Argument).TaskList;
            string fileName = ((TaskData)e.Argument).FileName;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)excel.ActiveSheet;
            excel.Visible = false;
            int index = 1;
            int process = listTask.Count;

            //Add Column
            ws.Cells[1, 1] = "taskName";
            ws.Cells[1, 2] = "taskDesc";
            ws.Cells[1, 3] = "taskStatus";
            foreach (var t in listTask)
            {
                if (!backgroundWorker2.CancellationPending)
                {
                    backgroundWorker2.ReportProgress(index++ * 100 / process);
                    ws.Cells[index, 1] = t.taskName;
                    ws.Cells[index, 2] = t.taskDescription;
                    ws.Cells[index, 3] = t.taskStatus;
                }
            }
            ws.SaveAs(fileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
            excel.Quit();
        }
    }
}
