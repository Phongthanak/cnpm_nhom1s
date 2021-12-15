using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.DAL;

namespace Gucaffe.DAL
{
    class DAL_NHANVIEN
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public DataTable LoadBan()
        {
            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("layBan", p);
            return dt;

        }
        public DataTable LoadLoaiSP()
        {

            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("layLoaiSP", p);
            return dt;

        }
        public DataTable LoadMon(String text)
        {
            string sql = "select * from SANPHAM where maloai='" + text + "'";
            DataTable dt = lopchung.LoadDL(sql);
            return dt;
        }


        public int UpdateBan(bool i, String maban)
        {
            string sql = "update BAN set tranthai = 1 where maban = '" + maban + "'";
            int ketqua = (int)lopchung.ThemXoaSua(sql);
            return ketqua;
        }

        public DataTable layBantam(string maban)
        {
            SqlParameter[] p = {
            new SqlParameter("@maban",SqlDbType.NChar,10)
            };
            p[0].Value = maban;
            DataTable dt = DB.ExecuteQuery("layBantam", p);

            return dt;

        }
        public bool themMon(string maban, string masanpham, string tensanpham)
        {
            try
            {
                SqlParameter[] p =
                        {
                        new SqlParameter("@maban",SqlDbType.NChar,10),
                        new SqlParameter("@masanpham",SqlDbType.NChar,10),
                        new SqlParameter("@tensanpham",SqlDbType.NVarChar,50),
                    
                    };
                p[0].Value = maban;
                p[1].Value = masanpham;
                p[2].Value = tensanpham;
      
                int rowsAffected = DB.ExecuteNonQuery("themMon", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }

        public int updateGia()
        {
            string sql = " update BANTAM set gia = dbo.tinhThanhtien(masanpham,soluong)";
            int ketqua = lopchung.ThemXoaSua(sql);
            return ketqua;

        }


       public DataTable layTenNhanVien(String username)
        {
            SqlParameter[] p =
            {
                new SqlParameter("@username",SqlDbType.NVarChar,200),
            };
            p[0].Value = username;
            DataTable db = DB.ExecuteQuery("getNhanvien", p);
            return db;
        }
        public bool thanhToan(string mahoadon,string mataikhoan,int tongtien,string maban)
        {
            try
            {
                SqlParameter[] p =
                        {
                        new SqlParameter("@mahoadon",SqlDbType.NVarChar,50),
                          new SqlParameter("@mataikhoan",SqlDbType.NVarChar,20),
                          new SqlParameter("@tongtien",SqlDbType.Int),
                            new SqlParameter("@maban",SqlDbType.NChar,10),


                    };
                p[0].Value = mahoadon;
                p[1].Value = mataikhoan;
                p[2].Value = tongtien;
                p[3].Value = maban;
 

                int rowsAffected = DB.ExecuteNonQuery("thanhToan", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public int checkBantam(string maban)
        {
            SqlParameter[] p =
                          {
                            new SqlParameter("@maban",SqlDbType.NChar,10),


                    };
            p[0].Value = maban;
            return DB.ExecuteIntCommand("dbo.checkBanTam", p);
          

        }

         

        public bool xoaMon(string masanpham,string maban)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@masanpham",SqlDbType.NChar,10),
                        new SqlParameter("@maban",SqlDbType.NChar,10),
                      

                    };
                p[0].Value = masanpham;
                p[1].Value = maban;
                int rowsAffected = DB.ExecuteNonQuery("xoaMon", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }


        public bool coKhach(string maban)
        {
            try
            {
                SqlParameter[] p = {
            new SqlParameter("@maban",SqlDbType.NChar,10)
                  };
                p[0].Value = maban;
                int rowsAffected = DB.ExecuteNonQuery("coKhach", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }
        public bool khongKhach(string maban)
        {
            try
            {
                SqlParameter[] p = {
            new SqlParameter("@maban",SqlDbType.NChar,10)
                  };
                p[0].Value = maban;
                int rowsAffected = DB.ExecuteNonQuery("khongKhach", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }
        public bool checkTrangThaiBan(string maban)
        {
            try
            {
                SqlParameter[] p = {
            new SqlParameter("@maban",SqlDbType.NVarChar,50)
                  };
                p[0].Value = maban;
                int rowsAffected = DB.ExecuteNonQuery("dbo.checkBanTrangThai", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }
        //quan ly hoa don
        public DataTable DanhSachHoaDon(string ngaybatdau, string ngayketthuc,string manv)
        {
            SqlParameter[] p =
                        {
                      new SqlParameter("@ngaybatdau",SqlDbType.VarChar,10),
                      new SqlParameter("@ngayketthuc",SqlDbType.VarChar,10),
                       new SqlParameter("@manv",SqlDbType.NVarChar,10)

                    };
            p[0].Value = ngaybatdau;
            p[1].Value = ngayketthuc;
            p[2].Value = manv;
            DataTable dt = DB.ExecuteQuery("ds_sp_tungay_dennay_theo_nhanvien", p);
            return dt;
        }
        public DataTable DanhSachCTHoaDon(string mahoadon)
        {
            SqlParameter[] p =
                        {                      
                         new SqlParameter("@mahoadon",SqlDbType.NVarChar,20)
                         };
            p[0].Value = mahoadon;
           
            DataTable dt = DB.ExecuteQuery("ds_chitet_hoadon", p);
            return dt;
        }


    }
}
