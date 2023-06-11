using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.DAL;

namespace ThiTracNghiem.BLL
{
    class CT_KetQua
    {
        public string idKetQua { get; set; }
        public string maCauHoi { get; set; }
        public string cauTraLoi { get; set; }

        public CT_KetQua(string idKetQua, string maCauHoi, string cauTraLoi)
        {
            this.idKetQua = idKetQua;
            this.maCauHoi = maCauHoi;
            this.cauTraLoi = cauTraLoi;
        }
        public static bool ThemBaiLam(string id, string cauhoi, string cautl)
        {
            try
            {
                int kq = ConnectDB.ExecuteNonQuery(String.Format("insert into ct_ketqua values('{0}','{1}',N'{2}')", id, cauhoi, cautl));
                if (kq >= 1)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
            }
            return false;
        }
    }
}
