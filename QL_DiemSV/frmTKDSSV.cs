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
    public partial class frmTKDSSV : Form
    {
        public frmTKDSSV()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        SINHVIEN sv = new SINHVIEN();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            var dsSV = from x in db.SINHVIENs select new { x.MaSV, x.HoTen, x.NgaySinh, x.GioiTinh, x.DiaChi, x.MaLop };
            CrystalReport1 r = new CrystalReport1();
            r.SetDataSource(dsSV);
            rptDSSV.ReportSource = r;
        }

        private void rptDSSV_Load(object sender, EventArgs e)
        {

        }
    }
}
