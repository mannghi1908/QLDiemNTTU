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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        LOP lp = new LOP();
        public void HienThiLop()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrLop.Rows.Clear();
            var dsLop = from x in context.LOPs select new { x.MaLop, x.TenLop, x.MaNganh };
            dgrLop.DataSource = dsLop;      
        }
        private void HienThiCBONganh()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsNganh = (from x in context.NGANHs select x);
            cboNganh.DisplayMember = "MaNganh";
            cboNganh.ValueMember = "TenNganh";
            cboNganh.DataSource = dsNganh.ToList();
            
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            HienThiLop();
            HienThiCBONganh();
        }

        private void cboKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgrLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
            
        }

        private void dgrLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrLop.Rows[e.RowIndex];
            txtMaLop.Text = r.Cells["MaLop"].Value.ToString();
            txtTenlop.Text = r.Cells["TenLop"].Value.ToString();
            cboNganh.Text = r.Cells["MaNganh"].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
         
            if (!string.IsNullOrEmpty(txtMaLop.Text) && !string.IsNullOrEmpty(txtTenlop.Text))
            {
                lp.MaLop = txtMaLop.Text;
                lp.TenLop = txtTenlop.Text;
                lp.MaNganh = cboNganh.Text;
                db.LOPs.InsertOnSubmit(lp);
                db.SubmitChanges();
                txtMaLop.Text = txtTenlop.Text = "";
                txtMaLop.Focus();
                MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLop();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(txtTenlop.Text))
            {
                lp = db.LOPs.Where(x => x.MaLop == txtMaLop.Text).Single();
                //lp.MaLop = txtMaLop.Text;
                lp.TenLop = txtTenlop.Text;
                lp.MaNganh = cboNganh.Text;
                db.SubmitChanges();
                txtMaLop.Text = txtTenlop.Text = "";
                txtMaLop.Focus();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLop(); 
            }

              
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTenlop.Text))
            {
                lp = db.LOPs.Where(x => x.MaLop == txtMaLop.Text).Single();
                //lp.MaLop = txtMaLop.Text;
                lp.TenLop = txtTenlop.Text;
                lp.MaNganh = cboNganh.Text;
                db.LOPs.DeleteOnSubmit(lp);
                db.SubmitChanges();
                txtMaLop.Text = txtTenlop.Text = "";
                txtMaLop.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiLop();
            }


            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
