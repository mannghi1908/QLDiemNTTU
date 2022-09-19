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
    public partial class frmThongKeDiemSV : Form
    {
        public frmThongKeDiemSV()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInBaoCao_Click_1(object sender, EventArgs e)
        {
            var diem = from dt in db.DIEMTHIs
                           //join sv in db.SINHVIENs on dt.MaSV equals sv.MaSV
                           //join mh in db.MONHOCs on dt.MaMH equals mh.MaMH
                       select new 
                         {
                             dt.MaSV,
                             dt.HoTen,
                             dt.MaLop,
                             dt.MaMH,
                             DiemLT = Convert.ToDouble(dt.DiemLT),
                             DiemTH = Convert.ToDouble(dt.DiemTH),
                             DiemThi= Convert.ToDouble(dt.DiemThi),
                             DiemTK = Convert.ToDouble(dt.DiemTK),
                             dt.HanhKiem,
                             dt.HocKy,
                             dt.GhiChu
                         };
            CrystalReport2 rp = new CrystalReport2();
            rp.SetDataSource(diem);
            rptDiemSV.ReportSource = rp;
        }

        private void rptDiemSV_Load(object sender, EventArgs e)
        {

        }
    }
}
