using Dapper;
using DGVPrinterHelper;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class ThresholdReachers : MetroFramework.Forms.MetroForm
    {
        public ThresholdReachers()
        {
            InitializeComponent();
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
        private void ThresholdReachers_Load(object sender, EventArgs e)
        {
            AutoCompleteAdmNo();
            AutoCompleteUnitCode();
            txtName.Enabled = false;
            txtUnitName.Enabled = false;
            txtTotal.Visible = false;
            txtGender.Visible = false;
            txtDOB.Visible = false;
            txtFaculty.Visible = false;
            txtCourse.Visible = false;
            txtUnit.Visible = false;
            metroButton2.Enabled = false;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select s.AdmNo, t.FullName, t.DOB, s.Unit, s.Course, s.Faculty, t.[Year],t.Gender from StudAttendance s inner join Students t on s.AdmNo=t.AdmNo";
                thresholdBindingSource.DataSource = db.Query<Threshold>(query, commandType: CommandType.Text);
              
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
        private void metroButton2_Click(object sender, EventArgs e)
        {
            //  thisisit();
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "TR REPORT: From "+dtFrom.Value.ToShortDateString()+" To: "+dtTo.Value.ToShortDateString()+"";
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


        void AutoCompleteAdmNo()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select AdmNo from Students", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    coll.Add(reader.GetString(0));
                }
                txtAdm.AutoCompleteCustomSource = coll;
            }
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
                }
                txtUnitCode.AutoCompleteCustomSource = coll;
            }
        }

        void AutoFillStudName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select FullName from Students where AdmNo='" + txtAdm.Text + "'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(0);
                    txtName.Text = sName;
                }
            }
        }

        void AutoFillUnitName()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select UnitName from Units where UnitCode='" + txtUnitCode.Text + "'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(0);
                    txtUnitName.Text = sName;
                }
            }
        }

        void AutoFillGender()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select Gender from Students where AdmNo='" + txtAdm.Text + "'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetBoolean(0).ToString();
                    if (sName == "true")
                    {
                        txtGender.Text = "Male";
                    }
                    else if(sName == "false")
                    {
                        txtGender.Text = "Female";
                    }
                    else
                    {
                        txtGender.Text = "N/A";
                    }
                   
                }
            }
        }
        void NameFiles(string fullPath)
        {
            int count = 1;
            string fileNameOnly = Path.GetFileNameWithoutExtension(fullPath);
            string extension = Path.GetExtension(fullPath);
            string path = Path.GetDirectoryName(fullPath);
            string newfullpath = fullPath;
            while (File.Exists(newfullpath))
            {
                string tempFileName = string.Format("{0}({1})", fileNameOnly, count++);
                newfullpath = Path.Combine(path, tempFileName + extension);
              
            }

        }
        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLesson.Text != "" &&txtAdm.Text==""&& txtUnitCode.Text!="")
                {
                    DelFields();
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        try
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            
                            string query = "select s.AdmNo, t.FullName, s.Unit, s.Course, s.Faculty, t.DOB, t.[Year],t.Gender from StudAttendance s inner join Students t on s.AdmNo=t.AdmNo " +
                               $"where StudDate between '{dtFrom.Value}' and  '{dtTo.Value}' and s.Unit='"+txtUnitName.Text+"' GROUP BY  s.AdmNo, t.FullName, s.Unit, s.Course, s.Faculty, t.DOB, t.[Year],t.Gender having COUNT(s.AdmNo)/ " + txtLesson.Text+"* 100>=67";

                            thresholdBindingSource.DataSource = db.Query<Threshold>(query, commandType: CommandType.Text);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if(txtLesson.Text != "" && txtAdm.Text != "" && txtUnitCode.Text != "")
                {
                    try
                    {
                        pickTotal();
                        DeleteFields();
                        using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            string query = "select b.AdmNo, c.FullName, b.Unit, b.Course, b.Faculty, c.DOB, c.[Year],c.Gender,count(b.AdmNo) AS Total_Attendance " +
                                "from StudAttendance b inner join Students c on b.AdmNo=c.AdmNo " +
                                $"where StudDate between '{dtFrom.Value}' and  '{dtTo.Value}' and b.AdmNo = '" + txtAdm.Text.ToString() + "' and b.Unit='" + txtUnitName.Text.ToString() + "' GROUP BY b.AdmNo, c.FullName, b.Unit, b.Course, b.Faculty, c.DOB, c.[Year],c.Gender having COUNT(b.AdmNo)>=" + txtLesson.Text;
                            thresholdBindingSource.DataSource = db.Query<Threshold>(query, commandType: CommandType.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if(txtLesson.Text=="")
                {
                    MessageBox.Show("Please fill the Lessons field");
                    txtLesson.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtLesson_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtLesson, picLesson, lblLessons, "");
        }

        private void txtAdm_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtAdm, picAdmNo, lblAdmNo, "");
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtName, picName, lblStudName, "");
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtLesson, picLesson, lblLessons, "");
        }

        private void metroGrid1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.metroGrid1.Rows[e.RowIndex];
                txtAdm.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtGender.Text = row.Cells[3].Value.ToString();
                if (txtGender.Text == "true")
                {
                    txtGender.Text = "Male";
                }
                else { txtGender.Text = "Female"; }

                txtDOB.Text = row.Cells[2].Value.ToString();
                txtFaculty.Text = row.Cells[6].Value.ToString();
                txtCourse.Text = row.Cells[5].Value.ToString();
                txtUnit.Text = row.Cells[4].Value.ToString();
                //txtTotal.Text = row.Cells[7].Value.ToString();

            }
        }

        
        void DelFields()
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("delete a from StudAttendance a inner join Defaulterstbl b on a.AdmNo= b.AdmNo where a.AdmNo= b.AdmNo and a.Unit = b.Unit and a.StudDate = b.StudDate", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //UpdateSuccess ups = new UpdateSuccess();
                //ups.ShowDialog();
            }
        }
        void DeleteFields()
        {
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("delete a from StudAttendance a inner join Defaulterstbl b on a.AdmNo= b.AdmNo where a.AdmNo='"+txtAdm.Text+"' and a.Unit ='"+txtUnitName.Text+"' and a.StudDate = b.StudDate", db);
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();                   
                    //UpdateSuccess ups = new UpdateSuccess();
                    //ups.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        void pickTotal()
        {
            try
            {
                using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand("select (select count(AdmNo) from StudAttendance where Unit ='"+txtUnitName.Text+"' and AdmNo='"+txtAdm.Text+"')-(select count(AdmNo) from Defaulterstbl where Unit ='"+txtUnitName.Text+"' and AdmNo='"+txtAdm.Text+"') as count1", db);
                    db.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string sName = reader.GetInt32(0).ToString();
                        txtTotal.Text = sName;
                    }
                   
                }
            }   
            catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            
        }
        void newCode()
        {
            DialogResult dr = MessageBox.Show("Do you want to save the list for preparation of exam card?", "Save Records?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {

                    for (int i = 0; i < metroGrid1.Rows.Count - 1; i++)
                    {
                        string AdmNo = metroGrid1.Rows[i].Cells[0].Value.ToString();                        
                        string Unit = metroGrid1.Rows[i].Cells[3].Value.ToString();
                        SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
                        db.Open();
                        string sql = "insert into ExamCardtbl(AdmNo, UnitName) values(@admno,@unit)";
                        SqlCommand cmd = new SqlCommand(sql);
                        cmd.Connection = db;
                        cmd.Parameters.AddWithValue("@admno", AdmNo);
                        cmd.Parameters.AddWithValue("@unit", Unit);
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
            newCode();
        }

        private void metroGrid1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
        void saveDgvVals()
        {
            
                DialogResult dr = MessageBox.Show("Do you want to save the list of d?", "Save Records?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    try
                    {

                        for (int i = 0; i < metroGrid1.Rows.Count - 1; i++)
                        {
                            string AdmNo = metroGrid1.Rows[i].Cells[0].Value.ToString();
                            string FullName = metroGrid1.Rows[i].Cells[1].Value.ToString();
                        string DOB = metroGrid1.Rows[i].Cells[2].Value.ToString();
                      // // string Geolocation = metroGrid1.Rows[i].Cells[2].Value.ToString();
                             string Gender = metroGrid1.Rows[i].Cells[3].Value.ToString();
                             //string StudDate = metroGrid1.Rows[i].Cells[3].Value.ToString();
                            string Unit = metroGrid1.Rows[i].Cells[4].Value.ToString();
                            string Course = metroGrid1.Rows[i].Cells[5].Value.ToString();
                            string Faculty = metroGrid1.Rows[i].Cells[6].Value.ToString();
                        string fromDate = dtFrom.Value.ToShortDateString();
                        string toDate = dtTo.Value.ToShortDateString();

                        }
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
        void AutoFillDOB()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select DOB from Students where AdmNo='"+txtAdm.Text+"'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    string sName = reader.GetDateTime(0).ToShortDateString();
                    txtDOB.Text = sName;
                }
                
            }
        }
        void AutoFillCourse()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("Select CourseName from Courses", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(0);
                    txtCourse.Text = sName;
                }
              //  txtCourse.AutoCompleteCustomSource = coll;
            }
        }
        void AutoFillFaculty()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select Faculty from StudAttendance where AdmNo='"+txtAdm.Text+"'", db);
                db.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string sName = reader.GetString(0);
                    txtFaculty.Text = sName;
                }
                //  txtCourse.AutoCompleteCustomSource = coll;
            }
        }

        private void txtAdm_TextChanged(object sender, EventArgs e)
        {
            AutoFillStudName();
            AutoFillGender();
            AutoFillDOB();
            AutoFillFaculty();
            AutoFillCourse();
        }

        private void txtUnitCode_TextChanged(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtUnitCode, picUnitCode, lblUnitCode, "");
            AutoFillUnitName();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        { 
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtName, picName, lblStudName, "");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

        }

        private void txtUnitCode_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtUnitCode, picUnitCode, lblUnitCode, "");
        }
    }
    }

