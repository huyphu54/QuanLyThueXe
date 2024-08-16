using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLTX
{
    public class DAL_HopDong:DBConnect
    {
        

        public DataTable layHopDong()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From HopDong", _conn);
            DataTable dtHopDong = new DataTable();
            da.Fill(dtHopDong);
            return dtHopDong;
        }

        public DataTable layHopDong(string ten, int trangThai)
        {
            string query;
            if (trangThai < 0)
            {
                query = string.Format("Select * From HopDong h JOIN KhachHang k ON h.MaKhachHang = k.MaKhachHang Where TenKhachHang like N'%{0}%'", ten);
            }
            else
            {
                query = string.Format("Select * From HopDong h JOIN KhachHang k ON h.MaKhachHang = k.MaKhachHang Where TenKhachHang like N'%{0}%' And ThanhToan = {1}", ten, trangThai);
            }

            SqlCommand cmd = new SqlCommand(query, _conn);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtHopDong = new DataTable();
            da.Fill(dtHopDong);

            return dtHopDong;
            
        }

        public HopDong layHopDong(int maHopDong)
        {
            string query = "SELECT * FROM HopDong WHERE MaHopDong = @MaHopDong";

            SqlCommand cmd = new SqlCommand(query, _conn);
            cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    HopDong hopDong = new HopDong();
                    DataRow row = dt.Rows[0];

                    hopDong.MaHopDong = Convert.ToInt32(row["MaHopDong"]);
                    hopDong.NgayLaphopDong = row["NgayLaphopDong"] != DBNull.Value ? Convert.ToDateTime(row["NgayLaphopDong"]) : (DateTime?)null;
                    hopDong.TongTien = row["TongTien"] != DBNull.Value ? Convert.ToDouble(row["TongTien"]) : (double?)null;
                    hopDong.TienDatCoc = row["TienDatCoc"] != DBNull.Value ? Convert.ToDouble(row["TienDatCoc"]) : (double?)null;
                    hopDong.CacDieuKhoan = row["CacDieuKhoan"] != DBNull.Value ? Convert.ToString(row["CacDieuKhoan"]) : null;
                    hopDong.MaNguoiDung = row["MaNguoiDung"] != DBNull.Value ? Convert.ToInt32(row["MaNguoiDung"]) : (int?)null;
                    hopDong.MaKhachHang = row["MaKhachHang"] != DBNull.Value ? Convert.ToInt32(row["MaKhachHang"]) : (int?)null;
                    hopDong.ThanhToan = Convert.ToBoolean(row["ThanhToan"]);

                    return hopDong;
                }
                else
                {
                    return null; // Contract not found
                }
            }
        }

         public void xoaHopDong(int maHopDong)
        {
            // Kết nối đến cơ sở dữ liệu
            try
            {
                _conn.Open();

                // Delete from ChiTietHopDong first
                string queryDeleteChiTiet = "DELETE FROM ChiTietHopDong WHERE MaHopDong = @MaHopDong";
                SqlCommand commandDeleteChiTiet = new SqlCommand(queryDeleteChiTiet, _conn);
                commandDeleteChiTiet.Parameters.AddWithValue("@MaHopDong", maHopDong);
                commandDeleteChiTiet.ExecuteNonQuery();

                // Delete from HopDong
                string queryDeleteHopDong = "DELETE FROM HopDong WHERE MaHopDong = @MaHopDong";
                SqlCommand commandDeleteHopDong = new SqlCommand(queryDeleteHopDong, _conn);
                commandDeleteHopDong.Parameters.AddWithValue("@MaHopDong", maHopDong);
                commandDeleteHopDong.ExecuteNonQuery();

                MessageBox.Show("Xóa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa hợp đồng thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }
        }


        public void themHopDong(DateTime ngayLapHopDong, float tongTien, float tienDatCoc, string cacDieuKhoan, int maKhachHang, HashSet<ChiTietHopDong>dsChiTIet)
        {
            // Kết nối đến cơ sở dữ liệu
            try
            {
                _conn.Open();
                string queryInsert = ("INSERT INTO HopDong(NgayLaphopDong, TongTien, TienDatCoc, CacDieuKhoan, MaKhachHang)"+
                                    "VALUES(@NgayLapHopDong, @TongTien, @TienDatCoc, @CacDieuKhoan, @MaKhachHang); ");
                SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
                commandInsert.Parameters.AddWithValue("@NgayLapHopDong", ngayLapHopDong);
                commandInsert.Parameters.AddWithValue("@TongTien", tongTien);
                commandInsert.Parameters.AddWithValue("@TienDatCoc", tienDatCoc);
                commandInsert.Parameters.AddWithValue("@cacDieuKhoan", cacDieuKhoan);
                commandInsert.Parameters.AddWithValue("@MaKhachHang", maKhachHang);
                commandInsert.ExecuteNonQuery();
                string queryScope = "SELECT MAX(MaHopDong) FROM HopDong";
                SqlCommand commandScope = new SqlCommand(queryScope, _conn);
                int hopDongId = Convert.ToInt32(commandScope.ExecuteScalar());

                MessageBox.Show("Thêm hợp đồng thành công!" + hopDongId, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                foreach(var chitiet in dsChiTIet)
                {
                    themChiTietHopDong(hopDongId, chitiet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hợp đồng thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { _conn.Close(); }
        }

        public void themChiTietHopDong(int idHopDong, ChiTietHopDong chiTiet)
        {
            string queryInsert = ("INSERT INTO ChiTietHopDong(NgayKhoiHanh, NgayKetThuc, MaXe, MaHopDong) " +
                "VALUES(@NgayBatDau, @NgayKetThuc, @MaXe, @MaHopDong); ");
            SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
            commandInsert.Parameters.AddWithValue("@NgayBatDau", chiTiet.NgayKhoiHanh);
            commandInsert.Parameters.AddWithValue("@NgayKetThuc", chiTiet.NgayKetThuc);
            commandInsert.Parameters.AddWithValue("@MaXe", chiTiet.MaXe);
            commandInsert.Parameters.AddWithValue("@MaHopDong", idHopDong);
            commandInsert.ExecuteNonQuery();
        }

        public bool kiemtraDate(int maXe, DateTime ngay)
        {

            try
            {
                _conn.Open();
                string query = "SELECT COUNT(*) FROM ChiTietHopDong WHERE MaXe = @MaXe AND @ngay BETWEEN NgayKhoiHanh AND NgayKetThuc";

                SqlCommand cmd = new SqlCommand(query, _conn);

                cmd.Parameters.AddWithValue("@MaXe", maXe);
                cmd.Parameters.AddWithValue("@ngay", ngay);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
            finally { _conn.Close(); }
        }


        
    }
}
