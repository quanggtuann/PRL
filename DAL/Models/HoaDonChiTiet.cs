using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDonChiTiet
    {
        public int IdHoaDonChiTiet { get; set; }
        public int IdHoaDon { get; set; }
        public int IdSanPham { get; set; }
        public int IdVoucher { get; set; }
        public int? SoLuongSanPham { get; set; }
        public decimal? Gia { get; set; }
        public bool? TrangThai { get; set; }
        public string? PhuongThucThanhToan { get; set; }

        public virtual HoaDon IdHoaDonNavigation { get; set; } = null!;
        public virtual SanPham IdSanPhamNavigation { get; set; } = null!;
        public virtual Voucher IdVoucherNavigation { get; set; } = null!;
    }
}
