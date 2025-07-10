namespace quanlibanvetau2.form
{
    partial class FormThongKe
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
            label4 = new Label();
            label3 = new Label();
            lblTongSoVe = new Label();
            lblTongDoanhThu = new Label();
            button2 = new Button();
            btnThongKe = new Button();
            label2 = new Label();
            label1 = new Label();
            dtpDen = new DateTimePicker();
            dgvThongKe = new DataGridView();
            dtpTu = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTongSoVe);
            panel1.Controls.Add(lblTongDoanhThu);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpDen);
            panel1.Controls.Add(dgvThongKe);
            panel1.Controls.Add(dtpTu);
            panel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1664, 956);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 403);
            label4.Name = "label4";
            label4.Size = new Size(273, 45);
            label4.TabIndex = 10;
            label4.Text = "Tổng Doanh Thu: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(966, 403);
            label3.Name = "label3";
            label3.Size = new Size(182, 45);
            label3.TabIndex = 9;
            label3.Text = "Tổng Số Vé";
            // 
            // lblTongSoVe
            // 
            lblTongSoVe.AutoSize = true;
            lblTongSoVe.Location = new Point(1195, 403);
            lblTongSoVe.Name = "lblTongSoVe";
            lblTongSoVe.Size = new Size(0, 45);
            lblTongSoVe.TabIndex = 8;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Location = new Point(392, 403);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(0, 45);
            lblTongDoanhThu.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(1295, 218);
            button2.Name = "button2";
            button2.Size = new Size(235, 92);
            button2.TabIndex = 6;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.Location = new Point(130, 218);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(257, 92);
            btnThongKe.TabIndex = 5;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(847, 118);
            label2.Name = "label2";
            label2.Size = new Size(160, 45);
            label2.TabIndex = 4;
            label2.Text = "Đến Ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 113);
            label1.Name = "label1";
            label1.Size = new Size(139, 45);
            label1.TabIndex = 3;
            label1.Text = "Từ Ngày";
            // 
            // dtpDen
            // 
            dtpDen.Location = new Point(1043, 118);
            dtpDen.Name = "dtpDen";
            dtpDen.Size = new Size(554, 50);
            dtpDen.TabIndex = 2;
            // 
            // dgvThongKe
            // 
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvThongKe.Location = new Point(23, 494);
            dgvThongKe.Name = "dgvThongKe";
            dgvThongKe.RowHeadersWidth = 82;
            dgvThongKe.Size = new Size(1623, 445);
            dgvThongKe.TabIndex = 1;
            // 
            // dtpTu
            // 
            dtpTu.Location = new Point(260, 113);
            dtpTu.Name = "dtpTu";
            dtpTu.Size = new Size(548, 50);
            dtpTu.TabIndex = 0;
            // 
            // FormThongKe
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 980);
            Controls.Add(panel1);
            Name = "FormThongKe";
            Text = "FormThongKe";
            Load += FormThongKe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvThongKe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button btnThongKe;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpDen;
        private DataGridView dgvThongKe;
        private DateTimePicker dtpTu;
        private Label label4;
        private Label label3;
        private Label lblTongSoVe;
        private Label lblTongDoanhThu;
    }
}