namespace QLTV
{
    partial class FormChinh
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabpage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDoimatkhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThemsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSuasach = new System.Windows.Forms.ToolStripMenuItem();
            this.mniXoasach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoatdong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMuonsach = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTrasach = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTksach = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTkdg = new System.Windows.Forms.ToolStripMenuItem();
            this.mnisNangcao = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThemthuthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThemthukho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mniHuongdan = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThongtintg = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabpage);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 24);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(708, 326);
            this.tabs.TabIndex = 3;
            // 
            // tabpage
            // 
            this.tabpage.Location = new System.Drawing.Point(4, 22);
            this.tabpage.Name = "tabpage";
            this.tabpage.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage.Size = new System.Drawing.Size(700, 300);
            this.tabpage.TabIndex = 0;
            this.tabpage.Tag = "";
            this.tabpage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(700, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTaikhoan,
            this.mnuSach,
            this.mnuHoatdong,
            this.mnuTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTaikhoan
            // 
            this.mnuTaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniThongtin,
            this.mniDoimatkhau,
            this.mniDangxuat});
            this.mnuTaikhoan.Name = "mnuTaikhoan";
            this.mnuTaikhoan.Size = new System.Drawing.Size(70, 20);
            this.mnuTaikhoan.Text = "Tài khoản";
            // 
            // mniThongtin
            // 
            this.mniThongtin.Name = "mniThongtin";
            this.mniThongtin.Size = new System.Drawing.Size(152, 22);
            this.mniThongtin.Text = "Thông tin";
            this.mniThongtin.Click += new System.EventHandler(this.mniThongtin_Click);
            // 
            // mniDoimatkhau
            // 
            this.mniDoimatkhau.Name = "mniDoimatkhau";
            this.mniDoimatkhau.Size = new System.Drawing.Size(152, 22);
            this.mniDoimatkhau.Text = "Đổi mật khẩu";
            this.mniDoimatkhau.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem_Click);
            // 
            // mniDangxuat
            // 
            this.mniDangxuat.Name = "mniDangxuat";
            this.mniDangxuat.Size = new System.Drawing.Size(152, 22);
            this.mniDangxuat.Text = "đăng xuất";
            // 
            // mnuSach
            // 
            this.mnuSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniThemsach,
            this.mniSuasach,
            this.mniXoasach});
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(44, 20);
            this.mnuSach.Text = "Sách";
            this.mnuSach.Visible = false;
            // 
            // mniThemsach
            // 
            this.mniThemsach.Name = "mniThemsach";
            this.mniThemsach.Size = new System.Drawing.Size(152, 22);
            this.mniThemsach.Text = "Thêm sách";
            // 
            // mniSuasach
            // 
            this.mniSuasach.Name = "mniSuasach";
            this.mniSuasach.Size = new System.Drawing.Size(152, 22);
            this.mniSuasach.Text = "Sửa sách";
            // 
            // mniXoasach
            // 
            this.mniXoasach.Name = "mniXoasach";
            this.mniXoasach.Size = new System.Drawing.Size(152, 22);
            this.mniXoasach.Text = "Xóa sách";
            // 
            // mnuHoatdong
            // 
            this.mnuHoatdong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMuonsach,
            this.mniTrasach,
            this.mnisThongke,
            this.mnisNangcao});
            this.mnuHoatdong.Name = "mnuHoatdong";
            this.mnuHoatdong.Size = new System.Drawing.Size(76, 20);
            this.mnuHoatdong.Text = "Hoạt động";
            this.mnuHoatdong.Visible = false;
            // 
            // mniMuonsach
            // 
            this.mniMuonsach.Name = "mniMuonsach";
            this.mniMuonsach.Size = new System.Drawing.Size(152, 22);
            this.mniMuonsach.Text = "Mượn sách";
            // 
            // mniTrasach
            // 
            this.mniTrasach.Name = "mniTrasach";
            this.mniTrasach.Size = new System.Drawing.Size(152, 22);
            this.mniTrasach.Text = "Trả sách";
            // 
            // mnisThongke
            // 
            this.mnisThongke.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniTksach,
            this.mniTkdg});
            this.mnisThongke.Name = "mnisThongke";
            this.mnisThongke.Size = new System.Drawing.Size(152, 22);
            this.mnisThongke.Text = "Thống kê";
            // 
            // mniTksach
            // 
            this.mniTksach.Name = "mniTksach";
            this.mniTksach.Size = new System.Drawing.Size(152, 22);
            this.mniTksach.Text = "Sách ";
            // 
            // mniTkdg
            // 
            this.mniTkdg.Name = "mniTkdg";
            this.mniTkdg.Size = new System.Drawing.Size(152, 22);
            this.mniTkdg.Text = "Độc giả";
            // 
            // mnisNangcao
            // 
            this.mnisNangcao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniThemthuthu,
            this.mniThemthukho});
            this.mnisNangcao.Name = "mnisNangcao";
            this.mnisNangcao.Size = new System.Drawing.Size(152, 22);
            this.mnisNangcao.Text = "Nâng cao";
            // 
            // mniThemthuthu
            // 
            this.mniThemthuthu.Name = "mniThemthuthu";
            this.mniThemthuthu.Size = new System.Drawing.Size(152, 22);
            this.mniThemthuthu.Text = "Thêm thủ thư";
            // 
            // mniThemthukho
            // 
            this.mniThemthukho.Name = "mniThemthukho";
            this.mniThemthukho.Size = new System.Drawing.Size(152, 22);
            this.mniThemthukho.Text = "Thêm thủ kho";
            // 
            // mnuTrogiup
            // 
            this.mnuTrogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniHuongdan,
            this.mniThongtintg});
            this.mnuTrogiup.Name = "mnuTrogiup";
            this.mnuTrogiup.Size = new System.Drawing.Size(63, 20);
            this.mnuTrogiup.Text = "Trợ giúp";
            // 
            // mniHuongdan
            // 
            this.mniHuongdan.Name = "mniHuongdan";
            this.mniHuongdan.Size = new System.Drawing.Size(164, 22);
            this.mniHuongdan.Text = "Hướng dẫn";
            // 
            // mniThongtintg
            // 
            this.mniThongtintg.Name = "mniThongtintg";
            this.mniThongtintg.Size = new System.Drawing.Size(164, 22);
            this.mniThongtintg.Text = "Thông tin tác giả";
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 350);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormChinh";
            this.Text = "FormChinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChinh_FormClosed);
            this.Load += new System.EventHandler(this.FormChinh_Load);
            this.tabs.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabpage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaikhoan;
        private System.Windows.Forms.ToolStripMenuItem mniThongtin;
        private System.Windows.Forms.ToolStripMenuItem mniDoimatkhau;
        private System.Windows.Forms.ToolStripMenuItem mniDangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripMenuItem mniThemsach;
        private System.Windows.Forms.ToolStripMenuItem mniSuasach;
        private System.Windows.Forms.ToolStripMenuItem mniXoasach;
        private System.Windows.Forms.ToolStripMenuItem mnuHoatdong;
        private System.Windows.Forms.ToolStripMenuItem mniMuonsach;
        private System.Windows.Forms.ToolStripMenuItem mniTrasach;
        private System.Windows.Forms.ToolStripMenuItem mnisThongke;
        private System.Windows.Forms.ToolStripMenuItem mniTksach;
        private System.Windows.Forms.ToolStripMenuItem mniTkdg;
        private System.Windows.Forms.ToolStripMenuItem mnisNangcao;
        private System.Windows.Forms.ToolStripMenuItem mniThemthuthu;
        private System.Windows.Forms.ToolStripMenuItem mniThemthukho;
        private System.Windows.Forms.ToolStripMenuItem mnuTrogiup;
        private System.Windows.Forms.ToolStripMenuItem mniHuongdan;
        private System.Windows.Forms.ToolStripMenuItem mniThongtintg;
    }
}