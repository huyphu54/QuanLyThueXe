using DTO_QLTX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DAL_QLTX
{
    public class DAL_Xe:DBConnect
    {
        public DataTable layXe(DateTime ngayLay, DateTime ngayTra)
        {
            string query = @"SELECT * FROM Xe 
                     JOIN LoaiXe ON XE.MaLoaiXe = LoaiXe.MaLoaiXe 
                     JOIN ThuongHieu ON Xe.MaThuongHieu = ThuongHieu.MaThuongHieu
                     WHERE MaXe NOT IN 
                     (SELECT MaXe FROM ChiTietHopDong 
                      JOIN HopDong ON ChiTietHopDong.MaHopDong = HopDong.MaHopDong
                      WHERE ((NgayKhoiHanh BETWEEN @NgayLay AND @NgayTra) OR (NgayKetThuc BETWEEN @NgayLay AND @NgayTra))
                      AND HopDong.ThanhToan = 0)";

            using (SqlDataAdapter da = new SqlDataAdapter(query, _conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@NgayLay", ngayLay);
                da.SelectCommand.Parameters.AddWithValue("@NgayTra", ngayTra);

                DataTable dtXe = new DataTable();
                da.Fill(dtXe);
                return dtXe;
            }
        }

        public DataTable layXe(DateTime ngayLay, DateTime ngayTra, string loaiXe, string thuongHieu)
        {
            string query = string.Format(@"SELECT * FROM Xe 
                 JOIN LoaiXe ON XE.MaLoaiXe = LoaiXe.MaLoaiXe 
                 JOIN ThuongHieu ON Xe.MaThuongHieu = ThuongHieu.MaThuongHieu
                 WHERE (TenThuongHieu like N'%{0}%' ) 
                 AND (TenLoaiXe like N'%{1}%' ) 
                 AND MaXe NOT IN 
                 (SELECT MaXe FROM ChiTietHopDong 
                  JOIN HopDong ON ChiTietHopDong.MaHopDong = HopDong.MaHopDong
                  WHERE ((NgayKhoiHanh BETWEEN @NgayLay AND @NgayTra) OR (NgayKetThuc BETWEEN @NgayLay AND @NgayTra))
                  AND HopDong.ThanhToan = 0)", thuongHieu, loaiXe);

            using (SqlDataAdapter da = new SqlDataAdapter(query, _conn))
            {
                da.SelectCommand.Parameters.AddWithValue("@NgayLay", ngayLay);
                da.SelectCommand.Parameters.AddWithValue("@NgayTra", ngayTra);
                //da.SelectCommand.Parameters.AddWithValue("@TenThuongHieu", loaiXe);
                //da.SelectCommand.Parameters.AddWithValue("@TenLoaiXe", thuongHieu);

                DataTable dtXe = new DataTable();
                da.Fill(dtXe);
                return dtXe;
            }


        }



        public void themXe(string bienSo, string moTa, string tinhTrang, int giaThue, string tenThuongHieu, string tenLoaiXe, bool mayLanh, bool camBienLui, bool ac, byte[] hinhAnh)
        {
            // Kết nối đến cơ sở dữ liệu
            try
            {
                _conn.Open();
                int maThuongHieu = -1;
                int maLoaiXe = -1;

                // Lấy mã thương hiệu từ tên thương hiệu
                string queryThuongHieu = string.Format("SELECT MaThuongHieu FROM ThuongHieu WHERE TenThuongHieu = N'{0}'", tenThuongHieu);
                SqlCommand commandThuongHieu = new SqlCommand(queryThuongHieu, _conn);
                maThuongHieu = Convert.ToInt32(commandThuongHieu.ExecuteScalar());
                // Lấy mã loại xe từ tên loại xe
                string queryLoaiXe = string.Format("SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = N'{0}'", tenLoaiXe);
                SqlCommand commandLoaiXe = new SqlCommand(queryLoaiXe, _conn);
                maLoaiXe = Convert.ToInt32(commandLoaiXe.ExecuteScalar());
                // Thêm xe vào cơ sở dữ liệu
                string queryInsert = ("INSERT INTO Xe (BienSo, MoTa, TinhTrang, GiaThue, MaLoaiXe, MaThuongHieu, MayLanh, CamBienLui, AC, HinhAnh) " +
                                     "VALUES (@BienSo, @MoTa, @TinhTrang, @GiaThue, @MaLoaiXe, @MaThuongHieu, @MayLanh, @CamBienLui, @AC, @HinhAnh)");
                SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
                commandInsert.Parameters.AddWithValue("@BienSo", bienSo);
                commandInsert.Parameters.AddWithValue("@MoTa", moTa);
                commandInsert.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                commandInsert.Parameters.AddWithValue("@GiaThue", giaThue);
                commandInsert.Parameters.AddWithValue("@MaLoaiXe", maLoaiXe);
                commandInsert.Parameters.AddWithValue("@MaThuongHieu", maThuongHieu);
                commandInsert.Parameters.AddWithValue("@MayLanh", mayLanh ? 1 : 0);
                commandInsert.Parameters.AddWithValue("@CamBienLui", camBienLui ? 1 : 0);
                commandInsert.Parameters.AddWithValue("@AC", ac ? 1 : 0);
                commandInsert.Parameters.AddWithValue("@HinhAnh", hinhAnh);

                commandInsert.ExecuteNonQuery();
                MessageBox.Show("Thêm xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Log lỗi vào một file hoặc hiển thị thông báo lỗi cho người dùng
                Console.WriteLine("Đã xảy ra lỗi khi thêm xe: " + ex.Message);
                MessageBox.Show("Thêm xe thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally { _conn.Close(); }
        }


        public void suaXe(string bienSo, string moTa, string tinhTrang, int giaThue, string tenThuongHieu, string tenLoaiXe, bool mayLanh, bool camBienLui, bool ac, byte[] hinhAnh)
        {
            try
            {
                _conn.Open();

                int maThuongHieu = -1;
                int maLoaiXe = -1;

                // Lấy mã thương hiệu từ tên thương hiệu
                string queryThuongHieu = string.Format("SELECT MaThuongHieu FROM ThuongHieu WHERE TenThuongHieu = N'{0}'", tenThuongHieu);
                SqlCommand commandThuongHieu = new SqlCommand(queryThuongHieu, _conn);
                maThuongHieu = Convert.ToInt32(commandThuongHieu.ExecuteScalar());
                // Lấy mã loại xe từ tên loại xe
                string queryLoaiXe = string.Format("SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = N'{0}'", tenLoaiXe);
                SqlCommand commandLoaiXe = new SqlCommand(queryLoaiXe, _conn);
                maLoaiXe = Convert.ToInt32(commandLoaiXe.ExecuteScalar());

                string query = @"UPDATE Xe 
                         SET MoTa = @MoTa, 
                             TinhTrang = @TinhTrang, 
                             GiaThue = @GiaThue, 
                             MaLoaiXe = @MaLoaiXe, 
                             MaThuongHieu = @MaThuongHieu, 
                             MayLanh = @MayLanh, 
                             CamBienLui = @CamBienLui, 
                             AC = @AC ,
                            HinhAnh = @HinhAnh
                         WHERE BienSo = @BienSo";

                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.AddWithValue("@BienSo", bienSo);
                command.Parameters.AddWithValue("@MoTa", moTa);
                command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                command.Parameters.AddWithValue("@GiaThue", giaThue);
                command.Parameters.AddWithValue("@MaLoaiXe", maLoaiXe);
                command.Parameters.AddWithValue("@MaThuongHieu", maThuongHieu);
                command.Parameters.AddWithValue("@MayLanh", mayLanh);
                command.Parameters.AddWithValue("@CamBienLui", camBienLui);
                command.Parameters.AddWithValue("@AC", ac);
                command.Parameters.AddWithValue("@HinhAnh", hinhAnh);

                command.ExecuteNonQuery();
                MessageBox.Show("Sua xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                MessageBox.Show("Sua xe thất bại. Vui lòng thử lại sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }
        }

        public void xoaXe(int maXe)
        {
            try
            {
                _conn.Open();

                string query = "DELETE FROM XE WHERE MaXe = @MaXe";
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.AddWithValue("@MaXe", maXe);

                int rowsAffected = command.ExecuteNonQuery();

                // Kiểm tra số hàng bị ảnh hưởng bởi câu lệnh DELETE
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa xe thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy xe có mã " + maXe + " trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Đã xảy ra lỗi khi xóa xe từ cơ sở dữ liệu: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool KiemTraBienSoTonTai(string bienSo)
        {
            bool bienSoTonTai = false;

            try
            {
                _conn.Open();

                string query = string.Format("SELECT COUNT(*) FROM Xe WHERE BienSo = '{0}'", bienSo);
                SqlCommand command = new SqlCommand(query, _conn);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    bienSoTonTai = true; // Biển số tồn tại trong cơ sở dữ liệu
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log, hiển thị thông báo lỗi)
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return bienSoTonTai;
        }
        public Xe LayXeTheoID(int id)
        {
            Xe xe = null;

            try
            {
                _conn.Open();

                string query = "SELECT * FROM Xe JOIN LoaiXe On Xe.MaLoaiXe = LoaiXe.MaLoaiXe JOIN ThuongHieu th ON th.MaThuongHieu = Xe.MaThuongHieu WHERE MaXe = @MaXe";
                SqlCommand command = new SqlCommand(query, _conn);
                command.Parameters.AddWithValue("@MaXe", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Đọc dữ liệu từ reader và tạo đối tượng Xe tương ứng
                    xe = new Xe();
                    xe.MaXe = reader.GetInt32(reader.GetOrdinal("MaXe"));
                    xe.BienSo = reader.GetString(reader.GetOrdinal("BienSo"));
                    xe.MoTa = reader.GetString(reader.GetOrdinal("MoTa"));
                    xe.GiaThue = reader.GetDouble(reader.GetOrdinal("GiaThue"));
                    xe.LoaiXe = new LoaiXe();
                    xe.LoaiXe.MaLoaiXe = reader.GetInt32(reader.GetOrdinal("MaLoaiXe"));
                    xe.LoaiXe.TenLoaiXe = reader.GetString(reader.GetOrdinal("TenLoaiXe"));
                    xe.ThuongHieu = new ThuongHieu();
                    xe.ThuongHieu.MaThuongHieu = reader.GetInt32(reader.GetOrdinal("MaThuongHieu"));
                    xe.ThuongHieu.TenThuongHieu = reader.GetString(reader.GetOrdinal("TenThuongHieu"));
                    xe.MayLanh = reader.GetBoolean(reader.GetOrdinal("MayLanh"));
                    xe.AC = reader.GetBoolean(reader.GetOrdinal("AC"));
                    xe.CamBienLui = reader.GetBoolean(reader.GetOrdinal("CamBienLui"));
                    xe.HinhAnh = (byte[])reader["HinhAnh"];
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: ghi log, hiển thị thông báo lỗi)
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                _conn.Close();
            }

            return xe;
        }
    }
}

