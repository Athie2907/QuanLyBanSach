using Microsoft.EntityFrameworkCore;
using QuanLyBanSach.Models;

namespace QuanLyBanSach.Data
{
    public class QuanLyBanSachContext : DbContext
    {
        public DbSet<LoaiSach> LoaiSachs { get; set; }

        public DbSet<Sach> Saches { get; set; }

        public DbSet<HoaDon> HoaDons { get; set; }

        public DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public DbSet<PhieuNhap> PhieuNhaps { get; set; }

        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=Athie\SQLEXPRESS;
                      Database=db_QuanLyBanSach;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // BẢNG LOẠI SÁCH
            modelBuilder.Entity<LoaiSach>(entity =>
            {
                entity.ToTable("tbl_loai_sach");

                entity.HasKey(e => e.MaLoaiSach);

                entity.Property(e => e.MaLoaiSach)
                    .HasColumnName("ma_loai_sach")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenLoaiSach)
                    .HasColumnName("ten_loai_sach")
                    .HasMaxLength(100)
                    .IsRequired();
            });

            // BẢNG SÁCH
            modelBuilder.Entity<Sach>(entity =>
            {
                entity.ToTable("tbl_sach");

                entity.HasKey(e => e.MaSach);

                entity.Property(e => e.MaSach)
                    .HasColumnName("ma_sach")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TenSach)
                    .HasColumnName("ten_sach")
                    .HasMaxLength(200)
                    .IsRequired();

                entity.Property(e => e.MaLoaiSach)
                    .HasColumnName("ma_loai_sach");

                entity.Property(e => e.TacGia)
                    .HasColumnName("tac_gia")
                    .HasMaxLength(100);

                entity.Property(e => e.SoLuong)
                    .HasColumnName("so_luong");

                entity.Property(e => e.GiaBan)
                    .HasColumnName("gia_ban")
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(e => e.LoaiSach)
                    .WithMany(e => e.Saches)
                    .HasForeignKey(e => e.MaLoaiSach);
            });

            // BẢNG HÓA ĐƠN
            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.ToTable("tbl_hoa_don");

                entity.HasKey(e => e.MaHoaDon);

                entity.Property(e => e.MaHoaDon)
                    .HasColumnName("ma_hoa_don")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NgayLapHoaDon)
                    .HasColumnName("ngay_lap_hoa_don")
                    .HasColumnType("date");

                entity.Property(e => e.TenKhachHang)
                    .HasColumnName("ten_khach_hang")
                    .HasMaxLength(100);

                entity.Property(e => e.SdtKhachHang)
                    .HasColumnName("sdt_khach_hang")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            // BẢNG CHI TIẾT HÓA ĐƠN
            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.ToTable("tbl_chi_tiet_hoa_don");

                entity.HasKey(e => new { e.MaHoaDon, e.MaSach });

                entity.Property(e => e.MaHoaDon)
                    .HasColumnName("ma_hoa_don");

                entity.Property(e => e.MaSach)
                    .HasColumnName("ma_sach");

                entity.Property(e => e.SoLuong)
                    .HasColumnName("so_luong");

                entity.HasOne(e => e.HoaDon)
                    .WithMany(e => e.ChiTietHoaDons)
                    .HasForeignKey(e => e.MaHoaDon);

                entity.HasOne(e => e.Sach)
                    .WithMany()
                    .HasForeignKey(e => e.MaSach);
            });

            // BẢNG PHIẾU NHẬP
            modelBuilder.Entity<PhieuNhap>(entity =>
            {
                entity.ToTable("tbl_phieu_nhap");

                entity.HasKey(e => e.MaPhieuNhap);

                entity.Property(e => e.MaPhieuNhap)
                    .HasColumnName("ma_phieu_nhap")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NgayLapPhieuNhap)
                    .HasColumnName("ngay_lap_phieu_nhap")
                    .HasColumnType("date");

                entity.Property(e => e.TenNhaCungCap)
                    .HasColumnName("ten_nha_cung_cap")
                    .HasMaxLength(150);
            });

            // BẢNG CHI TIẾT PHIẾU NHẬP
            modelBuilder.Entity<ChiTietPhieuNhap>(entity =>
            {
                entity.ToTable("tbl_chi_tiet_phieu_nhap");

                entity.HasKey(e => new { e.MaPhieuNhap, e.MaSach });

                entity.Property(e => e.MaPhieuNhap)
                    .HasColumnName("ma_phieu_nhap");

                entity.Property(e => e.MaSach)
                    .HasColumnName("ma_sach");

                entity.Property(e => e.SoLuong)
                    .HasColumnName("so_luong");

                entity.HasOne(e => e.PhieuNhap)
                    .WithMany(e => e.ChiTietPhieuNhaps)
                    .HasForeignKey(e => e.MaPhieuNhap);

                entity.HasOne(e => e.Sach)
                    .WithMany()
                    .HasForeignKey(e => e.MaSach);
            });
        }
    }
}
