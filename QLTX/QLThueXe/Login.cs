using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuXe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FMain fm = new FMain();
            if (txtUser.Text != "" && txtPassword.Text !="")
            {
                if (CheckLogin(txtUser.Text, txtPassword.Text))
                {
                   
                    fm.Show();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                txtUser.Focus();
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

       private bool CheckLogin(string username, string password)
        {
            return (username == "admin" && password == "123456"); ;
        }
    }
}
