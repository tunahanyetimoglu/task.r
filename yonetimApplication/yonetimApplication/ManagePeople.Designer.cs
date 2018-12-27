namespace yonetimApplication
{
    partial class ManagePeople
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDeleteP = new System.Windows.Forms.Button();
            this.buttonNewP = new System.Windows.Forms.Button();
            this.buttonEditP = new System.Windows.Forms.Button();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDeletePM = new System.Windows.Forms.Button();
            this.buttonNewPM = new System.Windows.Forms.Button();
            this.buttonEditPM = new System.Windows.Forms.Button();
            this.dataGridViewPM = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonEditM = new System.Windows.Forms.Button();
            this.buttonNewM = new System.Windows.Forms.Button();
            this.buttonDeleteM = new System.Windows.Forms.Button();
            this.dataGridViewM = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPM)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(898, 502);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonDeleteP);
            this.tabPage1.Controls.Add(this.buttonNewP);
            this.tabPage1.Controls.Add(this.buttonEditP);
            this.tabPage1.Controls.Add(this.dataGridViewPeople);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(890, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personel";
            // 
            // buttonDeleteP
            // 
            this.buttonDeleteP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDeleteP.Location = new System.Drawing.Point(653, 430);
            this.buttonDeleteP.Name = "buttonDeleteP";
            this.buttonDeleteP.Size = new System.Drawing.Size(75, 36);
            this.buttonDeleteP.TabIndex = 7;
            this.buttonDeleteP.Text = "Delete";
            this.buttonDeleteP.UseVisualStyleBackColor = true;
            this.buttonDeleteP.Click += new System.EventHandler(this.buttonDeleteP_Click);
            // 
            // buttonNewP
            // 
            this.buttonNewP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNewP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNewP.Location = new System.Drawing.Point(734, 430);
            this.buttonNewP.Name = "buttonNewP";
            this.buttonNewP.Size = new System.Drawing.Size(75, 36);
            this.buttonNewP.TabIndex = 6;
            this.buttonNewP.Text = "New";
            this.buttonNewP.UseVisualStyleBackColor = true;
            this.buttonNewP.Click += new System.EventHandler(this.buttonNewP_Click);
            // 
            // buttonEditP
            // 
            this.buttonEditP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEditP.Location = new System.Drawing.Point(815, 430);
            this.buttonEditP.Name = "buttonEditP";
            this.buttonEditP.Size = new System.Drawing.Size(75, 37);
            this.buttonEditP.TabIndex = 5;
            this.buttonEditP.Text = "Edit";
            this.buttonEditP.UseVisualStyleBackColor = true;
            this.buttonEditP.Click += new System.EventHandler(this.buttonEditP_Click);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPeople.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.Size = new System.Drawing.Size(878, 418);
            this.dataGridViewPeople.TabIndex = 4;
            this.dataGridViewPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPeople_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonDeletePM);
            this.tabPage2.Controls.Add(this.buttonNewPM);
            this.tabPage2.Controls.Add(this.buttonEditPM);
            this.tabPage2.Controls.Add(this.dataGridViewPM);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(890, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Project Manager";
            // 
            // buttonDeletePM
            // 
            this.buttonDeletePM.Location = new System.Drawing.Point(653, 430);
            this.buttonDeletePM.Name = "buttonDeletePM";
            this.buttonDeletePM.Size = new System.Drawing.Size(75, 36);
            this.buttonDeletePM.TabIndex = 11;
            this.buttonDeletePM.Text = "Delete";
            this.buttonDeletePM.UseVisualStyleBackColor = true;
            this.buttonDeletePM.Click += new System.EventHandler(this.buttonDeletePM_Click);
            // 
            // buttonNewPM
            // 
            this.buttonNewPM.Location = new System.Drawing.Point(734, 430);
            this.buttonNewPM.Name = "buttonNewPM";
            this.buttonNewPM.Size = new System.Drawing.Size(75, 36);
            this.buttonNewPM.TabIndex = 10;
            this.buttonNewPM.Text = "New";
            this.buttonNewPM.UseVisualStyleBackColor = true;
            this.buttonNewPM.Click += new System.EventHandler(this.buttonNewPM_Click);
            // 
            // buttonEditPM
            // 
            this.buttonEditPM.Location = new System.Drawing.Point(815, 430);
            this.buttonEditPM.Name = "buttonEditPM";
            this.buttonEditPM.Size = new System.Drawing.Size(75, 36);
            this.buttonEditPM.TabIndex = 9;
            this.buttonEditPM.Text = "Edit";
            this.buttonEditPM.UseVisualStyleBackColor = true;
            this.buttonEditPM.Click += new System.EventHandler(this.buttonEditPM_Click);
            // 
            // dataGridViewPM
            // 
            this.dataGridViewPM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPM.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewPM.Name = "dataGridViewPM";
            this.dataGridViewPM.Size = new System.Drawing.Size(878, 418);
            this.dataGridViewPM.TabIndex = 0;
            this.dataGridViewPM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPM_CellClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.buttonEditM);
            this.tabPage3.Controls.Add(this.buttonNewM);
            this.tabPage3.Controls.Add(this.buttonDeleteM);
            this.tabPage3.Controls.Add(this.dataGridViewM);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(890, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manager";
            // 
            // buttonEditM
            // 
            this.buttonEditM.Location = new System.Drawing.Point(815, 430);
            this.buttonEditM.Name = "buttonEditM";
            this.buttonEditM.Size = new System.Drawing.Size(75, 36);
            this.buttonEditM.TabIndex = 3;
            this.buttonEditM.Text = "Edit";
            this.buttonEditM.UseVisualStyleBackColor = true;
            this.buttonEditM.Click += new System.EventHandler(this.buttonEditM_Click);
            // 
            // buttonNewM
            // 
            this.buttonNewM.Location = new System.Drawing.Point(734, 430);
            this.buttonNewM.Name = "buttonNewM";
            this.buttonNewM.Size = new System.Drawing.Size(75, 36);
            this.buttonNewM.TabIndex = 2;
            this.buttonNewM.Text = "New";
            this.buttonNewM.UseVisualStyleBackColor = true;
            this.buttonNewM.Click += new System.EventHandler(this.ButtonNewM_Click);
            // 
            // buttonDeleteM
            // 
            this.buttonDeleteM.Location = new System.Drawing.Point(653, 430);
            this.buttonDeleteM.Name = "buttonDeleteM";
            this.buttonDeleteM.Size = new System.Drawing.Size(75, 36);
            this.buttonDeleteM.TabIndex = 1;
            this.buttonDeleteM.Text = "Delete";
            this.buttonDeleteM.UseVisualStyleBackColor = true;
            this.buttonDeleteM.Click += new System.EventHandler(this.buttonDeleteM_Click);
            // 
            // dataGridViewM
            // 
            this.dataGridViewM.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewM.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewM.Name = "dataGridViewM";
            this.dataGridViewM.Size = new System.Drawing.Size(878, 418);
            this.dataGridViewM.TabIndex = 0;
            this.dataGridViewM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewM_CellClick);
            // 
            // ManagePeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 526);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ManagePeople";
            this.Text = "ManagePeople";
            this.Load += new System.EventHandler(this.ManagePeople_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPM)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonDeleteP;
        private System.Windows.Forms.Button buttonNewP;
        private System.Windows.Forms.Button buttonEditP;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDeletePM;
        private System.Windows.Forms.Button buttonNewPM;
        private System.Windows.Forms.Button buttonEditPM;
        private System.Windows.Forms.DataGridView dataGridViewPM;
        private System.Windows.Forms.DataGridView dataGridViewM;
        private System.Windows.Forms.Button buttonEditM;
        private System.Windows.Forms.Button buttonNewM;
        private System.Windows.Forms.Button buttonDeleteM;
    }
}