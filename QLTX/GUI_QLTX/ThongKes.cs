using BUS_QLTX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace GUI_QLTX
{
    public partial class ThongKes : Form
    {
        BUS_ThongKe busThongKe = new BUS_ThongKe();
        public ThongKes()
        {
            InitializeComponent();
        }

        private void ThongKes_Load(object sender, EventArgs e)
        {
            vePieNam();
            vePieThang(DateTime.Now.Month);
            veColNam();
            veColThang(DateTime.Now.Month);
        }

        public void veColNam()
        {
            // Lấy dữ liệu từ Business Logic Layer
            DataTable dt = busThongKe.thongKeDoanhThu();

            // Xóa các dữ liệu cũ trên biểu đồ cột (nếu có)
            colNam.Series.Clear();

            // Tạo một loạt dữ liệu mới trên biểu đồ cột
            Series series = new Series("DoanhThuTheoThang");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu từ DataTable vào loạt dữ liệu
            foreach (DataRow row in dt.Rows)
            {
                // Lấy tháng và doanh thu từ dòng hiện tại
                int thang = Convert.ToInt32(row[0]);
                double doanhThu = Convert.ToDouble(row[1]);

                // Thêm điểm dữ liệu vào loạt dữ liệu
                series.Points.AddXY(thang, doanhThu);
            }

            // Thêm loạt dữ liệu vào biểu đồ cột
            colNam.Series.Add(series);

            // Đặt tiêu đề cho trục X và Y
            colNam.ChartAreas[0].AxisX.Title = "Tháng";
            colNam.ChartAreas[0].AxisY.Title = "Doanh thu";

            // Đặt tiêu đề cho biểu đồ
            colNam.Titles.Clear();
            colNam.Titles.Add("Doanh thu theo tháng");

            // Cập nhật lại biểu đồ
            colNam.Update();
        }

        public void veColThang(int thang)
        {
            // Lấy dữ liệu từ Business Logic Layer
            DataTable dt = busThongKe.thongKeDoanhThu(thang);

            // Xóa các điểm dữ liệu cũ
            colThang.Series.Clear();
            colThang.Titles.Clear();

            // Tạo một series mới
            Series series = new Series("vnd")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true
            };

            // Thêm series vào chart
            colThang.Series.Add(series);

            // Thêm tiêu đề cho biểu đồ
            colThang.Titles.Add("Thống kê doanh thu theo loại xe cho tháng " + thang);

            // Thêm dữ liệu từ DataTable vào series
            foreach (DataRow row in dt.Rows)
            {
                string tenLoaiXe = row["TenLoaiXe"].ToString();
                decimal soLuong = Convert.ToDecimal(row["SoLuong"]);

                series.Points.AddXY(tenLoaiXe, soLuong);
            }

            // Định dạng biểu đồ để hiển thị tỷ lệ phần trăm
            foreach (DataPoint point in series.Points)
            {
                point.Label = string.Format(new System.Globalization.CultureInfo("vi-VN"), "{0:C0}", point.YValues[0]); // Hiển thị giá trị doanh thu
            }
        }


        public void vePieNam()
        {
            DataTable dt = busThongKe.thongKeLoaiXe();
            // Xóa các điểm dữ liệu cũ
            pieNam.Series.Clear();

            // Tạo một loạt dữ liệu mới
            Series series = new Series("LoaiXe");
            series.ChartType = SeriesChartType.Pie;
            // Thêm các điểm dữ liệu từ DataTable vào loạt dữ liệu
            foreach (DataRow row in dt.Rows)
            {
                string tenLoaiXe = row["TenLoaiXe"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                series.Points.AddXY(tenLoaiXe, soLuong);
            }

            // Thêm loạt dữ liệu vào control PieChart
            pieNam.Series.Add(series);
        }

        public void vePieThang(int thang)
        {
            DataTable dt = busThongKe.thongKeLoaiXe(thang);
            // Xóa các điểm dữ liệu cũ
            pieThang.Series.Clear();

            // Tạo một loạt dữ liệu mới
            Series series = new Series("LoaiXe");
            series.ChartType = SeriesChartType.Pie;
            // Thêm các điểm dữ liệu từ DataTable vào loạt dữ liệu
            foreach (DataRow row in dt.Rows)
            {
                string tenLoaiXe = row["TenLoaiXe"].ToString();
                int soLuong = Convert.ToInt32(row["SoLuong"]);
                series.Points.AddXY(tenLoaiXe, soLuong);
            }

            // Thêm loạt dữ liệu vào control PieChart
            pieThang.Series.Add(series);
        }

        private void cbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbThang.SelectedIndex >= 0)
            {
                // Lấy giá trị của mục được chọn
                string selectedMonthValue = cbThang.SelectedItem.ToString();

                // Chuyển đổi giá trị thành số nguyên (tháng)
                if (int.TryParse(selectedMonthValue, out int selectedMonth))
                {
                    // Gọi phương thức thống kê với tháng được chọn
                    veColThang(selectedMonth);
                    vePieThang(selectedMonth);
                }
                else
                {
                    MessageBox.Show("Giá trị tháng không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tháng hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
