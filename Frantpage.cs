using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Coaching_Classes
{
    public partial class Frantpage : Form
    {
        public Frantpage()
        {
            InitializeComponent();
        }

        private void courseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseDetails cd = new CourseDetails();
            cd.Show();
        }

        private void teacherDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherDetails t = new TeacherDetails();
            t.Show();
        }

        private void studentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentDetails s = new StudentDetails();
            s.Show();
        }

        private void feesDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FeesDetails f = new FeesDetails();
            f.Show();
        }
    }
}
