using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class HowManyLessons : Form
    {
        public HowManyLessons()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double parsedvalue;
            if (!double.TryParse(txtCourse.Text, out parsedvalue))
            {
                txtCourse.Text = "";
            }
            studAttendancerpt rpt = new studAttendancerpt();
            rpt.attendance(parsedvalue);
            this.Close();
            
        }

        private void txtCourse_Click(object sender, EventArgs e)
        {

        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            double parsedvalue;
            if(!double.TryParse(txtCourse.Text, out parsedvalue))
            {
                txtCourse.Text = "";
            }
        }
    }
}
