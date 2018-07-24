using System;
using System.Windows.Forms;
namespace MMUSIS1
{

    public partial class Dashboard : Form
    {
        BunifuAnimatorNS.AnimateMode nm = new BunifuAnimatorNS.AnimateMode();
        public Dashboard()
        {
           
            InitializeComponent();
            addStudUC1.BringToFront();
            lblAddStud.Text = "Add Student";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           // richTextBox1.Enabled = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            errForm ct = new errForm("Do you want to exit MMUSAS V 1.0?");
            ct.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //panelLeft.Height = button1.Height;
            //panelLeft.Top = button1.Top;
            addStudUC1.BringToFront();
            lblAddStud.Text = "Add Student";
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////panelLeft.Height = button2.Height;
            //panelLeft.Top = button2.Top;
            //studCheckinUC1.BringToFront();
            //lblAddStud.Text = "Student Check-in";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //panelLeft.Top = button3.Top;
            //panelLeft.Height = button3.Height;
            checkStudUC1.BringToFront();
            lblAddStud.Text = "Check Student Attendance";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //panelLeft.Height = button4.Height;
            //panelLeft.Top = button4.Top;
            sendEmailUC1.BringToFront();
            lblAddStud.Text = "Send Email";
        }

        private void sendEmailUC1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            chatUC1.BringToFront();
            lblAddStud.Text = "Send a text message";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chatUC1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            reportsUC1.BringToFront();
            lblAddStud.Text = "View and Print your reports.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void reportsUC1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.Gray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;

        }

       

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.Color.Gray;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.Color.Gray;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.Color.Gray;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.Color.Gray;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.BackColor = System.Drawing.Color.Gray;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.BackColor = System.Drawing.Color.Gray;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            settingsUC1.BringToFront();
            lblAddStud.Text = "Settings Panel";
        }

        private void settingsUC1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Gold;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.Gold;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.SystemColors.Control;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            importCSV1.BringToFront();
            lblAddStud.Text = "Import a File";
        }

        private void lblAddStud_Click(object sender, EventArgs e)
        {

        }
    }
}
