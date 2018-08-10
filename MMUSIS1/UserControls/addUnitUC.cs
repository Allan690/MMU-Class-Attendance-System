using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Text.RegularExpressions;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;
using MetroFramework.Controls;
using MetroFramework;
using DGVPrinterHelper;
using System.Drawing;
using System.Threading;

namespace MMUSIS1.UserControls
{
    public partial class addUnitUC : UserControl
    {
        EntityStateUnits obj = EntityStateUnits.Unchanged;
        public addUnitUC()
        {
           // sysUser.Text ="The Current User is: "+ _str;
            InitializeComponent();
        }
        void ClearAll()
        {
            txtUnitName.Text = txtUnitCode.Text = txtCourse.Text = txtSearch.Text="";

            picCourse.Image = picUnitCode.Image =picSearch.Image= picUnitName.Image = null;
            lblCourse.Text = lblUnitCode.Text = lblSearch1.Text= lblUnitName.Text = "";

        }


        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUnitName_Click(object sender, EventArgs e)
        {

        }

        private void picCourse_Click(object sender, EventArgs e)
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
        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
        }
        private void addUnitUC_Load(object sender, EventArgs e)
        {
            autocompleteCourse();
            try
            {

                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    unitsBindingSource.DataSource = db.Query<Units>("Select * from Units", commandType: CommandType.Text);
                    pContainer.Enabled = false;

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        
        void autocompleteCourse()
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
                txtCourse.AutoCompleteCustomSource = coll;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearAll();
            obj = EntityStateUnits.Added;
            pContainer.Enabled = true;
            unitsBindingSource.Add(new Units());
            unitsBindingSource.MoveLast();
            txtUnitCode.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCourse_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            obj = EntityStateUnits.Changed;
            pContainer.Enabled = true;
            txtUnitCode.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pContainer.Enabled = false;
            unitsBindingSource.ResetBindings(false);
            ClearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                correctForm frm = new correctForm();
                obj = EntityStateUnits.Deleted;
                if (MetroFramework.MetroMessageBox.Show(this, "Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                        Units un = unitsBindingSource.Current as Units;
                        if (un != null)
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            int result = db.Execute("Delete from Units where UnitID = @unitid", new { UnitID = un.UnitID }, commandType: CommandType.Text);
                           
                            frm.ShowDialog();
                            if (result != 0)
                            {
                                unitsBindingSource.RemoveCurrent();
                                pContainer.Enabled = false;
                                obj = EntityStateUnits.Unchanged;
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
       
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {                
                unitsBindingSource.EndEdit();
                Units un = unitsBindingSource.Current as Units;
                    using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                    {
                      
                        if (un != null)
                        {
                            if (db.State == ConnectionState.Closed)
                                db.Open();
                            if (obj == EntityStateUnits.Added)
                            {
                                DynamicParameters p = new DynamicParameters();
                                p.Add("@unitid", dbType: DbType.Int32, direction: ParameterDirection.Output);
                                p.AddDynamicParams(new { UnitCode = un.UnitCode, UnitName = un.UnitName, Course = un.Course });
                                db.Execute("AddUnits", p, commandType: CommandType.StoredProcedure);
                            un.UnitID = p.Get<int>("@unitid");
                            MetroFramework.MetroMessageBox.Show(this, "Unit was successfully added.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                            
                      }
                        else if (obj == EntityStateUnits.Changed)
                        {
                            db.Execute("UpdateUnits", new { UnitID =un.UnitID, UnitCode = un.UnitCode, UnitName = un.UnitName, Course = un.Course }, commandType:CommandType.StoredProcedure);
                        }
                         metroGrid1.Refresh();
                        pContainer.Enabled = false;
                        obj = EntityStateUnits.Unchanged;
                    }
                }
            
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void unitsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pContainer_Paint(object sender, PaintEventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
        }

        private void txtUnitCode_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtUnitCode, picUnitCode, lblUnitCode, "");
            for(int i=0; i<metroGrid1.Rows.Count-1;i++)
            {
                for(int j = 0; j < metroGrid1.Columns.Count; j++)
                {
                    if (metroGrid1.Rows[i].Cells[j].Value != null && txtUnitCode.Text == metroGrid1.Rows[i].Cells[j].Value.ToString())
                    {
                        errorForm frm = new errorForm();
                        frm.ShowDialog();
                       // unitsBindingSource.RemoveCurrent(); 
                        break;
                    }
                }
            }
        }

        private void txtCourse_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtCourse, picCourse, lblCourse, "");
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtSearch, picSearch, lblSearch1, "");
        }

        private void txtUnitName_Leave(object sender, EventArgs e)
        {
            regexp(@"^(\s|\S)*(\S)+(\s|\S)*$", txtUnitName, picUnitName, lblUnitName, "");
        }
        void verify()
        {
            if (lblUnitCode.Text == "Invalid" || lblUnitName.Text == "Invalid" || lblCourse.Text == "Invalid")
            {
                MetroMessageBox.Show(this, "Cannot submit null fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSave.Enabled = false;
                
            }
            else
            {
                btnSave.Enabled = true;
            }

        }

        private void metroGrid1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pContainer_Leave(object sender, EventArgs e)
        {
           // verify();
        }

        private void pContainer_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Units On Offer";
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
    }
}



































































