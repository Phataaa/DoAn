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
    public class DAL_KhachHang : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable getKhachHang()
        {
            string strGetKH = "Select * from khachhang";
            return GetDataTable(strGetKH);
        }
        public int kiemtramatrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from khachhang where MaKH = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm khách hàng mới
        public bool ThemKhachHang(KhachHang kh)
        {
            string sql = "Insert into khachhang values('" + kh.MaKH + "', N'" + kh.TenKH + "', N'" + kh.Gioitinh + "', N'" + kh.Diachi + "', '" + kh.Sdt + "')";
            ThucThi(sql);
            return true;
        }
        public bool SuaKhachHang(KhachHang kh)
        {
            string sql = "Update khachhang set TenKH = N'" + kh.TenKH + "', N'" + kh.Gioitinh + "', Diachi = N'" + kh.Diachi + "', Sdt = N'" + kh.Sdt + "' where MaKH = '" + kh.MaKH + "'";
            ThucThi(sql);
            return true;
        }
        public bool XoaKhachHang(KhachHang kh)
        {
            string sql = "Delete from khachhang where MaKH = '" + kh.MaKH + "'";
            ThucThi(sql);
            return true;
        }
    }
}
