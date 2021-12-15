using caffe.DAL;
using caffe.GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.BLL
{
    class BLL_THONGTINNHANVIEN
    {
        private frm_ThongTinNhanVien thongtin;
   
       DAL__THONGTINNHANVIEN dal_thongtin = new DAL__THONGTINNHANVIEN();
        public BLL_THONGTINNHANVIEN(frm_ThongTinNhanVien frm_ThongTinNhanVien)
        {
            thongtin = frm_ThongTinNhanVien;
        }
        public void getThongtin()
        {
            foreach (DataRow row in dal_thongtin.getThongtin(thongtin.tentaikhoan).Rows)
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
        }
        public void suaThongTin()
        {
            bool i = dal_thongtin.updateThongtin(thongtin.tentaikhoan, thongtin.txt_diachi.Text, thongtin.txt_sodienthoai.Text, thongtin.txt_email.Text);
            if (i == true)
            {
                MessageBox.Show("Update thông tin thành công");
            }
            else
            {
                MessageBox.Show("Update thông tin thất bại");

            }
        }
   
    }
}
