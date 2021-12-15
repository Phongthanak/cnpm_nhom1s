using QLTV.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.Data;
namespace Gucaffe.DAL
{
    class DAL_DANGNHAP
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        public int DangNhapNhanvien(string tentaikhoan, string matkhau)
        {  
            string sql = "select count (*) from TAIKHOAN where username = '" + tentaikhoan + "' and password = '" + matkhau + "' and maloai='nhanvien'";
            return (int)lopchung.ExScalar(sql);
        }
        public int DangNhapQuanly(string tentaikhoan, string matkhau)
        {
            string sql2 = "select count (*) from TAIKHOAN where username = '" + tentaikhoan + "' and password = '" + matkhau + "' and maloai='admin'";
            return (int)lopchung.ExScalar(sql2);
        }


        public bool checkTrangthai(string username)
        {
            try
            {
                SqlParameter[] p =
                        {
                        new SqlParameter("@username",SqlDbType.NVarChar,50),
     
                    };
                p[0].Value = username;
                int rowsAffected = DB.ExecuteNonQuery("dbo.checkTrangthai", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }


    }
}
