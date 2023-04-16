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
    public partial class TeacherProtal : Form
    {
        
        public TeacherProtal()
        {
            InitializeComponent();
        }

        private void btnLessonPlanAndAnalysic_Click(object sender, EventArgs e)
        {
            LessonPaneAndShyllebus lps = new LessonPaneAndShyllebus();
            lps.TopLevel = false;
            panel3.Controls.Add(lps);
            lps.BringToFront();
            lps.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home h1 = new Home();
            h1.TopLevel = false;
            panel3.Controls.Add(h1);
            h1.BringToFront();
            h1.Show();
        }

        private void btnViewNotice_Click(object sender, EventArgs e)
        {
            TeacherViewNotice tvn = new TeacherViewNotice();
            tvn.TopLevel = false;
            panel3.Controls.Add(tvn);
            tvn.BringToFront();
            tvn.Show();
        }

        private void btnViewPolicy_Click(object sender, EventArgs e)
        {
            TeacherViewPolicy tvp = new TeacherViewPolicy();
            tvp.TopLevel = false;
            panel3.Controls.Add(tvp);
            tvp.BringToFront();
            tvp.Show();
        }

        private void btnNoteRemender_Click(object sender, EventArgs e)
        {
            TeacherNoteRemender tnr = new TeacherNoteRemender();
            tnr.TopLevel = false;
            panel3.Controls.Add(tnr);
            tnr.BringToFront();
            tnr.Show();
        }

        private void btnRecordAttendance_Click(object sender, EventArgs e)
        {
            TeacherRecordAttendance tra = new TeacherRecordAttendance();
            tra.TopLevel = false;
            panel3.Controls.Add(tra);
            tra.BringToFront();
            tra.Show();
        }
    }
}
