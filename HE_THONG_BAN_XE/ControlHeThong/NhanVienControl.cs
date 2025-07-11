using HE_THONG_BAN_XE.Connect;
using HE_THONG_BAN_XE.model;
using Microsoft.Data.SqlClient;
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
    public partial class NhanVienControl : UserControl
    {
        public NhanVienControl()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            textBox_manv_nhanvien.Clear();
            textBox_tennv_nhanvien.Clear();
            textBox_sdt_nhanvien.Clear();
            textBox_email_nhanvien.Clear();

            radioButton_nam_nhanvien.Checked = false;
            radioButton_nu_nhanvien.Checked = false;

            checkBox_nvbanhang_nhanvien.Checked = false;
            checkBox_thungan_nhanvien.Checked = false;

            dateTimePicker_namsinh_nhanvien.Value = DateTime.Now; // hoặc giá trị mặc định

            textBox_manv_nhanvien.Focus(); // trỏ chuột về ô mã nhân viên
        }
        private void LoadNhanVien()
        {

            using (var Context = new DBNhanVien())
            {
                var list = Context.nhanViens.ToList();
                dataGridView_nhanvien.DataSource = list;
                FormatDataGridView();
            }
            if (dataGridView_nhanvien.Columns.Contains("MaNV"))
            {
                dataGridView_nhanvien.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                dataGridView_nhanvien.Columns["MaNV"].Width = 130;
            }
            if (dataGridView_nhanvien.Columns.Contains("TenNV"))
            { 
                dataGridView_nhanvien.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
                dataGridView_nhanvien.Columns["TenNV"].Width = 180;
            }
            if (dataGridView_nhanvien.Columns.Contains("NamSinh"))
                dataGridView_nhanvien.Columns["NamSinh"].HeaderText = "Ngày Sinh";
            if (dataGridView_nhanvien.Columns.Contains("GioiTinh"))
                dataGridView_nhanvien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            if (dataGridView_nhanvien.Columns.Contains("DiaChi"))
                dataGridView_nhanvien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            if (dataGridView_nhanvien.Columns.Contains("SoDienThoai"))
                dataGridView_nhanvien.Columns["SDT"].HeaderText = "Số Điện Thoại";
            if (dataGridView_nhanvien.Columns.Contains("ChucVu"))
                dataGridView_nhanvien.Columns["ChucVu"].HeaderText = "Chức Vụ";;
        }
        private void FormatDataGridView()
        {
            dataGridView_nhanvien.EnableHeadersVisualStyles = false;

            dataGridView_nhanvien.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dataGridView_nhanvien.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView_nhanvien.ColumnHeadersDefaultCellStyle.Font = new Font("Time New Roman", 10, FontStyle.Bold);

            dataGridView_nhanvien.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView_nhanvien.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridView_nhanvien.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView_nhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                textBox_manv_nhanvien.Text = dataGridView_nhanvien.Rows[i].Cells["MaNV"].Value.ToString();
                textBox_tennv_nhanvien.Text = dataGridView_nhanvien.Rows[i].Cells["TenNV"].Value.ToString();
                string gioiTinh = dataGridView_nhanvien.Rows[i].Cells["GioiTinh"].Value.ToString();
                if (gioiTinh == "Nam") radioButton_nam_nhanvien.Checked = true; else radioButton_nu_nhanvien.Checked = true;
                dateTimePicker_namsinh_nhanvien.Value = Convert.ToDateTime(dataGridView_nhanvien.Rows[i].Cells["NamSinh"].Value);
                textBox_sdt_nhanvien.Text = dataGridView_nhanvien.Rows[i].Cells["SDT"].Value.ToString();
                textBox_email_nhanvien.Text = dataGridView_nhanvien.Rows[i].Cells["Email"].Value.ToString();

                string chucVu = dataGridView_nhanvien.Rows[i].Cells["ChucVu"].Value.ToString();
                checkBox_nvbanhang_nhanvien.Checked = chucVu.Contains("Bán Hàng");
                checkBox_thungan_nhanvien.Checked = chucVu.Contains("Thu Ngân");
            }
        }

        private void button_them_nhanvien_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                // không để trống tên mã số điện thoại nhân viên
                if (string.IsNullOrWhiteSpace(textBox_manv_nhanvien.Text) ||
                    string.IsNullOrWhiteSpace(textBox_tennv_nhanvien.Text) ||
                            string.IsNullOrWhiteSpace(textBox_sdt_nhanvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã,tên,số điện thoại nhân viên!", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                string maNV = textBox_manv_nhanvien.Text.Trim();
                // kiểm tra nhân viên tồn tại chưa
                bool maNVExists = context.nhanViens.Any(nv => nv.MaNV == maNV);
                if (maNVExists)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác!",
                        "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                var nv = new NhanVien
                {
                    MaNV = textBox_manv_nhanvien.Text.Trim(),
                    TenNV = textBox_tennv_nhanvien.Text.Trim(),
                    GioiTinh = radioButton_nam_nhanvien.Checked ? "Nam" : "Nữ",
                    NamSinh = dateTimePicker_namsinh_nhanvien.Value,
                    SDT = textBox_sdt_nhanvien.Text.Trim(),
                    Email = textBox_email_nhanvien.Text,
                    ChucVu = (checkBox_nvbanhang_nhanvien.Checked ? "Nhân Viên Bán Hàng" : "")
                     + (checkBox_thungan_nhanvien.Checked ? "Thu Ngân" : "")
                };
                context.nhanViens.Add(nv);
                context.SaveChanges();
                MessageBox.Show("Đã Thêm Một Nhân Viên!", "thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadNhanVien();
                FormatDataGridView();
                ClearForm();
            }

        }

        private void button_xoa_nhanvien_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_manv_nhanvien.Text.Trim();
                var nv = context.nhanViens.FirstOrDefault(n => n.MaNV == ma);
                if (nv != null)
                {
                    context.nhanViens.Remove(nv);
                    context.SaveChanges();
                    MessageBox.Show("Đã xóa nhân viên!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    LoadNhanVien();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("không tìm Thấy Nhân viên!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void button_tatca_nhanvien_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                var data = context.nhanViens.ToList(); // Lấy tất cả nhân viên
                dataGridView_nhanvien.DataSource = data;
                ClearForm();
            }
        }

        private void button_sua_nhanvien_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                string ma = textBox_manv_nhanvien.Text.Trim();
                // kiểm tra mã nhân viên tồn tại chưa
                bool maNVExists = context.nhanViens.Any(nv => nv.MaNV == ma);
                if (maNVExists)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng nhập mã khác!",
                        "Lỗi", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                // không được bỏ trống tên mã số điện thoại nhân viên
                if (string.IsNullOrWhiteSpace(textBox_manv_nhanvien.Text) ||
                    string.IsNullOrWhiteSpace(textBox_tennv_nhanvien.Text) ||
                            string.IsNullOrWhiteSpace(textBox_sdt_nhanvien.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã,tên,số điện thoại nhân viên!", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                    return;
                }
                var nv = context.nhanViens.FirstOrDefault(n => n.MaNV == ma);
                if (nv != null)
                {
                    nv.TenNV = textBox_tennv_nhanvien.Text.Trim();
                    nv.GioiTinh = radioButton_nam_nhanvien.Checked ? "Nam" : "Nữ";
                    nv.NamSinh = dateTimePicker_namsinh_nhanvien.Value;
                    nv.SDT = textBox_sdt_nhanvien.Text.Trim();
                    nv.Email = textBox_email_nhanvien.Text.Trim();
                    nv.ChucVu = (checkBox_nvbanhang_nhanvien.Checked ? "Nhân Viên Bán Hàng" : "") +
                        (checkBox_thungan_nhanvien.Checked ? "Thu Ngân" : "");
                    context.SaveChanges();
                    MessageBox.Show("đã sửa nhân viên", "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadNhanVien();
                    FormatDataGridView();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("không tìm thấy nhân viên!",
                        "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }

        private void NhanVienControl_Load(object sender, EventArgs e)
        {
            LoadNhanVien();
        }

        private void button_timkiem_nhanvien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_timkiem_nhanvien.Text))
            {
                MessageBox.Show("Vui lòng nhập mã,tên,số điện thoại nhân viên!", "thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearForm();
                return;
            }
            string keyword = textBox_timkiem_nhanvien.Text.Trim();
            using (var context = new DBNhanVien())
            {
                var result = context.nhanViens
                    .Where(n => n.MaNV.Contains(keyword) || n.TenNV.Contains(keyword) || n.SDT.Contains(keyword))
                    .ToList();
                dataGridView_nhanvien.DataSource = result;
                ClearForm();
                if (result.Count == 0)
                {
                    MessageBox.Show("không tìm thấy nhân viên!",
                        "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm() ;
                }
            }
        }

        private void radioButton_nam_nhanvien_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
