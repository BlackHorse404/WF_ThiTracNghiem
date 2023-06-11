using ThiTracNghiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ThiTracNghiem.BLL
{
    class DeThi
    {
        public string maDeThi { get; set; }
        public string maMH { get; set; }

        public DeThi(string maDeThi, string maMH)
        {
            this.maDeThi = maDeThi;
            this.maMH = maMH;
        }

        public DeThi() { }

        public static DataTable getDeThiTheoMon(string maMon)
        {
            return ConnectDB.ExecuteQuery("select * from DETHI where MAMH = '" + maMon + "'");
        }
    }
}
