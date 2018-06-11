using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

namespace MMUSIS1
{
    public partial class ImportExcel : MetroFramework.Forms.MetroForm
    {


        public ImportExcel()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
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
                            Faculty =Convert.ToString(row[7])

                        };
                        conn.StudAttendances.InsertOnSubmit(addtable);

                    }
                    conn.SubmitChanges();
                    excelreader.Close();
                    stream.Close();
                    MetroFramework.MetroMessageBox.Show(this, "Import successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            

            
            }

        private void ImportExcel_Load(object sender, EventArgs e)
        {

        }
    }
    }

