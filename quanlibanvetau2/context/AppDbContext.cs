using Microsoft.EntityFrameworkCore;
using quanlibanvetau.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlibanvetau1.context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<ChuyenTau> ChuyenTaus { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<HanhKhach> HanhKhaches { get; set; }
        public DbSet<VeTau> VeTaus { get; set; }
        public DbSet<ThongKe> ThongKes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-53GCMEP\SQLEXPRESS;Initial Catalog=quanlibanvetau2;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ChuyenTau>().HasData(
        new ChuyenTau { MaChuyen = 1, TenTau = "SE1", GaDi = "Hà Nội", GaDen = "Sài Gòn", ThoiGianKhoiHanh = new DateTime(2025, 7, 1, 6, 0, 0), ThoiGianDen = new DateTime(2025, 7, 2, 10, 0, 0), TongSoGhe = 100, GiaVe=100000 },
        new ChuyenTau { MaChuyen = 2, TenTau = "SE2", GaDi = "Đà Nẵng", GaDen = "Nha Trang", ThoiGianKhoiHanh = new DateTime(2025, 7, 3, 8, 0, 0), ThoiGianDen = new DateTime(2025, 7, 3, 14, 0, 0), TongSoGhe = 80, GiaVe=300000 },
        new ChuyenTau { MaChuyen = 3, TenTau = "SE3", GaDi = "Huế", GaDen = "Sài Gòn", ThoiGianKhoiHanh = new DateTime(2025, 7, 5, 9, 0, 0), ThoiGianDen = new DateTime(2025, 7, 6, 1, 0, 0), TongSoGhe = 120 , GiaVe=400000}
    );


            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien { MaNV = 1, TenNV = "Nguyễn Văn A", SoDienThoai = "0909123456" },
                new NhanVien { MaNV = 2, TenNV = "Trần Thị B", SoDienThoai = "0988777666" },
                new NhanVien { MaNV = 3, TenNV = "Lê Văn C", SoDienThoai = "0933555777" }
            );

            modelBuilder.Entity<HanhKhach>().HasData(
                new HanhKhach { MaHanhKhach = 1, HoTen = "Phạm Thị D", CMND = 123456789, DienThoai = "0911000111", DiaChi = "Hà Nội" },
                new HanhKhach { MaHanhKhach = 2, HoTen = "Ngô Văn E", CMND = 234567890, DienThoai = "0922000222", DiaChi = "Đà Nẵng" },
                new HanhKhach { MaHanhKhach = 3, HoTen = "Đỗ Thị F", CMND = 345678901, DienThoai = "0933000333", DiaChi = "HCM" }
            );


            modelBuilder.Entity<TaiKhoan>().HasData(
                new TaiKhoan { TenDangNhap = "admin", MatKhau = "123", VaiTro = "Admin", MaNV = 1, MaHanhKhach = null },
                new TaiKhoan { TenDangNhap = "nhanvien", MatKhau = "abc", VaiTro = "NhanVien", MaNV = 2, MaHanhKhach = null },
                new TaiKhoan { TenDangNhap = "khach", MatKhau = "xyz", VaiTro = "KhachHang", MaNV = null, MaHanhKhach = 1 }
            );

            modelBuilder.Entity<VeTau>().HasData(
                new VeTau { MaVe = 1, MaChuyen = 1, MaHanhKhach = 1, NgayDat = new DateTime(2025, 6, 30), SoGhe = "A01",  TrangThai = "DaDat", MaNV = 1 },
                new VeTau { MaVe = 2, MaChuyen = 2, MaHanhKhach = 2, NgayDat = new DateTime(2025, 6, 30), SoGhe = "B02",  TrangThai = "DaDat", MaNV = 2 },
                new VeTau { MaVe = 3, MaChuyen = 3, MaHanhKhach = 3, NgayDat = new DateTime(2025, 6, 30), SoGhe = "C03",  TrangThai = "DaDat", MaNV = 3 }
            );

            modelBuilder.Entity<ThongKe>().HasData(
                new ThongKe { MaThongKe = 1, Ngay = new DateTime(2025, 6, 30), MaChuyen = 1, TongVeDaBan = 1, DoanhThu = 500000, MaNV = 1 },
                new ThongKe { MaThongKe = 2, Ngay = new DateTime(2025, 6, 30), MaChuyen = 2, TongVeDaBan = 1, DoanhThu = 450000, MaNV = 2 },
                new ThongKe { MaThongKe = 3, Ngay = new DateTime(2025, 6, 30), MaChuyen = 3, TongVeDaBan = 1, DoanhThu = 600000, MaNV = 3 }
            );
        }
    }
    
}
