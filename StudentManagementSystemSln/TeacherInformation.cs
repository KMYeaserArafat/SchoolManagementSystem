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
    public partial class TeacherInformation : Form
    {
        public TeacherInformation()
        {
            InitializeComponent();
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            pnlTUserInfo userInfo = new pnlTUserInfo();
            userInfo.TopLevel = false;
            pnlShowInformation.Controls.Add(userInfo);
            userInfo.BringToFront();
            userInfo.Show();
        }

        private void btnAllTeacherInfo_Click(object sender, EventArgs e)
        {
            pnlTAllTeacherInfo allTeacherInfo = new pnlTAllTeacherInfo();
            allTeacherInfo.TopLevel = false;
            pnlShowInformation.Controls.Add(allTeacherInfo);
            allTeacherInfo.BringToFront();
            allTeacherInfo.Show();
        }

        private void btnAllStudentInfo_Click(object sender, EventArgs e)
        {
            pnlTAllStudentInfo studentInfo = new pnlTAllStudentInfo();
            studentInfo.TopLevel = false;   
            pnlShowInformation.Controls.Add(studentInfo);
            studentInfo.BringToFront();
            studentInfo.Show();
        }
    }
}
