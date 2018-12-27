namespace yonetimApplication
{
    partial class AddPersonToProject
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
            this.dataGridViewAP = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAP
            // 
            this.dataGridViewAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewAP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAP.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewAP.Name = "dataGridViewAP";
            this.dataGridViewAP.Size = new System.Drawing.Size(760, 398);
            this.dataGridViewAP.TabIndex = 0;
            this.dataGridViewAP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAP_CellClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAdd.Location = new System.Drawing.Point(678, 416);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 33);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Project";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddPersonToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewAP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPersonToProject";
            this.Text = "AddPersonToProject";
            this.Load += new System.EventHandler(this.AddPersonToProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAP;
        private System.Windows.Forms.Button buttonAdd;
    }
}