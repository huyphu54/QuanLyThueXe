using BUS_QLTX;
using DTO_QLTX;
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

namespace GUI_QLTX
{
    public partial class Login : Form
    {
        BUS_NguoiDung busNguoiDung = new BUS_NguoiDung();
        public static NguoiDung nd = null;
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true; // Set KeyPreview to true
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            login(txtUsername.Text, txtPassword.Text);
        }

        private void login(string username, string password)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                nd = busNguoiDung.layNguoiDung(username, password);
                if (nd != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Kiểm tra xem người dùng có nhấn nút "OK" không
                    if (dialogResult == DialogResult.OK)
                    {
                        Control control = new Control(nd);
                        control.Show();
                        control.Focus();
                        control.StartPosition= FormStartPosition.CenterScreen;
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại đăng nhập", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (txtUsername.Text == "" && txtPassword.Text == "")
                {
                    MessageBox.Show("Nhập tài khoản và mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (txtUsername.Text == "")
                    {
                        MessageBox.Show("Nhập tài khoản", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (txtPassword.Text == "")
                    {
                        MessageBox.Show("Nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void miniButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                login(txtUsername.Text, txtPassword.Text);
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Switch to fullscreen mode
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Switch to normal mode
                this.WindowState = FormWindowState.Normal;
            }
        }


    }
    }
    

