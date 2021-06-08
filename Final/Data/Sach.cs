using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class Sach
    {
        public Sach()
        {
        }

        public Sach(int maSach, string tenSach, string hinh, int donGia, string mota, int maLoai)
        {
            MaSach = maSach;
            TenSach = tenSach;
            Hinh = hinh;
            DonGia = donGia;
            Mota = mota;
            MaLoai = maLoai;
        }
        [Key]
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string Hinh { get; set; }
        public int DonGia { get; set; }
        public string Mota { get; set; }
        public int MaLoai { get; set; }
        public LoaiSach LoaiSach { get; set; }
        public IList<DonHang> DonHangs { get; set; }

    }
}
