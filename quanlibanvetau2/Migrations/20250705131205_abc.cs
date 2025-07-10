using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace quanlibanvetau2.Migrations
{
    /// <inheritdoc />
    public partial class abc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GiaVe",
                table: "ChuyenTaus",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "ChuyenTaus",
                keyColumn: "MaChuyen",
                keyValue: 1,
                column: "GiaVe",
                value: 100000m);

            migrationBuilder.UpdateData(
                table: "ChuyenTaus",
                keyColumn: "MaChuyen",
                keyValue: 2,
                column: "GiaVe",
                value: 300000m);

            migrationBuilder.UpdateData(
                table: "ChuyenTaus",
                keyColumn: "MaChuyen",
                keyValue: 3,
                column: "GiaVe",
                value: 400000m);

            migrationBuilder.UpdateData(
                table: "VeTaus",
                keyColumn: "MaVe",
                keyValue: 1,
                column: "GiaVe",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "VeTaus",
                keyColumn: "MaVe",
                keyValue: 2,
                column: "GiaVe",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "VeTaus",
                keyColumn: "MaVe",
                keyValue: 3,
                column: "GiaVe",
                value: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GiaVe",
                table: "ChuyenTaus");

            migrationBuilder.UpdateData(
                table: "VeTaus",
                keyColumn: "MaVe",
                keyValue: 1,
                column: "GiaVe",
                value: 500000m);

            migrationBuilder.UpdateData(
                table: "VeTaus",
                keyColumn: "MaVe",
                keyValue: 2,
                column: "GiaVe",
                value: 450000m);

            migrationBuilder.UpdateData(
                table: "VeTaus",
                keyColumn: "MaVe",
                keyValue: 3,
                column: "GiaVe",
                value: 600000m);
        }
    }
}
