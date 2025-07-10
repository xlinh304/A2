using Microsoft.EntityFrameworkCore;
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
    public partial class FormVeHanhKhach : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        private readonly int _maHanhKhach;
        public FormVeHanhKhach(int maHanhKhach)
        {
            InitializeComponent();
            _maHanhKhach = maHanhKhach;
        }
        private void LoadVeKhachHang()
        {
            var danhSachVe = _context.VeTaus
                .Where(v => v.MaHanhKhach == _maHanhKhach && v.TrangThai != "Đã hủy")
                .Select(v => new
                {
                    v.MaVe,
                    v.ChuyenTau.TenTau,
                    v.ChuyenTau.GaDi,
                    v.ChuyenTau.GaDen,
                    v.NgayDat,
                    v.ChuyenTau.ThoiGianKhoiHanh,
                    v.SoGhe,
                    v.GiaVe,
                    v.TrangThai
                })
                .ToList();

            dgvVe.DataSource = danhSachVe;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (dgvVe.CurrentRow != null)
            {
                int maVe = (int)dgvVe.CurrentRow.Cells["MaVe"].Value;

                // Include để load cả ChuyenTau
                var ve = _context.VeTaus
                                 .Include(v => v.ChuyenTau)
                                 .FirstOrDefault(v => v.MaVe == maVe);

                if (ve != null)
                {
                    if (ve.ChuyenTau != null && ve.ChuyenTau.ThoiGianKhoiHanh <= DateTime.Now)
                    {
                        MessageBox.Show("Chuyến tàu này đã khởi hành, không thể hủy vé!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn hủy vé này không?",
                        "Xác nhận hủy vé",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        ve.TrangThai = "Đã hủy";
                        _context.SaveChanges();
                        MessageBox.Show("Hủy vé thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadVeKhachHang(); // Refresh danh sách vé
                    }
                }
            }
        }

        private void FormVeHanhKhach_Load(object sender, EventArgs e)
        {
            LoadVeKhachHang();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDatVe formdatve = new FormDatVe(_maHanhKhach);
            formdatve.Show();
            this.Close();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
