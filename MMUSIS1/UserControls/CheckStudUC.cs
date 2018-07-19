using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using DGVPrinterHelper;
using System.Text.RegularExpressions;
using System.Threading;

namespace MMUSIS1.UserControls
{
    public partial class CheckStudUC : UserControl
    {
        public CheckStudUC()
        {
            InitializeComponent();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void AutoCompleteTxtAdmin()
        {            
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select AdmNo from StudAttendance", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtAdmNo.AutoCompleteCustomSource = coll;

            }
            txtName.Enabled = false;
            txtCourse.Enabled = false;
                      
            
        }

        void AutoCompleteTxtName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select DISTINCT Name from StudAttendance WHERE AdmNo = '"+txtAdmNo.Text+"'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtAdmNo.AutoCompleteCustomSource = coll;

            }


        }
        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
        }

        private void CheckStudUC_Load(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                     metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    studentAttendanceBindingSource.DataSource = db.Query<StudentAttendance>("Select distinct b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c on b.AdmNo= c.AdmNo group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course", commandType: CommandType.Text);
                   // metroGrid1_CellValueChanged(sender, e);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            AutoCompleteTxtAdmin();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "MMU Students Class Attendance report";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Multimedia University Class Attendance System (c) 2018";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(metroGrid1);


        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                txtAdmNo.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtCourse.Text = row.Cells[4].Value.ToString();
              
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                string dtFrom = dtFromDate.Value.ToString();
                string dtTo = dtToDate.Value.ToString();
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where StudDate >= '" + dtFrom + "' and StudDate <= '" + dtTo + "' and b.AdmNo='" + txtAdmNo.Text + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";
                string query1 = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where StudDate >= '" + dtFrom + "' and StudDate <= '" + dtTo + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";
                if (txtAdmNo.Text != "")
                {

                    metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    studentAttendanceBindingSource.DataSource = db.Query<StudentAttendance>(query, commandType: CommandType.Text);
                }
                else
                {

                    metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    studentAttendanceBindingSource.DataSource = db.Query<StudentAttendance>(query1, commandType: CommandType.Text);
                }
             

            }
        }

        private void txtAdmNo_Click(object sender, EventArgs e)
        {

        }

        private void txtAdmNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where b.AdmNo = '" + txtAdmNo.Text + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";

                    metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    studentAttendanceBindingSource.DataSource = db.Query<StudentAttendance>(query, commandType: CommandType.Text);

                }
              //  AutoCompleteTxtName();
              
            }
        }

        private void metroGrid1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void regexp(string re, MetroFramework.Controls.MetroTextBox tb, PictureBox pc, Label lbl, string s)
        {

            Regex regex = new Regex(re);
            if (regex.IsMatch(tb.Text))
            {
                pc.Image = Properties.Resources.correctbtn;
                lbl.ForeColor = System.Drawing.Color.Green;
                lbl.Text = s + "valid";
            }
            else
            {
                pc.Image = Properties.Resources.errorbtn;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = s + "Invalid";
            }
        }
        public void regexpy(string re, DateTimePicker dt, PictureBox pc, Label lbl, string s)
        {
            Regex regex = new Regex(re);
            if (regex.IsMatch(dt.Text))
            {
                pc.Image = Properties.Resources.correctbtn;
                lbl.ForeColor = System.Drawing.Color.Green;
                lbl.Text = s + "valid";
            }
            else
            {
                pc.Image = Properties.Resources.errorbtn;
                lbl.ForeColor = System.Drawing.Color.Red;
                lbl.Text = s + "Invalid";
            }
        }

        private void txtAdmNo_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtAdmNo, picAdmNo, lblAdmNo, "");
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtName, picName, lblName, "");
        }

        private void txtCourse_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourse, picCourse, lblCourse, "");
        }

        private void dtFromDate_ValueChanged(object sender, EventArgs e)
        {
            regexpy(@"^(\s|\S)*(\S)+(\s|\S)*$", dtFromDate, picFromDate, lblFrom, "");
            FieldChecker.Text = "Value of From date changed.";
        }

        private void dtToDate_ValueChanged(object sender, EventArgs e)
        {
            regexpy(@"^(\s|\S)*(\S)+(\s|\S)*$", dtToDate, picToDate, lblTo, "");
            FieldChecker.Text = "Value of To date changed.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblDate.Text = dt.ToLongDateString();
            lblTime.Text = dt.ToLongTimeString();
        }

        private void txtAdmNo_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Admission Number text field modified.";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Student name text field modified.";
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Course text field modified.";
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where FullName = '" + txtName.Text + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";

                    studentAttendanceBindingSource.DataSource = db.Query<StudentAttendance>(query, commandType: CommandType.Text);

                }
            }
        }

        private void txtCourse_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where Course = '" + txtCourse.Text + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";

                    studentAttendanceBindingSource.DataSource = db.Query<StudentAttendance>(query, commandType: CommandType.Text);

                }
            }
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
            else if (dialog == DialogResult.No)
            {
                this.Show();

            }
        }
    }
}
