﻿namespace HE_THONG_BAN_XE.FormHeThong
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
            panner_chucnang = new Panel();
            Nut_Exit = new Button();
            label1 = new Label();
            Menu_Pannel = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            panner_chucnang.SuspendLayout();
            Menu_Pannel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panner_chucnang
            // 
            panner_chucnang.BackColor = Color.White;
            panner_chucnang.BorderStyle = BorderStyle.Fixed3D;
            panner_chucnang.Controls.Add(Nut_Exit);
            panner_chucnang.ForeColor = Color.Indigo;
            panner_chucnang.Location = new Point(1, 83);
            panner_chucnang.Margin = new Padding(0);
            panner_chucnang.Name = "panner_chucnang";
            panner_chucnang.Size = new Size(179, 721);
            panner_chucnang.TabIndex = 0;
            panner_chucnang.Paint += panel1_Paint;
            // 
            // Nut_Exit
            // 
            Nut_Exit.BackColor = Color.Red;
            Nut_Exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Nut_Exit.ForeColor = Color.GhostWhite;
            Nut_Exit.Location = new Point(3, 634);
            Nut_Exit.Name = "Nut_Exit";
            Nut_Exit.Size = new Size(169, 74);
            Nut_Exit.TabIndex = 2;
            Nut_Exit.Text = "Đăng xuất";
            Nut_Exit.UseVisualStyleBackColor = false;
            Nut_Exit.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(240, 244, 248);
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(13, 71, 161);
            label1.Location = new Point(464, 14);
            label1.Name = "label1";
            label1.Size = new Size(430, 48);
            label1.TabIndex = 1;
            label1.Text = "HỆ THỐNG QUẢN LÝ BÁN XE";
            label1.Click += label1_Click;
            // 
            // Menu_Pannel
            // 
            Menu_Pannel.BackColor = Color.White;
            Menu_Pannel.BorderStyle = BorderStyle.Fixed3D;
            Menu_Pannel.Controls.Add(label2);
            Menu_Pannel.Location = new Point(183, 83);
            Menu_Pannel.Name = "Menu_Pannel";
            Menu_Pannel.Size = new Size(1147, 721);
            Menu_Pannel.TabIndex = 2;
            Menu_Pannel.Paint += Menu_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 298);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(240, 244, 248);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(1, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1329, 75);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 805);
            Controls.Add(panel2);
            Controls.Add(Menu_Pannel);
            Controls.Add(panner_chucnang);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load_1;
            panner_chucnang.ResumeLayout(false);
            Menu_Pannel.ResumeLayout(false);
            Menu_Pannel.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }
        // Add this event handler method to fix CS0103
        private void button1_Click(object sender, EventArgs e)
        {
            // Hide MainForm and show LoginForm
            this.Hide();
            var loginForm = new Login();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                this.Show(); // Hiện lại MainForm
            }
            else
            {
                Application.Exit(); // Nếu không đăng nhập, thoát hẳn
            }
        }
        #endregion

        private Panel panner_chucnang;
        private Label label1;
        private Button Nut_Exit;
        private Panel Menu_Pannel;
        private Panel panel2;
        private Label label2;
    }
}