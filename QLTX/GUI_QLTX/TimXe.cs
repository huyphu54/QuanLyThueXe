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
using DTO_QLTX;

namespace GUI_QLTX
{
    public partial class TimXe : Form
    {
        BUS_LoaiXe busLoaiXe = new BUS_LoaiXe();
        BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        BUS_Xe busXe = new BUS_Xe();
        Xe xeForm = new Xe();
       
        public TimXe()
        {
            InitializeComponent();
        }

        public DateTime ngayLay()
        {
            return this.dtNgayBatDau.Value;
        }

        public DateTime ngayTra()
        {
            return this.dtNgayKetThuc.Value;
        }

        private void TimXe_Load(object sender, EventArgs e)
        {
            DataTable listLoaiXe = busLoaiXe.layLoaiXe();
            cbLoaiXe.Items.Clear();
            cbLoaiXe.Items.Add("Tất cả");

            if (listLoaiXe != null && listLoaiXe.Rows.Count > 0)
            {
                foreach (DataRow row in listLoaiXe.Rows)
                {
                    cbLoaiXe.Items.Add(row["TenLoaiXe"].ToString());
                }
            }
            cbLoaiXe.SelectedIndex = 0;
            //----------------
            DataTable listThuongHieu = busThuongHieu.layThuongHieu();
            cbThuongHieu.Items.Clear();
            cbThuongHieu.Items.Add("Tất cả");

            if (listThuongHieu != null && listThuongHieu.Rows.Count > 0)
            {
                foreach (DataRow row in listThuongHieu.Rows)
                {
                    cbThuongHieu.Items.Add(row["TenThuongHieu"].ToString());
                }
            }
            cbThuongHieu.SelectedIndex = 0;
            //-------------------
            hienThiXe();
            
        }

        public void hienThiXe()
        {          
            fpDanhSachXe.Controls.Clear();

            if (cbLoaiXe.SelectedIndex == 0 && cbThuongHieu.SelectedIndex == 0)
            {
                DataTable listXe = busXe.layXe( dtNgayBatDau.Value, dtNgayKetThuc.Value, "", "");
                if (listXe != null && listXe.Rows.Count > 0)
                {
                    foreach (DataRow xe in listXe.Rows)
                    {
                        XeUI xeForm = new XeUI(xe);
                        xeForm.setTimXeForm(this);
                        fpDanhSachXe.Controls.Add(xeForm);
                    }
                }
            }
            
        }
        private void btThemXe_Click(object sender, EventArgs e)
        {
            xeForm.showThemXe();
            xeForm.Owner = this;
            xeForm.setTimXeForm(this);
            xeForm.StartPosition = FormStartPosition.CenterParent;
            xeForm.Show(); 
        }


        private void dtNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Today;

            // Kiểm tra nếu ngày kết thúc nhỏ hơn ngày bắt đầu thì không thực hiện truy vấn
            if (dtNgayKetThuc.Value < dtNgayBatDau.Value)
            {
                // Hiển thị thông báo hoặc xử lý ngày kết thúc không hợp lệ ở đây
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                return;
            }

            // Kiểm tra nếu ngày kết thúc nhỏ hơn ngày hiện tại thì không thực hiện truy vấn
            if (dtNgayBatDau.Value < ngayHienTai)
            {
                // Hiển thị thông báo hoặc xử lý ngày kết thúc không hợp lệ ở đây
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày hiện tại");
                return;
            }
        }

        private void dtNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayHienTai = DateTime.Today;

            // Kiểm tra nếu ngày kết thúc nhỏ hơn ngày bắt đầu thì không thực hiện truy vấn
            if (dtNgayKetThuc.Value < dtNgayBatDau.Value)
            {
                // Hiển thị thông báo hoặc xử lý ngày kết thúc không hợp lệ ở đây
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu");
                return;
            }

            // Kiểm tra nếu ngày kết thúc nhỏ hơn ngày hiện tại thì không thực hiện truy vấn
            if (dtNgayKetThuc.Value < ngayHienTai)
            {
                // Hiển thị thông báo hoặc xử lý ngày kết thúc không hợp lệ ở đây
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày hiện tại");
                return;
            }

            
        }

        private void btTimXe_Click(object sender, EventArgs e)
        {
            // Thực hiện truy vấn chỉ khi điều kiện hợp lệ
            string tenLoaiXe = "", tenThuongHieu = "";
            fpDanhSachXe.Controls.Clear();
            if (cbLoaiXe.SelectedItem != "Tất cả")
                tenLoaiXe = cbLoaiXe.SelectedItem.ToString();
            if (cbThuongHieu.SelectedItem != "Tất cả")
                tenThuongHieu = cbThuongHieu.SelectedItem.ToString();
            DataTable listXe = busXe.layXe(dtNgayBatDau.Value, dtNgayKetThuc.Value, tenLoaiXe, tenThuongHieu);
            if (listXe != null && listXe.Rows.Count > 0)
            {
                foreach (DataRow xe in listXe.Rows)
                {
                    XeUI xeForm = new XeUI(xe);
                    xeForm.setTimXeForm(this);
                    fpDanhSachXe.Controls.Add(xeForm);
                }
            }
        }
    }
}
