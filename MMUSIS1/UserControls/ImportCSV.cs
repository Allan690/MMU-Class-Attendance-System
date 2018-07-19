using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDataReader;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Threading;

namespace MMUSIS1.UserControls
{
    public partial class ImportCSV : UserControl
    {
        public ImportCSV()
        {
            InitializeComponent();
        }

        private void ImportCSV_Load(object sender, EventArgs e)
        {
           
        }
        public string MyProperty
        {
            get { return sysUser.Text; }
            set { sysUser.Text = value; }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (opn.ShowDialog() == DialogResult.Cancel)
                return;
            FileStream stream = new FileStream(opn.FileName, FileMode.Open);
            ExcelDataReader.IExcelDataReader excelreader = ExcelDataReader.ExcelReaderFactory.CreateOpenXmlReader(stream);
            // Excel.IExcelDataReader excelreader1 = Excel.ExcelReaderFactory.CreateOpenXmlReader(stream);
            // excelreader.IsFirstRowAsColumnNames = true;
            var conf = new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration
                {
                    UseHeaderRow = true
                }
            };

            DataSet dtset = excelreader.AsDataSet(conf);
            DataClasses1DataContext conn = new DataClasses1DataContext();
            foreach (DataTable table in dtset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    StudAttendance addtable = new StudAttendance()
                    {
                        StudDate = Convert.ToString(row[0]),
                        Name = Convert.ToString(row[1]),
                        AdmNo = Convert.ToString(row[3]),
                        Geolocation = Convert.ToString(row[4]),
                        Unit = Convert.ToString(row[5]),
                        Course = Convert.ToString(row[6]),
                        Faculty = Convert.ToString(row[7])

                    };
                    conn.StudAttendances.InsertOnSubmit(addtable);

                }
                conn.SubmitChanges();
                excelreader.Close();
                stream.Close();
                MetroFramework.MetroMessageBox.Show(this, "Import successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToLongDateString();
            lblTime.Text = date.ToLongTimeString();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            FieldChecker.Text = "Import Excel file of student records into system.";
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
