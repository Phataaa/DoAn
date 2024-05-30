using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhanQuyen
    {
        DAL_PhanQuyen dal_phanquyen = new DAL_PhanQuyen();
        public DataTable getPhanQuyen()
        {
            return dal_phanquyen.getPhanQuyen();
        }
    }
}
