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
    public partial class TeacherViewNotice : Form
    {
        public TeacherViewNotice()
        {
            InitializeComponent();
        }

        DataTable Table = new DataTable();

        private void btnView_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Message");
        }

        DataTable table = new DataTable();
        private void TeacherViewNotice_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Date",typeof(String));
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Notice", typeof(String));
            dgvNotice.DataSource = table;
            dgvNotice.Columns["Notice"].Width = 448;
            dgvNotice.AutoSize = true;
        }

        private void btnShowNotice_Click(object sender, EventArgs e)
        {
            pnlShowNotice.Visible = true;
            try
            {
                int index = dgvNotice.CurrentCell.RowIndex;

                if (index >= 0)
                {
                    txtDate.Text = table.Rows[index].ItemArray[0].ToString();
                    txtTitle.Text = table.Rows[index].ItemArray[1].ToString();
                    txtNotice.Text = table.Rows[index].ItemArray[2].ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Total Notice Board is Blank");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlShowNotice.Hide();
        }
    }
}
