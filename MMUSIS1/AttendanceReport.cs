using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMUSIS1
{
    class AttendanceReport
    {
        public string AdmNo { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public int year { get; set; }
        public bool Gender { get; set; }
        public string Unit { get; set; }
        public string Course { get; set; }
        public string Faculty { get; set; }
        public int Total_Attendance { get; set; }
    }
}
