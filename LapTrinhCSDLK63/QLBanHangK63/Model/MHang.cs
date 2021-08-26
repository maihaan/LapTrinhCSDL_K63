using QLBanHangK63.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QLBanHangK63.Model
{
    public class MHang
    {
        public int ID { get; set; }
        public String Ma { get; set; }
        public String Ten { get; set; }
        public String MoTa { get; set; }
        public String MaPhanLoai { get; set; }
        public String DVT { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }

        public MPhanLoai PhanLoaiHang()
        {
            CPhanLoai c = new CPhanLoai();
            return c.SelectByMa(MaPhanLoai);
        }
    }
}
