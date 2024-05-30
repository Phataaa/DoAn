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
    public class DAL_LoaiSP : DBConnect
    {
        DBConnect connect = new DBConnect();

        // Hiển thị danh sách loại sản phẩm
        public DataTable getLoaiSP()
        {
            string strGetLoaiSP = "Select * from loaisanpham";
            return GetDataTable(strGetLoaiSP);
        }
        public int kiemtramatrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from loaisanpham where Maloai = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }

        // Thêm loại sản phẩm mới
        public bool ThemLoaiSP(LoaiSP loaisp)
        {
            string sql = "Insert into loaisanpham values('" + loaisp.Maloai + "', N'" + loaisp.Tenloai + "')";
            ThucThi(sql);
            return true;
        }

        // Sửa thông tin loại sản phẩm
        public bool SuaLoaiSP(LoaiSP loaisp)
        {
            string sql = "Update loaisanpham set Tenloai = N'" + loaisp.Tenloai + "' where Maloai = '" + loaisp.Maloai + "'";
            ThucThi(sql);
            return true;
        }

        // Xóa loại sản phẩm
        public bool XoaLoaiSP(LoaiSP loaisp)
        {
            string sql = "Delete from loaisanpham where Maloai = '" + loaisp.Maloai + "'";
            ThucThi(sql);
            return true;
        }
    }
}
