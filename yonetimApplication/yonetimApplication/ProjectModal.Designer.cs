namespace yonetimApplication
{
    partial class ProjectModal
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
            this.projectId = new System.Windows.Forms.Label();
            this.projectName = new System.Windows.Forms.Label();
            this.projectDesc = new System.Windows.Forms.Label();
            this.projectManager = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectStartDate = new System.Windows.Forms.Label();
            this.projectLastUpdate = new System.Windows.Forms.Label();
            this.projectDeadline = new System.Windows.Forms.Label();
            this.projectIDs = new System.Windows.Forms.Label();
            this.textBoxProjectName = new System.Windows.Forms.TextBox();
            this.comboBoxManager = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLastUpdate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.richTBDescription = new System.Windows.Forms.RichTextBox();
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
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 437);
            this.panel1.TabIndex = 0;
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
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.94751F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.05249F));
            this.tableLayoutPanel1.Controls.Add(this.projectId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.projectName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.projectDesc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectManager, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.projectStartDate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.projectLastUpdate, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.projectDeadline, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.projectIDs, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxProjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxManager, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxStatus, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerStartDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerLastUpdate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDeadline, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.richTBDescription, 1, 2);
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
            // projectId
            // 
            this.projectId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectId.AutoSize = true;
            this.projectId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectId.Location = new System.Drawing.Point(123, 11);
            this.projectId.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectId.Name = "projectId";
            this.projectId.Size = new System.Drawing.Size(19, 16);
            this.projectId.TabIndex = 0;
            this.projectId.Text = "Id";
            // 
            // projectName
            // 
            this.projectName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectName.AutoSize = true;
            this.projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectName.Location = new System.Drawing.Point(97, 49);
            this.projectName.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectName.Name = "projectName";
            this.projectName.Size = new System.Drawing.Size(45, 16);
            this.projectName.TabIndex = 1;
            this.projectName.Text = "Name";
            // 
            // projectDesc
            // 
            this.projectDesc.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectDesc.AutoSize = true;
            this.projectDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectDesc.Location = new System.Drawing.Point(66, 129);
            this.projectDesc.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectDesc.Name = "projectDesc";
            this.projectDesc.Size = new System.Drawing.Size(76, 16);
            this.projectDesc.TabIndex = 2;
            this.projectDesc.Text = "Description";
            // 
            // projectManager
            // 
            this.projectManager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectManager.AutoSize = true;
            this.projectManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectManager.Location = new System.Drawing.Point(35, 209);
            this.projectManager.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectManager.Name = "projectManager";
            this.projectManager.Size = new System.Drawing.Size(107, 16);
            this.projectManager.TabIndex = 3;
            this.projectManager.Text = "Project Manager";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 247);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // projectStartDate
            // 
            this.projectStartDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.projectStartDate.AutoSize = true;
            this.projectStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectStartDate.Location = new System.Drawing.Point(75, 285);
            this.projectStartDate.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.projectStartDate.Name = "projectStartDate";
            this.projectStartDate.Size = new System.Drawing.Size(67, 16);
            this.projectStartDate.TabIndex = 5;
            this.projectStartDate.Text = "Start Date";
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
            // textBoxProjectName
            // 
            this.textBoxProjectName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxProjectName.Enabled = false;
            this.textBoxProjectName.Location = new System.Drawing.Point(155, 47);
            this.textBoxProjectName.Name = "textBoxProjectName";
            this.textBoxProjectName.Size = new System.Drawing.Size(604, 20);
            this.textBoxProjectName.TabIndex = 9;
            // 
            // comboBoxManager
            // 
            this.comboBoxManager.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxManager.FormattingEnabled = true;
            this.comboBoxManager.Location = new System.Drawing.Point(155, 206);
            this.comboBoxManager.Name = "comboBoxManager";
            this.comboBoxManager.Size = new System.Drawing.Size(604, 21);
            this.comboBoxManager.TabIndex = 11;
            this.comboBoxManager.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxManager_KeyDown);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "open",
            "on-going",
            "closed",
            "re-opened"});
            this.comboBoxStatus.Location = new System.Drawing.Point(155, 244);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(604, 21);
            this.comboBoxStatus.TabIndex = 12;
            this.comboBoxStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxStatus_KeyDown);
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerStartDate.Enabled = false;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(155, 283);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 13;
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
            this.dateTimePickerDeadline.Enabled = false;
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
            this.richTBDescription.Enabled = false;
            this.richTBDescription.Location = new System.Drawing.Point(155, 79);
            this.richTBDescription.Name = "richTBDescription";
            this.richTBDescription.Size = new System.Drawing.Size(604, 116);
            this.richTBDescription.TabIndex = 10;
            this.richTBDescription.Text = "";
            // 
            // ProjectModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProjectModal";
            this.Text = "ProjectModal";
            this.Load += new System.EventHandler(this.ProjectModal_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label projectId;
        private System.Windows.Forms.Label projectName;
        private System.Windows.Forms.Label projectDesc;
        private System.Windows.Forms.Label projectManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label projectStartDate;
        private System.Windows.Forms.Label projectLastUpdate;
        private System.Windows.Forms.Label projectDeadline;
        private System.Windows.Forms.Label projectIDs;
        private System.Windows.Forms.TextBox textBoxProjectName;
        private System.Windows.Forms.ComboBox comboBoxManager;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.RichTextBox richTBDescription;
    }
}