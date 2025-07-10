namespace quanlibanvetau2.form
{
    partial class FormVeTau
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
            panel4 = new Panel();
            dgvVeTau = new DataGridView();
            panel3 = new Panel();
            txtTk = new TextBox();
            btnTk = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            panel2 = new Panel();
            panel8 = new Panel();
            label4 = new Label();
            dtpNgayDat = new DateTimePicker();
            panel6 = new Panel();
            txtTrangThai = new TextBox();
            label2 = new Label();
            panel11 = new Panel();
            txtMaHanhKhach = new TextBox();
            label9 = new Label();
            panel10 = new Panel();
            txtMaChuyen = new TextBox();
            label8 = new Label();
            panel9 = new Panel();
            txtGiaVe = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            txtSoGhe = new TextBox();
            label3 = new Label();
            panel5 = new Panel();
            txtMaVe = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVeTau).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(38, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1593, 1060);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvVeTau);
            panel4.Location = new Point(30, 565);
            panel4.Name = "panel4";
            panel4.Size = new Size(1540, 492);
            panel4.TabIndex = 2;
            // 
            // dgvVeTau
            // 
            dgvVeTau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeTau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVeTau.Location = new Point(3, 35);
            dgvVeTau.Name = "dgvVeTau";
            dgvVeTau.RowHeadersWidth = 82;
            dgvVeTau.Size = new Size(1508, 454);
            dgvVeTau.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTk);
            panel3.Controls.Add(btnTk);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Location = new Point(33, 443);
            panel3.Name = "panel3";
            panel3.Size = new Size(1537, 104);
            panel3.TabIndex = 1;
            // 
            // txtTk
            // 
            txtTk.Font = new Font("Segoe UI", 10.875F);
            txtTk.Location = new Point(932, 15);
            txtTk.Multiline = true;
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(536, 73);
            txtTk.TabIndex = 4;
            // 
            // btnTk
            // 
            btnTk.Location = new Point(670, 15);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(196, 73);
            btnTk.TabIndex = 4;
            btnTk.Text = "Tìm kiếm";
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(397, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(196, 73);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click_1;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(48, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(260, 73);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(33, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1537, 410);
            panel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Controls.Add(dtpNgayDat);
            panel8.Location = new Point(20, 298);
            panel8.Name = "panel8";
            panel8.Size = new Size(707, 87);
            panel8.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(25, 26);
            label4.Name = "label4";
            label4.Size = new Size(152, 45);
            label4.TabIndex = 1;
            label4.Text = "Ngày Dặt";
            // 
            // dtpNgayDat
            // 
            dtpNgayDat.Location = new Point(215, 26);
            dtpNgayDat.Name = "dtpNgayDat";
            dtpNgayDat.Size = new Size(462, 39);
            dtpNgayDat.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTrangThai);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(979, 167);
            panel6.Name = "panel6";
            panel6.Size = new Size(486, 99);
            panel6.TabIndex = 4;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Font = new Font("Segoe UI", 10.875F);
            txtTrangThai.Location = new Point(237, 21);
            txtTrangThai.Multiline = true;
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(195, 78);
            txtTrangThai.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(148, 40);
            label2.TabIndex = 0;
            label2.Text = "Trạng Thái";
            // 
            // panel11
            // 
            panel11.Controls.Add(txtMaHanhKhach);
            panel11.Controls.Add(label9);
            panel11.Location = new Point(1022, 38);
            panel11.Name = "panel11";
            panel11.Size = new Size(502, 99);
            panel11.TabIndex = 4;
            // 
            // txtMaHanhKhach
            // 
            txtMaHanhKhach.Font = new Font("Segoe UI", 10.875F);
            txtMaHanhKhach.Location = new Point(264, 18);
            txtMaHanhKhach.Multiline = true;
            txtMaHanhKhach.Name = "txtMaHanhKhach";
            txtMaHanhKhach.Size = new Size(195, 78);
            txtMaHanhKhach.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.875F);
            label9.Location = new Point(25, 34);
            label9.Name = "label9";
            label9.Size = new Size(219, 40);
            label9.TabIndex = 0;
            label9.Text = "Mã Hành Khách";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtMaChuyen);
            panel10.Controls.Add(label8);
            panel10.Location = new Point(508, 38);
            panel10.Name = "panel10";
            panel10.Size = new Size(446, 99);
            panel10.TabIndex = 5;
            // 
            // txtMaChuyen
            // 
            txtMaChuyen.Font = new Font("Segoe UI", 10.875F);
            txtMaChuyen.Location = new Point(215, 18);
            txtMaChuyen.Multiline = true;
            txtMaChuyen.Name = "txtMaChuyen";
            txtMaChuyen.Size = new Size(195, 78);
            txtMaChuyen.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.875F);
            label8.Location = new Point(25, 34);
            label8.Name = "label8";
            label8.Size = new Size(161, 40);
            label8.TabIndex = 0;
            label8.Text = "Mã Chuyến";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtGiaVe);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(508, 164);
            panel9.Name = "panel9";
            panel9.Size = new Size(400, 99);
            panel9.TabIndex = 3;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Font = new Font("Segoe UI", 10.875F);
            txtGiaVe.Location = new Point(169, 18);
            txtGiaVe.Multiline = true;
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(195, 78);
            txtGiaVe.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.875F);
            label7.Location = new Point(25, 34);
            label7.Name = "label7";
            label7.Size = new Size(98, 40);
            label7.TabIndex = 0;
            label7.Text = "Giá Vé";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtSoGhe);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(20, 167);
            panel7.Name = "panel7";
            panel7.Size = new Size(400, 99);
            panel7.TabIndex = 2;
            // 
            // txtSoGhe
            // 
            txtSoGhe.Font = new Font("Segoe UI", 10.875F);
            txtSoGhe.Location = new Point(169, 18);
            txtSoGhe.Multiline = true;
            txtSoGhe.Name = "txtSoGhe";
            txtSoGhe.Size = new Size(195, 78);
            txtSoGhe.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F);
            label3.Location = new Point(25, 34);
            label3.Name = "label3";
            label3.Size = new Size(108, 40);
            label3.TabIndex = 0;
            label3.Text = "Số Ghế";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtMaVe);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(20, 38);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 99);
            panel5.TabIndex = 1;
            // 
            // txtMaVe
            // 
            txtMaVe.Font = new Font("Segoe UI", 10.875F);
            txtMaVe.Location = new Point(169, 18);
            txtMaVe.Multiline = true;
            txtMaVe.Name = "txtMaVe";
            txtMaVe.Size = new Size(206, 78);
            txtMaVe.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(97, 40);
            label1.TabIndex = 0;
            label1.Text = "Mã Vé";
            // 
            // FormVeTau
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1659, 1092);
            Controls.Add(panel1);
            Name = "FormVeTau";
            Text = "FormVeTau";
            Load += FormVeTau_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVeTau).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private DataGridView dgvVeTau;
        private Panel panel3;
        private TextBox txtTk;
        private Button btnTk;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private Panel panel6;
        private TextBox txtTrangThai;
        private Label label2;
        private Panel panel11;
        private TextBox txtMaHanhKhach;
        private Label label9;
        private Panel panel10;
        private TextBox txtMaChuyen;
        private Label label8;
        private Panel panel9;
        private TextBox txtGiaVe;
        private Label label7;
        private Panel panel7;
        private TextBox txtSoGhe;
        private Label label3;
        private Panel panel5;
        private TextBox txtMaVe;
        private Label label1;
        private Panel panel8;
        private Label label4;
        private DateTimePicker dtpNgayDat;
    }
}