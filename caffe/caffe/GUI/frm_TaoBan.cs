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
    public partial class frm_TaoBan : Form
    {

        private frm_QuanLy mainForm = new frm_QuanLy();
        BLL_QUANLY bll_quanly;
        public frm_TaoBan(frm_QuanLy form)
        {
            InitializeComponent();
            mainForm = form;
            bll_quanly = new BLL_QUANLY(this);
        }


        private void txt_tenban_TextChanged(object sender, EventArgs e)
        {
            //bll_quanly.checkTenBan();
            lbl_loitenban.Visible = false;
            lbl_checkTenban.Visible = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
           
            bool check = bll_quanly.themBan();
            if (check == true)
            {
                lbl_checkTenban.Visible = true;
                lbl_loitenban.Text = "Đã thêm Bàn : " + txt_tenban.Text;
                lbl_loitenban.Visible = true;
                //MessageBox.Show("Thêm danh mục thành công...");
                mainForm.reloadData();

            }
            else
            {
                lbl_checkTenban.Visible = false;
                lbl_loitenban.Visible = true;
            }
        }

        private void frm_TaoBan_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
