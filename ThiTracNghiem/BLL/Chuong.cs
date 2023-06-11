using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.DAL;

namespace ThiTracNghiem.BLL
{
    class Chuong
    {
        public String maChuong { get; set; }
        public String tenChuong { get; set; }
        public String mamh { get; set; }

        public Chuong(string maChuong, string tenChuong, string mamh)
        {
            this.maChuong = maChuong;
            this.tenChuong = tenChuong;
            this.mamh = mamh;
        }
        public static List<Chuong> getChuongTheoMonHoc (String mh)
        {
            DataTable dt = ConnectDB.ExecuteQuery("select * from CHUONG where MAMH = '" + mh + "'");
            int count = dt.Rows.Count;
            if (count > 0)
            {
                List<Chuong> dsc = new List<Chuong>();

                for(int i =0; i< count; i++ )
                {
                    dsc.Add(new Chuong(dt.Rows[i][0].ToString(),
                        dt.Rows[i][1].ToString(),
                        dt.Rows[i][2].ToString()));
                }
                return dsc;
            }
            return null;
        }
    }
}
