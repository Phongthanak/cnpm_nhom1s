
namespace caffe.GUI
{
    partial class frm_ThemSanPhamKM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThemSanPhamKM));
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tylekhuyenmai = new Guna.UI.WinForms.GunaLineTextBox();
            this.lb_tenkm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_loi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clb_tensanpham = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_soluong = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_huy = new Guna.UI.WinForms.GunaButton();
            this.btn_dongy = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 78;
            this.label5.Text = "Tỷ lệ khuyến mãi :";
            // 
            // txt_tylekhuyenmai
            // 
            this.txt_tylekhuyenmai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tylekhuyenmai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tylekhuyenmai.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tylekhuyenmai.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tylekhuyenmai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_tylekhuyenmai.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_tylekhuyenmai.Location = new System.Drawing.Point(240, 295);
            this.txt_tylekhuyenmai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tylekhuyenmai.Name = "txt_tylekhuyenmai";
            this.txt_tylekhuyenmai.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txt_tylekhuyenmai.PasswordChar = '\0';
            this.txt_tylekhuyenmai.SelectedText = "";
            this.txt_tylekhuyenmai.Size = new System.Drawing.Size(361, 57);
            this.txt_tylekhuyenmai.TabIndex = 77;
            this.txt_tylekhuyenmai.WordWrap = false;
            this.txt_tylekhuyenmai.TextChanged += new System.EventHandler(this.txt_tylekhuyenmai_TextChanged);
            this.txt_tylekhuyenmai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tylekhuyenmai_KeyPress);
            // 
            // lb_tenkm
            // 
            this.lb_tenkm.AutoSize = true;
            this.lb_tenkm.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenkm.Location = new System.Drawing.Point(372, 107);
            this.lb_tenkm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tenkm.Name = "lb_tenkm";
            this.lb_tenkm.Size = new System.Drawing.Size(102, 24);
            this.lb_tenkm.TabIndex = 76;
            this.lb_tenkm.Text = "Số lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(145, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tên đợt khuyến mãi :";
            // 
            // lb_loi
            // 
            this.lb_loi.AutoSize = true;
            this.lb_loi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_loi.ForeColor = System.Drawing.Color.Red;
            this.lb_loi.Location = new System.Drawing.Point(169, 375);
            this.lb_loi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_loi.Name = "lb_loi";
            this.lb_loi.Size = new System.Drawing.Size(378, 48);
            this.lb_loi.TabIndex = 72;
            this.lb_loi.Text = "Sản phẩm đã có trong đợt khuyến mãi hoặc\r\nCó trường chưa nhập dữ liệu";
            this.lb_loi.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(83, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 71;
            this.label7.Text = "Sản phẩm :";
            // 
            // clb_tensanpham
            // 
            this.clb_tensanpham.BackColor = System.Drawing.Color.Transparent;
            this.clb_tensanpham.BaseColor = System.Drawing.Color.White;
            this.clb_tensanpham.BorderColor = System.Drawing.Color.Silver;
            this.clb_tensanpham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.clb_tensanpham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clb_tensanpham.FocusedColor = System.Drawing.Color.Empty;
            this.clb_tensanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_tensanpham.ForeColor = System.Drawing.Color.Black;
            this.clb_tensanpham.FormattingEnabled = true;
            this.clb_tensanpham.Location = new System.Drawing.Point(240, 187);
            this.clb_tensanpham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clb_tensanpham.Name = "clb_tensanpham";
            this.clb_tensanpham.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.clb_tensanpham.OnHoverItemForeColor = System.Drawing.Color.White;
            this.clb_tensanpham.Size = new System.Drawing.Size(360, 30);
            this.clb_tensanpham.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 250);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "Số lượng :";
            // 
            // txt_soluong
            // 
            this.txt_soluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soluong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_soluong.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_soluong.Location = new System.Drawing.Point(240, 231);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.SelectedText = "";
            this.txt_soluong.Size = new System.Drawing.Size(361, 57);
            this.txt_soluong.TabIndex = 68;
            this.txt_soluong.WordWrap = false;
            this.txt_soluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soluong_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 49);
            this.label1.TabIndex = 67;
            this.label1.Text = "THÊM SẢN PHẨM KHUYẾN MÃI";
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
            this.btn_huy.Location = new System.Drawing.Point(447, 454);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Radius = 10;
            this.btn_huy.Size = new System.Drawing.Size(213, 52);
            this.btn_huy.TabIndex = 74;
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
            this.btn_dongy.Location = new System.Drawing.Point(99, 454);
            this.btn_dongy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dongy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dongy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dongy.OnHoverImage = null;
            this.btn_dongy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dongy.Radius = 10;
            this.btn_dongy.Size = new System.Drawing.Size(213, 52);
            this.btn_dongy.TabIndex = 73;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // frm_ThemSanPhamKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tylekhuyenmai);
            this.Controls.Add(this.lb_tenkm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.lb_loi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clb_tensanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ThemSanPhamKM";
            this.Text = "frm_ThemSanPhamKM";
            this.Load += new System.EventHandler(this.frm_ThemSanPhamKM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaLineTextBox txt_tylekhuyenmai;
        public System.Windows.Forms.Label lb_tenkm;
        public System.Windows.Forms.Label label3;
        public Guna.UI.WinForms.GunaButton btn_huy;
        public Guna.UI.WinForms.GunaButton btn_dongy;
        public System.Windows.Forms.Label lb_loi;
        public System.Windows.Forms.Label label7;
        public Guna.UI.WinForms.GunaComboBox clb_tensanpham;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaLineTextBox txt_soluong;
        public System.Windows.Forms.Label label1;
    }
}