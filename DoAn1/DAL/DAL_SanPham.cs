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
    public class DAL_SanPham : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable getSanPham()
        {
            string strGetSP = "Select * from sanpham";
            return GetDataTable(strGetSP);
        }
        public int kiemtramatrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from sanpham where MaSP = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }
        public bool ThemSanPham(SanPham sp)
        {
            string sql = "Insert into sanpham values('" + sp.MaSP + "', N'" + sp.TenSP + "', '" + sp.Maloai + "', '" + sp.MaNCC + "', '" + sp.Kichthuoc + "', N'" + sp.Xuatxu + "', '" + sp.Gia + "', '" + sp.Soluong + "', N'" + sp.Mota + "')";
            ThucThi(sql);
            return true;
        }
        public bool SuaSanPham(SanPham sp)
        {
            string sql = "Update sanpham set TenSP = N'" + sp.TenSP + "', Maloai = '" + sp.Maloai + "', MaNCC = '" + sp.MaNCC + "', Kichthuoc = '" + sp.Kichthuoc + "', Xuatxu = N'" + sp.Xuatxu + "', Gia = '" + sp.Gia + "', Soluong = '" + sp.Soluong + "' where MaSP = '" + sp.MaSP + "'";
            ThucThi(sql);
            return true;
        }
        public bool XoaSanPham(SanPham sp)
        {
            string sql = "Delete from sanpham where MaSP = '" + sp.MaSP + "'";
            ThucThi(sql);
            return true;
        }
    }
}
