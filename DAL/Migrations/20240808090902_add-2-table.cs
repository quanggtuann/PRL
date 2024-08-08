using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class add2table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    SDT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.SDT);
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    ID_SanPham = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSanPham = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    HangSanXuat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CPU = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RAM = table.Column<int>(type: "int", nullable: true),
                    ROM = table.Column<int>(type: "int", nullable: true),
                    GPU = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ManHinh = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Pin = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Gia = table.Column<decimal>(type: "money", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    IMG = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SanPham__617EA39232199A0C", x => x.ID_SanPham);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    ID_Voucher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaGiamGia = table.Column<string>(type: "varchar(32)", unicode: false, maxLength: 32, nullable: true),
                    PhanTramGiamGia = table.Column<int>(type: "int", nullable: true),
                    NgayRaMat = table.Column<DateTime>(type: "datetime", nullable: true),
                    HieuLucDen = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThai = table.Column<string>(type: "nchar(32)", fixedLength: true, maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Voucher__7D975E3EAE6101D1", x => x.ID_Voucher);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    ID_HoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayTao = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrangThai = table.Column<string>(type: "nchar(32)", fixedLength: true, maxLength: 32, nullable: true),
                    ThanhTien = table.Column<long>(type: "bigint", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangSDT = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDon__14AFCFC572CFA4AA", x => x.ID_HoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHangs_KhachHangSDT",
                        column: x => x.KhachHangSDT,
                        principalTable: "KhachHangs",
                        principalColumn: "SDT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanViens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    ID_HoaDonChiTiet = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_HoaDon = table.Column<int>(type: "int", nullable: false),
                    ID_SanPham = table.Column<int>(type: "int", nullable: false),
                    ID_Voucher = table.Column<int>(type: "int", nullable: false),
                    SoLuongSanPham = table.Column<int>(type: "int", nullable: true),
                    Gia = table.Column<decimal>(type: "money", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: true),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__HoaDonCh__A6583769B0D9A127", x => x.ID_HoaDonChiTiet);
                    table.ForeignKey(
                        name: "FK__HoaDonChi__ID_Ho__440B1D61",
                        column: x => x.ID_HoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "ID_HoaDon");
                    table.ForeignKey(
                        name: "FK__HoaDonChi__ID_Sa__44FF419A",
                        column: x => x.ID_SanPham,
                        principalTable: "SanPham",
                        principalColumn: "ID_SanPham");
                    table.ForeignKey(
                        name: "FK__HoaDonChi__ID_Vo__45F365D3",
                        column: x => x.ID_Voucher,
                        principalTable: "Voucher",
                        principalColumn: "ID_Voucher");
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangSDT",
                table: "HoaDon",
                column: "KhachHangSDT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_ID_HoaDon",
                table: "HoaDonChiTiet",
                column: "ID_HoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_ID_SanPham",
                table: "HoaDonChiTiet",
                column: "ID_SanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_ID_Voucher",
                table: "HoaDonChiTiet",
                column: "ID_Voucher");

            migrationBuilder.CreateIndex(
                name: "UQ__Voucher__EF9458E598139C77",
                table: "Voucher",
                column: "MaGiamGia",
                unique: true,
                filter: "[MaGiamGia] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");
        }
    }
}
