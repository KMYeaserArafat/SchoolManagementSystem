namespace StudentManagementSystemSln
{
    partial class LessonPaneAndShyllebus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonPaneAndShyllebus));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowPlanDelete = new System.Windows.Forms.Button();
            this.dgvShowAllPlan = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPlane = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btninsertDocument = new System.Windows.Forms.Button();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.nUDClass = new System.Windows.Forms.NumericUpDown();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllPlan)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDClass)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 516);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.btnShowPlanDelete);
            this.panel3.Controls.Add(this.dgvShowAllPlan);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(13, 210);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(797, 303);
            this.panel3.TabIndex = 1;
            // 
            // btnShowPlanDelete
            // 
            this.btnShowPlanDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnShowPlanDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowPlanDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPlanDelete.ForeColor = System.Drawing.Color.Yellow;
            this.btnShowPlanDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPlanDelete.Image")));
            this.btnShowPlanDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowPlanDelete.Location = new System.Drawing.Point(642, 253);
            this.btnShowPlanDelete.Name = "btnShowPlanDelete";
            this.btnShowPlanDelete.Size = new System.Drawing.Size(139, 47);
            this.btnShowPlanDelete.TabIndex = 15;
            this.btnShowPlanDelete.Text = "    Delete";
            this.btnShowPlanDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowPlanDelete.UseVisualStyleBackColor = false;
            this.btnShowPlanDelete.Click += new System.EventHandler(this.btnShowPlanDelete_Click);
            // 
            // dgvShowAllPlan
            // 
            this.dgvShowAllPlan.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvShowAllPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAllPlan.Location = new System.Drawing.Point(11, 41);
            this.dgvShowAllPlan.Name = "dgvShowAllPlan";
            this.dgvShowAllPlan.RowHeadersWidth = 51;
            this.dgvShowAllPlan.RowTemplate.Height = 24;
            this.dgvShowAllPlan.Size = new System.Drawing.Size(770, 206);
            this.dgvShowAllPlan.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 27);
            this.label8.TabIndex = 1;
            this.label8.Text = "Show All Plan";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtPlane);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btninsertDocument);
            this.panel2.Controls.Add(this.cmbSection);
            this.panel2.Controls.Add(this.nUDClass);
            this.panel2.Controls.Add(this.cmbDay);
            this.panel2.Controls.Add(this.dtpSelectDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(797, 176);
            this.panel2.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Yellow;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(641, 104);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 47);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "   Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Blue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(496, 104);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 47);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "    Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPlane
            // 
            this.txtPlane.Location = new System.Drawing.Point(134, 94);
            this.txtPlane.Multiline = true;
            this.txtPlane.Name = "txtPlane";
            this.txtPlane.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPlane.Size = new System.Drawing.Size(350, 75);
            this.txtPlane.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Write Plan : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(626, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Insert Document";
            // 
            // btninsertDocument
            // 
            this.btninsertDocument.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btninsertDocument.Font = new System.Drawing.Font("Modern No. 20", 10.8F);
            this.btninsertDocument.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btninsertDocument.Location = new System.Drawing.Point(617, 58);
            this.btninsertDocument.Name = "btninsertDocument";
            this.btninsertDocument.Size = new System.Drawing.Size(152, 30);
            this.btninsertDocument.TabIndex = 9;
            this.btninsertDocument.Text = "Insert ";
            this.btninsertDocument.UseVisualStyleBackColor = false;
            this.btninsertDocument.Click += new System.EventHandler(this.btninsertDocument_Click);
            // 
            // cmbSection
            // 
            this.cmbSection.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbSection.Location = new System.Drawing.Point(531, 58);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(66, 29);
            this.cmbSection.TabIndex = 8;
            // 
            // nUDClass
            // 
            this.nUDClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.nUDClass.Location = new System.Drawing.Point(443, 60);
            this.nUDClass.Name = "nUDClass";
            this.nUDClass.Size = new System.Drawing.Size(69, 28);
            this.nUDClass.TabIndex = 7;
            // 
            // cmbDay
            // 
            this.cmbDay.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "Satuerday",
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thuesday",
            "Friday"});
            this.cmbDay.Location = new System.Drawing.Point(299, 59);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(127, 29);
            this.cmbDay.TabIndex = 6;
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelectDate.Location = new System.Drawing.Point(10, 61);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(283, 27);
            this.dtpSelectDate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(449, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(528, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Section";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(310, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Day";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(94, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Lesson Plan";
            // 
            // LessonPaneAndShyllebus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 516);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LessonPaneAndShyllebus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LessonPaneAndShyllebus_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAllPlan)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPlane;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninsertDocument;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.NumericUpDown nUDClass;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvShowAllPlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowPlanDelete;
    }
}