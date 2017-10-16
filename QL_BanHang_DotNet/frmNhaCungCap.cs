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
    public partial class frmNhaCungCap : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=THIENTAM;Initial Catalog=QuanLiBanHang_DotNet;Integrated Security=True");

        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            //if (lblThem.Text == "Thêm")
            //{
            //    lblThem.Text = "Lưu";
            //    bntLuu.Enabled = false;
            //}
            //else if (lblThem.Text == "Lưu")
            //{
            //    lblThem.Text = "Thêm";
            //    bntLuu.Enabled = true;
            //}
        }
        public void HienThiThongTinNhaCungCap()
        {
            con.Open();
            cmd = new SqlCommand("Select *from NhaCungCap", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                int id = Int32.Parse(dr["IDNHACUNGCAP"].ToString());
                String tenhang = (string)(dr["TENNHACUNGCAP"].ToString());
                int sdt = Int32.Parse(dr["SDT"].ToString());
                String diachi = (string)(dr["DIACHI"].ToString());

                ListViewItem l = new ListViewItem(id + "");
                l.SubItems.Add(tenhang);
                l.SubItems.Add(diachi);
                l.SubItems.Add(sdt + "");
                listViewDanhSachLoaiHang.Items.Add(l);
            }
            con.Close();
           
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            HienThiThongTinNhaCungCap();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listViewDanhSachLoaiHang_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listViewDanhSachLoaiHang.SelectedItems[0];
                if (item != null)
                {
                    txtMaCC.Text = item.SubItems[0].Text;
                    txtTenCC.Text = item.SubItems[1].Text;
                    richTextBoxCC.Text = item.SubItems[2].Text;
                    txtSDT.Text = item.SubItems[3].Text;

                }
            }
            catch
            {
                MessageBox.Show("Click Đúng Thông Tin Cần Xem", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoMa_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text == "")
                {
                    HienThiThongTinNhaCungCap();
                }
                else
                {
                    if (rdoMa.Checked)
                    {
                        con.Open();
                        string que = "Select *FROM NHACUNGCAP WHERE IDNHACUNGCAP=@id";
                        cmd = new SqlCommand(que, con);
                        cmd.Parameters.Add(new SqlParameter("@id", txtTimKiem.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        listViewDanhSachLoaiHang.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem l = new ListViewItem(dr["IDNHACUNGCAP"].ToString());
                            l.SubItems.Add(dr["TENNHACUNGCAP"].ToString());
                            l.SubItems.Add(dr["DIACHI"].ToString());
                            l.SubItems.Add(dr["SDT"].ToString());

                            listViewDanhSachLoaiHang.Items.Add(l);
                        }
                        con.Close();
                    }
                    else if (rdoTen.Checked)
                    {
                        con.Open();
                        string que = "Select *FROM NHACUNGCAP WHERE NHACUNGCAP.TENNHACUNGCAP=@t";
                        cmd = new SqlCommand(que, con);
                        cmd.Parameters.Add(new SqlParameter("@t", txtTimKiem.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        listViewDanhSachLoaiHang.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem l = new ListViewItem(dr["IDNHACUNGCAP"].ToString());
                            l.SubItems.Add(dr["TENNHACUNGCAP"].ToString());
                            l.SubItems.Add(dr["DIACHI"].ToString());
                            l.SubItems.Add(dr["SDT"].ToString());

                            listViewDanhSachLoaiHang.Items.Add(l);
                        }
                        con.Close();
                    }

                }
            }
        }

        private void rdoTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
            con.Open();

            string que = "Select NHACUNGCAP.TENNHACUNGCAP From NHACUNGCAP";
            cmd = new SqlCommand(que, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTimKiem.AutoCompleteCustomSource.Add((string)dr["TENNHACUNGCAP"].ToString());
            }
            con.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupBoxThongTin.Enabled = true;
            btnXoa.Enabled = false; btnThoat.Enabled = false; btnSua.Enabled = false;
            if (btnThem.Text == "Thêm")
            {
                txtMaCC.Clear(); txtTenCC.Clear(); richTextBoxCC.Clear();
                txtSDT.Clear();
                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                con.Open();

                //    try
                //    {
                string que = "Insert Into NhaCungCap(IDNHACUNGCAP,TENNHACUNGCAP,SDT,DIACHI) Values(@id,@ten,@sdt,@diachi)";
                cmd = new SqlCommand(que, con);
                cmd.Parameters.Add(new SqlParameter("@id", SqlDbType.Int)).Value = Convert.ToInt32(txtMaCC.Text);
                cmd.Parameters.Add(new SqlParameter("@ten", SqlDbType.NVarChar)).Value = txtTenCC.Text;
                cmd.Parameters.Add(new SqlParameter("@sdt", SqlDbType.NVarChar)).Value = txtSDT.Text;
                cmd.Parameters.Add(new SqlParameter("@diachi", SqlDbType.NVarChar)).Value = richTextBoxCC.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm Thông Tin Thành Công");

                ListViewItem l = new ListViewItem(txtMaCC.Text + "");
                l.SubItems.Add(txtTenCC.Text);
                l.SubItems.Add(txtSDT.Text);
                l.SubItems.Add(richTextBoxCC.Text);

                listViewDanhSachLoaiHang.Items.Add(l);
                btnThem.Text = "Thêm";
                //   }
                //   catch
                // {
                //    MessageBox.Show("Thêm Thông Tin Thất Bại");
                //
                //     btnThem.Text = "Thêm";
                // }
                con.Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            if (btnXoa.Text == "Xóa")
            {
                groupBoxTimKiem.Enabled = false;
                groupBoxThongTin.Enabled = false;
                btnThem.Enabled = false; btnSua.Enabled = false; btnThoat.Enabled = false;
                listViewDanhSachLoaiHang.Enabled = true;
                btnXoa.Text = "Lưu";
                txtMaCC.Clear(); txtTenCC.Clear(); richTextBoxCC.Clear();
            }
            else if (btnXoa.Text == "Lưu")
            {
                if (txtMaCC.Text != "")
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Lưu Thay Đổi", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {


                            cmd = new SqlCommand("Delete  NHACUNGCAP Where NHACUNGCAP.IDNHACUNGCAP=@ID ", con);
                            //  cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(txtMaCC.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Lưu Thành Công");
                            int index = listViewDanhSachLoaiHang.FocusedItem.Index;
                            listViewDanhSachLoaiHang.Items.RemoveAt(index);
                            //if (listViewDanhSachLoaiHang.Items.Count > 0)
                            //{
                            //    listViewDanhSachLoaiHang.SelectedItems[0].Remove();
                            //}
                            groupBoxTimKiem.Enabled = true;
                            groupBoxThongTin.Enabled = true;
                            btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                            btnXoa.Text = "Xóa";

                        }
                        catch
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        groupBoxTimKiem.Enabled = true;
                        groupBoxThongTin.Enabled = true;
                        btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                        btnXoa.Text = "Xóa";
                    }

                }

                else
                {
                    MessageBox.Show("Bạn Cần Chọn Thông Tin Cần Xóa");
                }
            }
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu"; txtMaCC.Enabled = false;
                groupBoxTimKiem.Enabled = false;
                groupBoxThongTin.Enabled = true;
                btnXoa.Enabled = false; btnThem.Enabled = false; btnThoat.Enabled = false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (txtMaCC.Text == "" || txtTenCC.Text == "" || richTextBoxCC.Text == "")
                {
                    MessageBox.Show("Bạn Cần Chọn Điền Thông Tin Thay Đổi");
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Thay Đổi", "Chú Ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string que = " Update NHACUNGCAP Set TENNHACUNGCAP = @ten, SDT = @SDT,DIACHI=@DIACHI Where IDNHACUNGCAP =@ma";
                            cmd = new SqlCommand(que, con);
                            cmd.Parameters.Add(new SqlParameter("@ten", txtTenCC.Text));
                            cmd.Parameters.Add(new SqlParameter("@SDT", txtSDT.Text));
                            cmd.Parameters.Add(new SqlParameter("@DIACHI", richTextBoxCC.Text));
                            cmd.Parameters.Add(new SqlParameter("@ma", txtMaCC.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thay Đổi Thông Tin Thành Công");

                            listViewDanhSachLoaiHang.SelectedItems[0].SubItems[0].Text = txtMaCC.Text;
                            listViewDanhSachLoaiHang.SelectedItems[0].SubItems[1].Text = txtTenCC.Text;
                            listViewDanhSachLoaiHang.SelectedItems[0].SubItems[2].Text = richTextBoxCC.Text;
                            groupBoxTimKiem.Enabled = true;
                            groupBoxThongTin.Enabled = true; btnXoa.Enabled = true;
                            btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                            btnSua.Text = "Sửa";
                            txtMaCC.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        groupBoxTimKiem.Enabled = true;
                        groupBoxThongTin.Enabled = true;
                        btnXoa.Enabled = true;
                        btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                        btnSua.Text = "Sửa"; txtMaCC.Enabled = true;

                    }
                }
            }
            con.Close();
        }

        private void rdoMa_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
