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
    public class BUS_LoaiSP
    {
        DAL_LoaiSP dal_loaisp = new DAL_LoaiSP();
        public DataTable getLoaiSP()
        {
            return dal_loaisp.getLoaiSP();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_loaisp.kiemtramatrung(ma);
        }
        public bool ThemLoaiSP(LoaiSP loaisp)
        {
            return dal_loaisp.ThemLoaiSP(loaisp);
        }
        public bool SuaLoaiSP(LoaiSP loaisp)
        {
            return dal_loaisp.SuaLoaiSP(loaisp);
        }
        public bool XoaLoaiSP(LoaiSP loaisp)
        {
            return dal_loaisp.XoaLoaiSP(loaisp);
        }
    }
}
