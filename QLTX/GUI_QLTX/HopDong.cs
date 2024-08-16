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
    public partial class HopDong : Form
    {
        BUS_HopDong busHopDong = new BUS_HopDong();
        DataTable dt;
        public HopDong()
        {
            InitializeComponent();
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            dt = busHopDong.layHopDong();
            dgvHopDong.DataSource = dt;
            cbTrangThai.SelectedIndex = 0;
            lbTongDon.Text = "Tổng: " + dt.Rows.Count.ToString();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            string ten = txtTen.Text;
            if (cbTrangThai.SelectedIndex == 0)
            {
               dt = busHopDong.layHopDong(ten, -1);
            }else if (cbTrangThai.SelectedIndex == 1)
            {
                dt = busHopDong.layHopDong(ten, 0);
            }else if (cbTrangThai.SelectedIndex == 2)
            {
                dt = busHopDong.layHopDong(ten, 1);
            }
            dgvHopDong.DataSource = dt;
            lbTongDon.Text = "Tổng: " + dt.Rows.Count.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
        
            if (dgvHopDong.SelectedRows.Count > 0)
            {
                // Assuming the contract ID is stored in the first cell of the selected row
                int maHopDong = Convert.ToInt32(dgvHopDong.SelectedRows[0].Cells[0].Value);

                // Confirm deletion
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    busHopDong.xoaHopDong(maHopDong);

                    // Refresh the DataGridView or DataTable after deletion
                    dt = busHopDong.layHopDong();
                    dgvHopDong.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvHopDong.SelectedRows.Count > 0)
            {
                // Lấy index của dòng được chọn
                int selectedRowIndex = dgvHopDong.SelectedRows[0].Index;

                // Lấy giá trị của cột ThanhToan từ dòng được chọn
                bool thanhToan = Convert.ToBoolean(dgvHopDong.Rows[selectedRowIndex].Cells["ThanhToan"].Value);

                if (thanhToan)
                {
                    MessageBox.Show("Hợp đồng đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int maHopDong = Convert.ToInt32(dgvHopDong.Rows[selectedRowIndex].Cells["MaHopDong"].Value);
                    HoaDon hoaDonForm = new HoaDon(maHopDong);
                    hoaDonForm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn hợp đồng thanh toán", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
