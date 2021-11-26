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
    public partial class frm_ThemSanPhamKM : Form
    {
        private frm_ChiTietKhuyenMai mainForm = new frm_ChiTietKhuyenMai();
        BLL_CHITIETKHUYENMAI bll_ctkhuyenmai;
        string makm,tenkm;
        public frm_ThemSanPhamKM(frm_ChiTietKhuyenMai form,string tenkm,string makhuyenmai)
        {
            InitializeComponent();
            mainForm = form;
            this.tenkm = tenkm;
            this.makm = makhuyenmai;
            bll_ctkhuyenmai = new BLL_CHITIETKHUYENMAI(this);
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
           
            bool check = bll_ctkhuyenmai.themSPKM(makm);
            if (check == true)
            {
                lb_loi.Visible = true;
                lb_loi.Text = "Đã thêm sản phẩm : "+clb_tensanpham.Text+" vào đợt khuyến mãi" ;
                lb_loi.Visible = true;
                //MessageBox.Show("Thêm danh mục thành công...");
                mainForm.reloadData();

            }
            else
            {
                lb_loi.Visible = false;
                lb_loi.Visible = true;
            }
        }

        private void txt_soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;

            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;

            }
        }

        private void txt_tylekhuyenmai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tylekhuyenmai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                 (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }

        private void frm_ThemSanPhamKM_Load(object sender, EventArgs e)
        {
            bll_ctkhuyenmai.load_sp();
            lb_tenkm.Text = tenkm;
        }
    }
}
