using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DangNhap
    {
        DAL_DangNhap dal_dangnhap = new DAL_DangNhap();
        public int CheckDangNhap(string username, string password, out string tenQuyen)
        {
            return dal_dangnhap.CheckDangNhap(username, password, out tenQuyen);
        }
    }
}
