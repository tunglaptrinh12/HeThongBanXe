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
            if (dataGridView_xe.Columns.Contains("HoaDons"))
            {
                dataGridView_xe.Columns["HoaDons"].HeaderText = "Hóa Đơn";
                dataGridView_xe.Columns["HoaDons"].Width = 80;

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
                    ClearForm();
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
                    ClearForm();
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
    }
}
