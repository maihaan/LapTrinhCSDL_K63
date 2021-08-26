using QLBanHangK63.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHangK63.Model
{
    public class MPhanLoai
    {
        public int ID { get; set; }
        public String Ma { get; set; }
        public String Ten { get; set; }

        public List<MHang> DSHang()
        {
            CHang c = new CHang();
            return c.SelectListByMaPhanLoai(Ma);
        }
    }
}
