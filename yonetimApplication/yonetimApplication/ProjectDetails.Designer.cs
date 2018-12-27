namespace yonetimApplication
{
    partial class ProjectDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelTask = new System.Windows.Forms.Label();
            this.labelPersonel = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.dataGridViewPerson = new System.Windows.Forms.DataGridView();
            this.labelPM = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.labelTask);
            this.panel1.Controls.Add(this.labelPersonel);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.dataGridViewTask);
            this.panel1.Controls.Add(this.dataGridViewPerson);
            this.panel1.Controls.Add(this.labelPM);
            this.panel1.Controls.Add(this.labelP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 521);
            this.panel1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelStatus.Location = new System.Drawing.Point(564, 465);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(104, 16);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Processing...%0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(567, 484);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(351, 25);
            this.progressBar.TabIndex = 8;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTask.Location = new System.Drawing.Point(563, 90);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(51, 20);
            this.labelTask.TabIndex = 7;
            this.labelTask.Text = "Tasks";
            // 
            // labelPersonel
            // 
            this.labelPersonel.AutoSize = true;
            this.labelPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonel.Location = new System.Drawing.Point(20, 90);
            this.labelPersonel.Name = "labelPersonel";
            this.labelPersonel.Size = new System.Drawing.Size(67, 20);
            this.labelPersonel.TabIndex = 7;
            this.labelPersonel.Text = "Persons";
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(939, 466);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(75, 43);
            this.buttonReport.TabIndex = 6;
            this.buttonReport.Text = "&Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonProjectReport_Click);
            // 
            // dataGridViewTask
            // 
            this.dataGridViewTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(567, 113);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.Size = new System.Drawing.Size(450, 343);
            this.dataGridViewTask.TabIndex = 5;
            // 
            // dataGridViewPerson
            // 
            this.dataGridViewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPerson.Location = new System.Drawing.Point(24, 113);
            this.dataGridViewPerson.Name = "dataGridViewPerson";
            this.dataGridViewPerson.Size = new System.Drawing.Size(450, 343);
            this.dataGridViewPerson.TabIndex = 4;
            // 
            // labelPM
            // 
            this.labelPM.AutoSize = true;
            this.labelPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPM.Location = new System.Drawing.Point(156, 47);
            this.labelPM.Name = "labelPM";
            this.labelPM.Size = new System.Drawing.Size(91, 16);
            this.labelPM.TabIndex = 3;
            this.labelPM.Text = "labelProjectM";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelP.Location = new System.Drawing.Point(156, 19);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(80, 16);
            this.labelP.TabIndex = 2;
            this.labelP.Text = "labelProject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project Manager : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name : ";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            // 
            // ProjectDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 545);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectDetails";
            this.Text = "ProjectDetails";
            this.Load += new System.EventHandler(this.ProjectDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPerson)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPM;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.DataGridView dataGridViewPerson;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.Label labelPersonel;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}