namespace yonetimApplication
{
    partial class PersonForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ID = new System.Windows.Forms.Label();
            this.personName = new System.Windows.Forms.Label();
            this.personSurname = new System.Windows.Forms.Label();
            this.personEmail = new System.Windows.Forms.Label();
            this.personTeam = new System.Windows.Forms.Label();
            this.personSD = new System.Windows.Forms.Label();
            this.personLocation = new System.Windows.Forms.Label();
            this.personId = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerSD = new System.Windows.Forms.DateTimePicker();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.Person = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewProjects = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.49136F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 532);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonChangePassword);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.Person);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 526);
            this.panel1.TabIndex = 0;
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonChangePassword.Location = new System.Drawing.Point(287, 487);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(142, 31);
            this.buttonChangePassword.TabIndex = 3;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(435, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.39181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.60819F));
            this.tableLayoutPanel2.Controls.Add(this.ID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.personName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.personSurname, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.personEmail, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.personTeam, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.personSD, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.personLocation, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.personId, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSurname, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEmail, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerSD, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLocation, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTeam, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 458);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.Location = new System.Drawing.Point(90, 24);
            this.ID.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(19, 16);
            this.ID.TabIndex = 0;
            this.ID.Text = "Id";
            // 
            // personName
            // 
            this.personName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personName.AutoSize = true;
            this.personName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personName.Location = new System.Drawing.Point(64, 89);
            this.personName.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personName.Name = "personName";
            this.personName.Size = new System.Drawing.Size(45, 16);
            this.personName.TabIndex = 1;
            this.personName.Text = "Name";
            // 
            // personSurname
            // 
            this.personSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personSurname.AutoSize = true;
            this.personSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personSurname.Location = new System.Drawing.Point(54, 154);
            this.personSurname.Name = "personSurname";
            this.personSurname.Size = new System.Drawing.Size(62, 16);
            this.personSurname.TabIndex = 2;
            this.personSurname.Text = "Surname";
            // 
            // personEmail
            // 
            this.personEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personEmail.AutoSize = true;
            this.personEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personEmail.Location = new System.Drawing.Point(67, 219);
            this.personEmail.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personEmail.Name = "personEmail";
            this.personEmail.Size = new System.Drawing.Size(42, 16);
            this.personEmail.TabIndex = 3;
            this.personEmail.Text = "Email";
            // 
            // personTeam
            // 
            this.personTeam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personTeam.AutoSize = true;
            this.personTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personTeam.Location = new System.Drawing.Point(65, 284);
            this.personTeam.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personTeam.Name = "personTeam";
            this.personTeam.Size = new System.Drawing.Size(44, 16);
            this.personTeam.TabIndex = 4;
            this.personTeam.Text = "Team";
            // 
            // personSD
            // 
            this.personSD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personSD.AutoSize = true;
            this.personSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personSD.Location = new System.Drawing.Point(42, 349);
            this.personSD.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personSD.Name = "personSD";
            this.personSD.Size = new System.Drawing.Size(67, 16);
            this.personSD.TabIndex = 6;
            this.personSD.Text = "Start Date";
            // 
            // personLocation
            // 
            this.personLocation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.personLocation.AutoSize = true;
            this.personLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personLocation.Location = new System.Drawing.Point(50, 416);
            this.personLocation.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personLocation.Name = "personLocation";
            this.personLocation.Size = new System.Drawing.Size(59, 16);
            this.personLocation.TabIndex = 7;
            this.personLocation.Text = "Location";
            // 
            // personId
            // 
            this.personId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.personId.AutoSize = true;
            this.personId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personId.Location = new System.Drawing.Point(122, 24);
            this.personId.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.personId.Name = "personId";
            this.personId.Size = new System.Drawing.Size(0, 16);
            this.personId.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(122, 87);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(388, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Enabled = false;
            this.textBoxSurname.Location = new System.Drawing.Point(122, 152);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(388, 20);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Enabled = false;
            this.textBoxEmail.Location = new System.Drawing.Point(122, 217);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(388, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // dateTimePickerSD
            // 
            this.dateTimePickerSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSD.Enabled = false;
            this.dateTimePickerSD.Location = new System.Drawing.Point(122, 347);
            this.dateTimePickerSD.Name = "dateTimePickerSD";
            this.dateTimePickerSD.Size = new System.Drawing.Size(388, 20);
            this.dateTimePickerSD.TabIndex = 14;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocation.Enabled = false;
            this.textBoxLocation.Location = new System.Drawing.Point(122, 414);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(388, 20);
            this.textBoxLocation.TabIndex = 15;
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTeam.Enabled = false;
            this.textBoxTeam.Location = new System.Drawing.Point(122, 282);
            this.textBoxTeam.Name = "textBoxTeam";
            this.textBoxTeam.Size = new System.Drawing.Size(388, 20);
            this.textBoxTeam.TabIndex = 16;
            // 
            // Person
            // 
            this.Person.AutoSize = true;
            this.Person.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Person.Location = new System.Drawing.Point(3, 4);
            this.Person.Name = "Person";
            this.Person.Size = new System.Drawing.Size(51, 16);
            this.Person.TabIndex = 0;
            this.Person.Text = "Person";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(525, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(517, 526);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.dataGridViewProjects);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Projects";
            // 
            // dataGridViewProjects
            // 
            this.dataGridViewProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjects.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewProjects.Name = "dataGridViewProjects";
            this.dataGridViewProjects.Size = new System.Drawing.Size(497, 450);
            this.dataGridViewProjects.TabIndex = 3;
            this.dataGridViewProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellClick);
            this.dataGridViewProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProjects_CellDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.dataGridViewTasks);
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonNew);
            this.tabPage2.Controls.Add(this.buttonEdit);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(500, 448);
            this.dataGridViewTasks.TabIndex = 6;
            this.dataGridViewTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellClick);
            this.dataGridViewTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellDoubleClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDelete.Location = new System.Drawing.Point(269, 460);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNew.Location = new System.Drawing.Point(350, 460);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 31);
            this.buttonNew.TabIndex = 4;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEdit.Location = new System.Drawing.Point(431, 460);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 31);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjects)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label personName;
        private System.Windows.Forms.Label personSurname;
        private System.Windows.Forms.Label personEmail;
        private System.Windows.Forms.Label personTeam;
        private System.Windows.Forms.Label personSD;
        private System.Windows.Forms.Label personLocation;
        private System.Windows.Forms.Label personId;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerSD;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label Person;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewProjects;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxTeam;
    }
}