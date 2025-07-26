using HE_THONG_BAN_XE.Connect;
using HE_THONG_BAN_XE.FormHeThong;
using HE_THONG_BAN_XE.model;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HE_THONG_BAN_XE.ControlHeThong
{
    public partial class BanHangControl : UserControl
    {
        public BanHangControl()
        {
            InitializeComponent();
        }
        List<ChiTietHoaDon> danhSachXeTrongHD = new List<ChiTietHoaDon>();
        private void CapNhatThanhTien()
        {
            decimal tongTien = danhSachXeTrongHD.Sum(x => x.DonGia);
            decimal thanhTien = tongTien;
            int soLuongXe = danhSachXeTrongHD.Count;
            int soLanMua = 0;

            string maKH = comboBox_makh_bh.SelectedValue?.ToString() ?? "";

            using (var context = new DBNhanVien())
            {
                if (!string.IsNullOrEmpty(maKH))
                {
                    soLanMua = context.hoaDons.Count(h => h.MaKH == maKH);
                }

                if (comboBox_makm_bh.SelectedValue != null)
                {
                    string maKM = comboBox_makm_bh.SelectedValue.ToString();
                    var km = context.khuyenMais.FirstOrDefault(k => k.MaKM == maKM);
                    if (km != null)
                    {
                        if (DieuKienApDung(km.DieuKien, tongTien, soLuongXe, soLanMua))
                        {
                            string loaiKM = km.LoaiKM.ToLower();
                            decimal giaTriKM = km.GiaTriKM;

                            if (loaiKM.Contains("phần trăm"))
                                thanhTien = tongTien - (tongTien * giaTriKM / 100);
                            else if (loaiKM.Contains("tiền mặt"))
                                thanhTien = tongTien - giaTriKM;
                        }
                        else
                        {
                            // Không đủ điều kiện
                            MessageBox.Show("Không đủ điều kiện áp dụng khuyến mãi này.");
                            comboBox_makm_bh.SelectedIndex = -1;
                        }
                    }
                }
            }

            label_dongia_bh.Text = tongTien.ToString("N0") + " VND";
            label_thanhtien_bh.Text = thanhTien.ToString("N0") + " VND";
        }

        public static class MaTuSinh
        {
            private static Random random = new Random();

            public static string GenerateMaCTHD()
            {
                using (var context = new DBNhanVien())
                {
                    string ma;
                    do
                    {
                        ma = "CTHD" + random.Next(10000, 99999); // Ví dụ: CTHD12345
                    }
                    while (context.chiTietHoaDons.Any(x => x.MaCTHD == ma));

                    return ma;
                }
            }
        }
        private bool DieuKienApDung(string? dieuKien, decimal tongTien, int soLuongXe, int soLanMua)
        {
            if (string.IsNullOrWhiteSpace(dieuKien))
                return false;

            dieuKien = dieuKien.ToLower();

            // Điều kiện: Giá > X
            if ((dieuKien.Contains("giá") || dieuKien.Contains("Đơn giá")) && dieuKien.Contains(">"))
            {
                try
                {
                    string[] parts = dieuKien.Split('>');
                    if (parts.Length == 2)
                    {
                        string rawValue = parts[1].ToLower().Trim();

                        decimal giaCanSoSanh = 0;

                        if (rawValue.Contains("tỷ"))
                        {
                            rawValue = rawValue.Replace("tỷ", "").Trim();
                            if (decimal.TryParse(rawValue, out decimal so))
                            {
                                giaCanSoSanh = so * 1_000_000_000;
                            }
                        }
                        else if (rawValue.Contains("triệu"))
                        {
                            rawValue = rawValue.Replace("triệu", "").Trim();
                            if (decimal.TryParse(rawValue, out decimal so))
                            {
                                giaCanSoSanh = so * 1_000_000;
                            }
                        }
                        else
                        {
                            // giá trị không có đơn vị => parse trực tiếp
                            decimal.TryParse(rawValue.Replace(",", "").Replace(".", ""), out giaCanSoSanh);
                        }

                        return tongTien > giaCanSoSanh;
                    }
                }
                catch
                {
                    return false;
                }
            }

            // Điều kiện: Mua trên X lần
            if (dieuKien.Contains("mua trên") && dieuKien.Contains("lần"))
            {
                var match = Regex.Match(dieuKien, @"\d+");
                if (match.Success && int.TryParse(match.Value, out int sl))
                    return soLanMua > sl;
            }

            // Điều kiện: Mua từ X xe trở lên
            if (dieuKien.Contains("mua") && dieuKien.Contains("xe"))
            {
                var match = Regex.Match(dieuKien, @"\d+");
                if (match.Success && int.TryParse(match.Value, out int sl))
                    return soLuongXe >= sl;
            }

            return false;
        }
        private void TinhTongTienVaKhuyenMai()
        {
            decimal tongTien = danhSachXeTrongHD.Sum(x => x.DonGia);
            int soLuongXe = danhSachXeTrongHD.Count;

            string maKH = comboBox_makh_bh.SelectedValue?.ToString() ?? "";
            int soLanMua = 0;

            using (var db = new DBNhanVien())
            {
                if (!string.IsNullOrEmpty(maKH))
                {
                    soLanMua = db.hoaDons.Count(hd => hd.MaKH == maKH);
                }

                DateTime ngayLap = dateTimePicker_ngaylaphd_bh.Value;
                var danhSachKhuyenMai = db.khuyenMais
                    .Where(km => km.TrangThai == "Hoạt động")
                    .ToList();

                var kmApDung = danhSachKhuyenMai
                    .FirstOrDefault(km =>
                        km.NgayBatDau <= ngayLap &&
                        km.NgayKetThuc >= ngayLap &&
                        DieuKienApDung(km.DieuKien, tongTien, soLuongXe, soLanMua));

                decimal thanhTien = tongTien;

                if (kmApDung != null)
                {
                    if (kmApDung.LoaiKM.ToLower().Contains("phần trăm"))
                    {
                        thanhTien = tongTien - (tongTien * (kmApDung.GiaTriKM / 100));
                    }
                    else if (kmApDung.LoaiKM.ToLower().Contains("tiền mặt"))
                    {
                        thanhTien = tongTien - kmApDung.GiaTriKM;
                    }

                    comboBox_makm_bh.SelectedValue = kmApDung.MaKM;
                    label_giatrikm_bh.Text = kmApDung.LoaiKM.ToLower().Contains("phần trăm")
                        ? $"{kmApDung.GiaTriKM}%"
                        : $"{kmApDung.GiaTriKM:N0} VND";
                }
                else
                {
                    comboBox_makm_bh.SelectedIndex = -1;
                    label_giatrikm_bh.Text = "0";
                }

                label_dongia_bh.Text = $"{tongTien:N0} VND";
                label_thanhtien_bh.Text = $"{thanhTien:N0} VND";
            }
        }
        private void ClearForm()
        {
            textBox_mahd_bh.Clear();
            label_macode_bh.Text = "";
            label_thanhtien_bh.Text = "";
            label_dongia_bh.Text = "";
            danhSachXeTrongHD.Clear();
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

            using (var context = new DBNhanVien())
            {
                var list = context.hoaDons
                    .Include(h => h.KhachHang)
                    .Include(h => h.ChiTietHoaDons)
                    .Select(h => new
                    {
                        MaHD = h.MaHD,
                        MaKH = h.MaKH,
                        SoLuong = h.SoLuong,
                        NgayLapHD = h.NgaylapHD,
                        ThanhTien = h.ThanhTien,
                        KhachHang = h.KhachHang != null ? h.KhachHang.TenKH : "",
                        ChiTietHoaDon = string.Join(", ", h.ChiTietHoaDons.Select(ct => ct.MaCTHD))
                    })
                    .ToList();

                dataGridView_hoadon_bh.DataSource = list;
                FormatDataGridView();
            }
            if (dataGridView_hoadon_bh.Columns.Contains("MaHD"))
            {
                dataGridView_hoadon_bh.Columns["MaHD"].HeaderText = "Mã Hóa Đơn";
            }
            if (dataGridView_hoadon_bh.Columns.Contains("MaKH"))
            {
                dataGridView_hoadon_bh.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            }
            if (dataGridView_hoadon_bh.Columns.Contains("SoLuong"))
            {
                dataGridView_hoadon_bh.Columns["SoLuong"].HeaderText = "Số Lượng";
            }
            if (dataGridView_hoadon_bh.Columns.Contains("NgayLapHD"))
            {
                dataGridView_hoadon_bh.Columns["NgayLapHD"].HeaderText = "Ngày Lập Hóa Đơn";
            }
            if (dataGridView_hoadon_bh.Columns.Contains("ThanhTien"))
            {
                dataGridView_hoadon_bh.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            }
            if (dataGridView_hoadon_bh.Columns.Contains("KhachHang"))
            {
                dataGridView_hoadon_bh.Columns["KhachHang"].HeaderText = "Khách Hàng";
            }
            if (dataGridView_hoadon_bh.Columns.Contains("ChiTietHoaDons"))
            {
                dataGridView_hoadon_bh.Columns["ChiTietHoaDons"].HeaderText = "Chi Tiết Hóa Đơn";
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

        private void button_taohoadon_bh_Click(object sender, EventArgs e)
        {
            using (var db = new DBNhanVien())
            {
                // Kiểm tra dữ liệu đầu vào
                if (comboBox_makh_bh.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn khách hàng.");
                    return;
                }
                if (comboBox_maxe_bh.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn xe cần bán.");
                    return;
                }
                if (danhSachXeTrongHD.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một xe.");
                    return;
                }

                // Tạo mã hóa đơn và mã chi tiết hóa đơn
                string maCTHD = MaTuSinh.GenerateMaCTHD();
                label_macode_bh.Text = maCTHD;

                // Lấy thông tin cơ bản
                string maKH = comboBox_makh_bh.SelectedValue.ToString();
                DateTime ngayLap = dateTimePicker_ngaylaphd_bh.Value;
                string maHD = textBox_mahd_bh.Text;

                decimal tongTien = danhSachXeTrongHD.Sum(x => x.DonGia);
                int soLuongXe = danhSachXeTrongHD.Count;

                int soLanMua = db.hoaDons.Count(hd => hd.MaKH == maKH);

                // Xác định khuyến mãi phù hợp
                var danhSachKM = db.khuyenMais.ToList();
                KhuyenMai? khuyenMaiApDung = danhSachKM
                    .FirstOrDefault(km => DieuKienApDung(km.DieuKien, tongTien, soLuongXe, soLanMua));

                decimal tongGiaTriKhuyenMai = 0;

                // Lấy thông tin khách hàng
                var khachHang = db.khachHangs.FirstOrDefault(kh => kh.MaKH == maKH);
                if (khachHang == null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng.");
                    return;
                }

                // Tạo hóa đơn trước và thêm chi tiết sau
                var hoaDon = new HoaDon
                {
                    MaHD = maHD,
                    MaKH = maKH,
                    SoLuong = soLuongXe,
                    NgaylapHD = ngayLap,
                    ThanhTien = 0, // sẽ tính sau khi thêm chi tiết
                    KhachHang = khachHang,
                    ChiTietHoaDons = new List<ChiTietHoaDon>()
                };

                foreach (var xe in danhSachXeTrongHD)
                {
                    decimal donGia = xe.DonGia;
                    decimal giaTriKhuyenMai = 0;
                    decimal thanhTien = donGia;

                    if (khuyenMaiApDung != null)
                    {
                        if (khuyenMaiApDung.LoaiKM.ToLower().Contains("phần trăm"))
                        {
                            giaTriKhuyenMai = donGia * (khuyenMaiApDung.GiaTriKM) / 100;
                        }
                        else
                        {
                            giaTriKhuyenMai = khuyenMaiApDung.GiaTriKM;
                        }

                        thanhTien -= giaTriKhuyenMai;
                        tongGiaTriKhuyenMai += giaTriKhuyenMai;
                    }
                    var xeTrongDb = db.xes.FirstOrDefault(x => x.MaXe == xe.MaXe);
                    if (xeTrongDb != null)
                    {
                        xeTrongDb.TrangThai = "đã bán";
                        db.Entry(xeTrongDb).State = EntityState.Modified;
                    }

                    var cthd = new ChiTietHoaDon
                    {
                        MaCTHD = MaTuSinh.GenerateMaCTHD(),
                        MaHD = maHD,
                        MaKH = maKH,
                        MaXe = xe.MaXe,
                        DonGia = donGia,
                        GiaTriKhuyenMai = giaTriKhuyenMai,
                        MaKM = khuyenMaiApDung?.MaKM,
                        NgayLayHD = ngayLap,
                        ThanhTien = thanhTien
                    };

                    hoaDon.ChiTietHoaDons.Add(cthd);  // Gán chi tiết vào hóa đơn
                    //db.chiTietHoaDons.Add(cthd);      // Và thêm riêng để lưu
                }

                hoaDon.ThanhTien = tongTien - tongGiaTriKhuyenMai;

                db.hoaDons.Add(hoaDon);
                db.SaveChanges();

                MessageBox.Show("Tạo hóa đơn thành công!");
                ClearForm();
                LoadHoaDon();
            }
        }

        private void button_themxe_bh_Click(object sender, EventArgs e)
        {
            var maXe = comboBox_maxe_bh.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maXe)) return;

            if (danhSachXeTrongHD.Any(x => x.MaXe == maXe))
            {
                MessageBox.Show("Xe này đã được thêm rồi.");
                return;
            }

            using (var db = new DBNhanVien())
            {
                var xe = db.xes.FirstOrDefault(x => x.MaXe == maXe);
                if (xe != null)
                {
                    danhSachXeTrongHD.Add(new ChiTietHoaDon
                    {
                        MaXe = xe.MaXe,
                        DonGia = xe.GiaBan
                    });

                    TinhTongTienVaKhuyenMai();
                }
            }
        }

        private void comboBox_makh_bh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_maxe_bh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var maXe = comboBox_maxe_bh.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(maXe)) return;

            using (var db = new DBNhanVien())
            {
                var xe = db.xes.FirstOrDefault(x => x.MaXe == maXe);
                if (xe != null)
                {
                    label_dongia_bh.Text = xe.GiaBan.ToString("N0") + " VND";
                }
            }
        }

        private void dataGridView_hoadon_bh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_all_bh_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }

        private void button_chitiethoadon_bh_Click(object sender, EventArgs e)
        {
            ChiTietHoaDonForm chiTietHoaDonForm = new ChiTietHoaDonForm();
            chiTietHoaDonForm.ShowDialog();
        }

        private void button_timkiem_bh_Click(object sender, EventArgs e)
        {
            string maHD = textBox_mahd_bh.Text.Trim();

            if (string.IsNullOrEmpty(maHD))
            {
                MessageBox.Show("Vui lòng nhập mã hóa đơn cần tìm.");
                return;
            }

            using (var db = new DBNhanVien())
            {
                // Tìm hóa đơn theo mã
                var hoaDon = db.hoaDons
                    .Include(hd => hd.KhachHang)
                    .Include(hd => hd.ChiTietHoaDons)
                    .FirstOrDefault(hd => hd.MaHD == maHD);

                if (hoaDon == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.");
                    return;
                }

                // Hiển thị lên DataGridView
                var ketQua = hoaDon.ChiTietHoaDons.Select(cthd => new
                {
                    MaCTHD = cthd.MaCTHD,
                    MaHD = cthd.MaHD,
                    MaXe = cthd.MaXe,
                    DonGia = cthd.DonGia,
                    KhuyenMai = cthd.GiaTriKhuyenMai,
                    ThanhTien = cthd.ThanhTien,
                    NgayLap = cthd.NgayLayHD
                }).ToList();

                dataGridView_hoadon_bh.DataSource = ketQua;
            }
        }
    }
}
