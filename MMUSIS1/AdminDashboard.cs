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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            
            InitializeComponent();
            addStudUC1.BringToFront();
            lblAddStud.Text = "Add Student";
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            addStudUC1.BringToFront();
            lblAddStud.Text = "Add Student";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            addUnitUC1.BringToFront();
            lblAddStud.Text = "Add Unit";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            addCourseUC1.BringToFront();
            lblAddStud.Text = "Add Course";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkStudUC1.BringToFront();
            lblAddStud.Text = "Check Student Attendance";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sendEmailUC1.BringToFront();
            lblAddStud.Text = "Send Email";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reportsUC1.BringToFront();
            lblAddStud.Text = "View your reports";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            settingsUC1.BringToFront();
            lblAddStud.Text = "Settings";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            importCSV1.BringToFront();
            lblAddStud.Text = "Import Files";
            

        }

        private void btnAddStudent_MouseEnter(object sender, EventArgs e)
        {
            btnAddStudent.BackColor = Color.Gray;

        }

        private void btnAddStudent_MouseLeave(object sender, EventArgs e)
        {
            btnAddStudent.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button16_MouseEnter(object sender, EventArgs e)
        {
            button16.BackColor = Color.Gray;

        }

        private void button15_MouseEnter(object sender, EventArgs e)
        {
            button15.BackColor = Color.Gray;

        }

        private void button15_MouseLeave(object sender, EventArgs e)
        {
            button15.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.Gray;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chatUC1.BringToFront();
            lblAddStud.Text = "Send Text Message";
        }

        private void chatUC1_Load(object sender, EventArgs e)
        {

        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.Gray;

        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.Gray;

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.Gray;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = Color.Gray;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = Color.Gray;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = SystemColors.ActiveCaptionText;
        }

        private void button16_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button16_MouseLeave(object sender, EventArgs e)
        {
            button16.BackColor = SystemColors.ActiveCaptionText;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            errForm ct = new errForm("Do you want to exit MMUSAS V 1.0?");
            ct.ShowDialog();

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
