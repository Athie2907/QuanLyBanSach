using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Models
{
    public class ChiTietHoaDon
    {
        public int MaHoaDon { get; set; }

        public int MaSach { get; set; }

        public int? SoLuong { get; set; }

        public HoaDon? HoaDon { get; set; }

        public Sach? Sach { get; set; }
    }
}
