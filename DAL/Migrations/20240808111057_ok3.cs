using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ok3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHangs_KhachHangSDT",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanViens_NhanVienId",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_KhachHangSDT",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "KhachHangSDT",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "NhanVienId",
                table: "HoaDon");

            migrationBuilder.AlterColumn<string>(
                name: "IdKhach",
                table: "HoaDon",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKhach",
                table: "HoaDon",
                column: "IdKhach");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHangs_IdKhach",
                table: "HoaDon",
                column: "IdKhach",
                principalTable: "KhachHangs",
                principalColumn: "SDT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanViens_IdNhanVien",
                table: "HoaDon",
                column: "IdNhanVien",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_KhachHangs_IdKhach",
                table: "HoaDon");

            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanViens_IdNhanVien",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_IdKhach",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_IdNhanVien",
                table: "HoaDon");

            migrationBuilder.AlterColumn<string>(
                name: "IdKhach",
                table: "HoaDon",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "KhachHangSDT",
                table: "HoaDon",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "NhanVienId",
                table: "HoaDon",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangSDT",
                table: "HoaDon",
                column: "KhachHangSDT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_KhachHangs_KhachHangSDT",
                table: "HoaDon",
                column: "KhachHangSDT",
                principalTable: "KhachHangs",
                principalColumn: "SDT",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanViens_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId",
                principalTable: "NhanViens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
