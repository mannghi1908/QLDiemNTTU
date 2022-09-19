
namespace QL_DiemSV
{
    partial class frmThongKeDiemSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDiemSV));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picDN = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.rptDiemSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInBaoCao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picDN);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1413, 173);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(468, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 49);
            this.label1.TabIndex = 32;
            this.label1.Text = "DANH SÁCH ĐIỂM SINH VIÊN";
            // 
            // picDN
            // 
            this.picDN.Image = ((System.Drawing.Image)(resources.GetObject("picDN.Image")));
            this.picDN.InitialImage = null;
            this.picDN.Location = new System.Drawing.Point(-4, 11);
            this.picDN.Name = "picDN";
            this.picDN.Size = new System.Drawing.Size(270, 156);
            this.picDN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDN.TabIndex = 31;
            this.picDN.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SandyBrown;
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Teal;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(1200, 101);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(213, 66);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // rptDiemSV
            // 
            this.rptDiemSV.ActiveViewIndex = -1;
            this.rptDiemSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptDiemSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptDiemSV.Location = new System.Drawing.Point(1, 177);
            this.rptDiemSV.Name = "rptDiemSV";
            this.rptDiemSV.Size = new System.Drawing.Size(1406, 514);
            this.rptDiemSV.TabIndex = 34;
            this.rptDiemSV.Load += new System.EventHandler(this.rptDiemSV_Load);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.SandyBrown;
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Teal;
            this.btnInBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnInBaoCao.Image")));
            this.btnInBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBaoCao.Location = new System.Drawing.Point(1200, 21);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(213, 66);
            this.btnInBaoCao.TabIndex = 33;
            this.btnInBaoCao.Text = "In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click_1);
            // 
            // frmThongKeDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1419, 703);
            this.Controls.Add(this.rptDiemSV);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeDiemSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ DANH SÁCH ĐIỂM SINH VIÊN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDN;
        private System.Windows.Forms.Button btnThoat;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptDiemSV;
        private System.Windows.Forms.Button btnInBaoCao;
    }
}