namespace quanlibanvetau2.form
{
    partial class FormDangNhap
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
            btnDangnhap = new Button();
            panel3 = new Panel();
            txtPass = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtTendangnhap = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnDangnhap);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(8, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 358);
            panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(584, 261);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(188, 67);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnDangnhap
            // 
            btnDangnhap.Location = new Point(353, 261);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(188, 67);
            btnDangnhap.TabIndex = 3;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = true;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtPass);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(13, 135);
            panel3.Name = "panel3";
            panel3.Size = new Size(759, 99);
            panel3.TabIndex = 2;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 10.875F);
            txtPass.Location = new Point(267, 18);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(489, 78);
            txtPass.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.875F);
            label2.Location = new Point(25, 34);
            label2.Name = "label2";
            label2.Size = new Size(136, 40);
            label2.TabIndex = 0;
            label2.Text = "mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTendangnhap);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(13, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 99);
            panel2.TabIndex = 0;
            // 
            // txtTendangnhap
            // 
            txtTendangnhap.Font = new Font("Segoe UI", 10.875F);
            txtTendangnhap.Location = new Point(267, 18);
            txtTendangnhap.Multiline = true;
            txtTendangnhap.Name = "txtTendangnhap";
            txtTendangnhap.Size = new Size(489, 78);
            txtTendangnhap.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.875F);
            label1.Location = new Point(25, 34);
            label1.Name = "label1";
            label1.Size = new Size(205, 40);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 431);
            Controls.Add(panel1);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThoat;
        private Button btnDangnhap;
        private Panel panel3;
        private TextBox txtPass;
        private Label label2;
        private Panel panel2;
        private TextBox txtTendangnhap;
        private Label label1;
    }
}