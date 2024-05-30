using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_BanHang
    {
        DAL_BanHang dal_banhang = new DAL_BanHang();
        public DataTable GetNhanVien()
        {
            return dal_banhang.GetNhanVien();
        }
        public DataTable GetKhachHang()
        {
            return dal_banhang.GetKhachHang();
        }
        public DataTable GetSanPham()
        {
            return dal_banhang.GetSanPham();
        }
        public bool InsertHoadonban(string maHDB, string maNV, string maKH, float tongTien)
        {
            return dal_banhang.InsertHoadonban(maHDB, maNV, maKH, tongTien);
        }
        public bool InsertChitiethoadonban(string maHDB, string maSP, int soLuongBan, float donGia, float thanhTien)
        {
            return dal_banhang.InsertChitiethoadonban(maHDB, maSP, soLuongBan, donGia, thanhTien);
        }
    }
}
