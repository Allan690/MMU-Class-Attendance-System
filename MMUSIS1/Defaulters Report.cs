using Dapper;
using DGVPrinterHelper;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class Defaulters_Report : MetroFramework.Forms.MetroForm
    {
        
        public Defaulters_Report()
        {
            InitializeComponent();
           
        }
      //  List<Units> _listUnits = new List<Units>();
        private void Defaulters_Report_Load(object sender, EventArgs e)
        {
            
            btnSaveData.Enabled = false;
            txtCourseName.Enabled = false;
            txtUnitName.Enabled = false;
            try
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                 defaultersBindingSource.DataSource = db.Query<Defaulters>("Select distinct b.AdmNo, c.FullName, b.Geolocation, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c on b.AdmNo= c.AdmNo group by b.AdmNo, c.FullName, b.Geolocation,b.StudDate, b.Unit, b.Faculty, b.Course", commandType: CommandType.Text);
                   
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            AutoCompleteUnitCode();
            AutoCompleteCourseCode();
        }
       
        void AutoCompleteUnitCode()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select UnitCode from Units", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                   // txtUnitName.Text = reader["UnitName"].ToString();
                }
                txtUnitCode.AutoCompleteCustomSource = coll;

            }
            
        }
        void AutoCompleteCourseCode()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select CourseCode from Courses", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                    // txtUnitName.Text = reader["UnitName"].ToString();
                }
                txtCourseCode.AutoCompleteCustomSource = coll;

            }
        }
        void AutoFillCourseName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from Courses where CourseCode='" + txtCourseCode.Text + "'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(1);
                    txtCourseName.Text = sName;
                }
            }
        }
         void AutoFillUnitName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select * from Units where UnitCode='"+txtUnitCode.Text+"'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(1);
                    txtUnitName.Text = sName;
                }
            }

            }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitName_Click(object sender, EventArgs e)
        {

        }

        private void txtVenue_Click(object sender, EventArgs e)
        {

        }

        private void txtUnitCode_TextChanged(object sender, EventArgs e)
        {
            AutoFillUnitName();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }
        public void regexp(string re, MetroTextBox tb, PictureBox pc, Label lbl, string s)
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
        public void regexp2(string re, MetroDateTime tb, PictureBox pc, Label lbl, string s)
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

        private void txtVenue_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtVenue, picVenue, lblVenue, "");
        }

        private void txtUnitCode_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtUnitCode, picUnitCode, lblUnitCode, "");
        }

        private void txtUnitName_Leave(object sender, EventArgs e)
        {
          
        }

        private void txtUnitName_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtUnitName, picUnitName, lblUnitName, "");
        }

        private void txtCourseCode_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseCode, picCourseCode, lblCourseCode, "");
        }

        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseName, picCourseName, lblCourseName, "");
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
                    List<Defaulters> list = db.Query<Defaulters>
                        ("StudAttendanceViewOrSearch", param, commandType: CommandType.StoredProcedure).ToList();
                    metroGrid1.DataSource = list;
                   // metroGrid1.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filldatagridview();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Defaulters Report: '"+dtFrom.Value.ToShortDateString()+"' - '"+dtTo.Value.ToShortDateString()+"'";
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

        private void txtCourseName_Leave(object sender, EventArgs e)
        {

        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            regexp2(@"^(\s|\S)*(\S)+(\s|\S)*$", dtFrom, picFrom, lblFrom, "");
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            regexp2(@"^(\s|\S)*(\S)+(\s|\S)*$", dtTo, picTo, lblTo, "");
        }
        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txtUnitName.Text == "" || txtCourseCode.Text == "" || txtCourseName.Text == "" || txtUnitCode.Text == "" || txtVenue.Text == "")
            {
                formError err = new formError();
                err.ShowDialog();
                return;
            }
            else
            {
                try
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        string datFrom = dtFrom.Value.ToShortDateString();
                        string datTo = dtTo.Value.ToShortDateString();
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        string query1 = "Select b.AdmNo, c.FullName, b.Geolocation, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where StudDate >= '" + datFrom + "' and StudDate <= '" + datTo + "' and Geolocation NOT like '%" + txtVenue.Text + "%' and Unit='" + txtUnitName.Text + "' and b.Course='" + txtCourseName.Text + "'group by b.AdmNo, c.FullName, b.Geolocation, b.StudDate, b.Unit, b.Faculty, b.Course";
                        metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        defaultersBindingSource.DataSource = db.Query<Defaulters>(query1, commandType: CommandType.Text);

                    }
                    btnSaveData.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtCourseCode_TextChanged(object sender, EventArgs e)
        {
            AutoFillCourseName();
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourseCode, picCourseCode, lblCourseCode, "");
            
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            txtVenue.Text = txtUnitCode.Text = txtUnitName.Text = txtCourseName.Text =txtCourseCode.Text = null;
            dtFrom.Value = DateTime.Now;
            dtTo.Value = DateTime.Now;
        }

        private void txtVenue_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtVenue, picVenue, lblVenue, "");
        }
       
        void newCode()
        {
            DialogResult dr = MessageBox.Show("Do you want to save the list of defaulters?", "Save Records?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           if (dr == DialogResult.Yes)
            {
                try
                {

                    for (int i = 0; i < metroGrid1.Rows.Count-1; i++)
                    {
                        string AdmNo = metroGrid1.Rows[i].Cells[0].Value.ToString();
                        string FullName = metroGrid1.Rows[i].Cells[1].Value.ToString();
                        string Geolocation = metroGrid1.Rows[i].Cells[2].Value.ToString();
                        string StudDate = metroGrid1.Rows[i].Cells[3].Value.ToString();
                        string Unit = metroGrid1.Rows[i].Cells[4].Value.ToString();       
                        string Course = metroGrid1.Rows[i].Cells[5].Value.ToString();
                        string Faculty = metroGrid1.Rows[i].Cells[6].Value.ToString();
                    
                        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                        db.Open();
                        string sql = "insert into Defaulterstbl(AdmNo,FullName,Geolocation,StudDate,Unit, Course, Faculty) values(@admno, @fullname, @geolocation, @studdate, @unit, @course, @faculty)";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Connection = db;
                        cmd.Parameters.AddWithValue("@admno", AdmNo);
                        cmd.Parameters.AddWithValue("@fullname", FullName);
                        cmd.Parameters.AddWithValue("@geolocation", Geolocation);
                        cmd.Parameters.AddWithValue("@studdate", StudDate);
                        cmd.Parameters.AddWithValue("@unit", Unit);
                        cmd.Parameters.AddWithValue("@course", Course);
                        cmd.Parameters.AddWithValue("@faculty", Faculty);
                        cmd.ExecuteNonQuery();
                        db.Close();
                    }
                    UpdateSuccess ups = new UpdateSuccess();
                    ups.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            newCode();
        }

    }

    }

