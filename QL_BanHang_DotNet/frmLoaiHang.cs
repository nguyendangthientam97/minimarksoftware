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
    public partial class frmLoaiHang : Form
    {
        private SqlConnection con = new SqlConnection(@"Data Source=THIENTAM;Initial Catalog=QuanLiBanHang_DotNet;Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private Sqlcommands sqlAcess;
        public frmLoaiHang()
        {
            InitializeComponent();
        }

      
        private void frmLoaiHang_Load(object sender, EventArgs e)
        {
            HienThiThongTinLoaiHang();
           // hienthiTexboxTim();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e) // su kien khi nhan enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTimKiem.Text == "")
                {
                    HienThiThongTinLoaiHang();
                }
                else
                {
                    if (radioButtonMa.Checked)
                    {
                        con.Open();
                        string que = "Select *FROM LOAIHANG WHERE IDLOAIHANG=@id";
                        cmd = new SqlCommand(que, con);
                        cmd.Parameters.Add(new SqlParameter("@id", txtTimKiem.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        listViewDanhSachLoaiHang.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem l = new ListViewItem(dr["IDLOAIHANG"].ToString());
                            l.SubItems.Add(dr["TENLOAIHANG"].ToString());
                            l.SubItems.Add(dr["MOTA"].ToString());
                            listViewDanhSachLoaiHang.Items.Add(l);
                        }
                        con.Close();
                    }
                    else if (radioButtonTen.Checked)
                    {
                        con.Open();
                        string que = "Select *FROM LOAIHANG WHERE TENLOAIHANG=@ten";
                        cmd = new SqlCommand(que, con);
                        cmd.Parameters.Add(new SqlParameter("@ten", txtTimKiem.Text));
                        SqlDataReader dr = cmd.ExecuteReader();
                        listViewDanhSachLoaiHang.Items.Clear();
                        while (dr.Read())
                        {
                            ListViewItem l = new ListViewItem(dr["IDLOAIHANG"].ToString());
                            l.SubItems.Add(dr["TENLOAIHANG"].ToString());
                            l.SubItems.Add(dr["MOTA"].ToString());
                            listViewDanhSachLoaiHang.Items.Add(l);
                        }
                        con.Close();
                    }

                }
            }

        }
        public void HienThiThongTinLoaiHang()
        {
            con.Open();
            cmd = new SqlCommand("SELECT *FROM LOAIHANG", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                int id = Int32.Parse(dr["IDLOAIHANG"].ToString());
                String tenhang = (string)(dr["TENLOAIHANG"].ToString());
                String mota = (string)(dr["MOTA"].ToString());

                ListViewItem l = new ListViewItem(id + "");
                l.SubItems.Add(tenhang);
                l.SubItems.Add(mota);
                listViewDanhSachLoaiHang.Items.Add(l);
            }
            con.Close();
        }
        public void hienthiTexboxTim() // hiem thi thong tin len txttimkiem
        {

            if (radioButtonMa.Checked)
            {
                con.Open();

                string que = "Select LoaiHang.IDLOAIHANG From LOAIHANG";
                cmd = new SqlCommand(que, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtTimKiem.AutoCompleteCustomSource.Add((string)dr["IDLOAIHANG"].ToString());
                }
                con.Close();
            }


        }

        private void listViewDanhSachLoaiHang_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListViewItem item = listViewDanhSachLoaiHang.SelectedItems[0];
                if (item != null)
                {
                    txtMa.Text = item.SubItems[0].Text;
                    txtTen.Text = item.SubItems[1].Text;
                    richTextBoxMoTa.Text = item.SubItems[2].Text;
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

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            groupBoxDanhSach.Enabled = false;
            groupBoxTimKiemLoaiHang.Enabled = false;
            groupBoxThongTinLoaiHang.Enabled = true;
            btnXoa.Enabled = false; btnThoat.Enabled = false; btnSua.Enabled = false;
            if (btnThem.Text == "Thêm")
            {
                txtMa.Clear(); txtTen.Clear(); richTextBoxMoTa.Clear();

                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                con.Open();

                try
                {
                    string que = "THEMTHONGTINLOAIHANG";
                    cmd = new SqlCommand(que, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ID", SqlDbType.Int)).Value = Convert.ToInt32(txtMa.Text);
                    cmd.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar)).Value = txtTen.Text;
                    cmd.Parameters.Add(new SqlParameter("@MT", SqlDbType.NVarChar)).Value = richTextBoxMoTa.Text;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm Thông Tin Thành Công");
                    ListViewItem l = new ListViewItem(txtMa.Text);
                    l.SubItems.Add(txtTen.Text);
                    l.SubItems.Add(richTextBoxMoTa.Text);
                    listViewDanhSachLoaiHang.Items.Add(l);
                    groupBoxDanhSach.Enabled = true;
                    groupBoxTimKiemLoaiHang.Enabled = true;
                    groupBoxThongTinLoaiHang.Enabled = false;
                    btnXoa.Enabled = true; btnThoat.Enabled = true; btnSua.Enabled = true;
                    btnThem.Text = "Thêm";
                }
                catch
                {
                    MessageBox.Show("Thêm Thông Tin Thất Bại");
                    groupBoxDanhSach.Enabled = true;
                    groupBoxTimKiemLoaiHang.Enabled = true;
                    groupBoxThongTinLoaiHang.Enabled = false;
                    btnXoa.Enabled = true; btnThoat.Enabled = true; btnSua.Enabled = true;
                    btnThem.Text = "Thêm";
                }
                con.Close();



            }

        }

        private void radioButtonMa_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
            con.Open();

            string que = "Select LoaiHang.IDLOAIHANG From LOAIHANG";
            cmd = new SqlCommand(que, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txtTimKiem.AutoCompleteCustomSource.Add((string)dr["IDLOAIHANG"].ToString());
            }
            con.Close();

        }

        private void radioButtonTen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonTen_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Clear();
            con.Open();
            string que = "Select LOAIHANG.TENLOAIHANG From LOAIHANG";
            cmd = new SqlCommand(que, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtTimKiem.AutoCompleteCustomSource.Add((string)dr["TENLOAIHANG"].ToString());
            }
            con.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            con.Open();
            if (btnXoa.Text == "Xóa")
            {
                groupBoxTimKiemLoaiHang.Enabled = false;
                groupBoxThongTinLoaiHang.Enabled = false;
                btnThem.Enabled = false; btnSua.Enabled = false; btnThoat.Enabled = false;
                listViewDanhSachLoaiHang.Enabled = true;
                btnXoa.Text = "Lưu";
                txtMa.Clear(); txtTen.Clear(); richTextBoxMoTa.Clear();
            }
            else if (btnXoa.Text == "Lưu")
            {
                if (txtMa.Text != "")
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Lưu Thay Đổi", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {

                            int index = listViewDanhSachLoaiHang.FocusedItem.Index;
                            listViewDanhSachLoaiHang.Items.RemoveAt(index);
                            cmd = new SqlCommand("XOATHONHTINLOAIHANG", con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(txtMa.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Lưu Thành Công");

                            //if (listViewDanhSachLoaiHang.Items.Count > 0)
                            //{
                            //    listViewDanhSachLoaiHang.SelectedItems[0].Remove();
                            //}
                            groupBoxTimKiemLoaiHang.Enabled = true;
                            groupBoxThongTinLoaiHang.Enabled = true;
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
                        groupBoxTimKiemLoaiHang.Enabled = true;
                        groupBoxThongTinLoaiHang.Enabled = true;
                        btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                        btnXoa.Text = "Xóa";
                    }

                }

                else
                {
                    MessageBox.Show("Bạn Cần Chọn Thông Tin Cần Xóa");
                }
            }
            //try
            //{
            //    if (MessageBox.Show("Bạn Có Chắc Chắn Lưu Thay Đổi", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        int index = listViewDanhSachLoaiHang.FocusedItem.Index;
            //        listViewDanhSachLoaiHang.Items.RemoveAt(index);
            //        cmd = new SqlCommand("XOATHONHTINLOAIHANG", con);
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(txtMa.Text);
            //        cmd.ExecuteNonQuery();
            //        MessageBox.Show("Xóa Thành Công");
            //    }

            //}
            //catch
            //{
            //    MessageBox.Show("Xóa Thông Tin Không Thành Công");
            //}
            con.Close();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            con.Open();

            if (btnSua.Text == "Sửa")
            {
                btnSua.Text = "Lưu"; txtMa.Enabled = false;
                groupBoxTimKiemLoaiHang.Enabled = false;
                groupBoxThongTinLoaiHang.Enabled = true;
                btnXoa.Enabled = false; btnThem.Enabled = false; btnThoat.Enabled = false;
            }
            else if (btnSua.Text == "Lưu")
            {
                if (txtMa.Text == "" || txtTen.Text == "" || richTextBoxMoTa.Text == "")
                {
                    MessageBox.Show("Bạn Cần Chọn Điền Thông Tin Thay Đổi");
                }
                else
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Thay Đổi", "Chú Ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        try
                        {
                            string que = " Update LOAIHANG Set TENLOAIHANG = @ten, MOTA = @mota Where IDLOAIHANG =@ma";
                            cmd = new SqlCommand(que, con);
                            cmd.Parameters.Add(new SqlParameter("@ten", txtTen.Text));
                            cmd.Parameters.Add(new SqlParameter("@mota", richTextBoxMoTa.Text));
                            cmd.Parameters.Add(new SqlParameter("@ma", txtMa.Text));
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thay Đổi Thông Tin Thành Công");

                            listViewDanhSachLoaiHang.SelectedItems[0].SubItems[0].Text = txtMa.Text;
                            listViewDanhSachLoaiHang.SelectedItems[0].SubItems[1].Text = txtTen.Text;
                            listViewDanhSachLoaiHang.SelectedItems[0].SubItems[2].Text = richTextBoxMoTa.Text;
                            groupBoxTimKiemLoaiHang.Enabled = true;
                            groupBoxThongTinLoaiHang.Enabled = true; btnXoa.Enabled = true;
                            btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                            btnSua.Text = "Sửa";
                            txtMa.Enabled = true;
                        }
                        catch
                        {
                            MessageBox.Show("Fail");
                        }
                    }
                    else
                    {
                        groupBoxTimKiemLoaiHang.Enabled = true;
                        groupBoxThongTinLoaiHang.Enabled = true;
                        btnXoa.Enabled = true;
                        btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                        btnSua.Text = "Sửa"; txtMa.Enabled = true;

                    }
                }
            }
            con.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewLoaiHang_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        

        }

        private void dataGridViewLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void groupBoxDanhSach_Enter(object sender, EventArgs e)
        {

        }
    }
}
