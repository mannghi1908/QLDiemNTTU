
namespace QL_DiemSV
{
    partial class frmMonhoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonhoc));
            this.button4 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgrMON = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picDN = new System.Windows.Forms.PictureBox();
            this.cboNganh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaMon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Teal;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(1065, 454);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 72);
            this.button4.TabIndex = 19;
            this.button4.Text = "   Thoát ";
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
            this.btnXoa.Location = new System.Drawing.Point(1065, 358);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 69);
            this.btnXoa.TabIndex = 18;
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
            this.btnSua.Location = new System.Drawing.Point(1065, 261);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(170, 67);
            this.btnSua.TabIndex = 17;
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
            this.btnNhap.Location = new System.Drawing.Point(1065, 154);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(170, 72);
            this.btnNhap.TabIndex = 16;
            this.btnNhap.Text = "Thêm";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.dgrMON);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(475, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 541);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dgrMON
            // 
            this.dgrMON.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgrMON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrMON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.GiangVien,
            this.HocKy,
            this.MaNganh,
            this.TinChi});
            this.dgrMON.Location = new System.Drawing.Point(9, 27);
            this.dgrMON.Name = "dgrMON";
            this.dgrMON.RowHeadersWidth = 51;
            this.dgrMON.Size = new System.Drawing.Size(553, 508);
            this.dgrMON.TabIndex = 0;
            this.dgrMON.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMON_CellClick);
            this.dgrMON.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrMON_CellContentClick);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã MH";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 90;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên MH";
            this.TenMH.MinimumWidth = 300;
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 350;
            // 
            // GiangVien
            // 
            this.GiangVien.DataPropertyName = "GiangVien";
            this.GiangVien.HeaderText = "Giảng Viên";
            this.GiangVien.MinimumWidth = 6;
            this.GiangVien.Name = "GiangVien";
            this.GiangVien.Width = 220;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.Width = 60;
            // 
            // MaNganh
            // 
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã Ngành";
            this.MaNganh.MinimumWidth = 6;
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Width = 60;
            // 
            // TinChi
            // 
            this.TinChi.DataPropertyName = "TinChi";
            this.TinChi.HeaderText = "Tín Chỉ";
            this.TinChi.MinimumWidth = 6;
            this.TinChi.Name = "TinChi";
            this.TinChi.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.txtTinChi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picDN);
            this.groupBox1.Controls.Add(this.cboNganh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenMon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaMon);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(438, 541);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtTinChi
            // 
            this.txtTinChi.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinChi.Location = new System.Drawing.Point(141, 297);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.Size = new System.Drawing.Size(290, 34);
            this.txtTinChi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tín Chỉ";
            // 
            // picDN
            // 
            this.picDN.Image = ((System.Drawing.Image)(resources.GetObject("picDN.Image")));
            this.picDN.InitialImage = null;
            this.picDN.Location = new System.Drawing.Point(0, 337);
            this.picDN.Name = "picDN";
            this.picDN.Size = new System.Drawing.Size(431, 203);
            this.picDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDN.TabIndex = 24;
            this.picDN.TabStop = false;
            // 
            // cboNganh
            // 
            this.cboNganh.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNganh.FormattingEnabled = true;
            this.cboNganh.Location = new System.Drawing.Point(141, 248);
            this.cboNganh.Name = "cboNganh";
            this.cboNganh.Size = new System.Drawing.Size(290, 34);
            this.cboNganh.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 26);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã ngành";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Location = new System.Drawing.Point(141, 198);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(290, 34);
            this.txtHocKy.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Học kỳ";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaGV.Location = new System.Drawing.Point(141, 144);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(290, 34);
            this.txtMaGV.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã GV";
            // 
            // txtTenMon
            // 
            this.txtTenMon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(141, 93);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.Size = new System.Drawing.Size(290, 34);
            this.txtTenMon.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên môn";
            // 
            // txtMaMon
            // 
            this.txtMaMon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMon.Location = new System.Drawing.Point(141, 41);
            this.txtMaMon.Name = "txtMaMon";
            this.txtMaMon.Size = new System.Drawing.Size(290, 34);
            this.txtMaMon.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 26);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mã môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(393, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 49);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH MÔN HỌC";
            // 
            // frmMonhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1260, 634);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMonhoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH MÔN HỌC";
            this.Load += new System.EventHandler(this.frmMonhoc_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrMON)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrMON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboNganh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHocKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDN;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNganh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinChi;
    }
}