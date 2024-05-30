using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan
    {
        public string MaHDB { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime Ngaymua { get; set; }
        public float Tongtien { get; set; }
        public HoaDonBan() { }
        public HoaDonBan(string maHDB, string maNV, string maKH, DateTime ngayMua, float tongTien)
        {
            MaHDB = maHDB;
            MaNV = maNV;
            MaKH = maKH;
            Ngaymua = ngayMua;
            Tongtien = tongTien;
        }
    }
}
