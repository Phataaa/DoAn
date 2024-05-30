using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDonBan
    {
        public string MaHDB { get; set; }
        public string MaSP { get; set; }
        public int Soluongban { get; set; }
        public float Dongia { get; set; }
        public float Thanhtien { get; set; }
        public CTHoaDonBan() { }
        public CTHoaDonBan(string maHDB, string maSP, int soLuong, float donGia, float thanhTien)
        {
            MaHDB = maHDB;
            MaSP = maSP;
            Soluongban = soLuong;
            Dongia = donGia;
            Thanhtien = thanhTien;
        }
    }
}
