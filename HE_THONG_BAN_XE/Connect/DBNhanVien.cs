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
        public DbSet<NhanVien> nhanViens {  get; set; }
        public DbSet<Xe> xes { get; set; }
        public DbSet<HoaDon> hoaDons { get; set; }
        public DbSet<KhachHang> khachHangs { get; set; }
        public DbSet<KhachHangDaKhuyenMai> khachHangDaKhuyenMais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=CSDL_DoAn1;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // KHÓA NGOẠI: HoaDon → KhachHang
            modelBuilder.Entity<HoaDon>()
                .HasOne<KhachHang>()
                .WithMany()
                .HasForeignKey(h => h.MaKH)
                .HasConstraintName("FK_HoaDon_KhachHang");

            // KHÓA NGOẠI: HoaDon → Xe
            modelBuilder.Entity<HoaDon>()
                .HasOne<Xe>()
                .WithMany()
                .HasForeignKey(h => h.MaXe)
                .HasConstraintName("FK_HoaDon_Xe");

            // KHÓA NGOẠI: KhachHangDaKhuyenMai → KhachHang
            modelBuilder.Entity<KhachHangDaKhuyenMai>()
                .HasOne<KhachHang>()
                .WithMany()
                .HasForeignKey(k => k.MaKH)
                .HasConstraintName("FK_KhuyenMai_KhachHang");
        }

    }
}
