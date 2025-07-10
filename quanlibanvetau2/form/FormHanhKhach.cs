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
    public partial class FormHanhKhach : Form
    {
        public FormHanhKhach()
        {
            InitializeComponent();
        }
        private readonly AppDbContext _context = new AppDbContext();

        private void loaddata()
        {
            var hanhkhachlist = _context.HanhKhaches.ToList();
            dgvHanhKhach.DataSource = hanhkhachlist;
            dgvHanhKhach.Columns["TaiKhoans"].Visible = false;
            dgvHanhKhach.Columns["VeTauS"].Visible = false;


        }
        private void FormHanhKhach_Load(object sender, EventArgs e)
        {
            loaddata();

        }

        private void dgvHanhKhach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHanhKhach.SelectedRows.Count > 0)
            {
                var selectedRow = dgvHanhKhach.SelectedRows[0];
                txtHoTen.Text = selectedRow.Cells["HoTen"].Value.ToString();
                txtCMND.Text = selectedRow.Cells["CMND"].Value.ToString();
                txtDienThoai.Text = selectedRow.Cells["DienThoai"].Value.ToString();
                txtDiaChi.Text = selectedRow.Cells["DiaChi"].Value.ToString();
            }
            else
            {
                txtHoTen.Clear();
                txtCMND.Clear();
                txtDienThoai.Clear();
                txtDiaChi.Clear();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_context.HanhKhaches.Any(hk => hk.CMND == int.Parse(txtCMND.Text.Trim())))
                {
                    MessageBox.Show("CMND Đã tồn tại ! vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                var Hanhkach = new quanlibanvetau.model.HanhKhach
                {
                    HoTen = txtHoTen.Text.Trim(),
                    CMND = int.Parse(txtCMND.Text.Trim()),
                    DienThoai = txtDienThoai.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim()
                };
                _context.HanhKhaches.Add(Hanhkach);
                _context.SaveChanges();
                MessageBox.Show("Thêm hành khách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm hành khách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHanhKhach.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn hành khách cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var selectedRow = dgvHanhKhach.CurrentRow;
                var maHanhKhach = (int)selectedRow.Cells["MaHanhKhach"].Value;
                var hanhKhach = _context.HanhKhaches.Find(maHanhKhach);
                if (hanhKhach == null)
                {
                    MessageBox.Show("Hành khách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hanhKhach.HoTen = txtHoTen.Text.Trim();
                hanhKhach.CMND = int.Parse(txtCMND.Text.Trim());
                hanhKhach.DienThoai = txtDienThoai.Text.Trim();
                hanhKhach.DiaChi = txtDiaChi.Text.Trim();
                _context.SaveChanges();
                MessageBox.Show("Sửa thông tin hành khách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin hành khách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var selectedRow = dgvHanhKhach.CurrentRow;
            if (selectedRow == null)
            {
                MessageBox.Show("Vui lòng chọn hành khách cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var maHanhKhach = (int)selectedRow.Cells["MaHanhKhach"].Value;
                var hanhKhach = _context.HanhKhaches.Find(maHanhKhach);
                if (hanhKhach == null)
                {
                    MessageBox.Show("Hành khách không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _context.HanhKhaches.Remove(hanhKhach);
                _context.SaveChanges();
                MessageBox.Show("Xóa hành khách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddata();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa hành khách: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            string searchText = txtTk.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Vui lòng nhập thông tin tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var searchResults = _context.HanhKhaches
                .Where(hk => hk.HoTen.ToLower().Contains(searchText) || hk.CMND.ToString().Contains(searchText))
                .ToList();
            if (searchResults.Count == 0)
                {
                MessageBox.Show("Không tìm thấy hành khách nào phù hợp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvHanhKhach.DataSource = searchResults;
                dgvHanhKhach.ClearSelection();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var hanhkhachlist = _context.HanhKhaches.ToList();
            dgvHanhKhach.DataSource = hanhkhachlist;
            txtHoTen.Clear();
            txtCMND.Clear();
            txtDienThoai.Clear();
            txtDiaChi.Clear();
            txtTk.Clear();
            dgvHanhKhach.ClearSelection();

        }
    }
}
