using BUS_QLTX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLTX
{
    public partial class KhachHang : Form
    {
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        public KhachHang()
        {
            InitializeComponent();
        }

        private void Khách_Hàng_Load(object sender, EventArgs e)
        {
            DataTable dtKhachHang = busKhachHang.layKhachHang();
            hienThiKhachHang(dtKhachHang);
        }

        private void hienThiKhachHang(DataTable dtKhachHang)
        {
            dgKhachHang.DataSource = dtKhachHang;
        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            DataTable dtKhachHang = null;

            dtKhachHang = busKhachHang.layKhachHang(txtTenKH.Text, txtSoDienThoaiKH.Text, txtCCCD.Text);
            hienThiKhachHang(dtKhachHang);
        }

        private void btSuaKH_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSoDienThoaiKH.Text == "" || txtCCCD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phoneNumber = txtSoDienThoaiKH.Text;

            // Kiểm tra chiều dài của số điện thoại và xem nó có phải là số không
            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                if (phoneNumber.Length != 10)
                    MessageBox.Show("Số điện thoại phải có 10 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!int.TryParse(txtSoDienThoaiKH.Text, out _))
                    MessageBox.Show("Số điện thoại phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem số điện thoại có chứa chữ số không ở đầu không
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải được bắt đầu bằng số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra CCCD (ID card number)
            if (!int.TryParse(txtCCCD.Text, out _))
            {
                MessageBox.Show("CCCD phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cccd = int.Parse(txtCCCD.Text);
            DTO_QLTX.KhachHang khachHang = busKhachHang.timKhachHang(cccd);
            if (khachHang != null)
            {
                busKhachHang.suaKhachHang(txtTenKH.Text, Convert.ToInt32(txtSoDienThoaiKH.Text), Convert.ToInt32(txtCCCD.Text));
            }
            else
            {
                MessageBox.Show("Khách hàng chưa tồn tại để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DataTable dtKhachHang = busKhachHang.layKhachHang();
            hienThiKhachHang(dtKhachHang);
        }

        private void btThemKH_Click (object sender, EventArgs e)
        {
            if (txtTenKH.Text == "" || txtSoDienThoaiKH.Text == "" || txtCCCD.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tất cả dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phoneNumber = txtSoDienThoaiKH.Text;

            // Kiểm tra chiều dài của số điện thoại và xem nó có phải là số không
            if (phoneNumber.Length != 10 || !phoneNumber.All(char.IsDigit))
            {
                if (phoneNumber.Length != 10)
                    MessageBox.Show("Số điện thoại phải có 10 số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (!int.TryParse(txtSoDienThoaiKH.Text, out _))
                    MessageBox.Show("Số điện thoại phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra xem số điện thoại có chứa chữ số không ở đầu không
            if (!phoneNumber.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải được bắt đầu bằng số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra CCCD (ID card number)
            if (!int.TryParse(txtCCCD.Text, out _))
            {
                MessageBox.Show("CCCD phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cccd = int.Parse(txtCCCD.Text);
            DTO_QLTX.KhachHang khachHang = busKhachHang.timKhachHang(cccd);
            if (khachHang == null)
            {
                busKhachHang.themKhachHang(txtTenKH.Text, Convert.ToInt32(txtSoDienThoaiKH.Text), Convert.ToInt32(txtCCCD.Text));
            }

            DataTable dtKhachHang = busKhachHang.layKhachHang();
            hienThiKhachHang(dtKhachHang);

        }



        private void dgKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Đảm bảo rằng chỉ số hàng hợp lệ được click (không phải là tiêu đề)
            {
                // Lấy dòng được click
                DataGridViewRow row = dgKhachHang.Rows[e.RowIndex];

                // Lấy số CCCD từ dòng được click
                int soCCCD = Convert.ToInt32(row.Cells["SoCCCD"].Value);

                // Gọi phương thức lấy thông tin hợp đồng từ Bus hoặc Dao
                DataTable hopDong = busKhachHang.layHopDong(soCCCD);

                // Hiển thị thông tin hợp đồng trong DataGridView dgDonHang
                dgDonHang.DataSource = hopDong;

                txtCCCD.Text = row.Cells["SoCCCD"].Value.ToString();
                txtSoDienThoaiKH.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhachHang"].Value.ToString();

            }
        }
    }
}
