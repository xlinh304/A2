using Microsoft.IdentityModel.Tokens;
using quanlibanvetau.model;
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
    public partial class FormTaiKhoan : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private string? selectedTenTaiKhoan = null;

        public FormTaiKhoan()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            // Cấu hình ComboBox vai trò
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.AddRange(new string[] { "Admin", "NhanVien", "KhachHang" });
            cboVaiTro.DropDownStyle = ComboBoxStyle.DropDownList;

            // Cấu hình DataGridView
            ConfigureDataGridView();

            // Load dữ liệu
            LoadData();

            // Đăng ký event
            cboVaiTro.SelectedIndexChanged += CboVaiTro_SelectedIndexChanged;
        }

        private void ConfigureDataGridView()
        {
            dgvTaiKhoan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTaiKhoan.MultiSelect = false;
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Hiển thị/ẩn các trường theo vai trò
            string selectedRole = cboVaiTro.SelectedItem?.ToString();

            txtMaNV.Enabled = selectedRole == "NhanVien";
            txtMaHK.Enabled = selectedRole == "KhachHang";

            if (selectedRole == "Admin")
            {
                txtMaNV.Clear();
                txtMaHK.Clear();
                txtMaNV.Enabled = false;
                txtMaHK.Enabled = false;
            }
            else if (selectedRole == "NhanVien")
            {
                txtMaHK.Clear();
            }
            else if (selectedRole == "KhachHang")
            {
                txtMaNV.Clear();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                // Kiểm tra tên đăng nhập đã tồn tại
                if (_context.TaiKhoans.Any(tk => tk.TenDangNhap == txtTenDangNhap.Text.Trim()))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newTaiKhoan = new quanlibanvetau.model.TaiKhoan
                {
                    TenDangNhap = txtTenDangNhap.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    VaiTro = cboVaiTro.SelectedItem.ToString(),
                    MaNV = cboVaiTro.SelectedItem.ToString() == "NhanVien" && !string.IsNullOrEmpty(txtMaNV.Text)
                        ? int.Parse(txtMaNV.Text.Trim()) : (int?)null,
                    MaHanhKhach = cboVaiTro.SelectedItem.ToString() == "KhachHang" && !string.IsNullOrEmpty(txtMaHK.Text)
                        ? int.Parse(txtMaHK.Text.Trim()) : (int?)null
                };

                _context.TaiKhoans.Add(newTaiKhoan);
                _context.SaveChanges();

                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedTenTaiKhoan == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                var taiKhoan = _context.TaiKhoans.Find(selectedTenTaiKhoan);
                if (taiKhoan != null)
                {
                    // Kiểm tra tên đăng nhập đã tồn tại (trừ tài khoản hiện tại)
                    if (_context.TaiKhoans.Any(tk => tk.TenDangNhap == txtTenDangNhap.Text.Trim() ))
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    taiKhoan.TenDangNhap = txtTenDangNhap.Text.Trim();
                    taiKhoan.MatKhau = txtMatKhau.Text.Trim();
                    taiKhoan.VaiTro = cboVaiTro.SelectedItem.ToString();
                    taiKhoan.MaNV = cboVaiTro.SelectedItem.ToString() == "NhanVien" && !string.IsNullOrEmpty(txtMaNV.Text)
                        ? int.Parse(txtMaNV.Text.Trim()) : (int?)null;
                    taiKhoan.MaHanhKhach = cboVaiTro.SelectedItem.ToString() == "KhachHang" && !string.IsNullOrEmpty(txtMaHK.Text)
                        ? int.Parse(txtMaHK.Text.Trim()) : (int?)null;

                    _context.SaveChanges();
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedTenTaiKhoan == null)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var taiKhoan = _context.TaiKhoans.Find(selectedTenTaiKhoan);
                    if (taiKhoan != null)
                    {
                        _context.TaiKhoans.Remove(taiKhoan);
                        _context.SaveChanges();
                        MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi xóa tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                var searchText = txtTimKiem.Text.Trim().ToLower(); // Sử dụng textbox tìm kiếm riêng

                if (string.IsNullOrEmpty(searchText))
                {
                    LoadData();
                    return;
                }

                var filteredList = _context.TaiKhoans
                    .Where(tk => tk.TenDangNhap.ToLower().Contains(searchText) ||
                                tk.VaiTro.ToLower().Contains(searchText))
                    .Select(tk => new
                    {
                        
                        tk.TenDangNhap,
                        tk.MatKhau,
                        tk.VaiTro,
                        MaNV = tk.MaNV,
                        MaHanhKhach = tk.MaHanhKhach
                    }).ToList();

                dgvTaiKhoan.DataSource = filteredList;
                dgvTaiKhoan.ClearSelection();

                if (filteredList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();
        }

        private void LoadData()
        {
            try
            {
                var taiKhoanList = _context.TaiKhoans.Select(tk => new
                {
                    
                    tk.TenDangNhap,
                    tk.MatKhau,
                    tk.VaiTro,
                    MaNV = tk.MaNV,
                    MaHanhKhach = tk.MaHanhKhach
                }).ToList();

                dgvTaiKhoan.DataSource = taiKhoanList;
                dgvTaiKhoan.ClearSelection();

                // Ẩn cột Id
                if (dgvTaiKhoan.Columns["Id"] != null)
                    dgvTaiKhoan.Columns["Id"].Visible = false;

                // Đặt tên cột hiển thị
                SetColumnHeaders();

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetColumnHeaders()
        {
            if (dgvTaiKhoan.Columns["TenDangNhap"] != null)
                dgvTaiKhoan.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
            if (dgvTaiKhoan.Columns["MatKhau"] != null)
                dgvTaiKhoan.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            if (dgvTaiKhoan.Columns["VaiTro"] != null)
                dgvTaiKhoan.Columns["VaiTro"].HeaderText = "Vai Trò";
            if (dgvTaiKhoan.Columns["MaNV"] != null)
                dgvTaiKhoan.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            if (dgvTaiKhoan.Columns["MaHanhKhach"] != null)
                dgvTaiKhoan.Columns["MaHanhKhach"].HeaderText = "Mã Hành Khách";
        }

        private void ResetForm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
            cboVaiTro.SelectedIndex = -1;
            txtMaNV.Clear();
            txtMaHK.Clear();
            txtTimKiem.Clear();

            // Reset trạng thái enable
            txtMaNV.Enabled = true;
            txtMaHK.Enabled = true;

            selectedTenTaiKhoan = null;
        }

        private bool ValidateInput()
        {
            // Kiểm tra tên đăng nhập
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenDangNhap.Focus();
                return false;
            }

            // Kiểm tra mật khẩu
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Focus();
                return false;
            }

            // Kiểm tra vai trò
            if (cboVaiTro.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboVaiTro.Focus();
                return false;
            }

            // Kiểm tra mã nhân viên nếu vai trò là NhanVien
            if (cboVaiTro.SelectedItem.ToString() == "NhanVien" && string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }

            // Kiểm tra mã hành khách nếu vai trò là KhachHang
            if (cboVaiTro.SelectedItem.ToString() == "KhachHang" && string.IsNullOrWhiteSpace(txtMaHK.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hành khách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHK.Focus();
                return false;
            }

            // Kiểm tra định dạng số cho mã nhân viên
            if (!string.IsNullOrWhiteSpace(txtMaNV.Text) && !int.TryParse(txtMaNV.Text.Trim(), out _))
            {
                MessageBox.Show("Mã nhân viên phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return false;
            }

            // Kiểm tra định dạng số cho mã hành khách
            if (!string.IsNullOrWhiteSpace(txtMaHK.Text) && !int.TryParse(txtMaHK.Text.Trim(), out _))
            {
                MessageBox.Show("Mã hành khách phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaHK.Focus();
                return false;
            }

            return true;
        }

        private void dgvTaiKhoan_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvTaiKhoan.SelectedRows.Count > 0)
            {
                var selectedRow = dgvTaiKhoan.SelectedRows[0];
                selectedTenTaiKhoan = selectedRow.Cells["TenDangNhap"].Value.ToString();
                txtTenDangNhap.Text = selectedRow.Cells["TenDangNhap"].Value?.ToString();
                txtMatKhau.Text = selectedRow.Cells["MatKhau"].Value?.ToString();
                cboVaiTro.SelectedItem = selectedRow.Cells["VaiTro"].Value?.ToString();
                txtMaNV.Text = selectedRow.Cells["MaNV"].Value?.ToString() ?? string.Empty;
                txtMaHK.Text = selectedRow.Cells["MaHanhKhach"].Value?.ToString() ?? string.Empty;
            }
            else
            {
                ResetForm();
            }

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}