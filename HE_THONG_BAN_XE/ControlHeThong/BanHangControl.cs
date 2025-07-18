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
    public partial class BanHangControl : UserControl
    {
        public BanHangControl()
        {
            InitializeComponent();
        }
        private void LoadComboBoxMaXe()
        {
            using (var context = new DbContextXe())
            {
                var danhSachXe = context.Xes.ToList();

                cbMaXe.DataSource = danhSachXe;
                cbMaXe.DisplayMember = "MaXe";   // Hiển thị mã xe
                cbMaXe.ValueMember = "MaXe";     // Giá trị là mã xe (có thể đổi sang TenXe nếu muốn)

                cbMaXe.SelectedIndex = -1; // Không chọn sẵn xe nào
            }
        }

        public static class MaTuSinh
        {
            private static Random random = new Random();

            public static string GenerateMaCTHD(int length = 8)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                return new string(Enumerable.Repeat(chars, length)
                                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
        }
        private void BanHangControl_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
