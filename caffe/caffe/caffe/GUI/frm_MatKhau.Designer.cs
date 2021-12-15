
namespace caffe.GUI
{
    partial class frm_MatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_matkhau = new Guna.UI.WinForms.GunaLineTextBox();
            this.lb_tennhanvien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_matkhaumoi = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_huy = new Guna.UI.WinForms.GunaButton();
            this.btn_dongy = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_xacnhanmatkhaumoi = new Guna.UI.WinForms.GunaLineTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "MẬT KHẨU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên nhân viên:";
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_matkhau.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_matkhau.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_matkhau.Location = new System.Drawing.Point(183, 118);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Padding = new System.Windows.Forms.Padding(10);
            this.txt_matkhau.PasswordChar = '\0';
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.Size = new System.Drawing.Size(271, 46);
            this.txt_matkhau.TabIndex = 6;
            this.txt_matkhau.WordWrap = false;
            // 
            // lb_tennhanvien
            // 
            this.lb_tennhanvien.AutoSize = true;
            this.lb_tennhanvien.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tennhanvien.Location = new System.Drawing.Point(183, 76);
            this.lb_tennhanvien.Name = "lb_tennhanvien";
            this.lb_tennhanvien.Size = new System.Drawing.Size(180, 24);
            this.lb_tennhanvien.TabIndex = 8;
            this.lb_tennhanvien.Text = "Nguyễn Tam Hoàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mật khẩu cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mật khẩu mới:";
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_matkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhaumoi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_matkhaumoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhaumoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_matkhaumoi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_matkhaumoi.Location = new System.Drawing.Point(183, 184);
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.Padding = new System.Windows.Forms.Padding(10);
            this.txt_matkhaumoi.PasswordChar = '\0';
            this.txt_matkhaumoi.SelectedText = "";
            this.txt_matkhaumoi.Size = new System.Drawing.Size(271, 46);
            this.txt_matkhaumoi.TabIndex = 10;
            this.txt_matkhaumoi.WordWrap = false;
            // 
            // btn_huy
            // 
            this.btn_huy.AnimationHoverSpeed = 0.07F;
            this.btn_huy.AnimationSpeed = 0.03F;
            this.btn_huy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_huy.BorderColor = System.Drawing.Color.Black;
            this.btn_huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_huy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_huy.ForeColor = System.Drawing.Color.White;
            this.btn_huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_huy.Image")));
            this.btn_huy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_huy.Location = new System.Drawing.Point(230, 346);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_huy.OnHoverImage = null;
            this.btn_huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_huy.Size = new System.Drawing.Size(160, 42);
            this.btn_huy.TabIndex = 13;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_dongy
            // 
            this.btn_dongy.AnimationHoverSpeed = 0.07F;
            this.btn_dongy.AnimationSpeed = 0.03F;
            this.btn_dongy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_dongy.BorderColor = System.Drawing.Color.Black;
            this.btn_dongy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_dongy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_dongy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_dongy.ForeColor = System.Drawing.Color.White;
            this.btn_dongy.Image = ((System.Drawing.Image)(resources.GetObject("btn_dongy.Image")));
            this.btn_dongy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_dongy.Location = new System.Drawing.Point(35, 346);
            this.btn_dongy.Name = "btn_dongy";
            this.btn_dongy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_dongy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_dongy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_dongy.OnHoverImage = null;
            this.btn_dongy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_dongy.Size = new System.Drawing.Size(160, 42);
            this.btn_dongy.TabIndex = 12;
            this.btn_dongy.Text = "Đồng ý";
            this.btn_dongy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_dongy.Click += new System.EventHandler(this.btn_dongy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 48);
            this.label5.TabIndex = 15;
            this.label5.Text = "Xác nhận mật \r\nkhẩu mới:";
            // 
            // txt_xacnhanmatkhaumoi
            // 
            this.txt_xacnhanmatkhaumoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_xacnhanmatkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_xacnhanmatkhaumoi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_xacnhanmatkhaumoi.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_xacnhanmatkhaumoi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_xacnhanmatkhaumoi.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_xacnhanmatkhaumoi.Location = new System.Drawing.Point(183, 249);
            this.txt_xacnhanmatkhaumoi.Name = "txt_xacnhanmatkhaumoi";
            this.txt_xacnhanmatkhaumoi.Padding = new System.Windows.Forms.Padding(10);
            this.txt_xacnhanmatkhaumoi.PasswordChar = '\0';
            this.txt_xacnhanmatkhaumoi.SelectedText = "";
            this.txt_xacnhanmatkhaumoi.Size = new System.Drawing.Size(271, 46);
            this.txt_xacnhanmatkhaumoi.TabIndex = 14;
            this.txt_xacnhanmatkhaumoi.WordWrap = false;
            // 
            // frm_MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 428);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_xacnhanmatkhaumoi);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_dongy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_matkhaumoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_tennhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.label1);
            this.IconOptions.Image = global::caffe.Properties.Resources.user;
            this.Name = "frm_MatKhau";
            this.Text = "Thông tin Nhân viên";
            this.Load += new System.EventHandler(this.frm_MatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public Guna.UI.WinForms.GunaLineTextBox txt_matkhau;
        public System.Windows.Forms.Label lb_tennhanvien;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public Guna.UI.WinForms.GunaLineTextBox txt_matkhaumoi;
        public Guna.UI.WinForms.GunaButton btn_dongy;
        public Guna.UI.WinForms.GunaButton btn_huy;
        public System.Windows.Forms.Label label5;
        public Guna.UI.WinForms.GunaLineTextBox txt_xacnhanmatkhaumoi;
    }
}