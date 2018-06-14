using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1.UserControls
{
    public partial class ReportsUC : UserControl
    {
        public ReportsUC()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            studAttendancerpt stud = new studAttendancerpt();
            stud.ShowDialog();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportsUC_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            ThresholdReachers tr = new ThresholdReachers();
            tr.ShowDialog();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            Non_Threshold_reachers frm = new Non_Threshold_reachers();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
        }

        private void bunifuFlatButton1_MouseEnter(object sender, EventArgs e)
        {
            FieldChecker.Text = "Generate Student Attendance Report";
        }

        private void bunifuFlatButton2_MouseEnter(object sender, EventArgs e)
        {
            FieldChecker.Text = "Generate Threshold reachers Report";
        }

        private void bunifuFlatButton2_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_MouseEnter(object sender, EventArgs e)
        {
            FieldChecker.Text = "Generate Non-Threshold reachers report";
              }

        private void bunifuFlatButton5_MouseEnter(object sender, EventArgs e)
        {
            FieldChecker.Text = "Generate Exam Card Report";
        }
    }
}
