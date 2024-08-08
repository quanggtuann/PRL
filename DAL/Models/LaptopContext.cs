using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DAL.Models
{
    public partial class LaptopContext : DbContext
    {
        public LaptopContext()
        {
        }

        public LaptopContext(DbContextOptions<LaptopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; } = null!;
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<Voucher> Vouchers { get; set; } = null!;
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<NhanVien> NhanViens { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-6F007S99;Database=Laptop_01;User Id=SA;Password=12345;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.IdHoaDon)
                    .HasName("PK__HoaDon__14AFCFC572CFA4AA");

                entity.ToTable("HoaDon");

                entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.NgayTao).HasColumnType("datetime");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(32)
                    .IsFixedLength();
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => e.IdHoaDonChiTiet)
                    .HasName("PK__HoaDonCh__A6583769B0D9A127");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.IdHoaDonChiTiet).HasColumnName("ID_HoaDonChiTiet");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.IdHoaDon).HasColumnName("ID_HoaDon");

                entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");

                entity.Property(e => e.IdVoucher).HasColumnName("ID_Voucher");

                entity.Property(e => e.PhuongThucThanhToan).HasMaxLength(255);

                entity.HasOne(d => d.IdHoaDonNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdHoaDon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__ID_Ho__440B1D61");

                entity.HasOne(d => d.IdSanPhamNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdSanPham)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__ID_Sa__44FF419A");

                entity.HasOne(d => d.IdVoucherNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.IdVoucher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChi__ID_Vo__45F365D3");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdSanPham)
                    .HasName("PK__SanPham__617EA39232199A0C");

                entity.ToTable("SanPham");

                entity.Property(e => e.IdSanPham).HasColumnName("ID_SanPham");

                entity.Property(e => e.Cpu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CPU");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.Gpu)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GPU");

                entity.Property(e => e.HangSanXuat).HasMaxLength(255);

                entity.Property(e => e.Img)
                    .HasMaxLength(1000)
                    .HasColumnName("IMG");

                entity.Property(e => e.ManHinh).HasMaxLength(200);

                entity.Property(e => e.Pin).HasMaxLength(200);

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.Property(e => e.Rom).HasColumnName("ROM");

                entity.Property(e => e.TenSanPham).HasMaxLength(255);
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.IdVoucher)
                    .HasName("PK__Voucher__7D975E3EAE6101D1");

                entity.ToTable("Voucher");

                entity.HasIndex(e => e.MaGiamGia, "UQ__Voucher__EF9458E598139C77")
                    .IsUnique();

                entity.Property(e => e.IdVoucher).HasColumnName("ID_Voucher");

                entity.Property(e => e.HieuLucDen).HasColumnType("datetime");

                entity.Property(e => e.MaGiamGia)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.NgayRaMat).HasColumnType("datetime");

                entity.Property(e => e.TrangThai)
                    .HasMaxLength(32)
                    .IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
