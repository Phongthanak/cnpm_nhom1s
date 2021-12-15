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
    public partial class frm_TaoDM : Form
    {
        private frm_QuanLy mainForm = new frm_QuanLy();
        BLL_QUANLY bll_quanly;
        public frm_TaoDM(frm_QuanLy form)
        {
            InitializeComponent();
            mainForm = form;
            bll_quanly = new BLL_QUANLY(this);
        }

        private void frm_TaoDM_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            
        }

            private void btn_ok_Click(object sender, EventArgs e)
        {
            bool check = bll_quanly.themDM();
            if (check == true)
            {
                lbl_checkTenDM.Visible = true;
                lbl_loitendm.Text = "Đã thêm danh mục : " + txt_tendm.Text;
                lbl_loitendm.Visible = true;
                //MessageBox.Show("Thêm danh mục thành công...");
                mainForm.reloadData();
               
            }
            else
            {
                lbl_checkTenDM.Visible = false;
                lbl_loitendm.Visible = true;
            }
        }

        private void txt_tendm_TextChanged(object sender, EventArgs e)
        {
                lbl_loitendm.Visible = false;
                 lbl_checkTenDM.Visible = false;

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
