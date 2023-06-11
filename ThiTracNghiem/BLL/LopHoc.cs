using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem.BLL
{
    class LopHoc
    {
        public string maLop { get; set; }
        public string tenLop { get; set; }

        public LopHoc() { }

        public LopHoc(string maLop, string tenLop)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
        }
    }
}
