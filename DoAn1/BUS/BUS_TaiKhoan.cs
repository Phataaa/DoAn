using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_TaiKhoan
    {
        DAL_TaiKhoan dal_taikhoan = new DAL_TaiKhoan();
        public DataTable getTaiKhoan()
        {
            return dal_taikhoan.getTaiKhoan();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_taikhoan.kiemtramatrung(ma);
        }
        public bool ThemTaiKhoan(TaiKhoan tk)
        {
            return dal_taikhoan.ThemTaiKhoan(tk);
        }
        public bool SuaTaiKhoan(TaiKhoan tk)
        {
            return dal_taikhoan.SuaTaiKhoan(tk);
        }
        public bool XoaTaiKhoan(TaiKhoan tk)
        {
            return dal_taikhoan.XoaTaiKhoan(tk);
        }
    }
}
