using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystemSln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
             if(cbShowPassword.Checked)
            {
                txtUserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtUserPassword.UseSystemPasswordChar = true;
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to logout this Application ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
               == DialogResult.Yes)
            {
                txtUserID.Text = null;
                txtUserPassword.Text = null;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserID.Text == "admin-1" && txtUserPassword.Text == "123")
            {
                MessageBox.Show("Admin Protal is Open");
            }
            else if(txtUserID.Text == "teacher-1" && txtUserPassword.Text == "123")
            {
                MessageBox.Show("Teacher Protal is Open");
            }
            else if(txtUserID.Text == "student-1" && txtUserPassword.Text == "123")
            {
                MessageBox.Show("Student Protal is Open");
            }
            else
            {
                MessageBox.Show(" Invalid to Login");
            }
        }
    }
}
