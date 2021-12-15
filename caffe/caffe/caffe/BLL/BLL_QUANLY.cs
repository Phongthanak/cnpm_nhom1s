using caffe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Gucaffe.DAL;
using Gucaffe.DAL;
using System.Windows.Forms;

namespace caffe.BLL
{
    
    class BLL_QUANLY
    {
        frm_QuanLy quanly;
        frm_TaoBan taoban;        
        frm_TaoTaiKhoan taotaikhoan;
        frm_TaoDM taodm;
        frm_ThemSanPham themsp;
        DAL_QUANLY dal_quanly = new DAL_QUANLY();
        public BLL_QUANLY(frm_QuanLy f)
        {
            quanly = f;
        }

        public BLL_QUANLY(frm_TaoTaiKhoan t)
        {
            taotaikhoan = t;
        }

        public BLL_QUANLY(frm_TaoBan b)
        {
            taoban = b;
        }
        public BLL_QUANLY(frm_TaoDM d)
        {
            taodm = d;
        }
        public BLL_QUANLY(frm_ThemSanPham sp)
        {
            themsp = sp;
        }




        public void loadDSNV()
        {
            quanly.gridview_QLNV.DataSource = dal_quanly.loadDSNV();
        }

        public void timNV()
        {
           
            string something = quanly.txt_timNV.Text;
            quanly.gridview_QLNV.DataSource = dal_quanly.timNhanVien(something);
        }

        public bool taoTK()
        {
            string username = taotaikhoan.txt_username.Text;
            string diachi = taotaikhoan.txt_diachi.Text;
            string matkhau = taotaikhoan.txt_matkhau.Text;
            string sdt = taotaikhoan.txt_sodienthoai.Text;
            string email = taotaikhoan.txt_email.Text;
            string hovaten = taotaikhoan.txt_hovaten.Text;
            bool check = dal_quanly.themNhanvien(username, matkhau, diachi, sdt, email, hovaten);
            return check;
        }

        public void loadBan()
        {
            quanly.gridViewQLB.DataSource = dal_quanly.LoadBan();
        }

        public void xoaTK(string username)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa tài khoản không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.xoaTk(username);
                    if (i == true)
                    {
                        loadDSNV();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                    break;
                case DialogResult.No:
                    return;
            }

          
           
        }


        public void checkTenBan()
        {
            string tenban = taoban.txt_tenban.Text;

            {

                if (tenban.Length > 0)
                {
                    bool check = dal_quanly.checkTenBan(tenban);
                    MessageBox.Show(" "+tenban+" "+check);

                    if (check == false)
                    {
                        MessageBox.Show("Khong trung");

                        //taoban.lbl_checkTenban.Visible = true;
                        //taoban.lbl_loitenban.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("trung");
                        //taoban.lbl_loitenban.Visible = true;
                        //taoban.lbl_checkTenban.Visible = false;


                    }
                }
                else
                {
                    taoban.lbl_checkTenban.Visible = false;
                    taoban.lbl_loitenban.Visible = false;
                }
            }


        }
        public void khoaTK(string username)
        {

            int trangthai = 0;
            string value = quanly.gridview_QLNV.Rows[quanly.gridview_QLNV.CurrentRow.Index].Cells["username"].Value.ToString();
            if (int.Parse(quanly.gridview_QLNV.Rows[quanly.gridview_QLNV.CurrentRow.Index].Cells["trangthai"].Value.ToString()) == 1) 
            {


                DialogResult dr = MessageBox.Show("Bạn có thật sự muốn khóa tài khoản không?",
                          "Mood Test", MessageBoxButtons.YesNo);
                switch (dr)
                {
                    case DialogResult.Yes:
                        trangthai = 0;
                        break;
                    case DialogResult.No:
                        return;
                }
                
            }
            else
            {
                trangthai = 1;
            }

            bool i = dal_quanly.khoaTK(username, trangthai);
            if (i == true) {
                loadDSNV();
                MessageBox.Show("Update trạng thái thành công!");
            }
            else {
              
                MessageBox.Show("Update trạng thái thất bại!");
             
            }

        }
        //QUản lý danh mục
        public void loadLoaiSP()
        {
            quanly.grd_danhmuc.DataSource = dal_quanly.LoadLoaiSP();
          
        }
        
        public bool themDM()
        {
            string tendm=taodm.txt_tendm.Text;
            bool i = dal_quanly.ThemDM(tendm);
            return i;
        }
        public void suaDM(string madm ,string tendm)
        {
            bool i = dal_quanly.SuaDM(madm,tendm);
              if (i == true)
                {
                   
                    MessageBox.Show("Update danh mục thành công!");
                     loadLoaiSP();
            }
                else
                {

                    MessageBox.Show("Update danh mục thất bại!");

                }
        }
        public void xoaDM(string madm,string tendm)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa danh mục " +tendm+" này không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.XoaDM(madm);
                    if (i == true)
                    {
                        loadDSNV();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                    break;
                case DialogResult.No:
                    return;
            }
      }
        public void timDM()
        {

            string timDM = quanly.txt_timkiem.Text;
            quanly.grd_danhmuc.DataSource = dal_quanly.timDM(timDM);
        }

        //Quản lý thống kê

        public void thongke_sp_theoSL()
        {
            string ngaybatdau = quanly.ngaybatdau.Text;
            string ngayketthuc = quanly.ngayketthuc.Text;
            quanly.grd_thongke.DataSource = dal_quanly.ThongKeSPTheoSL(ngaybatdau, ngayketthuc);
        }
        public void thongke_sp_theoTT()
        {
            string ngaybatdau = quanly.ngaybatdau.Text;
            string ngayketthuc = quanly.ngayketthuc.Text;
            quanly.grd_thongke.DataSource = dal_quanly.ThongKeSPTheoTT(ngaybatdau, ngayketthuc);
            quanly.grd_thongke.Columns[5].Visible = false;
        }
       
        public void thongkeSP()
        {
            if (check_luachon() == true)
            {
                thongke_sp_theoSL();
            }
            else
            { 
           
                thongke_sp_theoTT();
            }
            
        }
       
        public int check_ngay(DateTime a,DateTime b)
        {
            if (a<b)
            {
                return 1;
            }
            else
                if (a==b)
            {
                return 2;
            }


            return 0;
        }
        public bool check_luachon()
        {
            if (quanly.rd_sl.Checked)
            {
                return true;
            }
            return false;
        }

        public void thongke_DT_theoTT()
        {
            string ngaybatdau = quanly.ngaybatdau_DT.Text;
            string ngayketthuc = quanly.ngayketthuc_DT.Text;
            quanly.grd_thongkeDT.DataSource = dal_quanly.ThongKeDTTheoTT(ngaybatdau, ngayketthuc);
          
           
        }
        public void tinh_tong_tien_DT()
        {
            decimal price = 0;
            foreach (DataGridViewRow row in quanly.grd_thongkeDT.Rows)
            {
                price += row.Cells["tongtien"] != null ? Convert.ToDecimal(row.Cells["tongtien"].Value) : 0;
            }
            quanly.tong_dt.Text = price.ToString("#,###");
        }
        //Quản lí Bàn
        public bool themBan()
        {
            string tenban = taoban.txt_tenban.Text;
            bool i = dal_quanly.ThemBan(tenban);
            return i;
        }
        public void xoaBan(string maban, string tenban)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa  " + tenban + " này không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.XoaBan(maban);
                    if (i == true)
                    {
                        loadDSNV();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                    break;
                case DialogResult.No:
                    return;
            }
        }
        public void suaBan(string maban, string tenban)
        {
            bool i = dal_quanly.SuaBan(maban, tenban);
            if (i == true)
            {

                MessageBox.Show("Update bàn thành công!");
                loadBan();
            }
            else
            {

                MessageBox.Show("Update bàn thất bại!");
                loadBan();
            }
        }
        public void timBan()
        {

            string timban = quanly.txt_timban.Text;
            quanly.gridViewQLB.DataSource = dal_quanly.timBan(timban);
        }
        //Quản lý sản phẩm
        public void loadSP()
        {
            quanly.gridview_QLSP.DataSource = dal_quanly.LoadSP();
        }
        public void loadDMSP()
        {
           themsp.clb_danhmuc.DataSource = dal_quanly.LoadLoaiSP();
            themsp.clb_danhmuc.DisplayMember = "tenloai";
            themsp.clb_danhmuc.ValueMember = "maloai";
        }
        public bool ThemSP()
        {
            string tensanpham = themsp.txt_tensanpham.Text;
            int soluong = int.Parse(themsp.txt_soluong.Text);
            decimal dongia = decimal.Parse(themsp.txt_dongia.Text);
            string ghichu = themsp.txt_ghichu.Text;
            string hinhanh = themsp.txt_hinhanh.Text;
            string maloai  = themsp.clb_danhmuc.SelectedValue.ToString();
            bool i = dal_quanly.ThemSP(tensanpham, soluong, dongia, ghichu, hinhanh,maloai);
            return i;

        }
        /* public bool SuaSP()
         {
             string tensanpham = themsp.txt_tensanpham.Text;
             int soluong = int.Parse(themsp.txt_soluong.Text);
             decimal dongia = decimal.Parse(themsp.txt_dongia.Text);
             string ghichu = themsp.txt_ghichu.Text;
             string hinhanh = themsp.txt_hinhanh.Text;
             string maloai = themsp.clb_danhmuc.SelectedValue.ToString();
             bool i = dal_quanly.SuaSP(masanpham,tensanpham, soluong, dongia, ghichu, hinhanh, maloai);
             return i;

         }*/
        /*public void getSANPHAM(string masanpham)
        {
            foreach (DataRow row in dal_quanly.getSanpham(dal_quanly.masanpham).Rows)
            {

                string hovaten = row["hovaten"].ToString();
                string diachi = row["diachi"].ToString();
                string sodienthoai = row["sodienthoai"].ToString();
                string mail = row["mail"].ToString();

                thongtin.txt_tennhanvien.Text = hovaten;
                thongtin.txt_diachi.Text = diachi;
                thongtin.txt_sodienthoai.Text = sodienthoai;
                thongtin.txt_email.Text = mail;
            }
        }*/
        public void xoaSP(string masanpham, string tensanpham)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa  " + tensanpham + " này không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.XoaSP(masanpham);
                    if (i == true)
                    {
                        loadSP();
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                    break;
                case DialogResult.No:
                    return;
            }
        }
        public void timSP()
        {

            string timSP = quanly.txt_timkiemSP.Text;
            quanly.gridview_QLSP.DataSource = dal_quanly.timSP(timSP);
        }
    }

}

