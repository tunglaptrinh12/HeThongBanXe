using HE_THONG_BAN_XE.Connect;
using HE_THONG_BAN_XE.model;
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
        bool daSuaGiaTriKM = false;
        bool dangClearForm = false;
        private void TinhKhuyenMai_TienMat()
        {
            if (daSuaGiaTriKM)
                return;

            decimal tongKhuyenMai = 0;

            if (checkBox_dongia1ty_km.Checked)
                tongKhuyenMai += 8000000;

            if (checkBox_khmuaxe_km.Checked)
                tongKhuyenMai += 1500000;

            textBox_giatrikhuyenmai_km.Text = tongKhuyenMai.ToString("N0");
        }
        private void ClearForm()
        {
            dangClearForm = true;
            textBox_makm_km.Clear();
            textBox_tekm_km.Clear();
            textBox_giatrikhuyenmai_km.Clear();
            textBox_timkiem_khuyenmai.Clear();

            radioButton_phantram_km.Checked = false;
            radioButton_tienmat_km.Checked = false;
            radioButton_hoatdong_km.Checked = false;
            radioButton_kohoatdong_km.Checked = false;

            checkBox_2xe_km.Checked = false;
            checkBox_4lanmua_km.Checked = false;
            checkBox_dongia1ty_km.Checked = false;
            checkBox_khmuaxe_km.Checked = false;
            checkBox_tren2xe_km.Checked = false;

            dateTime_ngayad_km.Value = DateTime.Now; // hoặc giá trị mặc định
            DateTime_ngayhh_km.Value = DateTime.Now;

            textBox_makm_km.Focus();
            daSuaGiaTriKM = false;
            dangClearForm = false;
        }
        private void FormatDataGridView()
        {
            dataGridView_khuyenmai.EnableHeadersVisualStyles = false;

            dataGridView_khuyenmai.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_khuyenmai.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_khuyenmai.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 10, FontStyle.Bold);

            dataGridView_khuyenmai.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView_khuyenmai.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView_khuyenmai.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView_khuyenmai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadKhuyenmai()
        {

            using (var Context = new DBNhanVien())
            {
                var list = Context.khuyenMais.ToList();
                dataGridView_khuyenmai.DataSource = list;
                FormatDataGridView();
            }
            if (dataGridView_khuyenmai.Columns.Contains("MaKM"))
                dataGridView_khuyenmai.Columns["MaKM"].HeaderText = "Mã Khuyến Mại";
            if (dataGridView_khuyenmai.Columns.Contains("TenKM"))
                dataGridView_khuyenmai.Columns["TenKM"].HeaderText = "Tên Khuyến Mại";
            if (dataGridView_khuyenmai.Columns.Contains("LoaiKM"))
                dataGridView_khuyenmai.Columns["LoaiKM"].HeaderText = "Loại Khuyến Mại";
            if (dataGridView_khuyenmai.Columns.Contains("GiaTriKM"))
                dataGridView_khuyenmai.Columns["GiaTriKM"].HeaderText = "Giá trị khuyến mại";
            if (dataGridView_khuyenmai.Columns.Contains("DieuKien"))
                dataGridView_khuyenmai.Columns["DieuKien"].HeaderText = "Điều Kiện";
            if (dataGridView_khuyenmai.Columns.Contains("NgayBatDau"))
                dataGridView_khuyenmai.Columns["NgayBatDau"].HeaderText = "Ngày Bắt Đầu";
            if (dataGridView_khuyenmai.Columns.Contains("NgayKetThuc"))
                dataGridView_khuyenmai.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
            if (dataGridView_khuyenmai.Columns.Contains("TrangThai"))
                dataGridView_khuyenmai.Columns["TrangThai"].HeaderText = "Trạng Thái";
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
            LoadKhuyenmai();
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            daSuaGiaTriKM = true;
        }

        private void radioButton_tienmat_km_CheckedChanged(object sender, EventArgs e)
        {
            if (dangClearForm) return;
            if (radioButton_tienmat_km.Checked)
            {
                groupBox_giamtienmat.Visible = true;
                groupBox_giamphantram.Visible = false;
                checkBox_tren2xe_km.Checked = false;
                checkBox_4lanmua_km.Checked = false;
                checkBox_2xe_km.Checked = false;
            }
            daSuaGiaTriKM = false;
            TinhKhuyenMai_TienMat();
        }

        private void radioButton_phantram_km_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_phantram_km.Checked)
            {
                groupBox_giamphantram.Visible = true;
                groupBox_giamtienmat.Visible = false;
                textBox_giatrikhuyenmai_km.Text = ""; // xóa giá trị cũ

                checkBox_dongia1ty_km.Checked = false;
                checkBox_khmuaxe_km.Checked = false;
            }
        }

        private void NutShowAll_km_Click(object sender, EventArgs e)
        {
            LoadKhuyenmai();
            ClearForm();
        }

        private void NutXoa_km_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_makm_km.Text.Trim();
                var nv = context.khuyenMais.FirstOrDefault(n => n.MaKM == ma);
                if (nv != null)
                {
                    context.khuyenMais.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa khuyến mãi!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    LoadKhuyenmai();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("không tìm Thấy khuyến mãi!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void NutThem_km_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                // 1. Kiểm tra thông tin bắt buộc
                if (string.IsNullOrWhiteSpace(textBox_makm_km.Text) ||
                    string.IsNullOrWhiteSpace(textBox_tekm_km.Text) ||
                    string.IsNullOrWhiteSpace(textBox_giatrikhuyenmai_km.Text) ||
                    (!radioButton_phantram_km.Checked && !radioButton_tienmat_km.Checked))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin và chọn loại khuyến mãi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Kiểm tra ngày hết hạn
                if (DateTime_ngayhh_km.Value.Date <= dateTime_ngayad_km.Value.Date)
                {
                    MessageBox.Show("Ngày hết hạn phải sau ngày áp dụng!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Kiểm tra phải chọn ít nhất một điều kiện
                if (radioButton_tienmat_km.Checked)
                {
                    if (!checkBox_dongia1ty_km.Checked && !checkBox_khmuaxe_km.Checked)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất một điều kiện áp dụng!", "Thiếu điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (radioButton_phantram_km.Checked)
                {
                    if (!checkBox_2xe_km.Checked && !checkBox_tren2xe_km.Checked && !checkBox_4lanmua_km.Checked)
                    {
                        MessageBox.Show("Vui lòng chọn ít nhất một điều kiện cho khuyến mãi phần trăm!", "Thiếu điều kiện", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                // 4. Kiểm tra trùng mã khuyến mãi
                string maKM = textBox_makm_km.Text.Trim();
                bool maTonTai = context.khuyenMais.Any(km => km.MaKM == maKM);
                if (maTonTai)
                {
                    MessageBox.Show("Mã khuyến mãi đã tồn tại. Vui lòng nhập mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // 6. Lấy giá trị khuyến mãi
                decimal giaTri;
                if (!decimal.TryParse(textBox_giatrikhuyenmai_km.Text.Replace(",", "").Replace("%", "").Trim(), out giaTri))
                {
                    MessageBox.Show("Giá trị khuyến mãi không hợp lệ!", "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (radioButton_phantram_km.Checked)
                {
                    if (giaTri <= 0 || giaTri > 100)
                    {
                        MessageBox.Show("Giá trị phần trăm phải nằm trong khoảng 1 đến 100!", "Lỗi phần trăm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                // 7. Gộp điều kiện
                string dieuKien = "";
                if (radioButton_tienmat_km.Checked)
                {
                    if (checkBox_dongia1ty_km.Checked) dieuKien += "Giá > 1 tỷ; ";
                    if (checkBox_khmuaxe_km.Checked) dieuKien += "Khách hàng cũ; ";
                }
                else if (radioButton_phantram_km.Checked)
                {
                    if (checkBox_2xe_km.Checked) dieuKien += "Mua 2 xe; ";
                    if (checkBox_tren2xe_km.Checked) dieuKien += "Trên 2 xe; ";
                    if (checkBox_4lanmua_km.Checked) dieuKien += "Tích lũy 4 lần; ";
                }

                dieuKien = dieuKien.TrimEnd(' ', ';');
                // 9. Tạo đối tượng khuyến mãi
                var km = new KhuyenMai
                {
                    MaKM = textBox_makm_km.Text.Trim(),
                    TenKM = textBox_tekm_km.Text.Trim(),
                    LoaiKM = radioButton_tienmat_km.Checked ? "Tiền mặt" : "Phần trăm",
                    GiaTriKM = giaTri,
                    DieuKien = dieuKien,
                    NgayBatDau = dateTime_ngayad_km.Value,
                    NgayKetThuc = DateTime_ngayhh_km.Value,
                    TrangThai = radioButton_hoatdong_km.Checked ? "Hoạt động" : "Không Hoạt động",
                };

                // 10. Thêm và lưu
                context.khuyenMais.Add(km);
                context.SaveChanges();

                // 11. Thông báo
                MessageBox.Show("Đã thêm một khuyến mãi mới!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 12. Làm mới
                LoadKhuyenmai();
                FormatDataGridView();
                ClearForm();
            }

        }

        private void checkBox_dongia1ty_km_CheckedChanged(object sender, EventArgs e)
        {
            if (dangClearForm) return;
            if (radioButton_tienmat_km.Checked)
            {
                daSuaGiaTriKM = false;
                TinhKhuyenMai_TienMat();
            }
        }

        private void checkBox_khmuaxe_km_CheckedChanged(object sender, EventArgs e)
        {
            if (dangClearForm) return;
            if (radioButton_tienmat_km.Checked)
            {
                daSuaGiaTriKM = false;
                TinhKhuyenMai_TienMat();
            }
        }

        private void NutSua_km_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_makm_km.Text.Trim();

                // 1. Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(ma) ||
                    string.IsNullOrWhiteSpace(textBox_tekm_km.Text) ||
                    string.IsNullOrWhiteSpace(textBox_giatrikhuyenmai_km.Text) ||
                    (!radioButton_tienmat_km.Checked && !radioButton_phantram_km.Checked))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin khuyến mãi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DateTime_ngayhh_km.Value.Date <= dateTime_ngayad_km.Value.Date)
                {
                    MessageBox.Show("Ngày hết hạn phải sau ngày bắt đầu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 2. Kiểm tra và parse giá trị khuyến mãi
                string inputGiaTri = textBox_giatrikhuyenmai_km.Text.Trim();

                if (!decimal.TryParse(inputGiaTri, out decimal giaTriKM))
                {
                    MessageBox.Show("Giá trị khuyến mãi phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (radioButton_phantram_km.Checked)
                {
                    if (giaTriKM <= 0 || giaTriKM > 100)
                    {
                        MessageBox.Show("Giá trị phần trăm phải nằm trong khoảng 1 đến 100!", "Lỗi phần trăm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                // 3. Tìm khuyến mãi trong DB
                var km = context.khuyenMais.FirstOrDefault(k => k.MaKM == ma);
                if (km != null)
                {
                    km.TenKM = textBox_tekm_km.Text.Trim();
                    km.GiaTriKM = giaTriKM;
                    km.LoaiKM = radioButton_tienmat_km.Checked ? "Tiền mặt" : "Phần trăm";
                    km.NgayBatDau = dateTime_ngayad_km.Value;
                    km.NgayKetThuc = DateTime_ngayhh_km.Value;
                    km.TrangThai = radioButton_hoatdong_km.Checked ? "Hoạt động" : "Không Hoạt động";

                    // 4. Gộp điều kiện từ các checkbox
                    List<string> dieuKienList = new List<string>();
                    if (checkBox_dongia1ty_km.Checked) dieuKienList.Add("Giá > 1 tỷ");
                    if (checkBox_khmuaxe_km.Checked) dieuKienList.Add("Khách hàng cũ");
                    if (checkBox_2xe_km.Checked) dieuKienList.Add("Mua 2 xe");
                    if (checkBox_4lanmua_km.Checked) dieuKienList.Add("Mua 4 lần");
                    if (checkBox_tren2xe_km.Checked) dieuKienList.Add("Mua trên 2 xe");
                    km.DieuKien = string.Join(" - ", dieuKienList);

                    // 5. Lưu lại
                    context.SaveChanges();

                    MessageBox.Show("Đã sửa thông tin khuyến mãi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadKhuyenmai();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khuyến mãi có mã này để sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void dataGridView_khuyenmai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                // Gán giá trị cơ bản
                textBox_makm_km.Text = dataGridView_khuyenmai.Rows[i].Cells["MaKM"].Value.ToString();
                textBox_tekm_km.Text = dataGridView_khuyenmai.Rows[i].Cells["TenKM"].Value.ToString();

                // Gán giá trị khuyến mãi
                decimal giaTri = Convert.ToDecimal(dataGridView_khuyenmai.Rows[i].Cells["GiaTriKM"].Value);
                textBox_giatrikhuyenmai_km.Text = giaTri.ToString("N0"); // định dạng có dấu phẩy

                // Loại khuyến mãi
                string loai = dataGridView_khuyenmai.Rows[i].Cells["LoaiKM"].Value.ToString();
                if (loai == "Tiền mặt") radioButton_tienmat_km.Checked = true;
                else radioButton_phantram_km.Checked = true;

                // Trạng thái
                string trangThai = dataGridView_khuyenmai.Rows[i].Cells["TrangThai"].Value.ToString();
                if (trangThai == "Hoạt động") radioButton_hoatdong_km.Checked = true;
                else radioButton_kohoatdong_km.Checked = true;

                // Gán ngày
                dateTime_ngayad_km.Value = Convert.ToDateTime(dataGridView_khuyenmai.Rows[i].Cells["NgayBatDau"].Value);
                DateTime_ngayhh_km.Value = Convert.ToDateTime(dataGridView_khuyenmai.Rows[i].Cells["NgayKetThuc"].Value);

                // Xử lý điều kiện từ chuỗi
                string dieuKien = dataGridView_khuyenmai.Rows[i].Cells["DieuKien"].Value.ToString();

                checkBox_dongia1ty_km.Checked = dieuKien.Contains("1 tỷ");
                checkBox_khmuaxe_km.Checked = dieuKien.Contains("cũ");
                checkBox_2xe_km.Checked = dieuKien.Contains("2 xe");
                checkBox_4lanmua_km.Checked = dieuKien.Contains("4 lần");
                checkBox_tren2xe_km.Checked = dieuKien.Contains("trên 2");

                // Đánh dấu không tính lại tự động nếu đã sửa tay
                daSuaGiaTriKM = true;
            }
        }

        private void NutTimKiem_km_Click(object sender, EventArgs e)
        {
            string tuKhoa = textBox_timkiem_khuyenmai.Text.Trim();

            using (var context = new DBNhanVien())
            {
                // Nếu không nhập từ khóa, hiển thị toàn bộ danh sách
                if (string.IsNullOrEmpty(tuKhoa))
                {
                    LoadKhuyenmai();
                    return;
                }

                // Tìm theo Mã KM hoặc Tên KM có chứa từ khóa (không phân biệt hoa thường)
                var ketQua = context.khuyenMais
                    .Where(km => km.MaKM.Contains(tuKhoa) || km.TenKM.Contains(tuKhoa))
                    .ToList();

                if (ketQua.Count > 0)
                {
                    dataGridView_khuyenmai.DataSource = ketQua;
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khuyến mãi phù hợp!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_khuyenmai.DataSource = null;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
