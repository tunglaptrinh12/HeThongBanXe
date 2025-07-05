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
            NhanVienControl nhanVienUC = new NhanVienControl // Tạo một điều khiển Nhân ViênControl
            {
                Name = "NhanVienControl",                    // Tên của điều khiển
                Dock = DockStyle.Fill,
                Visible = false
            };
            Menu_Pannel.Controls.Add(nhanVienUC);


            Panel panelKH = CreateMenuPanel("👥", "Nhân Viên", Color.FromArgb(46, 204, 113), "NhanVienControl");
            panelKH.Location = new Point(0, 50); // đặt bên dưới nút Xe chẳng hạn
            panner_chucnang.Controls.Add(panelKH); // hoặc panner_chucnang nếu mày dùng tên khác
        }
        private Panel CreateMenuPanel(string iconText, string labelText, Color bgColor, string tagName) // Tạo panel menu với biểu tượng, nhãn, màu nền và tên thẻ
        {
            Panel panel = new Panel // Tạo panel mới
            {
                Size = new Size(179, 50), // Kích thước của panel
                BackColor = bgColor, // Màu nền của panel
                Cursor = Cursors.Hand, // Hiển thị con trỏ tay khi di chuột qua panel
                Tag = tagName // Gán tên thẻ cho panel để sử dụng sau này
            };

            Label icon = new Label // Tạo nhãn cho biểu tượng
            {
                Text = iconText, // Biểu tượng hiển thị trên nhãn
                Font = new Font("Segoe UI Emoji", 16), // Phông chữ Segoe UI Emoji, cỡ 16
                ForeColor = Color.White, // Màu chữ trắng
                Size = new Size(40, 50), // Kích thước của nhãn biểu tượng
                Location = new Point(5, 0), // Vị trí của nhãn biểu tượng
                TextAlign = ContentAlignment.MiddleCenter // Căn giữa biểu tượng trong nhãn
            };

            Label label = new Label // Tạo nhãn cho văn bản
            {
                Text = labelText, // Văn bản hiển thị trên nhãn
                Font = new Font("Segoe UI", 11, FontStyle.Bold), // Phông chữ Segoe UI, cỡ 11, đậm
                ForeColor = Color.White, // Màu chữ trắng
                Size = new Size(130, 50), // Kích thước của nhãn văn bản
                Location = new Point(50, 0), // Vị trí của nhãn văn bản
                TextAlign = ContentAlignment.MiddleCenter // Căn giữa văn bản trong nhãn
            };

            // Gắn click
            icon.Click += (s, e) => OnPanelClick(tagName);
            label.Click += (s, e) => OnPanelClick(tagName);
            panel.Click += (s, e) => OnPanelClick(tagName);

            // Hover
            panel.MouseEnter += (s, e) => panel.BackColor = ControlPaint.Dark(bgColor, 0.1f); // Hover in
            panel.MouseLeave += (s, e) => panel.BackColor = bgColor; // Hover out

            panel.Controls.Add(icon); // Thêm nhãn biểu tượng vào panel
            panel.Controls.Add(label); // Thêm nhãn biểu tượng và nhãn văn bản vào panel
            return panel;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
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

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
