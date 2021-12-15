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
    public partial class frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        BLL_DANGNHAP bll_dangnhap;
        private bool mouseDown;
        private Point lastLocation;
        private string tentaikhoan;

        public frm_DangNhap()
        {
            InitializeComponent();
            bll_dangnhap = new BLL_DANGNHAP(this);
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

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
       bll_dangnhap.dangNhap();
         
        }

        private void txt_taikhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                  bll_dangnhap.dangNhap();
           
            } 
        }

        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              bll_dangnhap.dangNhap();
              
            }
        }

        private void gunaGradient2Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void gunaGradient2Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void gunaGradient2Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}