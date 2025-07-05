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

        }

        private void button_them_nhanvien_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
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
                using (var Context = new DBNhanVien())
                {
                    var data = Context.nhanViens.ToList(); // Lấy tất cả nhân viên
                    dataGridView_nhanvien.DataSource = data;
                }
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
                    using (var Context = new DBNhanVien())
                    {
                        var data = Context.nhanViens.ToList();
                        dataGridView_nhanvien.DataSource = data;
                    }
                }
                else
                {
                    MessageBox.Show("không tìm Thấy Nhân viên!", "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void button_tatca_nhanvien_Click(object sender, EventArgs e)
        {
            using (var context = new DBNhanVien())
            {
                var data = context.nhanViens.ToList(); // Lấy tất cả nhân viên
                dataGridView_nhanvien.DataSource = data;
            }
        }

        private void button_sua_nhanvien_Click(object sender, EventArgs e)
        {
            using ( var context = new DBNhanVien())
            {
                string ma = textBox_manv_nhanvien.Text.Trim();
                var nv = context.nhanViens.FirstOrDefault( n => n.MaNV == ma );
                if ( nv != null )
                {
                    nv.TenNV = textBox_tennv_nhanvien.Text.Trim();
                    nv.GioiTinh = radioButton_nam_nhanvien.Checked ? "Nam" : "Nữ";
                    nv.NamSinh = dateTimePicker_namsinh_nhanvien.Value;
                }
            }
        }
    }
}
