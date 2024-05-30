using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DAL
{
    public class DAL_TaiKhoan : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable getTaiKhoan()
        {
            string strGetTK = "Select * from taikhoan";
            return GetDataTable(strGetTK);
        }
        public int kiemtramatrung(string ma)
        {
            KetNoi();
            int i;
            string sql = "Select count(*) from taikhoan where MaNV = '" + ma.Trim() + "'";
            sqlCom = new SqlCommand(sql, sqlCon);
            i = (int)sqlCom.ExecuteScalar();
            NgatKetNoi();
            return i;
        }
        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            string sql = "Insert into taikhoan values('" + tk.MaNV + "', '" + tk.Maquyen + "', '" + tk.Tendangnhap + "', '" + tk.Matkhau + "')";
            ThucThi(sql);
            return true;
        }
        public bool SuaTaiKhoan(TaiKhoan tk)
        {
            //string sql = "Update taikhoan set Maquyen = '" + tk.Maquyen + "', Tendangnhap = '" + tk.Tendangnhap + "', Matkhau = '" + tk.Matkhau + "'";
            //ThucThi(sql);
            //return true;

            SqlTransaction transaction = null; // Khai báo biến transaction
            try
            {
                // Mở kết nối
                KetNoi();

                // Bắt đầu một transaction
                transaction = sqlCon.BeginTransaction();

                // Tạo câu lệnh SQL để cập nhật mã quyền trong bảng taikhoan
                string sqlUpdateTaiKhoan = "UPDATE taikhoan SET Maquyen = @Maquyen, Tendangnhap = @Tendangnhap, Matkhau = @Matkhau WHERE MaNV = @MaNV";

                // Tạo SqlCommand và thiết lập các tham số
                SqlCommand cmdUpdateTaiKhoan = new SqlCommand(sqlUpdateTaiKhoan, sqlCon, transaction);
                cmdUpdateTaiKhoan.Parameters.AddWithValue("@MaNV", tk.MaNV);
                cmdUpdateTaiKhoan.Parameters.AddWithValue("@Maquyen", tk.Maquyen);
                cmdUpdateTaiKhoan.Parameters.AddWithValue("@Tendangnhap", tk.Tendangnhap);
                cmdUpdateTaiKhoan.Parameters.AddWithValue("@Matkhau", tk.Matkhau);

                // Thực thi câu lệnh SQL để cập nhật thông tin tài khoản
                cmdUpdateTaiKhoan.ExecuteNonQuery();

                // Tạo câu lệnh SQL để cập nhật tên quyền trong bảng nhanvien
                string sqlUpdateNhanVien = "UPDATE nhanvien SET Tenquyen = (SELECT Tenquyen FROM phanquyen WHERE Maquyen = @Maquyen) WHERE MaNV = @MaNV";

                // Tạo SqlCommand và thiết lập các tham số
                SqlCommand cmdUpdateNhanVien = new SqlCommand(sqlUpdateNhanVien, sqlCon, transaction);
                cmdUpdateNhanVien.Parameters.AddWithValue("@MaNV", tk.MaNV);
                cmdUpdateNhanVien.Parameters.AddWithValue("@Maquyen", tk.Maquyen);

                // Thực thi câu lệnh SQL để cập nhật tên quyền trong bảng nhân viên
                cmdUpdateNhanVien.ExecuteNonQuery();

                // Commit transaction để lưu các thay đổi vào cơ sở dữ liệu
                transaction.Commit();

                // Đóng kết nối
                NgatKetNoi();

                return true;
            }
            catch (Exception ex)
            {
                // Nếu có lỗi xảy ra, rollback transaction
                transaction.Rollback();
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
                return false;
            }
        }
        public bool XoaTaiKhoan(TaiKhoan tk)
        {
            string sql = "Delete from taikhoan where MaNV = '" + tk.MaNV + "'";
            ThucThi(sql);
            return true;
        }
    }
}
