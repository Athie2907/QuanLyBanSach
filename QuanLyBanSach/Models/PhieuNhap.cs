using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Models
{
    public class PhieuNhap
    {
        public int MaPhieuNhap { get; set; }

        public DateTime? NgayLapPhieuNhap { get; set; }

        public string? TenNhaCungCap { get; set; }

        public ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
            = new List<ChiTietPhieuNhap>();
    }
}
