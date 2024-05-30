using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DoAn1
{
    public partial class GUI_Taikhoan : Form
    {
        BUS_TaiKhoan bus_taikhoan = new BUS_TaiKhoan();
        BUS_PhanQuyen bus_phanquyen = new BUS_PhanQuyen();
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        public GUI_Taikhoan()
        {
            InitializeComponent();
        }
        void loaddgv()
        {
            dgvtk.DataSource = bus_taikhoan.getTaiKhoan();
            dgvtk.Columns[0].HeaderText = "Mã nhân viên";
            dgvtk.Columns[1].HeaderText = "Mã quyền";
            dgvtk.Columns[2].HeaderText = "Tên đăng nhập";
            dgvtk.Columns[3].HeaderText = "Mật khẩu";
            cbomanv.DataSource = bus_nhanvien.getNhanVien();
            cbomanv.DisplayMember = "MaNV";
            cbomaquyen.DataSource = bus_phanquyen.getPhanQuyen();
            cbomaquyen.DisplayMember = "Maquyen";
        }

        private void GUI_Taikhoan_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvtk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbomanv.Text = dgvtk[0, i].Value.ToString().Trim();
            cbomaquyen.Text = dgvtk[1, i].Value.ToString().Trim();
            txttk.Text = dgvtk[2, i].Value.ToString().Trim();
            txtmk.Text = dgvtk[3, i].Value.ToString().Trim();
        }
        private void vbtnlammoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void vbtnthem_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.MaNV = cbomanv.Text;
            tk.Maquyen = int.Parse(cbomaquyen.Text);
            tk.Tendangnhap = txttk.Text;
            tk.Matkhau = txtmk.Text;
            if (bus_taikhoan.kiemtramatrung(cbomanv.Text) == 1)
            {
                MessageBox.Show("Nhân viên này đã có tài khoản!! Vui lòng chọn nhân viên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(cbomanv.Text) || string.IsNullOrEmpty(cbomaquyen.Text)
                    || string.IsNullOrEmpty(txttk.Text) || string.IsNullOrEmpty(txtmk.Text))
                {
                    MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (bus_taikhoan.ThemTaiKhoan(tk) == true)
                {
                    MessageBox.Show("Thêm tài khoản mới thành công.");
                    loaddgv();
                }
            }
        }

        private void vbtnsua_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = new TaiKhoan();
            tk.MaNV = cbomanv.Text;
            tk.Maquyen = int.Parse(cbomaquyen.Text);
            tk.Tendangnhap = txttk.Text;
            tk.Matkhau = txtmk.Text;
            if (string.IsNullOrEmpty(cbomanv.Text) || string.IsNullOrEmpty(cbomaquyen.Text)
                    || string.IsNullOrEmpty(txttk.Text) || string.IsNullOrEmpty(txtmk.Text))
            {
                MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (bus_taikhoan.SuaTaiKhoan(tk) == true)
            {
                MessageBox.Show("Sửa thông tin tài khoản thành công.");
                loaddgv();
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {

            TaiKhoan tk = new TaiKhoan();
            tk.MaNV = cbomanv.Text;
            tk.Maquyen = int.Parse(cbomaquyen.Text);
            tk.Tendangnhap = txttk.Text;
            tk.Matkhau = txtmk.Text;
            if (bus_taikhoan.XoaTaiKhoan(tk) == true)
            {
                MessageBox.Show("Xóa tài khoản thành công.");
                loaddgv();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvtk);
        }
        private void ExportToExcel(DataGridView dgv)
        {
            // Tạo đối tượng Excel Application
            Excel.Application excelApp = new Excel.Application();
            if (excelApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            // Tạo một workbook mới
            Excel.Workbook excelWorkbook = excelApp.Workbooks.Add(Type.Missing);
            Excel.Worksheet excelWorksheet = (Excel.Worksheet)excelWorkbook.Sheets[1];
            excelWorksheet.Name = "ExportedFromDatGridView";

            // Xuất tiêu đề cột
            for (int i = 1; i < dgv.Columns.Count + 1; i++)
            {
                excelWorksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
            }

            // Xuất dữ liệu hàng
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    excelWorksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value?.ToString();
                }
            }

            // Hiển thị ứng dụng Excel
            excelApp.Visible = true;

            // Giải phóng tài nguyên
            releaseObject(excelWorksheet);
            releaseObject(excelWorkbook);
            releaseObject(excelApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
