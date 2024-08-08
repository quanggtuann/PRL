using DAL.Models;
using DAL.SanPhamRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class SanPhamsv
    {
        SanPhamRepos _rp;
        public SanPhamsv()
        {
            _rp = new SanPhamRepos();
        }
        public List<SanPham> GetAll()
        {
            return _rp.Getall();
        }
        public string Create(SanPham sp)
        {
            if (_rp.CreateSP(sp))
            {
                return "thêm thành công";
            }
            else return "thêm thất bại";
        }
        public string update(SanPham sp, int id)
        {
            if (_rp.Update(sp, id))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public List<SanPham> Timkiem(string ten)
        {
            return _rp.Timkiem(ten);
        }

        public List<SanPham> Timkiemid(int id)
        {
            return _rp.Timkiemid(id);
        }

    }
}
