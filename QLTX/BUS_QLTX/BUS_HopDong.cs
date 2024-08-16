using DAL_QLTX;
using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS_QLTX
{
    public class BUS_HopDong
    {
        DAL_HopDong dalHopDong = new DAL_HopDong();

        public DataTable layHopDong()
        {
            return dalHopDong.layHopDong();
        }

        public DataTable layHopDong(string ten, int trangThai)
        {
            return dalHopDong.layHopDong(ten, trangThai);
        }

        public HopDong layHopDong (int maHopDong)
        {
            return dalHopDong.layHopDong (maHopDong);
        }
        public void xoaHopDong(int maHopDong)
        {
            dalHopDong.xoaHopDong(maHopDong);
        }


        public void themHopDong(DateTime ngayLapHopDong, float tongTien, float tienDatCoc, string cacDieuKhoan, int maKhachHang,HashSet<ChiTietHopDong> chitiet)
        {
            dalHopDong.themHopDong(ngayLapHopDong, tongTien, tienDatCoc, cacDieuKhoan, maKhachHang, chitiet);
        }

        public bool kiemtraDate(int maXe, DateTime ngay)
        {
            return dalHopDong.kiemtraDate(maXe,ngay);
        }


    }
}
