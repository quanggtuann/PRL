using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            HoaDonChiTiets = new HashSet<HoaDonChiTiet>();
        }

        public int IdHoaDon { get; set; }
        public DateTime? NgayTao { get; set; }
        public string? TrangThai { get; set; }
        public long? ThanhTien { get; set; }
        public string? GhiChu { get; set; }
        [ForeignKey(nameof(NhanVien))]
        public Guid IdNhanVien { get; set; }
        [ForeignKey(nameof(KhachHang))]
        public string IdKhach { get; set; }
        public virtual ICollection<HoaDonChiTiet> HoaDonChiTiets { get; set; }

        public virtual NhanVien NhanVien { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
