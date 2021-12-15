using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caffe.BLL;

namespace caffe.GUI
{
    public partial class frm_TaoTaiKhoan : Form
    {


        BLL_QUANLY bll_quanly;
        private frm_QuanLy mainForm = new frm_QuanLy();
        public frm_TaoTaiKhoan(frm_QuanLy form)
        {
            InitializeComponent();
            bll_quanly = new BLL_QUANLY(this);
            mainForm = form;
        }
       

        private void btn_ok_Click(object sender, EventArgs e)
        {
            bool check = bll_quanly.taoTK();
            if (check == true)
            {
                MessageBox.Show("Thêm nhân viên thành công...");
                mainForm.reloadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại...");
            }
        }

        private void frm_TaoTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
