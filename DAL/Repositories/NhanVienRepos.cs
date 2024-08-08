using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class NhanVienRepos
    {
        LaptopContext _context;
        public NhanVienRepos()
        {
            _context = new LaptopContext();
        }
       public string checklogin(string username, string password)
        {
            try {
                var check = _context.NhanViens.SingleOrDefault(p => p.username == username && p.password == password);
                if (check != null)
                {
                    return check.Id.ToString();
                } else return "0";
            }catch (Exception ex)
            {
                return "1";
            }
        }
    }
}
