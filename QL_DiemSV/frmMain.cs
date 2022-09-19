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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool kiemtraform(string name)
        {
            bool check = false;
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void activeChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }
        private void btQLDiem_Click(object sender, EventArgs e)
        {
            if (!kiemtraform("frmQLDiem"))
            {
                frmQLDiem frm = new frmQLDiem();
                frm.MdiParent = this;
                frm.Name = "frmQLDiem";
                frm.Show();
            }
            else
            {
                activeChildForm("frmQLDiem");
            }
        }

        private void btQLSV_Click(object sender, EventArgs e)
        {
            if (!kiemtraform("frmQLSV"))
            {
                frmQLSV frm = new frmQLSV();
                frm.MdiParent = this;
                frm.Name = "frmQLSV";
                frm.Show();
            }
            else
            {
                activeChildForm("frmQLSV");
            }
        }

        private void frmM_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btNganh_Click(object sender, EventArgs e)
        {
            if (!kiemtraform("frmQLNganhHoc"))
            {
                frmQLNganhHoc frm = new frmQLNganhHoc();
                frm.MdiParent = this;
                frm.Name = "frmQLNganhHoc";
                frm.Show();
            }
            else
            {
                activeChildForm("frmQLNganhHoc");
            }
        }

        private void btLop_Click(object sender, EventArgs e)
        {
            if (!kiemtraform("frmLop"))
            {
                frmLop frm = new frmLop();
                frm.MdiParent = this;
                frm.Name = "frmLop";
                frm.Show();
            }
            else
            {
                activeChildForm("frmLop");
            }
        }

        private void btMonhoc_Click(object sender, EventArgs e)
        {
            if (!kiemtraform("frmMonhoc"))
            {
                frmMonhoc frm = new frmMonhoc();
                frm.MdiParent = this;
                frm.Name = "frmMonhoc";
                frm.Show();
            }
            else
            {
                activeChildForm("frmMonhoc");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuDiemThiLai_Click(object sender, EventArgs e)
        {
            frmQLThiLai frm = new frmQLThiLai();
            frm.ShowDialog();

        }

        private void thongtin_Click(object sender, EventArgs e)
        {
            frmLienhe frm = new frmLienhe();
            frm.ShowDialog();
        }

        private void mnuThongtinSV_Click(object sender, EventArgs e)
        {
            frmTimKiemSV frm = new frmTimKiemSV();
            frm.ShowDialog();
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            frmGiangVien frm = new frmGiangVien();
            frm.ShowDialog();
        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void mnuDN_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void mnuDX_Click(object sender, EventArgs e)
        {
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
            this.Hide();
            //mnuDN.Enabled = true;
            //mnuQuanly.Enabled = mnuTimKiem.Enabled = mnuThongKe.Enabled = mnuTroGiup.Enabled = false;
          
            
        }

        private void mnItemQuanly_Click(object sender, EventArgs e)
        {

        }

        private void mnuDiemThiLai_Click_1(object sender, EventArgs e)
        {
            frmQLThiLai frm = new frmQLThiLai();
            frm.Show();
        }

        private void thongtin_Click_1(object sender, EventArgs e)
        {
            frmLienhe frm = new frmLienhe();
            frm.Show();
        }

        private void mnuQuanlinguoidung_Click(object sender, EventArgs e)
        {
            frmQuanLyNguoiDung frm = new frmQuanLyNguoiDung();
            frm.Show();
        }

        private void mnuDSSV_Click(object sender, EventArgs e)
        {
            frmTKDSSV frm = new frmTKDSSV();
            frm.ShowDialog();
        }

        private void mnuDiemTK_Click(object sender, EventArgs e)
        {
            frmThongKeDiemSV frm = new frmThongKeDiemSV();
            frm.ShowDialog();
        }
    }
}
