using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_BanHang_DotNet
{
    public partial class frmDangKyTaiKhoan : Form
    {
        Sqlcommands cmd;//= new Sqlcommands();
        public frmDangKyTaiKhoan()
        {
            InitializeComponent();
         }
        public Boolean KiemTraNhapThongTin()
        {
            if(txtMK.Text==""||txtSDT.Text==""||txtTaiKhoan.Text==""||txtNhapLaiMK.Text=="")
            {
                return false;
            }
            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
                 cmd = new Sqlcommands();
                if (KiemTraNhapThongTin())
                {
                    string[] thamso = { "id", "mk", "sdt" };
                    string[] giatri = { txtTaiKhoan.Text, txtMK.Text, txtSDT.Text };
                    if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "DANGKYTAIKHOAN", false) == true)
                    {
                        MessageBox.Show("Đăng Ký Thành Công");
                        Close();
                    }
                    else
                        MessageBox.Show("Đăng Ký Thất Bại");

                }
                else
                {
                    MessageBox.Show("Thông Tin Chưa Đầy Đủ");
                    txtMK.Clear(); txtNhapLaiMK.Clear(); txtSDT.Clear(); txtTaiKhoan.Clear();
                }
            }
    }
}
