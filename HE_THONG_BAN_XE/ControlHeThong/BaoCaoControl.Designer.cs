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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(422, 32);
            label1.TabIndex = 0;
            label1.Text = "Báo cáo kinh doanh cửa hàng ô tô";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(839, 25);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 1;
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
            label3.Location = new Point(52, 69);
            label3.Name = "label3";
            label3.Size = new Size(122, 26);
            label3.TabIndex = 0;
            label3.Text = "Doanh thu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.Location = new Point(459, 69);
            label4.Name = "label4";
            label4.Size = new Size(186, 26);
            label4.TabIndex = 1;
            label4.Text = "Số lượng tồn kho: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.Location = new Point(459, 279);
            label5.Name = "label5";
            label5.Size = new Size(165, 26);
            label5.TabIndex = 2;
            label5.Text = "Tổng nhân viên:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.Location = new Point(52, 493);
            label6.Name = "label6";
            label6.Size = new Size(186, 26);
            label6.TabIndex = 3;
            label6.Text = "Tổng khách hàng: ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.PowderBlue;
            panel1.Location = new Point(52, 308);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 153);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PowderBlue;
            panel2.Location = new Point(459, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(357, 153);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PowderBlue;
            panel3.Location = new Point(52, 522);
            panel3.Name = "panel3";
            panel3.Size = new Size(357, 153);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PowderBlue;
            panel4.Location = new Point(459, 308);
            panel4.Name = "panel4";
            panel4.Size = new Size(357, 153);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.BackColor = Color.PowderBlue;
            panel5.Location = new Point(52, 94);
            panel5.Name = "panel5";
            panel5.Size = new Size(357, 153);
            panel5.TabIndex = 8;
            //panel5.Paint += this.panel5_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F);
            label7.Location = new Point(52, 279);
            label7.Name = "label7";
            label7.Size = new Size(219, 26);
            label7.TabIndex = 9;
            label7.Text = "Tổng số xe bán được :";
            label7.Click += label7_Click;
            // 
            // BaoCaoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "BaoCaoControl";
            Size = new Size(1147, 721);
            Load += BaoCaoControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
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
    }
}
