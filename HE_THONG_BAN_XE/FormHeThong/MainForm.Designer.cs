namespace HE_THONG_BAN_XE.FormHeThong
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            Nut_Exit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 255);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(Nut_Exit);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.Indigo;
            panel1.Location = new Point(1, 2);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1221, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 255, 255);
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(0, 17);
            label1.Name = "label1";
            label1.Size = new Size(329, 34);
            label1.TabIndex = 1;
            label1.Text = "HỆ THỐNG QUẢN LÝ BÁN XE";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(1, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(1221, 585);
            panel2.TabIndex = 1;
            // 
            // Nut_Exit
            // 
            Nut_Exit.BackColor = Color.Red;
            Nut_Exit.Location = new Point(1088, 53);
            Nut_Exit.Name = "Nut_Exit";
            Nut_Exit.Size = new Size(126, 39);
            Nut_Exit.TabIndex = 2;
            Nut_Exit.Text = "Đăng xuất";
            Nut_Exit.UseVisualStyleBackColor = false;
            Nut_Exit.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 685);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button Nut_Exit;
    }
}