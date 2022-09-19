using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemSV
{
    public partial class frmGiangVien : Form
    {
        public frmGiangVien()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        GIANGVIEN gv = new GIANGVIEN();
        private void HienThiPhanLoaiGiangVien()
        {
            QuanLyDiemSVNTTUDataContext context = new QuanLyDiemSVNTTUDataContext();
            dgrGiangVien.Rows.Clear();
            var dsGV = from x in context.GIANGVIENs select x;
            dgrGiangVien.DataSource = dsGV;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            HienThiPhanLoaiGiangVien();
            //HienThiAnh();
        }

        public static bool IsEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }
        public static bool IsPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            return Regex.IsMatch(phone, "^0[98]{1}\\d{8}$");
        }
        private void dgrGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgrGiangVien.Rows[e.RowIndex];
            txtMaGV.Text = r.Cells["MaGV"].Value.ToString();
            txtHoTenGV.Text = r.Cells["TenGV"].Value.ToString();
            cboGioiTinh.Text = r.Cells["GioiTinh"].Value.ToString();
            mskSDT.Text = r.Cells["Phone"].Value.ToString();
            txtEmail.Text = r.Cells["Email"].Value.ToString();
            cboPhanloai.Text = r.Cells["PhanLoaiGV"].Value.ToString();
            //picAnh.Image = Image.FromFile("123");
            //ImageConverter objImageConverter = new ImageConverter();

            //byte[] x = (byte[])r.Cells["Image"].Value;
            //MemoryStream ms1 = new MemoryStream(x);
            //picAnh.Image = Bitmap.FromStream(ms1);

        }

            private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaGV.Text) && !string.IsNullOrEmpty(txtHoTenGV.Text))
            {
                gv.MaGV = txtMaGV.Text;
                gv.TenGV = txtHoTenGV.Text;
                gv.GioiTinh = cboGioiTinh.Text;
                if (!IsEmail(txtEmail.Text))
                {
                    MessageBox.Show("Nhập sai email!!!", "Nhập lại");
                }
                else if (!IsPhone(mskSDT.Text))
                {
                    MessageBox.Show("Nhập không đúng định dạng SĐT!!!", "Nhập lại");
                }
                else
                {
                    gv.Phone = mskSDT.Text;
                    gv.Email = txtEmail.Text;
                    gv.PhanLoaiGV = cboPhanloai.Text;
                    db.GIANGVIENs.InsertOnSubmit(gv);
                    db.SubmitChanges();
                    txtMaGV.Text = txtHoTenGV.Text = txtMaGV.Text = txtEmail.Text = mskSDT.Text = "";
                    txtMaGV.Focus();
                    MessageBox.Show("Thêm Thành Công", "Sucessfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhanLoaiGiangVien();
                }
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaGV.Text))
            {
                gv.MaGV = txtMaGV.Text;
                gv.TenGV = txtHoTenGV.Text;
                gv.GioiTinh = cboGioiTinh.Text;
                if (!IsEmail(txtEmail.Text))
                {
                    MessageBox.Show("Nhập sai email!!!", "Nhập lại");
                }
                else if (!IsPhone(mskSDT.Text))
                {
                    MessageBox.Show("Nhập không đúng định dạng SĐT!!!", "Nhập lại");
                }
                else
                {
                    gv.Phone = mskSDT.Text;
                    gv.Email = txtEmail.Text;
                    gv.PhanLoaiGV = cboPhanloai.Text;
                    db.SubmitChanges();
                    txtMaGV.Text = txtHoTenGV.Text = txtMaGV.Text = txtEmail.Text = mskSDT.Text = "";
                    txtMaGV.Focus();
                    MessageBox.Show("Sửa Thành Công", "Sucessfully!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiPhanLoaiGiangVien();
                }
            }
            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaGV.Text))
            {
                gv = db.GIANGVIENs.Where(x => x.MaGV == txtMaGV.Text).Single();
                gv.TenGV = txtHoTenGV.Text;
                gv.GioiTinh = cboGioiTinh.Text;
                gv.Phone = mskSDT.Text;
                gv.Email = txtEmail.Text;
                gv.PhanLoaiGV = cboPhanloai.Text;
                db.GIANGVIENs.DeleteOnSubmit(gv);
                db.SubmitChanges();
                txtMaGV.Text = txtHoTenGV.Text = txtMaGV.Text = txtEmail.Text = mskSDT.Text = "";
                txtMaGV.Focus();
                MessageBox.Show("Xóa Thành Công", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiPhanLoaiGiangVien();
            }


            else
            {
                MessageBox.Show("Xin vui lòng nhập liệu đầy đủ !", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgrGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picAnh_Click(object sender, EventArgs e)
        {
           
        }
        private void HienThiAnh()
        {
            var anh = (from x in db.GIANGVIENs select x.Anh).FirstOrDefault();
            
            picAnh.Image.Dispose();
        }
        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                picAnh.Image = new Bitmap(open.FileName);
                // image file path  
                btnAnh.Text = open.FileName;
                
            }
            HienThiAnh();
        }

        private void mskSDT_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
