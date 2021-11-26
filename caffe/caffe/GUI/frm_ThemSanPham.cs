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
    public partial class frm_ThemSanPham : Form
    {
        BLL_QUANLY bll_quanly;
        private frm_QuanLy mainForm = new frm_QuanLy();
        public frm_ThemSanPham(frm_QuanLy form)
        {
            InitializeComponent();
            bll_quanly = new BLL_QUANLY(this);
            mainForm = form;
        }

        

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemSanPham));
            this.btn_huy = new Guna.UI.WinForms.GunaButton();
            this.btn_dongy = new Guna.UI.WinForms.GunaButton();
            this.txt_soluong = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_dongia = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_ghichu = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tensanpham = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clb_danhmuc = new Guna.UI.WinForms.GunaComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_hinhanh = new Guna.UI.WinForms.GunaLineTextBox();
            this.lb_loi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.AnimationHoverSpeed = 0.07F;
            this.btn_huy.AnimationSpeed = 0.03F;
            this.btn_huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_huy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_huy.BorderColor = System.Drawing.Color.Black;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_huy.Location = new System.Drawing.Point(266, 469);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Radius = 10;
            this.btn_huy.Size = new System.Drawing.Size(160, 42);
            this.btn_huy.TabIndex = 27;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // btn_dongy
            // 
            this.btn_dongy.AnimationHoverSpeed = 0.07F;
            this.btn_dongy.AnimationSpeed = 0.03F;
            this.btn_dongy.BackColor = System.Drawing.Color.Transparent;
            this.btn_dongy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_dongy.BorderColor = System.Drawing.Color.Black;
            this.btn_dongy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dongy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dongy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dongy.ForeColor = System.Drawing.Color.White;
            this.btn_dongy.Image = ((System.Drawing.Image)(resources.GetObject("btn_dongy.Image")));
            this.btn_dongy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dongy.Location = new System.Drawing.Point(72, 469);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dongy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dongy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dongy.OnHoverImage = null;
            this.btn_dongy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dongy.Radius = 10;
            this.btn_dongy.Size = new System.Drawing.Size(160, 42);
            this.btn_dongy.TabIndex = 26;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_soluong.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_soluong.Location = new System.Drawing.Point(179, 185);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Padding = new System.Windows.Forms.Padding(10);
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.Size = new System.Drawing.Size(271, 46);
            this.txt_soluong.TabIndex = 25;
            this.txt_soluong.WordWrap = false;
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // txt_dongia
            // 
            this.txt_dongia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_dongia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dongia.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_dongia.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dongia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_dongia.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_dongia.Location = new System.Drawing.Point(179, 237);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Padding = new System.Windows.Forms.Padding(10);
            this.txt_dongia.PasswordChar = '\0';
            this.txt_dongia.SelectedText = "";
            this.txt_dongia.Size = new System.Drawing.Size(271, 46);
            this.txt_dongia.TabIndex = 24;
            this.txt_dongia.WordWrap = false;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_ghichu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ghichu.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_ghichu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ghichu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_ghichu.Location = new System.Drawing.Point(179, 289);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Padding = new System.Windows.Forms.Padding(10);
            this.txt_ghichu.PasswordChar = '\0';
            this.txt_ghichu.SelectedText = "";
            this.txt_ghichu.Size = new System.Drawing.Size(271, 46);
            this.txt_ghichu.TabIndex = 23;
            this.txt_ghichu.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Ghi chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Đơn giá :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên sản phẩm :";
            // 
            // txt_tensanpham
            // 
            this.txt_tensanpham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tensanpham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tensanpham.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tensanpham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tensanpham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_tensanpham.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_tensanpham.Location = new System.Drawing.Point(179, 133);
            this.txt_tensanpham.Name = "txt_tensanpham";
            this.txt_tensanpham.Padding = new System.Windows.Forms.Padding(10);
            this.txt_tensanpham.PasswordChar = '\0';
            this.txt_tensanpham.SelectedText = "";
            this.txt_tensanpham.Size = new System.Drawing.Size(271, 46);
            this.txt_tensanpham.TabIndex = 18;
            this.txt_tensanpham.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 49);
            this.label1.TabIndex = 17;
            this.label1.Text = "THÊM SẢN PHẨM";
            // 
            // clb_danhmuc
            // 
            this.clb_danhmuc.BackColor = System.Drawing.Color.Transparent;
            this.clb_danhmuc.BaseColor = System.Drawing.Color.White;
            this.clb_danhmuc.BorderColor = System.Drawing.Color.Silver;
            this.clb_danhmuc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clb_danhmuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clb_danhmuc.FocusedColor = System.Drawing.Color.Empty;
            this.clb_danhmuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.clb_danhmuc.ForeColor = System.Drawing.Color.Black;
            this.clb_danhmuc.FormattingEnabled = true;
            this.clb_danhmuc.Location = new System.Drawing.Point(179, 94);
            this.clb_danhmuc.Name = "clb_danhmuc";
            this.clb_danhmuc.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.clb_danhmuc.OnHoverItemForeColor = System.Drawing.Color.White;
            this.clb_danhmuc.Size = new System.Drawing.Size(271, 31);
            this.clb_danhmuc.TabIndex = 30;
            this.clb_danhmuc.SelectedIndexChanged += new System.EventHandler(this.clb_danhmuc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Danh mục :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hình ảnh :";
            this.label6.Visible = false;
            // 
            // txt_hinhanh
            // 
            this.txt_hinhanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_hinhanh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hinhanh.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_hinhanh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hinhanh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_hinhanh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_hinhanh.Location = new System.Drawing.Point(179, 341);
            this.txt_hinhanh.Name = "txt_hinhanh";
            this.txt_hinhanh.Padding = new System.Windows.Forms.Padding(10);
            this.txt_hinhanh.PasswordChar = '\0';
            this.txt_hinhanh.SelectedText = "";
            this.txt_hinhanh.Size = new System.Drawing.Size(271, 46);
            this.txt_hinhanh.TabIndex = 29;
            this.txt_hinhanh.Visible = false;
            this.txt_hinhanh.WordWrap = false;
            // 
            // lb_loi
            // 
            this.lb_loi.AutoSize = true;
            this.lb_loi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loi.ForeColor = System.Drawing.Color.Red;
            this.lb_loi.Location = new System.Drawing.Point(122, 412);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(290, 24);
            this.lb_loi.TabIndex = 32;
            this.lb_loi.Text = "Các trường không được để trống!";
            this.lb_loi.Visible = false;
            // 
            // frm_ThemSanPham
            // 
            this.ClientSize = new System.Drawing.Size(505, 544);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clb_danhmuc);
            this.Controls.Add(this.txt_hinhanh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tensanpham);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThemSanPham";
            this.Load += new System.EventHandler(this.frm_ThemSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frm_ThemSanPham_Load(object sender, EventArgs e)
        {
            bll_quanly.loadDMSP();
        }

        private void clb_danhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dongy_Click(object sender, EventArgs e)
        {
            if(txt_dongia.Text==""||txt_soluong.Text=="")
            {
               
                lb_loi.Visible = true;
                return;
            }
            bool i = bll_quanly.ThemSP(); 
            if (i == true)
            {

                MessageBox.Show("Thêm sản phẩm thành công!");
                mainForm.reloadData();
                this.Close();
            }
            else
            {

                MessageBox.Show("Thêm sản phẩm thất bại!");
                
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {

           
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

    }
}

