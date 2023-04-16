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
    public partial class TeacherNoteRemender : Form
    {
        public TeacherNoteRemender()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtTitle.Text = null;
            txtNote.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtTitle.Text,txtNote.Text);
        }

        DataTable table = new DataTable();
        private void TeacherNoteRemender_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Note", typeof(String));
            dataGridView1.DataSource = table;
            dataGridView1.Columns["Note"].Visible = false;
            dataGridView1.Columns["Title"].Width = 448;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                table.Rows[index].Delete();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Note Box is Blank");
            }
           

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index >= 0)
                {
                    txtTitle.Text = table.Rows[index].ItemArray[0].ToString();
                    txtNote.Text = table.Rows[index].ItemArray[1].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("NoteBox is Blank");
            }
           
        }
    }
}
