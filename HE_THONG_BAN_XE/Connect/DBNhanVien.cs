using HE_THONG_BAN_XE.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HE_THONG_BAN_XE.Connect
{
    internal class DBNhanVien : DbContext
    {
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<Xe> xes { get; set; }
        public DbSet<ChiTietHoaDon> chiTietHoaDons { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<KhuyenMai> khuyenMais { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CSDL_DoAn1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // KHÁCH HÀNG - HÓA ĐƠN
            modelBuilder.Entity<HoaDon>()
                .HasOne(h => h.KhachHang)
                .WithMany(k => k.HoaDons)
                .HasForeignKey(h => h.MaKH)
                .HasConstraintName("FK_HoaDon_KhachHang");

            // KHÁCH HÀNG - CHI TIẾT HÓA ĐƠN
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.KhachHang)
                .WithMany(kh => kh.ChiTietHoaDons)
                .HasForeignKey(ct => ct.MaKH)
                .HasConstraintName("FK_ChiTietHoaDon_KhachHang");

            // XE - CHI TIẾT HÓA ĐƠN
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.Xe)
                .WithMany(xe => xe.ChiTietHoaDons)
                .HasForeignKey(ct => ct.MaXe)
                .HasConstraintName("FK_ChiTietHoaDon_Xe");

            // KHUYẾN MÃI - CHI TIẾT HÓA ĐƠN
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.KhuyenMai)
                .WithMany()
                .HasForeignKey(ct => ct.MaKM)
                .HasConstraintName("FK_ChiTietHoaDon_KhuyenMai");

            // HÓA ĐƠN - CHI TIẾT HÓA ĐƠN
            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(hd => hd.ChiTietHoaDons)
                .HasForeignKey(ct => ct.MaHD)
                .HasConstraintName("FK_ChiTietHoaDon_HoaDon");
        }
    }
}
