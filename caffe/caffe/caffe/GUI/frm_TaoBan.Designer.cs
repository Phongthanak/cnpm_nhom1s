
namespace caffe.GUI
{
    partial class frm_TaoBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TaoBan));
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tenban = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_checkTenban = new Guna.UI2.WinForms.Guna2ImageRadioButton();
            this.btn_exit = new Guna.UI.WinForms.GunaButton();
            this.btn_ok = new Guna.UI.WinForms.GunaButton();
            this.lbl_loitenban = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tên bàn:";
            // 
            // txt_tenban
            // 
            this.txt_tenban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_tenban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tenban.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tenban.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenban.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_tenban.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(123)))), ((int)(((byte)(213)))));
            this.txt_tenban.Location = new System.Drawing.Point(110, 84);
            this.txt_tenban.Name = "txt_tenban";
            this.txt_tenban.Padding = new System.Windows.Forms.Padding(10);
            this.txt_tenban.PasswordChar = '\0';
            this.txt_tenban.SelectedText = "";
            this.txt_tenban.Size = new System.Drawing.Size(271, 46);
            this.txt_tenban.TabIndex = 45;
            this.txt_tenban.WordWrap = false;
            this.txt_tenban.TextChanged += new System.EventHandler(this.txt_tenban_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 49);
            this.label1.TabIndex = 32;
            this.label1.Text = "THÊM BÀN";
            // 
            // lbl_checkTenban
            // 
            this.lbl_checkTenban.BackgroundImage = global::caffe.Properties.Resources.check;
            this.lbl_checkTenban.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lbl_checkTenban.CheckedState.Parent = this.lbl_checkTenban;
            this.lbl_checkTenban.HoverState.Parent = this.lbl_checkTenban;
            this.lbl_checkTenban.Location = new System.Drawing.Point(387, 84);
            this.lbl_checkTenban.Name = "lbl_checkTenban";
            this.lbl_checkTenban.PressedState.Parent = this.lbl_checkTenban;
            this.lbl_checkTenban.Size = new System.Drawing.Size(48, 46);
            this.lbl_checkTenban.TabIndex = 47;
            this.lbl_checkTenban.Visible = false;
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
            this.btn_exit.Location = new System.Drawing.Point(248, 175);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_exit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_exit.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_exit.OnHoverImage = null;
            this.btn_exit.OnPressedColor = System.Drawing.Color.Black;
            this.btn_exit.Radius = 10;
            this.btn_exit.Size = new System.Drawing.Size(160, 42);
            this.btn_exit.TabIndex = 42;
            this.btn_exit.Text = "Hủy";
            this.btn_exit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btn_ok.Location = new System.Drawing.Point(53, 175);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_ok.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ok.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ok.OnHoverImage = null;
            this.btn_ok.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ok.Radius = 10;
            this.btn_ok.Size = new System.Drawing.Size(160, 42);
            this.btn_ok.TabIndex = 41;
            this.btn_ok.Text = "Đồng ý";
            this.btn_ok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lbl_loitenban
            // 
            this.lbl_loitenban.AutoSize = true;
            this.lbl_loitenban.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loitenban.ForeColor = System.Drawing.Color.Red;
            this.lbl_loitenban.Location = new System.Drawing.Point(107, 133);
            this.lbl_loitenban.Name = "lbl_loitenban";
            this.lbl_loitenban.Size = new System.Drawing.Size(197, 18);
            this.lbl_loitenban.TabIndex = 48;
            this.lbl_loitenban.Text = "Tên bàn đã được sử dụng";
            this.lbl_loitenban.Visible = false;
            // 
            // frm_TaoBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 302);
            this.Controls.Add(this.lbl_loitenban);
            this.Controls.Add(this.lbl_checkTenban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tenban);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label1);
            this.Name = "frm_TaoBan";
            this.Text = "frm_TaoBan";
            this.Load += new System.EventHandler(this.frm_TaoBan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label7;
        public Guna.UI.WinForms.GunaLineTextBox txt_tenban;
        public Guna.UI.WinForms.GunaButton btn_exit;
        public Guna.UI.WinForms.GunaButton btn_ok;
        public System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2ImageRadioButton lbl_checkTenban;
        public System.Windows.Forms.Label lbl_loitenban;
    }
}