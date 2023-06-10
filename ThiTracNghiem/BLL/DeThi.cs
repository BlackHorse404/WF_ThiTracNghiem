using QLShopThoiTrang.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem.BLL
{
    class DeThi
    {
        public string maDe { get; set; }
        public string tenDe { get; set; }

        public DeThi() { }

        public DataTable getAllDeThi() {
            return ConnectDB.ExecuteQuery("select * from DETHI");
        }
    }
}
    