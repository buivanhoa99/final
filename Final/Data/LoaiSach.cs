using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Data
{
    public class LoaiSach
    {
        public LoaiSach(int maLoai, string tenLoai)
        {
            MaLoai = maLoai;
            TenLoai = tenLoai;
        }

        [Key]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }

        public ICollection<Sach> Sachs { get; set; }
    }
}
