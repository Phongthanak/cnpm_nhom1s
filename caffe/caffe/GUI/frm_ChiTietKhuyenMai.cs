using caffe.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.GUI
{
    public partial class frm_ChiTietKhuyenMai : Form
    {
        public string makm, tenkm, ngaybatdau, ngayketthuc, trangthai;
        BLL_CHITIETKHUYENMAI bll_chitietkhuyenmai;
       

        private void btn_themspkhuyenmai_Click(object sender, EventArgs e)
        {

            string tenkm = lb_tenkm.Text;
            frm_ThemSanPhamKM f = new frm_ThemSanPhamKM(this,tenkm,makm);
            f.Show();
        }

        public frm_ChiTietKhuyenMai()
        {
            InitializeComponent();
            bll_chitietkhuyenmai = new BLL_CHITIETKHUYENMAI(this);
        }
        public frm_ChiTietKhuyenMai(string makm, string tenkm, string ngaybatdau, string ngayketthuc, string trangthai) : this()
        {
            this.makm = makm;
            this.tenkm = tenkm;
            this.ngaybatdau = ngaybatdau;
            this.ngayketthuc = ngayketthuc;
            this.trangthai = trangthai;


        }
        public void reloadData()
        {
            bll_chitietkhuyenmai.chitiet_khuyenmai(makm);

        }

        private void grd_chitietKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string makhuyenmai = grd_chitietKM.Rows[e.RowIndex].Cells[2].Value.ToString();
            
                string masp = grd_chitietKM.Rows[e.RowIndex].Cells[3].Value.ToString();
                string tensp = grd_chitietKM.Rows[e.RowIndex].Cells[4].Value.ToString();
                int soluong = Int32.Parse(grd_chitietKM.Rows[e.RowIndex].Cells[6].Value.ToString());
                float tyle = float.Parse(grd_chitietKM.Rows[e.RowIndex].Cells[5].Value.ToString());

                string command = grd_chitietKM.Columns[e.ColumnIndex].Name;
                if (command == "luuspkm")
                {
                  bll_chitietkhuyenmai.suaSPKM(makhuyenmai, tensp, masp, soluong, tyle);


                }
                if (command == "xoaspkm")
                {
                    bll_chitietkhuyenmai.xoaspKM(makhuyenmai,masp,tensp);


                }
            }
        }

           
            private void frm_ChiTietKhuyenMai_Load(object sender, EventArgs e)
            {
                bll_chitietkhuyenmai.chitiet_khuyenmai(makm);
        
                bll_chitietkhuyenmai.load_ctkm();
            int index = grd_chitietKM.Columns["thanhtien"].Index;
            grd_chitietKM.Columns[index].DefaultCellStyle.Format = "#,###";
            grd_chitietKM.Columns[index].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");


        }
        }
    }

