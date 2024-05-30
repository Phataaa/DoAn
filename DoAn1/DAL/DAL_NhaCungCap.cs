using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_NhaCungCap : DBConnect
    {
        DBConnect connect = new DBConnect();

        // Hiển thị danh sách loại sản phẩm
        public DataTable getNCC()
        {
            string strGetNCC = "Select * from nhacungcap";
            return GetDataTable(strGetNCC);
        }
        public int kiemtramatrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from nhacungcap where MaNCC = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            string sql = "Insert into nhacungcap values('" + ncc.MaNCC + "', N'" + ncc.TenNCC + "', N'" + ncc.Diachi + "', '" + ncc.Sodienthoai + "', '" + ncc.Email + "')";
            ThucThi(sql);
            return true;
        }
        public bool SuaNhaCungCap(NhaCungCap ncc)
        {
            string sql = "Update nhacungcap set TenNCC = N'" + ncc.TenNCC + "', Diachi = N'" + ncc.Diachi + "', Sodienthoai = '" + ncc.Sodienthoai + "', Email = '" + ncc.Email + "' where Maloai = '" + ncc.MaNCC + "'";
            ThucThi(sql);
            return true;
        }

        public bool XoaNhaCungCap(NhaCungCap ncc)
        {
            string sql = "Delete from nhacungcap where MaNCC = '" + ncc.MaNCC + "'";
            ThucThi(sql);
            return true;
        }
    }
}
