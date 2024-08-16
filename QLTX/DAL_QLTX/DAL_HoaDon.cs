using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLTX
{
    public class DAL_HoaDon:DBConnect
    {
        public void themHoaDon(DateTime ngayLapHoaDon, double tongTien, int maHopDong, double phatSinh)
        {
            try
            {
                _conn.Open();

                string queryInsert = "INSERT INTO HoaDon (NgayLapHoaDon, TongTien, MaHopDong, PhatSinh) " +
                                     "VALUES (@NgayLapHoaDon, @TongTien, @MaHopDong, @PhatSinh)";

                SqlCommand commandInsert = new SqlCommand(queryInsert, _conn);
                commandInsert.Parameters.AddWithValue("@NgayLapHoaDon", ngayLapHoaDon);
                commandInsert.Parameters.AddWithValue("@TongTien", tongTien);
                commandInsert.Parameters.AddWithValue("@MaHopDong", maHopDong);
                commandInsert.Parameters.AddWithValue("@PhatSinh", phatSinh);

                commandInsert.ExecuteNonQuery();

                string queryUpdate = "UPDATE HopDong SET ThanhToan = 1 WHERE MaHopDong = @MaHopDong";

                SqlCommand commandUpdate = new SqlCommand(queryUpdate, _conn);
                commandUpdate.Parameters.AddWithValue("@MaHopDong", maHopDong);
                commandUpdate.ExecuteNonQuery();

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm hóa đơn thất bại. Vui lòng thử lại sau.\n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _conn.Close();
            }
        }

    }
}
