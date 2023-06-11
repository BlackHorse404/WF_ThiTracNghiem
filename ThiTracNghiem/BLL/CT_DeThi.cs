using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem.BLL
{
    class CT_DeThi
    {
        public string maDeThi { get; set; }
        public string maCauHoi { get; set; }

        public CT_DeThi(string maDeThi, string maCauHoi) : this(maDeThi)
        {
            this.maCauHoi = maCauHoi;
        }

        public CT_DeThi(string maCauHoi)
        {
            this.maCauHoi = maCauHoi;
        }

    }
}
