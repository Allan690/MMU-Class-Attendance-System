using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

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

        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
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
        void logout()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);

                //save data
            }
        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (var waitingForm = new Waitfrm(logout))
                {
                    waitingForm.ShowDialog(this);
                    Form tmp = this.FindForm();
                    tmp.Close();
                    tmp.Dispose();
                    AdminLogin adm = new AdminLogin();
                    adm.Show();
                }

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Defaulters_Report rpt = new Defaulters_Report();
            rpt.ShowDialog();
        }
    }
}
