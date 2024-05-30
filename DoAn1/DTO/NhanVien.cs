using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string GioitinhNV { get; set; }
        public string NgaysinhNV { get; set; }
        public string DiachiNV { get; set; }
        public string SdtNV { get; set; }
        public string Tenquyen { get; set; }
        public NhanVien()
        {

        }

        public NhanVien(string manv, string tennv, string gioitinh, string ngaysinh, string diachi, string sdt, string tenquyen)
        {
            this.MaNV = manv;
            this.TenNV = tennv;
            this.GioitinhNV = ngaysinh;
            this.NgaysinhNV = gioitinh;
            this.DiachiNV = diachi;
            this.SdtNV = sdt;
            this.Tenquyen = tenquyen;   

        }
    }
}
