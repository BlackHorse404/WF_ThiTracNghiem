using ThiTracNghiem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem.BLL
{
    class UserLogin
    {
        public static string username { get; set; }
        public static string password { get; set; }

        private static bool checkLogin(string username, string password)
        {
            if (username == password)
            {
                int kq = int.Parse(ConnectDB.ExecuteScalar("select count(*) from HOCVIEN where MAHV = '" + username + "'").ToString());
                return kq != 0 ? true : false;
            }
            return false;
        }

        public static bool dangNhap()
        {
            return checkLogin(username, password);
        }
    }
}
