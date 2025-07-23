using HE_THONG_BAN_XE.Connect;
using System.Data;

namespace HE_THONG_BAN_XE.ControlHeThong
{
    public partial class BanHangControl : UserControl
    {
        public BanHangControl()
        {
            InitializeComponent();
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
        private void ClearForm()
        {
            textBox_mahd_bh.Clear();
            label_macode_bh.Text = "";
            label_thanhtien_bh.Text = "";
            label_dongia_bh.Text = "";
            if (comboBox_maxe_bh.SelectedIndex != -1)
            {
                comboBox_maxe_bh.SelectedIndex = -1;
            }
            if (comboBox_makh_bh.SelectedIndex != -1)
            {
                comboBox_makh_bh.SelectedIndex = -1;
            }
            if (comboBox_makm_bh.SelectedIndex != -1)
            {
                comboBox_makm_bh.SelectedIndex = -1;
            }
            dateTimePicker_ngaylaphd_bh.Value = DateTime.Now; // hoặc giá trị mặc định

            textBox_mahd_bh.Focus(); // trỏ chuột về ô mã nhân viên
        }
        private void FormatDataGridView()
        {
            dataGridView_hoadon_bh.EnableHeadersVisualStyles = false;

            dataGridView_hoadon_bh.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_hoadon_bh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_hoadon_bh.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView_hoadon_bh.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView_hoadon_bh.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView_hoadon_bh.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView_hoadon_bh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadHoaDon()
        {

            using (var Context = new DBNhanVien())
            {
                var list = Context.hoaDons.ToList();
                dataGridView_hoadon_bh.DataSource = list;
                FormatDataGridView();
            }
            if (dataGridView_hoadon_bh.Columns.Contains("MaHD"))
            {
                dataGridView_hoadon_bh.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 60;
            }
            if (dataGridView_hoadon_bh.Columns.Contains("MaKH"))
            {
                dataGridView_hoadon_bh.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 60;
            }
            if (dataGridView_hoadon_bh.Columns.Contains("SoLuong"))
            {
                dataGridView_hoadon_bh.Columns["SoLuong"].HeaderText = "Số Lượng";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 80;
            }
            if (dataGridView_hoadon_bh.Columns.Contains("NgayLapHD"))
            {
                dataGridView_hoadon_bh.Columns["NgayLapHD"].HeaderText = "Ngày Lập Hóa Đơn";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 150;
            }
            if (dataGridView_hoadon_bh.Columns.Contains("ThanhTien"))
            {
                dataGridView_hoadon_bh.Columns["ThanhTien"].HeaderText = "Thành Tiền";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 120;
            }
            if (dataGridView_hoadon_bh.Columns.Contains("KhachHang"))
            {
                dataGridView_hoadon_bh.Columns["KhachHang"].HeaderText = "Khách Hàng";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 160;
            }
            if (dataGridView_hoadon_bh.Columns.Contains("ChiTietHoaDons"))
            {
                dataGridView_hoadon_bh.Columns["ChiTietHoaDons"].HeaderText = "Chi Tiết Hóa Đơn";
                dataGridView_hoadon_bh.Columns["MaHD"].Width = 160;
            }
        }
        private void BanHangControl_Load(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                // 1. Load mã khách hàng
                var khlist = context.khachHangs
                    .Select(x => new
                    {
                        MaKH = x.MaKH,
                        TenHienThi = x.MaKH + " - " + x.TenKH
                    }).ToList();
                comboBox_makh_bh.DataSource = khlist;
                comboBox_makh_bh.DisplayMember = "TenHienThi";
                comboBox_makh_bh.ValueMember = "MaKH";
                comboBox_makh_bh.SelectedIndex = -1;

                // 2. Load mã xe
                var xeList = context.xes
                    .Where(x => x.TrangThai == "Chưa bán")
                    .Select(x => new
                    {
                        MaXe = x.MaXe,
                        TenHienThi = x.MaXe + " - " + x.TenXe
                    }).ToList();

                comboBox_maxe_bh.DataSource = xeList;
                comboBox_maxe_bh.DisplayMember = "TenHienThi";
                comboBox_maxe_bh.ValueMember = "MaXe";
                comboBox_maxe_bh.SelectedIndex = -1;


                // 3. Load mã khuyến mãi
                var kmList = context.khuyenMais
                        .Select(km => new
                        {
                            MaKM = km.MaKM,
                            TenHienThi = km.MaKM + " - Giảm " + km.DieuKien
                        }).ToList();
                comboBox_makm_bh.DataSource = kmList;
                comboBox_makm_bh.DisplayMember = "TenHienThi";
                comboBox_makm_bh.ValueMember = "MaKM";
                comboBox_makm_bh.SelectedIndex = -1;
            }
            LoadHoaDon();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button_lammoi_bh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
