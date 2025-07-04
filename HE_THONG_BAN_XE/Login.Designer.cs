namespace HE_THONG_BAN_XE
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_Name = new TextBox();
            txt_Pass = new TextBox();
            button1 = new Button();
            button3 = new Button();
            radioButton_QuanLy = new RadioButton();
            radioButton_NhanVien = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 30);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 73);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu :";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(156, 23);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(211, 27);
            txt_Name.TabIndex = 2;
            // 
            // txt_Pass
            // 
            txt_Pass.Location = new Point(156, 70);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(211, 27);
            txt_Pass.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(25, 169);
            button1.Name = "button1";
            button1.Size = new Size(150, 29);
            button1.TabIndex = 4;
            button1.Text = "Xác Nhận";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(202, 169);
            button3.Name = "button3";
            button3.Size = new Size(150, 29);
            button3.TabIndex = 6;
            button3.Text = "Thoát";
            button3.UseVisualStyleBackColor = true;
            // 
            // radioButton_QuanLy
            // 
            radioButton_QuanLy.AutoSize = true;
            radioButton_QuanLy.Location = new Point(234, 126);
            radioButton_QuanLy.Name = "radioButton_QuanLy";
            radioButton_QuanLy.Size = new Size(82, 24);
            radioButton_QuanLy.TabIndex = 7;
            radioButton_QuanLy.TabStop = true;
            radioButton_QuanLy.Text = "Quản Lý";
            radioButton_QuanLy.UseVisualStyleBackColor = true;
            // 
            // radioButton_NhanVien
            // 
            radioButton_NhanVien.AutoSize = true;
            radioButton_NhanVien.Location = new Point(60, 126);
            radioButton_NhanVien.Name = "radioButton_NhanVien";
            radioButton_NhanVien.Size = new Size(96, 24);
            radioButton_NhanVien.TabIndex = 8;
            radioButton_NhanVien.TabStop = true;
            radioButton_NhanVien.Text = "Nhân viên";
            radioButton_NhanVien.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 224);
            Controls.Add(radioButton_NhanVien);
            Controls.Add(radioButton_QuanLy);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txt_Pass);
            Controls.Add(txt_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Name;
        private TextBox txt_Pass;
        private Button button1;
        private Button button3;
        private RadioButton radioButton_QuanLy;
        private RadioButton radioButton_NhanVien;
    }
}
