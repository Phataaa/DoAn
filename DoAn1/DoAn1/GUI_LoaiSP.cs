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
    public partial class GUI_LoaiSP : Form
    {
        public GUI_LoaiSP()
        {
            InitializeComponent();
        }
        BUS_LoaiSP bus_loaisp = new BUS_LoaiSP();
        void loaddgv()
        {
            //DataTable dt = bus_loaisp.getData();
            //dgvloaisp.DataSource = dt;
            dgvloaisp.DataSource = bus_loaisp.getLoaiSP();
            dgvloaisp.Columns[0].HeaderText = "Mã loại";
            dgvloaisp.Columns[1].HeaderText = "Tên loại";
        }

        private void GUI_LoaiSP_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void dgvloaisp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmaloai.Text = dgvloaisp[0, i].Value.ToString().Trim();
            txttenloai.Text = dgvloaisp[1, i].Value.ToString().Trim();
        }

        private void vbtnthem_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
            LoaiSP loaisp = new LoaiSP();
            loaisp.Maloai = txtmaloai.Text;
            loaisp.Tenloai = txttenloai.Text;
            if (bus_loaisp.kiemtramatrung(txtmaloai.Text) == 1)
            {
                MessageBox.Show("Mã loại sản phẩm này đã tồn tại!! Vui lòng nhập lại mã.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(txtmaloai.Text) || string.IsNullOrEmpty(txttenloai.Text))
                {
                    MessageBox.Show("Thông tin không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Dừng thực hiện tiếp
                }
                if (bus_loaisp.ThemLoaiSP(loaisp) == true)
                {
                    MessageBox.Show("Thêm loại sản phẩm mới thành công.");
                    loaddgv();
                }
            }
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void vbtnsua_Click(object sender, EventArgs e)
        {
            LoaiSP loaisp = new LoaiSP();
            loaisp.Maloai = txtmaloai.Text;
            loaisp.Tenloai = txttenloai.Text;
            if (bus_loaisp.SuaLoaiSP(loaisp) == true)
            {
                MessageBox.Show("Sửa thông tin loại sản phẩm thành công.");
                loaddgv();
            }
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void vbtnxoa_Click(object sender, EventArgs e)
        {
            LoaiSP loaisp = new LoaiSP();
            loaisp.Maloai = txtmaloai.Text;
            loaisp.Tenloai = txttenloai.Text;
            if (bus_loaisp.XoaLoaiSP(loaisp) == true)
            {
                MessageBox.Show("Xóa thành công.");
                loaddgv();
            }
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = "";
                }
            }
        }
    }
}
