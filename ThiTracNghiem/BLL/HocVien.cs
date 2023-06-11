using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.DAL;

namespace ThiTracNghiem.BLL
{
    class HocVien
    {
        public string maHV { get; set; }
        public string tenHV { get; set; }

        public string Phai { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public LopHoc Lop { get; set; }

        public HocVien(string maHV, string tenHV, string phai, string sdt ,string MaLop, string DiaChi, string tenLop)
        {
            this.maHV = maHV;
            this.tenHV = tenHV;
            Phai = phai;
            SDT = sdt;
            Lop = new LopHoc(MaLop, tenLop);
            this.DiaChi = DiaChi;
        }

        public static HocVien getHocVienByMaHV(string maHV)
        {
            DataTable t = ConnectDB.ExecuteQuery("select a.*, b.TENLOP from HOCVIEN a, LOPHOC b where a.MALOP = b.MALOP and MAHV = '" + maHV + "'");
            if(t.Rows.Count != 0)
                return new HocVien(
                    t.Rows[0][0].ToString(),
                    t.Rows[0][1].ToString() + " "+t.Rows[0][2].ToString(),
                    t.Rows[0][3].ToString(),
                    t.Rows[0][4].ToString(),
                    t.Rows[0][5].ToString(),
                    t.Rows[0][6].ToString(),
                    t.Rows[0][7].ToString()
                    );
            return null;
        }
    }
}
