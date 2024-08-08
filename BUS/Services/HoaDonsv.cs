using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HoaDonsv
    {
        HoaDonrepos _rp;
        public HoaDonsv()
        {
            _rp = new HoaDonrepos();
        }
        public List<HoaDon> Getall()
        {
            return _rp.Getall();
        }
       public string Create(Guid idNV,string idKH)
        {
            HoaDon hoaDon = new HoaDon()
            {
                IdKhach = idKH, IdNhanVien = idNV,
                NgayTao = DateTime.Now,
                GhiChu = "Laptop",
                ThanhTien=0,
                TrangThai ="1"
            };
            if (_rp.Create(hoaDon))
            {
                return "tạo tành công";
            }
            else return "Tạo Thất Bại";
        }
    }
}
