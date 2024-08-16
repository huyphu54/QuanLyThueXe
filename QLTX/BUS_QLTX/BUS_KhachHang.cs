using DAL_QLTX;
using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLTX
{
    public class BUS_KhachHang
    {
        private DAL_KhachHang dalKhachHang = new DAL_KhachHang();

        public DataTable layKhachHang()
        {
            return dalKhachHang.layKhachHang();
        }

        public KhachHang layKhachHang (int maKhachHang)
        {
            return dalKhachHang.layKhachHang(maKhachHang);
        }

        public DataTable layKhachHang(string tenKH, string soDT, string cccd) {
            return dalKhachHang.layKhachHang(tenKH, soDT, cccd);
        }

        public void themKhachHang(string tenKH, int soDT, int cccd)
        {
            dalKhachHang.themKhachHang(tenKH, soDT, cccd);
        }

        public void suaKhachHang(string tenKH, int soDT, int cccd)
        {
            dalKhachHang.suaKhachHang(tenKH, soDT, cccd);
        }

        public DTO_QLTX.KhachHang timKhachHang(int cccd)
        {
            return dalKhachHang.timKhachHang(cccd);
        }

        public DataTable layHopDong(int cccd)
        {
            return dalKhachHang.layHopDong(cccd);
        }
    }
}
