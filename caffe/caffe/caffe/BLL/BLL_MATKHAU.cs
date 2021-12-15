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
    class BLL_MATKHAU
    {
        private frm_MatKhau matkhau;
        DAL__THONGTINNHANVIEN dal_thongtin = new DAL__THONGTINNHANVIEN();
        public BLL_MATKHAU(frm_MatKhau frm_MatKhau)
        {
            matkhau = frm_MatKhau;
        }
        public void doipass()
        {
          
                bool check = dal_thongtin.checkMatkhau(matkhau.tentaikhoan, matkhau.txt_matkhau.Text);
                if (check == true)
                {
                    bool i = dal_thongtin.updateMatkhau(matkhau.tentaikhoan, matkhau.txt_matkhaumoi.Text);
                     MessageBox.Show("Update Mật khẩu thành công");
                      matkhau.Close();
                
                    
                }
                  else  MessageBox.Show("Sai mật khẩu cũ"); 




        }
    }
}
