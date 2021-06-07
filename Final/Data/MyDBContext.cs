using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class MyDBContext : DbContext
    {
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<LoaiSach> LoaiSachs { get; set; }
        public DbSet<Sach> Sachs { get; set; }

        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Sach>()
                            .HasOne<LoaiSach>(s => s.LoaiSach)
                            .WithMany(ls => ls.Sachs)
                            .HasForeignKey(s => s.MaLoai);
            modelBuilder.Entity<DonHang>()
                            .HasKey(dh => new { dh.MaKhach, dh.MaSach });

            modelBuilder.Entity<DonHang>()
                            .HasOne<KhachHang>(dh => dh.KhachHang)
                            .WithMany(kh => kh.DonHangs)
                            .HasForeignKey(dh => dh.MaKhach);
            modelBuilder.Entity<DonHang>()
                .HasOne<Sach>(dh => dh.Sach)
                .WithMany(s => s.DonHangs)
                .HasForeignKey(dh => dh.MaSach);

            modelBuilder.Entity<KhachHang>().HasData(
                    new KhachHang(1,"DN1","Không Gia Đình"),
                    new KhachHang(2, "DN2", "Một món quà"),
                    new KhachHang(3, "DN3", "Tam quốc diễn nghĩa")

                );
            modelBuilder.Entity<LoaiSach>().HasData(
                    new LoaiSach(1,"Trinh Thám"),
                    new LoaiSach(2, "Hài Hước"),
                    new LoaiSach(3, "Self-help")

                );
            modelBuilder.Entity<Sach>().HasData(
                    new Sach(1, "Harry Potter", "https://vtv1.mediacdn.vn/thumb_w/650/2019/9/3/17988102-7420621-the8bookpotterseriesandotherrelatedstoriesaudiorecordi-a-61567460030727-15674958768921527956477.jpg",
                    200000, "Harry Potter Full", 1),
                    new Sach(2, "Không Gia Đình", "https://dep.com.vn/wp-content/uploads/2018/11/khong-gia-dinh-1.jpg", 350000, "Sách 1st seller", 2)

                );
            modelBuilder.Entity<DonHang>().HasData(
                    new DonHang(1, 2, 20),
                    new DonHang(2, 1, 10),
                    new DonHang(3, 2, 2)

                );

            ;
        }
    }
}
