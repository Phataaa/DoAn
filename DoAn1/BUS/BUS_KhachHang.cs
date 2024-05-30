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
    public class BUS_KhachHang
    {
        DAL_KhachHang dal_khachhang = new DAL_KhachHang();
        public DataTable getKhachHang()
        {
            return dal_khachhang.getKhachHang();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_khachhang.kiemtramatrung(ma);
        }
        public bool ThemKhachHang(KhachHang kh)
        {
            return dal_khachhang.ThemKhachHang(kh);
        }
        public bool SuaKhachHang(KhachHang kh)
        {
            return dal_khachhang.SuaKhachHang(kh);
        }
        public bool XoaKhachHang(KhachHang kh)
        {
            return dal_khachhang.XoaKhachHang(kh);
        }
    }
}
