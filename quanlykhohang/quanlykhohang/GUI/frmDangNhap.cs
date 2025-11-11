using quanlykhohang.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace quanlykhohang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string username = "admin";
        private string password = "123";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == username && txtPass.Text == password)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ẩn form Login, mở form Main
                frmMain main = new frmMain();
                this.Hide();
                main.ShowDialog();

                // Khi form main đóng → hiện lại login (hoặc thoát)
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPass.Clear();
                txtUser.Focus();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
