using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhanVien : DBConnect
    {
        DBConnect connect = new DBConnect();

        public DataTable getNhanVien()
        {
            string strGetNV = "Select * from nhanvien";
            return GetDataTable(strGetNV);
        }
        public int kiemtramatrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from nhanvien where MaNV = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }
        public bool ThemNhanVien(NhanVien nv)
        {
            string sql = "Insert into nhanvien values('" + nv.MaNV + "', N'" + nv.TenNV + "', N'" + nv.GioitinhNV + "', '" + nv.NgaysinhNV + "', N'" + nv.DiachiNV + "', '" + nv.SdtNV + "')";
            ThucThi(sql);
            return true;
        }
        public bool SuaNhanVien(NhanVien nv)
        {
            string sql = "Update nhanvien set TenNV = N'" + nv.TenNV + "', GioitinhNV = N'" + nv.GioitinhNV + "', NgaysinhNV = '" + nv.NgaysinhNV + "', DiachiNV = '" + nv.DiachiNV + "', SdtNV = '" + nv.SdtNV + "' where MaNV = '" + nv.MaNV + "'";
            ThucThi(sql);
            return true;
        }
        public bool XoaNhanVien(NhanVien nv)
        {
            string sql = "Delete from nhanvien where MaNV = '" + nv.MaNV + "'";
            ThucThi(sql);
            return true;
        }
    }
}
