using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiTracNghiem.DAL;

namespace ThiTracNghiem.BLL
{
    class KetQua
    {
        public string idKetQua { get; set; }

        public string maDeThi { get; set; }
        public string maHV { get; set; }
        public float tongSoDiems { get; set; }

        public KetQua(string idKetQua, string maDeThi, string maHV, float tongSoDiems)
        {
            this.idKetQua = idKetQua;
            this.maDeThi = maDeThi;
            this.maHV = maHV;
            this.tongSoDiems = tongSoDiems;
        }
        public static string taoMaBaiLam()
        {
            int count = (int)ConnectDB.ExecuteScalar("Select count(*) from ketqua");
            return "KQ"+count.ToString();
        }

        private static void capNhapDiem()
        {
            DataTable t = ConnectDB.ExecuteQuery("select kq.IDKETQUA, ROUND(count(*)*0.1/(select count(*) from CAUHOI ch, CHUONG c, MonHoc mh where ch.MACHUONG = c.MACHUONG and mh.MAMH = c.MAMH group by mh.MAMH) * 100,2) as DUNG from DETHI dt, MonHoc mh, CHUONG c, CAUHOI ch, KETQUA kq, CT_KETQUA ctkq where dt.MAMH = mh.MAMH and c.MAMH = mh.MAMH and ch.MACHUONG = c.MACHUONG and kq.IDKETQUA = ctkq.IDKETQUA and kq.MADETHI = dt.MADETHI and ctkq.MACAUHOI = ch.MACAUHOI and CAU_TRALOI = CAUTRALOI group by kq.IDKETQUA ");

            for(int i = 0; i < t.Rows.Count; i++)
            {
                ConnectDB.ExecuteNonQuery("update KETQUA set TONGSODIEM = "+float.Parse(t.Rows[i][1].ToString()).ToString("00.00")+" where IDKETQUA = '"+t.Rows[i][0].ToString()+"'");
            }
        }


        public static bool ThemBaiLam(string id,string mahv, string dethi)
        {
            try
            {
                string strSQL = String.Format("insert into ketqua values('{0}','{1}','{2}',0)", id, dethi, mahv);
                int kq = ConnectDB.ExecuteNonQuery(strSQL);
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
        public static DataTable getKetQuaHV(string maHV)
        {
            capNhapDiem();
            DataTable t = ConnectDB.ExecuteQuery("select b.TENMH, c.* from DETHI a, MonHoc b, KETQUA c where a.MAMH = b.MAMH and c.MADETHI = a.MADETHI and MAHV = '" + maHV + "'");
            
            return t;
        }
    }
}
