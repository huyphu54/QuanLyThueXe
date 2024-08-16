using BUS_QLTX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLTX
{
    public partial class HoaDon : Form
    {
        private int maHopDong {  get; set; }
        BUS_HoaDon busHoaDon = new BUS_HoaDon();
        BUS_KhachHang busKhachHang = new BUS_KhachHang();
        BUS_HopDong busHopDong = new BUS_HopDong();
        DTO_QLTX.HopDong hd;
        private double tinhTien(DTO_QLTX.HopDong hd)
        {
            return (double)((txtPhatSinh.Text == "" ? 0 : double.Parse(txtPhatSinh.Text)) + hd.TongTien * 1.0 - hd.TienDatCoc * 1.0);

        }
        public HoaDon(int maHopDong)
        {
            this.maHopDong = maHopDong;
            
            InitializeComponent();
            hd = busHopDong.layHopDong(maHopDong);
            DTO_QLTX.KhachHang kh = busKhachHang.layKhachHang((int)hd.MaKhachHang);
            txtTenKH.Text = kh.TenKhachHang;
            txtSoDienThoaiKH.Text = kh.SoDienThoai.ToString();
            txtCCCD.Text = kh.soCCCD.ToString();
            lbMaHopDong.Text = maHopDong.ToString();
            lbTongTien.Text = hd.TongTien.ToString();
            lbDatCoc.Text = hd.TienDatCoc.ToString();
            lbThanhTien.Text = tinhTien(hd).ToString();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            busHoaDon.themHoaDon(DateTime.Now, double.Parse(lbThanhTien.Text), maHopDong, txtPhatSinh.Text == "" ? 0 : double.Parse(txtPhatSinh.Text));
            MessageBox.Show("Thanh toán thành công!", "Thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Khởi tạo một đối tượng PrintDocument
            PrintDocument printDocument = new PrintDocument();

            // Xử lý sự kiện PrintPage để vẽ nội dung của Form lên trang in
            printDocument.PrintPage += (s, ev) =>
            {
                // Vẽ nội dung của Form lên trang in
                DrawFormContent(this, ev.Graphics);
            };

            // Khởi tạo một đối tượng PrintDialog
            using (PrintDialog printDialog = new PrintDialog())
            {
                printDialog.Document = printDocument;
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    // Kích hoạt quá trình in
                    printDocument.Print();

                    // Hiển thị hộp thoại thông báo cho người dùng biết rằng in đã hoàn tất
                    MessageBox.Show("In thành công!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Người dùng huỷ hộp thoại in
                    MessageBox.Show("Huỷ in.", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }

        // Phương thức để vẽ nội dung của Form lên trang in
        private void DrawFormContent(Form form, Graphics graphics)
        {
            // Tạo một Bitmap để chứa nội dung của Form
            Bitmap bitmap = new Bitmap(form.Width, form.Height);

            // Vẽ nội dung của Form lên Bitmap
            form.DrawToBitmap(bitmap, new Rectangle(0, 0, form.Width, form.Height));

            // Vẽ Bitmap lên trang in
            graphics.DrawImage(bitmap, 0, 0);
        }

        private void txtPhatSinh_TextChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem đầu vào có phải là một số hay không
            if (!double.TryParse(txtPhatSinh.Text, out double phatSinh))
            {
                // Nếu đầu vào không phải là một số, hiển thị một thông báo và xóa nội dung vừa nhập
                MessageBox.Show("Vui lòng nhập một số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhatSinh.Text = string.Empty;
            }
            else
            {
                // Nếu đầu vào là một số, thực hiện tính toán hoặc xử lý phù hợp
                lbThanhTien.Text = tinhTien(hd).ToString();
            }
        }
    }
}
