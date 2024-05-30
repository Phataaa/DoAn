using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhapHang : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable getHDN()
        {
            string strGet = "Select * from hoadonnhap";
            return GetDataTable(strGet);
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from hoadonnhap where MaHDN = '" + ma.Trim() + "'";
            return kiemtramatrung(sql);
        }

        public bool ThemHDN(HoaDonNhap hdn)
        {
            string ngaynhap = string.Format("{0}/{1}/{2}", hdn.Ngaynhap.Year, hdn.Ngaynhap.Month, hdn.Ngaynhap.Day);
            string sql = "Insert into hoadonnhap values('" + hdn.MaHDN + "', '" + hdn.MaNV + "', '" + hdn.MaNCC + "', '" + ngaynhap + "', '" + hdn.Tongtien + "')";
            ThucThi(sql);
            return true;
        }

        public bool SuaHDN(HoaDonNhap hdn)
        {
            string ngaynhap = string.Format("{0}/{1}/{2}", hdn.Ngaynhap.Year, hdn.Ngaynhap.Month, hdn.Ngaynhap.Day);
            string sql = "Update hoadonnhap set MaNV = '" + hdn.MaNV + "', MaNCC = '" + hdn.MaNCC + "', Ngaynhap = '" + ngaynhap + "', Tongtien = " + hdn.Tongtien + " where MaHDN = '" + hdn.MaHDN + "'";
            ThucThi(sql);
            return true;
        }

        public bool XoaHDN(string ma)
        {
            string sql = "Delete from hoadonnhap where MaHDN = '" + ma + "'";
            ThucThi(sql);
            return true;
        }
        public bool SetTongTien(double tt, string maHDN)
        {
            string sql = "UPDATE hoadonnhap SET Tongtien = " + tt + " WHERE MaHDN = '" + maHDN + "'";
            ThucThi(sql);
            return true;
        }
    }
}
