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
    public partial class KhachHangControl : UserControl
    {
        public KhachHangControl()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void ClearForm()
        {
            textBox_maKh_khachhang.Clear();
            textBox_tenKH_khachhang.Clear();
            textBox_sdt_khachhang.Clear();
            textBox_email_khachhang.Clear();
            textBox_diachi_khachhang.Clear();
            textBox_timkiem_khachhang.Clear();

            radioButton_nam_khachhang.Checked = false;
            radioButton_nu_khachhang.Checked = false;
            dateTimePicker_ngaysinh_khachhang.Value = DateTime.Now; // hoặc giá trị mặc định

            textBox_maKh_khachhang.Focus(); // trỏ chuột về ô mã nhân viên
        }
        private void LoadKhachHang()
        {

            using (var Context = new DBNhanVien())
            {
                var list = Context.khachHangs.ToList();
                dataGridView_khachhang.DataSource = list;
                FormatDataGridView();
            }
            if (dataGridView_khachhang.Columns.Contains("MaKH"))
                dataGridView_khachhang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            if (dataGridView_khachhang.Columns.Contains("TenKH"))
                dataGridView_khachhang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            if (dataGridView_khachhang.Columns.Contains("NgaySinh"))
                dataGridView_khachhang.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            if (dataGridView_khachhang.Columns.Contains("GioiTinh"))
                dataGridView_khachhang.Columns["GioiTinh"].HeaderText = "Giới Tính";
            if (dataGridView_khachhang.Columns.Contains("DiaChi"))
                dataGridView_khachhang.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            if (dataGridView_khachhang.Columns.Contains("SoDienThoai"))
                dataGridView_khachhang.Columns["SDT"].HeaderText = "Số Điện Thoại";
            if (dataGridView_khachhang.Columns.Contains("HoaDons"))
                dataGridView_khachhang.Columns["HoaDons"].HeaderText = "Hóa Đơn";
            if (dataGridView_khachhang.Columns.Contains("DanhSachKhuyenMai"))
                dataGridView_khachhang.Columns["DanhSachKhuyenMai"].HeaderText = "Khuyến Mãi";
        }
        private void FormatDataGridView()
        {
            dataGridView_khachhang.EnableHeadersVisualStyles = false;

            dataGridView_khachhang.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_khachhang.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_khachhang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView_khachhang.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView_khachhang.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView_khachhang.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // Hàm đổi nhiều tên cột dựa trên Dictionary
        private void DoiTenNhieuCot(DataGridView dgv, Dictionary<string, string> danhSachTenCot)
        {
            foreach (var cot in danhSachTenCot)
            {
                if (dgv.Columns.Contains(cot.Key))
                {
                    dgv.Columns[cot.Key].HeaderText = cot.Value;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBox_maKh_khachhang.Text = dataGridView_khachhang.Rows[i].Cells["MaKH"].Value.ToString();
                textBox_tenKH_khachhang.Text = dataGridView_khachhang.Rows[i].Cells["TenKH"].Value.ToString();
                string gioiTinh = dataGridView_khachhang.Rows[i].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam") radioButton_nam_khachhang.Checked = true; else radioButton_nu_khachhang.Checked = true;
                dateTimePicker_ngaysinh_khachhang.Value = Convert.ToDateTime(dataGridView_khachhang.Rows[i].Cells["NgaySinh"].Value);
                textBox_sdt_khachhang.Text = dataGridView_khachhang.Rows[i].Cells["SDT"].Value.ToString();
                textBox_email_khachhang.Text = dataGridView_khachhang.Rows[i].Cells["Email"].Value.ToString();
                textBox_diachi_khachhang.Text = dataGridView_khachhang.Rows[i].Cells["DiaChi"].Value.ToString();
            }
        }

        private void button_them_khachhang_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                // không để trống tên mã số điện thoại 
                if (string.IsNullOrWhiteSpace(textBox_maKh_khachhang.Text) ||
                    string.IsNullOrWhiteSpace(textBox_tenKH_khachhang.Text) ||
                            string.IsNullOrWhiteSpace(textBox_sdt_khachhang.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã,tên,số điện thoại khách hàng!", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                string email = textBox_email_khachhang.Text.Trim();

                if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
                {
                    MessageBox.Show("Email không đúng định dạng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_email_khachhang.Focus();
                    return;
                }
                string maKH = textBox_maKh_khachhang.Text.Trim();
                // kiểm tra khách Hàng tồn tại chưa
                bool maKHExists = context.khachHangs.Any(nv => nv.MaKH == maKH);
                if (maKHExists)
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại. Vui lòng nhập mã khác!",
                        "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                var kh = new KhachHang
                {
                    MaKH = textBox_maKh_khachhang.Text.Trim(),
                    TenKH = textBox_tenKH_khachhang.Text.Trim(),
                    GioiTinh = radioButton_nam_khachhang.Checked ? "Nam" : "Nữ",
                    NgaySinh = dateTimePicker_ngaysinh_khachhang.Value,
                    SDT = textBox_sdt_khachhang.Text.Trim(),
                    Email = textBox_email_khachhang.Text,
                    DiaChi = textBox_diachi_khachhang.Text.Trim()
                };
                context.khachHangs.Add(kh);
                context.SaveChanges();
                MessageBox.Show("Đã Thêm Một khách hàng!", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadKhachHang();
                FormatDataGridView();
                ClearForm();
            }

        }

        private void button_tatca_khachhang_Click(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void button_sua_khachhang_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_maKh_khachhang.Text.Trim();
                // không được bỏ trống tên mã số điện thoại 
                if (string.IsNullOrWhiteSpace(textBox_maKh_khachhang.Text) ||
                    string.IsNullOrWhiteSpace(textBox_tenKH_khachhang.Text) ||
                            string.IsNullOrWhiteSpace(textBox_sdt_khachhang.Text))
                {
                    MessageBox.Show("Vui lòng nhập thông tin khách hàng!", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var kh = context.khachHangs.FirstOrDefault(n => n.MaKH == ma);
                if (kh != null)
                {
                    kh.TenKH = textBox_tenKH_khachhang.Text.Trim();
                    kh.GioiTinh = radioButton_nam_khachhang.Checked ? "Nam" : "Nữ";
                    kh.NgaySinh = dateTimePicker_ngaysinh_khachhang.Value;
                    kh.SDT = textBox_sdt_khachhang.Text.Trim();
                    kh.Email = textBox_email_khachhang.Text.Trim();
                    kh.DiaChi = textBox_diachi_khachhang.Text.Trim();
                    context.SaveChanges();
                    MessageBox.Show("đã sửa khách hàng", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKhachHang();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("không tìm thấy khách hàng!",
                        "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void button_xoa_khachhang_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_maKh_khachhang.Text.Trim();
                var kh = context.khachHangs.FirstOrDefault(n => n.MaKH == ma);
                if (kh != null)
                {
                    context.khachHangs.Remove(kh);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa khách hàng!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    LoadKhachHang();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("không tìm Thấy khách hàng!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void button_timkiem_khachhang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_timkiem_khachhang.Text))
            {
                MessageBox.Show("Vui lòng nhập mã,tên,số điện thoại khách hàng!", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearForm();
                return;
            }
            string keyword = textBox_timkiem_khachhang.Text.Trim();
            using (var context = new DBNhanVien())
            {
                var result = context.khachHangs
                    .Where(n => n.MaKH.Contains(keyword) || n.TenKH.Contains(keyword) || n.SDT.Contains(keyword))
                    .ToList();
                dataGridView_khachhang.DataSource = result;
                ClearForm();
                if (result.Count == 0)
                {
                    MessageBox.Show("không tìm thấy khách hàng!",
                        "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void KhachHangControl_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
            
        }
    }
}
