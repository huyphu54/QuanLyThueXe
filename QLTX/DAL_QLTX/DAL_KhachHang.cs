using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLTX
{
    public class DAL_KhachHang : DBConnect
    {
        public DataTable layKhachHang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }

        public DataTable layKhachHang(string tenKH, string soDT, string cccd)
        {
            string query = string.Format("SELECT * FROM KhachHang WHERE LOWER(TenKhachHang) LIKE LOWER('%{0}%') AND CAST(SoDienThoai AS NVARCHAR(MAX)) like '%{1}%' AND CAST(soCCCD AS NVARCHAR(MAX)) like '%{2}%'", tenKH, soDT.ToString(), cccd.ToString());
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);
            return dtKhachHang;
        }

        public KhachHang layKhachHang(int? maKhachHang)
        {
            string query = string.Format("SELECT * FROM KhachHang WHERE MaKhachHang = {0}", maKhachHang);
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtKhachHang = new DataTable();
            da.Fill(dtKhachHang);

            if (dtKhachHang.Rows.Count > 0)
            {
                DataRow row = dtKhachHang.Rows[0];

                KhachHang khachHang = new KhachHang
                (
                    (int)row.Field<int?>("MaKhachHang"),
                    row.Field<string>("TenKhachHang"),
                    row.Field<double?>("SoCCCD"),
                    row.Field<int?>("SoDienThoai")
                );
                return khachHang;
            }
            else
            {
                return null; // Customer not found
            }
        }


        public void themKhachHang(string tenKH, int soDT, int cccd)
        {
            // Kết nối đến cơ sở dữ liệu
            try
            {
                _conn.Open();
               
                string queryInsert = ("INSERT INTO KhachHang(TenKhachHang, soCCCD, SoDienThoai)" +
                    "VALUES (@TenKhachHang, @SoCCCD, @SoDienThoai);" );
                SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
                commandInsert.Parameters.AddWithValue("@TenKhachHang", tenKH);
                commandInsert.Parameters.AddWithValue("@SoCCCD", cccd);
                commandInsert.Parameters.AddWithValue("@SoDienThoai", soDT);

                commandInsert.ExecuteNonQuery();
                MessageBox.Show("Thêm khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Log lỗi vào một file hoặc hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Thêm khách hàng thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { _conn.Close(); }
        }

        public void suaKhachHang(string tenKH, int soDT, int cccd)
        {
            try
            {
                _conn.Open();

                string queryUpdate = @"UPDATE KhachHang 
                               SET TenKhachHang = @TenKhachHang, 
                                   SoDienThoai = @SoDienThoai 
                               WHERE SoCCCD = @SoCCCD";
                SqlCommand commandUpdate = new SqlCommand(queryUpdate, _conn);
                commandUpdate.Parameters.AddWithValue("@TenKhachHang", tenKH);
                commandUpdate.Parameters.AddWithValue("@SoDienThoai", soDT);
                commandUpdate.Parameters.AddWithValue("@SoCCCD", cccd);

                int rowsAffected = commandUpdate.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng có số CCCD này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Log lỗi vào một file hoặc hiển thị thông báo lỗi cho người dùng
                MessageBox.Show("Cập nhật thông tin khách hàng thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }
        }


        public DTO_QLTX.KhachHang timKhachHang(int cccd)
        {
            string query = "SELECT TOP 1 MaKhachHang, TenKhachHang, SoDienThoai FROM KhachHang WHERE soCCCD = @cccd";
            SqlCommand command = new SqlCommand(query, _conn);
            command.Parameters.AddWithValue("@cccd", cccd);

            DTO_QLTX.KhachHang khachHang = null;

            try
            {
                _conn.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    khachHang = new DTO_QLTX.KhachHang(Convert.ToInt16(reader["MaKhachHang"]), reader["TenKhachHang"].ToString(), cccd, Convert.ToInt32(reader["SoDienThoai"]));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tìm khách hàng thất bại. Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }

            return khachHang;
        }

        public DataTable layHopDong(int cccd)
        {
            string query = string.Format("Select hd.* From HopDong hd JOIN KhachHang kh ON hd.MaKhachHang = kh.MaKhachHang WHERE kh.soCCCD = {0} ", cccd);
            SqlDataAdapter da = new SqlDataAdapter(query, _conn);
            DataTable dtHopDong = new DataTable();
            da.Fill(dtHopDong);
            return dtHopDong;
        }
    }

}
