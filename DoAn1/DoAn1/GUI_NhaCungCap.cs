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

namespace DoAn1
{
    public partial class GUI_NhaCungCap : Form
    {
        BUS_NhaCungCap bus_nhacungcap = new BUS_NhaCungCap();
        public GUI_NhaCungCap()
        {
            InitializeComponent();
            txttimkiem.GotFocus += txttimkiem_Enter;
            txttimkiem.LostFocus += txttimkiem_Leave;
            txttimkiem.Text = "Tìm kiếm theo mã, theo tên";
        }

        void loaddgv()
        {
            //DataTable dt = bus_loaisp.getData();
            //dgvloaisp.DataSource = dt;
            dgvncc.DataSource = bus_nhacungcap.getNCC();
            dgvncc.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvncc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvncc.Columns[2].HeaderText = "Địa chỉ";
            dgvncc.Columns[3].HeaderText = "Số điện thoại";
            dgvncc.Columns[4].HeaderText = "Email";
        }

        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvncc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmancc.Text = dgvncc[0, i].Value.ToString().Trim();
            txttenncc.Text = dgvncc[1, i].Value.ToString().Trim();
            txtdiachi.Text = dgvncc[2, i].Value.ToString().Trim();
            txtsdt.Text = dgvncc[3, i].Value.ToString().Trim();
            txtemail.Text = dgvncc[4, i].Value.ToString().Trim();
        }

        private void vbtnlammoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }
        private void vbtnthem_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = txtmancc.Text;
            ncc.TenNCC = txttenncc.Text;
            ncc.Diachi = txtdiachi.Text;
            ncc.Sodienthoai = txtsdt.Text;
            ncc.Email = txtemail.Text;
            if (bus_nhacungcap.kiemtramatrung(txtmancc.Text) == 1)
            {
                MessageBox.Show("Mã nhà cung cấp này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtmancc.Text) || string.IsNullOrEmpty(txttenncc.Text)
                    || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtsdt.Text)
                    || string.IsNullOrEmpty(txtemail.Text))
                {
                    MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if(ncc.Sodienthoai.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (!ncc.Email.Contains("@") || !ncc.Email.Contains("."))
                {
                    MessageBox.Show("Định dạng email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (bus_nhacungcap.ThemNhaCungCap(ncc) == true)
                {
                    MessageBox.Show("Thêm nhà cung cấp mới thành công.");
                    loaddgv();
                }
            }
        }

        private void vbtnsua_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = txtmancc.Text;
            ncc.TenNCC = txttenncc.Text;
            ncc.Diachi = txtdiachi.Text;
            ncc.Sodienthoai = txtsdt.Text;
            ncc.Email = txtemail.Text;
            if (string.IsNullOrEmpty(txtmancc.Text) || string.IsNullOrEmpty(txttenncc.Text)
                    || string.IsNullOrEmpty(txtdiachi.Text) || string.IsNullOrEmpty(txtsdt.Text)
                    || string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (ncc.Sodienthoai.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải chứa đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            if (!ncc.Email.Contains("@") || !ncc.Email.Contains("."))
            {
                MessageBox.Show("Định dạng email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng thực hiện tiếp
            }
            else
            {
                if (bus_nhacungcap.SuaNhaCungCap(ncc) == true)
                {
                    MessageBox.Show("Sửa thông tin nhà cung cấp thành công.");
                    loaddgv();
                }
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = txtmancc.Text;
            ncc.TenNCC = txttenncc.Text;
            ncc.Diachi = txtdiachi.Text;
            ncc.Sodienthoai = txtsdt.Text;
            ncc.Email = txtemail.Text;
            if (bus_nhacungcap.XoaNhaCungCap(ncc) == true)
            {
                MessageBox.Show("Xóa thành công.");
                loaddgv();
            }
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            GUI_NhaCungCap_Load(sender, e);
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgvncc.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgvncc[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgvncc[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgvncc[2, i].Value?.ToString().Trim().ToUpperInvariant();

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText));

                if (!containsSearchText)
                {
                    dgvncc.Rows.RemoveAt(i);
                }
            }
        }

        private void txttimkiem_Enter(object sender, EventArgs e)
        {
            if (txttimkiem.Text == "Tìm kiếm theo mã, theo tên")
            {
                txttimkiem.Text = "";
            }
        }

        private void txttimkiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttimkiem.Text))
            {
                txttimkiem.Text = "Tìm kiếm theo mã, theo tên";
            }
        }
    }
}
