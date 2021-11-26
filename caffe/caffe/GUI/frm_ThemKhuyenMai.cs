using caffe.BLL;
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
    public partial class frm_ThemKhuyenMai : Form
    {
        private frm_QuanLy mainForm = new frm_QuanLy();
        BLL_QUANLY bll_quanly;
     
        public frm_ThemKhuyenMai(frm_QuanLy form)
        {
            InitializeComponent();
            mainForm = form;
            bll_quanly = new BLL_QUANLY(this);
        }

        private void frm_ThemKhuyenMai_Load(object sender, EventArgs e)
        {
            //bll_quanly.load_trangthai();
            lb_loi.Visible = false;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            int i = bll_quanly.check_ngay(ngaybatdau.Value.Date, ngayketthuc.Value.Date);

            
            if (i == 1 || i == 2)
            {
                bool check = bll_quanly.ThemKM();
                if (check == true)
                {

                    MessageBox.Show("Thêm khuyến mãi thành công!");
                    mainForm.reloadData();
                    this.Close();
                }
                else
                {

                    lb_loi.Visible = true;
                    //lb_loi.Text = "Bạn đã nhập trùng tên hoặc đã bỏ trống tên khuyến mãi";

                }

            }

            else
            {
                lb_loi.Visible = true;
                lb_loi.Text = "Phải chọn ngày bắt đầu bé hơn ngày kết thúc";
            }

        }

        private void lb_loi_Click(object sender, EventArgs e)
        {

        }
    }
}
