using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_QLTX;
using DTO_QLTX;
namespace GUI_QLTX
{
    public partial class QuanLyNguoiDung : Form
    {
        private BUS_NguoiDung nguoiDung;
        private BindingSource bsNguoiDung;

        public QuanLyNguoiDung()
        {
            InitializeComponent();
            nguoiDung = new BUS_NguoiDung();
            bsNguoiDung = new BindingSource();
            dgvNguoiDung.DataSource = bsNguoiDung;
            LoadDanhSachNguoiDung();
        }
        private void LoadDanhSachNguoiDung()
        {
            bsNguoiDung.DataSource = nguoiDung.LayDanhSachNguoiDung();
        }

        private void dgvNguoiDung_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNguoiDung.SelectedRows[0];
                txtMa.Text = row.Cells[0].Value?.ToString();
                txtName.Text = row.Cells[1].Value?.ToString();
                txtUser.Text = row.Cells[2].Value?.ToString();
                txtPass.Text = row.Cells[3].Value?.ToString();
                boxType.Text = row.Cells[4].Value?.ToString();
            }
            else
            {
                // Xử lý trường hợp không có hàng nào được chọn
                // Ví dụ: hiển thị thông báo cho người dùng
                MessageBox.Show("Không có người dùng nào được chọn.");
            }
        }

 
        private void btnAddND_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtUser.Text != "" && txtPass.Text != "" && boxType.Text != "")
            {

                string TenNguoiDung = txtName.Text;
                string TaiKhoan = txtUser.Text;
                string MatKhau = txtPass.Text;
                string LoaiNguoiDung = boxType.Text;
                NguoiDung NguoiDung = new NguoiDung
                {

                    TenNguoiDung = TenNguoiDung,
                    TaiKhoan = TaiKhoan,
                    MatKhau = MatKhau,
                    LoaiNguoiDung = LoaiNguoiDung


                };
                nguoiDung.ThemNguoiDung(NguoiDung);
                MessageBox.Show("Đã thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachNguoiDung();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count > 0)
            {

                if (txtName.Text != "" && txtUser.Text != "" && txtPass.Text != "" && boxType.Text != "")
                {
                    NguoiDung NguoiDung = (NguoiDung)dgvNguoiDung.SelectedRows[0].DataBoundItem;

                    NguoiDung.TenNguoiDung = txtName.Text;
                    NguoiDung.TaiKhoan = txtUser.Text;
                    NguoiDung.MatKhau = txtPass.Text;
                    NguoiDung.LoaiNguoiDung = boxType.Text;

                    nguoiDung.SuaNguoiDung(NguoiDung);

                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();


                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvNguoiDung.SelectedRows[0];
                int ID = Convert.ToInt16(row.Cells[0].Value.ToString());
                if (nguoiDung.XoaNguoiDung(ID))
                {
                    MessageBox.Show("Xóa người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachNguoiDung();
                }
                else
                {
                    MessageBox.Show("Xóa ko thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn thành viên muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
