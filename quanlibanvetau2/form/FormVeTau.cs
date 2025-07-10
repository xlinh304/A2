using quanlibanvetau.model;
using quanlibanvetau1.context;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;

namespace quanlibanvetau2.form
{
    public partial class FormVeTau : Form
    {
        private readonly AppDbContext _context;
        private BindingSource _bindingSource;
        private bool _isLoading = false;

        public FormVeTau()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _bindingSource = new BindingSource();
            InitializeForm();
        }

        #region Form Initialization
        private void InitializeForm()
        {
            try
            {
                ConfigureDataGridView();
                LoadData();
                InitializeControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvVeTau.DataSource = _bindingSource;
            dgvVeTau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVeTau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVeTau.MultiSelect = false;
            dgvVeTau.AllowUserToAddRows = false;
            dgvVeTau.ReadOnly = true;

            // Đăng ký sự kiện
            dgvVeTau.CellClick += dgvVeTau_CellClick;
        }

        private void InitializeControls()
        {
            // Thiết lập DateTimePicker
            dtpNgayDat.Value = DateTime.Now;
            dtpNgayDat.Format = DateTimePickerFormat.Short;

            // Thiết lập ComboBox cho trạng thái
            if (Controls.Find("cboTrangThai", true).FirstOrDefault() is ComboBox cboTrangThai)
            {
                cboTrangThai.Items.Clear();
                cboTrangThai.Items.AddRange(new string[] { "Đã đặt", "Đã thanh toán", "Đã hủy", "Đã sử dụng" });
                cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            }

            ResetForm();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _bindingSource?.Dispose();
            _context?.Dispose();
        }
        #endregion

        #region Data Loading
        private async void LoadData()
        {
            if (_isLoading) return;

            _isLoading = true;
            try
            {
                // Hiển thị loading indicator nếu có
                Cursor = Cursors.WaitCursor;

                var danhSachVe = await System.Threading.Tasks.Task.Run(() =>
                {
                    return _context.VeTaus
                        .Select(v => new VeTauViewModel
                        {
                            MaVe = v.MaVe,
                            MaChuyen = (int)v.MaChuyen,
                            TenChuyen = v.ChuyenTau.TenTau ?? "N/A",
                            MaHanhKhach = (int)v.MaHanhKhach,
                            TenHanhKhach = v.HanhKhach.HoTen ?? "N/A",
                            NgayDat = v.NgayDat,
                            SoGhe = v.SoGhe ?? "N/A",
                            GiaVe = v.GiaVe,
                            TrangThai = v.TrangThai ?? "N/A"
                        })
                        .OrderByDescending(v => v.NgayDat)
                        .ToList();
                });

                _bindingSource.DataSource = danhSachVe;

                // Format DataGridView sau khi load data
                FormatDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
                _isLoading = false;
            }
        }

        private void FormatDataGridView()
        {
            if (dgvVeTau.Columns.Count > 0)
            {
                // Format cột tiền
                if (dgvVeTau.Columns["GiaVe"] != null)
                {
                    dgvVeTau.Columns["GiaVe"].DefaultCellStyle.Format = "N0";
                    dgvVeTau.Columns["GiaVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                // Format cột ngày
                if (dgvVeTau.Columns["NgayDat"] != null)
                {
                    dgvVeTau.Columns["NgayDat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                // Thiết lập header text
                SetColumnHeaders();
            }
        }

        private void SetColumnHeaders()
        {
            var headers = new Dictionary<string, string>
            {
                {"MaVe", "Mã Vé"},
                {"MaChuyen", "Mã Chuyến"},
                {"TenChuyen", "Tên Chuyến"},
                {"MaHanhKhach", "Mã Hành Khách"},
                {"TenHanhKhach", "Tên Hành Khách"},
                {"NgayDat", "Ngày Đặt"},
                {"SoGhe", "Số Ghế"},
                {"GiaVe", "Giá Vé (VND)"},
                {"TrangThai", "Trạng Thái"}
            };

            foreach (var header in headers)
            {
                if (dgvVeTau.Columns[header.Key] != null)
                {
                    dgvVeTau.Columns[header.Key].HeaderText = header.Value;
                }
            }
        }
        #endregion

        #region Button Events


        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Validation
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtMaChuyen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã chuyến!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyen.Focus();
                return false;
            }

            if (!int.TryParse(txtMaChuyen.Text.Trim(), out _))
            {
                MessageBox.Show("Mã chuyến phải là số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaChuyen.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMaHanhKhach.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hành khách!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHanhKhach.Focus();
                return false;
            }

            if (!int.TryParse(txtMaHanhKhach.Text.Trim(), out _))
            {
                MessageBox.Show("Mã hành khách phải là số!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaHanhKhach.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoGhe.Text))
            {
                MessageBox.Show("Vui lòng nhập số ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGhe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGiaVe.Text))
            {
                MessageBox.Show("Vui lòng nhập giá vé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaVe.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaVe.Text.Trim(), out decimal giaVe) || giaVe <= 0)
            {
                MessageBox.Show("Giá vé phải là số dương!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaVe.Focus();
                return false;
            }

            return true;
        }

        private bool ValidateInputForEdit()
        {
            if (string.IsNullOrWhiteSpace(txtMaVe.Text))
            {
                MessageBox.Show("Vui lòng chọn vé cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtMaVe.Text.Trim(), out _))
            {
                MessageBox.Show("Mã vé không hợp lệ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSoGhe.Text))
            {
                MessageBox.Show("Vui lòng nhập số ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGhe.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGiaVe.Text))
            {
                MessageBox.Show("Vui lòng nhập giá vé!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaVe.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaVe.Text.Trim(), out decimal giaVe) || giaVe <= 0)
            {
                MessageBox.Show("Giá vé phải là số dương!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaVe.Focus();
                return false;
            }

            return true;
        }

        private bool IsGheDaDat(int maChuyen, string soGhe, int? maVeHienTai = null)
        {
            var query = _context.VeTaus.Where(v => v.MaChuyen == maChuyen &&
                                               v.SoGhe == soGhe &&
                                               v.TrangThai != "Đã hủy");

            // Nếu đang sửa vé, loại trừ vé hiện tại khỏi kiểm tra
            if (maVeHienTai.HasValue)
            {
                query = query.Where(v => v.MaVe != maVeHienTai.Value);
            }

            return query.Any();
        }
        #endregion

        #region Helper Methods
        private VeTau CreateVeTauFromInput()
        {
            return new VeTau
            {
                MaChuyen = int.Parse(txtMaChuyen.Text.Trim()),
                MaHanhKhach = int.Parse(txtMaHanhKhach.Text.Trim()),
                NgayDat = dtpNgayDat.Value,
                SoGhe = txtSoGhe.Text.Trim(),
                GiaVe = decimal.Parse(txtGiaVe.Text.Trim()),
                TrangThai = GetSelectedTrangThai()
            };
        }

        private string GetSelectedTrangThai()
        {
            if (Controls.Find("cboTrangThai", true).FirstOrDefault() is ComboBox cboTrangThai)
            {
                return cboTrangThai.SelectedItem?.ToString() ?? "Đã đặt";
            }
            return txtTrangThai.Text.Trim();
        }

        private void ResetForm()
        {
            txtMaVe.Clear();
            txtMaChuyen.Clear();
            txtMaHanhKhach.Clear();
            txtSoGhe.Clear();
            txtGiaVe.Clear();
            txtTrangThai.Clear();
            txtTk.Clear();
            dtpNgayDat.Value = DateTime.Now;

            if (Controls.Find("cboTrangThai", true).FirstOrDefault() is ComboBox cboTrangThai)
            {
                cboTrangThai.SelectedIndex = 0; // Đã đặt
            }
        }

        private void dgvVeTau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvVeTau.Rows.Count)
            {
                try
                {
                    var row = dgvVeTau.Rows[e.RowIndex];
                    txtMaVe.Text = row.Cells["MaVe"].Value?.ToString() ?? "";
                    txtMaChuyen.Text = row.Cells["MaChuyen"].Value?.ToString() ?? "";
                    txtMaHanhKhach.Text = row.Cells["MaHanhKhach"].Value?.ToString() ?? "";
                    txtSoGhe.Text = row.Cells["SoGhe"].Value?.ToString() ?? "";
                    txtGiaVe.Text = row.Cells["GiaVe"].Value?.ToString() ?? "";
                    txtTrangThai.Text = row.Cells["TrangThai"].Value?.ToString() ?? "";

                    // Nếu có ComboBox trạng thái
                    if (Controls.Find("cboTrangThai", true).FirstOrDefault() is ComboBox cboTrangThai)
                    {
                        string trangThai = row.Cells["TrangThai"].Value?.ToString() ?? "";
                        cboTrangThai.SelectedItem = trangThai;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị dữ liệu: {ex.Message}", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInputForEdit()) return;

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        int maVe = int.Parse(txtMaVe.Text.Trim());
                        var ve = _context.VeTaus.Find(maVe);

                        if (ve != null)
                        {
                            // Lưu giá trị cũ để kiểm tra
                            string soGheCu = ve.SoGhe;
                            int maChuyenCu = (int)ve.MaChuyen;

                            // Cập nhật các trường được phép sửa
                            string soGheMoi = txtSoGhe.Text.Trim();
                            decimal giaVeMoi = decimal.Parse(txtGiaVe.Text.Trim());
                            string trangThaiMoi = GetSelectedTrangThai();

                            // Kiểm tra ghế trùng lặp nếu số ghế được thay đổi
                            if (soGheMoi != soGheCu && IsGheDaDat(maChuyenCu, soGheMoi, maVe))
                            {
                                MessageBox.Show("Ghế này đã được đặt cho chuyến tàu này!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Kiểm tra giá vé hợp lệ
                            if (giaVeMoi <= 0)
                            {
                                MessageBox.Show("Giá vé phải lớn hơn 0!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Cập nhật thông tin vé
                            ve.SoGhe = soGheMoi;
                            ve.GiaVe = giaVeMoi;
                            ve.TrangThai = trangThaiMoi;

                            _context.SaveChanges();
                            transaction.Commit();

                            MessageBox.Show("Cập nhật vé thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy vé cần sửa!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvVeTau.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn vé cần xóa!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Hiển thị dialog xác nhận với tùy chọn xóa hoàn toàn hoặc chỉ hủy
                var result = MessageBox.Show("Chọn 'Yes' để xóa vé hoàn toàn\nChọn 'No' để chỉ hủy vé (đặt trạng thái 'Đã hủy')\nChọn 'Cancel' để không thực hiện",
                    "Xác nhận xóa", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result != DialogResult.Cancel)
                {
                    int maVe = (int)dgvVeTau.CurrentRow.Cells["MaVe"].Value;
                    var ve = _context.VeTaus.Find(maVe);

                    if (ve != null)
                    {
                        using (var transaction = _context.Database.BeginTransaction())
                        {
                            try
                            {
                                if (result == DialogResult.Yes)
                                {
                                    // Xóa hoàn toàn
                                    _context.VeTaus.Remove(ve);
                                    _context.SaveChanges();
                                    transaction.Commit();
                                    MessageBox.Show("Xóa vé thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else if (result == DialogResult.No)
                                {
                                    // Chỉ hủy vé
                                    ve.TrangThai = "Đã hủy";
                                    _context.SaveChanges();
                                    transaction.Commit();
                                    MessageBox.Show("Hủy vé thành công!", "Thông báo",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                LoadData();
                                ResetForm();
                            }
                            catch (Exception)
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy vé cần xóa!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput()) return;

                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var veMoi = CreateVeTauFromInput();

                        // Kiểm tra ghế trùng lặp
                        if (IsGheDaDat((int)veMoi.MaChuyen, veMoi.SoGhe))
                        {
                            MessageBox.Show("Ghế này đã được đặt cho chuyến tàu này!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        _context.VeTaus.Add(veMoi);
                        _context.SaveChanges();
                        transaction.Commit();

                        MessageBox.Show("Thêm vé thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ResetForm();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTk.Text.Trim();

                if (string.IsNullOrEmpty(keyword))
                {
                    LoadData();
                    return;
                }

                var ketQua = _context.VeTaus
                    .Where(v => v.MaChuyen.ToString().Contains(keyword) ||
                               v.MaHanhKhach.ToString().Contains(keyword) ||
                               v.HanhKhach.HoTen.Contains(keyword) ||
                               v.ChuyenTau.TenTau.Contains(keyword) ||
                               v.SoGhe.Contains(keyword) ||
                               v.TrangThai.Contains(keyword))
                    .Select(v => new VeTauViewModel
                    {
                        MaVe = v.MaVe,
                        MaChuyen = (int)v.MaChuyen,
                        TenChuyen = v.ChuyenTau.TenTau ?? "N/A",
                        MaHanhKhach = (int)v.MaHanhKhach,
                        TenHanhKhach = v.HanhKhach.HoTen ?? "N/A",
                        NgayDat = v.NgayDat,
                        SoGhe = v.SoGhe ?? "N/A",
                        GiaVe = v.GiaVe,
                        TrangThai = v.TrangThai ?? "N/A"
                    })
                    .OrderByDescending(v => v.NgayDat)
                    .ToList();

                _bindingSource.DataSource = ketQua;

                if (ketQua.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormVeTau_Load(object sender, EventArgs e)
        {

        }
    }

    #region ViewModel
    public class VeTauViewModel
    {
        public int MaVe { get; set; }
        public int MaChuyen { get; set; }
        public string TenChuyen { get; set; }
        public int MaHanhKhach { get; set; }
        public string TenHanhKhach { get; set; }
        public DateTime NgayDat { get; set; }
        public string SoGhe { get; set; }
        public decimal GiaVe { get; set; }
        public string TrangThai { get; set; }
    }
    #endregion
}