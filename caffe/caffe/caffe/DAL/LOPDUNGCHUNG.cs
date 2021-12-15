using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraExport.Xls;
using System.IO;    

namespace QLTV.DAL
{
    class LOPDUNGCHUNG
    {
        string chuoiketnoi = @"Data Source=DESKTOP-JMGV6AK\HUUTUAN;Initial Catalog=QLCF;User ID=sa;Password=12345";
        // string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + @"\db_Gucafe.mdf;Integrated Security=True";
        SqlConnection conn;
        public LOPDUNGCHUNG()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public void Mo()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }
        public void Dong()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }
     
        public int ThemXoaSua(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            Mo();
            
            int ketqua = comm.ExecuteNonQuery();
            //conn.Close();
            Dong();
            return ketqua;
        }
        public DataTable LoadDL(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
      
        public object ExScalar(string sql)
        {
            SqlCommand comm = new SqlCommand(sql, conn);
            // conn.Open();
            Mo();
            object ketqua = comm.ExecuteScalar();
            //conn.Close();
            Dong();
            return ketqua;
        }
    }
}


