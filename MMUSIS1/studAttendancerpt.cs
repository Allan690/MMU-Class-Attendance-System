using Dapper;
using System;
using iTextSharp;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace MMUSIS1
{
    public partial class studAttendancerpt : MetroFramework.Forms.MetroForm
    {
        public studAttendancerpt()
        {
            InitializeComponent();
           // double x = str;
        }

        private void studAttendancerpt_Load(object sender, EventArgs e)
        {
           
            txtUnit.Visible = false;
            txtTotal.Visible = false;
            txtGender.Visible = false;
            txtFaculty.Visible = false;
            txtCourse.Visible = false;
            txtDOB.Visible = false;
           

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select s.AdmNo, t.FullName, s.Unit, s.Course, s.Faculty, t.DOB, t.[Year],t.Gender from StudAttendance s inner join Students t on s.AdmNo=t.AdmNo";
                attendanceReportBindingSource.DataSource = db.Query<Students>(query, commandType: CommandType.Text);
                // pContainer.Enabled = false;
            }
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select s.AdmNo, t.FullName, s.Unit, s.Course, s.Faculty, t.DOB, t.[Year],t.Gender,count(s.AdmNo) AS Total_Attendance from StudAttendance s inner join Students t on s.AdmNo=t.AdmNo where StudDate >= '" + dtFrom.Value.ToString() + "' and StudDate <= '" + dtTo.Value.ToString() + "' and s.AdmNo = '" + txtAdm.Text.ToString() + "'GROUP BY s.AdmNo, t.FullName, s.Unit, s.Course, s.Faculty, t.DOB, t.[Year],t.Gender";
                attendanceReportBindingSource.DataSource = db.Query<AttendanceReport>(query, commandType: CommandType.Text);
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

       
        Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
        //HowManyLessons ls = new HowManyLessons();

        private void metroButton2_Click(object sender, EventArgs e)
        {
          
            try
            {
                SaveFileDialog SavePdfDialog = new SaveFileDialog();
                Stream stream;
                SavePdfDialog.Filter = "PDF File (*.pdf)|*.pdf|All files(*.*)|*.*";
                SavePdfDialog.FilterIndex = 1;
                SavePdfDialog.RestoreDirectory = true;
                SavePdfDialog.FileName = txtName.Text;

                if (SavePdfDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = SavePdfDialog.OpenFile()) != null)

                    {
                        PdfWriter wri = PdfWriter.GetInstance(doc, stream);
                        DateTime dt = DateTime.Now;
                        
                        doc.Open(); //Open document to write
                        //HowManyLessons ls = new HowManyLessons();
                       // ls.ShowDialog();
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(@"C:\Users\FRED\Documents\Visual Studio 2015\WebSites\Testing\Image\mmu1.jpeg");
                        img.ScalePercent(50f);
                        img.IndentationLeft = 150f;

                        img.SetAbsolutePosition(doc.PageSize.Width - 500f - 72f, doc.PageSize.Height - -80f - 216.6f);
                        doc.Add(img);
                        //Write some content                      
                        Paragraph par = new Paragraph("MULTIMEDIA UNIVERSITY OF KENYA.", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 18f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE));
                        Paragraph par5 = new Paragraph("P.O. Box 15653 - 00503, Mbagathi, Nairobi Tel: +254 020 2071391, +254 020 724257083, + 254 020 735900008", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE));
                        Paragraph par6 = new Paragraph("Fax: +254 020 2071243 Email: info@mmu.ac.ke Leader in Innovative Technology", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLUE));
                        Paragraph par7 = new Paragraph("\n MMU CLASS ATTENDANCE REPORT\n\n", new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14f, iTextSharp.text.Font.BOLDITALIC, iTextSharp.text.BaseColor.BLACK));
                        Paragraph par1 = new Paragraph("Name: " + txtName.Text + "\n Admission Number: " + txtAdm.Text);
                        Paragraph par3 = new Paragraph("\n\n\n");
                        Paragraph par4 = new Paragraph("\n\n");

                        //Adding a table to the document
                        PdfPTable table = new PdfPTable(2);
                        PdfPCell cell = new PdfPCell(new Phrase("CLASS ATTENDANCE REPORT FOR:" + txtAdm.Text));
                        cell.Colspan = 2;
                        cell.HorizontalAlignment = 1;
                        table.AddCell(cell);

                        table.AddCell("Name:");
                        table.AddCell(txtName.Text);
                        table.AddCell("Admission Number:");
                        table.AddCell(txtAdm.Text);
                        table.AddCell("Gender:");
                        table.AddCell(txtGender.Text);
                        table.AddCell("Date Of Birth:");
                        table.AddCell(txtDOB.Text);
                        table.AddCell("Course:");
                        table.AddCell(txtCourse.Text);
                        table.AddCell("Faculty:");
                        table.AddCell(txtFaculty.Text);
                        table.AddCell("Unit Name:");
                        table.AddCell(txtUnit.Text);
                        table.AddCell("Total Attendance:");
                        table.AddCell(txtTotal.Text);
                        table.AddCell("From Date:");
                        table.AddCell(dtFrom.Value.ToString());
                        table.AddCell("To Date:");
                        table.AddCell(dtTo.Value.ToString());

                        
                        Paragraph par2 = new Paragraph("\n\n\nSignature .....................");


                        //iTextSharp.text.Image img1 = iTextSharp.text.Image.GetInstance(txtName.Text + ".jpg");
                        //img1.ScalePercent(40f);
                        //img1.SetAbsolutePosition(doc.PageSize.Width - 50f - 72f, doc.PageSize.Height - 36f - 216.6f);
                        //doc.Add(img1);
                        par.IndentationLeft = 200f;
                        par1.IndentationLeft = 150f;
                        par2.IndentationLeft = 420f;
                        par5.IndentationLeft = 150f;
                        par6.IndentationLeft = 150f;
                        par7.IndentationLeft = 150f;


                        // Now add the above created text using different class object to our pdf document
                        doc.Add(par);

                        doc.Add(par5);
                        doc.Add(par6);
                        doc.Add(par4);
                        doc.Add(par7);
                        doc.Add(par1);
                        doc.Add(par3);
                        doc.Add(table);
                       
                        doc.Add(par2);
                        
                        Paragraph ph= new Paragraph(doc.BottomMargin, "\n\n\nMultimedia University Class Attendance System \u00a9 2018 " + dt);
                        ph.IndentationLeft = 130f;
                       
                        doc.Add(ph);
                        
                        doc.Close();//close the document
                        wri.Close();
                        stream.Close();
                        System.Diagnostics.Process.Start(SavePdfDialog.FileName);
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
         public void attendance(double str)
        {
            //MessageBox.Show(str);
            double x=str;
            //int.TryParse(str, out x);
               
            int y;
            int.TryParse(txtTotal.Text, out y);
            if ((x / y) * 100.0 > 67)
            {
                doc.Open();
                Paragraph ph3=new Paragraph( "Student has attended " + (x / y) * 100.0 + "% of classes. Student can proceed to process exam card");
                doc.Add(ph3);
                doc.Close();
            }
            else if ((x / y) * 100.0 < 67)
            {
                doc.Open();
               Paragraph ph4 = new Paragraph("Student has attended " + (x / y) * 100.0 + "% of classes. Student is yet to reach threshold.");
                doc.Add(ph4);
                doc.Close();
            }
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
                txtTotal.Text = row.Cells[7].Value.ToString();

            }
        }
    }
}