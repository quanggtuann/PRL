using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class KhachHang
    {
        [Key]
        public string SDT {  get; set; }
        public string Ten { get; set; }
        public List<HoaDon>? HoaDons { get; set; }
    }
}
