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
    public partial class frmQLThiLai : Form
    {
        public frmQLThiLai()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        DIEMTHILAI diemthilai = new DIEMTHILAI();

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HienThiDiemThiLai()
        {
            QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
            dgrDiem.Rows.Clear();
            var dsDiemThiLai =  from x in db.DIEMTHILAIs
            select new
                         {
                             x.MaSV,
                             x.HoTen,
                             x.MaLop,
                             //x.TenMH,
                             x.DiemLT,
                             x.DiemTH,
                             x.DiemThiLai,
                             x.HocKy,
                            
                         };
            dgrDiem.DataSource = dsDiemThiLai;
        }
       
        private void HienThiCBOLop()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsLop = (from x in context.LOPs select x);
            cboLop.DisplayMember = "TenLop";
            //cboLop.ValueMember = "MaLop";
            cboLop.DataSource = dsLop;
        }
        private void HienThiCBOMonHoc()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            var dsMH = (from x in context.MONHOCs select x);
            cboMonHoc.DisplayMember = "TenMH";
            //cboNganh.ValueMember = "MaMH";
            cboMonHoc.DataSource = dsMH;
        }
        private void frmQLThiLai_Load(object sender, EventArgs e)
        {
            HienThiDiemThiLai();
            HienThiCBOLop();
            HienThiCBOMonHoc();
        }

        private void dgrDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrDiem.Rows[e.RowIndex];
            txtMaSV.Text = r.Cells["MaSV"].Value.ToString();
            txtHoTen.Text = r.Cells["HoTen"].Value.ToString();
            cboLop.Text = r.Cells["MaLop"].Value.ToString();
            //cboMonHoc.Text = r.Cells["MaMH"].Value.ToString();
            cboHocKi.Text = r.Cells["HocKy"].Value.ToString();
            txtDiemThiLai.Text = r.Cells["DiemThiLai"].Value.ToString();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaSV.Text))
            {
                diemthilai.MaSV = txtMaSV.Text;
                diemthilai.HoTen = txtHoTen.Text;
                //diemthilai.MaMH = cboMonHoc.Text;
                diemthilai.MaLop = cboLop.Text;
                diemthilai.HocKy = cboHocKi.Text;
                diemthilai.DiemThiLai = float.Parse(txtDiemThiLai.Text);
                db.DIEMTHILAIs.InsertOnSubmit(diemthilai);
                db.SubmitChanges();
                txtMaSV.Text = txtHoTen.Text = txtDiemThiLai.Text = cboHocKi.Text = cboLop.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Thêm Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiCBOLop();
                //HienThiCBOMonHoc();
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
                diemthilai = db.DIEMTHILAIs.Where(x => x.MaSV == txtMaSV.Text).Single();
                diemthilai.HoTen = txtHoTen.Text;
                //diemthilai.MaMH = cboMonHoc.Text;
                diemthilai.MaLop = cboLop.Text;
                diemthilai.HocKy = cboHocKi.Text;
                diemthilai.DiemThiLai = float.Parse(txtDiemThiLai.Text);
                db.SubmitChanges();
                txtMaSV.Text = txtHoTen.Text = txtDiemThiLai.Text = cboHocKi.Text = cboLop.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Sửa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                diemthilai = db.DIEMTHILAIs.Where(x => x.MaSV == txtMaSV.Text).Single();
                diemthilai.HoTen = txtHoTen.Text;
                //diemthilai.MaMH = cboMonHoc.Text;
                diemthilai.MaLop = cboLop.Text;
                diemthilai.HocKy = cboHocKi.Text;
                diemthilai.DiemThiLai = float.Parse(txtDiemThiLai.Text);
                db.DIEMTHILAIs.DeleteOnSubmit(diemthilai);
                db.SubmitChanges();
                txtMaSV.Text = txtHoTen.Text = txtDiemThiLai.Text = cboHocKi.Text = cboLop.Text = "";
                txtMaSV.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiCBOLop();
                HienThiCBOMonHoc();
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
    }
}
