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
using BUS_QLTX;
using DTO_QLTX;

namespace GUI_QLTX
{
    public partial class XeUI : UserControl
    {
        BUS_Xe busXe = new BUS_Xe();
        private int xeID = -1;
        private TimXe _timXeForm;

        public void setTimXeForm(TimXe timXe)
        {
            this._timXeForm = timXe;
        }

        public XeUI()
        {
            InitializeComponent();
        }
        public XeUI(DataRow xe)
        {
            InitializeComponent();
            // Load the image from file
           // Image image = Image.FromFile(xe["HinhAnh"].ToString()); // Chỉnh sửa

            // Assign the image to the PictureBox
          //  picXe.Image = image;
            lbTenXe.Text ="Tên xe: " +xe["MoTa"].ToString();
            lbGia.Text ="Giá thuê: " + xe["GiaThue"].ToString() + "đ/ngày";
            lbBienSo.Text ="Biển số: " + xe["BienSo"].ToString();
            lbMayLanh.Text = ((bool)xe["MayLanh"]) ? "Có" : "Không"; // Chuyển đổi kiểu dữ liệu
            lbCamBien.Text = ((bool)xe["CamBienLui"]) ? "Có" : "Không"; // Chuyển đổi kiểu dữ liệu
            lbAC.Text = ((bool)xe["AC"]) ? "Có" : "Không"; // Chuyển đổi kiểu dữ liệu
            lbThuongHieu.Text = xe["TenThuongHieu"].ToString();
            lbLoaiXe.Text = xe["TenLoaiXe"].ToString();
            xeID = (int)xe["MaXe"];
            // Chuyển đổi dữ liệu byte[] thành một đối tượng hình ảnh
            using (MemoryStream ms = new MemoryStream(xe["HinhAnh"] as byte[]))
            {
                picXe.Image = Image.FromStream(ms);
            }
        }

        public void hienThi(int xeID)
        {
            DTO_QLTX.Xe xe = busXe.LayXeTheoID(xeID);
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
            this.Controls.Remove(btThueXe);
            this.Controls.Remove(btXoa);
            this.Controls.Remove(btCapNhat);
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            Xe xeForm = new Xe();
            xeForm.showCapNhatXe();
            xeForm.StartPosition = FormStartPosition.CenterParent;
            xeForm.Show();
            xeForm.hienThiXeCapNhat(xeID);
            xeForm.setTimXeForm(_timXeForm);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            busXe.xoaXe(xeID);
            _timXeForm.hienThiXe();
        }

        private void btThueXe_Click(object sender, EventArgs e)
        {
            Control.hienThiThueXe();
            Control.thueXe(new ChiTietHopDong(_timXeForm.ngayLay(), _timXeForm.ngayTra(), xeID));
            Control.tinhTien();
        }

        private void XeUI_Load(object sender, EventArgs e)
        {

        }
    }
}
