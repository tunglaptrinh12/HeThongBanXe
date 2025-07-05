using HE_THONG_BAN_XE.ControlHeThong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HE_THONG_BAN_XE.FormHeThong
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();  
        }
        private void CustomizeDesign() // Tùy chỉnh giao diện menu
        {
            Panel panelXe = CreateMenuPanel("🚗", "Quản Lý Xe", Color.FromArgb(52, 152, 219), "FormXe"); // Tạo panel cho Quản Lý Xe
            panelXe.Location = new Point(0, 50); // Đặt vị trí panel
            panner_chucnang.Controls.Add(panelXe); // Thêm panel vào panner_chucnang
            NhanVienControl nv = new NhanVienControl();
            nv.Dock = DockStyle.Fill;
            Menu_Pannel.Controls.Clear();
            Menu_Pannel.Controls.Add(nv);
        }
        private Panel CreateMenuPanel(string iconText, string labelText, Color bgColor, string tagName) // Tạo panel menu với biểu tượng, nhãn, màu nền và tên thẻ
        {
            Panel panel = new Panel // Tạo panel mới
            {
                Size = new Size(179,50), // Kích thước của panel
                BackColor = bgColor, // Màu nền của panel
                Cursor = Cursors.Hand, //   Hiển thị con trỏ tay khi di chuột qua panel
                Tag = tagName // Gán tên thẻ cho panel để sử dụng sau này
            };
            

            Label icon = new Label // Tạo nhãn cho biểu tượng
            {
                Text = iconText, // Biểu tượng hiển thị trên nhãn
                Font = new Font("Segoe UI Emoji", 16), // Phông chữ Segoe UI Emoji, cỡ 16
                ForeColor = Color.White, // Màu chữ trắng
                Size = new Size(40, 50), // Kích thước của nhãn biểu tượng
                Location = new Point(5,0), // Vị trí của nhãn biểu tượng
                TextAlign = ContentAlignment.MiddleCenter // Căn giữa biểu tượng trong nhãn
            };

            Label label = new Label // Tạo nhãn cho văn bản
            {
                Text = labelText, // Văn bản hiển thị trên nhãn
                Font = new Font("Segoe UI", 11, FontStyle.Bold), //    Phông chữ Segoe UI, cỡ 11, đậm
                ForeColor = Color.White, // Màu chữ trắng
                Size = new Size(130, 50), //    Kích thước của nhãn văn bản
                Location = new Point(50,0), // Vị trí của nhãn văn bản
                TextAlign = ContentAlignment.MiddleCenter //    Căn giữa văn bản trong nhãn
            
            };


        // Gắn click
            icon.Click += (s, e) => MessageBox.Show($"Mở form: {panel.Tag}"); // Click on icon
            label.Click += (s, e) => MessageBox.Show($"Mở form: {panel.Tag}"); // Click on label
            panel.Click += (s, e) =>
            {
                string tag = panel.Tag.ToString(); // ví dụ: "panelXe"
                ShowPanelTrongPanelNoiDung(tag);
            };

            // Hover
            panel.MouseEnter += (s, e) => panel.BackColor = ControlPaint.Dark(bgColor, 0.1f);// Hover in
            panel.MouseLeave += (s, e) => panel.BackColor = bgColor; // Hover out

            panel.Controls.Add(icon); // Thêm nhãn biểu tượng vào panel
            panel.Controls.Add(label); // Thêm nhãn biểu tượng và nhãn văn bản vào panel
            return panel;
        }
        private void ShowPanelTrongPanelNoiDung(string panelName)
        {
            foreach (Control ctrl in Menu_Pannel.Controls)
            {
                if (ctrl is Panel)
                {
                    ctrl.Visible = ctrl.Name == panelName;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
//Panel panelKhachHang = new Panel
//{
//    Name = "panelKhachHang",
//    Dock = DockStyle.Fill,
//    BackColor = Color.LightGreen, // hoặc màu khác tuỳ mày
//    Visible = false
//};
//panelNoiDung.Controls.Add(panelKhachHang);
//Panel panelKH = CreateMenuPanel("👥", "Khách Hàng", Color.FromArgb(46, 204, 113), "panelKhachHang");
//panelKH.Location = new Point(0, 100); // đặt bên dưới nút Xe chẳng hạn
//panelMenu.Controls.Add(panelKH); // hoặc panner_chucnang nếu mày dùng tên khác