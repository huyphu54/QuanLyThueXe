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
using System.IO;

namespace GUI_QLTX
{
    public partial class Xe : Form
    {
        BUS_Xe busXe = new BUS_Xe();
        BUS_LoaiXe busLoaiXe = new BUS_LoaiXe();
        BUS_ThuongHieu busThuongHieu = new BUS_ThuongHieu();
        private TimXe _timXeForm;
        public Xe()
        {
            InitializeComponent();
        }
        public void setTimXeForm(TimXe timXe)
        {
            this._timXeForm = timXe;
        }

        private void Xe_Load(object sender, EventArgs e)
        {
            DataTable listLoaiXe = busLoaiXe.layLoaiXe();
            cbLoaiXe.Items.Clear();

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

            if (listThuongHieu != null && listThuongHieu.Rows.Count > 0)
            {
                foreach (DataRow row in listThuongHieu.Rows)
                {
                    cbThuongHieu.Items.Add(row["TenThuongHieu"].ToString());
                }
            }
            cbThuongHieu.SelectedIndex = 0;
            cbAC.SelectedIndex = 0;
            cbMayLanh.SelectedIndex = 0;
            cbCamBien.SelectedIndex = 0;

        }

        public void showThemXe()
        {
            lbTieuDe.Text = "Thêm Xe";
            this.Controls.Remove(btnCapNhat);
        }

        public void showCapNhatXe()
        {
            lbTieuDe.Text = "Cập Nhật Xe";
            txtBienSo.Enabled = false;
            this.Controls.Remove(btThemXe);
        }

        private void btThemXe_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô văn bản không rỗng
            if (string.IsNullOrEmpty(txtBienSo.Text) ||
                string.IsNullOrEmpty(txtTenXe.Text) ||
                string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu có ô văn bản không rỗng
            }
            if (!int.TryParse(txtGia.Text, out _))
            {
                MessageBox.Show("Giá phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!busXe.KiemTraBienSoTonTai(txtBienSo.Text))
            {
                bool isMayLanh = (cbMayLanh.SelectedItem.ToString() == "Có") ? true : false;
                bool isCamBien = (cbCamBien.SelectedItem.ToString() == "Có") ? true : false;
                bool isAC = (cbAC.SelectedItem.ToString() == "Có") ? true : false;
                busXe.themXe(txtBienSo.Text, txtTenXe.Text, "Trống", int.Parse(txtGia.Text), cbThuongHieu.SelectedItem.ToString(), cbLoaiXe.SelectedItem.ToString(), isMayLanh, isCamBien, isAC, ImageToByteArray(picXe.Image));
                _timXeForm.hienThiXe();
            }
            else
            {
                MessageBox.Show("Xe có biển số này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void hienThiXeCapNhat(int idXe)
        {
            DataTable listLoaiXe = busLoaiXe.layLoaiXe();
            cbLoaiXe.Items.Clear();

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

            if (listThuongHieu != null && listThuongHieu.Rows.Count > 0)
            {
                foreach (DataRow row in listThuongHieu.Rows)
                {
                    cbThuongHieu.Items.Add(row["TenThuongHieu"].ToString());
                }
            }
            DTO_QLTX.Xe xeObj = busXe.LayXeTheoID(idXe);
            txtTenXe.Text = xeObj.MoTa;
            txtGia.Text = xeObj.GiaThue.ToString();
            txtBienSo.Text = xeObj.BienSo.ToString();
            cbLoaiXe.SelectedItem = xeObj.LoaiXe.TenLoaiXe;
            cbThuongHieu.SelectedItem = xeObj.ThuongHieu.TenThuongHieu;
            cbMayLanh.SelectedItem = (bool)xeObj.MayLanh ? "Có" : "Không";
            cbAC.SelectedItem = (bool)xeObj.AC ? "Có" : "Không";
            cbCamBien.SelectedItem = (bool)xeObj.CamBienLui ? "Có" : "Không";
            // Chuyển đổi dữ liệu byte[] thành một đối tượng hình ảnh
            using (MemoryStream ms = new MemoryStream(xeObj.HinhAnh as byte[]))
            {
                picXe.Image = Image.FromStream(ms);
            }
        }

        byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra các ô văn bản không rỗng
            if (string.IsNullOrEmpty(txtBienSo.Text) ||
                string.IsNullOrEmpty(txtTenXe.Text) ||
                string.IsNullOrEmpty(txtGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại nếu có ô văn bản không rỗng
            }
            if (!int.TryParse(txtGia.Text, out _))
            {
                MessageBox.Show("Giá phải là một số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool isMayLanh = (cbMayLanh.SelectedItem.ToString() == "Có") ? true : false;
            bool isCamBien = (cbCamBien.SelectedItem.ToString() == "Có") ? true : false;
            bool isAC = (cbAC.SelectedItem.ToString() == "Có") ? true : false;
            busXe.suaXe(txtBienSo.Text, txtTenXe.Text, "Trống", int.Parse(txtGia.Text), cbThuongHieu.SelectedItem.ToString(), cbLoaiXe.SelectedItem.ToString(), isMayLanh, isCamBien, isAC, ImageToByteArray(picXe.Image));
            _timXeForm.hienThiXe();
        }

        private void picXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                picXe.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
    }
}
