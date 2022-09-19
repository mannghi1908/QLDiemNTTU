
namespace QL_DiemSV
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskSDT = new System.Windows.Forms.MaskedTextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.cboPhanloai = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgrGiangVien = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhanLoaiGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(490, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 49);
            this.label1.TabIndex = 14;
            this.label1.Text = "THÔNG TIN GIẢNG VIÊN ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.btnAnh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.picAnh);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.mskSDT);
            this.groupBox2.Controls.Add(this.cboGioiTinh);
            this.groupBox2.Controls.Add(this.cboPhanloai);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtHoTenGV);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 81);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(435, 618);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            // 
            // btnAnh
            // 
            this.btnAnh.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAnh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnh.ForeColor = System.Drawing.Color.Teal;
            this.btnAnh.Image = ((System.Drawing.Image)(resources.GetObject("btnAnh.Image")));
            this.btnAnh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnh.Location = new System.Drawing.Point(107, 554);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(196, 56);
            this.btnAnh.TabIndex = 31;
            this.btnAnh.Text = "Chọn ảnh";
            this.btnAnh.UseVisualStyleBackColor = false;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 279);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Phân loại";
            // 
            // picAnh
            // 
            this.picAnh.Image = ((System.Drawing.Image)(resources.GetObject("picAnh.Image")));
            this.picAnh.Location = new System.Drawing.Point(81, 328);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(266, 201);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 30;
            this.picAnh.TabStop = false;
            this.picAnh.Click += new System.EventHandler(this.picAnh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "SĐT";
            // 
            // mskSDT
            // 
            this.mskSDT.BackColor = System.Drawing.SystemColors.Window;
            this.mskSDT.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskSDT.Location = new System.Drawing.Point(168, 187);
            this.mskSDT.Mask = "9990000000";
            this.mskSDT.Name = "mskSDT";
            this.mskSDT.Size = new System.Drawing.Size(260, 34);
            this.mskSDT.TabIndex = 27;
            this.mskSDT.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskSDT_MaskInputRejected);
            this.mskSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskSDT_KeyPress);
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.SystemColors.Window;
            this.cboGioiTinh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboGioiTinh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGioiTinh.ForeColor = System.Drawing.Color.DarkGreen;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cboGioiTinh.Location = new System.Drawing.Point(167, 141);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(262, 34);
            this.cboGioiTinh.TabIndex = 4;
            this.cboGioiTinh.Text = "Nam";
            // 
            // cboPhanloai
            // 
            this.cboPhanloai.BackColor = System.Drawing.SystemColors.Window;
            this.cboPhanloai.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPhanloai.ForeColor = System.Drawing.Color.DarkGreen;
            this.cboPhanloai.FormattingEnabled = true;
            this.cboPhanloai.Items.AddRange(new object[] {
            "Thạc Sĩ",
            "Tiến Sĩ"});
            this.cboPhanloai.Location = new System.Drawing.Point(167, 274);
            this.cboPhanloai.Margin = new System.Windows.Forms.Padding(4);
            this.cboPhanloai.Name = "cboPhanloai";
            this.cboPhanloai.Size = new System.Drawing.Size(262, 34);
            this.cboPhanloai.TabIndex = 6;
            this.cboPhanloai.Text = "Thạc Sĩ";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtEmail.Location = new System.Drawing.Point(167, 231);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 34);
            this.txtEmail.TabIndex = 5;
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.BackColor = System.Drawing.SystemColors.Window;
            this.txtHoTenGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenGV.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtHoTenGV.Location = new System.Drawing.Point(167, 91);
            this.txtHoTenGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(262, 34);
            this.txtHoTenGV.TabIndex = 2;
            // 
            // txtMaGV
            // 
            this.txtMaGV.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtMaGV.Location = new System.Drawing.Point(167, 42);
            this.txtMaGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(262, 34);
            this.txtMaGV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-1, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã GV";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.dgrGiangVien);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkGreen;
            this.groupBox1.Location = new System.Drawing.Point(466, 81);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(729, 618);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách";
            // 
            // dgrGiangVien
            // 
            this.dgrGiangVien.BackgroundColor = System.Drawing.Color.White;
            this.dgrGiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrGiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.TenGV,
            this.GioiTinh,
            this.Phone,
            this.Email,
            this.PhanLoaiGV});
            this.dgrGiangVien.Location = new System.Drawing.Point(8, 35);
            this.dgrGiangVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgrGiangVien.Name = "dgrGiangVien";
            this.dgrGiangVien.RowHeadersWidth = 51;
            this.dgrGiangVien.Size = new System.Drawing.Size(713, 575);
            this.dgrGiangVien.TabIndex = 0;
            this.dgrGiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrGiangVien_CellClick);
            this.dgrGiangVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrGiangVien_CellContentClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            this.MaGV.Width = 125;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Họ Tên";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 250;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 80;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "SĐT";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 200;
            // 
            // PhanLoaiGV
            // 
            this.PhanLoaiGV.DataPropertyName = "PhanLoaiGV";
            this.PhanLoaiGV.HeaderText = "Phân Loại";
            this.PhanLoaiGV.MinimumWidth = 6;
            this.PhanLoaiGV.Name = "PhanLoaiGV";
            this.PhanLoaiGV.Width = 125;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1213, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 66);
            this.button4.TabIndex = 29;
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
            this.btnXoa.Location = new System.Drawing.Point(1213, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(196, 65);
            this.btnXoa.TabIndex = 28;
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
            this.btnSua.Location = new System.Drawing.Point(1213, 280);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(196, 66);
            this.btnSua.TabIndex = 27;
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
            this.btnNhap.Location = new System.Drawing.Point(1213, 192);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(196, 64);
            this.btnNhap.TabIndex = 26;
            this.btnNhap.Text = "Thêm";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1421, 712);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiangVien";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskSDT;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboPhanloai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.DataGridView dgrGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhanLoaiGV;
        private System.Windows.Forms.Button btnAnh;
    }
}