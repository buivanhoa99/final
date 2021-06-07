using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class DonHang
    {
        public DonHang(int maKhach, int maSach, int soLuong)
        {
            MaKhach = maKhach;
            MaSach = maSach;
            SoLuong = soLuong;
        }

        public int MaKhach { get; set; }
        public KhachHang KhachHang { get; set; }
        public int MaSach { get; set; }
        public Sach Sach { get; set; }
        public int SoLuong { get; set; }
    }
}
