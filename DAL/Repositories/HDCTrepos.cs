using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HDCTrepos
    {
        LaptopContext context;
        public HDCTrepos()
        {
            context = new LaptopContext();
        }
        public List<HoaDonChiTiet> GetAllByHD(int idHD)
        {
            return context.HoaDonChiTiets.Where(p => p.IdHoaDon == idHD).ToList();
        }
        public bool Createhdct(int soluong, int maSP, int MaHD, decimal Gia)
        {
            HoaDonChiTiet hdct = new HoaDonChiTiet()
            {
                Gia= Gia,SoLuongSanPham=soluong,IdSanPham=maSP,IdHoaDon=MaHD
            };
            try {
                context.HoaDonChiTiets.Add(hdct);
                context.SaveChanges();
                return true;
            }
          catch 
            {
                return false;
            }
             
        }
    }
}
