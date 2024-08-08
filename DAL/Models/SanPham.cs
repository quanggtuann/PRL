using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int IdSanPham { get; set; }
        public string? TenSanPham { get; set; }
        public string? HangSanXuat { get; set; }
        public string? Cpu { get; set; }
        public int? Ram { get; set; }
        public int? Rom { get; set; }
        public string? Gpu { get; set; }
        public string? ManHinh { get; set; }
        public string? Pin { get; set; }
        public decimal? Gia { get; set; }
        public int? SoLuong { get; set; }
        public string? Img { get; set; }
        public bool? TrangThai { get; set; }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
