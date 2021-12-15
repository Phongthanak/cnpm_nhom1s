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
    public partial class frm_QuanLy : Form
    {

        BLL_QUANLY bll_quanly;
        public frm_QuanLy()
        {
            InitializeComponent();
            bll_quanly = new BLL_QUANLY(this);
        }

        private bool mouseDown;
        private Point lastLocation;

        private void guna2CustomGradientPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;

        }

        private void guna2CustomGradientPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void guna2CustomGradientPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void frm_QuanLy_Load(object sender, EventArgs e)
        {
            bll_quanly.loadDSNV();
            bll_quanly.loadBan();
            bll_quanly.loadLoaiSP();
            bll_quanly.loadSP();
        }


        public void reloadData()
        {
            bll_quanly.loadDSNV();
            bll_quanly.loadLoaiSP();
            bll_quanly.loadBan();
            bll_quanly.loadSP();
            
        }
 

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            frm_TaoTaiKhoan f = new frm_TaoTaiKhoan(this);
            f.Show();
     
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap f = new frm_DangNhap();
            f.ShowDialog();
            this.Close();
        }

        private void gridview_QLNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                string user = gridview_QLNV.Rows[e.RowIndex].Cells[2].Value.ToString();

                string command = gridview_QLNV.Columns[e.ColumnIndex].Name;
                if (command == "xoa")
                {
                    bll_quanly.xoaTK(user);

                }
                if (command == "khoa")
                {
                    bll_quanly.khoaTK(user);

                }
            }
        }

        private void txt_timNV_TextChanged(object sender, EventArgs e)
        {
            bll_quanly.timNV();
        }

        

private void gridview_QLNV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void btn_taoban_Click(object sender, EventArgs e)
        {
            frm_TaoBan f = new frm_TaoBan(this);
            f.Show();
        }

        private void grd_danhmuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string madm = grd_danhmuc.Rows[e.RowIndex].Cells[3].Value.ToString();
                string tendm = grd_danhmuc.Rows[e.RowIndex].Cells[4].Value.ToString();

                string command = grd_danhmuc.Columns[e.ColumnIndex].Name;
                if (command == "suaDM")
                {
                    //bll_quanly.suaDM(madm,tendm);
                   // MessageBox.Show(madm + " " + tendm+" "+ grd_danhmuc.Rows[e.RowIndex].Cells[4].ToString());
                    grd_danhmuc.Rows[e.RowIndex].Cells[4].ReadOnly = false;
                   
                    // MessageBox.Show("Thành công");

                }
                if (command == "luuDM")
                {

                    // bll_quanly.suaDM(madm, tendm);
                    
                  // MessageBox.Show(madm + " " + tendm);
                    bll_quanly.suaDM(madm, tendm);
                    grd_danhmuc.Rows[e.RowIndex].Cells[4].ReadOnly = true;
                   

                }
                if (command == "xoaDM")
                {
                    bll_quanly.xoaDM(madm, tendm);
                    bll_quanly.loadLoaiSP();

                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            frm_TaoDM f = new frm_TaoDM(this);
            f.Show();
           
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            int i = bll_quanly.check_ngay(ngaybatdau.Value.Date,ngayketthuc.Value.Date);
           
            
            if (i == 1)
            {
                bll_quanly.thongkeSP();
                lb_test.Text = "Bảng thống kê sản phẩm bán chạy từ ngày : "+ngaybatdau.Text+" đến : "+ngayketthuc.Text;
            }
            else
            if (i == 2)
            {
                bll_quanly.thongkeSP();
                lb_test.Text = "Bảng thống kê sản phẩm bán chạy ngày : " + ngaybatdau.Text;          }
            else
            {
                lb_test.Text = "Phải chọn ngày bắt đầu bé hơn hoặc bằng ngày kết thúc";

            }    
            
        }

        private void btn_thongkeDT_Click(object sender, EventArgs e)
        {

            int i = bll_quanly.check_ngay(ngaybatdau_DT.Value.Date, ngayketthuc_DT.Value.Date);


            if (i == 1)
            {
                bll_quanly.thongke_DT_theoTT();
                lb_thongbao.Text = "Bảng thống kê doanh thu từ ngày : " + ngaybatdau.Text + " đến : " + ngayketthuc.Text;
                bll_quanly.tinh_tong_tien_DT();
            }
            else
            if (i == 2)
            {
                bll_quanly.thongke_DT_theoTT();
                lb_thongbao.Text = "Bảng thống kê doanh thu ngày : " + ngaybatdau.Text;
                bll_quanly.tinh_tong_tien_DT();
            }
            else
            {
                lb_thongbao.Text = "Phải chọn ngày bắt đầu bé hơn ngày kết thúc";
            }
        }

       

        private void tong_dt_Click(object sender, EventArgs e)
        {
        }

       

        private void txt_timban_TextChanged(object sender, EventArgs e)
        {
            bll_quanly.timBan();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            bll_quanly.timDM();
        }

        private void btn_themSP_Click(object sender, EventArgs e)
        {
            frm_ThemSanPham f = new frm_ThemSanPham(this);
            f.Show();
        }
       

        private void gridview_QLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string masanpham = gridview_QLSP.Rows[e.RowIndex].Cells[3].Value.ToString();
                string tensanpham = gridview_QLSP.Rows[e.RowIndex].Cells[4].Value.ToString();

                string command = gridview_QLSP.Columns[e.ColumnIndex].Name;
                /*if (command == "sua2")
                {
                    bll_quanly.suaBan(maban, tenban);
                    *//*MessageBox.Show(maban + " " + tenban + " "+ gridViewQLB.Rows[e.RowIndex].Cells[4].ToString());*/
                /*gridViewQLB.Rows[e.RowIndex].Cells[4].ReadOnly = false;*/

                /* MessageBox.Show("Thành công");*//*

            }*/
                /*if (command == "luuDM")
                {

                    // bll_quanly.suaDM(madm, tendm);

                    // MessageBox.Show(madm + " " + tendm);
                    bll_quanly.suaDM(madm, tendm);
                    grd_danhmuc.Rows[e.RowIndex].Cells[4].ReadOnly = true;


                }*/
                if (command == "xoaSP")
                {
                    bll_quanly.xoaSP(masanpham, tensanpham);
                    bll_quanly.loadSP();


                }
            }
        }

        private void txt_timkiemSP_TextChanged(object sender, EventArgs e)
        {
            bll_quanly.timSP();
        }
    }
  }

