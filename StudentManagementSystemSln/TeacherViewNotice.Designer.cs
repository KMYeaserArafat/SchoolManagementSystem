namespace StudentManagementSystemSln
{
    partial class TeacherViewNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherViewNotice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvNotice = new System.Windows.Forms.DataGridView();
            this.btnShowNotice = new System.Windows.Forms.Button();
            this.pnlShowNotice = new System.Windows.Forms.Panel();
            this.txtNotice = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).BeginInit();
            this.pnlShowNotice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pnlShowNotice);
            this.panel1.Controls.Add(this.btnShowNotice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 562);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(347, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notice Boad";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dgvNotice);
            this.panel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(12, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 179);
            this.panel2.TabIndex = 0;
            // 
            // dgvNotice
            // 
            this.dgvNotice.AllowUserToAddRows = false;
            this.dgvNotice.AllowUserToDeleteRows = false;
            this.dgvNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotice.Location = new System.Drawing.Point(0, 0);
            this.dgvNotice.Name = "dgvNotice";
            this.dgvNotice.ReadOnly = true;
            this.dgvNotice.RowHeadersWidth = 51;
            this.dgvNotice.RowTemplate.Height = 24;
            this.dgvNotice.Size = new System.Drawing.Size(797, 179);
            this.dgvNotice.TabIndex = 0;
            // 
            // btnShowNotice
            // 
            this.btnShowNotice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnShowNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowNotice.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowNotice.Image = ((System.Drawing.Image)(resources.GetObject("btnShowNotice.Image")));
            this.btnShowNotice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowNotice.Location = new System.Drawing.Point(605, 228);
            this.btnShowNotice.Name = "btnShowNotice";
            this.btnShowNotice.Size = new System.Drawing.Size(204, 46);
            this.btnShowNotice.TabIndex = 4;
            this.btnShowNotice.Text = "Show  Notice";
            this.btnShowNotice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowNotice.UseVisualStyleBackColor = false;
            this.btnShowNotice.Click += new System.EventHandler(this.btnShowNotice_Click);
            // 
            // pnlShowNotice
            // 
            this.pnlShowNotice.BackColor = System.Drawing.Color.Transparent;
            this.pnlShowNotice.Controls.Add(this.txtTitle);
            this.pnlShowNotice.Controls.Add(this.label2);
            this.pnlShowNotice.Controls.Add(this.txtNotice);
            this.pnlShowNotice.Controls.Add(this.txtDate);
            this.pnlShowNotice.Controls.Add(this.label3);
            this.pnlShowNotice.Controls.Add(this.label4);
            this.pnlShowNotice.Controls.Add(this.button2);
            this.pnlShowNotice.Location = new System.Drawing.Point(12, 289);
            this.pnlShowNotice.Name = "pnlShowNotice";
            this.pnlShowNotice.Size = new System.Drawing.Size(797, 236);
            this.pnlShowNotice.TabIndex = 5;
            this.pnlShowNotice.Visible = false;
            // 
            // txtNotice
            // 
            this.txtNotice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNotice.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtNotice.Location = new System.Drawing.Point(90, 83);
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.ReadOnly = true;
            this.txtNotice.Size = new System.Drawing.Size(553, 129);
            this.txtNotice.TabIndex = 6;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtDate.Location = new System.Drawing.Point(90, 13);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(194, 29);
            this.txtDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Notice :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date : ";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(649, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title :";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold);
            this.txtTitle.Location = new System.Drawing.Point(90, 48);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(553, 29);
            this.txtTitle.TabIndex = 8;
            // 
            // TeacherViewNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 562);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherViewNotice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherViewNotice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotice)).EndInit();
            this.pnlShowNotice.ResumeLayout(false);
            this.pnlShowNotice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvNotice;
        private System.Windows.Forms.Button btnShowNotice;
        private System.Windows.Forms.Panel pnlShowNotice;
        private System.Windows.Forms.TextBox txtNotice;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
    }
}