namespace StudentManagementSystemSln
{
    partial class TeacherInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherInformation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAllTeacherInfo = new System.Windows.Forms.Button();
            this.btnAllStudentInfo = new System.Windows.Forms.Button();
            this.pnlShowInformation = new System.Windows.Forms.Panel();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(163)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.pnlShowInformation);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 489);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(14)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.btnUserInfo);
            this.panel2.Controls.Add(this.btnAllStudentInfo);
            this.panel2.Controls.Add(this.btnAllTeacherInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(863, 138);
            this.panel2.TabIndex = 0;
            // 
            // btnAllTeacherInfo
            // 
            this.btnAllTeacherInfo.BackColor = System.Drawing.Color.DimGray;
            this.btnAllTeacherInfo.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTeacherInfo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnAllTeacherInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAllTeacherInfo.Image")));
            this.btnAllTeacherInfo.Location = new System.Drawing.Point(344, 12);
            this.btnAllTeacherInfo.Name = "btnAllTeacherInfo";
            this.btnAllTeacherInfo.Size = new System.Drawing.Size(166, 103);
            this.btnAllTeacherInfo.TabIndex = 0;
            this.btnAllTeacherInfo.Text = "All Teacher Info";
            this.btnAllTeacherInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAllTeacherInfo.UseVisualStyleBackColor = false;
            this.btnAllTeacherInfo.Click += new System.EventHandler(this.btnAllTeacherInfo_Click);
            // 
            // btnAllStudentInfo
            // 
            this.btnAllStudentInfo.BackColor = System.Drawing.Color.DimGray;
            this.btnAllStudentInfo.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllStudentInfo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnAllStudentInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnAllStudentInfo.Image")));
            this.btnAllStudentInfo.Location = new System.Drawing.Point(616, 12);
            this.btnAllStudentInfo.Name = "btnAllStudentInfo";
            this.btnAllStudentInfo.Size = new System.Drawing.Size(166, 103);
            this.btnAllStudentInfo.TabIndex = 1;
            this.btnAllStudentInfo.Text = "All Student Info";
            this.btnAllStudentInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAllStudentInfo.UseVisualStyleBackColor = false;
            this.btnAllStudentInfo.Click += new System.EventHandler(this.btnAllStudentInfo_Click);
            // 
            // pnlShowInformation
            // 
            this.pnlShowInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(141)))), ((int)(((byte)(115)))));
            this.pnlShowInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShowInformation.Location = new System.Drawing.Point(0, 138);
            this.pnlShowInformation.Name = "pnlShowInformation";
            this.pnlShowInformation.Size = new System.Drawing.Size(863, 351);
            this.pnlShowInformation.TabIndex = 2;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.DimGray;
            this.btnUserInfo.Font = new System.Drawing.Font("Calibri", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.DarkKhaki;
            this.btnUserInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnUserInfo.Image")));
            this.btnUserInfo.Location = new System.Drawing.Point(72, 12);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(166, 103);
            this.btnUserInfo.TabIndex = 2;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUserInfo.UseVisualStyleBackColor = false;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // TeacherInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 489);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TeacherInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAllTeacherInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlShowInformation;
        private System.Windows.Forms.Button btnAllStudentInfo;
        private System.Windows.Forms.Button btnUserInfo;
    }
}