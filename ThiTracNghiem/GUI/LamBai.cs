using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiem.BLL;

namespace ThiTracNghiem.GUI
{
    public partial class LamBai : Form
    {
        public LamBai()
        {
            InitializeComponent();
        }
        string mamh = null;
        string dethi = null;
        string ketqua = null;
        int sttCH = 0;

        public LamBai(string mamh, string dethi, string ketqua)
        {
            InitializeComponent();
            this.mamh = mamh;
            this.dethi = dethi;
            this.sttCH = 1;
            this.ketqua = ketqua;
        }

        int startChuong = 0;
        int finalChuong = 0;
        int startCauHoi = 0;
        int finalCauHoi = 0;
        List<CauHoi> lstCH = new List<CauHoi>();
        List<Chuong> lstChuong = new List<Chuong>();

        String returnKQ()
        {
            string kq = null;
            if (rdo_kq1.Checked)
                kq = rdo_kq1.Text;
            else if (rdo_kq2.Checked)
                kq = rdo_kq2.Text;
            else if (rdo_kq3.Checked)
                kq = rdo_kq3.Text;
            else if (rdo_kq4.Checked)
                kq = rdo_kq4.Text;

            return kq;

        }
        bool saveKQ()
        {
            string kq = returnKQ();
            if (kq != null)
                return CT_KetQua.ThemBaiLam(ketqua, lstCH[startCauHoi].maCauHoi, kq);
            else
                return false;
        }
        void loadListChuong()
        {
            if(sttCH != 0 && mamh != null && startChuong <= finalChuong)
            {
                lstChuong = Chuong.getChuongTheoMonHoc(mamh); // danh sach chương
                finalChuong = lstChuong.Count-1;//so luong chương max
            }
        }

        List<CauHoi> loadListCauHoi(string maChuong)
        {
            List<CauHoi> lCH = CauHoi.getCauHoiTheoChuong(maChuong);
            finalCauHoi = lCH == null ? 0 : lCH.Count - 1;
            return lCH;
        }

        CauHoi loadCauHoi(int indexCH)
        {
            if(lstCH == null)
            {
                MessageBox.Show("Không có dữ liệu câu hỏi !");
                return null;
            }
            return lstCH[indexCH];
        }

        private void loadFormCauHoi(CauHoi cauhoi)
        {
            if (cauhoi == null)
            {
                return;
            }
            rdo_kq1.Checked = false;
            rdo_kq2.Checked = false;
            rdo_kq3.Checked = false;
            rdo_kq4.Checked = false;
            rdo_kq1.TabStop = false;
            rdo_kq2.TabStop = false;
            rdo_kq3.TabStop = false;
            rdo_kq4.TabStop = false;
            lbl_Cauhoi.Text = (startChuong + 1) + "." + (startCauHoi + 1) + ") " + cauhoi.noiDungCauHoi;
            rdo_kq1.Text = cauhoi.plan_A;
            rdo_kq2.Text = cauhoi.plan_B;
            rdo_kq3.Text = cauhoi.plan_C;
            rdo_kq4.Text = cauhoi.plan_D;
        }

        private void LamBai_Load(object sender, EventArgs e)
        {
            rdo_kq1.Checked = false;
            rdo_kq2.Checked = false;
            rdo_kq3.Checked = false;
            rdo_kq4.Checked = false;
            loadListChuong();
            lstCH = loadListCauHoi(lstChuong[startChuong].maChuong);
            CauHoi ch = loadCauHoi(startCauHoi);
            loadFormCauHoi(ch);
            btn_nopbai.Visible = false;
            
        }

        private void pnl_TiepTheo_MouseClick(object sender, MouseEventArgs e)
        {
            if (!saveKQ())
            {
                MessageBox.Show("Vui lòng chọn câu trả lời !", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            startCauHoi++;
            if (startCauHoi < 0)
                startCauHoi = 0;
            if (startCauHoi > finalCauHoi)
            {
                startChuong++;
                startCauHoi = 0;
                //Het chuong moi
                if (startChuong > finalChuong || startCauHoi < 0)
                {
                    startChuong = finalChuong;
                    btn_nopbai.Visible = true;
                    pnl_TiepTheo.Visible = false;
                    return;
                }
                lstCH = loadListCauHoi(lstChuong[startChuong].maChuong);
                //Qua chuong moi nhung khong co cau hoi
                if(lstCH==null || finalCauHoi == 0)
                {
                    startChuong++;
                    if (startChuong > finalChuong)
                    {
                        startChuong = finalChuong;
                        btn_nopbai.Visible = true;
                        pnl_TiepTheo.Visible = false;
                        return;
                    }
                }
                loadFormCauHoi(loadCauHoi(startCauHoi));
            }
            else
            {
                if(startCauHoi <= finalCauHoi)
                {
                    loadFormCauHoi(loadCauHoi(startCauHoi));
                }
            }
        }

        int minutes = 5;
        int seccond = 0;
        private void time_Tick(object sender, EventArgs e)
        {
            if(seccond == 0)
            {
                seccond = 59;
                minutes--;
            }
            if(seccond <= 59 && seccond > 0)
                seccond--;
            lbl_ThoiGian.Text = "Time: " + minutes.ToString("00") +":"+ seccond.ToString("00");
            if(minutes == 0 && seccond== 0)
            {
                time.Enabled = false;
                MessageBox.Show("Hết giờ làm bài !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Owner.Show();
                this.Close();
            }
        }

        private void NopBai_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void LamBai_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
