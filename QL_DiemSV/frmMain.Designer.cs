
namespace QL_DiemSV
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuItemHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanlinguoidung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDX = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnItemQuanly = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiemThiLai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongtinSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDSSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDiemTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.thongtin = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btNganh = new System.Windows.Forms.Button();
            this.btLop = new System.Windows.Forms.Button();
            this.btMonhoc = new System.Windows.Forms.Button();
            this.btQLDiem = new System.Windows.Forms.Button();
            this.btQLSV = new System.Windows.Forms.Button();
            this.btnGiangVien = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.PowderBlue;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHethong,
            this.mnItemQuanly,
            this.mnuTimKiem,
            this.mnuThongKe,
            this.mnuTroGiup});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1922, 40);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnuItemHethong
            // 
            this.mnuItemHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.mnuDN,
            this.mnuDoiMK,
            this.mnuQuanlinguoidung,
            this.mnuDX,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.mnuExit});
            this.mnuItemHethong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuItemHethong.ForeColor = System.Drawing.Color.Green;
            this.mnuItemHethong.Image = ((System.Drawing.Image)(resources.GetObject("mnuItemHethong.Image")));
            this.mnuItemHethong.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuItemHethong.Name = "mnuItemHethong";
            this.mnuItemHethong.Size = new System.Drawing.Size(167, 36);
            this.mnuItemHethong.Text = "Hệ Thống";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(276, 6);
            // 
            // mnuDN
            // 
            this.mnuDN.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDN.ForeColor = System.Drawing.Color.ForestGreen;
            this.mnuDN.Image = ((System.Drawing.Image)(resources.GetObject("mnuDN.Image")));
            this.mnuDN.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuDN.Name = "mnuDN";
            this.mnuDN.Size = new System.Drawing.Size(279, 32);
            this.mnuDN.Text = "Đăng nhập";
            this.mnuDN.Click += new System.EventHandler(this.mnuDN_Click);
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDoiMK.ForeColor = System.Drawing.Color.ForestGreen;
            this.mnuDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiMK.Image")));
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(279, 32);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            this.mnuDoiMK.Click += new System.EventHandler(this.mnuDoiMK_Click);
            // 
            // mnuQuanlinguoidung
            // 
            this.mnuQuanlinguoidung.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuQuanlinguoidung.ForeColor = System.Drawing.Color.ForestGreen;
            this.mnuQuanlinguoidung.Image = ((System.Drawing.Image)(resources.GetObject("mnuQuanlinguoidung.Image")));
            this.mnuQuanlinguoidung.Name = "mnuQuanlinguoidung";
            this.mnuQuanlinguoidung.Size = new System.Drawing.Size(279, 32);
            this.mnuQuanlinguoidung.Text = "Quản lí người dùng";
            this.mnuQuanlinguoidung.Click += new System.EventHandler(this.mnuQuanlinguoidung_Click);
            // 
            // mnuDX
            // 
            this.mnuDX.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuDX.ForeColor = System.Drawing.Color.ForestGreen;
            this.mnuDX.Image = ((System.Drawing.Image)(resources.GetObject("mnuDX.Image")));
            this.mnuDX.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnuDX.Name = "mnuDX";
            this.mnuDX.Size = new System.Drawing.Size(279, 32);
            this.mnuDX.Text = "Đăng xuất";
            this.mnuDX.Click += new System.EventHandler(this.mnuDX_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(276, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(276, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.ForeColor = System.Drawing.Color.ForestGreen;
            this.mnuExit.Image = ((System.Drawing.Image)(resources.GetObject("mnuExit.Image")));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(279, 32);
            this.mnuExit.Text = "E&xit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnItemQuanly
            // 
            this.mnItemQuanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDiemThiLai});
            this.mnItemQuanly.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.mnItemQuanly.ForeColor = System.Drawing.Color.Green;
            this.mnItemQuanly.Image = ((System.Drawing.Image)(resources.GetObject("mnItemQuanly.Image")));
            this.mnItemQuanly.Name = "mnItemQuanly";
            this.mnItemQuanly.Size = new System.Drawing.Size(157, 36);
            this.mnItemQuanly.Text = "Quản Lý";
            this.mnItemQuanly.Click += new System.EventHandler(this.mnItemQuanly_Click);
            // 
            // mnuDiemThiLai
            // 
            this.mnuDiemThiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.mnuDiemThiLai.ForeColor = System.Drawing.Color.Green;
            this.mnuDiemThiLai.Image = ((System.Drawing.Image)(resources.GetObject("mnuDiemThiLai.Image")));
            this.mnuDiemThiLai.Name = "mnuDiemThiLai";
            this.mnuDiemThiLai.Size = new System.Drawing.Size(214, 32);
            this.mnuDiemThiLai.Text = "Điểm Thi Lại";
            this.mnuDiemThiLai.Click += new System.EventHandler(this.mnuDiemThiLai_Click_1);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongtinSV});
            this.mnuTimKiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTimKiem.ForeColor = System.Drawing.Color.Green;
            this.mnuTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("mnuTimKiem.Image")));
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(169, 36);
            this.mnuTimKiem.Text = "Tìm Kiếm";
            // 
            // mnuThongtinSV
            // 
            this.mnuThongtinSV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuThongtinSV.ForeColor = System.Drawing.Color.ForestGreen;
            this.mnuThongtinSV.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongtinSV.Image")));
            this.mnuThongtinSV.Name = "mnuThongtinSV";
            this.mnuThongtinSV.Size = new System.Drawing.Size(257, 32);
            this.mnuThongtinSV.Text = "Thông tin của SV";
            this.mnuThongtinSV.Click += new System.EventHandler(this.mnuThongtinSV_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDSSV,
            this.mnuDiemTK});
            this.mnuThongKe.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.mnuThongKe.ForeColor = System.Drawing.Color.Green;
            this.mnuThongKe.Image = ((System.Drawing.Image)(resources.GetObject("mnuThongKe.Image")));
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(169, 36);
            this.mnuThongKe.Text = "Thống Kê";
            // 
            // mnuDSSV
            // 
            this.mnuDSSV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.mnuDSSV.ForeColor = System.Drawing.Color.Green;
            this.mnuDSSV.Image = ((System.Drawing.Image)(resources.GetObject("mnuDSSV.Image")));
            this.mnuDSSV.Name = "mnuDSSV";
            this.mnuDSSV.Size = new System.Drawing.Size(300, 32);
            this.mnuDSSV.Text = "Danh sách SV";
            this.mnuDSSV.Click += new System.EventHandler(this.mnuDSSV_Click);
            // 
            // mnuDiemTK
            // 
            this.mnuDiemTK.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.mnuDiemTK.ForeColor = System.Drawing.Color.Green;
            this.mnuDiemTK.Image = ((System.Drawing.Image)(resources.GetObject("mnuDiemTK.Image")));
            this.mnuDiemTK.Name = "mnuDiemTK";
            this.mnuDiemTK.Size = new System.Drawing.Size(300, 32);
            this.mnuDiemTK.Text = "Điểm tổng kết của SV";
            this.mnuDiemTK.Click += new System.EventHandler(this.mnuDiemTK_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thongtin});
            this.mnuTroGiup.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.mnuTroGiup.ForeColor = System.Drawing.Color.Green;
            this.mnuTroGiup.Image = ((System.Drawing.Image)(resources.GetObject("mnuTroGiup.Image")));
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(162, 36);
            this.mnuTroGiup.Text = "Trợ Giúp";
            // 
            // thongtin
            // 
            this.thongtin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.thongtin.ForeColor = System.Drawing.Color.Green;
            this.thongtin.Image = ((System.Drawing.Image)(resources.GetObject("thongtin.Image")));
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(270, 32);
            this.thongtin.Text = "Thông Tin Liên Hệ";
            this.thongtin.Click += new System.EventHandler(this.thongtin_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btNganh
            // 
            this.btNganh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btNganh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNganh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNganh.ForeColor = System.Drawing.Color.Ivory;
            this.btNganh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btNganh.Location = new System.Drawing.Point(0, 402);
            this.btNganh.Margin = new System.Windows.Forms.Padding(4);
            this.btNganh.Name = "btNganh";
            this.btNganh.Size = new System.Drawing.Size(288, 85);
            this.btNganh.TabIndex = 9;
            this.btNganh.Text = "Quản lý Ngành";
            this.btNganh.UseVisualStyleBackColor = false;
            this.btNganh.Click += new System.EventHandler(this.btNganh_Click);
            // 
            // btLop
            // 
            this.btLop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLop.ForeColor = System.Drawing.Color.Ivory;
            this.btLop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btLop.Location = new System.Drawing.Point(0, 530);
            this.btLop.Margin = new System.Windows.Forms.Padding(4);
            this.btLop.Name = "btLop";
            this.btLop.Size = new System.Drawing.Size(288, 85);
            this.btLop.TabIndex = 10;
            this.btLop.Text = "Quản lý Lớp";
            this.btLop.UseVisualStyleBackColor = false;
            this.btLop.Click += new System.EventHandler(this.btLop_Click);
            // 
            // btMonhoc
            // 
            this.btMonhoc.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btMonhoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMonhoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMonhoc.ForeColor = System.Drawing.Color.Ivory;
            this.btMonhoc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btMonhoc.Location = new System.Drawing.Point(0, 662);
            this.btMonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.btMonhoc.Name = "btMonhoc";
            this.btMonhoc.Size = new System.Drawing.Size(288, 95);
            this.btMonhoc.TabIndex = 11;
            this.btMonhoc.Text = "Quản lý Môn học";
            this.btMonhoc.UseVisualStyleBackColor = false;
            this.btMonhoc.Click += new System.EventHandler(this.btMonhoc_Click);
            // 
            // btQLDiem
            // 
            this.btQLDiem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btQLDiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQLDiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLDiem.ForeColor = System.Drawing.Color.Ivory;
            this.btQLDiem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btQLDiem.Location = new System.Drawing.Point(0, 264);
            this.btQLDiem.Margin = new System.Windows.Forms.Padding(4);
            this.btQLDiem.Name = "btQLDiem";
            this.btQLDiem.Size = new System.Drawing.Size(288, 88);
            this.btQLDiem.TabIndex = 8;
            this.btQLDiem.Text = "Quản lý điểm Sinh viên";
            this.btQLDiem.UseVisualStyleBackColor = false;
            this.btQLDiem.Click += new System.EventHandler(this.btQLDiem_Click);
            // 
            // btQLSV
            // 
            this.btQLSV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btQLSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQLSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLSV.ForeColor = System.Drawing.Color.Ivory;
            this.btQLSV.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btQLSV.Location = new System.Drawing.Point(0, 125);
            this.btQLSV.Margin = new System.Windows.Forms.Padding(4);
            this.btQLSV.Name = "btQLSV";
            this.btQLSV.Size = new System.Drawing.Size(288, 84);
            this.btQLSV.TabIndex = 7;
            this.btQLSV.Text = "QLSinh Viên";
            this.btQLSV.UseVisualStyleBackColor = false;
            this.btQLSV.Click += new System.EventHandler(this.btQLSV_Click);
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnGiangVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiangVien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiangVien.ForeColor = System.Drawing.Color.Ivory;
            this.btnGiangVien.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGiangVien.Location = new System.Drawing.Point(0, 797);
            this.btnGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(288, 95);
            this.btnGiangVien.TabIndex = 13;
            this.btnGiangVien.Text = "Quản lý Giảng Viên";
            this.btnGiangVien.UseVisualStyleBackColor = false;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1922, 858);
            this.Controls.Add(this.btnGiangVien);
            this.Controls.Add(this.btQLSV);
            this.Controls.Add(this.btQLDiem);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.btMonhoc);
            this.Controls.Add(this.btLop);
            this.Controls.Add(this.btNganh);
            this.ForeColor = System.Drawing.Color.Green;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN TRƯỜNG ĐẠI HỌC NGUYỄN TẤT THÀNH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripMenuItem mnuDN;
        public System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
        public System.Windows.Forms.ToolStripMenuItem mnuQuanlinguoidung;
        public System.Windows.Forms.ToolStripMenuItem mnuDX;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        public System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuThongtinSV;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        public System.Windows.Forms.Button btQLSV;
        public System.Windows.Forms.Button btQLDiem;
        public System.Windows.Forms.Button btMonhoc;
        public System.Windows.Forms.Button btLop;
        public System.Windows.Forms.Button btNganh;
        public System.Windows.Forms.Button btnGiangVien;
        private System.Windows.Forms.ToolStripMenuItem mnuDiemThiLai;
        private System.Windows.Forms.ToolStripMenuItem mnuDSSV;
        private System.Windows.Forms.ToolStripMenuItem mnuDiemTK;
        private System.Windows.Forms.ToolStripMenuItem thongtin;
        public System.Windows.Forms.ToolStripMenuItem mnuItemHethong;
        public System.Windows.Forms.ToolStripMenuItem mnItemQuanly;
        public System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        public System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
    }
}

