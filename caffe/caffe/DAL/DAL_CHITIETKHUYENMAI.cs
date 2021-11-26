using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caffe.DAL
{
    class DAL_CHITIETKHUYENMAI
    {
        public DataTable CT_KhuyenMai(string makhuyenmai)
        {
            SqlParameter[] p =
                        {
                         new SqlParameter("@key",SqlDbType.NVarChar,20)
                         };
            p[0].Value = makhuyenmai;

            DataTable dt = DB.ExecuteQuery("ds_km_theo_makm", p);
            return dt;
        }
        public bool SuaSPKM(string makm, string masp, int soluong, float tyle)
        {
            if (soluong<=0 || tyle<=0||tyle>100 || checkNull(soluong.ToString()) == false || checkNull(tyle.ToString()) == false)
            {
                return false;
            }
            try
            {
                SqlParameter[] p =
                        {
                         new SqlParameter("@makm",SqlDbType.NVarChar,20),
                         new SqlParameter("@masanpham",SqlDbType.NVarChar,20),
                         new SqlParameter("@soluong",SqlDbType.Int),
                         new SqlParameter("@tyle",SqlDbType.Float)
                        
                    };
                p[0].Value = makm;
                p[1].Value = masp;
                p[2].Value = soluong;
                p[3].Value = tyle;
               


                int rowsAffected = DB.ExecuteNonQuery("sua_spkm", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool xoaSPKM(string makm,string masp)
        {
            try
            {
                SqlParameter[] p =
                        {
                     new SqlParameter("@makm",SqlDbType.NVarChar,20),
                      new SqlParameter("@masp",SqlDbType.NVarChar,20)
                    };
                p[0].Value = makm;
                p[1].Value = masp;
                int rowsAffected = DB.ExecuteNonQuery("xoaSPKM", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public DataTable LoadSP()
        {
            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("loadSP", p);
            return dt;

        }
        public bool ThemSPKM(string makm, string masp, int soluong, float tyle)
        {
            if (checkNull(soluong.ToString()) == false || checkNull(tyle.ToString()) == false || tyle>100 || tyle<0 || soluong <= 0)
            {
                return false;
            }

            try
            {
                SqlParameter[] p =
                        {
                         new SqlParameter("@makm",SqlDbType.NVarChar,20),
                         new SqlParameter("@masanpham",SqlDbType.NVarChar,20),
                         new SqlParameter("@soluong",SqlDbType.Int),
                         new SqlParameter("@tyle",SqlDbType.Float)

                    };
                p[0].Value = makm;
                p[1].Value = masp;
                p[2].Value = soluong;
                p[3].Value = tyle;



                int rowsAffected = DB.ExecuteNonQuery("them_spkm", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }
        public bool checkNull(string text)
        {
            if (text == "") return false;
            return true;
        }
    }
}
