using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Text.RegularExpressions;
using Bunifu.Framework.UI;
using System.Threading;
using DGVPrinterHelper;
using System.Drawing;

namespace MMUSIS1.UserControls
{
    public partial class addCourseUC : UserControl
    {
        int courseid = 0;
   
        public addCourseUC()
        {
            InitializeComponent();
            sysUser.Text = "The Current System User is: "  + this.MyProperty ;
        }
        class EmptyField : ApplicationException
        {

            public void EmptyFields()
            {
                MessageBox.Show("Some fields are empty. Please ensure all fields are filled before trying again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
        }
        private void addCourseUC_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(MyProperty);
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            filldatagridview();
            AutoCompleteTxtCourseCode();
            AutoCompleteTxtCourseName();
            AutoCompleteFaculty();
            AutoCompleteDepartment();
            
        }

        void verify()
        {
            if(lblCoursecode.Text=="Invalid" || lblCoursename.Text == "Invalid" || lblDepartment.Text == "Invalid" || lblFaculty.Text == "Invalid")
            {
                               
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblCoursecode.Text == "Invalid"|| lblCoursecode.Text ==""  || lblCoursename.Text == "Invalid"|| lblCoursename.Text == "" || lblDepartment.Text == "Invalid" || lblDepartment.Text==""|| lblFaculty.Text == "Invalid"|| lblFaculty.Text=="")
            {
                formError fm = new formError();
                fm.ShowDialog();
                return;
            }
            else
            {
                try
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        DynamicParameters param = new DynamicParameters();
                        param.Add("@courseid", courseid);
                        param.Add("@coursecode", txtCourseCode.Text.Trim());
                        param.Add("@coursename", txtCourseName.Text.Trim());
                        param.Add("@faculty", txtFaculty.Text.Trim());
                        param.Add("@department", txtDepartment.Text.Trim());

                        db.Execute("CoursesAddOrEdit", param, commandType: CommandType.StoredProcedure);
                        db.Close();

                        filldatagridview();
               metroGrid1.Visible = true;

                    }
                }

                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        duplicateRecords dp = new duplicateRecords();
                        dp.ShowDialog();
                    }
                }
            }
        }
        void AutoCompleteTxtCourseCode()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select CourseCode from dbo.Courses", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtCourseCode.AutoCompleteCustomSource = coll;

            }
            

        }
        void AutoCompleteTxtCourseName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select CourseName from dbo.Courses", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtCourseName.AutoCompleteCustomSource = coll;

            }
           
        }
        void AutoCompleteFaculty()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select Faculty from dbo.Courses", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtFaculty.AutoCompleteCustomSource = coll;

            }
           
        }
        void AutoCompleteDepartment()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select Department from dbo.Courses", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtDepartment.AutoCompleteCustomSource = coll;

            }

        }

        void filldatagridview()
        {
            try
            {

                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@SearchText", txtSearch.Text.Trim());
                    List<Courses> list = db.Query<Courses>
                        ("CoursesViewOrSearch", param, commandType: CommandType.StoredProcedure).ToList<Courses>();
                    metroGrid1.DataSource = list;
                    metroGrid1.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void errortest(MetroFramework.Controls.MetroTextBox tb)
        {
            if(tb.Text==null|| tb.Text =="")
            {
                MessageBox.Show("Please fill all text boxes bef");
            }
                
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            
           
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@courseid", courseid);
                param.Add("@coursecode", txtCourseCode.Text.Trim());
                param.Add("@coursename", txtCourseName.Text.Trim());
                param.Add("@faculty", txtFaculty.Text.Trim());
                param.Add("@department", txtDepartment.Text.Trim());

                db.Execute("CoursesAddOrEdit", param, commandType: CommandType.StoredProcedure);
                db.Close();
                metroGrid1.Visible = true;
                filldatagridview();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClearAll();

        }
        class Courses
        {
            public int CourseID { get; set; }
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            public string Faculty { get; set; }
            public string Department { get; set;}

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    DynamicParameters param = new DynamicParameters();
                    param.Add("@coursecode", txtCourseCode.Text);
                    
                    db.Execute("CourseDeletebyID", param, commandType: CommandType.StoredProcedure);
                    db.Close();

                    filldatagridview();
                 metroGrid1.Visible = true;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void ClearAll()
        {
            txtCourseCode.Text = txtCourseName.Text = txtFaculty.Text = txtDepartment.Text = txtSearch.Text = "";
            courseid = 0;
            picCourseCode.Image = picCourseName.Image = picDepartment.Image = picFaculty.Image = picSearch.Image = null;
            lblCoursecode.Text = lblCoursename.Text = lblDepartment.Text = lblFaculty.Text = lblSearch.Text = "";
        }

        private void txtCoursecode_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Course code field edited.";
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

        private void txtCoursecode_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtCoursename_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtFaculty_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtCoursename_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Course name field edited.";
        }

        private void txtFaculty_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Faculty name field edited.";
        }

        private void txtDepartment_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Department field edited.";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
                txtFaculty.Text = row.Cells["Faculty"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void txtCourseCode_Leave_1(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseCode, picCourseCode, lblCoursecode, "");
            regexp(@"^[A-Z]+(-[0-9]+)(?![\s\S])$", txtCourseCode, picCourseCode, lblCoursecode, "");
        }

        private void txtCourseName_Leave_1(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseName, picCourseName, lblCoursename, "");
            regexp(@"[A-Za-z ]+[A-Za-z ]{5}$", txtCourseName, picCourseName, lblCoursename, "");
        }

        private void txtFaculty_Leave_1(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtFaculty, picFaculty, lblFaculty, "");
            regexp(@"[A-Za-z ]+[A-Za-z ]{3}$", txtFaculty, picFaculty, lblFaculty, "");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Search field edited.";
            try
            {
                filldatagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtDepartment_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDepartment_Leave_1(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtDepartment, picDepartment, lblDepartment, "");
            regexp(@"[A-Za-z]+[A-Za-z]{5}$", txtDepartment, picDepartment, lblDepartment, "");
        }

        private void txtSearch_Leave_1(object sender, EventArgs e)
        {
            regexp(@" ^ (\s|\S)*(\S)+(\s|\S)*$", txtSearch, picSearch, lblSearch, "");
           // regexp(@" ^ (\s|\S)*(\S)+(\s|\S)*$", txtSearch, picSearch, lblSearch, "");
        }

        private void txtDepartment_Click(object sender, EventArgs e)
        {

        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Courses On Offer";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Multimedia University Class Attendance System \u00a9 2018";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(metroGrid1);
        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}