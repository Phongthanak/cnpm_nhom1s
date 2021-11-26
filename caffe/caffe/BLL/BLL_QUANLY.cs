using caffe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Gucaffe.DAL;
using Gucaffe.DAL;
using System.Windows.Forms;
using System.Globalization;

namespace caffe.BLL
{
    
    class BLL_QUANLY
    {
        frm_QuanLy quanly;
        frm_TaoBan taoban;        
        frm_TaoTaiKhoan taotaikhoan;
        frm_TaoDM taodm;
        frm_ThemSanPham themsp;
        frm_ThemKhuyenMai themkm;
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
        public BLL_QUANLY(frm_ThemKhuyenMai km)
        {
            themkm = km;
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
                tong_sl();
            }
            else
            { 
           
                thongke_sp_theoTT();
                tinh_tong_tien();
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
        public void tinh_tong_tien()
        {

            decimal price = 0;
            foreach (DataGridViewRow row in quanly.grd_thongke.Rows)
            {
                price += row.Cells["tt"] != null ? Convert.ToDecimal(row.Cells["tt"].Value) : 0;
            }
            quanly.tong_bc.Text = price.ToString("#,###");
        }
        public void tong_sl()
        {
            int sl = 0;
            foreach (DataGridViewRow row in quanly.grd_thongke.Rows)
            {
              
                sl += row.Cells["soluong"] != null ? Convert.ToInt32(row.Cells["soluong"].Value) : 0;

            }
            quanly.tong_bc.Text = sl.ToString("#,###");

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
            int index = quanly.gridview_QLSP.Columns["dongia222"].Index;
            quanly.gridview_QLSP.Columns[index].DefaultCellStyle.Format = "#,###";
            quanly.gridview_QLSP.Columns[index].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");
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
        public void suaSp(string masp,string tensp,int soluong,decimal dongia,string ghichu,string maloai)
        {

            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn sửa  " + tensp + " này không?",
                      "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.suaSP(masp, tensp, soluong, dongia, ghichu, maloai);
                    if (i == true)
                    {
                        loadSP();
                        MessageBox.Show("Sửa  thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                    break;
                case DialogResult.No:
                    return;
            }

        }
       

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
                        MessageBox.Show("Xóa không thành công! Sản phẩm đang được khuyến mãi!");
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
        //quan ly hoa don
        public void danhsachhoadon()
        {
            string ngaybatdau = quanly.ngaybatdauHD.Value.ToString("dd/MM/yyyy");
            string ngayketthuc = quanly.ngayketthucHD.Value.ToString("dd/MM/yyyy");
            string manv = "";            
            quanly.grd_hoadon.DataSource = dal_quanly.DanhSachHoaDon(ngaybatdau, ngayketthuc, manv);
        }
        public void danhsachcthoadon(string mahoadon)
        {
            quanly.grd_cthoadon.DataSource = dal_quanly.DanhSachCTHoaDon(mahoadon);
        }
        public void timHD()
        {

            string timHD = quanly.txt_timHD.Text;
            quanly.grd_hoadon.DataSource = dal_quanly.timHD(timHD);
        }
        public void tinh_tong_tien_HD()
        {

            decimal price = 0;
            foreach (DataGridViewRow row in quanly.grd_hoadon.Rows)
            {
                price += row.Cells["thanhtien_hd"] != null ? Convert.ToDecimal(row.Cells["thanhtien_hd"].Value) : 0;
            }
            quanly.btn_tongtien.Text = price.ToString("#,###");
        }

        //Quản lý khuyến mãi
        public void ds_khuyenmai()
        {

            string tt = trangthai_KM();
            quanly.grd_khuyenmai.DataSource = dal_quanly.DS_khuyenmai(tt);
        }
        public string trangthai_KM()
        {
            if (quanly.rd_tatca.Checked)
            {
                quanly.lb_test_km.Text = "Danh sách tất cả các đợt khuyến mãi";
                return "0";
            }
            else
                if (quanly.rd_chuapdung.Checked)
            {
                quanly.lb_test_km.Text = "Danh sách các đợt khuyến mãi ngừng áp dụng";
                return "3";
            }
            else
                if (quanly.rd_daapdung.Checked)
            {
                quanly.lb_test_km.Text = "Danh sách các đợt khuyến mãi đang áp dụng";
                return "2";
            }
            quanly.lb_test_km.Text = "Danh sách các đợt khuyến mãi chưa áp dụng";
            return "1";
        }
        public void timds_km()
        {

            string text = quanly.txt_timiemKM.Text;
            quanly.grd_khuyenmai.DataSource = dal_quanly.timdsKM(text);
        }
        public void load_trangthai()
        {
            themkm.clb_trangthai.DataSource = dal_quanly.Load_TT();
            themkm.clb_trangthai.DisplayMember = "trangthai";
            themkm.clb_trangthai.ValueMember = "tt";
        }
        public bool ThemKM()
        {
            string tenkhuyenmai = themkm.txt_tenkm.Text;
            string ngaybatdau = themkm.ngaybatdau.Value.ToString("yyyy-MM-dd");
            string ngayketthuc = themkm.ngayketthuc.Value.ToString("yyyy-MM-dd");
            string trangthai = "3";
            bool i = dal_quanly.ThemKM(tenkhuyenmai, ngaybatdau, ngayketthuc, trangthai);
            return i;

        }
        public void xoakm(string makhuyenmai, string tenkhuyenmai)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa  " + tenkhuyenmai + " này không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.XoaKM(makhuyenmai);
                    if (i == true)
                    {
                        ds_khuyenmai();
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
        public void suakm(string makhuyenmai, string tenkhuyenmai)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn sửa trạng thái  của " + tenkhuyenmai + " này không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_quanly.SuaTTKM(makhuyenmai);
                    if (i == true)
                    {
                        ds_khuyenmai();
                        MessageBox.Show("Sửa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                    }
                    break;
                case DialogResult.No:
                    return;
            }
        }


    }

}

