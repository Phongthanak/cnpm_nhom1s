using caffe.DAL;
using caffe.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.BLL
{
    class BLL_HOADON
    {
        private frm_hoadon hoadon;

        DAL_HOADON dal_hoadon = new DAL_HOADON();
        public BLL_HOADON(frm_hoadon frm_hoadon)
        {
            hoadon = frm_hoadon;
        }
        public void ct_hoadon(string tenban)
        {
            hoadon.grd_chitiethd.DataSource = dal_hoadon.CT_HoaDon(hoadon.tenban);
        }
        public void load_hoadon()
        {
            hoadon.lb_tenban.Text = hoadon.tenban;
            hoadon.lb_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            hoadon.lb_nhanvien.Text = hoadon.tennhanvien;
            decimal price = 0;
            int sl = 0;
            foreach (DataGridViewRow row in hoadon.grd_chitiethd.Rows)
            {
                price += row.Cells["thanhtien"] != null ? Convert.ToDecimal(row.Cells["thanhtien"].Value) : 0;
                sl += row.Cells["sl"] != null ? Convert.ToInt32(row.Cells["sl"].Value) : 0;
            }
            hoadon.lb_soluong.Text = sl.ToString();
            hoadon.lb_tongtien.Text = price.ToString("#,###");
        }
    }
}
