using Dapper;
using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMUSIS1
{
    public partial class Thresholdreportall : Form
    {
        public Thresholdreportall()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Threshold Report For " + txtCourse.Text;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                string dtFrom = dtFromDate.Value.ToString();
                string dtTo = dtToDate.Value.ToString();
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where StudDate >= '" + dtFrom + "' and StudDate <= '" + dtTo + "' and b.AdmNo='" + txtAdmNo.Text + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";
                string query1 = "Select b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course from StudAttendance b inner join Students c ON b.AdmNo=c.AdmNo where StudDate >= '" + dtFrom + "' and StudDate <= '" + dtTo + "' group by b.AdmNo, c.FullName, b.StudDate, b.Unit, b.Faculty, b.Course";
                if (txtAdmNo.Text != "")
                {
                    attendanceReportBindingSource.DataSource = db.Query<AttendanceReport>(query, commandType: CommandType.Text);
                }
                else
                {
                    attendanceReportBindingSource.DataSource = db.Query<AttendanceReport>(query1, commandType: CommandType.Text);
                }


            }
        }

        private void Thresholdreportall_Load(object sender, EventArgs e)
        {

        }
    }
}
