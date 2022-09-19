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
    public partial class frmMonhoc : Form
    {
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        MONHOC mh = new MONHOC();
        public frmMonhoc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HienThiMonHoc()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrMON.Rows.Clear();
            var dsMon = from x in context.MONHOCs select x;
            dgrMON.DataSource = dsMon;
        }
        private void HienThiNgangHoc()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsNganh = from x in context.NGANHs select x;
            cboNganh.DisplayMember = "TenNganh";
            //cboLop.ValueMember = "MaLop";
            cboNganh.DataSource = dsNganh;
        }
        private void frmMonhoc_Load(object sender, EventArgs e)
        {
            HienThiMonHoc();
            HienThiNgangHoc();
        }

        private void dgrMON_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrMON.Rows[e.RowIndex];
            txtMaMon.Text = r.Cells["MaMH"].Value.ToString();
            txtTenMon.Text = r.Cells["TenMH"].Value.ToString();
            txtMaGV.Text = r.Cells["MaGV"].Value.ToString();
            txtHocKy.Text = r.Cells["HocKy"].Value.ToString();
            cboNganh.Text = r.Cells["MaNganh"].Value.ToString();
            txtTinChi.Text = r.Cells["TinChi"].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtMaMon.Text) && !string.IsNullOrEmpty(txtTenMon.Text))
            {
                mh.MaMH = txtMaMon.Text;
                mh.TenMH = txtTenMon.Text;
                mh.MaGV = txtMaGV.Text;
                mh.HocKy = txtHocKy.Text;
                mh.MaNganh = cboNganh.Text;
                mh.TinChi = txtTinChi.Text;
                db.MONHOCs.InsertOnSubmit(mh);
                db.SubmitChanges();
                txtMaMon.Text = txtTenMon.Text = txtMaGV.Text = txtHocKy.Text = txtTinChi.Text = "";
                txtMaMon.Focus();
                MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaMon.Text))
            {
                mh = db.MONHOCs.Where(x => x.MaMH == txtMaMon.Text).Single();
                mh.TenMH = txtTenMon.Text;
                mh.MaGV = txtMaGV.Text;
                mh.HocKy = txtHocKy.Text;
                mh.MaNganh = cboNganh.Text;
                mh.TinChi = txtTinChi.Text;
                db.SubmitChanges();
                txtMaMon.Text = txtTenMon.Text = txtMaGV.Text = txtHocKy.Text = txtTinChi.Text = "";
                txtMaMon.Focus();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaMon.Text))
            {
                mh = db.MONHOCs.Where(x => x.MaMH == txtMaMon.Text).Single();
                mh.TenMH = txtTenMon.Text;
                mh.MaGV = txtMaGV.Text;
                mh.HocKy = txtHocKy.Text;
                mh.MaNganh = cboNganh.Text;
                mh.TinChi = txtTinChi.Text;
                db.MONHOCs.DeleteOnSubmit(mh);
                db.SubmitChanges();
                txtMaMon.Text = txtTenMon.Text = txtMaGV.Text = txtHocKy.Text = txtTinChi.Text = "";
                txtMaMon.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgrMON_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
