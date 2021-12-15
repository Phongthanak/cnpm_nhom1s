using caffe.BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.GUI
{
    public partial class frm_Nhanvien : DevExpress.XtraEditors.XtraForm
    {
        BLL_NHANVIEN bll_nhanvien;
        public string tentaikhoan;
        public frm_Nhanvien()
        {
            InitializeComponent();
            bll_nhanvien = new BLL_NHANVIEN(this);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public frm_Nhanvien(string username) : this()
        {
            tentaikhoan = username;
        }



        private void frm_Nhanvien_Load(object sender, EventArgs e)
        {
            bll_nhanvien.loadBan();
            bll_nhanvien.loadLoaiSP();
            bll_nhanvien.laytenTaikhoan();
            bll_nhanvien.danhsachhoadon();

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thanhtoan_Click(object sender, EventArgs e)
        {
            bll_nhanvien.thanhToan();


        }


        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_DangNhap f = new frm_DangNhap();
            f.ShowDialog();
            this.Close();
        }

        private bool mouseDown;
        private Point lastLocation;
        private void panelContainer_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelContainer_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelContainer_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void gridview_Hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn chắc chắn xóa món chứ?",
                      "Mood Test", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    bll_nhanvien.xoaMon();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void taikhoan_Click(object sender, EventArgs e)
        {
            frm_ThongTinNhanVien f = new frm_ThongTinNhanVien(tentaikhoan);
            f.Show();
        }

        private void btn_Thanhtoan_MouseHover(object sender, EventArgs e)
        {

        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {

            int i = bll_nhanvien.check_ngay(ngaybatdau.Value.Date, ngayketthuc.Value.Date);


            if (i == 1)
            {
                bll_nhanvien.danhsachhoadon();
                lb_test.Text = "Bảng thống kê hóa đơn đã bán từ ngày : " + ngaybatdau.Value.ToString("dd/MM/yyyy") + " đến : " + ngayketthuc.Value.ToString("dd/MM/yyyy"); ;
            }
            else
            if (i == 2)
            {
                bll_nhanvien.danhsachhoadon();
                lb_test.Text = "Bảng thống kê hóa đơn đã bán ngày : " + ngaybatdau.Text;
            }
            else
            {
                lb_test.Text = "Phải chọn ngày bắt đầu bé hơn hoặc bằng ngày kết thúc";

            }
        }

        private void grd_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string mahoadon = grd_hoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
                //string mahoadon = "B019_09/24/2021_06:33:48";
                string command = grd_hoadon.Columns[e.ColumnIndex].Name;
                if (command == "chitiet")
                {
                    bll_nhanvien.danhsachcthoadon(mahoadon);

                }
            }
        }

        private void grd_hoadon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string mahoadon = grd_hoadon.Rows[e.RowIndex].Cells[1].Value.ToString();
                //string mahoadon = "B019_09/24/2021_06:33:48";
                string command = grd_hoadon.Columns[e.ColumnIndex].Name;
                if (command == "chitiet")
                {
                    bll_nhanvien.danhsachcthoadon(mahoadon);

                }
            }
        }
    }
}