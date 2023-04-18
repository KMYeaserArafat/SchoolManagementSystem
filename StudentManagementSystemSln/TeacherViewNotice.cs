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
            
        }

           
  
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowNotice_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvNotice.CurrentCell.RowIndex;

                MessageBox.Show(table.Rows[index].ItemArray[3].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No Notice at yet !");
            }
           
        }
    }
}
