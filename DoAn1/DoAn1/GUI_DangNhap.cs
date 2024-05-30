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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DoAn1
{
    public partial class GUI_DangNhap : Form
    {
        BUS_DangNhap bus_dangnhap = new BUS_DangNhap();
        public GUI_DangNhap()
        {
            InitializeComponent();

            DisableFocus();

            txttk.GotFocus += txttk_Enter;
            txttk.LostFocus += txttk_Leave;
            txttk.Text = "Username";

            txtmk.GotFocus += txtmk_Enter;
            txtmk.LostFocus += txtmk_Leave;
            txtmk.Text = "Password";
        }
        private void DisableFocus()
        {
            // Tạm thời vô hiệu hóa việc chấp nhận focus cho tất cả các textbox trong form
            foreach (Control ctr in this.groupBox1.Controls)
            {
                ctr.TabStop = false;
            }
        }

        private void txttk_Enter(object sender, EventArgs e)
        {
            // Khi TextBox nhận focus, xóa văn bản mặc định
            if (txttk.Text == "Username")
            {
                txttk.Text = "";
            }
        }

        private void txttk_Leave(object sender, EventArgs e)
        {
            // Khi TextBox mất focus và không có văn bản, hiển thị văn bản mặc định
            if (string.IsNullOrWhiteSpace(txttk.Text))
            {
                txttk.Text = "Username";
            }
        }

        private void txtmk_Enter(object sender, EventArgs e)
        {
            if (txtmk.Text == "Password")
            {
                txtmk.Text = "";
            }
        }

        private void txtmk_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtmk.Text))
            {
                txtmk.Text = "Password";
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            if(txtmk.PasswordChar == '*')
            {
                view.BringToFront();
                txtmk.PasswordChar = '\0';
            }
        }

        private void view_Click(object sender, EventArgs e)
        {
            if (txtmk.PasswordChar == '\0')
            {
                hide.BringToFront();
                txtmk.PasswordChar = '*';
            }
        }

        private void vbtndn_Click(object sender, EventArgs e)
        {
            string username = txttk.Text;
            string password = txtmk.Text;
            string tenQuyen;
            int result = bus_dangnhap.CheckDangNhap(username, password, out tenQuyen);
            if (result == 1)
            {
                MessageBox.Show("Đăng nhập thành công! Quyền: " + tenQuyen);
                GUI_TrangChu trc = new GUI_TrangChu(tenQuyen);
                this.Hide();
                trc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không hợp lệ!");
            }
        }

    }
}
