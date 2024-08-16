using BUS_QLTX;
using DTO_QLTX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace GUI_QLTX
{
    public partial class ThueXe : Form
    {
        BUS_HopDong busHopDong = new BUS_HopDong();
        BUS_Xe busXe = new BUS_Xe();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        private HashSet<ChiTietHopDong> dsXe = new HashSet<ChiTietHopDong>();
        private int idKhachHang;
        public void themXeThue (ChiTietHopDong chiTiet)
        {
            foreach(ChiTietHopDong item in dsXe)
            {
                if (item.MaXe == chiTiet.MaXe) return;
            }
            dsXe.Add(chiTiet);
            fpDSXe.Controls.Clear();
            foreach (ChiTietHopDong item in dsXe)
            {
                XeChiTiet xeUI = new XeChiTiet(this);
                xeUI.hienThi(item);
                fpDSXe.Controls.Add(xeUI);
            }
        }

        public void tinhTien()
        {
            int total = 0; 
            fpTinhTien.Controls.Clear();
            foreach (ChiTietHopDong chiTiet in dsXe)
            {
                TimeSpan difference = chiTiet.NgayKetThuc.Value.Subtract(chiTiet.NgayKhoiHanh.Value);

                int day = difference.Days +1;
                DTO_QLTX.Xe xe = busXe.LayXeTheoID((int)chiTiet.MaXe);
                Label lb = new Label();
                lb.Text = string.Format("{0} : {1} đ * {2}= {3} đ", xe.BienSo, xe.GiaThue, day, day* xe.GiaThue);
                lb.AutoSize = true;
                fpTinhTien.Controls.Add(lb);
                total += day * (int)xe.GiaThue;
            }
            lbTongTien.Text = total.ToString() + " đ";
        }
        public ThueXe()
        {
            InitializeComponent();
        }

        private void ThueXe_Load(object sender, EventArgs e)
        {
            tinhTien();
            fpDSXe.Controls.Clear();
            foreach (ChiTietHopDong item in dsXe)
            {
                XeChiTiet xeUI = new XeChiTiet(this);
                xeUI.hienThi(item);
                fpDSXe.Controls.Add(xeUI);
            }
        }

        private void btTimKH_Click(object sender, EventArgs e)
        {
            if (txtCCCD.Text == "")
            {
                MessageBox.Show("Nhập thông tin khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cccd;
            if (!int.TryParse(txtCCCD.Text, out cccd)) // Kiểm tra xem liệu nhập vào có phải là một số không
            {
                MessageBox.Show("Vui lòng nhập số CCCD hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DTO_QLTX.KhachHang khachHang = busKhachHang.timKhachHang(cccd);
            if (khachHang == null)
            {
                DialogResult result = MessageBox.Show("Khách hàng không tồn tại trong hệ thống. Bạn có muốn đăng ký một khách hàng mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Mở form KhachHang để đăng ký khách hàng mới
                    KhachHang formKhachHang = new KhachHang();
                    formKhachHang.Show();
                }
                return;
            }

            // Hiển thị thông tin khách hàng nếu tìm thấy
            txtTenKH.Text = khachHang.TenKhachHang;
            txtSoDienThoaiKH.Text = khachHang.SoDienThoai.ToString();
            idKhachHang = khachHang.MaKhachHang;
        }

        private void btThueXe_Click(object sender, EventArgs e)
        {

            int total = 0;
            foreach (ChiTietHopDong chiTiet in dsXe)
            {
                TimeSpan difference = chiTiet.NgayKetThuc.Value.Subtract(chiTiet.NgayKhoiHanh.Value);

                int day = difference.Days + 1;
                
                DTO_QLTX.Xe xe = busXe.LayXeTheoID((int)chiTiet.MaXe);
                total += day * (int)xe.GiaThue;
            }
            busHopDong.themHopDong(DateTime.Now, total, txtDatCoc.Text == "" ? 0 : Convert.ToInt32(txtDatCoc.Text), txtDIeuKhoan.Text, idKhachHang, dsXe);
        }

        private void txtDatCoc_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem input có phải là một số không
            if (!int.TryParse(txtDatCoc.Text, out _))
            {
                MessageBox.Show("Vui lòng nhập một số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Nếu không phải số, bạn có thể xử lý tiếp theo ở đây hoặc bỏ qua
            }
        }
    }
}
