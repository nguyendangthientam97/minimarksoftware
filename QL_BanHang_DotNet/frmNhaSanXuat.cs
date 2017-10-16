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
    public partial class frmNhaSanXuat : Form
    {
        private Sqlcommands cmd;
        //private SqlConnection con = new SqlConnection(@"
        //Data Source=THIENTAM-PC\SQLEXPRESS;Initial Catalog
        //=QuanLiBanHang_DotNet;Integrated Security=True");
        public frmNhaSanXuat()
        {
            InitializeComponent();
        }
        //194.168.1.24

        public void HienThiTongTinLenDataGird()
        {
            cmd = new Sqlcommands();
            if (cmd.open())
            {
                DataTable tb = new DataTable();
                tb = cmd.getDataTable("Select *FROM NHASANXUAT");
                danhsachNhaSanXuat.DataSource = tb;
            }

        }
        public Boolean KiemTraMa(string s)
        {
            int dem = s.Count();
            foreach (Char c in s)
            {
                if (Char.IsDigit(c) != true || dem > 10)
                {
                    return false;
                }
            }
            return true;
        }
        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            HienThiTongTinLenDataGird();
            HienThiTimKiem();
            // rdoMa.Checked = false;
        }
        public void HienThiTimKiem()
        {
            cmd = new Sqlcommands();
            if (rdoTimTheoTen.Checked)
            {
                if (cmd.open())
                {
                    txtTimKiem.Text = "";
                    SqlDataReader dr;
                    dr = cmd.getDataReader("SELECT NHASANXUAT.TENNHASANXUAT FROM NHASANXUAT");
                    while (dr.Read())
                    {
                        txtTimKiem.AutoCompleteCustomSource.Add(dr["TENNHASANXUAT"].ToString());
                    }
                }
                cmd.close();
            }
        }
        //try
        //    {
        //        txtMaSX.Text = danhsachNhaSanXuat.SelectedRows[0].Cells[0].Value.ToString();
        //        txtTenNSX.Text = danhsachNhaSanXuat.SelectedRows[0].Cells[1].Value.ToString();
        //        txtSDT.Text = danhsachNhaSanXuat.SelectedRows[0].Cells[2].Value.ToString();
        //        richTextBoxDiaChi.Text = danhsachNhaSanXuat.SelectedRows[0].Cells[3].Value.ToString();
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Chọn Đúng Thông Tin Cần Xem");
        //    }
private void rdoMa_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtMaSX.Text = danhsachNhaSanXuat.CurrentRow.Cells[0].Value.ToString();
            txtTenNSX.Text = danhsachNhaSanXuat.CurrentRow.Cells[1].Value.ToString();
            txtSDT.Text = danhsachNhaSanXuat.CurrentRow.Cells[2].Value.ToString();
            richTextBoxDiaChi.Text = danhsachNhaSanXuat.CurrentRow.Cells[3].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void rdoMa_MouseClick(object sender, MouseEventArgs e)
        {
            cmd = new Sqlcommands();
            txtTimKiem.Text = "";
            SqlDataReader dr;
            dr = cmd.getDataReader("SELECT NHASANXUAT.IDNHASANXUAT FROM NHASANXUAT");
            while (dr.Read())
            {
                txtTimKiem.AutoCompleteCustomSource.Add(dr["IDNHASANXUAT"].ToString());
            }

            cmd.close();
        }

        private void rdoTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
            cmd = new Sqlcommands();
            if (cmd.open())
            {
                txtTimKiem.Text = "";
                SqlDataReader dr;
                dr = cmd.getDataReader("SELECT NHASANXUAT.TENNHASANXUAT FROM NHASANXUAT");
                while (dr.Read())
                {
                    txtTimKiem.AutoCompleteCustomSource.Add(dr["TENNHASANXUAT"].ToString());
                }
            }
            cmd.close();

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

            cmd.close();
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            cmd = new Sqlcommands();
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                if (txtTimKiem.Text == "")
                {
                    HienThiTongTinLenDataGird();
                }
                else
                {
                    if (rdoMa.Checked)
                    {
                        if (cmd.open())
                        {
                            DataTable tb = new DataTable();
                            //   dataGridViewLoaiHang.Rows.Clear();
                            string[] thamso = { "ma" };
                            string[] giatri = { txtTimKiem.Text };
                            //    sqlAcees.executeNonQueryStoredProcedure(thamso, giatri, "SELECT", false);
                            tb = cmd.getDataTableStoredProcedure(thamso, giatri, "TIMKIEMTHEOMANHASANXUAT");
                            danhsachNhaSanXuat.DataSource = tb;
                        }
                    }
                    if (rdoTimTheoTen.Checked)
                    {
                        if (cmd.open())
                        {
                            DataTable tb = new DataTable();
                            //   dataGridViewLoaiHang.Rows.Clear();
                            string[] thamso = { "ten" };
                            string[] giatri = { txtTimKiem.Text };
                            //    sqlAcees.executeNonQueryStoredProcedure(thamso, giatri, "SELECT", false);
                            tb = cmd.getDataTableStoredProcedure(thamso, giatri, "TIMKIEMTHEOTENNHASANXUAT");
                            danhsachNhaSanXuat.DataSource = tb;
                        }
                    }
                }
            }

            cmd.close();
        }
        public Boolean KiemTraThongTinDayDu()
        {
            if (txtMaSX.Text == "" || txtTenNSX.Text == "" || txtSDT.Text == "" || richTextBoxDiaChi.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            groupBoxTimKiem.Enabled = false;
            groupBoxDanhSachNSX.Enabled = false;
            groupBoxThongTinNSX.Enabled = true;
            btnXoa.Enabled = false; btnThoat.Enabled = false; btnSua.Enabled = false;
            if (btnThem.Text == "Thêm")
            {
                txtMaSX.Clear(); txtSDT.Clear(); richTextBoxDiaChi.Clear();
                txtTenNSX.Clear();
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (KiemTraMa(txtMaSX.Text) && KiemTraThongTinDayDu())
                {
                    if (cmd.open())
                    {
                        string[] thamso = { "ID", "TEN", "SDT", "dc" };
                        string[] giatri = { txtMaSX.Text, txtTenNSX.Text, txtSDT.Text, richTextBoxDiaChi.Text };
                        if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "THEMTHONGTINNHASANXUAT", false) == true)
                        {
                            MessageBox.Show("Thêm Thông Tin Thành Công");
                            cmd.close();
                            HienThiTongTinLenDataGird();
                            groupBoxDanhSachNSX.Enabled = true;
                            groupBoxThongTinNSX.Enabled = false;
                            groupBoxTimKiem.Enabled = true;
                            btnXoa.Enabled = true; btnThoat.Enabled = true; btnSua.Enabled = true;
                            btnThem.Text = "Thêm";
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Thông Tin Không Hợp Lệ");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {  cmd = new Sqlcommands();

            if (cmd.open())
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Lưu"; txtMaSX.Enabled = false;
                    groupBoxTimKiem.Enabled = false;
                    groupBoxThongTinNSX.Enabled = true;
                    btnXoa.Enabled = false; btnThem.Enabled = false; btnThoat.Enabled = false;
                }
                else if (btnSua.Text == "Lưu")
                {
                    if (txtMaSX.Text == "" || txtTenNSX.Text == "" || txtSDT.Text == "" || richTextBoxDiaChi.Text == "")
                    {
                        MessageBox.Show("Bạn Cần Chọn Điền Thông Tin Thay Đổi");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Có Chắc Chắn Thay Đổi", "Chú Ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string[] thamso = { "TEN","SDT","DC","ID" };string[] giatri = 
                                {txtTenNSX.Text,txtSDT.Text,richTextBoxDiaChi.Text,txtMaSX.Text };
                            if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "SUATHONGTINNHASANXUAT", false) == true)
                            {
                                MessageBox.Show("Thay Đổi Thông Tin Thành Công");
                                cmd.close();

                                HienThiTongTinLenDataGird();
                                groupBoxTimKiem.Enabled = true;
                                groupBoxThongTinNSX.Enabled = false; btnXoa.Enabled = true;
                                btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                                btnSua.Text = "Sửa";
                                txtMaSX.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fail");
                            }


                        }
                        else
                        {
                            groupBoxTimKiem.Enabled = true;
                            groupBoxThongTinNSX.Enabled = true;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                            btnSua.Text = "Sửa";

                        }
                    }


                }

             
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            if (KiemTraThongTinDayDu())
            {
                if (cmd.open())
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Lưu Thay Đổi", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string[] thamso = { "ID" }; string[] giatri = { txtMaSX.Text };

                        if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "XOATHONGTINNHASANXUAT", false))
                        {
                            MessageBox.Show("Xóa Thông Tin Thành Công"); txtMaSX.Clear(); txtTenNSX.Clear(); txtSDT.Clear();
                            // int index = danhsachNhaSanXuat.CurrentRow.Index;
                            // danhsachNhaSanXuat.Rows.RemoveAt(index);
                            danhsachNhaSanXuat.Rows.RemoveAt(danhsachNhaSanXuat.CurrentRow.Index);

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Thông Tin Cần Xóa");
            }
            cmd.close();
        }

        private void danhsachNhaSanXuat_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void lblSDT_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxNXS_SelectedValueChanged(object sender, EventArgs e)
        {
            txtcompo.Text = comboBoxNXS.SelectedItem.ToString();
        }
    }
}
