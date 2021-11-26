
namespace caffe.GUI
{
    partial class frm_ThemKhuyenMai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemKhuyenMai));
            this.lb_loi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clb_trangthai = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenkm = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ngaybatdau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.ngayketthuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.btn_huy = new Guna.UI.WinForms.GunaButton();
            this.btn_dongy = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // lb_loi
            // 
            this.lb_loi.AutoSize = true;
            this.lb_loi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loi.ForeColor = System.Drawing.Color.Red;
            this.lb_loi.Location = new System.Drawing.Point(5, 311);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(527, 36);
            this.lb_loi.TabIndex = 46;
            this.lb_loi.Text = "Các trường không được để trống hoặc bạn đã nhập trùng tên khuyến mãi \r\nhoặc ngày " +
    "bắt đầu phải lớn hơn ngày kết thúc của đợt khuyến mãi đang áp dụng";
            this.lb_loi.Visible = false;
            this.lb_loi.Click += new System.EventHandler(this.lb_loi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "Trạng thái :";
            // 
            // clb_trangthai
            // 
            this.clb_trangthai.BackColor = System.Drawing.Color.Transparent;
            this.clb_trangthai.BaseColor = System.Drawing.Color.White;
            this.clb_trangthai.BorderColor = System.Drawing.Color.Silver;
            this.clb_trangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clb_trangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clb_trangthai.FocusedColor = System.Drawing.Color.Empty;
            this.clb_trangthai.Font = new System.Drawing.Font("Roboto Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_trangthai.ForeColor = System.Drawing.Color.Black;
            this.clb_trangthai.FormattingEnabled = true;
            this.clb_trangthai.Items.AddRange(new object[] {
            "CHƯA ÁP DỤNG"});
            this.clb_trangthai.Location = new System.Drawing.Point(181, 92);
            this.clb_trangthai.Name = "clb_trangthai";
            this.clb_trangthai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.clb_trangthai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.clb_trangthai.Size = new System.Drawing.Size(271, 27);
            this.clb_trangthai.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày kết thúc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ngày bắt đầu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tên khuyến mãi :";
            // 
            // txt_tenkm
            // 
            this.txt_tenkm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tenkm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenkm.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tenkm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_tenkm.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_tenkm.Location = new System.Drawing.Point(181, 131);
            this.txt_tenkm.Name = "txt_tenkm";
            this.txt_tenkm.Padding = new System.Windows.Forms.Padding(10);
            this.txt_tenkm.PasswordChar = '\0';
            this.txt_tenkm.SelectedText = "";
            this.txt_tenkm.Size = new System.Drawing.Size(271, 46);
            this.txt_tenkm.TabIndex = 34;
            this.txt_tenkm.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 33;
            this.label1.Text = "THÊM KHUYẾN MÃI";
            // 
            // ngaybatdau
            // 
            this.ngaybatdau.BorderRadius = 10;
            this.ngaybatdau.CheckedState.Parent = this.ngaybatdau;
            this.ngaybatdau.CustomFormat = "dd/MM/yyyy";
            this.ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaybatdau.HoverState.Parent = this.ngaybatdau;
            this.ngaybatdau.Location = new System.Drawing.Point(181, 197);
            this.ngaybatdau.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.ngaybatdau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ngaybatdau.Name = "ngaybatdau";
            this.ngaybatdau.ShadowDecoration.Parent = this.ngaybatdau;
            this.ngaybatdau.Size = new System.Drawing.Size(271, 36);
            this.ngaybatdau.TabIndex = 49;
            this.ngaybatdau.Value = new System.DateTime(2021, 9, 25, 13, 48, 20, 356);
            // 
            // ngayketthuc
            // 
            this.ngayketthuc.BorderRadius = 10;
            this.ngayketthuc.CheckedState.Parent = this.ngayketthuc;
            this.ngayketthuc.CustomFormat = "dd/MM/yyyy";
            this.ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayketthuc.HoverState.Parent = this.ngayketthuc;
            this.ngayketthuc.Location = new System.Drawing.Point(181, 249);
            this.ngayketthuc.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.ngayketthuc.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.ngayketthuc.Name = "ngayketthuc";
            this.ngayketthuc.ShadowDecoration.Parent = this.ngayketthuc;
            this.ngayketthuc.Size = new System.Drawing.Size(271, 36);
            this.ngayketthuc.TabIndex = 50;
            this.ngayketthuc.Value = new System.DateTime(2021, 10, 8, 15, 19, 23, 0);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(239, 369);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 10;
            this.gunaButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaButton1.TabIndex = 48;
            this.gunaButton1.Text = "Hủy";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(42, 369);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 10;
            this.gunaButton2.Size = new System.Drawing.Size(160, 42);
            this.gunaButton2.TabIndex = 47;
            this.gunaButton2.Text = "Đồng ý";
            this.gunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
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
            this.btn_huy.Location = new System.Drawing.Point(245, 461);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Radius = 10;
            this.btn_huy.Size = new System.Drawing.Size(160, 42);
            this.btn_huy.TabIndex = 43;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_dongy.Location = new System.Drawing.Point(51, 461);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dongy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dongy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dongy.OnHoverImage = null;
            this.btn_dongy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dongy.Radius = 10;
            this.btn_dongy.Size = new System.Drawing.Size(160, 42);
            this.btn_dongy.TabIndex = 42;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_ThemKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 457);
            this.Controls.Add(this.ngayketthuc);
            this.Controls.Add(this.ngaybatdau);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.gunaButton2);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clb_trangthai);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tenkm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_ThemKhuyenMai";
            this.Text = "frm_ThemKhuyenMai";
            this.Load += new System.EventHandler(this.frm_ThemKhuyenMai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_loi;
        public System.Windows.Forms.Label label7;
        public Guna.UI.WinForms.GunaComboBox clb_trangthai;
        public Guna.UI.WinForms.GunaButton btn_huy;
        public Guna.UI.WinForms.GunaButton btn_dongy;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaLineTextBox txt_tenkm;
        public System.Windows.Forms.Label label1;
        public Guna.UI.WinForms.GunaButton gunaButton1;
        public Guna.UI.WinForms.GunaButton gunaButton2;
        public Guna.UI2.WinForms.Guna2DateTimePicker ngaybatdau;
        public Guna.UI2.WinForms.Guna2DateTimePicker ngayketthuc;
    }
}