using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class Nhanviensv
    {
        NhanVienRepos _rp;
        public Nhanviensv()
        {
            _rp = new NhanVienRepos();
        }
        public string login(string username, string password)
        {
            return _rp.checklogin(username, password);
        }

    }
}
