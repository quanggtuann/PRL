using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.SanPhamRepos
{
    public class SanPhamRepos
    {
        LaptopContext _context;
        public SanPhamRepos()
        {
            _context = new LaptopContext();
        }
        public List<SanPham> Getall()
        {
            return _context.SanPhams.ToList();

        }
        public SanPham Getbyid(int id)
        {
            return _context.SanPhams.Find(id);
        }
        public bool CreateSP(SanPham sp)
        {
            try
            {
                _context.SanPhams.Add(sp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool Update(SanPham sp, int id)
        {
            try
            {
                var update = _context.SanPhams.Find(id);
                update.TenSanPham = sp.TenSanPham;
                update.HangSanXuat = sp.HangSanXuat;
                update.Cpu = sp.Cpu;
                update.Gpu = sp.Gpu;
                update.Ram = sp.Ram;
                update.Rom = sp.Rom;
                update.ManHinh = sp.ManHinh;
                update.Pin = sp.Pin;
                update.Gia = sp.Gia;
                update.SoLuong = sp.SoLuong;
                update.Img = sp.Img;
                update.TrangThai = sp.TrangThai;
                _context.SanPhams.Update(update);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<SanPham> Timkiem(string ten)
        {
            return _context.SanPhams.Where(p => p.TenSanPham.Contains(ten)).ToList();
        }

        public List<SanPham> Timkiemid(int id)
        {
            return _context.SanPhams.Where(p => p.IdSanPham == id).ToList();
        }

    }
}
