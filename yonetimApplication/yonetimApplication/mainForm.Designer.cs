namespace yonetimApplication
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonProjectDelete = new System.Windows.Forms.Button();
            this.buttonProjectNew = new System.Windows.Forms.Button();
            this.buttonProjectEdit = new System.Windows.Forms.Button();
            this.dataGridViewProject = new System.Windows.Forms.DataGridView();
            this.labelProject = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.buttonExclude = new System.Windows.Forms.Button();
            this.buttonManagePeople = new System.Windows.Forms.Button();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonTaskDelete = new System.Windows.Forms.Button();
            this.buttonTaskNew = new System.Windows.Forms.Button();
            this.buttonTaskEdit = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.buttonDetail = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.buttonProfile);
            this.mainPanel.Controls.Add(this.buttonRefresh);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1045, 32);
            this.mainPanel.TabIndex = 0;
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.Location = new System.Drawing.Point(963, 0);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(75, 26);
            this.buttonProfile.TabIndex = 2;
            this.buttonProfile.Text = "My Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 26);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1045, 486);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonDetail);
            this.panel2.Controls.Add(this.buttonProjectDelete);
            this.panel2.Controls.Add(this.buttonProjectNew);
            this.panel2.Controls.Add(this.buttonProjectEdit);
            this.panel2.Controls.Add(this.dataGridViewProject);
            this.panel2.Controls.Add(this.labelProject);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 480);
            this.panel2.TabIndex = 0;
            // 
            // buttonProjectDelete
            // 
            this.buttonProjectDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProjectDelete.Location = new System.Drawing.Point(276, 445);
            this.buttonProjectDelete.Name = "buttonProjectDelete";
            this.buttonProjectDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonProjectDelete.TabIndex = 5;
            this.buttonProjectDelete.Text = "Delete";
            this.buttonProjectDelete.UseVisualStyleBackColor = true;
            this.buttonProjectDelete.Click += new System.EventHandler(this.buttonProjectDelete_Click);
            // 
            // buttonProjectNew
            // 
            this.buttonProjectNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProjectNew.Location = new System.Drawing.Point(357, 445);
            this.buttonProjectNew.Name = "buttonProjectNew";
            this.buttonProjectNew.Size = new System.Drawing.Size(75, 31);
            this.buttonProjectNew.TabIndex = 4;
            this.buttonProjectNew.Text = "New";
            this.buttonProjectNew.UseVisualStyleBackColor = true;
            this.buttonProjectNew.Click += new System.EventHandler(this.buttonProjectNew_Click);
            // 
            // buttonProjectEdit
            // 
            this.buttonProjectEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProjectEdit.Location = new System.Drawing.Point(438, 445);
            this.buttonProjectEdit.Name = "buttonProjectEdit";
            this.buttonProjectEdit.Size = new System.Drawing.Size(75, 31);
            this.buttonProjectEdit.TabIndex = 3;
            this.buttonProjectEdit.Text = "Edit";
            this.buttonProjectEdit.UseVisualStyleBackColor = true;
            this.buttonProjectEdit.Click += new System.EventHandler(this.buttonProjectEdit_Click);
            // 
            // dataGridViewProject
            // 
            this.dataGridViewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProject.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProject.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewProject.Name = "dataGridViewProject";
            this.dataGridViewProject.Size = new System.Drawing.Size(500, 400);
            this.dataGridViewProject.TabIndex = 1;
            this.dataGridViewProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProject_CellClick);
            this.dataGridViewProject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProject_CellDoubleClick);
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelProject.Location = new System.Drawing.Point(3, 3);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(57, 16);
            this.labelProject.TabIndex = 0;
            this.labelProject.Text = "Projects";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl.Location = new System.Drawing.Point(525, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(517, 480);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonInclude);
            this.tabPage1.Controls.Add(this.buttonExclude);
            this.tabPage1.Controls.Add(this.buttonManagePeople);
            this.tabPage1.Controls.Add(this.dataGridViewPeople);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(509, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "People";
            // 
            // buttonInclude
            // 
            this.buttonInclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInclude.Location = new System.Drawing.Point(347, 420);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(75, 31);
            this.buttonInclude.TabIndex = 3;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // buttonExclude
            // 
            this.buttonExclude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExclude.Location = new System.Drawing.Point(428, 420);
            this.buttonExclude.Name = "buttonExclude";
            this.buttonExclude.Size = new System.Drawing.Size(75, 31);
            this.buttonExclude.TabIndex = 2;
            this.buttonExclude.Text = "Exclude";
            this.buttonExclude.UseVisualStyleBackColor = true;
            this.buttonExclude.Click += new System.EventHandler(this.buttonExclude_Click);
            // 
            // buttonManagePeople
            // 
            this.buttonManagePeople.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonManagePeople.Location = new System.Drawing.Point(6, 420);
            this.buttonManagePeople.Name = "buttonManagePeople";
            this.buttonManagePeople.Size = new System.Drawing.Size(122, 31);
            this.buttonManagePeople.TabIndex = 1;
            this.buttonManagePeople.Text = "Manage People";
            this.buttonManagePeople.UseVisualStyleBackColor = true;
            this.buttonManagePeople.Click += new System.EventHandler(this.buttonManagePeople_Click);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPeople.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.Size = new System.Drawing.Size(500, 400);
            this.dataGridViewPeople.TabIndex = 0;
            this.dataGridViewPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeople_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonTaskDelete);
            this.tabPage2.Controls.Add(this.buttonTaskNew);
            this.tabPage2.Controls.Add(this.buttonTaskEdit);
            this.tabPage2.Controls.Add(this.dataGridViewTasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(509, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tasks";
            // 
            // buttonTaskDelete
            // 
            this.buttonTaskDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaskDelete.Enabled = false;
            this.buttonTaskDelete.Location = new System.Drawing.Point(266, 420);
            this.buttonTaskDelete.Name = "buttonTaskDelete";
            this.buttonTaskDelete.Size = new System.Drawing.Size(75, 31);
            this.buttonTaskDelete.TabIndex = 3;
            this.buttonTaskDelete.Text = "Delete";
            this.buttonTaskDelete.UseVisualStyleBackColor = true;
            this.buttonTaskDelete.Click += new System.EventHandler(this.buttonTaskDelete_Click);
            // 
            // buttonTaskNew
            // 
            this.buttonTaskNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaskNew.Enabled = false;
            this.buttonTaskNew.Location = new System.Drawing.Point(347, 420);
            this.buttonTaskNew.Name = "buttonTaskNew";
            this.buttonTaskNew.Size = new System.Drawing.Size(75, 31);
            this.buttonTaskNew.TabIndex = 2;
            this.buttonTaskNew.Text = "New";
            this.buttonTaskNew.UseVisualStyleBackColor = true;
            this.buttonTaskNew.Click += new System.EventHandler(this.buttonTaskNew_Click);
            // 
            // buttonTaskEdit
            // 
            this.buttonTaskEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTaskEdit.Enabled = false;
            this.buttonTaskEdit.Location = new System.Drawing.Point(428, 420);
            this.buttonTaskEdit.Name = "buttonTaskEdit";
            this.buttonTaskEdit.Size = new System.Drawing.Size(75, 31);
            this.buttonTaskEdit.TabIndex = 1;
            this.buttonTaskEdit.Text = "Edit";
            this.buttonTaskEdit.UseVisualStyleBackColor = true;
            this.buttonTaskEdit.Click += new System.EventHandler(this.buttonTaskEdit_Click);
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(3, 0);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.Size = new System.Drawing.Size(500, 400);
            this.dataGridViewTasks.TabIndex = 0;
            this.dataGridViewTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellClick);
            this.dataGridViewTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellDoubleClick);
            // 
            // buttonDetail
            // 
            this.buttonDetail.Location = new System.Drawing.Point(6, 445);
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Size = new System.Drawing.Size(75, 31);
            this.buttonDetail.TabIndex = 6;
            this.buttonDetail.Text = "Details";
            this.buttonDetail.UseVisualStyleBackColor = true;
            this.buttonDetail.Click += new System.EventHandler(this.buttonDetail_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 545);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainPanel);
            this.Name = "mainForm";
            this.Text = "task.r";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProject)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonProjectDelete;
        private System.Windows.Forms.Button buttonProjectNew;
        private System.Windows.Forms.Button buttonProjectEdit;
        private System.Windows.Forms.DataGridView dataGridViewProject;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Button buttonExclude;
        private System.Windows.Forms.Button buttonManagePeople;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonTaskDelete;
        private System.Windows.Forms.Button buttonTaskNew;
        private System.Windows.Forms.Button buttonTaskEdit;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.Button buttonDetail;
    }
}

