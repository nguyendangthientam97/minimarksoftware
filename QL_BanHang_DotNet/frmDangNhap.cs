using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QL_BanHang_DotNet
{
    public partial class frmDangNhap : Form
    {
        private Sqlcommands cmd;
        private SqlCommand c;
        private SqlConnection con = new SqlConnection(@"
        Data Source=THIENTAM-PC\SQLEXPRESS;Initial Catalog
        =QuanLiBanHang_DotNet;Integrated Security=True");
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public Boolean KiemTraThongTin()
        {
            if(txtMKDangNhap.Text==""||txtTaoKhoanDangNhap.Text=="")
            {
                return false;
            }
            return true;
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            if(KiemTraThongTin())
            {

                //con.Open();
                //{
                //    c = new SqlCommand("DANGNHAPHETHONG", con);

                    
                //    c.CommandType = CommandType.StoredProcedure;
                //    c.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = txtTaoKhoanDangNhap.Text;
                //    c.Parameters.Add(new SqlParameter("@mk", SqlDbType.NVarChar)).Value = txtMKDangNhap.Text;
                //    int tmp=Int32.Parse(c.ExecuteScalar().ToString());
                if(cmd.open())
                {
                    string[] thamso = { "id", "mk" };
                    string[] giatri={ txtTaoKhoanDangNhap.Text,txtMKDangNhap.Text};
                    object tmp = cmd.getObjectStoredProcedure(thamso, giatri, "DANGNHAPHETHONG");
                    int check = Int32.Parse(tmp.ToString());
                    if (check == 1)
                    {
                        MessageBox.Show("Đăng Nhập Thành Công");
                        frmTrangChu f = new frmTrangChu();f.Show();
                    }
                    else
                        MessageBox.Show("Đăng Nhập Thất Bại");
                }
            }
            else
                MessageBox.Show("Thông Tin Chưa Đầy Đủ");
            con.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
                if (txtMKDangNhap.UseSystemPasswordChar == true)
                {
                    txtMKDangNhap.UseSystemPasswordChar = false;
                }
                else
                {
                    txtMKDangNhap.UseSystemPasswordChar = true;
                }
            
            
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKyTaiKhoan f = new frmDangKyTaiKhoan();f.ShowDialog();
        }

        //private void bt_Login_Click(object sender, EventArgs e)
        //{
        //    if (textBoxTaiKhoan.Text.ToString().Equals("") || textBoxMatKhau.Text.ToString().Equals(""))
        //    {
        //        MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        //    }
        //    else if (tenHam.checkTaiKhoan(textBoxTaiKhoan.Text.ToString()))
        //    {
        //        if (tenHam.checkTaiKhoan(textBoxTaiKhoan.Text.ToString(), textBoxTaiKhoan.Text.ToString()))
        //        {
        //            this.Hide();
        //            fTrangChu = new frmTrangChu();
        //            fTrangChu.Show();
        //        }
        //        else
        //            MessageBox.Show("Mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

    }
}
