using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_HDB
    {
        DAL_HDB hdb = new DAL_HDB();
        public DataTable getHDB()
        {
            return hdb.getHDB();
        }
        public DataTable getCTHDB(string maHDB)
        {
            return hdb.getCTHDB(maHDB);
        }
        public void XoaHoaDonBan(string maHDB)
        {
            hdb.XoaCTHDB(maHDB);
            hdb.XoaHDB(maHDB);
        }
        public DataTable TimKiemHoaDonBan(string keyword)
        {
            return hdb.TimKiemHoaDonBan(keyword);
        }
    }
}
