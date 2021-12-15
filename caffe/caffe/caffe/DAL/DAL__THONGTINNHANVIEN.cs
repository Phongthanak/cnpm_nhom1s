using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace caffe.DAL
{
    class DAL__THONGTINNHANVIEN
    {
        public DataTable getThongtin(string username)
        {
            SqlParameter[] p = {
            new SqlParameter("@username",SqlDbType.NVarChar,50)
            };
            p[0].Value = username;
            DataTable dt = DB.ExecuteQuery("getThongtin", p);
            return dt;
        }
        public bool updateThongtin(string username,string diachi,string sodienthoai,string mail)
        {
            try
            {
                SqlParameter[] p =
                        {
                        new SqlParameter("@username",SqlDbType.NVarChar,10),
                        new SqlParameter("@sodienthoai",SqlDbType.NVarChar,15),
                        new SqlParameter("@diachi",SqlDbType.NVarChar,255),
                         new SqlParameter("@mail",SqlDbType.NVarChar,50),

                    };
                p[0].Value = username;
                p[1].Value = sodienthoai;
                p[2].Value = diachi;
                p[3].Value = mail;

                int rowsAffected = DB.ExecuteNonQuery("suaThongtin", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }

        public bool updateMatkhau(string username, string matkhau)
        {
            try
            {
                SqlParameter[] p =
                        {
                        new SqlParameter("@username",SqlDbType.NVarChar,50),
                        new SqlParameter("@newpass",SqlDbType.NVarChar,50),
  

                    };
                p[0].Value = username;
                p[1].Value = matkhau;
     

                int rowsAffected = DB.ExecuteNonQuery("doiMatkhau", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }


        public bool checkMatkhau(string username, string matkhau)
        {
            try
            {
                SqlParameter[] p =
                        {
                        new SqlParameter("@username",SqlDbType.NVarChar,50),
                        new SqlParameter("@password",SqlDbType.NVarChar,50),


                    };
                p[0].Value = username;
                p[1].Value = matkhau;


                int rowsAffected = DB.ExecuteIntCommand("dbo.checkPass", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }

    }
}
