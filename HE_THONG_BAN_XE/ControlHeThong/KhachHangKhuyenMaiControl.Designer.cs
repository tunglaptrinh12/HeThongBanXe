namespace HE_THONG_BAN_XE.ControlHeThong
{
    partial class KhachHangKhuyenMaiControl
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
            DateTimeNgayAD = new DateTimePicker();
            txtMaKM = new TextBox();
            txtMaKH = new TextBox();
            txtMaHoaDon = new TextBox();
            txtGhiChu = new TextBox();
            txtGTKM = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView_nhanvien = new DataGridView();
            groupBox2 = new GroupBox();
            NutTimKiem = new Button();
            NutShowAll = new Button();
            NutXoa = new Button();
            NutSua = new Button();
            NutThem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_nhanvien).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SkyBlue;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(281, 32);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Khuyến Mãi";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DateTimeNgayAD);
            groupBox1.Controls.Add(txtMaKM);
            groupBox1.Controls.Add(txtMaKH);
            groupBox1.Controls.Add(txtMaHoaDon);
            groupBox1.Controls.Add(txtGhiChu);
            groupBox1.Controls.Add(txtGTKM);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkBlue;
            groupBox1.Location = new Point(28, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(719, 375);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // DateTimeNgayAD
            // 
            DateTimeNgayAD.Location = new Point(229, 208);
            DateTimeNgayAD.Name = "DateTimeNgayAD";
            DateTimeNgayAD.Size = new Size(473, 34);
            DateTimeNgayAD.TabIndex = 11;
            // 
            // txtMaKM
            // 
            txtMaKM.Location = new Point(229, 34);
            txtMaKM.Name = "txtMaKM";
            txtMaKM.Size = new Size(473, 34);
            txtMaKM.TabIndex = 10;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(229, 92);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(473, 34);
            txtMaKH.TabIndex = 9;
            // 
            // txtMaHoaDon
            // 
            txtMaHoaDon.Location = new Point(229, 150);
            txtMaHoaDon.Name = "txtMaHoaDon";
            txtMaHoaDon.Size = new Size(473, 34);
            txtMaHoaDon.TabIndex = 8;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(229, 324);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(473, 34);
            txtGhiChu.TabIndex = 7;
            // 
            // txtGTKM
            // 
            txtGTKM.Location = new Point(229, 261);
            txtGTKM.Name = "txtGTKM";
            txtGTKM.Size = new Size(473, 34);
            txtGTKM.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(125, 332);
            label5.Name = "label5";
            label5.Size = new Size(98, 26);
            label5.TabIndex = 5;
            label5.Text = "Ghi chú :\r\n";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 269);
            label6.Name = "label6";
            label6.Size = new Size(198, 26);
            label6.TabIndex = 4;
            label6.Text = "Giá trị khuyến mãi :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(69, 215);
            label7.Name = "label7";
            label7.Size = new Size(154, 26);
            label7.TabIndex = 3;
            label7.Text = "Ngày áp dụng :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 158);
            label4.Name = "label4";
            label4.Size = new Size(135, 26);
            label4.TabIndex = 2;
            label4.Text = "Mã hóa đơn :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 100);
            label3.Name = "label3";
            label3.Size = new Size(172, 26);
            label3.TabIndex = 1;
            label3.Text = "Mã khách hàng : ";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 42);
            label2.Name = "label2";
            label2.Size = new Size(169, 26);
            label2.TabIndex = 0;
            label2.Text = "Mã khuyến mãi :";
            // 
            // dataGridView_nhanvien
            // 
            dataGridView_nhanvien.BackgroundColor = Color.FloralWhite;
            dataGridView_nhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_nhanvien.Location = new Point(17, 450);
            dataGridView_nhanvien.Name = "dataGridView_nhanvien";
            dataGridView_nhanvien.ReadOnly = true;
            dataGridView_nhanvien.RowHeadersWidth = 51;
            dataGridView_nhanvien.Size = new Size(1111, 259);
            dataGridView_nhanvien.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NutTimKiem);
            groupBox2.Controls.Add(NutShowAll);
            groupBox2.Controls.Add(NutXoa);
            groupBox2.Controls.Add(NutSua);
            groupBox2.Controls.Add(NutThem);
            groupBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            groupBox2.ForeColor = Color.DarkBlue;
            groupBox2.Location = new Point(753, 69);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 375);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Điều khiển";
            // 
            // NutTimKiem
            // 
            NutTimKiem.BackColor = Color.Tan;
            NutTimKiem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            NutTimKiem.ForeColor = SystemColors.InactiveCaptionText;
            NutTimKiem.Location = new Point(18, 320);
            NutTimKiem.Name = "NutTimKiem";
            NutTimKiem.Size = new Size(338, 49);
            NutTimKiem.TabIndex = 5;
            NutTimKiem.Text = "Tìm Kiếm";
            NutTimKiem.UseVisualStyleBackColor = false;
            // 
            // NutShowAll
            // 
            NutShowAll.BackColor = Color.Tan;
            NutShowAll.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            NutShowAll.ForeColor = SystemColors.InactiveCaptionText;
            NutShowAll.Location = new Point(18, 252);
            NutShowAll.Name = "NutShowAll";
            NutShowAll.Size = new Size(338, 49);
            NutShowAll.TabIndex = 4;
            NutShowAll.Text = "Tất cả";
            NutShowAll.UseVisualStyleBackColor = false;
            // 
            // NutXoa
            // 
            NutXoa.BackColor = Color.Tan;
            NutXoa.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            NutXoa.ForeColor = SystemColors.InactiveCaptionText;
            NutXoa.Location = new Point(18, 182);
            NutXoa.Name = "NutXoa";
            NutXoa.Size = new Size(338, 49);
            NutXoa.TabIndex = 3;
            NutXoa.Text = "Xóa";
            NutXoa.UseVisualStyleBackColor = false;
            // 
            // NutSua
            // 
            NutSua.BackColor = Color.Tan;
            NutSua.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            NutSua.ForeColor = SystemColors.InactiveCaptionText;
            NutSua.Location = new Point(18, 106);
            NutSua.Name = "NutSua";
            NutSua.Size = new Size(338, 49);
            NutSua.TabIndex = 2;
            NutSua.Text = "Sửa";
            NutSua.UseVisualStyleBackColor = false;
            // 
            // NutThem
            // 
            NutThem.BackColor = Color.Tan;
            NutThem.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold);
            NutThem.ForeColor = SystemColors.InactiveCaptionText;
            NutThem.Location = new Point(18, 30);
            NutThem.Name = "NutThem";
            NutThem.Size = new Size(338, 49);
            NutThem.TabIndex = 1;
            NutThem.Text = "Thêm";
            NutThem.UseVisualStyleBackColor = false;
            // 
            // KhachHangKhuyenMaiControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            Controls.Add(groupBox2);
            Controls.Add(dataGridView_nhanvien);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "KhachHangKhuyenMaiControl";
            Size = new Size(1147, 721);
            Load += KhachHangKhuyenMaiControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_nhanvien).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dataGridView_nhanvien;
        private GroupBox groupBox2;
        private Button NutThem;
        private Button NutShowAll;
        private Button NutXoa;
        private Button NutSua;
        private Button NutTimKiem;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private DateTimePicker DateTimeNgayAD;
        private TextBox txtMaKM;
        private TextBox txtMaKH;
        private TextBox txtMaHoaDon;
        private TextBox txtGhiChu;
        private TextBox txtGTKM;
    }
}
