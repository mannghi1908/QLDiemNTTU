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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool KTDN()
        {
            var dn = from x in db.LOGINs
                     where x.MatKhau == txtMatKhau.Text && x.TenDN == txtTenDN.Text
                     select x;
            if (dn.Any())

            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool KTDNAdmin()
        {
            QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
            var dn = from x in db.LOGINs
                     where x.MatKhau == txtMatKhau.Text && x.TenDN == txtTenDN.Text
                     && x.Quyen == "Admin"
                     select x.Quyen;
            if (dn.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool KTDNMember()
        {
            QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
            var dn = from x in db.LOGINs
                     where x.MatKhau == txtMatKhau.Text
                     && x.Quyen == "Member"
                     select x;
            if (dn.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnDangNhap_Click(object sender, EventArgs e) 
        {
            if (!KTDN())
            {
                MessageBox.Show("Đăng nhập không thành công !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
                txtTenDN.Clear();
                txtTenDN.Focus();
            }
            else if (KTDNAdmin() || !KTDNMember())
            {
                //MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                frmMain frm = new frmMain();
                frm.Show();
                frm.mnuDN.Enabled = false;
                frm.mnuTimKiem.Enabled = true;
                this.Hide();

            }
            else //if (!KTDNAdmin() || !KTDNMember())
            {
                //MessageBox.Show("Đăng nhập vào hệ thống !", "Thông báo !");
                frmMain frm = new frmMain();
                frm.Show();
                frm.mnuDN.Enabled = frm.mnuQuanlinguoidung.Enabled = frm.mnItemQuanly.Enabled = frm.mnuThongKe.Enabled= false;
                frm.btnGiangVien.Enabled = frm.btLop.Enabled = frm.btMonhoc.Enabled = 
                frm.btQLSV.Enabled = frm.btNganh.Enabled = frm.btQLDiem.Enabled = false;
                frmQLDiem qlsv = new frmQLDiem();
                qlsv.Show();
                qlsv.btnNhap.Enabled = qlsv.btnXoa.Enabled = qlsv.btnSua.Enabled = qlsv.btnLamLai.Enabled = qlsv.btnXuat.Enabled= false;
                this.Hide();
            }

        }

        private void txtTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhau.Focus();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(this, new EventArgs());
            }

        }
    }
}
