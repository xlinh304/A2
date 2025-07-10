namespace quanlibanvetau2.form
{
    partial class FormVeHanhKhach
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
            btnThoat = new Button();
            btnQuayLai = new Button();
            btnHuy = new Button();
            dgvVe = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVe).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnQuayLai);
            panel1.Controls.Add(btnHuy);
            panel1.Controls.Add(dgvVe);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1727, 677);
            panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(618, 527);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(218, 90);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(320, 527);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(218, 90);
            btnQuayLai.TabIndex = 2;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(21, 527);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(218, 90);
            btnHuy.TabIndex = 1;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // dgvVe
            // 
            dgvVe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVe.Location = new Point(21, 28);
            dgvVe.Name = "dgvVe";
            dgvVe.RowHeadersWidth = 82;
            dgvVe.Size = new Size(1684, 400);
            dgvVe.TabIndex = 0;
            // 
            // FormVeHanhKhach
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1751, 715);
            Controls.Add(panel1);
            Name = "FormVeHanhKhach";
            Text = "FormVeHanhKhach";
            Load += FormVeHanhKhach_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvVe;
        private Button btnQuayLai;
        private Button btnHuy;
        private Button btnThoat;
    }
}