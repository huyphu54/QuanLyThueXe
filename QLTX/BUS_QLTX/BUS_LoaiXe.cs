using DAL_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLTX
{
    public class BUS_LoaiXe
    {
        DAL_LoaiXe dalLoaiXe = new DAL_LoaiXe();
        public DataTable layLoaiXe()
        {
            return dalLoaiXe.layLoaiXe();
        }
    }
}
