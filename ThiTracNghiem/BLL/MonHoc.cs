using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.DAL;

namespace ThiTracNghiem.BLL
{
    class MonHoc
    {
        public string maMH { get; set; }
        public string tenMH { get; set; }
        public string ghiChu { get; set; }

        public MonHoc(string maMH, string tenMH, string ghiChu)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.ghiChu = ghiChu;
        }

        public MonHoc() { }

        public static DataTable getMonHocTheoLop(string maLop)
        {
            return ConnectDB.ExecuteQuery("select a.*, b.TENMH from LOP_MONHOC a, MonHoc b WHERE MALOP = '" + maLop + "' and a.MAMH = b.MAMH");
        }
    }
}
