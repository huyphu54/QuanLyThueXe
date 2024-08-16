using DAL_QLTX;
using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLTX
{
    public class BUS_Xe
    {
        DAL_Xe dalXe = new DAL_Xe();

        public DataTable layXe(DateTime ngayLay, DateTime NgayTra, string thuongHieu, string loaiXe)
        {
            return dalXe.layXe(ngayLay, NgayTra, thuongHieu, loaiXe);
        }

        public void themXe(string bienSo, string moTa, string tinhTrang, int giaThue, string tenThuongHieu, string tenLoaiXe, bool mayLanh, bool camBienLui, bool ac, byte[] hinhAnh)
        {
            dalXe.themXe(bienSo, moTa, tinhTrang, giaThue, tenThuongHieu, tenLoaiXe, mayLanh, camBienLui, ac, hinhAnh);
        }

        public bool KiemTraBienSoTonTai(string bienSo)
        {
            
            return dalXe.KiemTraBienSoTonTai(bienSo);
        }
        public Xe LayXeTheoID(int id)
        {
            return dalXe.LayXeTheoID(id);
        }
        public void suaXe(string bienSo, string moTa, string tinhTrang, int giaThue, string tenThuongHieu, string tenLoaiXe, bool mayLanh, bool camBienLui, bool ac, byte[] hinhAnh)
        {
            dalXe.suaXe(bienSo, moTa, tinhTrang, giaThue, tenThuongHieu, tenLoaiXe, mayLanh, camBienLui, ac, hinhAnh);
        }
        public void xoaXe(int maXe)
        {
            dalXe.xoaXe(maXe);
        }
    }
}
