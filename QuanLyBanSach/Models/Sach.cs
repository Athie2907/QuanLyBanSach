using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Models
{
    public class Sach
    {
        public int MaSach { get; set; }

        public string TenSach { get; set; } = string.Empty;

        public int? MaLoaiSach { get; set; }

        public string? TacGia { get; set; }

        public int? SoLuong { get; set; }

        public decimal? GiaBan { get; set; }

        public LoaiSach? LoaiSach { get; set; }
    }
}
