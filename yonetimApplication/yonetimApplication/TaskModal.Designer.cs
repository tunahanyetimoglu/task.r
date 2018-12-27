namespace yonetimApplication
{
    partial class TaskModal
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.taskId = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.Label();
            this.taskDesc = new System.Windows.Forms.Label();
            this.projectLastUpdate = new System.Windows.Forms.Label();
            this.projectDeadline = new System.Windows.Forms.Label();
            this.projectIDs = new System.Windows.Forms.Label();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.richTBDescription = new System.Windows.Forms.RichTextBox();
            this.personelT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectT = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxProject = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(8, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 437);
            this.panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(663, 401);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(102, 32);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.94751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.05249F));
            this.tableLayoutPanel1.Controls.Add(this.taskId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.taskDesc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectLastUpdate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.projectDeadline, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.projectIDs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTaskName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPersonel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerLastUpdate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDeadline, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.richTBDescription, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.personelT, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.projectT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStatus, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxProject, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.37255F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.803922F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // taskId
            // 
            this.taskId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.taskId.AutoSize = true;
            this.taskId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taskId.Location = new System.Drawing.Point(123, 11);
            this.taskId.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.taskId.Name = "taskId";
            this.taskId.Size = new System.Drawing.Size(19, 16);
            this.taskId.TabIndex = 0;
            this.taskId.Text = "Id";
            // 
            // taskName
            // 
            this.taskName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.taskName.AutoSize = true;
            this.taskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taskName.Location = new System.Drawing.Point(97, 49);
            this.taskName.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(45, 16);
            this.taskName.TabIndex = 1;
            this.taskName.Text = "Name";
            // 
            // taskDesc
            // 
            this.taskDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.taskDesc.AutoSize = true;
            this.taskDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.taskDesc.Location = new System.Drawing.Point(66, 129);
            this.taskDesc.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.taskDesc.Name = "taskDesc";
            this.taskDesc.Size = new System.Drawing.Size(76, 16);
            this.taskDesc.TabIndex = 2;
            this.taskDesc.Text = "Description";
            // 
            // projectLastUpdate
            // 
            this.projectLastUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectLastUpdate.AutoSize = true;
            this.projectLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectLastUpdate.Location = new System.Drawing.Point(61, 323);
            this.projectLastUpdate.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectLastUpdate.Name = "projectLastUpdate";
            this.projectLastUpdate.Size = new System.Drawing.Size(81, 16);
            this.projectLastUpdate.TabIndex = 6;
            this.projectLastUpdate.Text = "Last Update";
            // 
            // projectDeadline
            // 
            this.projectDeadline.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectDeadline.AutoSize = true;
            this.projectDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectDeadline.Location = new System.Drawing.Point(79, 363);
            this.projectDeadline.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectDeadline.Name = "projectDeadline";
            this.projectDeadline.Size = new System.Drawing.Size(63, 16);
            this.projectDeadline.TabIndex = 7;
            this.projectDeadline.Text = "Deadline";
            // 
            // projectIDs
            // 
            this.projectIDs.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.projectIDs.AutoSize = true;
            this.projectIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectIDs.Location = new System.Drawing.Point(162, 11);
            this.projectIDs.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.projectIDs.Name = "projectIDs";
            this.projectIDs.Size = new System.Drawing.Size(0, 16);
            this.projectIDs.TabIndex = 8;
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTaskName.Enabled = false;
            this.textBoxTaskName.Location = new System.Drawing.Point(155, 47);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(604, 20);
            this.textBoxTaskName.TabIndex = 9;
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPersonel.Enabled = false;
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(155, 244);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(604, 21);
            this.comboBoxPersonel.TabIndex = 12;
            this.comboBoxPersonel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxPersonel_KeyDown);
            // 
            // dateTimePickerLastUpdate
            // 
            this.dateTimePickerLastUpdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerLastUpdate.Enabled = false;
            this.dateTimePickerLastUpdate.Location = new System.Drawing.Point(155, 321);
            this.dateTimePickerLastUpdate.Name = "dateTimePickerLastUpdate";
            this.dateTimePickerLastUpdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLastUpdate.TabIndex = 14;
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(155, 361);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDeadline.TabIndex = 15;
            // 
            // richTBDescription
            // 
            this.richTBDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTBDescription.Location = new System.Drawing.Point(155, 79);
            this.richTBDescription.Name = "richTBDescription";
            this.richTBDescription.Size = new System.Drawing.Size(604, 116);
            this.richTBDescription.TabIndex = 10;
            this.richTBDescription.Text = "";
            // 
            // personelT
            // 
            this.personelT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personelT.AutoSize = true;
            this.personelT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personelT.Location = new System.Drawing.Point(80, 247);
            this.personelT.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personelT.Name = "personelT";
            this.personelT.Size = new System.Drawing.Size(62, 16);
            this.personelT.TabIndex = 3;
            this.personelT.Text = "Personel";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // projectT
            // 
            this.projectT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectT.AutoSize = true;
            this.projectT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectT.Location = new System.Drawing.Point(92, 209);
            this.projectT.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectT.Name = "projectT";
            this.projectT.Size = new System.Drawing.Size(50, 16);
            this.projectT.TabIndex = 5;
            this.projectT.Text = "Project";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "open",
            "on-going",
            "closed",
            "re-opened"});
            this.comboBoxStatus.Location = new System.Drawing.Point(155, 282);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(604, 21);
            this.comboBoxStatus.TabIndex = 12;
            this.comboBoxStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxStatus_KeyDown);
            // 
            // comboBoxProject
            // 
            this.comboBoxProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProject.Enabled = false;
            this.comboBoxProject.FormattingEnabled = true;
            this.comboBoxProject.Location = new System.Drawing.Point(155, 206);
            this.comboBoxProject.Name = "comboBoxProject";
            this.comboBoxProject.Size = new System.Drawing.Size(604, 21);
            this.comboBoxProject.TabIndex = 16;
            this.comboBoxProject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxProject_KeyDown);
            // 
            // TaskModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaskModal";
            this.Text = "TaskModal";
            this.Load += new System.EventHandler(this.TaskModal_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label taskId;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.Label taskDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label projectT;
        private System.Windows.Forms.Label projectLastUpdate;
        private System.Windows.Forms.Label projectDeadline;
        private System.Windows.Forms.Label projectIDs;
        private System.Windows.Forms.TextBox textBoxTaskName;
        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.RichTextBox richTBDescription;
        private System.Windows.Forms.Label personelT;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxProject;
    }
}