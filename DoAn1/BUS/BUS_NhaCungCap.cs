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
    public class BUS_NhaCungCap
    {
        DAL_NhaCungCap dal_nhacungcap = new DAL_NhaCungCap();
        public DataTable getNCC()
        {
            return dal_nhacungcap.getNCC();
        }
        public int kiemtramatrung(string ma)
        {
            return dal_nhacungcap.kiemtramatrung(ma);
        }
        public bool ThemNhaCungCap(NhaCungCap ncc)
        {
            return dal_nhacungcap.ThemNhaCungCap(ncc);
        }
        public bool SuaNhaCungCap(NhaCungCap ncc)
        {
            return dal_nhacungcap.SuaNhaCungCap(ncc);
        }
        public bool XoaNhaCungCap(NhaCungCap ncc)
        {
            return dal_nhacungcap.XoaNhaCungCap(ncc);
        }
    }
}
