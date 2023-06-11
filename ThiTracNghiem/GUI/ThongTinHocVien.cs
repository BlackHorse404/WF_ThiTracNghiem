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
    public partial class ThongTinHocVien : Form
    {
        public ThongTinHocVien()
        {
            InitializeComponent();
        }

        string maLop = "";
        HocVien hv = HocVien.getHocVienByMaHV(UserLogin.username);
        private void ThongTinHocVien_Load(object sender, EventArgs e)
        {
            
            txtMaHV.Text = hv.maHV;
            txtHoTen.Text = hv.tenHV;
            txtDiaChi.Text = hv.DiaChi;
            txtLop.Text = hv.Lop.tenLop;
            maLop = hv.Lop.maLop;
            txtGioiTinh.Text = hv.Phai;
            txtSDT.Text = hv.SDT;
            loadComboBoxMonThi();
            cbMonThi.SelectedIndex = 0;
            loadComboBoxDeThi();
        }

        private void loadComboBoxMonThi()
        {
            if(maLop.Length != 0)
            {
                cbMonThi.DataSource = null;
                cbMonThi.Items.Clear();

                cbMonThi.DataSource = MonHoc.getMonHocTheoLop(maLop);
                cbMonThi.DisplayMember = "TENMH";
                cbMonThi.ValueMember = "MAMH";
            }
        }

        private void loadComboBoxDeThi()
        {
            if (cbMonThi.Items.Count != 0)
            {
                cbDeThi.DataSource = null;
                cbDeThi.Items.Clear();

                cbDeThi.DataSource = DeThi.getDeThiTheoMon(cbMonThi.SelectedValue.ToString());
                cbDeThi.DisplayMember = "MADETHI";
                cbDeThi.ValueMember = "MADETHI";
            }
        }

        private void cbMonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMonThi.Items.Count != 0)
            {
                loadComboBoxDeThi();
            }    
        }

        private void btnLamBai_Click(object sender, EventArgs e)
        {
            this.Hide();
            String t = KetQua.taoMaBaiLam();
            if (KetQua.ThemBaiLam(t, hv.maHV, cbDeThi.SelectedValue.ToString()))
            {
                LamBai lm = new LamBai(cbMonThi.SelectedValue.ToString(), cbDeThi.SelectedValue.ToString(), t);
                lm.Show();
                lm.Owner = this;
            }
            else
            {
                MessageBox.Show("Khong the tao bai thi");
            }
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            this.Hide();
            XemKetQua ketQua= new XemKetQua();
            ketQua.Show();
            ketQua.Owner = this;
        }

        private void ThongTinHocVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
    }
}
