namespace yonetimApplication
{
    partial class UserModal
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Name = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.Label();
            this.SD = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelJob = new System.Windows.Forms.Label();
            this.dateTimePickerSD = new System.Windows.Forms.DateTimePicker();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTeam = new System.Windows.Forms.TextBox();
            this.Person = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.Person);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 482);
            this.panel1.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.Location = new System.Drawing.Point(438, 443);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 31);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Add";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.39181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.60819F));
            this.tableLayoutPanel2.Controls.Add(this.Name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Surname, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Email, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Team, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Job, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.SD, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.Location, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSurname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEmail, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelJob, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.dateTimePickerSD, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLocation, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTeam, 1, 3);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(513, 414);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Name
            // 
            this.Name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name.Location = new System.Drawing.Point(64, 21);
            this.Name.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(45, 16);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // Surname
            // 
            this.Surname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Surname.Location = new System.Drawing.Point(54, 80);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(62, 16);
            this.Surname.TabIndex = 2;
            this.Surname.Text = "Surname";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Email.Location = new System.Drawing.Point(67, 139);
            this.Email.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 16);
            this.Email.TabIndex = 3;
            this.Email.Text = "Email";
            // 
            // Team
            // 
            this.Team.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Team.AutoSize = true;
            this.Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Team.Location = new System.Drawing.Point(65, 198);
            this.Team.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(44, 16);
            this.Team.TabIndex = 4;
            this.Team.Text = "Team";
            // 
            // Job
            // 
            this.Job.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Job.AutoSize = true;
            this.Job.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Job.Location = new System.Drawing.Point(78, 257);
            this.Job.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(31, 16);
            this.Job.TabIndex = 5;
            this.Job.Text = "Job";
            // 
            // SD
            // 
            this.SD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SD.AutoSize = true;
            this.SD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SD.Location = new System.Drawing.Point(42, 316);
            this.SD.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.SD.Name = "SD";
            this.SD.Size = new System.Drawing.Size(67, 16);
            this.SD.TabIndex = 6;
            this.SD.Text = "Start Date";
            // 
            // Location
            // 
            this.Location.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Location.AutoSize = true;
            this.Location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Location.Location = new System.Drawing.Point(50, 376);
            this.Location.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(59, 16);
            this.Location.TabIndex = 7;
            this.Location.Text = "Location";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(122, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(388, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSurname.Location = new System.Drawing.Point(122, 78);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(388, 20);
            this.textBoxSurname.TabIndex = 10;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail.Location = new System.Drawing.Point(122, 137);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(388, 20);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelJob
            // 
            this.labelJob.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelJob.AutoSize = true;
            this.labelJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelJob.Location = new System.Drawing.Point(122, 257);
            this.labelJob.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.labelJob.Name = "labelJob";
            this.labelJob.Size = new System.Drawing.Size(31, 16);
            this.labelJob.TabIndex = 13;
            this.labelJob.Text = "Job";
            // 
            // dateTimePickerSD
            // 
            this.dateTimePickerSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSD.Enabled = false;
            this.dateTimePickerSD.Location = new System.Drawing.Point(122, 314);
            this.dateTimePickerSD.Name = "dateTimePickerSD";
            this.dateTimePickerSD.Size = new System.Drawing.Size(388, 20);
            this.dateTimePickerSD.TabIndex = 14;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocation.Location = new System.Drawing.Point(122, 374);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(388, 20);
            this.textBoxLocation.TabIndex = 15;
            // 
            // textBoxTeam
            // 
            this.textBoxTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTeam.Location = new System.Drawing.Point(122, 196);
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
            // UserModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Text = "UserModal";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Team;
        private System.Windows.Forms.Label Job;
        private System.Windows.Forms.Label SD;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelJob;
        private System.Windows.Forms.DateTimePicker dateTimePickerSD;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label Person;
        private System.Windows.Forms.TextBox textBoxTeam;
    }
}