using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_DiemSV
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        QuanLyDiemSVNTTUDataContext db = new QuanLyDiemSVNTTUDataContext();
        LOGIN lg = new LOGIN();
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool KiemTra()
        {
            if (string.IsNullOrEmpty(txtTaikhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!!!", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaikhoan.Select();
                txtTaikhoan.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtMKcu.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!!!", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKcu.Select();
                return false;
            }
            else if (string.IsNullOrEmpty(txtMKmoi.Text) || string.IsNullOrEmpty(txtConfimMk.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện mới!!!", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKmoi.Select();
                return false;
            }
            else if (!txtMKmoi.Text.Equals(txtConfimMk.Text))
            {
                MessageBox.Show("Mật khẩu Không trùng khớp!!!", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMKmoi.Select();
                return false;
            }
            return true;
        }
        private void Open()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings
                ["QuanLyDiemSVNTTU.Properties.Settings.QLDiemConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DoiMatKhau";
            cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtTaikhoan.Text;
            cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txtMKcu.Text;
            cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtMKmoi.Text;
            cmd.Connection = conn;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đổi mật khẩu không ?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                if (KiemTra())
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = ConfigurationManager.ConnectionStrings
                            ["QL_DiemSV.Properties.Settings.QLDIEMTHIConnectionString"].ConnectionString;
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "DoiMatKhau";
                        cmd.Parameters.Add("@User", SqlDbType.NVarChar).Value = txtTaikhoan.Text;
                        cmd.Parameters.Add("@OldPass", SqlDbType.NVarChar).Value = txtMKcu.Text;
                        cmd.Parameters.Add("@NewPass", SqlDbType.NVarChar).Value = txtMKmoi.Text;
                        cmd.Connection = conn;
                        conn.Open();
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        if (dr.GetInt32(0) == 1)
                        {
                            lblShowInfor.ForeColor = Color.Blue;
                            lblShowInfor.Text = dr.GetString(1);
                            txtConfimMk.Text = "";
                            txtMKcu.Text = "";
                            txtMKmoi.Text = "";
                            txtMKcu.Focus();
                        }
                        else
                        {
                            lblShowInfor.ForeColor = Color.Red;
                            lblShowInfor.Text = dr.GetString(1);
                            txtMKcu.Focus();
                            txtMKcu.SelectAll();
                        }
                        dr.Close();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMKcu.PasswordChar = (char)0;
                txtMKmoi.PasswordChar = (char)0;
                txtConfimMk.PasswordChar = (char)0;
            }
            else
            {
                txtMKcu.PasswordChar = '*';
                txtMKmoi.PasswordChar = '*';
                txtConfimMk.PasswordChar = '*';
            }
        }
    }
}

