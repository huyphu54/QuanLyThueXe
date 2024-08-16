using DTO_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTX
{
    public class DAL_NguoiDung:DBConnect
    {
        public NguoiDung layNguoiDung (string username, string password)
        {
            NguoiDung nguoiDung = null;

            try
            {
                _conn.Open();
                string SQL = string.Format("SELECT * FROM NguoiDung WHERE TaiKhoan = '{0}' AND MatKhau = '{1}'", username,password);
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    nguoiDung = new NguoiDung
                    {
                        MaNguoiDung = (int)reader[0], 
                        TenNguoiDung = (string)reader[1],
                        TaiKhoan = (string)reader[2],
                        MatKhau = (string)reader[3],
                        LoaiNguoiDung = (string)reader[4]
                    };
                }

                reader.Close();
            }
            catch (Exception e)
            {
                // Ghi log hoặc xử lý ngoại lệ
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return nguoiDung;
        }
        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            List<NguoiDung> danhSachNguoiDung = new List<NguoiDung>();

            try
            {
                _conn.Open();
                string SQL = "SELECT * FROM NguoiDung";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NguoiDung nguoiDung = new NguoiDung
                    {
                        MaNguoiDung = (int)reader["MaNguoiDung"],
                        TenNguoiDung = (string)reader["TenNguoiDung"],
                        TaiKhoan = (string)reader["TaiKhoan"],
                        MatKhau = (string)reader["MatKhau"],
                        LoaiNguoiDung = (string)reader["LoaiNguoiDung"]
                    };

                    danhSachNguoiDung.Add(nguoiDung);
                }

                reader.Close();
            }
            catch (Exception e)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }

            return danhSachNguoiDung;
        }
        public void ThemNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                _conn.Open();
                string SQL = "INSERT INTO NguoiDung (TenNguoiDung, TaiKhoan, MatKhau, LoaiNguoiDung) VALUES (@TenNguoiDung, @TaiKhoan, @MatKhau, @LoaiNguoiDung)";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@TenNguoiDung", nguoiDung.TenNguoiDung);
                cmd.Parameters.AddWithValue("@TaiKhoan", nguoiDung.TaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", nguoiDung.MatKhau);
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", nguoiDung.LoaiNguoiDung);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public void SuaNguoiDung(NguoiDung nguoiDung)
        {
            try
            {
                _conn.Open();
                string SQL = "UPDATE NguoiDung SET TenNguoiDung = @TenNguoiDung, TaiKhoan = @TaiKhoan, MatKhau = @MatKhau, LoaiNguoiDung = @LoaiNguoiDung WHERE MaNguoiDung = @MaNguoiDung";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@TenNguoiDung", nguoiDung.TenNguoiDung);
                cmd.Parameters.AddWithValue("@TaiKhoan", nguoiDung.TaiKhoan);
                cmd.Parameters.AddWithValue("@MatKhau", nguoiDung.MatKhau);
                cmd.Parameters.AddWithValue("@LoaiNguoiDung", nguoiDung.LoaiNguoiDung);
                cmd.Parameters.AddWithValue("@MaNguoiDung", nguoiDung.MaNguoiDung);

                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Lỗi: " + e.Message);
            }
            finally
            {
                _conn.Close();
            }
        }
        public bool XoaNguoiDung(int maNguoiDung)
        {
            try
            {
                _conn.Open();
                string SQL = "DELETE FROM NguoiDung WHERE MaNguoiDung = @MaNguoiDung";
                SqlCommand cmd = new SqlCommand(SQL, _conn);
                cmd.Parameters.AddWithValue("@MaNguoiDung", maNguoiDung);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                // Xử lý ngoại lệ
                Console.WriteLine("Lỗi: " + e.Message);
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }
    }
}
