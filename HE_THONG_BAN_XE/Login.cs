using HE_THONG_BAN_XE.Connect;

namespace HE_THONG_BAN_XE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với hệ thống!",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xacnhan_Click(object sender, EventArgs e)
        {
            string tenDN = txt_Name.Text.Trim();
            string matKhau = txt_Pass.Text;
            string maQLBiMat = "QUANLY123";

            if (string.IsNullOrWhiteSpace(tenDN) || string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.",
                    "Cảnh Báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (radioButton_QuanLy.Checked)
            {
                // Định nghĩa tài khoản quản lý cố định trong code
                string taiKhoanQL = "admin";
                string matKhauQL = "admin123";

                if (txt_Name.Text == taiKhoanQL && txt_Pass.Text == matKhauQL)
                {
                    MessageBox.Show("Bạn đã đăng Nhập với vai trò quản lý!",
                        "thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("tài Khoản Mật Khẩu sai!",
                        "Cảnh Báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (radioButton_NhanVien.Checked)
            {
                if (string.IsNullOrWhiteSpace(txt_Name.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã nhân viên để đăng nhập",
                        "Cảnh Báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                using (var db = new DBNhanVien())
                {
                    // Kiểm tra Mã Nhân viên có trong CSDL không
                    var nv = db.nhanViens.FirstOrDefault(n => n.MaNV == txt_Name.Text);
                    if (nv != null)
                    {
                        if (txt_Pass.Text == "t123")
                        {
                            // kết nói sang form
                                
                        }
                        else
                        {
                            MessageBox.Show("Sai mật khẩu",
                                "Cảnh Báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sai Tên đăng nhập!",
                            "cảnh báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("vui lòng chọn vai trò đăng nhập!",
                    "thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void radioButton_QuanLy_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
