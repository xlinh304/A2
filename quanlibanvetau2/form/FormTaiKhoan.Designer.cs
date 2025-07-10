namespace quanlibanvetau2.form
{
    partial class FormTaiKhoan
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
            dgvTaiKhoan = new DataGridView();
            panel3 = new Panel();
            txtTimKiem = new TextBox();
            btnTroVe = new Button();
            btnTk = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            panel8 = new Panel();
            label5 = new Label();
            txtMaHK = new TextBox();
            label4 = new Label();
            txtMaNV = new TextBox();
            panel7 = new Panel();
            cboVaiTro = new ComboBox();
            label3 = new Label();
            panel6 = new Panel();
            txtMatKhau = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txtTenDangNhap = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(46, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1492, 881);
            panel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvTaiKhoan);
            panel4.Location = new Point(33, 486);
            panel4.Name = "panel4";
            panel4.Size = new Size(1406, 374);
            panel4.TabIndex = 2;
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(52, 35);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.RowHeadersWidth = 82;
            dgvTaiKhoan.Size = new Size(1321, 303);
            dgvTaiKhoan.TabIndex = 0;
            dgvTaiKhoan.SelectionChanged += dgvTaiKhoan_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTimKiem);
            panel3.Controls.Add(btnTroVe);
            panel3.Controls.Add(btnTk);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Location = new Point(925, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 407);
            panel3.TabIndex = 1;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10.875F);
            txtTimKiem.Location = new Point(24, 240);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(468, 47);
            txtTimKiem.TabIndex = 2;
            // 
            // btnTroVe
            // 
            btnTroVe.Location = new Point(156, 317);
            btnTroVe.Name = "btnTroVe";
            btnTroVe.Size = new Size(196, 73);
            btnTroVe.TabIndex = 5;
            btnTroVe.Text = "Trở Về";
            btnTroVe.UseVisualStyleBackColor = true;
            // 
            // btnTk
            // 
            btnTk.Location = new Point(285, 129);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(196, 73);
            btnTk.TabIndex = 4;
            btnTk.Text = "Tìm kiếm";
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(41, 129);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(196, 73);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(285, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(196, 73);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(41, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(196, 73);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(33, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 407);
            panel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(label5);
            panel8.Controls.Add(txtMaHK);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(txtMaNV);
            panel8.Location = new Point(17, 268);
            panel8.Name = "panel8";
            panel8.Size = new Size(749, 136);
            panel8.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F);
            label5.Location = new Point(23, 82);
            label5.Name = "label5";
            label5.Size = new Size(219, 40);
            label5.TabIndex = 4;
            label5.Text = "Mã Hành Khách";
            // 
            // txtMaHK
            // 
            txtMaHK.Font = new Font("Segoe UI", 10.875F);
            txtMaHK.Location = new Point(272, 82);
            txtMaHK.Multiline = true;
            txtMaHK.Name = "txtMaHK";
            txtMaHK.Size = new Size(463, 40);
            txtMaHK.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F);
            label4.Location = new Point(23, 14);
            label4.Name = "label4";
            label4.Size = new Size(199, 40);
            label4.TabIndex = 2;
            label4.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10.875F);
            txtMaNV.Location = new Point(272, 14);
            txtMaNV.Multiline = true;
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(463, 40);
            txtMaNV.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.Controls.Add(cboVaiTro);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(17, 185);
            panel7.Name = "panel7";
            panel7.Size = new Size(759, 68);
            panel7.TabIndex = 2;
            // 
            // cboVaiTro
            // 
            cboVaiTro.FormattingEnabled = true;
            cboVaiTro.Location = new Point(267, 14);
            cboVaiTro.Name = "cboVaiTro";
            cboVaiTro.Size = new Size(468, 40);
            cboVaiTro.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F);
            label3.Location = new Point(25, 14);
            label3.Name = "label3";
            label3.Size = new Size(102, 40);
            label3.TabIndex = 0;
            label3.Text = "Vai Trò";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtMatKhau);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(17, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(759, 78);
            panel6.TabIndex = 2;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 10.875F);
            txtMatKhau.Location = new Point(267, 18);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(468, 47);
            txtMatKhau.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 18);
            label2.Name = "label2";
            label2.Size = new Size(140, 40);
            label2.TabIndex = 0;
            label2.Text = "Mật Khẩu";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTenDangNhap);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(17, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(759, 78);
            panel5.TabIndex = 1;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 10.875F);
            txtTenDangNhap.Location = new Point(267, 18);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(468, 47);
            txtTenDangNhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(16, 18);
            label1.Name = "label1";
            label1.Size = new Size(214, 40);
            label1.TabIndex = 0;
            label1.Text = "Tên Đăng Nhập";
            // 
            // FormTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 929);
            Controls.Add(panel1);
            Name = "FormTaiKhoan";
            Text = "FormTaiKhoan";
            Load += FormTaiKhoan_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private DataGridView dgvTaiKhoan;
        private Panel panel3;
        private Button btnTk;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private Panel panel7;
        private Label label3;
        private Panel panel6;
        private TextBox txtMatKhau;
        private Label label2;
        private Panel panel5;
        private TextBox txtTenDangNhap;
        private Label label1;
        private Panel panel8;
        private TextBox txtMaNV;
        private Label label4;
        private Label label5;
        private TextBox txtMaHK;
        private ComboBox cboVaiTro;
        private TextBox txtTimKiem;
        private Button btnTroVe;
    }
}