
namespace caffe.GUI
{
    partial class frm_DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_nhanvien = new System.Windows.Forms.RadioButton();
            this.rd_quanly = new System.Windows.Forms.RadioButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.btn_dangnhap = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txt_matkhau = new Guna.UI.WinForms.GunaLineTextBox();
            this.txt_taikhoan = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_close = new Guna.UI.WinForms.GunaImageButton();
            this.gunaGradient2Panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.gunaLabel1.Location = new System.Drawing.Point(12, 152);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(155, 36);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Tài khoản:";
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.groupBox1);
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel2.Controls.Add(this.btn_dangnhap);
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel2.Controls.Add(this.txt_matkhau);
            this.gunaGradient2Panel2.Controls.Add(this.txt_taikhoan);
            this.gunaGradient2Panel2.Controls.Add(this.btn_close);
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel2.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradient2Panel2.ForeColor = System.Drawing.Color.White;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(238)))), ((int)(((byte)(226)))));
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(452, 476);
            this.gunaGradient2Panel2.TabIndex = 2;
            this.gunaGradient2Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gunaGradient2Panel2_MouseDown);
            this.gunaGradient2Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gunaGradient2Panel2_MouseMove);
            this.gunaGradient2Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gunaGradient2Panel2_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_nhanvien);
            this.groupBox1.Controls.Add(this.rd_quanly);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 287);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 79);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn là:";
            // 
            // rd_nhanvien
            // 
            this.rd_nhanvien.AutoSize = true;
            this.rd_nhanvien.Checked = true;
            this.rd_nhanvien.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.rd_nhanvien.Location = new System.Drawing.Point(193, 40);
            this.rd_nhanvien.Name = "rd_nhanvien";
            this.rd_nhanvien.Size = new System.Drawing.Size(153, 33);
            this.rd_nhanvien.TabIndex = 1;
            this.rd_nhanvien.TabStop = true;
            this.rd_nhanvien.Text = "Nhân viên";
            this.rd_nhanvien.UseVisualStyleBackColor = true;
            // 
            // rd_quanly
            // 
            this.rd_quanly.AutoSize = true;
            this.rd_quanly.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_quanly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.rd_quanly.Location = new System.Drawing.Point(28, 40);
            this.rd_quanly.Name = "rd_quanly";
            this.rd_quanly.Size = new System.Drawing.Size(125, 33);
            this.rd_quanly.TabIndex = 0;
            this.rd_quanly.Text = "Quản lý";
            this.rd_quanly.UseVisualStyleBackColor = true;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.gunaLabel3.Location = new System.Drawing.Point(122, 63);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(233, 49);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "ĐĂNG NHẬP";
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.AnimationHoverSpeed = 0.07F;
            this.btn_dangnhap.AnimationSpeed = 0.03F;
            this.btn_dangnhap.BackColor = System.Drawing.Color.Transparent;
            this.btn_dangnhap.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.btn_dangnhap.BorderColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangnhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dangnhap.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dangnhap.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.ForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.Image = global::caffe.Properties.Resources.user;
            this.btn_dangnhap.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangnhap.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dangnhap.Location = new System.Drawing.Point(101, 392);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.btn_dangnhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dangnhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dangnhap.OnHoverImage = null;
            this.btn_dangnhap.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dangnhap.Radius = 20;
            this.btn_dangnhap.Size = new System.Drawing.Size(234, 60);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "ĐĂNG NHẬP";
            this.btn_dangnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(166)))), ((int)(((byte)(3)))));
            this.gunaLabel2.Location = new System.Drawing.Point(18, 226);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(149, 36);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Mật khẩu:";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.Color.White;
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.txt_matkhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_matkhau.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.txt_matkhau.LineSize = 5;
            this.txt_matkhau.Location = new System.Drawing.Point(191, 226);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Padding = new System.Windows.Forms.Padding(10);
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(207, 46);
            this.txt_matkhau.TabIndex = 3;
            this.txt_matkhau.Text = "1";
            this.txt_matkhau.WordWrap = false;
            this.txt_matkhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_matkhau_KeyDown);
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.BackColor = System.Drawing.Color.White;
            this.txt_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taikhoan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_taikhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.txt_taikhoan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_taikhoan.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(92)))), ((int)(((byte)(0)))));
            this.txt_taikhoan.LineSize = 5;
            this.txt_taikhoan.Location = new System.Drawing.Point(191, 152);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Padding = new System.Windows.Forms.Padding(10);
            this.txt_taikhoan.PasswordChar = '\0';
            this.txt_taikhoan.SelectedText = "";
            this.txt_taikhoan.Size = new System.Drawing.Size(207, 46);
            this.txt_taikhoan.TabIndex = 2;
            this.txt_taikhoan.Text = "nhanvien";
            this.txt_taikhoan.WordWrap = false;
            this.txt_taikhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_taikhoan_KeyDown);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.Image = global::caffe.Properties.Resources.icons8_close_window_64;
            this.btn_close.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_close.Location = new System.Drawing.Point(374, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.OnHoverImage = null;
            this.btn_close.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btn_close.Size = new System.Drawing.Size(66, 42);
            this.btn_close.TabIndex = 1;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frm_DangNhap
            // 
            this.ActiveGlowColor = System.Drawing.Color.Transparent;
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 476);
            this.Controls.Add(this.gunaGradient2Panel2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_DangNhap";
            this.Text = "frm_DangNhap";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI.WinForms.GunaLabel gunaLabel1;
        public Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        public Guna.UI.WinForms.GunaImageButton btn_close;
        public Guna.UI.WinForms.GunaButton btn_dangnhap;
        public Guna.UI.WinForms.GunaLabel gunaLabel2;
        public Guna.UI.WinForms.GunaLineTextBox txt_matkhau;
        public Guna.UI.WinForms.GunaLineTextBox txt_taikhoan;
        public Guna.UI.WinForms.GunaLabel gunaLabel3;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RadioButton rd_nhanvien;
        public System.Windows.Forms.RadioButton rd_quanly;
    }
}