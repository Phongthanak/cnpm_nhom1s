using caffe.GUI;
using Gucaffe.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.BLL
{
    class BLL_DANGNHAP
    {
         frm_DangNhap dangnhap;
        DAL_DANGNHAP dal_nhannhap = new DAL_DANGNHAP();

        public BLL_DANGNHAP(frm_DangNhap f)
        {
            dangnhap = f;
        }


        public void dangNhap() 
        {

            if (dangnhap.txt_taikhoan.Text == "" && dangnhap.txt_matkhau.Text == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không dược để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else
            {
               
                if (dangnhap.rd_nhanvien.Checked)
                {
                    int i = dal_nhannhap.DangNhapNhanvien(dangnhap.txt_taikhoan.Text, dangnhap.txt_matkhau.Text);
                    if (i == 1)
                    {

                        //bool check = dal_nhannhap.checkTrangthai(dangnhap.txt_taikhoan.Text);
                        //if (check == true)
                        //{
                            dangnhap.Hide();
                            frm_Nhanvien f = new frm_Nhanvien(dangnhap.txt_taikhoan.Text);
                            f.ShowDialog();
                            dangnhap.Close();
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Tài khoản của bạn đã bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                        //}



                    }
                    else
                    {
                    
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng hoặc bạn đã chọn nhầm loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else if (dangnhap.rd_quanly.Checked)
                {
                    int i = dal_nhannhap.DangNhapQuanly(dangnhap.txt_taikhoan.Text, dangnhap.txt_matkhau.Text);
                    if (i == 1)
                    {
                        dangnhap.Hide();
                        frm_QuanLy f = new frm_QuanLy();
                        f.ShowDialog();
                        dangnhap.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng hoặc bạn đã chọn nhầm loại tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn loại tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);

                }
            }
        }
    }
}
