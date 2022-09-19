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
    public partial class frmTimKiemSV : Form
    {
        public frmTimKiemSV()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
        private void HienThiDiemThiLai()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrDIEMSV.Rows.Clear();
            var dsDiemSV = from x in context.DIEMTHIs select new
                               {
                                   x.MaSV,
                                   x.HoTen,
                                   x.MaLop,
                                   x.MaMH,
                                   x.DiemLT,
                                   x.DiemTH,
                                   x.DiemThi,
                                   x.DiemTK,
                                   x.HanhKiem,
                                   x.HocKy,
                                   x.GhiChu,

                               };
            dgrDIEMSV.DataSource = dsDiemSV;
        }
        //private void HienThiCBOMonHoc()
        //{
        //    QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
        //    var dsMH = (from x in context.MONHOCs select x);
        //    cboMonHoc.DisplayMember = "TenMH";
        //    //cboNganh.ValueMember = "MaMH";
        //    cboMonHoc.DataSource = dsMH;
        //}
        private void HienThiCBONganh()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsNganh = (from x in context.NGANHs select x);
            //cboNganh.DisplayMember = "TenNganh";
            cboNganh.ValueMember = "MaNganh";
            cboNganh.DataSource = dsNganh;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimKiemSV_Load(object sender, EventArgs e)
        {
            HienThiDiemThiLai();
            //HienThiCBOMonHoc();
            HienThiCBONganh();
        }

        private void txtMaSV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var Lst = (from x in context.DIEMTHIs 
                       where  x.MaSV.Contains(txtMaSV.Text) 
                       select new
                       {
                           x.MaSV,
                           x.HoTen,
                           x.MaLop,
                           x.MaMH,
                           x.DiemLT,
                           x.DiemTH,
                           x.DiemThi,
                           x.DiemTK,
                           x.HanhKiem,
                           x.HocKy,
                           x.GhiChu,

                       }).ToList();
            dgrDIEMSV.DataSource = Lst;
            txtMaSV.DataBindings.Clear();
            cboNganh.DataBindings.Clear();
            txtMH.DataBindings.Clear();
            txtMaSV.DataBindings.Add("text", Lst, "MaSV");
            //txtMH.DataBindings.Add("text", Lst, "MaMH");
            //cboMonHoc.DataBindings.Add("text", Lst, "MaMH");
        }

        private void dgrDIEMSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrDIEMSV.Rows[e.RowIndex];
            txtMaSV.Text = r.Cells["MaSV"].Value.ToString();
            txtMH.Text = r.Cells["MaMH"].Value.ToString();
        }

        private void txtMaSV_KeyUp(object sender, KeyEventArgs e)
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var Lst = (from x in context.DIEMTHIs
                       where (x.MaSV == txtMaSV.Text)
                       select new
                       {
                           x.MaSV, x.HoTen, x.MaLop, x.MaMH, x.DiemLT, x.DiemTH, x.DiemThi, x.DiemTK, x.HanhKiem, x.HocKy, x.GhiChu
                       }).ToList();
            dgrDIEMSV.DataSource = Lst;
            txtMaSV.DataBindings.Clear();
            cboNganh.DataBindings.Clear();
            txtMH.DataBindings.Clear();
            txtMaSV.DataBindings.Add("text", Lst, "MaSV");
            //txtMH.DataBindings.Add("text", Lst, "MaMH");
            //cboMonHoc.DataBindings.Add("text", Lst, "MaMH");
        }
    }
}
