using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tamthaitu_CongCu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Gắn sự kiện Click cho nút Đăng Nhập
            btnlogin.Click += btnlogin_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (username == "admin" && password == "admin")
            {
                // Đăng nhập thành công: mở Form2 và ẩn Form1
                Form2 successForm = new Form2();
                successForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}