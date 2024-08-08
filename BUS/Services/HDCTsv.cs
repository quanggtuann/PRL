using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class HDCTsv
    {
        HDCTrepos _rp =new HDCTrepos();
        public HDCTsv()
        {
         
        }
        public List<HoaDonChiTiet> GetALLByHD(int idhd)
        {
            return _rp.GetAllByHD(idhd);
        }
        public string Create(int soluong, int maSP, int MaHD, decimal Gia )
        {
            if (_rp.Createhdct(soluong, maSP, MaHD,Gia))
            {
                return "Thành Công";
            }
            else return "Thất bại";
        }
    }
}
