using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MMUSIS1
{
    public class Admins
    {
        public int AdminID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string Imageurl { get; set; }
    }
}
