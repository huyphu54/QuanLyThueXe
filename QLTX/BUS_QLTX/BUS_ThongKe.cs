using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLTX;

namespace BUS_QLTX
{
    public class BUS_ThongKe
    {
        DAL_ThongKe dalThongKe = new DAL_ThongKe();
        public DataTable thongKeLoaiXe()
        {
            return dalThongKe.thongKeLoaiXe();
        }

        public DataTable thongKeLoaiXe(int thang)
        {
            return dalThongKe.thongKeLoaiXe(thang);
        }

        public DataTable thongKeDoanhThu()
        {
            return dalThongKe.thongKeDoanhThu();
        }

        public DataTable thongKeDoanhThu(int thang)
        {
            return dalThongKe.thongKeDoanhThu(thang);
        }
    }
}
