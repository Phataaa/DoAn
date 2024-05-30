using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DangNhap : DBConnect
    {
        DBConnect connect = new DBConnect();
        public int CheckDangNhap(string username, string password, out string tenQuyen)
        {
            tenQuyen = string.Empty;
            int result = 0;

            try
            {
                connect.KetNoi();

                using (SqlCommand cmd = new SqlCommand("checkdangnhap", connect.sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tendangnhap", username);
                    cmd.Parameters.AddWithValue("@Matkhau", password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        tenQuyen = reader["Tenquyen"].ToString();
                        result = 1; // Đăng nhập thành công
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Log hoặc xử lý ngoại lệ nếu cần
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connect.NgatKetNoi();
            }

            return result;
        }
    }
}
