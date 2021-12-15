
namespace caffe.GUI
{
    partial class frm_TaoDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaoDM));
            this.lbl_loitendm = new System.Windows.Forms.Label();
            this.lbl_checkTenDM = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tendm = new Guna.UI.WinForms.GunaLineTextBox();
            this.btn_exit = new Guna.UI.WinForms.GunaButton();
            this.btn_ok = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_loitendm
            // 
            this.lbl_loitendm.AutoSize = true;
            this.lbl_loitendm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loitendm.ForeColor = System.Drawing.Color.Red;
            this.lbl_loitendm.Location = new System.Drawing.Point(149, 126);
            this.lbl_loitendm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_loitendm.Name = "lbl_loitendm";
            this.lbl_loitendm.Size = new System.Drawing.Size(208, 15);
            this.lbl_loitendm.TabIndex = 55;
            this.lbl_loitendm.Text = "Tên danh mục đã được sử dụng";
            this.lbl_loitendm.Visible = false;
            // 
            // lbl_checkTenDM
            // 
            this.lbl_checkTenDM.BackgroundImage = global::caffe.Properties.Resources.check;
            this.lbl_checkTenDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lbl_checkTenDM.CheckedState.Parent = this.lbl_checkTenDM;
            this.lbl_checkTenDM.HoverState.Parent = this.lbl_checkTenDM;
            this.lbl_checkTenDM.Location = new System.Drawing.Point(360, 87);
            this.lbl_checkTenDM.Margin = new System.Windows.Forms.Padding(2);
            this.lbl_checkTenDM.Name = "lbl_checkTenDM";
            this.lbl_checkTenDM.PressedState.Parent = this.lbl_checkTenDM;
            this.lbl_checkTenDM.Size = new System.Drawing.Size(36, 37);
            this.lbl_checkTenDM.TabIndex = 54;
            this.lbl_checkTenDM.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tên danh mục";
            // 
            // txt_tendm
            // 
            this.txt_tendm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tendm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tendm.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tendm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_tendm.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_tendm.Location = new System.Drawing.Point(152, 87);
            this.txt_tendm.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tendm.Name = "txt_tendm";
            this.txt_tendm.Padding = new System.Windows.Forms.Padding(8);
            this.txt_tendm.PasswordChar = '\0';
            this.txt_tendm.SelectedText = "";
            this.txt_tendm.Size = new System.Drawing.Size(203, 37);
            this.txt_tendm.TabIndex = 52;
            this.txt_tendm.WordWrap = false;
            this.txt_tendm.TextChanged += new System.EventHandler(this.txt_tendm_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.AnimationHoverSpeed = 0.07F;
            this.btn_exit.AnimationSpeed = 0.03F;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_exit.BorderColor = System.Drawing.Color.Black;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_exit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_exit.Location = new System.Drawing.Point(256, 161);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_exit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_exit.OnHoverImage = null;
            this.btn_exit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_exit.Radius = 10;
            this.btn_exit.Size = new System.Drawing.Size(120, 34);
            this.btn_exit.TabIndex = 51;
            this.btn_exit.Text = "Hủy";
            this.btn_exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click_1);
            // 
            // btn_ok
            // 
            this.btn_ok.AnimationHoverSpeed = 0.07F;
            this.btn_ok.AnimationSpeed = 0.03F;
            this.btn_ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_ok.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_ok.BorderColor = System.Drawing.Color.Black;
            this.btn_ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ok.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ok.ForeColor = System.Drawing.Color.White;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ok.Location = new System.Drawing.Point(110, 161);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ok.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ok.OnHoverImage = null;
            this.btn_ok.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ok.Radius = 10;
            this.btn_ok.Size = new System.Drawing.Size(120, 34);
            this.btn_ok.TabIndex = 50;
            this.btn_ok.Text = "Đồng ý";
            this.btn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 40);
            this.label1.TabIndex = 49;
            this.label1.Text = "THÊM DANH MỤC";
            // 
            // frm_TaoDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 236);
            this.Controls.Add(this.lbl_loitendm);
            this.Controls.Add(this.lbl_checkTenDM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tendm);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Name = "frm_TaoDM";
            this.Text = "frm_TaoDM";
            this.Load += new System.EventHandler(this.frm_TaoDM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_loitendm;
        public Guna.UI2.WinForms.Guna2ImageRadioButton lbl_checkTenDM;
        public System.Windows.Forms.Label label7;
        public Guna.UI.WinForms.GunaLineTextBox txt_tendm;
        public Guna.UI.WinForms.GunaButton btn_exit;
        public Guna.UI.WinForms.GunaButton btn_ok;
        public System.Windows.Forms.Label label1;
    }
}