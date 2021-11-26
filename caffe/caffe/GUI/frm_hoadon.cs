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
    public partial class frm_hoadon : Form
    {
        BLL_HOADON bll_hoadon;
        public string tenban;
        public string tennhanvien;

        BLL_NHANVIEN bll_nhanvien;
        frm_Nhanvien nhanvien;
       
        public frm_hoadon(frm_Nhanvien f)
        {
            InitializeComponent();
            bll_hoadon = new BLL_HOADON(this);
            bll_nhanvien = new BLL_NHANVIEN(this);
            this.nhanvien = f;
            this.tenban = nhanvien.tenban.Text;
            this.tennhanvien = nhanvien.taikhoan.Text;
 
        }
       
        private void btn_dongy_Click(object sender, EventArgs e)
        {

        }


      

        private void frm_hoadon_Load(object sender, EventArgs e)
        {
            bll_hoadon.ct_hoadon(tenban);
            bll_hoadon.load_hoadon();
        }

      

        private void btn_huy_Click_2(object sender, EventArgs e)
        {

            this.Close();
        
        }

        

        public void btn_dongy_Click_1(object sender, EventArgs e)
        {
            nhanvien.thanhtoan();
            this.Close();
        }


        Bitmap memoryImage;
        private void CaptureScreen()
        {
            Graphics myGraphics = PanelHOADON.CreateGraphics();
            Size s = PanelHOADON.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(PanelHOADON.Location.X, PanelHOADON.Location.Y, 0, 0, s);
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

   
        private void btn_inhd_Click_1(object sender, EventArgs e)
        {
            
            CaptureScreen();
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
