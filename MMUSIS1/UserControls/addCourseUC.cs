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
namespace MMUSIS1.UserControls
{
    public partial class addCourseUC : UserControl
    {
        int courseid = 0;
   
        public addCourseUC()
        {
            InitializeComponent();
        }
        class EmptyField : ApplicationException
        {

            public void EmptyFields()
            {
                MessageBox.Show("Some fields are empty. Please ensure all fields are filled before trying again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      

        private void addCourseUC_Load(object sender, EventArgs e)
        {
          metroGrid1.Visible = false;
        }

        void verify()
        {
            if(lblCoursecode.Text=="Invalid" || lblCoursename.Text == "Invalid" || lblDepartment.Text == "Invalid" || lblFaculty.Text == "Invalid")
            {
                btnAdd.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lblCoursecode.Text == "" || lblCoursename.Text == "" || lblDepartment.Text == "" || lblFaculty.Text == "")
            {
                MessageBox.Show("Please fill all the fields on the form.", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                        param.Add("@coursecode", txtCoursecode.Text.Trim());
                        param.Add("@coursename", txtCoursename.Text.Trim());
                        param.Add("@faculty", txtFaculty.Text.Trim());
                        param.Add("@department", txtDepartment.Text.Trim());

                        db.Execute("CoursesAddOrEdit", param, commandType: CommandType.StoredProcedure);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
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
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@courseid", courseid);
                param.Add("@coursecode", txtCoursecode.Text.Trim());
                param.Add("@coursename", txtCoursename.Text.Trim());
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
                    param.Add("@coursecode", txtCoursecode.Text);
                    
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
            txtCoursecode.Text = txtCoursename.Text = txtFaculty.Text = txtDepartment.Text = txtSearch.Text = "";
            courseid = 0;
            picCourseCode.Image = picCourseName.Image = picDepartment.Image = picFaculty.Image = picSearch.Image = null;
            lblCoursecode.Text = lblCoursename.Text = lblDepartment.Text = lblFaculty.Text = lblSearch.Text = "";
        }

        private void txtCoursecode_OnValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Course code field edited.";
        }
        public void regexp(string re, BunifuMaterialTextbox tb, PictureBox pc, Label lbl, string s)
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
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCoursecode, picCourseCode, lblCoursecode, "");
        }

        private void txtCoursename_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCoursename, picCourseName, lblCoursename, "");
        }

        private void txtFaculty_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtFaculty, picFaculty, lblFaculty, "");
        }

        private void txtDepartment_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtDepartment, picDepartment, lblDepartment, "");
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtSearch,picSearch, lblSearch, "");
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Show();
            }
            else if (dialog == DialogResult.No)
            {
                this.Hide();
                AdminLogin adm = new AdminLogin();
                adm.Show();
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                txtCoursecode.Text = row.Cells["CourseCode"].Value.ToString();
                txtCoursename.Text = row.Cells["CourseName"].Value.ToString();
                txtFaculty.Text = row.Cells["Faculty"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
            }
        }

       
    }
}