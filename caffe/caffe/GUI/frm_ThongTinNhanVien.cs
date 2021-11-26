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
    public partial class frm_ThongTinNhanVien : DevExpress.XtraEditors.XtraForm
    {
        BLL_THONGTINNHANVIEN bll_thongtin;
        public string tentaikhoan;
        //public string tennhanvien;
        public frm_ThongTinNhanVien()
        {
            InitializeComponent();
            bll_thongtin = new BLL_THONGTINNHANVIEN(this);
        }
        public frm_ThongTinNhanVien(string tentaikhoan) : this()
        {
            this.tentaikhoan = tentaikhoan;
         //   this.tennhanvien = tennhanvien;
        }

        private void frm_ThongTinNhanVien_Load(object sender, EventArgs e)
        {
            bll_thongtin.getThongtin();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txt_tennhanvien.Text != "" && txt_tennhanvien.Text != "" && txt_diachi.Text != "" && txt_sodienthoai.Text != "" && txt_email.Text != "")
            {
                DialogResult dr = MessageBox.Show("Bạn đồng ý thay đổi chứ?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    bll_thongtin.suaThongTin();
                }
            }
            else
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
            }
            
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            string tennhanvien = txt_tennhanvien.Text;
           frm_MatKhau f = new frm_MatKhau(tentaikhoan,tennhanvien);
            f.Show();
        }
    }
}