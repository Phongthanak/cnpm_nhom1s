using caffe.BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.GUI
{
    public partial class frm_MatKhau : DevExpress.XtraEditors.XtraForm
    {
        BLL_MATKHAU bll_matkhau;
   
       public string tennhanvien;
       public string tentaikhoan;

        public frm_MatKhau()
        {
            InitializeComponent();
            bll_matkhau = new BLL_MATKHAU(this);
        }

        public frm_MatKhau(string tentaikhoan, string tennhanvien) : this()
        {
            this.tentaikhoan = tentaikhoan;
            this.tennhanvien = tennhanvien;
        }

        //public frm_MatKhau(string tentaikhoan, string tennhanvien)
        //{
        //    username = tentaikhoan;
        //    tennhanvien = tennhanvien;
        //}

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            if(txt_matkhau.Text == "" && txt_matkhaumoi.Text == "" && txt_xacnhanmatkhaumoi.Text == "")
            {
                MessageBox.Show("Các trường không được để trống!");
            }
            else
            {
                if (txt_matkhaumoi.Text == txt_xacnhanmatkhaumoi.Text)
                {
                    
                    DialogResult dr = MessageBox.Show("Bạn đồng ý thay đổi mật khẩu chứ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Cancel)
                    {
                        return;
                    }
                    else if (dr == DialogResult.Yes)
                    {
                        bll_matkhau.doipass();
                    }
                }
                else MessageBox.Show("Mật khẩu không trùng với xác nhận mật khẩu");
            }
        }

        private void frm_MatKhau_Load(object sender, EventArgs e)
        {
            lb_tennhanvien.Text = tennhanvien;
        }
    }
}