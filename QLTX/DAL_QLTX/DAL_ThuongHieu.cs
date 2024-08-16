using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLTX
{
    public class DAL_ThuongHieu:DBConnect
    {
        public DataTable layThuongHieu()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From ThuongHieu", _conn);
            DataTable dtThuongHieu = new DataTable();
            da.Fill(dtThuongHieu);
            return dtThuongHieu;
        }
    }
}
