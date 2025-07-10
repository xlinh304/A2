namespace quanlibanvetau2.form
{
    partial class FormHanhKhach
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
            dgvHanhKhach = new DataGridView();
            panel3 = new Panel();
            txtTk = new TextBox();
            button5 = new Button();
            btnTk = new Button();
            btnReset = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            panel8 = new Panel();
            txtDiaChi = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            txtDienThoai = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            txtCMND = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txtHoTen = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHanhKhach).BeginInit();
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
            panel1.Location = new Point(22, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(1597, 966);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvHanhKhach);
            panel4.Location = new Point(33, 579);
            panel4.Name = "panel4";
            panel4.Size = new Size(1406, 374);
            panel4.TabIndex = 2;
            // 
            // dgvHanhKhach
            // 
            dgvHanhKhach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHanhKhach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHanhKhach.Location = new Point(52, 35);
            dgvHanhKhach.Name = "dgvHanhKhach";
            dgvHanhKhach.RowHeadersWidth = 82;
            dgvHanhKhach.Size = new Size(1321, 303);
            dgvHanhKhach.TabIndex = 0;
            dgvHanhKhach.SelectionChanged += dgvHanhKhach_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtTk);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(btnTk);
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(btnXoa);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(btnThem);
            panel3.Location = new Point(1004, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(504, 424);
            panel3.TabIndex = 1;
            // 
            // txtTk
            // 
            txtTk.Font = new Font("Segoe UI", 10.875F);
            txtTk.Location = new Point(13, 326);
            txtTk.Multiline = true;
            txtTk.Name = "txtTk";
            txtTk.Size = new Size(478, 78);
            txtTk.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(285, 231);
            button5.Name = "button5";
            button5.Size = new Size(196, 73);
            button5.TabIndex = 5;
            button5.Text = "trở về";
            button5.UseVisualStyleBackColor = true;
            // 
            // btnTk
            // 
            btnTk.Location = new Point(41, 231);
            btnTk.Name = "btnTk";
            btnTk.Size = new Size(196, 73);
            btnTk.TabIndex = 4;
            btnTk.Text = "Tìm kiếm";
            btnTk.UseVisualStyleBackColor = true;
            btnTk.Click += btnTk_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(285, 129);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(196, 73);
            btnReset.TabIndex = 3;
            btnReset.Text = "reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
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
            panel2.Size = new Size(796, 546);
            panel2.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(txtDiaChi);
            panel8.Controls.Add(label4);
            panel8.Location = new Point(17, 421);
            panel8.Name = "panel8";
            panel8.Size = new Size(759, 99);
            panel8.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 10.875F);
            txtDiaChi.Location = new Point(267, 18);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(489, 78);
            txtDiaChi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.875F);
            label4.Location = new Point(25, 34);
            label4.Name = "label4";
            label4.Size = new Size(108, 40);
            label4.TabIndex = 0;
            label4.Text = "Địa Chỉ";
            // 
            // panel7
            // 
            panel7.Controls.Add(txtDienThoai);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(17, 292);
            panel7.Name = "panel7";
            panel7.Size = new Size(759, 99);
            panel7.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Font = new Font("Segoe UI", 10.875F);
            txtDienThoai.Location = new Point(267, 18);
            txtDienThoai.Multiline = true;
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(489, 78);
            txtDienThoai.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F);
            label3.Location = new Point(25, 34);
            label3.Name = "label3";
            label3.Size = new Size(153, 40);
            label3.TabIndex = 0;
            label3.Text = "Điện Thoại";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtCMND);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(17, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(759, 99);
            panel6.TabIndex = 2;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI", 10.875F);
            txtCMND.Location = new Point(267, 18);
            txtCMND.Multiline = true;
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(489, 78);
            txtCMND.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(103, 40);
            label2.TabIndex = 0;
            label2.Text = "CMND";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtHoTen);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(17, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(759, 99);
            panel5.TabIndex = 1;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 10.875F);
            txtHoTen.Location = new Point(267, 18);
            txtHoTen.Multiline = true;
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(489, 78);
            txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 40);
            label1.TabIndex = 0;
            label1.Text = "Họ Tên";
            // 
            // FormHanhKhach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1631, 1024);
            Controls.Add(panel1);
            Name = "FormHanhKhach";
            Text = "FormHanhKhach";
            Load += FormHanhKhach_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHanhKhach).EndInit();
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
        private DataGridView dgvHanhKhach;
        private Panel panel3;
        private TextBox txtTk;
        private Button button5;
        private Button btnTk;
        private Button btnReset;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private Panel panel8;
        private TextBox txtDiaChi;
        private Label label4;
        private Panel panel7;
        private TextBox txtDienThoai;
        private Label label3;
        private Panel panel6;
        private TextBox txtCMND;
        private Label label2;
        private Panel panel5;
        private TextBox txtHoTen;
        private Label label1;
    }
}