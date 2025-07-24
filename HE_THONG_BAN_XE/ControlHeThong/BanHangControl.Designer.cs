namespace HE_THONG_BAN_XE.ControlHeThong
{
    partial class BanHangControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            label_giatrikm_bh = new Label();
            label3 = new Label();
            dateTimePicker_ngaylaphd_bh = new DateTimePicker();
            label_dongia_bh = new Label();
            comboBox_makm_bh = new ComboBox();
            comboBox_maxe_bh = new ComboBox();
            comboBox_makh_bh = new ComboBox();
            textBox_mahd_bh = new TextBox();
            label_thanhtien_bh = new Label();
            label10 = new Label();
            label9 = new Label();
            label_macode_bh = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            button_all_bh = new Button();
            button_themxe_bh = new Button();
            button_lammoi_bh = new Button();
            button_chitiethoadon_bh = new Button();
            button_timkiem_bh = new Button();
            button_taohoadon_bh = new Button();
            dataGridView_hoadon_bh = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_hoadon_bh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(14, 10);
            label1.Name = "label1";
            label1.Size = new Size(209, 25);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Bán Hàng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label_giatrikm_bh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker_ngaylaphd_bh);
            groupBox1.Controls.Add(label_dongia_bh);
            groupBox1.Controls.Add(comboBox_makm_bh);
            groupBox1.Controls.Add(comboBox_maxe_bh);
            groupBox1.Controls.Add(comboBox_makh_bh);
            groupBox1.Controls.Add(textBox_mahd_bh);
            groupBox1.Controls.Add(label_thanhtien_bh);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label_macode_bh);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(14, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(744, 432);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn";
            // 
            // label_giatrikm_bh
            // 
            label_giatrikm_bh.Location = new Point(176, 261);
            label_giatrikm_bh.Name = "label_giatrikm_bh";
            label_giatrikm_bh.Size = new Size(551, 25);
            label_giatrikm_bh.TabIndex = 16;
            // 
            // label3
            // 
            label3.Location = new Point(7, 261);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 4;
            label3.Text = "Giá trị khuyến mãi:";
            label3.Click += label3_Click;
            // 
            // dateTimePicker_ngaylaphd_bh
            // 
            dateTimePicker_ngaylaphd_bh.Location = new Point(176, 340);
            dateTimePicker_ngaylaphd_bh.Name = "dateTimePicker_ngaylaphd_bh";
            dateTimePicker_ngaylaphd_bh.Size = new Size(551, 28);
            dateTimePicker_ngaylaphd_bh.TabIndex = 15;
            // 
            // label_dongia_bh
            // 
            label_dongia_bh.Location = new Point(176, 299);
            label_dongia_bh.Name = "label_dongia_bh";
            label_dongia_bh.Size = new Size(551, 25);
            label_dongia_bh.TabIndex = 14;
            // 
            // comboBox_makm_bh
            // 
            comboBox_makm_bh.FormattingEnabled = true;
            comboBox_makm_bh.Location = new Point(176, 219);
            comboBox_makm_bh.Name = "comboBox_makm_bh";
            comboBox_makm_bh.Size = new Size(551, 28);
            comboBox_makm_bh.TabIndex = 13;
            // 
            // comboBox_maxe_bh
            // 
            comboBox_maxe_bh.FormattingEnabled = true;
            comboBox_maxe_bh.Location = new Point(176, 172);
            comboBox_maxe_bh.Name = "comboBox_maxe_bh";
            comboBox_maxe_bh.Size = new Size(551, 28);
            comboBox_maxe_bh.TabIndex = 12;
            comboBox_maxe_bh.SelectedIndexChanged += comboBox_maxe_bh_SelectedIndexChanged;
            // 
            // comboBox_makh_bh
            // 
            comboBox_makh_bh.FormattingEnabled = true;
            comboBox_makh_bh.Location = new Point(176, 125);
            comboBox_makh_bh.Name = "comboBox_makh_bh";
            comboBox_makh_bh.Size = new Size(551, 28);
            comboBox_makh_bh.TabIndex = 11;
            // 
            // textBox_mahd_bh
            // 
            textBox_mahd_bh.Location = new Point(176, 78);
            textBox_mahd_bh.Name = "textBox_mahd_bh";
            textBox_mahd_bh.Size = new Size(551, 28);
            textBox_mahd_bh.TabIndex = 10;
            // 
            // label_thanhtien_bh
            // 
            label_thanhtien_bh.Location = new Point(176, 393);
            label_thanhtien_bh.Name = "label_thanhtien_bh";
            label_thanhtien_bh.Size = new Size(551, 25);
            label_thanhtien_bh.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 346);
            label10.Name = "label10";
            label10.Size = new Size(151, 20);
            label10.TabIndex = 8;
            label10.Text = "Ngày lập hóa đơn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(72, 393);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 7;
            label9.Text = "Thành tiền:";
            // 
            // label_macode_bh
            // 
            label_macode_bh.Location = new Point(176, 35);
            label_macode_bh.Name = "label_macode_bh";
            label_macode_bh.Size = new Size(551, 25);
            label_macode_bh.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 175);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 6;
            label8.Text = "Mã xe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 128);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 5;
            label7.Text = "Mã Khách hàng:";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 299);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 4;
            label6.Text = "Đơn giá:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 222);
            label5.Name = "label5";
            label5.Size = new Size(140, 20);
            label5.TabIndex = 3;
            label5.Text = "Mã Khuyến mãi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(62, 81);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 2;
            label4.Text = "Mã hóa đơn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 35);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 0;
            label2.Text = "Mã code:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button_all_bh);
            groupBox2.Controls.Add(button_themxe_bh);
            groupBox2.Controls.Add(button_lammoi_bh);
            groupBox2.Controls.Add(button_chitiethoadon_bh);
            groupBox2.Controls.Add(button_timkiem_bh);
            groupBox2.Controls.Add(button_taohoadon_bh);
            groupBox2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkBlue;
            groupBox2.Location = new Point(764, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 432);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điều Khiển";
            // 
            // button_all_bh
            // 
            button_all_bh.BackColor = Color.Tan;
            button_all_bh.Location = new Point(18, 370);
            button_all_bh.Name = "button_all_bh";
            button_all_bh.Size = new Size(332, 54);
            button_all_bh.TabIndex = 5;
            button_all_bh.Text = "Tất Cả Hóa Đơn";
            button_all_bh.UseVisualStyleBackColor = false;
            button_all_bh.Click += button_all_bh_Click;
            // 
            // button_themxe_bh
            // 
            button_themxe_bh.BackColor = Color.Tan;
            button_themxe_bh.Location = new Point(18, 236);
            button_themxe_bh.Name = "button_themxe_bh";
            button_themxe_bh.Size = new Size(332, 54);
            button_themxe_bh.TabIndex = 4;
            button_themxe_bh.Text = "Thêm xe vào Hóa Đơn";
            button_themxe_bh.UseVisualStyleBackColor = false;
            button_themxe_bh.Click += button_themxe_bh_Click;
            // 
            // button_lammoi_bh
            // 
            button_lammoi_bh.BackColor = Color.Tan;
            button_lammoi_bh.Location = new Point(18, 169);
            button_lammoi_bh.Name = "button_lammoi_bh";
            button_lammoi_bh.Size = new Size(332, 54);
            button_lammoi_bh.TabIndex = 3;
            button_lammoi_bh.Text = "Làm Mới";
            button_lammoi_bh.UseVisualStyleBackColor = false;
            button_lammoi_bh.Click += button_lammoi_bh_Click;
            // 
            // button_chitiethoadon_bh
            // 
            button_chitiethoadon_bh.BackColor = Color.Tan;
            button_chitiethoadon_bh.Location = new Point(18, 303);
            button_chitiethoadon_bh.Name = "button_chitiethoadon_bh";
            button_chitiethoadon_bh.Size = new Size(332, 54);
            button_chitiethoadon_bh.TabIndex = 2;
            button_chitiethoadon_bh.Text = "Chi tiết hóa đơn";
            button_chitiethoadon_bh.UseVisualStyleBackColor = false;
            button_chitiethoadon_bh.Click += button_chitiethoadon_bh_Click;
            // 
            // button_timkiem_bh
            // 
            button_timkiem_bh.BackColor = Color.Tan;
            button_timkiem_bh.Location = new Point(18, 102);
            button_timkiem_bh.Name = "button_timkiem_bh";
            button_timkiem_bh.Size = new Size(332, 54);
            button_timkiem_bh.TabIndex = 1;
            button_timkiem_bh.Text = "Tìm Kiếm";
            button_timkiem_bh.UseVisualStyleBackColor = false;
            button_timkiem_bh.Click += button_timkiem_bh_Click;
            // 
            // button_taohoadon_bh
            // 
            button_taohoadon_bh.BackColor = Color.Tan;
            button_taohoadon_bh.Location = new Point(18, 35);
            button_taohoadon_bh.Name = "button_taohoadon_bh";
            button_taohoadon_bh.Size = new Size(332, 54);
            button_taohoadon_bh.TabIndex = 0;
            button_taohoadon_bh.Text = "Tạo Hóa Đơn";
            button_taohoadon_bh.UseVisualStyleBackColor = false;
            button_taohoadon_bh.Click += button_taohoadon_bh_Click;
            // 
            // dataGridView_hoadon_bh
            // 
            dataGridView_hoadon_bh.BackgroundColor = Color.FloralWhite;
            dataGridView_hoadon_bh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_hoadon_bh.Location = new Point(14, 476);
            dataGridView_hoadon_bh.Name = "dataGridView_hoadon_bh";
            dataGridView_hoadon_bh.RowHeadersVisible = false;
            dataGridView_hoadon_bh.RowHeadersWidth = 51;
            dataGridView_hoadon_bh.Size = new Size(1120, 229);
            dataGridView_hoadon_bh.TabIndex = 3;
            dataGridView_hoadon_bh.CellContentClick += dataGridView_hoadon_bh_CellContentClick;
            // 
            // BanHangControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(dataGridView_hoadon_bh);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "BanHangControl";
            Size = new Size(1147, 721);
            Load += BanHangControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_hoadon_bh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label_macode_bh;
        private Label label8;
        private Label label10;
        private Label label9;
        private TextBox textBox_mahd_bh;
        private Label label_thanhtien_bh;
        private DateTimePicker dateTimePicker_ngaylaphd_bh;
        private Label label_dongia_bh;
        private ComboBox comboBox_makm_bh;
        private ComboBox comboBox_maxe_bh;
        private ComboBox comboBox_makh_bh;
        private GroupBox groupBox2;
        private Button button_timkiem_bh;
        private Button button_taohoadon_bh;
        private Button button_chitiethoadon_bh;
        private Button button_themxe_bh;
        private Button button_lammoi_bh;
        private DataGridView dataGridView_hoadon_bh;
        private Button button_all_bh;
        private Label label3;
        private Label label_giatrikm_bh;
    }
}
