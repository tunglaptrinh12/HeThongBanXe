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
    public partial class XeControl : UserControl
    {
        public XeControl()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            textBox_maxe_xe.Clear();
            textBox_tenxe_xe.Clear();
            textBox_hangxe_xe.Clear();
            textBox_bienso_xe.Clear();
            textBox_mausac_xe.Clear();
            textBox_soghe_xe.Clear();
            textBox_giaban_xe.Clear();

            radioButton_chuaban_xe.Checked = false;
            radioButton_daban_xe.Checked = false;
            radioButton_cu_xe.Checked = false;
            radioButton_moi_xe.Checked = false;

            checkBox_sedan_xe.Checked = false;
            checkBox_supercar_xe.Checked = false;
            checkBox_suv_xe.Checked = false;
            checkBox_trusk_xe.Checked = false;
            checkBox_van_xe.Checked = false;

            dateTimePicker_namsanxuat_xe.Value = DateTime.Now; // hoặc giá trị mặc định

            textBox_maxe_xe.Focus(); // trỏ chuột về ô mã nhân viên
        }
        private void LoadXe()
        {

            using (var Context = new DBNhanVien())
            {
                var list = Context.xes.ToList();
                dataGridView_xe.DataSource = list;
                FormatDataGridView();
            }
            if (dataGridView_xe.Columns.Contains("MaXe"))
            {
                dataGridView_xe.Columns["MaXe"].HeaderText = "Mã Xe";
                dataGridView_xe.Columns["MaXe"].Width = 60;
            }
            if (dataGridView_xe.Columns.Contains("TenXe"))
            {
                dataGridView_xe.Columns["TenXe"].HeaderText = "Tên Xe";
                dataGridView_xe.Columns["TenXe"].Width = 95;
            }
            if (dataGridView_xe.Columns.Contains("HangXe"))
            {
                dataGridView_xe.Columns["HangXe"].HeaderText = "Hãng Xe";
                dataGridView_xe.Columns["HangXe"].Width = 80;
            }
            if (dataGridView_xe.Columns.Contains("LoaiXe"))
            {
                dataGridView_xe.Columns["LoaiXe"].HeaderText = "Loại Xe";
                dataGridView_xe.Columns["LoaiXe"].Width = 70;
            }
            if (dataGridView_xe.Columns.Contains("MauSac"))
            {
                dataGridView_xe.Columns["MauSac"].HeaderText = "Màu Sắc";
                dataGridView_xe.Columns["MauSac"].Width = 70;
            }
            if (dataGridView_xe.Columns.Contains("SoChoNgoi"))
            {
                dataGridView_xe.Columns["SoChoNgoi"].HeaderText = "Số Chỗ";
                dataGridView_xe.Columns["SoChoNgoi"].Width = 60;
            }
            if (dataGridView_xe.Columns.Contains("NamSanXuat"))
            {
                dataGridView_xe.Columns["NamSanXuat"].HeaderText = "Năm Sản Xuất";
                dataGridView_xe.Columns["NamSanXuat"].Width = 70;
            }
            if (dataGridView_xe.Columns.Contains("BienSo"))
            {
                dataGridView_xe.Columns["BienSo"].HeaderText = "Biển Số";
                dataGridView_xe.Columns["BienSo"].Width = 95;
            }
            if (dataGridView_xe.Columns.Contains("MoiCu"))
            {
                dataGridView_xe.Columns["MoiCu"].HeaderText = "Tình Trạng";
                dataGridView_xe.Columns["MoiCu"].Width = 80;
            }
            if (dataGridView_xe.Columns.Contains("GiaBan"))
            {
                dataGridView_xe.Columns["GiaBan"].HeaderText = "Giá Bán";
                dataGridView_xe.Columns["GiaBan"].Width = 90;
            }
            if (dataGridView_xe.Columns.Contains("TrangThai"))
            {
                dataGridView_xe.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dataGridView_xe.Columns["TrangThai"].Width = 80;
            }
            if (dataGridView_xe.Columns.Contains("ChiTietHoaDons"))
            {
                dataGridView_xe.Columns["ChiTietHoaDons"].HeaderText = "Hóa Đơn";
                dataGridView_xe.Columns["ChiTietHoaDons"].Width = 80;

            }
        }
        private void FormatDataGridView()
        {
            dataGridView_xe.EnableHeadersVisualStyles = false;

            dataGridView_xe.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_xe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_xe.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 10, FontStyle.Bold);

            dataGridView_xe.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView_xe.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView_xe.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView_xe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button_them_xe_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                // không để trống tên mã số điện thoại nhân viên
                if (string.IsNullOrWhiteSpace(textBox_maxe_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_tenxe_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_bienso_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_giaban_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_hangxe_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_mausac_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_soghe_xe.Text))
                {
                    MessageBox.Show("Vui lòng Nhập đủ thông tin xe", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string maXE = textBox_maxe_xe.Text.Trim();
                // kiểm tra mã xe tồn tại chưa
                bool maXEExists = context.xes.Any(mx => mx.MaXe == maXE);
                if (maXEExists)
                {
                    MessageBox.Show("Mã xe đã tồn tại. Vui lòng nhập mã khác!",
                        "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var xe = new Xe
                {
                    MaXe = textBox_maxe_xe.Text.Trim(),
                    TenXe = textBox_tenxe_xe.Text.Trim(),
                    HangXe = textBox_hangxe_xe.Text.Trim(),
                    BienSo = textBox_bienso_xe.Text.Trim(),
                    MauSac = textBox_mausac_xe.Text.Trim(),
                    SoChoNgoi = int.Parse(textBox_soghe_xe.Text.Trim()),
                    GiaBan = decimal.Parse(textBox_giaban_xe.Text.Trim()),
                    NamSanXuat = dateTimePicker_namsanxuat_xe.Value,
                    LoaiXe = (checkBox_sedan_xe.Checked ? "sedan" : "")
                     + (checkBox_supercar_xe.Checked ? "supercar" : "")
                     + (checkBox_suv_xe.Checked ? "suv" : "")
                     + (checkBox_trusk_xe.Checked ? "trusk" : "")
                     + (checkBox_van_xe.Checked ? "van" : ""),
                    MoiCu = radioButton_cu_xe.Checked ? "mới" : "cũ",
                    TrangThai = radioButton_daban_xe.Checked ? "đã bán" : "chưa bán",
                };
                context.xes.Add(xe);
                context.SaveChanges();
                MessageBox.Show("Đã Thêm Một xe!", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadXe();
                FormatDataGridView();
                ClearForm();
            }
        }
        private void XeControl_Load(object sender, EventArgs e)
        {
            LoadXe();
        }

        private void button_tatca_xe_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                var data = context.xes.ToList(); // Lấy tất cả nhân viên
                dataGridView_xe.DataSource = data;
                ClearForm();
            }
        }

        private void radioButton_daban_xe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_chuaban_xe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_sua_xe_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_maxe_xe.Text.Trim();

                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(ma) ||
                    string.IsNullOrWhiteSpace(textBox_tenxe_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_bienso_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_giaban_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_hangxe_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_mausac_xe.Text) ||
                    string.IsNullOrWhiteSpace(textBox_soghe_xe.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin xe!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                if (!int.TryParse(textBox_soghe_xe.Text.Trim(), out int soCho))
                {
                    MessageBox.Show("Số chỗ ngồi phải là số nguyên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textBox_giaban_xe.Text.Trim(), out decimal giaBan))
                {
                    MessageBox.Show("Giá bán phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var xe = context.xes.FirstOrDefault(x => x.MaXe == ma);
                if (xe != null)
                {
                    xe.TenXe = textBox_tenxe_xe.Text.Trim();
                    xe.HangXe = textBox_hangxe_xe.Text.Trim();
                    xe.BienSo = textBox_bienso_xe.Text.Trim();
                    xe.MauSac = textBox_mausac_xe.Text.Trim();
                    xe.SoChoNgoi = soCho;
                    xe.GiaBan = giaBan;
                    xe.NamSanXuat = dateTimePicker_namsanxuat_xe.Value;

                    // Gộp loại xe từ checkbox
                    List<string> loaiXeList = new List<string>();
                    if (checkBox_sedan_xe.Checked) loaiXeList.Add("sedan");
                    if (checkBox_supercar_xe.Checked) loaiXeList.Add("supercar");
                    if (checkBox_suv_xe.Checked) loaiXeList.Add("suv");
                    if (checkBox_trusk_xe.Checked) loaiXeList.Add("trusk");
                    if (checkBox_van_xe.Checked) loaiXeList.Add("van");
                    xe.LoaiXe = string.Join(" - ", loaiXeList);

                    xe.MoiCu = radioButton_moi_xe.Checked ? "mới" : "cũ";
                    xe.TrangThai = radioButton_daban_xe.Checked ? "đã bán" : "chưa bán";

                    context.SaveChanges();

                    MessageBox.Show("Đã sửa thông tin xe!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadXe();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe có mã này để sửa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void dataGridView_xe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBox_maxe_xe.Text = dataGridView_xe.Rows[i].Cells["MaXe"].Value.ToString();
                textBox_tenxe_xe.Text = dataGridView_xe.Rows[i].Cells["TenXe"].Value.ToString();
                textBox_hangxe_xe.Text = dataGridView_xe.Rows[i].Cells["HangXe"].Value.ToString();
                textBox_bienso_xe.Text = dataGridView_xe.Rows[i].Cells["BienSo"].Value.ToString();
                textBox_mausac_xe.Text = dataGridView_xe.Rows[i].Cells["MauSac"].Value.ToString();
                textBox_soghe_xe.Text = dataGridView_xe.Rows[i].Cells["SoChoNgoi"].Value.ToString();
                textBox_giaban_xe.Text = dataGridView_xe.Rows[i].Cells["GiaBan"].Value.ToString();

                string loaixe = dataGridView_xe.Rows[i].Cells["LoaiXe"].Value.ToString();
                checkBox_sedan_xe.Checked = loaixe.Contains("sedan");
                checkBox_supercar_xe.Checked = loaixe.Contains("supercar");
                checkBox_suv_xe.Checked = loaixe.Contains("suv");
                checkBox_trusk_xe.Checked = loaixe.Contains("trusk");
                checkBox_van_xe.Checked = loaixe.Contains("van");

                string moicu = dataGridView_xe.Rows[i].Cells["MoiCu"].Value.ToString();
                if (moicu == "mới") radioButton_moi_xe.Checked = true;
                else radioButton_cu_xe.Checked = true;

                string trangthai = dataGridView_xe.Rows[i].Cells["TrangThai"].Value.ToString();
                if (trangthai == "đã bán") radioButton_daban_xe.Checked = true;
                else radioButton_chuaban_xe.Checked = true;
            }
        }

        private void button_xoa_xe_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_maxe_xe.Text.Trim();
                var nv = context.xes.FirstOrDefault(n => n.MaXe == ma);
                if (nv != null)
                {
                    context.xes.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa xe!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    LoadXe();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("không tìm Thấy xe!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void button_timkiem_xe_Click(object sender, EventArgs e)
        {
            //Sửa lại tìm kiếm(không cần nhập mã xe để tìm xe)
            using (var context = new DBNhanVien())
            {
                // Lấy dữ liệu bắt buộc
                string ten = textBox_tenxe_xe.Text.Trim();
                string soCho = textBox_soghe_xe.Text.Trim();
                string giaBan = textBox_giaban_xe.Text.Trim();

                // Kiểm tra bắt buộc
                if (string.IsNullOrWhiteSpace(ten) ||
                    string.IsNullOrWhiteSpace(soCho) ||
                    string.IsNullOrWhiteSpace(giaBan))
                {
                    MessageBox.Show("Vui lòng nhập đủ: Tên xe, Số chỗ ngồi, Giá bán!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra ít nhất một checkbox loại xe
                List<string> loaiXeList = new List<string>();
                if (checkBox_trusk_xe.Checked) loaiXeList.Add("TRUSK");
                if (checkBox_van_xe.Checked) loaiXeList.Add("VAN");
                if (checkBox_suv_xe.Checked) loaiXeList.Add("SUV");
                if (checkBox_sedan_xe.Checked) loaiXeList.Add("SEDAN");
                if (checkBox_supercar_xe.Checked) loaiXeList.Add("SUPERCAR");

                if (loaiXeList.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn ít nhất một Loại xe!", "Thiếu thông tin",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Bắt đầu truy vấn
                var query = context.xes.AsQueryable();

                query = query.Where(x => x.TenXe.Contains(ten));

                if (int.TryParse(soCho, out int soChoInt))
                    query = query.Where(x => x.SoChoNgoi == soChoInt);
                else
                {
                    MessageBox.Show("Số chỗ ngồi không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (decimal.TryParse(giaBan, out decimal giaNhap))
                {
                    decimal tu = giaNhap - 500000;
                    decimal den = giaNhap + 500000;
                    query = query.Where(x => x.GiaBan >= tu && x.GiaBan <= den);
                }
                else
                {
                    MessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lọc theo loại xe (chứa bất kỳ trong danh sách)
                query = query.Where(x => loaiXeList.Any(loai => x.LoaiXe.ToLower().Contains(loai.ToLower())));

                // --- Không bắt buộc ---
                string hang = textBox_hangxe_xe.Text.Trim();
                string mau = textBox_mausac_xe.Text.Trim();
                string bienSo = textBox_bienso_xe.Text.Trim();
                string ma = textBox_maxe_xe.Text.Trim();

                if (string.IsNullOrEmpty(ma))
                    query = query.Where(x => x.MaXe.Contains(ma));
                if (!string.IsNullOrWhiteSpace(hang))
                    query = query.Where(x => x.HangXe.Contains(hang));

                if (!string.IsNullOrWhiteSpace(mau))
                    query = query.Where(x => x.MauSac.Contains(mau));

                if (!string.IsNullOrWhiteSpace(bienSo))
                    query = query.Where(x => x.BienSo.Contains(bienSo));

                // Tình trạng mới/cũ
                if (radioButton_moi_xe.Checked)
                    query = query.Where(x => x.MoiCu.ToLower().Contains("mới"));
                else if (radioButton_cu_xe.Checked)
                    query = query.Where(x => x.MoiCu.ToLower().Contains("cũ"));

                // Trạng thái đã bán / chưa bán
                if (radioButton_daban_xe.Checked)
                    query = query.Where(x => x.TrangThai.ToLower().Contains("đã bán"));
                else if (radioButton_chuaban_xe.Checked)
                    query = query.Where(x => x.TrangThai.ToLower().Contains("chưa bán"));

                // Năm sản xuất
                int selectedYear = dateTimePicker_namsanxuat_xe.Value.Year;
                int currentYear = DateTime.Now.Year;
                if (selectedYear != currentYear)
                {
                    query = query.Where(x => x.NamSanXuat.Year == selectedYear);
                }

                // Kết quả
                var ketQua = query.ToList();
                dataGridView_xe.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy xe phù hợp!", "Kết quả",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_daban_xe_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                var danhSachDaBan = context.xes
                    .Where(x => x.TrangThai.ToLower().Contains("đã bán"))
                    .ToList();

                dataGridView_xe.DataSource = danhSachDaBan;

                if (danhSachDaBan.Count == 0)
                {
                    MessageBox.Show("Không có xe nào đã bán!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_chuaban_xe_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                var danhSachChuaBan = context.xes
                    .Where(x => x.TrangThai.ToLower().Contains("chưa bán"))
                    .ToList();

                dataGridView_xe.DataSource = danhSachChuaBan;

                if (danhSachChuaBan.Count == 0)
                {
                    MessageBox.Show("Không có xe nào chưa bán!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
