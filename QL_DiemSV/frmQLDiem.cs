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
    public partial class frmQLDiem : Form
    {
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        DIEMTHI diem = new DIEMTHI();

        public frmQLDiem()
        {
            InitializeComponent();
        }
        private bool KTMATonTai()
        {
            var dsDiem = from dt in db.DIEMTHIs
                         join sv in db.SINHVIENs on dt.MaSV equals sv.MaSV
                         where dt.MaSV == txtMaSV.Text
                         select new
                         {
                             MaSV = dt.MaSV
                             
                         };
            return false;
        }
        private void HienThiDiemSV()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrDiem.Rows.Clear();

            var dsDiem = from dt in context.DIEMTHIs 
                         join sv in context.SINHVIENs on dt.MaSV equals sv.MaSV
                         join mh in context.MONHOCs on dt.MaMH equals mh.MaMH
                         select new
                         {
                             dt.MaSV,
                             dt.HoTen,
                             dt.MaLop,
                             dt.MaMH,
                             dt.DiemLT,
                             dt.DiemTH,
                             dt.DiemThi,
                             dt.DiemTK,
                             dt.HanhKiem,
                             dt.HocKy,
                             dt.GhiChu
                         };
            dgrDiem.DataSource = dsDiem;
        }
        //private void HienThiCBONganh()
        //{
        //    QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
        //    var dsNganh = (from x in context.NGANHs select x);
        //    cboNganh.DisplayMember = "TenNganh";
        //    cboNganh.ValueMember = "MaNganh";
        //    cboNganh.DataSource = dsNganh;
        //}
        private void HienThiCBOLop()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsLop = (from x in context.LOPs select x);
            cboLop.DisplayMember = "MaLop";
            //cboLop.ValueMember = "MaLop";
            cboLop.DataSource = dsLop;
        }
        private void HienThiCBOMonHoc()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsMH = (from x in context.MONHOCs select x);
            cboMonHoc.DisplayMember = "MaMH";
            //cboNganh.ValueMember = "MaMH";
            cboMonHoc.DataSource = dsMH;
        }
        private void frmQLDiem_Load(object sender, EventArgs e)
        {
            HienThiDiemSV();
            //HienThiCBONganh();
            HienThiCBOLop();
            HienThiCBOMonHoc();
        }
        private void TinhDiemTB()
        {
            double DIEMLT, DIEMTH, DIEMTHI, DIEMTK;

            if (txtDiemLT.Text == "")
            {
                DIEMTH = double.Parse(txtDiemTH.Text);
                this.txtDiemLT.Text = "0";
                this.txtDiemThi.Text = "0";
                //Tính điểm TK
                this.txtDiemTK.Text = "0";
                this.txtGhiChu.Text = "Thi lại";
            }
            else if (txtDiemTH.Text == "")
            {
                this.txtDiemTH.Text = "0";
                DIEMLT = double.Parse(this.txtDiemLT.Text);
                DIEMTHI = double.Parse(txtDiemThi.Text);
                //Tính điểm TK
                DIEMTK = (DIEMLT + 2 * DIEMTHI) / 4;
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            else if (txtDiemThi.Text == "")
            {
                this.txtDiemThi.Text = "0";
                DIEMLT = double.Parse(this.txtDiemLT.Text);
                DIEMTH = double.Parse(this.txtDiemTH.Text);

                //Tính điểm TK
                DIEMTK = (DIEMLT + DIEMTH) / 4;
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            else
            {
                DIEMLT = double.Parse(this.txtDiemLT.Text);
                DIEMTH = double.Parse(this.txtDiemTH.Text);
                DIEMTHI = double.Parse(this.txtDiemThi.Text);
                //Tính điểm TK
                DIEMTK = (DIEMLT + DIEMTH + 2 * DIEMTHI) / 4;
                this.txtDiemTK.Text = Convert.ToString(DIEMTK);
            }
            DIEMTK = double.Parse(this.txtDiemTK.Text);
            if (DIEMTK <= 4)
            {
                this.txtGhiChu.Text = "Thi lại";
            }
            else
            {
                this.txtGhiChu.Text = "";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý sinh viên";

                // export header trong DataGridView
                for (int i = 0; i < dgrDiem.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgrDiem.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dgrDiem.RowCount; i++)
                {
                    for (int j = 0; j < dgrDiem.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgrDiem.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgrDiem, saveFileDialog1.FileName);
            }

        }

        private void dgrDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrDiem.Rows[e.RowIndex];
            txtMaSV.Text = r.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
            cboLop.Text = r.Cells["MaLop"].Value.ToString();
            cboMonHoc.Text = r.Cells["MaMH"].Value.ToString();
            txtDiemLT.Text = r.Cells["DiemLT"].Value.ToString();
            txtDiemTH.Text = r.Cells["DiemTH"].Value.ToString();
            txtDiemThi.Text = r.Cells["DiemThi"].Value.ToString();
            txtDiemTK.Text = r.Cells["DiemTK"].Value.ToString();    
            cboHanhKiem.Text = r.Cells["HanhKiem"].Value.ToString();
            cboHocKi.Text = r.Cells["HocKy"].Value.ToString();
            txtGhiChu.Text = r.Cells["GhiChu"].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                diem.MaSV = txtMaSV.Text;
                diem.HoTen = txtHoTen.Text;
                diem.MaMH = cboMonHoc.Text;
                diem.MaLop = cboLop.Text;
                diem.HocKy = cboHocKi.SelectedIndex;
                diem.HanhKiem = cboHanhKiem.Text;
                diem.GhiChu = txtGhiChu.Text;
                diem.DiemLT = double.Parse(txtDiemLT.Text);
                diem.DiemTH = double.Parse(txtDiemTH.Text);
                diem.DiemThi = double.Parse(txtDiemThi.Text);
                diem.DiemTK = double.Parse(txtDiemTK.Text);
                db.DIEMTHIs.InsertOnSubmit(diem);
                if (!KTMATonTai())
                {
                    
                    
                    MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }
                else
                {
                    MessageBox.Show("Thêm Không Thành Công", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                db.SubmitChanges();
                txtMaSV.Text = txtHoTen.Text = txtGhiChu.Text = cboHanhKiem.Text = cboHocKi.Text =
                cboLop.Text = txtDiemLT.Text = txtDiemTH.Text = txtDiemThi.Text = txtDiemTK.Text = "";
                txtMaSV.Focus();
                HienThiDiemSV();
                HienThiCBOLop();
                HienThiCBOMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                diem = db.DIEMTHIs.Where(x => x.MaSV == txtMaSV.Text && x.MaMH == cboMonHoc.Text).Single();
                diem.HoTen = txtHoTen.Text;
                diem.MaMH = cboMonHoc.Text;
                diem.MaLop = cboLop.Text;
                diem.HocKy = cboHocKi.SelectedIndex;
                diem.HanhKiem = cboHanhKiem.Text;
                diem.GhiChu = txtGhiChu.Text;
                diem.DiemLT = double.Parse(txtDiemLT.Text);
                diem.DiemTH = double.Parse(txtDiemTH.Text);
                diem.DiemThi = double.Parse(txtDiemThi.Text);
                db.SubmitChanges();
                txtMaSV.Text = txtHoTen.Text = txtGhiChu.Text = cboHanhKiem.Text = cboHocKi.Text = 
                cboLop.Text = txtDiemLT.Text = txtDiemTH.Text = txtDiemThi.Text = txtDiemTK.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDiemSV();
                HienThiCBOLop();
                HienThiCBOMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                diem = db.DIEMTHIs.Where(x => x.MaSV == txtMaSV.Text && x.MaMH == cboMonHoc.Text).Single();
                //diem.HoTen = txtHoTen.Text;
                //diem.MaMH = cboMonHoc.Text;
                //diem.MaLop = cboLop.Text;
                //diem.HocKy = cboHocKi.SelectedIndex;
                //diem.HanhKiem = cboHanhKiem.Text;
                //diem.GhiChu = txtGhiChu.Text;
                //diem.DiemLT = float.Parse(txtDiemLT.Text);
                //diem.DiemTH = float.Parse(txtDiemTH.Text);
                //diem.DiemThi = float.Parse(txtDiemThi.Text);
                db.DIEMTHIs.DeleteOnSubmit(diem);
                db.SubmitChanges();
                txtMaSV.Text = txtHoTen.Text = txtGhiChu.Text = cboHanhKiem.Text = cboHocKi.Text =
                cboLop.Text = txtDiemLT.Text = txtDiemTH.Text = txtDiemThi.Text = txtDiemTK.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDiemSV();
                HienThiCBOLop();
                HienThiCBOMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void txtDiemTK_TextChanged(object sender, EventArgs e)
        {
            //TinhDiemTB();
        }
        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTB();
        }

        private void txtDiemLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtDiemTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtDiemThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtDiemTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = txtHoTen.Text = txtGhiChu.Text = txtDiemLT.Text = 
            txtDiemTH.Text = txtDiemThi.Text = txtDiemTK.Text = "";
        }
    }
}
