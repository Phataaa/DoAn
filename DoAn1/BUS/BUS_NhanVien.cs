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
    public class BUS_NhanVien
    {
        DAL_NhanVien dal_nhanvien = new DAL_NhanVien();
        public DataTable getNhanVien()
        {
            return dal_nhanvien.getNhanVien();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_nhanvien.kiemtramatrung(ma);
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            return dal_nhanvien.ThemNhanVien(nv);
        }
        public bool SuaNhanVien(NhanVien nv)
        {
            return dal_nhanvien.SuaNhanVien(nv);
        }
        public bool XoaNhanVien(NhanVien nv)
        {
            return dal_nhanvien.XoaNhanVien(nv);
        }
    }
}
