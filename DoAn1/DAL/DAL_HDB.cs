using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_HDB : DBConnect
    {
        DBConnect connect = new DBConnect();
        public DataTable getHDB()
        {
            string strGetHDB = "Select * from hoadonban";
            return GetDataTable(strGetHDB);
        }
        public DataTable getCTHDB(string maHDB)
        {
            string strGetCTHDB = $"Select * from chitiethoadonban where MaHDB = '{maHDB}'";
            return GetDataTable(strGetCTHDB);
        }
        public void XoaCTHDB(string maHDB)
        {
            string query = $"DELETE FROM chitiethoadonban WHERE MaHDB = '{maHDB}'";
            ThucThi(query);
        }
        public void XoaHDB(string maHDB)
        {
            string query = $"DELETE FROM hoadonban WHERE MaHDB = '{maHDB}'";
            ThucThi(query);
        }
        public DataTable TimKiemHoaDonBan(string keyword)
        {
            string query = "SELECT * FROM hoadonban WHERE " +
                           $"MaHDB LIKE '%{keyword}%' OR " +
                           $"MaNV LIKE '%{keyword}%' OR " +
                           $"MaKH LIKE '%{keyword}%'";

            return GetDataTable(query);
        }
    }
}
