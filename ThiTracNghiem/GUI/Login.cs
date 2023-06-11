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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text.Trim();
            string pass = txt_pass.Text.Trim();

            UserLogin.username = user;
            UserLogin.password = pass;
            try
            {
                if (UserLogin.dangNhap())
                {
                    MessageBox.Show("Học Sinh có mã "+UserLogin.username+" đăng nhập thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ThongTinHocVien f = new ThongTinHocVien();
                    f.Show();
                    f.Owner = this;
                }
                else
                {
                    MessageBox.Show("Học Sinh có mã " + UserLogin.username + " đăng nhập thất bại !\nKiểm tra lại mật khẩu hoặc liên hệ với giáo vụ !","Thông Báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
