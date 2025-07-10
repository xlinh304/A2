using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace quanlibanvetau2.Migrations
{
    /// <inheritdoc />
    public partial class tau : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChuyenTaus",
                columns: table => new
                {
                    MaChuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GaDi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GaDen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianKhoiHanh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianDen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongSoGhe = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenTaus", x => x.MaChuyen);
                });

            migrationBuilder.CreateTable(
                name: "HanhKhaches",
                columns: table => new
                {
                    MaHanhKhach = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CMND = table.Column<int>(type: "int", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HanhKhaches", x => x.MaHanhKhach);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNV = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNV);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoans",
                columns: table => new
                {
                    TenDangNhap = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: true),
                    MaHanhKhach = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoans", x => x.TenDangNhap);
                    table.ForeignKey(
                        name: "FK_TaiKhoans_HanhKhaches_MaHanhKhach",
                        column: x => x.MaHanhKhach,
                        principalTable: "HanhKhaches",
                        principalColumn: "MaHanhKhach");
                    table.ForeignKey(
                        name: "FK_TaiKhoans_NhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanViens",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "ThongKes",
                columns: table => new
                {
                    MaThongKe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaChuyen = table.Column<int>(type: "int", nullable: true),
                    MaNV = table.Column<int>(type: "int", nullable: true),
                    TongVeDaBan = table.Column<int>(type: "int", nullable: false),
                    DoanhThu = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongKes", x => x.MaThongKe);
                    table.ForeignKey(
                        name: "FK_ThongKes_ChuyenTaus_MaChuyen",
                        column: x => x.MaChuyen,
                        principalTable: "ChuyenTaus",
                        principalColumn: "MaChuyen");
                    table.ForeignKey(
                        name: "FK_ThongKes_NhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanViens",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "VeTaus",
                columns: table => new
                {
                    MaVe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaChuyen = table.Column<int>(type: "int", nullable: true),
                    MaHanhKhach = table.Column<int>(type: "int", nullable: true),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoGhe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaVe = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VeTaus", x => x.MaVe);
                    table.ForeignKey(
                        name: "FK_VeTaus_ChuyenTaus_MaChuyen",
                        column: x => x.MaChuyen,
                        principalTable: "ChuyenTaus",
                        principalColumn: "MaChuyen");
                    table.ForeignKey(
                        name: "FK_VeTaus_HanhKhaches_MaHanhKhach",
                        column: x => x.MaHanhKhach,
                        principalTable: "HanhKhaches",
                        principalColumn: "MaHanhKhach");
                    table.ForeignKey(
                        name: "FK_VeTaus_NhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanViens",
                        principalColumn: "MaNV");
                });

            migrationBuilder.InsertData(
                table: "ChuyenTaus",
                columns: new[] { "MaChuyen", "GaDen", "GaDi", "TenTau", "ThoiGianDen", "ThoiGianKhoiHanh", "TongSoGhe" },
                values: new object[,]
                {
                    { 1, "Sài Gòn", "Hà Nội", "SE1", new DateTime(2025, 7, 2, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), 100 },
                    { 2, "Nha Trang", "Đà Nẵng", "SE2", new DateTime(2025, 7, 3, 14, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 3, 8, 0, 0, 0, DateTimeKind.Unspecified), 80 },
                    { 3, "Sài Gòn", "Huế", "SE3", new DateTime(2025, 7, 6, 1, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 5, 9, 0, 0, 0, DateTimeKind.Unspecified), 120 }
                });

            migrationBuilder.InsertData(
                table: "HanhKhaches",
                columns: new[] { "MaHanhKhach", "CMND", "DiaChi", "DienThoai", "HoTen" },
                values: new object[,]
                {
                    { 1, 123456789, "Hà Nội", "0911000111", "Phạm Thị D" },
                    { 2, 234567890, "Đà Nẵng", "0922000222", "Ngô Văn E" },
                    { 3, 345678901, "HCM", "0933000333", "Đỗ Thị F" }
                });

            migrationBuilder.InsertData(
                table: "NhanViens",
                columns: new[] { "MaNV", "SoDienThoai", "TenNV" },
                values: new object[,]
                {
                    { 1, "0909123456", "Nguyễn Văn A" },
                    { 2, "0988777666", "Trần Thị B" },
                    { 3, "0933555777", "Lê Văn C" }
                });

            migrationBuilder.InsertData(
                table: "TaiKhoans",
                columns: new[] { "TenDangNhap", "MaHanhKhach", "MaNV", "MatKhau", "VaiTro" },
                values: new object[,]
                {
                    { "admin", null, 1, "123", "Admin" },
                    { "khach", 1, null, "xyz", "KhachHang" },
                    { "nhanvien", null, 2, "abc", "NhanVien" }
                });

            migrationBuilder.InsertData(
                table: "ThongKes",
                columns: new[] { "MaThongKe", "DoanhThu", "MaChuyen", "MaNV", "Ngay", "TongVeDaBan" },
                values: new object[,]
                {
                    { 1, 500000m, 1, 1, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, 450000m, 2, 2, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 600000m, 3, 3, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "VeTaus",
                columns: new[] { "MaVe", "GiaVe", "MaChuyen", "MaHanhKhach", "MaNV", "NgayDat", "SoGhe", "TrangThai" },
                values: new object[,]
                {
                    { 1, 500000m, 1, 1, 1, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "A01", "DaDat" },
                    { 2, 450000m, 2, 2, 2, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "B02", "DaDat" },
                    { 3, 600000m, 3, 3, 3, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "C03", "DaDat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_MaHanhKhach",
                table: "TaiKhoans",
                column: "MaHanhKhach");

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoans_MaNV",
                table: "TaiKhoans",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKes_MaChuyen",
                table: "ThongKes",
                column: "MaChuyen");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKes_MaNV",
                table: "ThongKes",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_VeTaus_MaChuyen",
                table: "VeTaus",
                column: "MaChuyen");

            migrationBuilder.CreateIndex(
                name: "IX_VeTaus_MaHanhKhach",
                table: "VeTaus",
                column: "MaHanhKhach");

            migrationBuilder.CreateIndex(
                name: "IX_VeTaus_MaNV",
                table: "VeTaus",
                column: "MaNV");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaiKhoans");

            migrationBuilder.DropTable(
                name: "ThongKes");

            migrationBuilder.DropTable(
                name: "VeTaus");

            migrationBuilder.DropTable(
                name: "ChuyenTaus");

            migrationBuilder.DropTable(
                name: "HanhKhaches");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
