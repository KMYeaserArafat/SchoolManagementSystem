using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystemSln
{
    public partial class LessonPaneAndShyllebus : Form
    {
        DataTable table = new DataTable();
        public LessonPaneAndShyllebus()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpSelectDate.ResetText();
            cmbDay.Text = "";
            nUDClass.ResetText();
            cmbSection.Text = "";
            btninsertDocument.Text = "Insert";
            txtPlane.Text = null;
        }

        private void btninsertDocument_Click(object sender, EventArgs e)
        {
            string imglocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.pdf)|*.pdf|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                btninsertDocument.Text = imglocation;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           //Add Data ;
            table.Rows.Add(dtpSelectDate.Text, dtpSelectDate.Text, nUDClass.Text, cmbSection.Text, btninsertDocument.Text, txtPlane.Text);
            dtpSelectDate.ResetText();
            cmbDay.Text = "";
            nUDClass.ResetText();
            cmbSection.Text = "";
            btninsertDocument.Text = "Insert";
            txtPlane.Text = null;
        }

        private void LessonPaneAndShyllebus_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date", typeof(String));
            table.Columns.Add("Day", typeof(String));
            table.Columns.Add("Class", typeof(String));
            table.Columns.Add("Section", typeof(String));
            table.Columns.Add("Plan", typeof(String));
            table.Columns.Add("Insert Document", typeof(String));
            dgvShowAllPlan.DataSource = table;
        }

        private void btnShowPlanDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvShowAllPlan.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Box is blank");
            }
            
        }
    }
}
