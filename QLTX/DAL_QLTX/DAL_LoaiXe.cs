using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QLTX;

namespace DAL_QLTX
{
    public class DAL_LoaiXe:DBConnect
    {
        public DataTable layLoaiXe()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From LoaiXe", _conn);
            DataTable dtLoaiXe = new DataTable();
            da.Fill(dtLoaiXe);
            return dtLoaiXe;
        }
    }
}
