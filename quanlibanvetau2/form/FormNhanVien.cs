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
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }
        private readonly AppDbContext _context = new AppDbContext();
        private int? selectedMaNV = null;
        private void loadData()
        {
            var nhanVienList = _context.NhanViens.Select(nv => new
            {
                nv.MaNV,
                nv.TenNV,
                nv.SoDienThoai
            }).ToList();
            dgvNhanvien.DataSource = nhanVienList;
            dgvNhanvien.ClearSelection();
            ResetForm();

        }
        private void ResetForm()
        {
            txtManv.Clear();
            txtTennv.Clear();
            txtSdt.Clear();
            selectedMaNV = null;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var newNhanVien = new quanlibanvetau.model.NhanVien
            {
                TenNV = txtTennv.Text.Trim(),
                SoDienThoai = txtSdt.Text.Trim()
            };
            _context.NhanViens.Add(newNhanVien);
            _context.SaveChanges();
            MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            loadData();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var maNV = selectedMaNV;
            if (maNV == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var nhanVien = _context.NhanViens.Find(maNV);
            if (nhanVien == null)
            {
                MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            nhanVien.TenNV = txtTennv.Text.Trim();
            nhanVien.SoDienThoai = txtSdt.Text.Trim();
            _context.SaveChanges();
            MessageBox.Show("Sửa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var maNV = selectedMaNV;
            if (maNV == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nhanVien = _context.NhanViens.Find(maNV);
            if (nhanVien == null)
            {
                MessageBox.Show("Nhân viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                _context.NhanViens.Remove(nhanVien);
                _context.SaveChanges();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }

        }

        private void btnTk_Click(object sender, EventArgs e)
        {
            var searchText = txtTennv.Text.Trim().ToLower();
            var searchResults = _context.NhanViens
                .Where(nv => nv.TenNV.ToLower().Contains(searchText))
                .Select(nv => new
                {
                    nv.MaNV,
                    nv.TenNV,
                    nv.SoDienThoai
                })
                .ToList();
            if (searchResults.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvNhanvien.DataSource = searchResults;
                dgvNhanvien.ClearSelection();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(ToString());
            this.Hide();
            formMain.ShowDialog();
            
        }

        private void dgvNhanvien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvNhanvien.SelectedRows.Count > 0)
            {
                var selectedRows = dgvNhanvien.SelectedRows[0];
                selectedMaNV = (int)selectedRows.Cells["MaNV"].Value;
                txtManv.Text = selectedRows.Cells["MaNV"].Value.ToString();
                txtTennv.Text = selectedRows.Cells["Tennv"].Value.ToString();
                txtSdt.Text = selectedRows.Cells["SoDienThoai"].Value.ToString();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtManv.Clear();
            txtTennv.Clear();
            txtSdt.Clear();
            loadData();

        }
    }
}
