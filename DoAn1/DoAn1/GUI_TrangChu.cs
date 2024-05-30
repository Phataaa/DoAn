using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn1
{
    public partial class GUI_TrangChu : Form
    {
        private Form currentFormChild;
        private string userRole;
        public GUI_TrangChu(string role)
        {
            InitializeComponent();
            userRole = role;
            SetPermissions();
        }
        private void SetPermissions()
        {
            if (userRole == "Nhân viên")
            {
                // Vô hiệu hóa chức năng xem nhân viên
                vbtnnhanvien.Enabled = false;
                vbtntaikhoan.Enabled = false;
            }
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelform.Controls.Add(childForm);
            panelform.Controls.SetChildIndex(childForm, 0); // Đảm bảo form con nằm trên cùng
            panelform.BringToFront();
            childForm.Show();
        }

        private void vbtnkhachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_KhachHang());
        }

        private void vbtnnhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_NhanVien());
        }

        private void vbtnbanhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_BanHang());
        }

        private void vbtnsanpham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_SanPham());
        }

        private void vbtnnhaphang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_NhapHang());
        }

        private void vbtntaikhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI_Taikhoan());
        }
    }
}
