namespace yonetimApplication
{
    partial class PasswordChange
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
            this.labelP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.buttonRP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelP.Location = new System.Drawing.Point(9, 87);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(110, 16);
            this.labelP.TabIndex = 0;
            this.labelP.Text = "New Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Confirm New Password";
            // 
            // textBoxNP
            // 
            this.textBoxNP.Location = new System.Drawing.Point(12, 106);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.PasswordChar = '*';
            this.textBoxNP.Size = new System.Drawing.Size(220, 20);
            this.textBoxNP.TabIndex = 1;
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.Location = new System.Drawing.Point(12, 158);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.PasswordChar = '*';
            this.textBoxCNP.Size = new System.Drawing.Size(220, 20);
            this.textBoxCNP.TabIndex = 2;
            // 
            // buttonRP
            // 
            this.buttonRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRP.Location = new System.Drawing.Point(12, 196);
            this.buttonRP.Name = "buttonRP";
            this.buttonRP.Size = new System.Drawing.Size(220, 37);
            this.buttonRP.TabIndex = 3;
            this.buttonRP.Text = "Reset Password";
            this.buttonRP.UseVisualStyleBackColor = true;
            this.buttonRP.Click += new System.EventHandler(this.buttonRP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Old Password";
            // 
            // textBoxOP
            // 
            this.textBoxOP.Location = new System.Drawing.Point(12, 55);
            this.textBoxOP.Name = "textBoxOP";
            this.textBoxOP.PasswordChar = '*';
            this.textBoxOP.Size = new System.Drawing.Size(220, 20);
            this.textBoxOP.TabIndex = 4;
            // 
            // PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(300, 307);
            this.Controls.Add(this.textBoxOP);
            this.Controls.Add(this.buttonRP);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.textBoxNP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelP);
            this.Name = "PasswordChange";
            this.Text = "PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.Button buttonRP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOP;
    }
}