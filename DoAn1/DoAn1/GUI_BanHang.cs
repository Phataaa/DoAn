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
    public partial class GUI_BanHang : Form
    {
        BUS_HDB bus_hdb = new BUS_HDB();
        BUS_BanHang bus_bh = new BUS_BanHang();
        DataTable dtNhanVien;
        DataTable dtKhachHang;
        DataTable dtSanPham;
        float tongTien = 0;
        public GUI_BanHang()
        {
            InitializeComponent();
            loadkh();
            loadsp();
            loadnv();
        }
        void loadnv()
        {
            dtNhanVien = bus_bh.GetNhanVien();
            cbomanv.DataSource = dtNhanVien;
            cbomanv.DisplayMember = "MaNV";
            cbomanv.ValueMember = "TenNV";

            cbotennv.DataSource = dtNhanVien;
            cbotennv.DisplayMember = "TenNV";
            cbotennv.ValueMember = "MaNV";
        }
        void loadkh()
        {
            dtKhachHang = bus_bh.GetKhachHang();
            cbotenkh.DataSource = dtKhachHang;
            cbotenkh.DisplayMember = "TenKH";
            cbotenkh.ValueMember = "MaKH";

            cbomakh.DataSource = dtKhachHang;
            cbomakh.DisplayMember = "MaKH";
            cbomakh.ValueMember = "TenKH";
        }
        void loadsp()
        {
            dtSanPham = bus_bh.GetSanPham();
            cbotensp.DataSource = dtSanPham;
            cbotensp.DisplayMember = "TenSP";
            cbotensp.ValueMember = "MaSP";

            cbomasp.DataSource = dtSanPham;
            cbomasp.DisplayMember = "MaSP";
            cbomasp.ValueMember = "TenSP";
        }

        void loadhdb()
        {
            DataTable dt = bus_hdb.getHDB();
            dgvhdb.DataSource = dt;
            dgvhdb.Columns[0].HeaderText = "Mã hóa đơn";
            dgvhdb.Columns[1].HeaderText = "Mã nhân viên";
            dgvhdb.Columns[2].HeaderText = "Mã khách hàng";
            dgvhdb.Columns[3].HeaderText = "Ngày mua";
            dgvhdb.Columns[4].HeaderText = "Tổng tiền";
        }
        void loadcthdb(string maHDB)
        {
            DataTable dt = bus_hdb.getCTHDB(maHDB);
            dgvcthdb.DataSource = dt;
            dgvhdb.Columns[0].HeaderText = "Mã hóa đơn";
            dgvhdb.Columns[1].HeaderText = "Mã sản phẩm";
            dgvhdb.Columns[2].HeaderText = "Số lượng";
            dgvhdb.Columns[3].HeaderText = "Đơn giá";
            dgvhdb.Columns[4].HeaderText = "Thành tiền";
        }

            // tabControl2
        private void dgvhdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvhdb.Rows[e.RowIndex];
                string maHDB = row.Cells["MaHDB"].Value.ToString();
                loadcthdb(maHDB);
            }
        }

            // tabControl2

        private void GUI_BanHang_Load(object sender, EventArgs e)
        {
            loadhdb();
            dgvhdb.CellClick += dgvhdb_CellClick;
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            if (dgvhdb.SelectedRows.Count > 0)
            {
                string maHDB = dgvhdb.SelectedRows[0].Cells["MaHDB"].Value.ToString();
                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?",
                                     "Xác nhận xóa!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        bus_hdb.XoaHoaDonBan(maHDB);
                        loadhdb();
                        dgvcthdb.DataSource = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa hóa đơn bán: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.");
            }
        }

        private void vbtntim_Click(object sender, EventArgs e)
        {
            string keyword = txttimkiem.Text.Trim();
            DataTable dt = bus_hdb.TimKiemHoaDonBan(keyword);
            dgvhdb.DataSource = dt;
        }

        private void cbomanv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cbomanv.SelectedValue.ToString();
            DataRow[] rows = dtNhanVien.Select($"MaNV = '{maNV}'");
            if (rows.Length > 0)
            {
                cbotennv.Text = rows[0]["TenNV"].ToString();
            }
        }

        private void cbotenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotenkh.SelectedItem;
            txtdiachi.Text = row["Diachi"].ToString();
            txtsdt.Text = row["Sdt"].ToString();
            rdbnam.Checked = row["Gioitinh"].ToString() == "Nam";
            rdbnu.Checked = row["Gioitinh"].ToString() == "Nữ";

            // Lấy mã khách hàng tương ứng và cập nhật giá trị của combobox mã khách hàng
            string maKH = row["MaKH"].ToString();
            cbomakh.SelectedValue = maKH;
        }

        private void cbotensp_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cbotensp.SelectedItem;
            txtgia.Text = row["Gia"].ToString();

            // Lấy mã sản phẩm tương ứng và cập nhật giá trị của combobox mã sản phẩm
            string maSP = row["MaSP"].ToString();
            cbomasp.SelectedValue = maSP;
        }
        private void cbomakh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã khách hàng được chọn và cập nhật giá trị của combobox tên khách hàng
            string maKH = cbomakh.SelectedValue.ToString();
            DataRow[] rows = dtKhachHang.Select($"MaKH = '{maKH}'");
            if (rows.Length > 0)
            {
                cbotenkh.Text = rows[0]["TenKH"].ToString();
                txtdiachi.Text = rows[0]["Diachi"].ToString();
                txtsdt.Text = rows[0]["Sdt"].ToString();
                rdbnam.Checked = rows[0]["Gioitinh"].ToString() == "Nam";
                rdbnu.Checked = rows[0]["Gioitinh"].ToString() == "Nữ";
            }
        }

        private void cbomasp_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy mã sản phẩm được chọn và cập nhật giá trị của combobox tên sản phẩm
            string maSP = cbomasp.SelectedValue.ToString();
            DataRow[] rows = dtSanPham.Select($"MaSP = '{maSP}'");
            if (rows.Length > 0)
            {
                cbotensp.Text = rows[0]["TenSP"].ToString();
                txtgia.Text = rows[0]["Gia"].ToString();
            }
        }

        private void vbtnthem_Click(object sender, EventArgs e)
        {
            string maSP = cbotensp.SelectedValue.ToString();
            string tenSP = cbotensp.Text;
            int soLuong = int.Parse(txtsl.Text);
            float gia = float.Parse(txtgia.Text);
            float thanhTien = soLuong * gia;

            dgvsp.Rows.Add(txtmahd.Text, cbomanv.SelectedValue.ToString(), cbomakh.SelectedValue, maSP, tenSP, soLuong, gia, thanhTien);
            tongTien += thanhTien;
            txttongtien.Text = tongTien.ToString();

            // Làm mới các trường thông tin sản phẩm
            txtsl.Clear();
            txtgia.Clear();
            //txtthanhtien.Clear();
        }

        private void vbtnlendon_Click(object sender, EventArgs e)
        {
            if (bus_bh.InsertHoadonban(txtmahd.Text, cbomanv.SelectedValue.ToString(), cbomakh.SelectedValue.ToString(), tongTien))
            {
                foreach (DataGridViewRow row in dgvsp.Rows)
                {
                    string maSP = row.Cells["MaSP"].Value.ToString();
                    int soLuong = int.Parse(row.Cells["SoLuong"].Value.ToString());
                    float gia = float.Parse(row.Cells["Gia"].Value.ToString());
                    float thanhTien = float.Parse(row.Cells["ThanhTien"].Value.ToString());

                    bus_bh.InsertChitiethoadonban(txtmahd.Text, maSP, soLuong, gia, thanhTien);
                }
                MessageBox.Show("Lưu hóa đơn thành công!");
            }
            else
            {
                MessageBox.Show("Lưu hóa đơn thất bại!");
            }
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgvsp);
        }

        private void dgvsp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
