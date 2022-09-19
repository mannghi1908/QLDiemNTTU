
namespace QL_DiemSV
{
    partial class frmQLDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLDiem));
            this.btnXuat = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrDiem = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HanhKiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDiemTH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDiemLT = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboHanhKiem = new System.Windows.Forms.ComboBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDiemTK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboHocKi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.picDN = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnXuat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.Color.Teal;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(1213, 683);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(227, 69);
            this.btnXuat.TabIndex = 22;
            this.btnXuat.Text = "In Bảng Điểm";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1213, 491);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(227, 66);
            this.button4.TabIndex = 21;
            this.button4.Text = "Thoát ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SandyBrown;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Teal;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(1213, 400);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(227, 65);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Teal;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(1213, 306);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(227, 66);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.Color.SandyBrown;
            this.btnNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhap.ForeColor = System.Drawing.Color.Teal;
            this.btnNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnNhap.Image")));
            this.btnNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhap.Location = new System.Drawing.Point(1213, 218);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(227, 64);
            this.btnNhap.TabIndex = 18;
            this.btnNhap.Text = "Thêm";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox4.Controls.Add(this.dgrDiem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 422);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1181, 332);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách";
            // 
            // dgrDiem
            // 
            this.dgrDiem.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.HoTen,
            this.MaLop,
            this.MaMH,
            this.DiemLT,
            this.DiemTH,
            this.DiemThi,
            this.DiemTK,
            this.HanhKiem,
            this.HocKy,
            this.GhiChu});
            this.dgrDiem.Location = new System.Drawing.Point(10, 27);
            this.dgrDiem.Name = "dgrDiem";
            this.dgrDiem.RowHeadersWidth = 51;
            this.dgrDiem.Size = new System.Drawing.Size(1156, 286);
            this.dgrDiem.TabIndex = 0;
            this.dgrDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrDiem_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 200;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã Lớp";
            this.MaLop.MinimumWidth = 6;
            this.MaLop.Name = "MaLop";
            this.MaLop.Width = 125;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 140;
            // 
            // DiemLT
            // 
            this.DiemLT.DataPropertyName = "DiemLT";
            this.DiemLT.HeaderText = "Điểm LT";
            this.DiemLT.MinimumWidth = 6;
            this.DiemLT.Name = "DiemLT";
            this.DiemLT.Width = 60;
            // 
            // DiemTH
            // 
            this.DiemTH.DataPropertyName = "DiemTH";
            this.DiemTH.HeaderText = "Điểm TH";
            this.DiemTH.MinimumWidth = 6;
            this.DiemTH.Name = "DiemTH";
            this.DiemTH.Width = 60;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm Thi";
            this.DiemThi.MinimumWidth = 6;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Width = 60;
            // 
            // DiemTK
            // 
            this.DiemTK.DataPropertyName = "DiemTK";
            this.DiemTK.HeaderText = "Điểm TK";
            this.DiemTK.MinimumWidth = 6;
            this.DiemTK.Name = "DiemTK";
            this.DiemTK.Width = 60;
            // 
            // HanhKiem
            // 
            this.HanhKiem.DataPropertyName = "HanhKiem";
            this.HanhKiem.HeaderText = "Hạnh Kiểm";
            this.HanhKiem.MinimumWidth = 6;
            this.HanhKiem.Name = "HanhKiem";
            this.HanhKiem.Width = 90;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.Width = 50;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox3.Controls.Add(this.txtGhiChu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(738, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 151);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(6, 25);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(443, 96);
            this.txtGhiChu.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.txtDiemTH);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDiemLT);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboHanhKiem);
            this.groupBox2.Controls.Add(this.txtDiemThi);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtDiemTK);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtMaSV);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1181, 162);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // txtDiemTH
            // 
            this.txtDiemTH.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTH.Location = new System.Drawing.Point(468, 100);
            this.txtDiemTH.Name = "txtDiemTH";
            this.txtDiemTH.Size = new System.Drawing.Size(87, 34);
            this.txtDiemTH.TabIndex = 27;
            this.txtDiemTH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemTH_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(276, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "Điểm thực hành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Điểm lí thuyết";
            // 
            // txtDiemLT
            // 
            this.txtDiemLT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLT.Location = new System.Drawing.Point(161, 100);
            this.txtDiemLT.Name = "txtDiemLT";
            this.txtDiemLT.Size = new System.Drawing.Size(87, 34);
            this.txtDiemLT.TabIndex = 8;
            this.txtDiemLT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemLT_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(903, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 25);
            this.label13.TabIndex = 23;
            this.label13.Text = "Hạnh kiểm";
            // 
            // cboHanhKiem
            // 
            this.cboHanhKiem.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHanhKiem.FormattingEnabled = true;
            this.cboHanhKiem.Items.AddRange(new object[] {
            "Kém",
            "Yếu",
            "Trung bình",
            "Khá ",
            "Tốt"});
            this.cboHanhKiem.Location = new System.Drawing.Point(1040, 40);
            this.cboHanhKiem.Name = "cboHanhKiem";
            this.cboHanhKiem.Size = new System.Drawing.Size(126, 34);
            this.cboHanhKiem.TabIndex = 7;
            this.cboHanhKiem.Text = "Tốt";
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi.Location = new System.Drawing.Point(747, 100);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(83, 34);
            this.txtDiemThi.TabIndex = 9;
            this.txtDiemThi.TextChanged += new System.EventHandler(this.txtDiemThi_TextChanged);
            this.txtDiemThi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemThi_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(626, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 20;
            this.label12.Text = "Điểm thi ";
            // 
            // txtDiemTK
            // 
            this.txtDiemTK.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemTK.Location = new System.Drawing.Point(1040, 102);
            this.txtDiemTK.Name = "txtDiemTK";
            this.txtDiemTK.ReadOnly = true;
            this.txtDiemTK.Size = new System.Drawing.Size(126, 34);
            this.txtDiemTK.TabIndex = 11;
            this.txtDiemTK.TextChanged += new System.EventHandler(this.txtDiemTK_TextChanged);
            this.txtDiemTK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiemTK_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(884, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm tổng kết";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(506, 40);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(379, 34);
            this.txtHoTen.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(392, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Họ và tên";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSV.Location = new System.Drawing.Point(161, 41);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(222, 34);
            this.txtMaSV.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(2, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã sinh viên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboHocKi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 151);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(117, 87);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(562, 34);
            this.cboMonHoc.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Môn học";
            // 
            // cboHocKi
            // 
            this.cboHocKi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHocKi.FormattingEnabled = true;
            this.cboHocKi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cboHocKi.Location = new System.Drawing.Point(550, 33);
            this.cboHocKi.Name = "cboHocKi";
            this.cboHocKi.Size = new System.Drawing.Size(129, 34);
            this.cboHocKi.TabIndex = 3;
            this.cboHocKi.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(438, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Học kì";
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(117, 33);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(278, 34);
            this.cboLop.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(451, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "THÔNG TIN ĐIỂM SINH VIÊN ";
            // 
            // btnLamLai
            // 
            this.btnLamLai.BackColor = System.Drawing.Color.SandyBrown;
            this.btnLamLai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamLai.ForeColor = System.Drawing.Color.Teal;
            this.btnLamLai.Image = ((System.Drawing.Image)(resources.GetObject("btnLamLai.Image")));
            this.btnLamLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamLai.Location = new System.Drawing.Point(1213, 586);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(227, 66);
            this.btnLamLai.TabIndex = 23;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = false;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // picDN
            // 
            this.picDN.Image = ((System.Drawing.Image)(resources.GetObject("picDN.Image")));
            this.picDN.InitialImage = null;
            this.picDN.Location = new System.Drawing.Point(1199, 6);
            this.picDN.Name = "picDN";
            this.picDN.Size = new System.Drawing.Size(249, 194);
            this.picDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDN.TabIndex = 35;
            this.picDN.TabStop = false;
            // 
            // frmQLDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1452, 766);
            this.Controls.Add(this.picDN);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQLDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLDiem";
            this.Load += new System.EventHandler(this.frmQLDiem_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrDiem)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgrDiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDiemLT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboHanhKiem;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDiemTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboHocKi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiemTH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn HanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        public System.Windows.Forms.Button btnXuat;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.Button btnNhap;
        public System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.PictureBox picDN;
    }
}