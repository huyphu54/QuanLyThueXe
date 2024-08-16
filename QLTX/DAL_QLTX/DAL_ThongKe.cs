using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace DAL_QLTX
{
    public class DAL_ThongKe:DBConnect
    {
        public DataTable thongKeLoaiXe()
        {
            string query = @"
                SELECT l.TenLoaiXe, COUNT(x.MaXe) AS SoLuong
                FROM LoaiXe l 
                JOIN Xe x ON l.MaLoaiXe = x.MaLoaiXe
                JOIN ChiTietHopDong c ON c.MaXe = x.MaXe
                JOIN HopDong h ON h.MaHopDong = c.MaHopDong
                WHERE YEAR(h.NgayLaphopDong) = YEAR(GETDATE())
                GROUP BY l.TenLoaiXe";

            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtThongKe = new DataTable();
            da.Fill(dtThongKe);
            return dtThongKe;
        }

        public DataTable thongKeLoaiXe(int thang)
        {
            string query = @"
                SELECT l.TenLoaiXe, COUNT(x.MaXe) AS SoLuong
                FROM LoaiXe l 
                JOIN Xe x ON l.MaLoaiXe = x.MaLoaiXe
                JOIN ChiTietHopDong c ON c.MaXe = x.MaXe
                JOIN HopDong h ON h.MaHopDong = c.MaHopDong
                WHERE MONTH(h.NgayLaphopDong) = @Thang AND YEAR(h.NgayLaphopDong) = YEAR(GETDATE())
                GROUP BY l.TenLoaiXe";

            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@Thang", thang);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtThongKe = new DataTable();
            da.Fill(dtThongKe);
            return dtThongKe;
        }

        public DataTable thongKeDoanhThu () {
            string query = @"SELECT MONTH(h.NgayLaphopDong) AS Thang, SUM(h.TongTien) AS DoanhThu
                         FROM LoaiXe l
                         JOIN Xe x ON l.MaLoaiXe = x.MaLoaiXe
                         JOIN ChiTietHopDong c ON c.MaXe = x.MaXe
                         JOIN HopDong h ON h.MaHopDong = c.MaHopDong
                         WHERE YEAR(h.NgayLaphopDong) = YEAR(GETDATE()) AND h.ThanhToan = 1
                         GROUP BY MONTH(h.NgayLaphopDong)";

            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtThongKe = new DataTable();
            da.Fill(dtThongKe);
            return dtThongKe;
        }

        public DataTable thongKeDoanhThu(int thang)
        {
            string query = @"SELECT l.TenLoaiXe, SUM(x.GiaThue) AS SoLuong
                            FROM LoaiXe l 
                            JOIN Xe x ON l.MaLoaiXe = x.MaLoaiXe
                            JOIN ChiTietHopDong c ON c.MaXe = x.MaXe
                            JOIN HopDong h ON h.MaHopDong = c.MaHopDong
                            WHERE MONTH(h.NgayLaphopDong) = @thang AND YEAR(h.NgayLaphopDong) = YEAR(GETDATE())
                            GROUP BY l.TenLoaiXe";

            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@Thang", thang);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtThongKe = new DataTable();
            da.Fill(dtThongKe);
            return dtThongKe;
        }
    }
}
