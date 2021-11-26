using caffe.DAL;
using caffe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.BLL
{
    class BLL_CHITIETKHUYENMAI
    {
        private frm_ChiTietKhuyenMai ct_khuyenmai;
        frm_ThemSanPhamKM themspkm;

        DAL_CHITIETKHUYENMAI dal_ctkhuyenmai = new DAL_CHITIETKHUYENMAI();
        public BLL_CHITIETKHUYENMAI(frm_ChiTietKhuyenMai frm_ChiTietKhuyenMai)
        {
            ct_khuyenmai = frm_ChiTietKhuyenMai;
        }
        public BLL_CHITIETKHUYENMAI(frm_ThemSanPhamKM h)
        {
            themspkm = h;

        }
        public void chitiet_khuyenmai(string makhuyenmai)
        {
            ct_khuyenmai.grd_chitietKM.DataSource = dal_ctkhuyenmai.CT_KhuyenMai(ct_khuyenmai.makm);
           // ct_khuyenmai.grd_chitietKM.Columns[7]..ToString("#,###");
            
        }
        public void load_ctkm()
        {
            ct_khuyenmai.lb_makm.Text = ct_khuyenmai.makm;
            ct_khuyenmai.lb_tenkm.Text = ct_khuyenmai.tenkm;
            ct_khuyenmai.lb_ngaybatdau.Text = ct_khuyenmai.ngaybatdau;
            ct_khuyenmai.lb_ngayketthuc.Text = ct_khuyenmai.ngayketthuc;
            ct_khuyenmai.lb_trangthai.Text = ct_khuyenmai.trangthai;            
        }
        public void suaSPKM(string makm, string tensp, string masp, int soluong, float tyle)
        {

            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn sửa  " + tensp + " này không?",
                      "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_ctkhuyenmai.SuaSPKM(makm,masp,soluong,tyle);
                    if (i == true)
                    {
                        chitiet_khuyenmai(makm);
                        MessageBox.Show("Sửa  thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Sửa thất bại!");
                        chitiet_khuyenmai(makm);
                    }
                    break;
                case DialogResult.No:
                    return;
            }

        }
        public void xoaspKM(string makm, string masp,string tensp)
        {


            DialogResult dr = MessageBox.Show("Bạn có thật sự muốn xóa  " + tensp + " này không?",
                        "Thông báo!", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:

                    bool i = dal_ctkhuyenmai.xoaSPKM(makm,masp);
                    if (i == true)
                    {
                        chitiet_khuyenmai(makm);
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
        public void load_sp()
        {
            themspkm.clb_tensanpham.DataSource = dal_ctkhuyenmai.LoadSP();
            themspkm.clb_tensanpham.DisplayMember = "tensanpham";
            themspkm.clb_tensanpham.ValueMember = "masanpham";
        }
        public bool themSPKM(string makm)
        {
            string masp = themspkm.clb_tensanpham.SelectedValue.ToString();
            try {
                int soluong = Int32.Parse(themspkm.txt_soluong.Text);
                float tyle = float.Parse(themspkm.txt_tylekhuyenmai.Text);
                bool i = dal_ctkhuyenmai.ThemSPKM(makm, masp, soluong, tyle);
                return i;

            }
            catch{
              return false;
            }
          

        }
    }
}
