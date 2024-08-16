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
    public partial class FMain : Form
    {

        fTrangChu ftc;
        TimXe tx;
        public FMain()
        {
            InitializeComponent();
            tx = new TimXe();
            ftc = new fTrangChu();
            
        }

        private void btTrangChu_Click(object sender, EventArgs e)
        {
            painMain.Controls.Clear();
            tx.Visible = true;
            painMain.Controls.Add(ftc);
        }

        private void btTimXe_Click(object sender, EventArgs e)
        {
            painMain.Controls.Clear();
            tx.Visible = true;
            painMain.Controls.Add(tx);
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            bool isLoggedIn = CheckUserLoginStatus();

            if (!isLoggedIn)
            {
                Login l = new Login();
               
                this.Hide();
                if (l.ShowDialog() == DialogResult.OK)
                {
                    UpdateLoginButton(true);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateLoginButton(bool isLoggedIn)
        {
            if (isLoggedIn)
            {
                btDangNhap.Text = "Đăng xuất";
            }
            else
            {
                
                btDangNhap.Text = "Đăng nhập";
            }
        }

        private bool CheckUserLoginStatus()
        {
           
            return btDangNhap.Text == "Đăng xuất";
        }

     

        private void FMain_Load_1(object sender, EventArgs e)
        {
            UpdateLoginButton(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormQuanLy ql = new FormQuanLy();
            this.Hide();
            ql.Show();
        }

        private void fTrangChu6_Load(object sender, EventArgs e)
        {

        }
    }
}
