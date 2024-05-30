using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhanQuyen : DBConnect
    {
        DBConnect connect = new DBConnect();

        public DataTable getPhanQuyen()
        {
            string strGetPQ = "Select * from phanquyen";
            return GetDataTable(strGetPQ);
        }
    }
}
