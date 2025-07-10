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
    public partial class FormMain : Form
    {
        private string quyenNguoiDung;
        private string tenNguoiDung;

        public FormMain(string quyen, string tenUser = "")
        {
            InitializeComponent();
            this.quyenNguoiDung = quyen?.Trim() ?? "";
            this.tenNguoiDung = tenUser?.Trim() ?? "";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Hiển thị thông tin user
            this.Text = $"Hệ thống quản lý bán vé tàu - {tenNguoiDung} ({quyenNguoiDung})";

            // Thiết lập quyền truy cập
            SetupPermissions();
        }

        private void SetupPermissions()
        {
            // Khởi tạo - ẩn tất cả menu
            ResetMenuVisibility();

            // Phân quyền theo vai trò
            switch (quyenNguoiDung?.ToUpper())
            {
                case "ADMIN":
                    SetAdminPermissions();
                    break;

                case "NHANVIEN":
                    SetEmployeePermissions();
                    break;

                case "KHACHHANG":
                    SetCustomerPermissions();
                    break;

                default:
                    SetGuestPermissions();
                    MessageBox.Show("Vai trò không hợp lệ. Chỉ có quyền khách.",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ResetMenuVisibility()
        {
            // Ẩn tất cả menu con trong quản lí
            if (quảnLíToolStripMenuItem.DropDownItems.Count > 0)
            {
                tàiKhoảnToolStripMenuItem.Visible = false;
                nhânViênToolStripMenuItem.Visible = false;
                hànhKháchToolStripMenuItem.Visible = false;
                véTàuToolStripMenuItem.Visible = false;
                chuyếnTàuToolStripMenuItem.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
            }

            // Ẩn menu chính
            quảnLíToolStripMenuItem.Visible = false;
            hệThốngToolStripMenuItem.Visible = false;
        }

        private void SetAdminPermissions()
        {
            // Admin có full quyền
            quảnLíToolStripMenuItem.Visible = true;
            hệThốngToolStripMenuItem.Visible = true;

            // Hiện tất cả menu con
            tàiKhoảnToolStripMenuItem.Visible = true;
            nhânViênToolStripMenuItem.Visible = true;
            hànhKháchToolStripMenuItem.Visible = true;
            véTàuToolStripMenuItem.Visible = true;
            chuyếnTàuToolStripMenuItem.Visible = true;
            thốngKêToolStripMenuItem.Visible = true;
        }

        private void SetEmployeePermissions()
        {
            // Nhân viên không quản lý tài khoản và nhân viên
            quảnLíToolStripMenuItem.Visible = true;
            hệThốngToolStripMenuItem.Visible = true;

            tàiKhoảnToolStripMenuItem.Visible = false;
            nhânViênToolStripMenuItem.Visible = false;
            hànhKháchToolStripMenuItem.Visible = true;
            véTàuToolStripMenuItem.Visible = true;
            chuyếnTàuToolStripMenuItem.Visible = true;
            thốngKêToolStripMenuItem.Visible = true;
        }

        private void SetCustomerPermissions()
        {
            // Khách hàng chỉ xem thông tin và đặt vé
            quảnLíToolStripMenuItem.Visible = true;
            hệThốngToolStripMenuItem.Visible = true;

            tàiKhoảnToolStripMenuItem.Visible = false;
            nhânViênToolStripMenuItem.Visible = false;
            hànhKháchToolStripMenuItem.Visible = false;
            véTàuToolStripMenuItem.Visible = true; // Chỉ được đặt vé
            chuyếnTàuToolStripMenuItem.Visible = true; // Xem lịch trình
            thốngKêToolStripMenuItem.Visible = false;
        }

        private void SetGuestPermissions()
        {
            // Khách: quyền tối thiểu - chỉ có hệ thống để đăng xuất
            hệThốngToolStripMenuItem.Visible = true;
        }

        // Kiểm tra quyền trước khi mở form
        private bool CheckPermission(string requiredRole)
        {
            string[] allowedRoles = requiredRole.Split(',');
            bool hasPermission = allowedRoles.Contains(quyenNguoiDung, StringComparer.OrdinalIgnoreCase);

            if (!hasPermission)
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!",
                    "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return hasPermission;
        }

        private void ShowChildForm(Form childForm)
        {
            try
            {
                childForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handlers cho các menu
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckPermission("Admin"))
            {
                ShowChildForm(new FormNhanVien());
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckPermission("Admin"))
            {
                ShowChildForm(new FormTaiKhoan());
            }
        }

        private void hànhKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckPermission("Admin,NhanVien"))
            {
                ShowChildForm(new FormHanhKhach());
            }
        }

        private void véTàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckPermission("Admin,NhanVien,KhachHang"))
            {
                ShowChildForm(new FormVeTau());
            }
        }

        private void chuyếnTàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckPermission("Admin,NhanVien,KhachHang"))
            {
                ShowChildForm(new FormChuyenTau());
            }
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckPermission("Admin,NhanVien"))
            {
                ShowChildForm(new FormThongKe());
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK; // Báo hiệu đăng xuất bình thường
                this.Close();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu đóng form bằng nút X
            if (e.CloseReason == CloseReason.UserClosing && this.DialogResult != DialogResult.OK)
            {
                if (MessageBox.Show("Bạn có muốn đăng xuất và quay lại màn hình đăng nhập?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    e.Cancel = true; // Hủy việc đóng form
                }
            }
        }

        // Empty event handlers cho menu cha (không cần xử lý)
        private void quảnLíToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e) { }
    }
}