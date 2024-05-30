using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_BanHang : DBConnect
    {
        public DataTable GetNhanVien()
        {
            KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM nhanvien", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }
        public DataTable GetKhachHang()
        {
            KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM khachhang", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }

        public DataTable GetSanPham()
        {
            KetNoi();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sanpham", sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            NgatKetNoi();
            return dt;
        }

        public bool InsertHoadonban(string maHDB, string maNV, string maKH, float tongTien)
        {
            try
            {
                KetNoi();
                string sql = "INSERT INTO hoadonban (MaHDB, MaNV, MaKH, Ngaymua, Tongtien) VALUES (@MaHDB, @MaNV, @MaKH, @Ngaymua, @Tongtien)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@MaHDB", maHDB);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                cmd.Parameters.AddWithValue("@MaKH", maKH);
                cmd.Parameters.AddWithValue("@Ngaymua", DateTime.Now);
                cmd.Parameters.AddWithValue("@Tongtien", tongTien);
                cmd.ExecuteNonQuery();
                NgatKetNoi();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertChitiethoadonban(string maHDB, string maSP, int soLuongBan, float donGia, float thanhTien)
        {
            try
            {
                KetNoi();
                string sql = "INSERT INTO chitiethoadonban (MaHDB, MaSP, Soluongban, Dongia, Thanhtien) VALUES (@MaHDB, @MaSP, @Soluongban, @Dongia, @Thanhtien)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@MaHDB", maHDB);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@Soluongban", soLuongBan);
                cmd.Parameters.AddWithValue("@Dongia", donGia);
                cmd.Parameters.AddWithValue("@Thanhtien", thanhTien);
                cmd.ExecuteNonQuery();
                NgatKetNoi();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
