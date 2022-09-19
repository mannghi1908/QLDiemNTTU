using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemSV
{
    public partial class frmQuanLyNguoiDung : Form
    {
        public frmQuanLyNguoiDung()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        LOGIN lg = new LOGIN();
        private void HienThiTT()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgvQLNguoiDung.Rows.Clear();
            var dsNguoidung = from x in context.LOGINs select x;
            dgvQLNguoiDung.DataSource = dsNguoidung;
        }
        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        private void dgvQLNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvQLNguoiDung.Rows[e.RowIndex];
            txtTaikhoan.Text = r.Cells["TenDN"].Value.ToString();
            txtMatKhau.Text = r.Cells["MatKhau"].Value.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
            cboGioiTinh.Text = r.Cells["GioiTinh"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            cboQuyen.Text = r.Cells["Quyen"].Value.ToString();
        }
        private void frmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            HienThiTT();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                lg = db.LOGINs.Where(s => s.TenDN == txtTaikhoan.Text).Single();
                lg.MatKhau = txtMatKhau.Text;
                lg.HoTen = txtHoTen.Text;
                lg.GioiTinh = cboGioiTinh.Text;
                if (!IsEmail(txtEmail.Text))
                {
                    MessageBox.Show("Nhập sai email!!!", "Nhập lại");
                }
                else
                {
                    lg.Email = txtEmail.Text;
                    lg.Quyen = cboQuyen.Text;
                    db.LOGINs.InsertOnSubmit(lg);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmQuanLyNguoiDung_Load(sender, e);
                }    
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                lg = db.LOGINs.Where(s => s.TenDN == txtTaikhoan.Text).Single();
                lg.MatKhau = txtMatKhau.Text;
                lg.HoTen = txtHoTen.Text;
                lg.GioiTinh = cboGioiTinh.Text;
                lg.Email = txtEmail.Text;
                lg.Quyen = cboQuyen.Text;
                db.SubmitChanges();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLyNguoiDung_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaikhoan.Text))
            
            {
                var dangnhap = db.LOGINs.SingleOrDefault(lg => lg.TenDN == txtTaikhoan.Text);
                db.LOGINs.DeleteOnSubmit(dangnhap);
                db.SubmitChanges();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmQuanLyNguoiDung_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnlamLai_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = txtMatKhau.Text = txtHoTen.Text = cboGioiTinh.Text = txtEmail.Text = cboQuyen.Text = "";
            txtTaikhoan.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvQLNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
