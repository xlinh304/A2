namespace quanlibanvetau2.form
{
    partial class FormChuyenTau
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
            dgvChuyenTau = new DataGridView();
            panel3 = new Panel();
            txtTk = new TextBox();
            btnTk = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            panel9 = new Panel();
            txtGiaVe = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            dtpDen = new DateTimePicker();
            dtpDI = new DateTimePicker();
            label6 = new Label();
            label4 = new Label();
            panel7 = new Panel();
            txtSoGhe = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            txtGaDen = new TextBox();
            label5 = new Label();
            txtGaDi = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txtTenTau = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChuyenTau).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel9.SuspendLayout();
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
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1621, 1004);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvChuyenTau);
            panel4.Location = new Point(33, 602);
            panel4.Name = "panel4";
            panel4.Size = new Size(1540, 374);
            panel4.TabIndex = 2;
            // 
            // dgvChuyenTau
            // 
            dgvChuyenTau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChuyenTau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChuyenTau.Location = new Point(3, 35);
            dgvChuyenTau.Name = "dgvChuyenTau";
            dgvChuyenTau.RowHeadersWidth = 82;
            dgvChuyenTau.Size = new Size(1508, 303);
            dgvChuyenTau.TabIndex = 0;
            dgvChuyenTau.SelectionChanged += dgvChuyenTau_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTk);
            panel3.Controls.Add(btnTk);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Location = new Point(36, 473);
            panel3.Name = "panel3";
            panel3.Size = new Size(1537, 104);
            panel3.TabIndex = 1;
            // 
            // txtTk
            // 
            txtTk.Font = new Font("Segoe UI", 10.875F);
            txtTk.Location = new Point(1108, 15);
            txtTk.Multiline = true;
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(400, 73);
            txtTk.TabIndex = 4;
            // 
            // btnTk
            // 
            btnTk.Location = new Point(850, 15);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(196, 73);
            btnTk.TabIndex = 4;
            btnTk.Text = "Tìm kiếm";
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(551, 15);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(196, 73);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(283, 15);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(196, 73);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(17, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(196, 73);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm ";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(33, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(1537, 423);
            panel2.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.Controls.Add(txtGiaVe);
            panel9.Controls.Add(label7);
            panel9.Location = new Point(506, 307);
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
            // panel8
            // 
            panel8.Controls.Add(dtpDen);
            panel8.Controls.Add(dtpDI);
            panel8.Controls.Add(label6);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(20, 180);
            panel8.Name = "panel8";
            panel8.Size = new Size(1029, 99);
            panel8.TabIndex = 3;
            // 
            // dtpDen
            // 
            dtpDen.CalendarFont = new Font("Segoe UI", 12F);
            dtpDen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDen.Format = DateTimePickerFormat.Custom;
            dtpDen.Location = new Point(753, 34);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(260, 39);
            dtpDen.TabIndex = 3;
            // 
            // dtpDI
            // 
            dtpDI.CalendarFont = new Font("Segoe UI", 12F);
            dtpDI.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpDI.Format = DateTimePickerFormat.Custom;
            dtpDI.Location = new Point(204, 35);
            dtpDI.Name = "dtpDI";
            dtpDI.Size = new Size(272, 39);
            dtpDI.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.875F);
            label6.Location = new Point(526, 34);
            label6.Name = "label6";
            label6.Size = new Size(204, 40);
            label6.TabIndex = 1;
            label6.Text = "Thời Gian Điến";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F);
            label4.Location = new Point(25, 34);
            label4.Name = "label4";
            label4.Size = new Size(173, 40);
            label4.TabIndex = 0;
            label4.Text = "Thời Gian Đi";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtSoGhe);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(20, 307);
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
            // panel6
            // 
            panel6.Controls.Add(txtGaDen);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtGaDi);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(546, 38);
            panel6.Name = "panel6";
            panel6.Size = new Size(965, 99);
            panel6.TabIndex = 2;
            // 
            // txtGaDen
            // 
            txtGaDen.Font = new Font("Segoe UI", 10.875F);
            txtGaDen.Location = new Point(698, 18);
            txtGaDen.Multiline = true;
            txtGaDen.Name = "txtGaDen";
            txtGaDen.Size = new Size(246, 78);
            txtGaDen.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F);
            label5.Location = new Point(562, 34);
            label5.Name = "label5";
            label5.Size = new Size(119, 40);
            label5.TabIndex = 2;
            label5.Text = "Ga Đến ";
            // 
            // txtGaDi
            // 
            txtGaDi.Font = new Font("Segoe UI", 10.875F);
            txtGaDi.Location = new Point(195, 18);
            txtGaDi.Multiline = true;
            txtGaDi.Name = "txtGaDi";
            txtGaDi.Size = new Size(329, 78);
            txtGaDi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 21);
            label2.Name = "label2";
            label2.Size = new Size(88, 40);
            label2.TabIndex = 0;
            label2.Text = "Ga ĐI";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtTenTau);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(20, 38);
            panel5.Name = "panel5";
            panel5.Size = new Size(438, 99);
            panel5.TabIndex = 1;
            // 
            // txtTenTau
            // 
            txtTenTau.Font = new Font("Segoe UI", 10.875F);
            txtTenTau.Location = new Point(194, 18);
            txtTenTau.Multiline = true;
            txtTenTau.Name = "txtTenTau";
            txtTenTau.Size = new Size(206, 78);
            txtTenTau.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(111, 40);
            label1.TabIndex = 0;
            label1.Text = "Tên Tàu";
            // 
            // FormChuyenTau
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 1028);
            Controls.Add(panel1);
            Name = "FormChuyenTau";
            Text = "FormChuyenTau";
            Load += FormChuyenTau_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChuyenTau).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
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
        private DataGridView dgvChuyenTau;
        private Panel panel3;
        private Button btnTk;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private Panel panel7;
        private TextBox txtSoGhe;
        private Label label3;
        private Panel panel6;
        private TextBox txtGaDi;
        private Label label2;
        private Panel panel5;
        private TextBox txtTenTau;
        private Label label1;
        private Panel panel8;
        private DateTimePicker dtpDI;
        private Label label6;
        private Label label4;
        private TextBox txtGaDen;
        private Label label5;
        private DateTimePicker dtpDen;
        private TextBox txtTk;
        private Panel panel9;
        private TextBox txtGiaVe;
        private Label label7;
    }
}