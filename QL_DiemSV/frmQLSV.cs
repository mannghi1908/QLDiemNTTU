using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemSV
{
    public partial class frmQLSV : Form
    {
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        SINHVIEN sv = new SINHVIEN();
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HienThiTTSV()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrDSSV.Rows.Clear();
            var dsSV = from x in context.SINHVIENs select new { x.MaSV, x.HoTen, x.NgaySinh, x.GioiTinh, x.DiaChi, x.MaLop };
            dgrDSSV.DataSource = dsSV;
        }
        private void HienThiCBONganh()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsNganh = (from x in context.NGANHs select x);
            //cboNganh.DisplayMember = "MaNganh";
            cboNganh.ValueMember = "TenNganh";
            cboNganh.DataSource = dsNganh;
        }
        private void HienThiCBOTenLop()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsLop = (from x in context.LOPs select x);
            cboTenLop.DisplayMember = "TenLop";
            //cboLop.ValueMember = "MaLop";
            cboTenLop.DataSource = dsLop;
        }
        private void HienThiCBOMaLop()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsMaLop = (from x in context.LOPs select x);
            cboMalop.DisplayMember = "MaLop";
            //cboLop.ValueMember = "MaLop";
            cboMalop.DataSource = dsMaLop;
        }
        private void frmQLSV_Load(object sender, EventArgs e)
        {
            HienThiTTSV();
            HienThiCBONganh();
            HienThiCBOTenLop();
            HienThiCBOMaLop();
        }

        private void dgrDSSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrDSSV.Rows[e.RowIndex];
            txtMaSV.Text = r.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
            //dtpNgaySinh.MinDate = DateTime.Now;
            //int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            //dtpNgaySinh.MaxDate= new DateTime(DateTime.Now.Year, DateTime.Now.Month,dayofmonth);
            dtpNgaySinh.Text = r.Cells["NgaySinh"].Value.ToString();
            cboGioiTinh.Text = r.Cells["GioiTinh"].Value.ToString();
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
            cboMalop.Text = r.Cells["MaLop"].Value.ToString();
            //cboNganh.Text = r.Cells["MaNganh"].Value.ToString();
            //cboTenLop.Text = r.Cells["TenLop"].Value.ToString();
         
          
           
           
            txtDiaChi.Text = r.Cells["DiaChi"].Value.ToString();
           
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text) && !string.IsNullOrEmpty(txtMaSV.Text))
            {
                sv.MaSV = txtMaSV.Text;
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value.Date;
                sv.GioiTinh = cboGioiTinh.Text;
                sv.DiaChi = txtDiaChi.Text;
                sv.MaLop = cboMalop.Text;
                db.SINHVIENs.InsertOnSubmit(sv);
                db.SubmitChanges();
                txtMaSV.Text = txtDiaChi.Text = txtHoTen.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiTTSV();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text) && !string.IsNullOrEmpty(txtMaSV.Text))
            {
                sv = db.SINHVIENs.Where(x => x.MaSV == txtMaSV.Text).Single();
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value.Date;
                sv.GioiTinh = cboGioiTinh.Text;
                sv.DiaChi = txtDiaChi.Text;
                sv.MaLop = cboMalop.Text;
                db.SubmitChanges();
                txtMaSV.Text = txtDiaChi.Text = txtHoTen.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiTTSV();
            }


            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtHoTen.Text) && !string.IsNullOrEmpty(txtMaSV.Text))
            {
                sv = db.SINHVIENs.Where(x => x.MaSV == txtMaSV.Text).Single();
                sv.HoTen = txtHoTen.Text;
                sv.NgaySinh = dtpNgaySinh.Value.Date;
                sv.GioiTinh = cboGioiTinh.Text;
                sv.DiaChi = txtDiaChi.Text;
                sv.MaLop = cboMalop.Text;
                db.SINHVIENs.DeleteOnSubmit(sv);
                db.SubmitChanges();
                txtMaSV.Text = txtDiaChi.Text = txtHoTen.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiTTSV();
            }


            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
