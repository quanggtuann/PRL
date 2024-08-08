using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Voucher
    {
        public Voucher()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int IdVoucher { get; set; }
        public string? MaGiamGia { get; set; }
        public int? PhanTramGiamGia { get; set; }
        public DateTime? NgayRaMat { get; set; }
        public DateTime? HieuLucDen { get; set; }
        public string? TrangThai { get; set; }

        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }
    }
}
