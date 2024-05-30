using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SanPham
    {
        DAL_SanPham dal_sanpham = new DAL_SanPham();
        public DataTable getSanPham()
        {
            return dal_sanpham.getSanPham();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_sanpham.kiemtramatrung(ma);
        }
        public bool ThemSanPham(SanPham sp)
        {
            return dal_sanpham.ThemSanPham(sp);
        }
        public bool SuaSanPham(SanPham sp)
        {
            return dal_sanpham.SuaSanPham(sp);
        }
        public bool XoaSanPham(SanPham sp)
        {
            return dal_sanpham.XoaSanPham(sp);
        }
    }
}
