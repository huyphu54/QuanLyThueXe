using BUS_QLTX;
using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLTX
{
    public partial class XeChiTiet : UserControl
    {
        BUS_HopDong busHopDong = new BUS_HopDong();
        BUS_Xe busXe = new BUS_Xe();
        private ChiTietHopDong chiTiet = null;
        private ThueXe _txForm = null;
        public XeChiTiet(ThueXe txForm)
        {
            this._txForm = txForm;
            InitializeComponent();
        }


        public void hienThi(ChiTietHopDong chiTiet)
        {
            this.chiTiet = chiTiet;
            DTO_QLTX.Xe xe = busXe.LayXeTheoID((int)chiTiet.MaXe);
            lbTenXe.Text = "Tên xe: " + xe.MoTa;
            lbGia.Text = "Giá thuê: " + xe.GiaThue + "đ/ngày";
            lbBienSo.Text = "Biển số: " + xe.BienSo;
            lbMayLanh.Text = ((bool)xe.MayLanh) ? "Có" : "Không"; // Chuyển đổi kiểu dữ liệu
            lbCamBien.Text = ((bool)xe.CamBienLui) ? "Có" : "Không"; // Chuyển đổi kiểu dữ liệu
            lbAC.Text = ((bool)xe.AC) ? "Có" : "Không"; // Chuyển đổi kiểu dữ liệu
            lbThuongHieu.Text = xe.ThuongHieu.TenThuongHieu;
            lbLoaiXe.Text = xe.LoaiXe.TenLoaiXe;
            // Chuyển đổi dữ liệu byte[] thành một đối tượng hình ảnh
            using (MemoryStream ms = new MemoryStream(xe.HinhAnh as byte[]))
            {
                picXe.Image = Image.FromStream(ms);
            }
            dtNgayLay.Value = (DateTime)chiTiet.NgayKhoiHanh;
            dtNgayLay.Enabled = false;
            dtNgayTra.Value = (DateTime)chiTiet.NgayKetThuc;
            dtNgayTra.Enabled = false;
            TimeSpan difference = dtNgayTra.Value.Subtract(dtNgayLay.Value);
            int day = difference.Days;
            this.lbTongNgay.Text = ("Tổng ngày: " + (day + 1).ToString());
            _txForm.tinhTien();
        }




        private void lbTongNgay_Click(object sender, EventArgs e)
        {

        }
    }
}
