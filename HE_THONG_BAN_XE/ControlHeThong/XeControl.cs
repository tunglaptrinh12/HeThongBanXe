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

        }

        private void XeControl_Load(object sender, EventArgs e)
        {
            LoadXe();
        }
    }
}
