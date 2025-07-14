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
    public partial class KhachHangKhuyenMaiControl : UserControl
    {
        public KhachHangKhuyenMaiControl()
        {
            InitializeComponent();
        }
        private void ClearForm()
        {
            textBox_makm_km.Clear();
            textBox_tekm_km.Clear();
            textBox_giatrikhuyenmai_km.Clear();
            textBox_timkiem_khuyenmai.Clear();
            textBox_trangthai_km.Clear();

            radioButton_phantram_km.Checked = false;
            radioButton_tienmat_km.Checked = false;

            checkBox_2xe_km.Checked = false;
            checkBox_4lanmua_km.Checked = false;
            checkBox_dongia1ty_km.Checked = false;
            checkBox_khmuaxe_km.Checked = false;
            checkBox_tren2xe_km.Checked = false;

            dateTime_ngayad_km.Value = DateTime.Now; // hoặc giá trị mặc định
            DateTime_ngayhh_km.Value = DateTime.Now;

            textBox_makm_km.Focus(); 
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

        }

        private void radioButton_tienmat_km_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_tienmat_km.Checked)
            {
                groupBox_giamtienmat.Visible = true;
                groupBox_giamphantram.Visible = false;
            }
        }

        private void radioButton_phantram_km_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_phantram_km.Checked)
            {
                groupBox_giamphantram.Visible = true;
                groupBox_giamtienmat.Visible = false;
            }
        }
    }
}
