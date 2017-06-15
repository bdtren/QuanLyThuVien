namespace QLTV
{
    partial class Dangnhap
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
            this.llblquenmatkhau = new System.Windows.Forms.LinkLabel();
            this.llbldangky = new System.Windows.Forms.LinkLabel();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.picxacthuc = new System.Windows.Forms.PictureBox();
            this.txtxacthuc = new System.Windows.Forms.TextBox();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txttaikhoan = new System.Windows.Forms.TextBox();
            this.lblxacthuc = new System.Windows.Forms.Label();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picxacthuc)).BeginInit();
            this.SuspendLayout();
            // 
            // llblquenmatkhau
            // 
            this.llblquenmatkhau.AutoSize = true;
            this.llblquenmatkhau.Location = new System.Drawing.Point(192, 151);
            this.llblquenmatkhau.Name = "llblquenmatkhau";
            this.llblquenmatkhau.Size = new System.Drawing.Size(80, 13);
            this.llblquenmatkhau.TabIndex = 5;
            this.llblquenmatkhau.TabStop = true;
            this.llblquenmatkhau.Text = "Quên mật khẩu";
            // 
            // llbldangky
            // 
            this.llbldangky.AutoSize = true;
            this.llbldangky.Location = new System.Drawing.Point(139, 151);
            this.llbldangky.Name = "llbldangky";
            this.llbldangky.Size = new System.Drawing.Size(47, 13);
            this.llbldangky.TabIndex = 4;
            this.llbldangky.TabStop = true;
            this.llbldangky.Text = "Đăng ký";
            this.llbldangky.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbldangky_LinkClicked);
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(102, 176);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(82, 23);
            this.btndangnhap.TabIndex = 6;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.btndangnhap_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(206, 176);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(82, 23);
            this.btnthoat.TabIndex = 7;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // picxacthuc
            // 
            this.picxacthuc.Image = global::QLTV.Properties.Resources.tra_cuu_ma_so_thue_ohay_tv_757;
            this.picxacthuc.Location = new System.Drawing.Point(102, 88);
            this.picxacthuc.Name = "picxacthuc";
            this.picxacthuc.Size = new System.Drawing.Size(186, 34);
            this.picxacthuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picxacthuc.TabIndex = 19;
            this.picxacthuc.TabStop = false;
            // 
            // txtxacthuc
            // 
            this.txtxacthuc.Location = new System.Drawing.Point(102, 128);
            this.txtxacthuc.Name = "txtxacthuc";
            this.txtxacthuc.Size = new System.Drawing.Size(186, 20);
            this.txtxacthuc.TabIndex = 3;
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Location = new System.Drawing.Point(102, 61);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '*';
            this.txtmatkhau.Size = new System.Drawing.Size(186, 20);
            this.txtmatkhau.TabIndex = 2;
            // 
            // txttaikhoan
            // 
            this.txttaikhoan.Location = new System.Drawing.Point(102, 25);
            this.txttaikhoan.Name = "txttaikhoan";
            this.txttaikhoan.Size = new System.Drawing.Size(186, 20);
            this.txttaikhoan.TabIndex = 1;
            // 
            // lblxacthuc
            // 
            this.lblxacthuc.AutoSize = true;
            this.lblxacthuc.Location = new System.Drawing.Point(29, 131);
            this.lblxacthuc.Name = "lblxacthuc";
            this.lblxacthuc.Size = new System.Drawing.Size(56, 13);
            this.lblxacthuc.TabIndex = 13;
            this.lblxacthuc.Text = "Xác thực: ";
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Location = new System.Drawing.Point(29, 64);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(55, 13);
            this.lblmatkhau.TabIndex = 14;
            this.lblmatkhau.Text = "Mật khẩu:";
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(29, 28);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(58, 13);
            this.lbltaikhoan.TabIndex = 15;
            this.lbltaikhoan.Text = "Tài khoản:";
            // 
            // Dangnhap
            // 
            this.AcceptButton = this.btndangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 216);
            this.Controls.Add(this.llblquenmatkhau);
            this.Controls.Add(this.llbldangky);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.picxacthuc);
            this.Controls.Add(this.txtxacthuc);
            this.Controls.Add(this.txtmatkhau);
            this.Controls.Add(this.txttaikhoan);
            this.Controls.Add(this.lblxacthuc);
            this.Controls.Add(this.lblmatkhau);
            this.Controls.Add(this.lbltaikhoan);
            this.Name = "Dangnhap";
            this.Text = "Đăng nhập";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Dangnhap_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picxacthuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llblquenmatkhau;
        private System.Windows.Forms.LinkLabel llbldangky;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.PictureBox picxacthuc;
        private System.Windows.Forms.TextBox txtxacthuc;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label lblxacthuc;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lbltaikhoan;
    }
}

