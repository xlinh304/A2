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
    public partial class FormThongKe : Form
    {
        private readonly AppDbContext _context = new AppDbContext();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            dtpTu.Value = DateTime.Now.AddMonths(-1);
            dtpDen.Value = DateTime.Now;
            loaddata();
        }
        private void loaddata()
        {
            DateTime tungay = dtpTu.Value.Date;
            DateTime denngay = dtpDen.Value.Date.AddDays(1).AddSeconds(-1);
            var danhsach = _context.VeTaus.Where(v => v.NgayDat >= tungay && v.NgayDat <= denngay && v.TrangThai == "Đã Đặt")
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
                }).ToList();
            dgvThongKe.DataSource = danhsach;
            decimal tongDoanhThu = danhsach.Sum(v => v.GiaVe);
            int tongVeDaDat = danhsach.Count;
            lblTongDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:C}";
            lblTongSoVe.Text = $"Tổng vé đã đặt: {tongVeDaDat}";
        }
    }
}
