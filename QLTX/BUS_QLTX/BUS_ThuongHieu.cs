using DAL_QLTX;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_QLTX
{
    public class BUS_ThuongHieu
    {
        DAL_ThuongHieu dalThuongHieu = new DAL_ThuongHieu();
        public DataTable layThuongHieu()
        {
            return dalThuongHieu.layThuongHieu();
        }
    }
}
