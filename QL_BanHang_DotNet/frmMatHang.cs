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
    public partial class frmMatHang : Form
    {
        
        Sqlcommands cmd;
        SqlDataAdapter da;
        SqlCommand cmdHeThong;
        DataTable dt;
        DataSet ds;
        private string strSelectMatHang = "SELECT *FROM MATHANG";
        private string strSelectTenLoaiHang = "SELECT IDLOAIHANG,TENLOAIHANG FROM LOAIHANG";
        private string strSelectTenNhaCungCap = "SELECT IDNHACUNGCAP,TENNHACUNGCAP FROM NHACUNGCAP";
        private string strTenNhaSanXuat = "SELECT IDNHASANXUAT,TENNHASANXUAT FROM NHASANXUAT";
      //  private DataTable dt;

        public frmMatHang()
        {
            InitializeComponent();
        }
        public void HienThiThongTinMatHang(string str)
        {
            cmd = new Sqlcommands();
            //ds = new DataSet();
            //ds.Clear();
            dt = new DataTable("MATHANG");
            if (cmd.open())
            {
                //    ds = cmd.getDataSet(str);
                //    dataGridViewDanhSachMatHang.DataSource = ds.Tables[0];
                //    //     dataGridViewDanhSachMatHang.DataSource = ds;
                //}
               // dt = new DataTable();
                dt= cmd.getDataTable(str);
                dataGridViewDanhSachMatHang.DataSource = dt;
            }
        }
        private void frmMatHang_Load(object sender, EventArgs e)
        {
            HienThiThongTinMatHang(strSelectMatHang);
         //   loadTenLoaiHang(strSelectTenLoaiHang);
            loadTenNhaSanXuat(strTenNhaSanXuat);
            loadTenNhaCungCap(strSelectTenNhaCungCap);
            comboBoxLoaihang.Text = "";comboBoxNhaCungCap.Text = "";comboBoxNhaSanXuat.Text = "";
            loadTenLoaiHang(strSelectTenLoaiHang);
        }

        public void loadTenNhaSanXuat(string str)
        {
            dt = new DataTable();
            dt = cmd.getDataTable(str);
            comboBoxNhaSanXuat.DataSource = dt;

            comboBoxNhaSanXuat.DisplayMember = dt.Columns[1].ToString();
            comboBoxNhaSanXuat.ValueMember = dt.Columns[0].ToString();
        }
        public void loadTenNhaCungCap(string str)
        {
            dt = new DataTable();
            dt = cmd.getDataTable(str);
            comboBoxNhaCungCap.DataSource = dt;
            comboBoxNhaCungCap.DisplayMember = dt.Columns[1].ToString();
            comboBoxNhaCungCap.ValueMember = dt.Columns[0].ToString();
        }
        public void loadcboLoaiHang()
        {

            cmd = new Sqlcommands();
            SqlDataReader dr;
            if (cmd.open())
            {


                cmdHeThong = new SqlCommand("SELECT LOAIHANG.TENLOAIHANG FROM LOAIHANG", cmd.getConnection());
                dr = cmdHeThong.ExecuteReader();
                while (dr.Read())
                {
                    comboBoxLoaihang.Items.Add ( dr["TENLOAIHANG"].ToString());
                }
            }
            cmd.close();
        }
        public void loadTenLoaiHang(string str)
        {
            // ds = new DataSet();
            // ds = cmd.getDataSet(str);
            //// comboBoxLoaihang.DataSource = ds;
            //foreach (DataRow r in ds.Tables[0].Rows)
            // {
            //       comboBoxLoaihang.Items.Add(r[1].ToString());

            //     // comboBoxLoaihang.DisplayMember = 1.ToString();
            //     //comboBoxLoaihang.ValueMember = 0.ToString();
            // }
            dt = new DataTable();
            dt = cmd.getDataTable(str);
            comboBoxLoaihang.DataSource = dt;
            comboBoxLoaihang.DisplayMember = dt.Columns[1].ToString();
            comboBoxLoaihang.ValueMember = dt.Columns[0].ToString();
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
        public Boolean KiemTraThongTinDayDu()
        {
            if(txtMaHang.Text==""||txtTenHang.Text==""||txtDonGiaBan.Text==""||txtDonGiaNhap.Text==""||txtSoLuong.Text==""||
                comboBoxDVT.Text==""||comboBoxLoaihang.Text==""||comboBoxNhaCungCap.Text==""||comboBoxNhaSanXuat.Text=="")
            {
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            groupBoxTimKiem.Enabled = false;
            groupBoxDanhSachHang.Enabled = false;
            btnXoa.Enabled = false; btnThoat.Enabled = false; btnSua.Enabled = false;txtMaHang.Enabled = true;
            if (btnThem.Text == "Thêm")
            {
                txtMaHang.Clear(); txtTenHang.Clear(); txtSoLuong.Clear();
                txtDonGiaBan.Clear(); txtDonGiaNhap.Clear();comboBoxLoaihang.Text = "";comboBoxNhaCungCap.Text = "";comboBoxNhaSanXuat.Text = "";
                comboBoxDVT.Text = "";

                btnThem.Text = "Lưu";
            }
            else if (btnThem.Text == "Lưu")
            {
                if (KiemTraMa(txtMaHang.Text) && KiemTraThongTinDayDu())
                {
                    if (cmd.open())
                    {
                        string[] thamso = { "ID", "TEN" , "IDLD" ,"IDNSX" , "IDNCC" , "DVT", "SL" , "DGN", "DGB","MT" };
                        string[] giatri = { txtMaHang.Text, txtTenHang.Text, comboBoxLoaihang.SelectedValue.ToString()/*GetMaLoaiHang(comboBoxLoaihang.Text).ToString()*/,GetMaSanXuat(comboBoxNhaSanXuat.Text).ToString(),GetMacCungCap(comboBoxNhaCungCap.Text).ToString(),
                        comboBoxDVT.Text,txtSoLuong.Text,txtDonGiaNhap.Text,txtDonGiaBan.Text,richtextMoTa.Text};
                        if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "THEMTHONGTINMATHANG") == true)
                        {
                            MessageBox.Show("Thêm Thông Tin Thành Công");
                           // cmd.close();
                            HienThiThongTinMatHang(strSelectMatHang);
                            groupBoxDanhSachHang.Enabled = true;
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
        public string GetTenLoaiHang(string s)
        {
            string kq="";
            // conHeThong.Open();
            cmd = new Sqlcommands();
           // string kq = "";
            if(cmd.open())
            {
                cmdHeThong = new SqlCommand("SELECT LOAIHANG.TENLOAIHANG FROM LOAIHANG, MATHANG WHERE LOAIHANG.IDLOAIHANG=MATHANG.IDLOAIHANG AND IDMATHANG=@id", cmd.getConnection());
                cmdHeThong.Parameters.Add(new SqlParameter("@id", s));
                kq = (string)cmdHeThong.ExecuteScalar();
                cmd.close();
            }
             
   
            return kq;
        }

        public string GetTenNhaSanXuat(string s)
        {
            string kq = "";
            // conHeThong.Open();
            cmd = new Sqlcommands();
            // string kq = "";
            if (cmd.open())
            {

                cmdHeThong = new SqlCommand("SELECT NHASANXUAT.TENNHASANXUAT FROM NHASANXUAT, MATHANG WHERE NHASANXUAT.IDNHASANXUAT= MATHANG.IDNHASANXUAT AND MATHANG.IDMATHANG=@id", cmd.getConnection());

                cmdHeThong.Parameters.Add(new SqlParameter("@id", s));
                kq = (string)cmdHeThong.ExecuteScalar();
                cmd.close();
            }


            return kq;
        }
        public string GetTenNhaCungCap(string s)
        {
            string kq = "";
            // conHeThong.Open();
            cmd = new Sqlcommands();
            // string kq = "";
            if (cmd.open())
            {
                cmdHeThong = new SqlCommand("SELECT NHACUNGCAP.TENNHACUNGCAP FROM NHACUNGCAP, MATHANG WHERE NHACUNGCAP.IDNHACUNGCAP= MATHANG.IDNHACUNGCAP AND MATHANG.IDMATHANG=@id", cmd.getConnection());
                cmdHeThong.Parameters.Add(new SqlParameter("@id", s));
                kq = (string)cmdHeThong.ExecuteScalar();
                cmd.close();
            }


            return kq;
        }
        private void dataGridViewDanhSachMatHang_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                // string ma = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[0].Value.ToString();
                txtMaHang.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[0].Value.ToString();
                txtTenHang.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[1].Value.ToString();
                // cach 2
                comboBoxLoaihang.SelectedValue = dataGridViewDanhSachMatHang.CurrentRow.Cells[2].Value.ToString();
                // comboBoxLoaihang.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[2].Value.ToString();
                //  comboBoxLoaihang.Text = 
                comboBoxNhaSanXuat.SelectedValue = dataGridViewDanhSachMatHang.CurrentRow.Cells[3].Value.ToString();
                comboBoxNhaCungCap.SelectedValue = dataGridViewDanhSachMatHang.CurrentRow.Cells[4].Value.ToString();

                //  comboBoxNhaSanXuat.Text = loadTenNhaSanXuat(strTenNhaSanXuat);
                //   comboBoxNhaSanXuat.Text = GetTenNhaSanXuat(txtMaHang.Text);
                //   comboBoxNhaCungCap.Text = GetTenNhaCungCap(txtMaHang.Text);
                comboBoxDVT.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[5].Value.ToString();
                txtSoLuong.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[6].Value.ToString();
                txtDonGiaNhap.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[7].Value.ToString();
                txtDonGiaBan.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[8].Value.ToString();
                //    richtextMoTa.Text = dataGridViewDanhSachMatHang.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Click Đúng Thông Tin!!");
            }
        }

        private void dataGridViewDanhSachMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnThem.Enabled == true && btnXoa.Enabled == false && btnSua.Enabled == false)
                {
                    groupBoxDanhSachHang.Enabled = true;
                    groupBoxTimKiem.Enabled = true;
                    btnXoa.Enabled = true; btnThoat.Enabled = true; btnSua.Enabled = true;
                    btnThem.Text = "Thêm";
                }
                if (btnSua.Enabled == true && btnXoa.Enabled == false && btnThem.Enabled == false)
                {
                    groupBoxDanhSachHang.Enabled = true;
                    groupBoxTimKiem.Enabled = true;
                    btnXoa.Enabled = true; btnThoat.Enabled = true; btnSua.Enabled = true;
                    btnSua.Text = "Sửa"; btnThem.Enabled = true;txtMaHang.Enabled=true;
                }
            }
            catch
            {
                MessageBox.Show("Thao Tác K Đúng");
            }
         
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //cmd = new Sqlcommands();
            //if (cmd.open())
            //{
            //    if (e.KeyChar == (char)13)
            //    {
            //        dt = new DataTable("MATHANG");

            //        //    dt = cmd.getDataTable("SELECT * FROM MATHANG WHERE MATHANG.TENMATHANG LIKE N'%{0}%'", textBox1.Text);
            //        DataView dv = dt.DefaultView;
            //        dv.RowFilter = String.Format("TENMATHANG LIKE '%{0}%'", textBox1.Text);
            //        dataGridViewDanhSachMatHang.DataSource = dv.ToTable();
            //    }
            //}
            //cmd = new Sqlcommands();
            ////  SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM MATHANG WHERE IDMATHANG=110", cmd.getConnection());

            //dt = new DataTable();
            //string[] thamso = {"TEN"}; string[] giatri = { textBox1.Text.Trim() };
            //dt = cmd.getDataTableStoredProcedure(thamso, giatri, "TIMMATHANGTHEOTEN");
            ////AD.Fill(dt);
            //dataGridViewDanhSachMatHang.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            //  SqlDataAdapter AD = new SqlDataAdapter("SELECT * FROM MATHANG WHERE IDMATHANG=110", cmd.getConnection());
            if(cmd.open())
            {
                if(rdoMa.Checked==false)
                {
                    if (textBox1.Text == "")
                    {
                        HienThiThongTinMatHang(strSelectMatHang);
                    }
                    else
                    {
                        dt = new DataTable();
                        string[] thamso = { "TEN" }; string[] giatri = { textBox1.Text };
                        dt = cmd.getDataTableStoredProcedure(thamso, giatri, "[TIMMATHANGTHEOTEN]");
                        //AD.Fill(dt);
                        dataGridViewDanhSachMatHang.DataSource = dt;
                    }
                
                }
                if(rdoTen.Checked==false)
                {
                    if(textBox1.Text=="")
                    {
                        HienThiThongTinMatHang(strSelectMatHang);
                    }
                    else
                    {
                        dt = new DataTable();
                        string[] thamso = { "ID" }; string[] giatri = { textBox1.Text };
                        dt = cmd.getDataTableStoredProcedure(thamso, giatri, "[TIMMATHANGTHEOMA]");
                        //AD.Fill(dt);
                        dataGridViewDanhSachMatHang.DataSource = dt;
                    }
                  
                }
            }
            
            cmd.close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();

            if (cmd.open())
            {
                if (btnSua.Text == "Sửa")
                {
                    btnSua.Text = "Lưu"; txtMaHang.Enabled = false;
                    groupBoxTimKiem.Enabled = false;
                    groupBoxDanhSachHang.Enabled = true;
                    btnXoa.Enabled = false; btnThem.Enabled = false; btnThoat.Enabled = false;
                }
                else if (btnSua.Text == "Lưu")
                {
                    if (txtMaHang.Text == "" || txtTenHang.Text == "" || comboBoxDVT.Text == "" || comboBoxLoaihang.Text == ""
                        || comboBoxNhaCungCap.Text == "" || comboBoxNhaSanXuat.Text == "" 
                        || txtSoLuong.Text == "" || txtDonGiaBan.Text == "" || txtDonGiaNhap.Text == "")
                    {
                        MessageBox.Show("Bạn Cần Chọn Thông Tin Thay Đổi");
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn Có Chắc Chắn Thay Đổi Thông Tin", "Chú Ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string[] thamso = {"TEN","IDLH","IDNSX" ,"IDNCC","DVT",
"SL","DGN" ,"DGB","MT","IDH"};
                            string[] giatri =
                                    {txtTenHang.Text,GetMaLoaiHang(comboBoxLoaihang.Text).ToString(),
                                GetMaSanXuat(comboBoxNhaSanXuat.Text).ToString(),
                                GetMacCungCap(comboBoxNhaCungCap.Text).ToString(),
                                comboBoxDVT.Text,txtSoLuong.Text,txtDonGiaNhap.Text,txtDonGiaBan.Text,richtextMoTa.Text,txtMaHang.Text };
                            if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "SUATHONGTINMATHANG", false) == true)
                            {
                                MessageBox.Show("Thay Đổi Thông Tin Thành Công");
                                cmd.close();

                                HienThiThongTinMatHang(strSelectMatHang);
                                groupBoxTimKiem.Enabled = true;
                                groupBoxDanhSachHang.Enabled = true; btnXoa.Enabled = true;
                                btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                                btnSua.Text = "Sửa";
                                txtMaHang.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Fail");
                            }


                        }
                        else
                        {
                            groupBoxTimKiem.Enabled = true;
                            groupBoxDanhSachHang.Enabled = true;
                            btnXoa.Enabled = true;
                            btnThem.Enabled = true; btnSua.Enabled = true; btnThoat.Enabled = true;
                            btnSua.Text = "Sửa";

                        }
                    }


                }


            }
        }
        public int GetMaLoaiHang(string str)
        {
            int ma =0;
            cmd = new Sqlcommands();
            try
            {
                if (cmd.open())
                {
                    cmdHeThong = new SqlCommand("GETMALOAIHANG", cmd.getConnection());
                    cmdHeThong.CommandType = CommandType.StoredProcedure;
                    cmdHeThong.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar)).Value = str;
                    ma = Int32.Parse(cmdHeThong.ExecuteScalar().ToString());
                    cmd.close();
                }
            }
            catch 
            {
                MessageBox.Show("Thông Tin Tên Loại Hàng K Đúng");
            }
           
            return ma;
        }
        public int GetMaSanXuat(string str)
        {
            int ma = 0;
            cmd = new Sqlcommands();
            try
            {
                if (cmd.open())
                {
                    cmdHeThong = new SqlCommand("GETMANHASANXUAT", cmd.getConnection());
                    cmdHeThong.CommandType = CommandType.StoredProcedure;
                    cmdHeThong.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar)).Value = str;
                    ma = Int32.Parse(cmdHeThong.ExecuteScalar().ToString());
                    cmd.close();
                }
            }
            catch
            {
                MessageBox.Show("Thông Tin Nhà Sản Xuất Không Đúng");
            }
         
            return ma;
        }
        public int GetMacCungCap(string str)
        {
            int ma = 0;
            cmd = new Sqlcommands();
            try
            {
                if (cmd.open())
                {
                    cmdHeThong = new SqlCommand("GETMANHACUNGCAP", cmd.getConnection());
                    cmdHeThong.CommandType = CommandType.StoredProcedure;
                    cmdHeThong.Parameters.Add(new SqlParameter("@TEN", SqlDbType.NVarChar)).Value = str;
                    ma = Int32.Parse(cmdHeThong.ExecuteScalar().ToString());
                    cmd.close();
                }
            }
            catch
            {
                MessageBox.Show("Thông Tin Nhà Cung Cấp Không Đúng");
            }
           
            return ma;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            if (KiemTraThongTinDayDu())
            {
                if (cmd.open())
                {
                    if (MessageBox.Show("Bạn Có Chắc Chắn Muốn Xóa Không", "Chú ý", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string[] thamso = { "ID" }; string[] giatri = { txtMaHang.Text };

                        if (cmd.executeNonQueryStoredProcedure(thamso, giatri, "XOATHONHTINMATHANG", false))
                        {
                            MessageBox.Show("Xóa Thông Tin Thành Công"); txtMaHang.Clear(); txtTenHang.Clear(); txtSoLuong.Clear();
                            txtDonGiaNhap.Clear(); txtDonGiaBan.Clear();comboBoxLoaihang.Text = "";comboBoxNhaCungCap.Text = "";comboBoxNhaSanXuat.Text = "";
                            comboBoxDVT.Text = "";
                            // int index = danhsachNhaSanXuat.CurrentRow.Index;
                            // danhsachNhaSanXuat.Rows.RemoveAt(index);
                            dataGridViewDanhSachMatHang.Rows.RemoveAt(dataGridViewDanhSachMatHang.CurrentRow.Index);

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
    
}
