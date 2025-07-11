using HE_THONG_BAN_XE.Connect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE_THONG_BAN_XE.ControlHeThong
{
    public partial class KhachHangKhuyenMaiControl : UserControl
    {
        public KhachHangKhuyenMaiControl()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            txtMaKM.Clear();
            txtMaHoaDon.Clear();
            txtGTKM.Clear();
            txtGhiChu.Clear();
            txtMaKH.Clear();
            DateTimeNgayAD.Value = DateTime.Now;
            txtMaKM.Focus();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void KhachHangKhuyenMaiControl_Load(object sender, EventArgs e)
        {

        }
    }
}
