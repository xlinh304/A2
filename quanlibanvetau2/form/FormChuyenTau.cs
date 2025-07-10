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
    public partial class FormChuyenTau : Form
    {
        public FormChuyenTau()
        {
            InitializeComponent();
        }
        private readonly AppDbContext _context = new AppDbContext();
        private void loadData()
        {
            var chuyenTaus = _context.ChuyenTaus.ToList();
            dgvChuyenTau.DataSource = chuyenTaus;
            
            dgvChuyenTau.Columns["ThongKes"].Visible = false; // Ẩn cột MaChuyen nếu không cần thiết hiển thị
            dgvChuyenTau.Columns["VeTaus"].Visible = false; // Ẩn cột VeTaus nếu không cần thiết hiển thị
        }
        private void FormChuyenTau_Load(object sender, EventArgs e)
        {
            loadData();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_context.ChuyenTaus.Any(ct => ct.TenTau == txtTenTau.Text.Trim()))
                {
                    MessageBox.Show("Tên tàu đã tồn tại. Vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var ChuyenTau = new quanlibanvetau.model.ChuyenTau
                {
                    TenTau = txtTenTau.Text.Trim(),
                    GaDi = txtGaDi.Text.Trim(),
                    GaDen = txtGaDen.Text.Trim(),
                    ThoiGianKhoiHanh = dtpDI.Value,
                    ThoiGianDen = dtpDen.Value,
                    TongSoGhe = txtSoGhe.Text.Trim() == "" ? 0 : int.Parse(txtSoGhe.Text.Trim()),
                    GiaVe = decimal.TryParse(txtGiaVe.Text.Trim(),out var gia) ? gia : 0
                    
                }; 
                _context.ChuyenTaus.Add(ChuyenTau);
                _context.SaveChanges();
                MessageBox.Show("Thêm chuyến tàu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm chuyến tàu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(dgvChuyenTau.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var selectedRow = dgvChuyenTau.CurrentRow;
                int maChuyen = (int)selectedRow.Cells["MaChuyen"].Value;
                var chuyenTau = _context.ChuyenTaus.Find(maChuyen);
                if (chuyenTau == null)
                {
                    MessageBox.Show("Chuyến tàu không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                chuyenTau.TenTau = txtTenTau.Text.Trim();
                chuyenTau.GaDi = txtGaDi.Text.Trim();
                chuyenTau.GaDen = txtGaDen.Text.Trim();
                chuyenTau.ThoiGianKhoiHanh = dtpDI.Value;
                chuyenTau.ThoiGianDen = dtpDen.Value;
                chuyenTau.TongSoGhe = txtSoGhe.Text.Trim() == "" ? 0 : int.Parse(txtSoGhe.Text.Trim());
                chuyenTau.GiaVe = decimal.TryParse(txtGiaVe.Text.Trim(), out var gia) ? gia : 0;
                _context.SaveChanges();
                MessageBox.Show("Sửa chuyến tàu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa chuyến tàu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dgvChuyenTau.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn chuyến tàu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var selectedRow = dgvChuyenTau.CurrentRow;
                int maChuyen = (int)selectedRow.Cells["MaChuyen"].Value;
                var chuyenTau = _context.ChuyenTaus.Find(maChuyen);
                if (chuyenTau == null)
                {
                    MessageBox.Show("Chuyến tàu không tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _context.ChuyenTaus.Remove(chuyenTau);
                _context.SaveChanges();
                MessageBox.Show("Xóa chuyến tàu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa chuyến tàu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            string searchTerm = txtTk.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var results = _context.ChuyenTaus
                .Where(ct => ct.TenTau.ToLower().Contains(searchTerm) ||
                             ct.GaDi.ToLower().Contains(searchTerm) ||
                             ct.GaDen.ToLower().Contains(searchTerm))
                .ToList();
            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy chuyến tàu nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvChuyenTau.DataSource = results;

        }

        private void dgvChuyenTau_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvChuyenTau.SelectedRows.Count>0)
            {
                var selectedRow = dgvChuyenTau.SelectedRows[0];
                txtTenTau.Text = selectedRow.Cells["TenTau"].Value.ToString();
                txtGaDi.Text = selectedRow.Cells["GaDi"].Value.ToString();
                txtGaDen.Text = selectedRow.Cells["GaDen"].Value.ToString();
                dtpDI.Value = Convert.ToDateTime(selectedRow.Cells["ThoiGianKhoiHanh"].Value);
                dtpDen.Value = Convert.ToDateTime(selectedRow.Cells["ThoiGianDen"].Value);
                txtSoGhe.Text = selectedRow.Cells["TongSoGhe"].Value.ToString();
                txtGiaVe.Text = selectedRow.Cells["GiaVe"].Value.ToString();
            }
        }
    }
}
