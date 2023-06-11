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
    public partial class XemKetQua : Form
    {
        public XemKetQua()
        {
            InitializeComponent();
        }
        void loadtable()
        {
            if(dgv_ketqua.Rows.Count != 0 )
            {
                dgv_ketqua.DataSource = null;
                dgv_ketqua.Rows.Clear();
                dgv_ketqua.Columns.Clear();
            }
            
            dgv_ketqua.DataSource = KetQua.getKetQuaHV(UserLogin.username);
        }

        private void XemKetQua_Load(object sender, EventArgs e)
        {
            loadtable();
        }

        private void pnl_QuayVe_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
            
        }
    }
}
