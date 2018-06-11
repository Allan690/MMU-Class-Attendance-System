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

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
