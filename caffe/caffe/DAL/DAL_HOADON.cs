using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caffe.DAL
{
    class DAL_HOADON
    {
        public DataTable CT_HoaDon(string tenban)
        {
            SqlParameter[] p =
                        {
                         new SqlParameter("@tenban",SqlDbType.NVarChar,20)
                         };
            p[0].Value = tenban;

            DataTable dt = DB.ExecuteQuery("xem_hoadon", p);
            return dt;
        }
    }
}
