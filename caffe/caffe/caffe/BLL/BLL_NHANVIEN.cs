using caffe.GUI;
using Gucaffe.DAL;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caffe.BLL
{
    class BLL_NHANVIEN
    {
        frm_Nhanvien nhanvien;
        DAL_NHANVIEN dal_nhanvien = new DAL_NHANVIEN();
        string Maban;

        public BLL_NHANVIEN(frm_Nhanvien f)
        {
            nhanvien = f;
          
        }
        
        public void laytenTaikhoan()
        {
            foreach (DataRow row in dal_nhanvien.layTenNhanVien(nhanvien.tentaikhoan).Rows)
            {
                nhanvien.taikhoan.Text = row["hovaten"].ToString();
                nhanvien.taikhoan.Name = row["mataikhoan"].ToString();
            }
        
        }

  

        public void loadBan()
        {
            foreach (DataRow row in dal_nhanvien.LoadBan().Rows)
            {
          
                String maban = row["maban"].ToString();
                String tenban = row["tenban"].ToString();
                Boolean trangthai = (Boolean)row["trangthai"];
              
                nhanvien.lb_Tenban.Controls.Add(createBan(maban, tenban,trangthai));
           


            }
        }
      public void reloadBan()
        {
          
            nhanvien.lb_Tenban.Controls.Clear();
            loadBan();

        }

        public void loadLoaiSP()
        {
            foreach (DataRow row in dal_nhanvien.LoadLoaiSP().Rows)
            {
                DevExpress.XtraTab.XtraTabPage page = new DevExpress.XtraTab.XtraTabPage();
                page.Text = row["tenloai"].ToString();
                page.Name = row["maloai"].ToString();
                // flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                nhanvien.thucDon.TabPages.Add(page);
                  FlowLayoutPanel flow = new FlowLayoutPanel();
                   flow.Dock = System.Windows.Forms.DockStyle.Fill;
                foreach (DataRow row2 in dal_nhanvien.LoadMon(page.Name).Rows)
                {

                   // String link = row2["hinhanh"].ToString();
                    String tenmon = row2["tensanpham"].ToString();
                    String masp = row2["masanpham"].ToString();
                    string dongia2 = row2["dongia"].ToString();
                    CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // try with "en-US"
                    string dongia = double.Parse(dongia2).ToString("#,###", cul.NumberFormat);


                    //TẠO MÓN
                    Panel focus = new System.Windows.Forms.Panel();
                    GunaLinePanel gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
                    GunaTileButton gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
                    GunaGradient2Panel gunaGradient2Panel4 = new Guna.UI.WinForms.GunaGradient2Panel();
                    GunaLabel gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
                    focus.SuspendLayout();
                    gunaLinePanel1.SuspendLayout();
                    gunaGradient2Panel4.SuspendLayout();
             
                    // 
                    // focus
                    // 
                    focus.BackColor = System.Drawing.Color.Transparent;
                    focus.Controls.Add(gunaLinePanel1);
                    focus.Location = new System.Drawing.Point(218, 66);
                    focus.Name = masp;
                    focus.Size = new System.Drawing.Size(185, 238);
                    focus.TabIndex = 8;
                    // 
                    // gunaLinePanel1
                    // 
                    gunaLinePanel1.Controls.Add(gunaTileButton1);
                    gunaLinePanel1.Controls.Add(gunaGradient2Panel4);
                    gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
                    gunaLinePanel1.LineBottom = 3;
                    gunaLinePanel1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(112)))), ((int)(((byte)(85)))));
                    gunaLinePanel1.LineLeft = 3;
                    gunaLinePanel1.LineRight = 3;
                    gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
                    gunaLinePanel1.LineTop = 3;
                    gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
                    gunaLinePanel1.Name = "gunaLinePanel1";
                    gunaLinePanel1.Size = new System.Drawing.Size(185, 238);
                    gunaLinePanel1.TabIndex = 8;
                    // 
                    // gunaTileButton1
                    // 
                    gunaTileButton1.AnimationHoverSpeed = 0.07F;
                    gunaTileButton1.AnimationSpeed = 0.03F;
                    gunaTileButton1.BackColor = System.Drawing.Color.Transparent;
                    gunaTileButton1.BaseColor = System.Drawing.Color.Transparent;
                    gunaTileButton1.BorderColor = System.Drawing.Color.Black;
                    gunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
                    gunaTileButton1.FocusedColor = System.Drawing.Color.Empty;
                    gunaTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 11F);
                    gunaTileButton1.ForeColor = System.Drawing.Color.Black;
                    gunaTileButton1.Image = global::caffe.Properties.Resources.cup;
                    gunaTileButton1.ImageSize = new System.Drawing.Size(100, 100);
                    gunaTileButton1.Location = new System.Drawing.Point(12, 59);
                    gunaTileButton1.Name = "gunaTileButton1";
                    // 249, 166, 3
                    // 246,238,226
                    //246,139,45
                    gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
                    gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
                    gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
                    gunaTileButton1.OnHoverImage = null;
                    gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
                    gunaTileButton1.Radius = 10;
                    gunaTileButton1.Size = new System.Drawing.Size(163, 165);
                    gunaTileButton1.TabIndex = 6;
                    gunaTileButton1.Text = tenmon;
                    gunaTileButton1.DoubleClick += (sender, e) => { chonMon(sender, e, masp, tenmon); };
                    // 
                    // gunaGradient2Panel4
                    // 
                    gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
                    gunaGradient2Panel4.Controls.Add(gunaLabel2);
                    gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
                    gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
                    gunaGradient2Panel4.Location = new System.Drawing.Point(12, 13);
                    gunaGradient2Panel4.Name = "gunaGradient2Panel4";
                    gunaGradient2Panel4.Radius = 10;
                    gunaGradient2Panel4.Size = new System.Drawing.Size(93, 40);
                    gunaGradient2Panel4.TabIndex = 7;
                    // 
                    // gunaLabel2
                    // 
                    gunaLabel2.AutoSize = true;
                    gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    gunaLabel2.ForeColor = System.Drawing.Color.White;
                    gunaLabel2.Location = new System.Drawing.Point(14, 5);
                    gunaLabel2.Name = "gunaLabel2";
                    gunaLabel2.Size = new System.Drawing.Size(68, 25);
                    gunaLabel2.TabIndex = 0;
                    gunaLabel2.Text = dongia+"đ";
      
        
                    focus.ResumeLayout(false);
                    gunaLinePanel1.ResumeLayout(false);
                    gunaGradient2Panel4.ResumeLayout(false);
                    gunaGradient2Panel4.PerformLayout();
                       ////END TẠO MÓN//

                    flow.Controls.Add(
                     focus
                        );
                    page.Controls.Add(flow);

                }
            }
        }

        void tinhTongtien()
        {
            decimal price = 0;
            foreach (DataGridViewRow row in nhanvien.gridview_Hoadon.Rows)
            {
                price += row.Cells["thanhtien"] != null ? Convert.ToDecimal(row.Cells["thanhtien"].Value) : 0;
            }
            nhanvien.lb_Tongtien.Text = price.ToString();
        }




        //LOAD HÓA ĐƠN
        void loadHoadon()
        {
            dal_nhanvien.updateGia();
            nhanvien.gridview_Hoadon.DataSource = dal_nhanvien.layBantam(Maban);
        }



        public void chonMon(object sender, System.EventArgs e, String mamon, String tenmon)
        {
            //nhanvien.lb_Masanpham.Text = mamon;
            //nhanvien.lb_Tenmon.Text = tenmon;
            //nhanvien.txt_Soluong.Text = "1";

            if (Maban == "")
            {
                MessageBox.Show("Bạn chưa chọn bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            bool i = dal_nhanvien.themMon(Maban, mamon, tenmon);
            if (i == true)
            {
                loadHoadon();
              tinhTongtien();
                bool a = dal_nhanvien.coKhach(Maban);
                reloadBan();
                
          

            }
            else
            {
                MessageBox.Show("Thêm món thất bại. Hãy thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }


        ///TẠO BÀN
        public GunaTileButton createBan(string maban,string tenban,bool trangthai)
        {
            Guna.UI.WinForms.GunaTileButton ban = new Guna.UI.WinForms.GunaTileButton();
            ban.AnimationHoverSpeed = 0.07F;
            ban.AnimationSpeed = 0.03F;
            if (trangthai == false)
            {
                
                ban.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));

            }
            else
            {
                ban.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));

            }

            ban.BorderColor = System.Drawing.Color.Black;
            ban.DialogResult = System.Windows.Forms.DialogResult.None;
            ban.FocusedColor = System.Drawing.Color.Empty;
            ban.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            ban.ForeColor = System.Drawing.Color.White;
            ban.Image = global::caffe.Properties.Resources.Household_Table_icon;
            ban.ImageSize = new System.Drawing.Size(52, 52);
            ban.Location = new System.Drawing.Point(3, 3);
            ban.Name = maban;
            // 249, 166, 3
            // 246,238,226
            //246,139,45
            ban.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(139)))), ((int)(((byte)(45)))));
            ban.OnHoverBorderColor = System.Drawing.Color.Black;
            ban.OnHoverForeColor = System.Drawing.Color.White;
            ban.OnHoverImage = null;
            ban.OnPressedColor = System.Drawing.Color.Black;
            ban.Radius = 10;
            ban.Size = new System.Drawing.Size(121, 117);
            ban.TabIndex = 0;
            ban.Text = tenban;
            ban.ForeColor = System.Drawing.Color.Black;
            ban.Click += (sender, e) => { btn_ban_Click(sender, e, maban,tenban); };
     //       ban.MouseDown += (sender, e) => { ban_MouseDown(sender, e); };
     
            return ban;
        }
        
        
        private void btn_ban_Click(object sender, EventArgs e, string maban, string tenban)
        {
            Maban = maban;
            nhanvien.tenban.Text = tenban;
            loadHoadon();
            tinhTongtien();

        }


        //Tạo món
        public Panel createMon(string mamon,string tenmon)
        {
            System.Windows.Forms.Panel focus = new System.Windows.Forms.Panel();
      
            Guna.UI.WinForms.GunaTileButton gunaTileButton1 = new Guna.UI.WinForms.GunaTileButton();
            Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel4 = new Guna.UI.WinForms.GunaGradient2Panel();
            Guna.UI.WinForms.GunaLabel gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
   
          
            focus.BackColor = System.Drawing.Color.Transparent;
   
            focus.Location = new System.Drawing.Point(218, 66);
            focus.Name = mamon;
            focus.Size = new System.Drawing.Size(185, 238);
            focus.TabIndex = 8;
       
            gunaTileButton1.AnimationHoverSpeed = 0.07F;
            gunaTileButton1.AnimationSpeed = 0.03F;
            gunaTileButton1.BackColor = System.Drawing.Color.Transparent;
            gunaTileButton1.BaseColor = System.Drawing.Color.Transparent;
            gunaTileButton1.BorderColor = System.Drawing.Color.Black;
            gunaTileButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            gunaTileButton1.FocusedColor = System.Drawing.Color.Empty;
            gunaTileButton1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            gunaTileButton1.ForeColor = System.Drawing.Color.Black;
            gunaTileButton1.Image = global::caffe.Properties.Resources.cup;
            gunaTileButton1.ImageSize = new System.Drawing.Size(100, 100);
            gunaTileButton1.Location = new System.Drawing.Point(12, 59);
            gunaTileButton1.Name = "gunaTileButton1";
            gunaTileButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            gunaTileButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            gunaTileButton1.OnHoverForeColor = System.Drawing.Color.White;
            gunaTileButton1.OnHoverImage = null;
            gunaTileButton1.OnPressedColor = System.Drawing.Color.Black;
            gunaTileButton1.Radius = 10;
            gunaTileButton1.Size = new System.Drawing.Size(163, 165);
            gunaTileButton1.TabIndex = 6;
            gunaTileButton1.Text = tenmon;
            // 
            // gunaGradient2Panel4
            // 
            gunaGradient2Panel4.BackColor = System.Drawing.Color.Transparent;
            gunaGradient2Panel4.Controls.Add(gunaLabel2);
            gunaGradient2Panel4.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(117)))));
            gunaGradient2Panel4.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(203)))), ((int)(((byte)(110)))));
            gunaGradient2Panel4.Location = new System.Drawing.Point(12, 13);
            gunaGradient2Panel4.Name = "gunaGradient2Panel4";
            gunaGradient2Panel4.Radius = 10;
            gunaGradient2Panel4.Size = new System.Drawing.Size(93, 40);
            gunaGradient2Panel4.TabIndex = 7;
            // 
            // gunaLabel2
            // 
            gunaLabel2.AutoSize = true;
            gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gunaLabel2.ForeColor = System.Drawing.Color.White;
            gunaLabel2.Location = new System.Drawing.Point(14, 5);
            gunaLabel2.Name = "gunaLabel2";
            gunaLabel2.Size = new System.Drawing.Size(68, 25);
            gunaLabel2.TabIndex = 0;
            gunaLabel2.Text = "17,000";

            return focus;
        }

        ///THANH TOÁN
        public void thanhToan()
        {
         
            int checkban = dal_nhanvien.checkBantam(Maban);
            if (checkban == 1)
            {
                int total = int.Parse(nhanvien.lb_Tongtien.Text);
                bool i = dal_nhanvien.thanhToan(taoMaHD(Maban), nhanvien.taikhoan.Name, total, Maban);

                loadHoadon();
                tinhTongtien();
                MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                bool a = dal_nhanvien.khongKhach(Maban);
                reloadBan();
            }
            else MessageBox.Show("Chưa có món nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);



        }

        ///TẠO MÃ HÓA ĐƠN 
        public String taoMaHD(string maban)
        {

            string currentDate = DateTime.Now.ToString("MM/dd/yyyy_HH:mm:ss");
            string mahoadon = maban + "_" + currentDate;
            maban.Trim();
            while (mahoadon.IndexOf("  ") != -1)
            {
                mahoadon = mahoadon.Replace(" ", "");
            }
            return mahoadon;
        }
        public void xoaMon()
        {
          
                
          
                string value = nhanvien.gridview_Hoadon.Rows[nhanvien.gridview_Hoadon.CurrentRow.Index].Cells["masanpham"].Value.ToString();
                bool i = dal_nhanvien.xoaMon(value, Maban);

                loadHoadon();
                reloadBan();
          


        }
        //quan ly hoa don
        public void danhsachhoadon()
        {
            string ngaybatdau = nhanvien.ngaybatdau.Value.ToString("dd/MM/yyyy");
            string ngayketthuc = nhanvien.ngayketthuc.Value.ToString("dd/MM/yyyy");
            string manv = "";
            //string manv = "nv03";
            foreach (DataRow row in dal_nhanvien.layTenNhanVien(nhanvien.tentaikhoan).Rows)
            {
                nhanvien.taikhoan.Text = row["hovaten"].ToString();
                manv = row["mataikhoan"].ToString();
            }

            //string ngaybatdau = "20/06/2021";
            //string ngayketthuc = "26/09/2021";
            //string manv = "nv03";
            nhanvien.grd_hoadon.DataSource = dal_nhanvien.DanhSachHoaDon(ngaybatdau, ngayketthuc,manv);
        }
        public void danhsachcthoadon(string mahoadon)
        {           
            nhanvien.grd_cthoadon.DataSource = dal_nhanvien.DanhSachCTHoaDon(mahoadon);
        }
        public int check_ngay(DateTime a, DateTime b)
        {
            if (a < b)
            {
                return 1;
            }
            else
                if (a == b)
            {
                return 2;
            }


            return 0;
        }

    }
  

    //    public void menuClick()
    //{
    //    bool i = 
    //}

}
