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
using System.Xml;
using static System.Windows.Forms.AxHost;

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
            NhanVienControl nhanVienUC = new NhanVienControl // Tạo một điều khiển Nhân ViênControl
            {
                Name = "NhanVienControl",                    // Tên của điều khiển
                Dock = DockStyle.Fill,                       // Đặt điều khiển lấp đầy không gian của panel
                Visible = false                              // Ban đầu ẩn điều khiển này
            };
            Menu_Pannel.Controls.Add(nhanVienUC);


            Panel panelNV = CreateMenuPanel("👥", "Nhân Viên", Color.White, "NhanVienControl");
            panelNV.Location = new Point(0,0 ); // đặt bên dưới nút Xe chẳng hạn
            panner_chucnang.Controls.Add(panelNV); // hoặc panner_chucnang nếu mày dùng tên khác

            //Nut Xe
            XeControl xeControl = new XeControl // Tạo một điều khiển XeControl
            {
                Name = "XeControl",                          // Tên của điều khiển
                Dock = DockStyle.Fill,                       // Đặt điều khiển lấp đầy không gian của panel
                Visible = false                              // Ban đầu ẩn điều khiển này
            };
            Menu_Pannel.Controls.Add(xeControl); // Thêm điều khiển XeControl vào panel Menu_Pannel
            Panel panelXe = CreateMenuPanel("🏢", "Kho hàng ", Color.White, "XeControl");
            panelXe.Location = new Point(0,100); // Đặt vị trí panel Xe bên dưới panel Nhân Viên
            panner_chucnang.Controls.Add(panelXe); // Thêm panel Xe vào panner_chucnang
            //Nut Khach Hang 
            KhachHangControl khachHangControl = new KhachHangControl // Tạo một điều khiển KhachHangControl
            {
                Name = "KhachHangControl",                  // Tên của điều khiển
                Dock = DockStyle.Fill,                       // Đặt điều khiển lấp đầy không gian của panel
                Visible = false                              // Ban đầu ẩn điều khiển này
            };
            Menu_Pannel.Controls.Add(khachHangControl); // Thêm điều khiển KhachHangControl vào panel Menu_Pannel
            Panel panelKhachHang = CreateMenuPanel("👤", "Khách Hàng", Color.White, "KhachHangControl");
            panelKhachHang.Location = new Point(0, 200); // Đặt vị trí panel Khách Hàng bên dưới panel Xe
            panner_chucnang.Controls.Add(panelKhachHang); // Thêm panel Khách Hàng vào panner_chucnang
            //Nut Hoa Don
            /* HoaDonControl hoaDonControl = new HoaDonControl // Tạo một điều khiển HoaDonControl
            {
                Name = "HoaDonControl",                      // Tên của điều khiển
                Dock = DockStyle.Fill,                       // Đặt điều khiển lấp đầy không gian của panel
                Visible = false                              // Ban đầu ẩn điều khiển này
            };
            Menu_Pannel.Controls.Add(hoaDonControl); // Thêm điều khiển HoaDonControl vào panel Menu_Pannel
            Panel panelHoaDon = CreateMenuPanel("🧾", "Hóa Đơn", Color.LightSkyBlue, "HoaDonControl");
            panelHoaDon.Location = new Point(0, 200); // Đặt vị trí panel Hóa Đơn bên dưới panel Khách Hàng
            panner_chucnang.Controls.Add(panelHoaDon); // Thêm panel Hóa Đơn vào panner_chucnang
            */
            //Nut Khach Hang Khuyen Mai
            
             KhachHangKhuyenMaiControl khachHangKhuyenMaiControl = new KhachHangKhuyenMaiControl // Tạo một điều khiển KhachHangKhuyenMaiControl
            {
              Name = "KhachHangKhuyenMaiControl", // Tên của điều khiển
              Dock = DockStyle.Fill, // Đặt điều khiển lấp đầy không gian của panel
              Visible = false // Ban đầu ẩn điều khiển này
            };
            Menu_Pannel.Controls.Add(khachHangKhuyenMaiControl); // Thêm điều khiển KhachHangKhuyenMaiControl vào panel Menu_Pannel
            Panel panelKhachHangKhuyenMai = CreateMenuPanel("🎁", "Khuyến Mãi", Color.White, "KhachHangKhuyenMaiControl");
            panelKhachHangKhuyenMai.Location = new Point(0, 300); // Đặt vị trí panel Khách Hàng Khuyến Mãi bên dưới panel Hóa Đơn
            panner_chucnang.Controls.Add(panelKhachHangKhuyenMai); // Thêm panel Khách Hàng Khuyến Mãi vào panner_chucnang

            //Nut chuyen trang ban hang
            BanHangControl banHangControl = new BanHangControl
            {
              Name = "BanHangControl",
              Dock = DockStyle.Fill,
              Visible = false
            };
            Menu_Pannel.Controls.Add(banHangControl);
            Panel panelBanHangControl = CreateMenuPanel("🛒", "Bán Hàng",Color.White,"BanHangControl");
            panelBanHangControl.Location = new Point(0, 400);
            panner_chucnang.Controls.Add (panelBanHangControl);

            //Nut Bao cao 
            BaoCaoControl baoCaoControl = new BaoCaoControl
            {
                Name = "BaoCaoControl",
                Dock = DockStyle.Fill,
                Visible = false
            };
            Menu_Pannel.Controls.Add(baoCaoControl);
            Panel panelBaoCaoControl = CreateMenuPanel("📊", "Báo Cáo", Color.White, "BaoCaoControl");
            panelBaoCaoControl.Location = new Point(0, 500);
            panner_chucnang.Controls.Add(panelBaoCaoControl);

        }

        private Panel CreateMenuPanel(string iconText, string labelText, Color bgColor, string tagName)
        {
            Panel panel = new Panel
            {
                Size = new Size(179, 100),
                BackColor = bgColor,
                Cursor = Cursors.Hand,
                Tag = tagName
            };

            int iconWidth = 40, iconHeight = 50;
            int labelWidth = 110, labelHeight = 50;
            int spacing = 10;
            int totalWidth = iconWidth + spacing + labelWidth;
            int startX = (panel.Width - totalWidth) / 2;
            int centerY = (panel.Height - iconHeight) / 2;

            Label icon = new Label
            {
                Text = iconText,
                Font = new Font("Segoe UI Emoji", 16),
                ForeColor = Color.Black,
                Size = new Size(iconWidth, iconHeight),
                Location = new Point(startX, centerY),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label label = new Label
            {
                Text = labelText,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Black,
                Size = new Size(labelWidth, labelHeight),
                Location = new Point(startX + iconWidth + spacing, centerY),
                TextAlign = ContentAlignment.MiddleLeft
            };

            icon.Click += (s, e) => OnPanelClick(tagName);
            label.Click += (s, e) => OnPanelClick(tagName);
            panel.Click += (s, e) => OnPanelClick(tagName);

            // Hover
            panel.MouseEnter += (s, e) => panel.BackColor = ControlPaint.Dark(bgColor, 0.1f);
            icon.MouseEnter += (s, e) => panel.BackColor = ControlPaint.Dark(bgColor, 0.1f);
            label.MouseEnter += (s, e) => panel.BackColor = ControlPaint.Dark(bgColor, 0.1f);

            panel.MouseLeave += (s, e) => panel.BackColor = bgColor;
            icon.MouseLeave += (s, e) => panel.BackColor = bgColor;
            label.MouseLeave += (s, e) => panel.BackColor = bgColor;

            panel.Controls.Add(icon);
            panel.Controls.Add(label);
            return panel;
        }

        private void Label_MouseEnter(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnPanelClick(string tagName)
        {
            ShowPanelTrongPanelNoiDung(tagName);
        }
        private void ShowPanelTrongPanelNoiDung(string controlName)
        {
            foreach (Control ctrl in Menu_Pannel.Controls)
            {
                if (ctrl.Name == controlName)
                    ctrl.Visible = true;
                else
                    ctrl.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                Application.Exit();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;         // Phóng to
            this.FormBorderStyle = FormBorderStyle.None;          // Ẩn viền (nếu muốn kiểu full real)
            this.Bounds = Screen.PrimaryScreen.Bounds;            // Chiếm toàn màn hình

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

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
