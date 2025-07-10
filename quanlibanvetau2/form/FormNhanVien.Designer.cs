namespace quanlibanvetau2.form
{
    partial class FormNhanVien
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
            dgvNhanvien = new DataGridView();
            panel3 = new Panel();
            txtTk = new TextBox();
            button5 = new Button();
            btnTk = new Button();
            btnReset = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel2 = new Panel();
            panel7 = new Panel();
            txtSdt = new TextBox();
            label3 = new Label();
            panel6 = new Panel();
            txtTennv = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            txtManv = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Location = new Point(64, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(1492, 881);
            panel1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvNhanvien);
            panel4.Location = new Point(33, 486);
            panel4.Name = "panel4";
            panel4.Size = new Size(1406, 374);
            panel4.TabIndex = 2;
            // 
            // dgvNhanvien
            // 
            dgvNhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanvien.Location = new Point(52, 35);
            dgvNhanvien.Name = "dgvNhanvien";
            dgvNhanvien.RowHeadersWidth = 82;
            dgvNhanvien.Size = new Size(1321, 303);
            dgvNhanvien.TabIndex = 0;
            dgvNhanvien.SelectionChanged += dgvNhanvien_SelectionChanged;
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
            panel3.Location = new Point(925, 27);
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
            button5.Click += button5_Click;
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
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(33, 27);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 424);
            panel2.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtSdt);
            panel7.Controls.Add(label3);
            panel7.Location = new Point(17, 292);
            panel7.Name = "panel7";
            panel7.Size = new Size(759, 99);
            panel7.TabIndex = 2;
            // 
            // txtSdt
            // 
            txtSdt.Font = new Font("Segoe UI", 10.875F);
            txtSdt.Location = new Point(267, 18);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(489, 78);
            txtSdt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.875F);
            label3.Location = new Point(25, 34);
            label3.Name = "label3";
            label3.Size = new Size(193, 40);
            label3.TabIndex = 0;
            label3.Text = "Số Điện Thoại";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtTennv);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(17, 151);
            panel6.Name = "panel6";
            panel6.Size = new Size(759, 99);
            panel6.TabIndex = 2;
            // 
            // txtTennv
            // 
            txtTennv.Font = new Font("Segoe UI", 10.875F);
            txtTennv.Location = new Point(267, 18);
            txtTennv.Multiline = true;
            txtTennv.Name = "txtTennv";
            txtTennv.Size = new Size(489, 78);
            txtTennv.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(106, 40);
            label2.TabIndex = 0;
            label2.Text = "Họ Tên";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtManv);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(17, 17);
            panel5.Name = "panel5";
            panel5.Size = new Size(759, 99);
            panel5.TabIndex = 1;
            // 
            // txtManv
            // 
            txtManv.Font = new Font("Segoe UI", 10.875F);
            txtManv.Location = new Point(267, 18);
            txtManv.Multiline = true;
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(489, 78);
            txtManv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 0;
            label1.Text = "Mã Nhân Viên";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1616, 978);
            Controls.Add(panel1);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            Load += FormNhanVien_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvNhanvien).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
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
        private DataGridView dgvNhanvien;
        private Panel panel3;
        private TextBox txtTk;
        private Button button5;
        private Button btnTk;
        private Button btnReset;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel2;
        private Panel panel7;
        private TextBox txtSdt;
        private Label label3;
        private Panel panel6;
        private TextBox txtTennv;
        private Label label2;
        private Panel panel5;
        private TextBox txtManv;
        private Label label1;
    }
}