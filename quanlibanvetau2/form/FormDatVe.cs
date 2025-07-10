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
using Microsoft.EntityFrameworkCore;

namespace quanlibanvetau2.form
{
    public partial class FormDatVe : Form
    {
        private readonly int _mahanhkhach;
        private readonly AppDbContext _context;

        public FormDatVe(int mahanhkhach)
        {
            InitializeComponent();
            _mahanhkhach = mahanhkhach;
            _context = new AppDbContext();
        }

        #region Form Events
        private void FormDatVe_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                InitializeControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _context?.Dispose();
        }
        #endregion

        #region Data Loading Methods
        private void LoadData()
        {
            var danhsachchuyentau = _context.ChuyenTaus.ToList();

            if (danhsachchuyentau.Any())
            {
                dgvChuyenTau.DataSource = danhsachchuyentau;
                ConfigureDataGridView();
            }
            else
            {
                MessageBox.Show("Không có chuyến tàu nào trong hệ thống!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConfigureDataGridView()
        {
            dgvChuyenTau.Columns["ThongKes"].Visible = false;
            dgvChuyenTau.Columns["VeTaus"].Visible = false;

            // Tùy chỉnh thêm các cột hiển thị
            dgvChuyenTau.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChuyenTau.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChuyenTau.ReadOnly = true;
        }

        private void LoadDanhSachSoGhe()
        {
            cboSoGhe.Items.Clear();
            cboSoGhe.Items.AddRange(Enumerable.Range(1, 50)
                .Select(i => $"Ghế {i}")
                .ToArray());
            cboSoGhe.SelectedIndex = -1;
        }

        private void InitializeControls()
        {
            // Tạm thời tắt sự kiện để tránh trigger khi binding
            cboMaChuyenTau.SelectedIndexChanged -= cboMaChuyenTau_SelectedIndexChanged;

            try
            {
                var danhSachChuyenTau = _context.ChuyenTaus.ToList();
                cboMaChuyenTau.DataSource = danhSachChuyenTau;
                cboMaChuyenTau.DisplayMember = "MaChuyen";
                cboMaChuyenTau.ValueMember = "MaChuyen";

                LoadDanhSachSoGhe();
                ClearInputFields();

                cboMaChuyenTau.SelectedIndex = -1;
            }
            finally
            {
                // Bật lại sự kiện
                cboMaChuyenTau.SelectedIndexChanged += cboMaChuyenTau_SelectedIndexChanged;
            }
        }

        private void ClearInputFields()
        {
            txtGaDi.Clear();
            txtGaDen.Clear();
            txtGiaVe.Clear();
        }
        #endregion

        #region Button Events
        private void btnDat_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (!ValidateInput())
                    return;

                int maChuyen = (int)cboMaChuyenTau.SelectedValue;

                if (!ProcessTicketBooking(maChuyen))
                    return;

                MessageBox.Show("Đặt vé thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtGaDi.Clear();
                txtGaDen.Clear();
                txtGiaVe.Clear();
                cboMaChuyenTau.SelectedIndex = -1;
                cboSoGhe.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đặt vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnVeCuaToi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var formve = new FormVeHanhKhach(_mahanhkhach))
                {
                    formve.ShowDialog();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi mở form vé: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Validation and Business Logic
        private bool ValidateInput()
        {
            if (cboMaChuyenTau.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaChuyenTau.Focus();
                return false;
            }

            if (cboSoGhe.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn số ghế!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboSoGhe.Focus();
                return false;
            }

            return true;
        }

        private bool ProcessTicketBooking(int maChuyen)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    var chuyenTau = _context.ChuyenTaus.Find(maChuyen);
                    if (chuyenTau == null)
                    {
                        MessageBox.Show("Chuyến tàu không tồn tại!", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (chuyenTau.TongSoGhe <= 0)
                    {
                        MessageBox.Show("Chuyến tàu này đã hết ghế!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Kiểm tra xem ghế đã được đặt chưa
                    string soGheDaChon = cboSoGhe.SelectedItem.ToString();
                    if (IsGheDaDat(maChuyen, soGheDaChon))
                    {
                        MessageBox.Show("Ghế này đã được đặt, vui lòng chọn ghế khác!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    // Tạo vé mới
                    var veMoi = new VeTau
                    {
                        MaChuyen = maChuyen,
                        MaHanhKhach = _mahanhkhach,
                        NgayDat = DateTime.Now,
                        TrangThai = "Đã đặt",
                        GiaVe = chuyenTau.GiaVe,
                        SoGhe = soGheDaChon
                    };

                    _context.VeTaus.Add(veMoi);

                    // Giảm số ghế trống
                    chuyenTau.TongSoGhe -= 1;
                    _context.ChuyenTaus.Update(chuyenTau);

                    _context.SaveChanges();
                    transaction.Commit();

                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        private bool IsGheDaDat(int maChuyen, string soGhe)
        {
            return _context.VeTaus.Any(v => v.MaChuyen == maChuyen &&
                                           v.SoGhe == soGhe &&
                                           v.TrangThai != "Đã hủy");
        }
        #endregion

        #region Control Events
        private void cboMaChuyenTau_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboMaChuyenTau.SelectedValue is int maChuyen)
                {
                    var chuyen = _context.ChuyenTaus.FirstOrDefault(c => c.MaChuyen == maChuyen);
                    if (chuyen != null)
                    {
                        txtGaDi.Text = chuyen.GaDi;
                        txtGaDen.Text = chuyen.GaDen;
                        txtGiaVe.Text = chuyen.GiaVe.ToString("N0") + " VND";

                        // Load lại danh sách ghế còn trống
                        LoadGheConTrong(maChuyen);
                    }
                }
                else
                {
                    ClearInputFields();
                    LoadDanhSachSoGhe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn chuyến tàu: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGheConTrong(int maChuyen)
        {
            try
            {
                var gheDaDat = _context.VeTaus
                    .Where(v => v.MaChuyen == maChuyen && v.TrangThai != "Đã hủy")
                    .Select(v => v.SoGhe)
                    .ToList();

                cboSoGhe.Items.Clear();

                for (int i = 1; i <= 50; i++)
                {
                    string soGhe = $"Ghế {i}";
                    if (!gheDaDat.Contains(soGhe))
                    {
                        cboSoGhe.Items.Add(soGhe);
                    }
                }

                cboSoGhe.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load ghế: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadDanhSachSoGhe(); // Fallback to load all seats
            }
        }

    }
    #endregion
}

