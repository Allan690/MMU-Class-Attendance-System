﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace MMUSIS1.UserControls
{
    public partial class btnClearForm : UserControl
    {
        EntityStateStud objstud = EntityStateStud.Unchanged;
        public btnClearForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddStudUC_Load(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                studentsBindingSource.DataSource = db.Query<Students>("Select * from Students", commandType: CommandType.Text);
                pContainer.Enabled = false;

            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picStudImage.Image = Image.FromFile(ofd.FileName);
                    Students obj = studentsBindingSource.Current as Students;
                    if (obj != null)
                    {
                        obj.Imageurl = ofd.FileName;
                    }
                }
            }
        }
        void ClearAll()
        {
            txtAdmNo.Text = txtCourse.Text = txtName.Text =txtYear.Text = txtSearch.Text="";

            picStudImage.Image = pictureBox2.Image = pictureBox3.Image = pictureBox4.Image = pictureBox5.Image=pictureBox6.Image= null;
            lblAdmNo.Text = lblCourse.Text = lblDOB.Text = lblName.Text = lblYear.Text="";
            metroCheckBox1.Checked = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objstud = EntityStateStud.Added;
            picStudImage.Image = null;
            pContainer.Enabled = true;
            studentsBindingSource.Add(new Students());
            studentsBindingSource.MoveLast();
            txtAdmNo.Focus();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            objstud = EntityStateStud.Changed;
            pContainer.Enabled = true;
            txtAdmNo.Focus();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Students obj = studentsBindingSource.Current as Students;
                if (obj != null)
                {
                    if (!string.IsNullOrEmpty(obj.Imageurl))
                    {
                        picStudImage.Image = Image.FromFile(obj.Imageurl);
                    }
                }

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                objstud = EntityStateStud.Deleted;
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        Students stud = studentsBindingSource.Current as Students;
                        if (stud != null)
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("Delete from Students where StudID = @StudID", new { StudID = stud.StudID }, commandType: CommandType.Text);

                            if (result != 0)
                            {
                                studentsBindingSource.RemoveCurrent();
                                pContainer.Enabled = false;
                                objstud = EntityStateStud.Unchanged;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                studentsBindingSource.EndEdit();
                Students stud = studentsBindingSource.Current as Students;
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {

                    if (stud != null)
                    {
                        if (db.State == ConnectionState.Closed)
                            db.Open();
                        if (objstud == EntityStateStud.Added)
                        {
                            DynamicParameters p = new DynamicParameters();
                            p.Add("@StudID", dbType: DbType.Int32, direction: ParameterDirection.Output);
                            p.AddDynamicParams(new { AdmNo = stud.AdmNo, FullName = stud.FullName, DOB = stud.DOB, Gender = stud.Gender, Course = stud.Course, Year = stud.Year, Imageurl=stud.Imageurl });
                            db.Execute("StudInsert", p, commandType: CommandType.StoredProcedure);
                            stud.StudID = p.Get<int>("@StudID");
                            MetroFramework.MetroMessageBox.Show(this, "Student was successfully added.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else if (objstud == EntityStateStud.Changed)
                    {
                        db.Execute("UpdateUnits", new { StudID=stud.StudID,AdmNo = stud.AdmNo, FullName = stud.FullName, DOB = stud.DOB, Gender = stud.Gender, Course = stud.Course, Year = stud.Year, Imageurl=stud.Imageurl}, commandType: CommandType.StoredProcedure);
                    }
                    metroGrid1.Refresh();
                    pContainer.Enabled = false;
                    objstud = EntityStateStud.Unchanged;
                }
            }
            catch(Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAdmNo_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Admission Number text field modified";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Student name text field modified";
        }

        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Year of birth text field modified";
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Course text field modified";
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Year of study text field modified";
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            FieldChecker.Text = "Gender field modified";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
        }

        private void metroCheckBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(metroCheckBox1.CheckState==CheckState.Checked)
            {
                metroCheckBox1.Text = "Female";
            }
            else if (metroCheckBox1.CheckState == CheckState.Unchecked)
            {
                metroCheckBox1.Text = "Male";
            }
            else
            {
                metroCheckBox1.Text = "Female";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
