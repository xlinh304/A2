using quanlibanvetau1.context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlibanvetau2.form
{
    public partial class FormDangNhap : Form
    {
        private readonly AppDbContext _context;

        public FormDangNhap()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Validation input
                if (string.IsNullOrWhiteSpace(txtTendangnhap.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTendangnhap.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Focus();
                    return;
                }

                string username = txtTendangnhap.Text.Trim();
                string pass = txtPass.Text.Trim();

                // Kiểm tra đăng nhập
                var user = _context.TaiKhoans.FirstOrDefault(u =>
                    u.TenDangNhap.Trim().ToLower() == username.ToLower() &&
                    u.MatKhau.Trim() == pass);

                if (user != null)
                {
                    MessageBox.Show($"Đăng nhập thành công!\nChào mừng {user.TenDangNhap}",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (user.VaiTro == "KhachHang")
                    {
                        var makhachhang = user.MaHanhKhach ?? 0;
                        this.Hide();
                        FormDatVe formdatve = new FormDatVe(makhachhang);
                        formdatve.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        // Ẩn form login và mở form main
                        this.Hide();
                        FormMain formMain = new FormMain(user.VaiTro, user.TenDangNhap);

                        // Khi form main đóng, hiện lại form login
                        if (formMain.ShowDialog() == DialogResult.OK)
                        {
                            // Nếu user đăng xuất bình thường
                            ClearInputs();
                            this.Show();
                        }
                        else
                        {
                            // Nếu đóng ứng dụng
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!",
                        "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Clear password và focus lại username
                    txtPass.Clear();
                    txtTendangnhap.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearInputs()
        {
            txtTendangnhap.Clear();
            txtPass.Clear();
            txtTendangnhap.Focus();
        }

        

        // Xử lý phím Enter
        private void txtTendangnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtPass.Focus();
                e.Handled = true;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangnhap_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}