using QLTV.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gucaffe.DAL
{
    
    class DAL_QUANLY
    {
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();

        public DataTable loadDSNV()
        {
            string sql = "select username, diachi,maloai, sodienthoai, trangthai, mail, hovaten from TAIKHOAN ";
            DataTable dt = lopchung.LoadDL(sql);
            return dt;
        }
        public DataTable timNhanVien(string something)
        {
            SqlParameter[] p = {
            new SqlParameter("@something",SqlDbType.NVarChar,20)
            };
            p[0].Value = something;
            DataTable dt = DB.ExecuteQuery("timNhanvien", p);
            return dt;
        }


        public DataTable LoadBan()
        {
            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("layBan", p);
            return dt;

        }
        public bool checkTenBan(string tenban)
        {
            try
            {
                SqlParameter[] p = {
            new SqlParameter("@tenban",SqlDbType.NVarChar,50)
            };
                p[0].Value = tenban;
                int rowsAffected = DB.ExecuteNonQuery("dbo.checkTenBan_", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }



        public bool themNhanvien(string username, string password, string diachi,string sdt, string email,string hovaten)
        {
            if (checkNull(username) == false || checkNull(diachi) ==false || checkNull(sdt) == false || checkNull(email) == false || checkNull(hovaten) == false)
            {
                return false;
            }
            try
            {
                SqlParameter[] p =
                        {
                         new SqlParameter("@username",SqlDbType.NVarChar,50),
                         new SqlParameter("@password",SqlDbType.NVarChar,50),
                         new SqlParameter("@diachi",SqlDbType.NVarChar,50),
                         new SqlParameter("@sdt",SqlDbType.NVarChar,50),
                         new SqlParameter("@email",SqlDbType.NVarChar,50),
                         new SqlParameter("@hovaten",SqlDbType.NVarChar,50),
                    };
                p[0].Value = username;
                p[1].Value = password;
                p[2].Value = diachi;
                p[3].Value = sdt;
                p[4].Value = email;
                p[5].Value = hovaten;


                int rowsAffected = DB.ExecuteNonQuery("themNV", p);

                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool khoaTK(string username,int trangthai)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@username",SqlDbType.NVarChar,50),
                         new SqlParameter("@trangthai",SqlDbType.Int),   


                    };
                p[0].Value = username;
                p[1].Value = trangthai;
                int rowsAffected = DB.ExecuteNonQuery("updateTrangthai", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }

        public bool xoaTk(string username)
        {
            if(username== "admin")
            {
                MessageBox.Show("Không thể xóa tài khoản Admin!");
                return false;
            }
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@username",SqlDbType.NVarChar,50),


                    };
                p[0].Value = username;
                int rowsAffected = DB.ExecuteNonQuery("xoa_tk", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        //Quản lý danh mục
        public DataTable LoadLoaiSP()
        {

            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("layLoaiSP", p);
            return dt;

        }
        public bool CheckDM(string tendm)
        {

            try
            {
                SqlParameter[] p = {
            new SqlParameter("@tenDM",SqlDbType.NVarChar,20)
            };
                p[0].Value = tendm;
                int rowsAffected = DB.ExecuteNonQuery("dbo.checkDM", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }
        public bool ThemDM(string tendm)
        {
            if (checkNull(tendm) == false)
            {
                return false;
            }
            try
            {
                SqlParameter[] p =
                        {
                      
                      new SqlParameter("@tendm",SqlDbType.NVarChar,20)


                    };
                p[0].Value = tendm;
                
                int rowsAffected = DB.ExecuteNonQuery("themDM", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaDM(string madm,string tendm)
        {
            if (checkNull(tendm) == false)
            {
                return false;
            }

            try
            {

                    SqlParameter[] p =
                            {
                      new SqlParameter("@madm",SqlDbType.NChar,10),
                      new SqlParameter("@tendm",SqlDbType.NVarChar,20),


                    };
                    p[0].Value = madm;
                    p[1].Value = tendm;
                    int rowsAffected = DB.ExecuteNonQuery("suaDM", p);
                    return rowsAffected == 1;
          
            }
            catch
            {
                return false;
            }
        }
        public bool XoaDM(string madm)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@madm",SqlDbType.NChar,10)
                      
                    };
                p[0].Value = madm;                
                int rowsAffected = DB.ExecuteNonQuery("xoaDM", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public DataTable timDM(string tenloai)
        {
            SqlParameter[] p = {
            new SqlParameter("@tenloai",SqlDbType.NVarChar,20)
            };
            p[0].Value = tenloai;
            DataTable dt = DB.ExecuteQuery("timDM", p);
            return dt;
        }

        //Quản lý thống kê

        public DataTable ThongKeSPTheoSL(string ngaybatdau, string ngayketthuc)
        {
            SqlParameter[] p =
                      {
                      new SqlParameter("@ngaybatdau",SqlDbType.VarChar,10),
                      new SqlParameter("@ngayketthuc",SqlDbType.VarChar,10),


                    };
            p[0].Value = ngaybatdau;
            p[1].Value = ngayketthuc;
            DataTable dt = DB.ExecuteQuery("thong_ke_sp_theoSL", p);
            return dt;

        }
        public DataTable ThongKeSPTheoTT(string ngaybatdau, string ngayketthuc)
        {
            SqlParameter[] p =
                        {
                      new SqlParameter("@ngaybatdau",SqlDbType.VarChar,10),
                      new SqlParameter("@ngayketthuc",SqlDbType.VarChar,10),


                    };
            p[0].Value = ngaybatdau;
            p[1].Value = ngayketthuc;
            DataTable dt = DB.ExecuteQuery("thong_ke_sp_theoTT", p);
            return dt;
        }
        public DataTable ThongKeDTTheoTT(string ngaybatdau, string ngayketthuc)
        {
            SqlParameter[] p =
                        {
                      new SqlParameter("@ngaybatdau",SqlDbType.VarChar,10),
                      new SqlParameter("@ngayketthuc",SqlDbType.VarChar,10),


                    };
            p[0].Value = ngaybatdau;
            p[1].Value = ngayketthuc;
            DataTable dt = DB.ExecuteQuery("thong_ke_doanhthu_theothoigian", p);
            return dt;
        }
        // Quản lí Bàn
        public bool ThemBan(string tenban)
        {
            if (checkNull(tenban) == false)
            {
                return false;
            }

            try
            {
                SqlParameter[] p =
                        {

                      new SqlParameter("@tenban",SqlDbType.NVarChar,50)


                    };
                p[0].Value = tenban;

                int rowsAffected = DB.ExecuteNonQuery("themBan", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaBan(string maban)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@maban",SqlDbType.NChar,20)

                    };
                p[0].Value = maban;
                int rowsAffected = DB.ExecuteNonQuery("xoaBan", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaBan(string maban, string tenban)
        {
            if (checkNull(tenban) == false)
            {
                return false;
            }


            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@maban",SqlDbType.NChar,10),
                      new SqlParameter("@tenban",SqlDbType.NVarChar,20),


                    };
                p[0].Value = maban;
                p[1].Value = tenban;
                int rowsAffected = DB.ExecuteNonQuery("suaBan", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public DataTable timBan(string tenban)
        {
            SqlParameter[] p = {
            new SqlParameter("@tenban",SqlDbType.NVarChar,20)
            };
            p[0].Value = tenban;
            DataTable dt = DB.ExecuteQuery("timBan", p);
            return dt;
        }
        ///Quản lý sản phẩm
        public DataTable LoadSP()
        {
            SqlParameter[] p = { };
            DataTable dt = DB.ExecuteQuery("loadSP", p);
            return dt;

        }
        public bool ThemSP(string tensanpham,int soluong,decimal dongia,string ghichu,string hinhanh,string maloai)
        {
            if (checkNull(tensanpham) == false|| checkNull(soluong.ToString()) == false|| checkNull(dongia.ToString()) == false)
            {
                return false;
            }

            try
            {


                SqlParameter[] p =
                        {

                      new SqlParameter("@tensanpham",SqlDbType.NVarChar,50),
                      new SqlParameter("@soluong",SqlDbType.Int),
                      new SqlParameter("@dongia",SqlDbType.Decimal),
                      new SqlParameter("@ghichu",SqlDbType.NVarChar,200),
                      new SqlParameter("@hinhanh",SqlDbType.NVarChar,200),
                      new SqlParameter("@maloai",SqlDbType.NChar,10),


                    };
                p[0].Value = tensanpham;
                p[1].Value = soluong;
                p[2].Value = dongia;
                p[3].Value = ghichu;
                p[4].Value = hinhanh;
                p[5].Value = maloai;

                int rowsAffected = DB.ExecuteNonQuery("themSP", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
           
        }
        public bool suaSP(string masanpham, string tensanpham, int soluong, decimal dongia, string ghichu, string maloai)
        {
            if (checkNull(tensanpham) == false || checkNull(tensanpham) == false || checkNull(soluong.ToString()) == false || checkNull(dongia.ToString()) == false)
            {
                return false;
            }

            try
            {
                SqlParameter[] p =
                        {
                     new SqlParameter("@masanpham",SqlDbType.NChar,10),
                      new SqlParameter("@tensanpham",SqlDbType.NVarChar,50),
                      new SqlParameter("@soluong",SqlDbType.Int),
                      new SqlParameter("@dongia",SqlDbType.Decimal),
                      new SqlParameter("@ghichu",SqlDbType.NVarChar,200),
                      new SqlParameter("@maloai",SqlDbType.NChar,10),


                    };
                p[0].Value = masanpham;
                p[1].Value = tensanpham;
                p[2].Value = soluong;
                p[3].Value = dongia;
                p[4].Value = ghichu;
                p[5].Value = maloai;


                int rowsAffected = DB.ExecuteNonQuery("suaSP", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public DataTable getSanpham(string masanpham)
        {
            SqlParameter[] p = {
            new SqlParameter("@masanpham",SqlDbType.NChar,10)
                    };
            p[0].Value = masanpham;
            DataTable dt = DB.ExecuteQuery("getSanpham", p);
            return dt;
        }

        public bool XoaSP(string masanpham)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@masanpham",SqlDbType.NChar,10)

                    };
                p[0].Value = masanpham;
                int rowsAffected = DB.ExecuteNonQuery("xoaSP", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public DataTable timSP(string tensanpham)
        {
            SqlParameter[] p = {
            new SqlParameter("@tensanpham",SqlDbType.NVarChar,50)
            };
            p[0].Value = tensanpham;
            DataTable dt = DB.ExecuteQuery("timSP", p);
            return dt;
        }
        public bool checkNull(string text)
        {
            if (text == "") return false;
            return true;
        }
        //quan ly hoa don
        public DataTable DanhSachHoaDon(string ngaybatdau, string ngayketthuc, string manv)
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
        public DataTable timHD(string key)
        {
            SqlParameter[] p = {
            new SqlParameter("@key",SqlDbType.NVarChar,20)
            };
            p[0].Value = key;
            DataTable dt = DB.ExecuteQuery("timkiemhoadon", p);
            return dt;
        }

        //quản lý khuyến mãi
        public DataTable DS_khuyenmai(string trangthai)
        {
            SqlParameter[] p = {
            new SqlParameter("@trangthai",SqlDbType.NChar,3)
            };
            p[0].Value = trangthai;
            DataTable dt = DB.ExecuteQuery("get_dskhuyenmai", p);
            return dt;
        }
        public DataTable timdsKM(string key)
        {
            SqlParameter[] p = {
            new SqlParameter("@key",SqlDbType.NVarChar,50)
            };
            p[0].Value = key;
            DataTable dt = DB.ExecuteQuery("tim_dskhuyenmai", p);
            return dt;
        }
        public DataTable Load_TT()
        {
            SqlParameter[] p = {
            
            };
           
            DataTable dt = DB.ExecuteQuery("load_trangthai", p);
            return dt;
        }
        public bool ThemKM(string tenkm, string ngaybatdau, string ngayketthuc, string trangthai)
        {
            if (checkNull(tenkm) == false )
            {
                return false;
            }

            try
            {


                SqlParameter[] p =
                        {

                      new SqlParameter("@tenkm",SqlDbType.NVarChar,50),
                      new SqlParameter("@ngaybatdau",SqlDbType.NChar,10),
                      new SqlParameter("@ngayketthuc",SqlDbType.NChar,10),
                       new SqlParameter("@trangthai",SqlDbType.NChar,3)
                      

                    };
                p[0].Value = tenkm;
                p[1].Value = ngaybatdau;
                p[2].Value = ngayketthuc;
                p[3].Value = trangthai;
              

                int rowsAffected = DB.ExecuteNonQuery("themKM", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }

        }
        public bool XoaKM(string makhuyenmai)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@makhuyenmai",SqlDbType.NChar,10)

                    };
                p[0].Value = makhuyenmai;
                int rowsAffected = DB.ExecuteNonQuery("xoa_km", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaTTKM(string makhuyenmai)
        {
            try
            {
                SqlParameter[] p =
                        {
                      new SqlParameter("@makm",SqlDbType.NVarChar,20)

                    };
                p[0].Value = makhuyenmai;
                int rowsAffected = DB.ExecuteNonQuery("capnhat_km", p);
                return rowsAffected == 1;
            }
            catch
            {
                return false;
            }
        }
    }


}
