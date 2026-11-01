using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Models
{
    public class HoaDon
    {
        public int MaHoaDon { get; set; }

        public DateTime? NgayLapHoaDon { get; set; }

        public string? TenKhachHang { get; set; }

        public string? SdtKhachHang { get; set; }

        public ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
            = new List<ChiTietHoaDon>();
    }
}
