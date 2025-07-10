namespace quanlibanvetau2.form
{
    partial class FormDatVe
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
            panel8 = new Panel();
            dgvChuyenTau = new DataGridView();
            label7 = new Label();
            panel2 = new Panel();
            btnThoat = new Button();
            btnReset = new Button();
            btnDat = new Button();
            panel7 = new Panel();
            txtGiaVe = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            cboSoGhe = new ComboBox();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel3 = new Panel();
            cboMaChuyenTau = new ComboBox();
            label1 = new Label();
            panel6 = new Panel();
            txtGaDen = new TextBox();
            label5 = new Label();
            txtGaDi = new TextBox();
            label2 = new Label();
            btnVeCuaToi = new Button();
            panel1.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChuyenTau).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1615, 960);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvChuyenTau);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(22, 559);
            panel8.Name = "panel8";
            panel8.Size = new Size(1589, 401);
            panel8.TabIndex = 8;
            // 
            // dgvChuyenTau
            // 
            dgvChuyenTau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChuyenTau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChuyenTau.Location = new Point(3, 74);
            dgvChuyenTau.Name = "dgvChuyenTau";
            dgvChuyenTau.RowHeadersWidth = 82;
            dgvChuyenTau.Size = new Size(1583, 314);
            dgvChuyenTau.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(346, 45);
            label7.TabIndex = 0;
            label7.Text = "Danh sách chuyến tàu: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnVeCuaToi);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(btnDat);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(22, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(1589, 512);
            panel2.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(1343, 138);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(231, 98);
            btnThoat.TabIndex = 10;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(1343, 22);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(231, 93);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDat
            // 
            btnDat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDat.Location = new Point(1081, 22);
            btnDat.Name = "btnDat";
            btnDat.Size = new Size(231, 98);
            btnDat.TabIndex = 8;
            btnDat.Text = "Đặt";
            btnDat.UseVisualStyleBackColor = true;
            btnDat.Click += btnDat_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtGiaVe);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(703, 394);
            panel7.Name = "panel7";
            panel7.Size = new Size(609, 102);
            panel7.TabIndex = 7;
            // 
            // txtGiaVe
            // 
            txtGiaVe.Font = new Font("Segoe UI", 10.875F);
            txtGiaVe.Location = new Point(190, 21);
            txtGiaVe.Multiline = true;
            txtGiaVe.Name = "txtGiaVe";
            txtGiaVe.Size = new Size(401, 62);
            txtGiaVe.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(22, 22);
            label6.Name = "label6";
            label6.Size = new Size(110, 45);
            label6.TabIndex = 0;
            label6.Text = "Giá Vé";
            // 
            // panel5
            // 
            panel5.Controls.Add(cboSoGhe);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(51, 394);
            panel5.Name = "panel5";
            panel5.Size = new Size(637, 105);
            panel5.TabIndex = 6;
            // 
            // cboSoGhe
            // 
            cboSoGhe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboSoGhe.FormattingEnabled = true;
            cboSoGhe.Location = new Point(190, 22);
            cboSoGhe.Name = "cboSoGhe";
            cboSoGhe.Size = new Size(401, 53);
            cboSoGhe.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(22, 17);
            label4.Name = "label4";
            label4.Size = new Size(122, 45);
            label4.TabIndex = 0;
            label4.Text = "Số Ghế";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(dateTimePicker1);
            panel4.Location = new Point(48, 282);
            panel4.Name = "panel4";
            panel4.Size = new Size(707, 87);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 26);
            label3.Name = "label3";
            label3.Size = new Size(152, 45);
            label3.TabIndex = 1;
            label3.Text = "Ngày Dặt";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(215, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(462, 39);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(cboMaChuyenTau);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(48, 31);
            panel3.Name = "panel3";
            panel3.Size = new Size(664, 84);
            panel3.TabIndex = 4;
            // 
            // cboMaChuyenTau
            // 
            cboMaChuyenTau.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboMaChuyenTau.FormattingEnabled = true;
            cboMaChuyenTau.Location = new Point(312, 15);
            cboMaChuyenTau.Name = "cboMaChuyenTau";
            cboMaChuyenTau.Size = new Size(328, 53);
            cboMaChuyenTau.TabIndex = 1;
            cboMaChuyenTau.SelectedIndexChanged += cboMaChuyenTau_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(25, 18);
            label1.Name = "label1";
            label1.Size = new Size(236, 45);
            label1.TabIndex = 0;
            label1.Text = "Mã Chuyến Tàu";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtGaDen);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtGaDi);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(48, 138);
            panel6.Name = "panel6";
            panel6.Size = new Size(965, 99);
            panel6.TabIndex = 3;
            // 
            // txtGaDen
            // 
            txtGaDen.Font = new Font("Segoe UI", 10.875F);
            txtGaDen.Location = new Point(633, 18);
            txtGaDen.Multiline = true;
            txtGaDen.Name = "txtGaDen";
            txtGaDen.Size = new Size(304, 64);
            txtGaDen.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.875F);
            label5.Location = new Point(508, 34);
            label5.Name = "label5";
            label5.Size = new Size(119, 40);
            label5.TabIndex = 2;
            label5.Text = "Ga Đến ";
            // 
            // txtGaDi
            // 
            txtGaDi.Font = new Font("Segoe UI", 10.875F);
            txtGaDi.Location = new Point(141, 18);
            txtGaDi.Multiline = true;
            txtGaDi.Name = "txtGaDi";
            txtGaDi.Size = new Size(329, 64);
            txtGaDi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(88, 40);
            label2.TabIndex = 0;
            label2.Text = "Ga ĐI";
            // 
            // btnVeCuaToi
            // 
            btnVeCuaToi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVeCuaToi.Location = new Point(1081, 141);
            btnVeCuaToi.Name = "btnVeCuaToi";
            btnVeCuaToi.Size = new Size(231, 98);
            btnVeCuaToi.TabIndex = 11;
            btnVeCuaToi.Text = "Vé của tôi";
            btnVeCuaToi.UseVisualStyleBackColor = true;
            btnVeCuaToi.Click += btnVeCuaToi_Click;
            // 
            // FormDatVe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 984);
            Controls.Add(panel1);
            Name = "FormDatVe";
            Text = "FormDatVe";
            Load += FormDatVe_Load;
            panel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChuyenTau).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private ComboBox cboMaChuyenTau;
        private Label label1;
        private Panel panel6;
        private TextBox txtGaDen;
        private Label label5;
        private TextBox txtGaDi;
        private Label label2;
        private Panel panel7;
        private TextBox txtGiaVe;
        private Label label6;
        private Panel panel5;
        private ComboBox cboSoGhe;
        private Label label4;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnDat;
        private Button btnThoat;
        private Button btnReset;
        private Panel panel8;
        private DataGridView dgvChuyenTau;
        private Label label7;
        private Button btnVeCuaToi;
    }
}