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
    public partial class frmQLNganhHoc : Form
    {
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        NGANH ng = new NGANH();

        public frmQLNganhHoc()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HienThiNgangHoc()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrNganh.Rows.Clear();
            var dsNganh = from x in context.NGANHs select x;
            dgrNganh.DataSource = dsNganh;
            cboNganh.DisplayMember = "MaNganh";
            //cboLop.ValueMember = "MaLop";
            cboNganh.DataSource = dsNganh;
        }
        private void dgrNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrNganh.Rows[e.RowIndex];
            cboNganh.Text = r.Cells["MaNganh"].Value.ToString();
            txtTenNganh.Text = r.Cells["TenNganh"].Value.ToString();

        }
        private void frmQLNganhHoc_Load(object sender, EventArgs e)
        {
            HienThiNgangHoc();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNganh.Text))
            {
                ng.MaNganh = cboNganh.Text;
                ng.TenNganh = txtTenNganh.Text;
                db.NGANHs.InsertOnSubmit(ng);
                db.SubmitChanges();
                txtTenNganh.Text = "";
                txtTenNganh.Focus();
                MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiNgangHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNganh.Text))
            {
                ng = db.NGANHs.Where(x => x.MaNganh == cboNganh.Text).Single();       
                ng.TenNganh = txtTenNganh.Text;
                db.SubmitChanges();
                txtTenNganh.Text = "";
                txtTenNganh.Focus();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiNgangHoc();
            }


            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenNganh.Text))
            {
                ng = db.NGANHs.Where(x => x.MaNganh == cboNganh.Text).Single();
                ng.TenNganh = txtTenNganh.Text;
                db.NGANHs.DeleteOnSubmit(ng);
                db.SubmitChanges();
                txtTenNganh.Text = "";
                txtTenNganh.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiNgangHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgrNganh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
