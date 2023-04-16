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
    public partial class TeacherViewPolicy : Form
    {
        public TeacherViewPolicy()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void TeacherViewPolicy_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Policy Permit Date", typeof(String));
            table.Columns.Add("Policy",typeof(String));
            dgvTeacherViewPolicy.DataSource = table;
            dgvTeacherViewPolicy.Columns["Policy Permit Date"].Width = 150;
            dgvTeacherViewPolicy.Columns["Policy"].Width = 448;
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
