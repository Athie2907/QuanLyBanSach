using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanSach.Models
{
    public class LoaiSach
    {
        public int MaLoaiSach { get; set; }

        public string TenLoaiSach { get; set; } = string.Empty;

        public ICollection<Sach> Saches { get; set; }
            = new List<Sach>();
    }
}
