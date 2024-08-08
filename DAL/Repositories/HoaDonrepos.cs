using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonrepos
    {
        LaptopContext context;
        public HoaDonrepos()
        {
            context = new LaptopContext();
        }

        public List<HoaDon> Getall()
        {
            return context.HoaDons.ToList();
        }
        public bool Create(HoaDon hoaDon)
        {
            try
            {
                context.HoaDons.Add(hoaDon);
                context.SaveChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
