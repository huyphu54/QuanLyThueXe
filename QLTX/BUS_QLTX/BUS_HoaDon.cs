using DAL_QLTX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLTX
{
    public class BUS_HoaDon
    {
        DAL_HoaDon dalHoaDon = new DAL_HoaDon();
        public void themHoaDon(DateTime ngayLapHoaDon, double tongTien, int maHopDong, double phatSinh)
        {
            dalHoaDon.themHoaDon(ngayLapHoaDon,tongTien, maHopDong, phatSinh);
        }
        
    }
}
