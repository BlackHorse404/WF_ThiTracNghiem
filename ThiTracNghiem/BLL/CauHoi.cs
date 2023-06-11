using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.DAL;

namespace ThiTracNghiem.BLL
{
    class CauHoi
    {
        public String maCauHoi { get; set; }
        public String noiDungCauHoi { get; set; }
        public String plan_A { get; set; }
        public String plan_B { get; set; }
        public String plan_C { get; set; }
        public String plan_D { get; set; }
        public String cauTraLoi { get; set; }
        public String maChuong { get; set; }

        public CauHoi(string maCauHoi, string noiDungCauHoi, string plan_A, string plan_B, string plan_C, string plan_D, string cauTraLoi, string maChuong)
        {
            this.maCauHoi = maCauHoi;
            this.noiDungCauHoi = noiDungCauHoi;
            this.plan_A = plan_A;
            this.plan_B = plan_B;
            this.plan_C = plan_C;
            this.plan_D = plan_D;
            this.cauTraLoi = cauTraLoi;
            this.maChuong = maChuong;
        }

        public CauHoi()
        {
        }
        public static List<CauHoi> getCauHoiTheoChuong(string maCH)
        {
            DataTable dt = ConnectDB.ExecuteQuery("select * from CAUHOI where MACHUONG = '" + maCH + "'");
            int count = dt.Rows.Count;
            if (count > 0)
            {
                List<CauHoi> dsch = new List<CauHoi>();

                for (int i = 0; i < count; i++)
                {
                    dsch.Add(new CauHoi(dt.Rows[i][0].ToString(),
                            dt.Rows[i][1].ToString(),
                            dt.Rows[i][2].ToString(),
                            dt.Rows[i][3].ToString(),
                            dt.Rows[i][4].ToString(),
                            dt.Rows[i][5].ToString(),
                            dt.Rows[i][6].ToString(),
                            dt.Rows[i][7].ToString()));
                }
                return dsch;
            }
            return null;
        }
    }
}
