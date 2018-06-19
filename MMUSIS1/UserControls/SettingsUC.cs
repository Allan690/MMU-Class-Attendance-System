using System;
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
    public partial class SettingsUC : UserControl
    {
        int UserID = 0;
        public SettingsUC()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    Admins obj = adminsBindingSource.Current as Admins;
                    if (obj != null)
                    {
                      obj.Imageurl = ofd.FileName;
                        
                    }
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admins obj = adminsBindingSource.Current as Admins;
        
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                 if (db.State == ConnectionState.Closed)
                    db.Open();
                db.Execute("UpdateAdmin", new {AdminID =obj.AdminID, Password =obj.password, Imageurl= obj.Imageurl, UserName =obj.userName}, commandType: CommandType.StoredProcedure);
                UpdateSuccess up = new UpdateSuccess();
                up.ShowDialog();
            }
        }

        private void SettingsUC_Load(object sender, EventArgs e)
        {
            txtOldUser.Enabled = txtPass1.Enabled= false;
            
            metroGrid1.Visible = false;
            //metroTextBox1.Visible=false;
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                adminsBindingSource.DataSource = db.Query<Admins>("Select * from Admins", commandType: CommandType.Text);
             //   pContainer.Enabled = false;

            }
        }

        private void txtPass1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserID", UserID);
                param.Add("@UserName", txtuserName.Text.Trim());
                param.Add("@Password", txtpassWord.Text.Trim());
                
                db.Execute("UserAdd", param, commandType: CommandType.StoredProcedure);
                db.Close();
                UpdateSuccess up = new UpdateSuccess();
                up.ShowDialog();
                txtuserName.Text = txtpassWord.Text = null;
             //   filldatagridview();
               // metroGrid1.Visible = true;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@UserName", txtResetPassword.Text.Trim());
               
                db.Execute("ResetPassword", param, commandType: CommandType.StoredProcedure);
                db.Close();
                UpdateSuccess up = new UpdateSuccess();
                up.ShowDialog();
                txtuserName.Text = txtpassWord.Text = null;
              
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
