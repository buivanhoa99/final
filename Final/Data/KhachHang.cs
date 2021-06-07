using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class KhachHang
    {
        public KhachHang(int maKhach, string tenDN, string tenKhach)
        {
            MaKhach = maKhach;
            TenDN = tenDN;
            TenKhach = tenKhach;
        }

        [Key]
        public int MaKhach { get; set; }
        public string TenDN { get; set; }
        public string TenKhach { get; set; }
        public IList<DonHang> DonHangs { get; set; }

    }
}
