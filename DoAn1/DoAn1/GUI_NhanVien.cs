using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
//using WinFormsRadioButton = System.Windows.Forms.RadioButton;
//using VisualStyleRadioButton = System.Windows.Forms.VisualStyles.VisualStyleElement.Button.RadioButton;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DoAn1
{
    public partial class GUI_NhanVien : Form
    {
        BUS_NhanVien bus_nhanvien = new BUS_NhanVien();
        BUS_PhanQuyen bus_phanquyen = new BUS_PhanQuyen();
        public GUI_NhanVien()
        {
            InitializeComponent();
            txttimkiem.GotFocus += txttimkiem_Enter;
            txttimkiem.LostFocus += txttimkiem_Leave;
            txttimkiem.Text = "Tìm kiếm theo mã, tên, giới tính, địa chỉ";
        }
        //private void SomeMethod()
        //{
        //    // Sử dụng alias để tạo đối tượng RadioButton
        //    WinFormsRadioButton myRadioButton = new WinFormsRadioButton();
        //    // Hoặc nếu bạn cần sử dụng VisualStyleRadioButton
        //    // VisualStyleRadioButton myVisualStyleRadioButton = new VisualStyleRadioButton();
        //}
        void loaddgv()
        {
            dgvnv.DataSource = bus_nhanvien.getNhanVien();
            dgvnv.Columns[0].HeaderText = "Mã nhân viên";
            dgvnv.Columns[1].HeaderText = "Tên nhân viên";
            dgvnv.Columns[2].HeaderText = "Giới tính";
            dgvnv.Columns[3].HeaderText = "Ngày sinh";
            dgvnv.Columns[4].HeaderText = "Địa chỉ";
            dgvnv.Columns[5].HeaderText = "Số điện thoại";
            dgvnv.Columns[6].HeaderText = "Tên quyền";
            cbotenq.DataSource = bus_phanquyen.getPhanQuyen();
            cbotenq.DisplayMember = "Tenquyen";
        }

        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanv.Text = dgvnv[0, i].Value.ToString().Trim();
            txttennv.Text = dgvnv[1, i].Value.ToString().Trim();
            dtngaysinh.Text = dgvnv[3, i].Value.ToString().Trim();
            txtdiachi.Text = dgvnv[4, i].Value.ToString().Trim();
            txtsdt.Text = dgvnv[5, i].Value.ToString().Trim();
            cbotenq.Text = dgvnv[6, i].Value.ToString().Trim();
            string gt = dgvnv.Rows[i].Cells[2].Value.ToString().Trim();
            if(gt == "Nam")
            {
                rdbnam.Checked = true;
            }
            else
            {
                rdbnu.Checked = true;
            }
        }

        private void vbtnlammoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox || ctr is ComboBox || ctr is DateTimePicker || ctr is RadioButton)
                {
                    ctr.Text = "";
                }
            }
        }
        private void vbtnthem_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtmanv.Text;
            nv.TenNV = txttennv.Text;
            nv.GioitinhNV = "";
            // Duyệt qua tất cả các điều khiển trong GroupBox
            foreach (Control ctr in this.panel6.Controls)
            {
                // Kiểm tra nếu điều khiển là RadioButton và nó đang được chọn
                if (ctr is RadioButton && rdbnam.Checked)
                {
                    // Lấy giá trị của RadioButton
                    nv.GioitinhNV = rdbnam.Text;
                    break; // Thoát khỏi vòng lặp khi tìm thấy RadioButton được chọn
                }
                else if (ctr is RadioButton && rdbnu.Checked)
                {
                    nv.GioitinhNV = rdbnu.Text;
                    break;
                }
            }
            nv.NgaysinhNV = dtngaysinh.Text;
            nv.DiachiNV = txtdiachi.Text;
            nv.SdtNV = txtsdt.Text;
            nv.Tenquyen = cbotenq.Text;
            if (bus_nhanvien.kiemtramatrung(txtmanv.Text) == 1)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtmanv.Text) || string.IsNullOrEmpty(txttennv.Text)
                    || string.IsNullOrEmpty(rdbnam.Text) || string.IsNullOrEmpty(rdbnam.Text)
                    || string.IsNullOrEmpty(dtngaysinh.Text) || string.IsNullOrEmpty(txtdiachi.Text) 
                    || string.IsNullOrEmpty(txtsdt.Text))
                {
                    MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (nv.SdtNV.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (bus_nhanvien.ThemNhanVien(nv) == true)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công.");
                    loaddgv();
                }
            }
        }

        private void vbtnsua_Click(object sender, EventArgs e)
        {

            NhanVien nv = new NhanVien();
            nv.MaNV = txtmanv.Text;
            nv.TenNV = txttennv.Text;
            nv.GioitinhNV = "";
            // Duyệt qua tất cả các điều khiển trong GroupBox
            foreach (Control ctr in this.panel6.Controls)
            {
                // Kiểm tra nếu điều khiển là RadioButton và nó đang được chọn
                if (ctr is RadioButton && rdbnam.Checked)
                {
                    // Lấy giá trị của RadioButton
                    nv.GioitinhNV = rdbnam.Text;
                    break; // Thoát khỏi vòng lặp khi tìm thấy RadioButton được chọn
                }
                else if (ctr is RadioButton && rdbnu.Checked)
                {
                    nv.GioitinhNV = rdbnu.Text;
                    break;
                }
            }
            nv.NgaysinhNV = dtngaysinh.Text;
            nv.DiachiNV = txtdiachi.Text;
            nv.SdtNV = txtsdt.Text;
            nv.Tenquyen = cbotenq.Text;
            if (string.IsNullOrEmpty(txtmanv.Text) || string.IsNullOrEmpty(txttennv.Text)
                    || string.IsNullOrEmpty(rdbnam.Text) || string.IsNullOrEmpty(dtngaysinh.Text)
                    || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtsdt.Text))
            {
                MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (nv.SdtNV.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            else
            {
                if (bus_nhanvien.SuaNhanVien(nv))
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công.");
                    loaddgv(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi sửa thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtmanv.Text;
            nv.TenNV = txttennv.Text;
            nv.GioitinhNV = "";
            // Duyệt qua tất cả các điều khiển trong GroupBox
            foreach (Control ctr in this.panel6.Controls)
            {
                // Kiểm tra nếu điều khiển là RadioButton và nó đang được chọn
                if (ctr is RadioButton && rdbnam.Checked)
                {
                    // Lấy giá trị của RadioButton
                    nv.GioitinhNV = rdbnam.Text;
                    break; // Thoát khỏi vòng lặp khi tìm thấy RadioButton được chọn
                }
                else if (ctr is RadioButton && rdbnu.Checked)
                {
                    nv.GioitinhNV = rdbnu.Text;
                    break;
                }
            }
            nv.NgaysinhNV = dtngaysinh.Text;
            nv.DiachiNV = txtdiachi.Text;
            nv.SdtNV = txtsdt.Text;
            nv.Tenquyen = cbotenq.Text;
            if (bus_nhanvien.XoaNhanVien(nv) == true)
            {
                MessageBox.Show("Xóa nhân viên thành công.");
                loaddgv();
            }
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GUI_NhanVien_Load(sender, e);
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgvnv.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvnv[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvnv[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgvnv[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue4 = dgvnv[4, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue4) && cellValue4.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvnv.Rows.RemoveAt(i);
                }
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm kiếm theo mã, tên, giới tính, địa chỉ")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Tìm kiếm theo mã, tên, giới tính, địa chỉ";
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvnv);
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
