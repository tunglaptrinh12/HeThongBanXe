namespace HE_THONG_BAN_XE.ControlHeThong
{
    partial class BaoCaoControl
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
            dtNgay = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            lblXeBan = new Label();
            panel2 = new Panel();
            lblTonKho = new Label();
            panel3 = new Panel();
            lblKhachHang = new Label();
            panel4 = new Panel();
            lblNhanVien = new Label();
            panel5 = new Panel();
            lblDoanhThu = new Label();
            label7 = new Label();
            dgvXeBan = new DataGridView();
            label8 = new Label();
            btnTaoBaoCao = new Button();
            btnXuatBaoCao = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeBan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(20, 27);
            label1.Name = "label1";
            label1.Size = new Size(512, 38);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo kinh doanh cửa hàng ô tô";
            // 
            // dtNgay
            // 
            dtNgay.Location = new Point(839, 25);
            dtNgay.Name = "dtNgay";
            dtNgay.Size = new Size(250, 27);
            dtNgay.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(760, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 2;
            label2.Text = "Ngày :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.Location = new Point(19, 119);
            label3.Name = "label3";
            label3.Size = new Size(122, 26);
            label3.TabIndex = 0;
            label3.Text = "Doanh thu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(19, 460);
            label4.Name = "label4";
            label4.Size = new Size(186, 26);
            label4.TabIndex = 1;
            label4.Text = "Số lượng tồn kho: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(19, 568);
            label5.Name = "label5";
            label5.Size = new Size(165, 26);
            label5.TabIndex = 2;
            label5.Text = "Tổng nhân viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(19, 348);
            label6.Name = "label6";
            label6.Size = new Size(186, 26);
            label6.TabIndex = 3;
            label6.Text = "Tổng khách hàng: ";
            label6.Click += label6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Controls.Add(lblXeBan);
            panel1.Location = new Point(19, 263);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 63);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // lblXeBan
            // 
            lblXeBan.AutoSize = true;
            lblXeBan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblXeBan.Location = new Point(4, 20);
            lblXeBan.Name = "lblXeBan";
            lblXeBan.Size = new Size(47, 25);
            lblXeBan.TabIndex = 1;
            lblXeBan.Text = "Null";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Controls.Add(lblTonKho);
            panel2.Location = new Point(19, 489);
            panel2.Name = "panel2";
            panel2.Size = new Size(208, 63);
            panel2.TabIndex = 5;
            // 
            // lblTonKho
            // 
            lblTonKho.AutoSize = true;
            lblTonKho.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTonKho.Location = new Point(4, 20);
            lblTonKho.Name = "lblTonKho";
            lblTonKho.Size = new Size(47, 25);
            lblTonKho.TabIndex = 1;
            lblTonKho.Text = "Null";
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Controls.Add(lblKhachHang);
            panel3.Location = new Point(19, 377);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 63);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // lblKhachHang
            // 
            lblKhachHang.AutoSize = true;
            lblKhachHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKhachHang.Location = new Point(4, 22);
            lblKhachHang.Name = "lblKhachHang";
            lblKhachHang.Size = new Size(47, 25);
            lblKhachHang.TabIndex = 1;
            lblKhachHang.Text = "Null";
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Controls.Add(lblNhanVien);
            panel4.Location = new Point(19, 597);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 63);
            panel4.TabIndex = 7;
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNhanVien.Location = new Point(4, 20);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(47, 25);
            lblNhanVien.TabIndex = 1;
            lblNhanVien.Text = "Null";
            // 
            // panel5
            // 
            panel5.BackColor = Color.PowderBlue;
            panel5.Controls.Add(lblDoanhThu);
            panel5.Location = new Point(20, 148);
            panel5.Name = "panel5";
            panel5.Size = new Size(208, 63);
            panel5.TabIndex = 8;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDoanhThu.Location = new Point(3, 19);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(47, 25);
            lblDoanhThu.TabIndex = 0;
            lblDoanhThu.Text = "Null";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(19, 234);
            label7.Name = "label7";
            label7.Size = new Size(219, 26);
            label7.TabIndex = 9;
            label7.Text = "Tổng số xe bán được :";
            label7.Click += label7_Click;
            // 
            // dgvXeBan
            // 
            dgvXeBan.BackgroundColor = Color.FloralWhite;
            dgvXeBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvXeBan.GridColor = SystemColors.HighlightText;
            dgvXeBan.Location = new Point(274, 148);
            dgvXeBan.Name = "dgvXeBan";
            dgvXeBan.RowHeadersWidth = 51;
            dgvXeBan.Size = new Size(838, 446);
            dgvXeBan.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(464, 112);
            label8.Name = "label8";
            label8.Size = new Size(480, 33);
            label8.TabIndex = 11;
            label8.Text = "Bảng báo cáo số lượng xe bán trong ngày ";
            // 
            // btnTaoBaoCao
            // 
            btnTaoBaoCao.Cursor = Cursors.Hand;
            btnTaoBaoCao.Font = new Font("Times New Roman", 10.2F);
            btnTaoBaoCao.Location = new Point(816, 617);
            btnTaoBaoCao.Name = "btnTaoBaoCao";
            btnTaoBaoCao.Size = new Size(128, 43);
            btnTaoBaoCao.TabIndex = 12;
            btnTaoBaoCao.Text = "Tạo báo cáo\r\n";
            btnTaoBaoCao.UseVisualStyleBackColor = true;
            btnTaoBaoCao.Click += btnTaoBaoCao_Click;
            // 
            // btnXuatBaoCao
            // 
            btnXuatBaoCao.Cursor = Cursors.Hand;
            btnXuatBaoCao.Font = new Font("Times New Roman", 10.2F);
            btnXuatBaoCao.Location = new Point(984, 617);
            btnXuatBaoCao.Name = "btnXuatBaoCao";
            btnXuatBaoCao.Size = new Size(128, 43);
            btnXuatBaoCao.TabIndex = 13;
            btnXuatBaoCao.Text = "Xuất báo cáo";
            btnXuatBaoCao.UseVisualStyleBackColor = true;
            btnXuatBaoCao.Click += btnXuatBaoCao_Click;
            // 
            // BaoCaoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(btnXuatBaoCao);
            Controls.Add(btnTaoBaoCao);
            Controls.Add(label8);
            Controls.Add(dgvXeBan);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtNgay);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "BaoCaoControl";
            Size = new Size(1147, 721);
            Load += BaoCaoControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvXeBan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtNgay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label label7;
        private DataGridView dgvXeBan;
        private Label label8;
        private Button btnTaoBaoCao;
        private Button btnXuatBaoCao;
        private Label lblXeBan;
        private Label lblTonKho;
        private Label lblKhachHang;
        private Label lblNhanVien;
        private Label lblDoanhThu;
    }
}
