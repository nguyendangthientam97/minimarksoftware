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
    public partial class frmHoaDonBanHang : Form
    {
        Sqlcommands cmd;
        SqlCommand cmdHEThong;
        DataTable dt;
        SqlDataReader dr;
        public frmHoaDonBanHang()
        {
            InitializeComponent();
        }

       
        public Boolean kiemtrathongtinmathang()
        {
            if(txtTenHang.Text==""||txtSoLuong.Text==""||txtDonGia.Text==""||cboDonViTinh.Text=="")
            {
                return false;
            }
            return true;
        }
        public void loadulieulenChiTietHoaDon()
        {
            cmd = new Sqlcommands();
            if(cmd.open())
            {
                string q = "SELECT CHITIETHOADONBANHANG.IDMATHANG,TENMATHANG,DONGIABAN,SOLUONG,THANHTIEN FROM CHITIETHOADONBANHANG WHERE IDHOADON=@ID ";
                SqlDataAdapter da = new SqlDataAdapter(q, cmd.getConnection());
                da.SelectCommand.Parameters.Add(new SqlParameter("@ID", txtMaHDBan.Text));
                dt = new DataTable();
                da.Fill(dt);
                dataGridViewChiTietDonHang.DataSource = dt;
            }

        }
        public Boolean kiemtramahoadon (string id)
        {
            cmd = new Sqlcommands();
            if(cmd.open())
            {
                cmdHEThong = new SqlCommand("SELECT COUNT(*) FROM CHITIETHOADONBANHANG,HOADONBANHANG WHERE HOADONBANHANG.IDHOADON=CHITIETHOADONBANHANG.IDHOADON AND CHITIETHOADONBANHANG.IDHOADON=@ID",cmd.getConnection());
                cmdHEThong.Parameters.Add(new SqlParameter("@ID", id));
                int tmp = Int32.Parse(cmdHEThong.ExecuteScalar().ToString());
                if(tmp==0)
                {
                    return false;
                }
            }
           // cmd.close();
            return true;
        }
        public void tinhtongtien()
        {
            cmd = new Sqlcommands();
            try
            {
                if(cmd.open())
                {
                    if(kiemtramahoadon(txtMaHDBan.Text))
                    {
                        string que2 = "SELECT SUM(CHITIETHOADONBANHANG.THANHTIEN) FROM HOADONBANHANG,CHITIETHOADONBANHANG WHERE HOADONBANHANG.IDHOADON=CHITIETHOADONBANHANG.IDHOADON AND HOADONBANHANG.IDHOADON=@id GROUP BY HOADONBANHANG.IDHOADON";

                        cmdHEThong = new SqlCommand(que2, cmd.getConnection());
                        cmdHEThong.Parameters.Add(new SqlParameter("@id", txtMaHDBan.Text));
                        double i = Double.Parse(cmdHEThong.ExecuteScalar().ToString());
                        richTextBoxTonThanhToan.Text = i + "";
                    }
                    else
                    {
                        richTextBoxTonThanhToan.Text ="";

                    }

                }
                else
                {
                    MessageBox.Show("K Mở Hệ Thống Đc");
                }
          }
            catch
            {
              MessageBox.Show("Đầu Vào K Hợp Lệ");
           }
            cmd.close();
        }
        private void btnGhiHang_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            if(cmd.open()&&kiemtrathongtinmathang())
            {
                double sl = Double.Parse(txtSoLuong.Text);
                double dongia = Double.Parse(txtDonGia.Text);
                double tongtien = sl * dongia;
                string[] thamso = { "IDHD", "IDHANG", "TENHANG", "SL", "DONGIA", "THANHTIEN" };
                string[] giatri = { txtMaHDBan.Text, txtMaHang.Text, txtTenHang.Text, txtSoLuong.Text, txtDonGia.Text, tongtien + "" };
                cmd.executeNonQueryStoredProcedure(thamso, giatri, "THEMTHONGTINCHITIETHOADON", true);
                MessageBox.Show("Thêm Mặt Hàng Thành Công");
                loadulieulenChiTietHoaDon();
                tinhtongtien();
            }
            else
            {
                MessageBox.Show("Lỗi Thực Thi");
            }
            cmd.close();
        }
        public void loadThongTinMaHangTenHang()
        {
            cmd = new Sqlcommands();
            SqlDataReader dr = cmd.getDataReader("SELECT  MATHANG.IDMATHANG FROM MATHANG ");
            while (dr.Read())
            {
                txtMaHang.AutoCompleteCustomSource.Add(dr["IDMATHANG"].ToString());
            }
            cmd.close();
            cmd = new Sqlcommands();
            SqlDataReader dr2 = cmd.getDataReader("SELECT  MATHANG.TENMATHANG FROM MATHANG ");
            while (dr2.Read())
            {
                txtTenHang.AutoCompleteCustomSource.Add(dr2["TENMATHANG"].ToString());
            }
            cmd.close();
        }
        private void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLiBanHang_DotNetDataSet.CHITIETHOADONBANHANG' table. You can move, or remove it, as needed.
           // this.cHITIETHOADONBANHANGTableAdapter.Fill(this.quanLiBanHang_DotNetDataSet.CHITIETHOADONBANHANG);
            panelGhiMatHang.Enabled = false;panelThanhTien.Enabled = false;groupBoxChiTietHoaDon.Enabled = false;
            btnXoa.Enabled = false;btnSua.Enabled = false;btnLamMoi.Enabled = true;btnInBill.Enabled = false;
            btnHuyPhieu.Enabled = false;
            loadThongTinLoaiKhachHang(); loadThongTinMaHangTenHang();
        }
        public void loadThongTinLoaiKhachHang()
        {
            cmd = new Sqlcommands();
            if(cmd.open())
            {
                SqlDataReader dr = cmd.getDataReader("SELECT  LOAIKHACHHANG.TENLOAIKHACH FROM LOAIKHACHHANG ");
                while (dr.Read())
                {
                    cboLoaiKhach.Items.Add(dr["TENLOAIKHACH"]);
                }
            }
        }
        public Boolean kiemtrathongtinHoaDon()
        {
            if ( cboLoaiKhach.Text == "" || txtIDNV.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            if(kiemtrathongtinHoaDon())
            {
                cmd = new Sqlcommands();
                string[] thamso = { "IDHD","TENLOAIKHACH","TENKHACH","SDT","DIACHI","IDNHANVIEN","NGAYHD" };
                string[] giatri = {txtMaHDBan.Text, cboLoaiKhach.Text, txtTenKhach.Text, txtSDT.Text, txtDiaChi.Text, txtIDNV.Text, datetimeHoaDon.Value.ToShortDateString() };
                cmd.executeNonQueryStoredProcedure(thamso, giatri, "THEMTHONGTINHOADONBANHANG", false);
                MessageBox.Show("Lập Hóa Đơn Thành Công");
                int tmp = (int)cmd.getObject("SELECT MAX(HOADONBANHANG.IDHOADON) FROM HOADONBANHANG");
                txtMaHDBan.Text = tmp + "";
                groupBoxChiTietHoaDon.Enabled = true;panelGhiMatHang.Enabled = true;panelThanhTien.Enabled = true;
                btnGhiHang.Enabled = true;btnHuyPhieu.Enabled = true;btnLamMoi.Enabled = true;btnSua.Enabled = true;btnInBill.Enabled = true;
                groupBoxHoaDon.Enabled = false; btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thông Tin Chưa Chính Xác,Kiểm Tra Lại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        

        private void txtTenHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd = new Sqlcommands();
                if (cmd.open())
                {
                    string que = "Select MATHANG.IDMATHANG,MATHANG.DONGIABAN,MATHANG.DONVITINH FROM MATHANG WHERE MATHANG.TENMATHANG=@TENHANG";
                    cmdHEThong = new SqlCommand(que, cmd.getConnection());
                    cmdHEThong.Parameters.Add(new SqlParameter("@TENHANG", txtTenHang.Text));
                    SqlDataReader dr = cmdHEThong.ExecuteReader();
                    while (dr.Read())
                    {
                        txtMaHang.Text = (dr["IDMATHANG"].ToString());
                        txtDonGia.Text = (dr["DONGIABAN"].ToString());
                        cboDonViTinh.Text = (dr["DONVITINH"].ToString());
                    }

                }
            }
        }


        private void btnHuyPhieu_Click(object sender, EventArgs e)
        {
           // try
         //   {
                cmd = new Sqlcommands();
                if(MessageBox.Show("Bạn Chắc Chắn Hủy Phiếu Này","Thông Báo",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    if(cmd.open())
                {

                    string que = "DELETE FROM CHITIETHOADONBANHANG WHERE IDHOADON IN(SELECT IDHOADON FROM CHITIETHOADONBANHANG WHERE IDHOADON = @id)";
                    cmdHEThong = new SqlCommand(que, cmd.getConnection());
                    cmdHEThong.Parameters.Add(new SqlParameter("@id", txtMaHDBan.Text));
                    cmdHEThong.ExecuteNonQuery();
                    // dataGridViewChiTietDonHang.Rows.Clear();
                    string que1 = "DELETE FROM HOADONBANHANG  WHERE IDHOADON  = @id2";
                    cmdHEThong = new SqlCommand(que1, cmd.getConnection());
                    cmdHEThong.Parameters.Add(new SqlParameter("@id2", txtMaHDBan.Text));
                    cmdHEThong.ExecuteNonQuery();

                    MessageBox.Show("Hủy  Thông Tin Phiếu  Thành Công");
                    dataGridViewChiTietDonHang.DataSource = null;

                    groupBoxHoaDon.Enabled = true; panelGhiMatHang.Enabled = false; groupBoxChiTietHoaDon.Enabled = false;
                    btnXoa.Enabled = false; btnSua.Enabled = false; btnDong.Enabled = true; btnLamMoi.Enabled = true;
                }
                }
                else
                {
                    MessageBox.Show("Tiếp Tục Bán Hàng");
                }

         //   }
            //catch
         //   {
             //   MessageBox.Show("Hủy Thông Tin Thất Bại",
            //    "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   }
            cmd.close();
        }

        private void dataGridViewChiTietDonHang_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                txtMaHang.Text = dataGridViewChiTietDonHang.SelectedRows[0].Cells[0].Value.ToString();
                txtTenHang.Text = dataGridViewChiTietDonHang.SelectedRows[0].Cells[1].Value.ToString();
                cboDonViTinh.Text = dataGridViewChiTietDonHang.SelectedRows[0].Cells[2].Value.ToString();
                txtDonGia.Text = dataGridViewChiTietDonHang.SelectedRows[0].Cells[3].Value.ToString();
                txtSoLuong.Text = dataGridViewChiTietDonHang.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("K Tìm Thấy Thông Tin");
            }

           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            if(cmd.open())
            {
                if (MessageBox.Show("Bạn Có Muốn Xóa Thông Tin Này Không", "Chú Ý:", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string que = "Delete CHITIETHOADONBANHANG Where CHITIETHOADONBANHANG.IDMATHANG=@ma";
                        cmdHEThong = new SqlCommand(que, cmd.getConnection());
                        cmdHEThong.Parameters.Add(new SqlParameter("@ma", txtMaHang.Text));
                        cmdHEThong.ExecuteNonQuery();
                        int index = dataGridViewChiTietDonHang.CurrentRow.Index;
                        dataGridViewChiTietDonHang.Rows.RemoveAt(index);
                        MessageBox.Show("Xóa Thông Tin  Thành Công");
                        tinhtongtien();
                    }
                    catch
                    {
                        MessageBox.Show("Xóa Thông Tin Thất Bại",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            cmd.close();

        }
        public Boolean checkThongTinSuaPhieu()
        {
            if (txtMaHang.Text == "" || txtTenHang.Text == "" || txtSoLuong.Text == "" || txtDonGia.Text == ""||cboDonViTinh.Text=="")
            {
                return false;
            }
            return true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            if(cmd.open()&&checkThongTinSuaPhieu())
            {
                string que = "Update CHITIETHOADONBANHANG SET  SOLUONG=@sl,THANHTIEN=@tien Where IDHOADON=@idhd and IDMATHANG=@idh";
                cmdHEThong = new SqlCommand(que, cmd.getConnection());
                cmdHEThong.Parameters.Add(new SqlParameter("@sl", txtSoLuong.Text));
                double sl = Double.Parse(txtSoLuong.Text);
                double dongia = Double.Parse(txtDonGia.Text);
                double thanhtien = sl * dongia;
                cmdHEThong.Parameters.Add(new SqlParameter("@tien", thanhtien + ""));
                cmdHEThong.Parameters.Add(new SqlParameter("@idhd", txtMaHDBan.Text));

                cmdHEThong.Parameters.Add(new SqlParameter("@idh", txtMaHang.Text));

                cmdHEThong.ExecuteNonQuery();

                MessageBox.Show("Thay Đổi Thông Tin Thành Công");
                tinhtongtien();
                loadulieulenChiTietHoaDon();

            }
            else
            {
                MessageBox.Show("Dữ Liệu Đầu Vào Không Hợp Lệ");
            }
            cmd.close();
        }

        private void txtChietKhau_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtChietKhau.Text=="")
                {
                    tinhtongtien();
                }
                else
                {
                    double chietkhau = Double.Parse(txtChietKhau.Text);
                    double thanhtien = double.Parse(richTextBoxTonThanhToan.Text);
                    double thanhtoan = thanhtien-(thanhtien * chietkhau / 100) ;
                    richTextBoxTonThanhToan.Text = thanhtoan+"";
                }
            }
            catch
            {
                tinhtongtien();
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
          
        }

        private void txtKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtKhachDua.Text != "")
                {
                    double tongtien = Double.Parse(richTextBoxTonThanhToan.Text);
                    double khachdua = Double.Parse(txtKhachDua.Text);
                    double tienthua = khachdua - tongtien;
                    txtThoiLai.Text = tienthua + "";
                }
                else
                {
                    txtThoiLai.Text = "";

                }
            }
            catch
            {
                txtThoiLai.Text = "";
                
            }
        }
       
        private void txtChietKhau_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
        public void luuHoaDon()
        {
            cmd = new Sqlcommands();
            if(cmd.open())
            {
                try
                {
                    string que = "UPDATE HOADONBANHANG Set TONGTHANHTOAN=@sum Where IDHOADON=@id";
                    cmdHEThong = new SqlCommand(que, cmd.getConnection());
                    cmdHEThong.Parameters.Add(new SqlParameter("@sum", richTextBoxTonThanhToan.Text));
                    cmdHEThong.Parameters.Add(new SqlParameter("@id", txtMaHDBan.Text));

                    cmdHEThong.ExecuteNonQuery();
                    MessageBox.Show("Lưu Thông Tin  Thành Công");
                   
                }
                catch
                {
                    MessageBox.Show("Lưu Thông Tin Thất Bại");
                }
               

            }
            cmd.close();

        }
        private void btnInBill_Click(object sender, EventArgs e)
        {

            luuHoaDon();
            string ma = Convert.ToString(txtMaHDBan.Text);
            string tong = Convert.ToString(richTextBoxTonThanhToan.Text);
            string khachdua = Convert.ToString(txtKhachDua.Text);
            string thoilai = Convert.ToString(txtThoiLai.Text);
            string ngay = datetimeHoaDon.Value.ToShortDateString();
            frmInHoaDonBanHang fIn = new frmInHoaDonBanHang(ma,ngay,tong,khachdua,thoilai);
            fIn.Show();


        }

       
    }
    
}
