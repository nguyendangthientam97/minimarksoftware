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
    public partial class frmBaoCaoDoanhThu : Form
    {
        private Sqlcommands cmd;
        SqlCommand cmdHeThong;
        SqlDataAdapter ad;
        DataTable dt;
        SqlDataReader dr;
        public frmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //cmd = new Sqlcommands();
            //int ngay1 = dateTimePickerTuNgay.Value.Day;
            //int thang1 = dateTimePickerTuNgay.Value.Month;
            //int nam1 = dateTimePickerTuNgay.Value.Year;
            //int ngay2 = dateTimePickerDenNgay.Value.Day;
            //int thang2 = dateTimePickerDenNgay.Value.Month;
            //int nam2 = dateTimePickerDenNgay.Value.Year;
            //if (cmd.open())
            //{
            //    if (kiemtrangaythangnam())
            //    {
            //        //string s = "update DOCGIA set HoDocGia='" + 
            //        //hoDocGia + "',TenLotDocGia= '" + tenLotDocGia + "',
            //        //      TenDocGia='" + tenDocGia + "',GioiTinh=" + gioiTinh + ",
            //        //  NgaySinh='" + ngaySinh + "',Sonha='" + soNha + "',Duong='" + duong + "'
            //        //    ,Quan='" + quan + "',SoDienThoai='" + soDienThoai + "',NgayDangKi='" 
            //        //+ ngayDK + "',NgayHethanDK='" + ngayHetHanDK + "' where MaDocGia='" + maDocGia + "'";
            //        string[] thanso = { "ngay1", "thang1", "nam1", "ngay2", "thang2", "nam2" };
            //        string[] giatri = { ngay1 + "", thang1 + "", nam1 + "", ngay2 + "", thang2 + "", nam2 + "" };
            //        dt = cmd.getDataTableStoredProcedure(thanso, giatri, "BAOCAODOANHTHUBANHANG");

            //        dataGridViewThongTinHoaDonBanHang.DataSource = dt;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Thông Tin Ngày Tháng Không Hợp Lệ");
            //    }
            //}

            //cmd.close();
            //txtTongSLHD.Text = tinhtongsoluong() + "";
            //txtTongDoanhThuHD.Text = tinhtongdoanhthu() + "";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            txtTongSLHD.Text = tinhtongsoluong() + "";
        }
        public Boolean kiemtrangaythangnam()
        {
            int ngay1 = dateTimePickerTuNgay.Value.Day;
            int thang1 = dateTimePickerTuNgay.Value.Month;
            int nam1 = dateTimePickerTuNgay.Value.Year;
            int ngay2 = dateTimePickerDenNgay.Value.Day;
            int thang2 = dateTimePickerDenNgay.Value.Month;
            int nam2 = dateTimePickerDenNgay.Value.Year;
            if(ngay1>ngay2||thang1>thang2||nam1>nam2)
            {
                return false;
            }
            return true;
        }
        public int tinhtongsoluong()
        {
            int sl = 0;
            int ngay1 = dateTimePickerTuNgay.Value.Day;
            int thang1 = dateTimePickerTuNgay.Value.Month;
            int nam1 = dateTimePickerTuNgay.Value.Year;
            int ngay2 = dateTimePickerDenNgay.Value.Day;
            int thang2 = dateTimePickerDenNgay.Value.Month;
            int nam2 = dateTimePickerDenNgay.Value.Year;
            cmd = new Sqlcommands();
            if(cmd.open())
            {
                cmdHeThong = new SqlCommand("SELECT COUNT(*) FROM HOADONBANHANG   WHERE day(NGAYHOADON) between @ngay1 and @ngay2 AND month(NGAYHOADON) between @thang1 and @thang2 and YEAR(NGAYHOADON) between @nam1 and @nam2", cmd.getConnection());
                cmdHeThong.Parameters.Add(new SqlParameter("@ngay1", ngay1));
                cmdHeThong.Parameters.Add(new SqlParameter("@ngay2", ngay2));
                cmdHeThong.Parameters.Add(new SqlParameter("@thang1", thang1));
                cmdHeThong.Parameters.Add(new SqlParameter("@thang2", thang2));
                cmdHeThong.Parameters.Add(new SqlParameter("@nam1", nam1));
                cmdHeThong.Parameters.Add(new SqlParameter("@nam2", nam2));
                 sl = Int32.Parse(cmdHeThong.ExecuteScalar().ToString());


            }
            cmd.close();
            return sl;
        }
        public double tinhtongdoanhthu()
        {

            double doanhthu = 0;
            int ngay1 = dateTimePickerTuNgay.Value.Day;
            int thang1 = dateTimePickerTuNgay.Value.Month;
            int nam1 = dateTimePickerTuNgay.Value.Year;
            int ngay2 = dateTimePickerDenNgay.Value.Day;
            int thang2 = dateTimePickerDenNgay.Value.Month;
            int nam2 = dateTimePickerDenNgay.Value.Year;
            cmd = new Sqlcommands();
            if (cmd.open())
            {
                string que = "select  sum(HOADONBANHANG.TONGTHANHTOAN) from HOADONBANHANG Where YEAR(NGAYHOADON) between @nam1 and @nam2 and MONTH(NGAYHOADON) between @thang1 and @thang2 and day(NGAYHOADON) between @ngay1 and @ngay2 GROUP BY HOADONBANHANG.NGAYHOADON";

                cmdHeThong = new SqlCommand(que, cmd.getConnection());
                cmdHeThong.Parameters.Add(new SqlParameter("@ngay1", ngay1));
                cmdHeThong.Parameters.Add(new SqlParameter("@ngay2", ngay2));
                cmdHeThong.Parameters.Add(new SqlParameter("@thang1", thang1));
                cmdHeThong.Parameters.Add(new SqlParameter("@thang2", thang2));
                cmdHeThong.Parameters.Add(new SqlParameter("@nam1", nam1));
                cmdHeThong.Parameters.Add(new SqlParameter("@nam2", nam2));
                doanhthu = Double.Parse(cmdHeThong.ExecuteScalar().ToString());
            }
            cmd.close();
            return doanhthu;
        }
        private void dateTimePickerDenNgay_ValueChanged(object sender, EventArgs e)
        {
    
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'quanLiBanHang_DotNetDataSet2.HOADONBANHANG' table. You can move, or remove it, as needed.
            this.hOADONBANHANGTableAdapter.Fill(this.quanLiBanHang_DotNetDataSet2.HOADONBANHANG);

        }

        private void dataGridViewThongTinHoaDonBanHang_MouseClick(object sender, MouseEventArgs e)
        {
            cmd = new Sqlcommands();
            string mahd = dataGridViewThongTinHoaDonBanHang.CurrentRow.Cells[0].Value.ToString();
            SqlDataAdapter dap = new SqlDataAdapter("SELECT *FROM CHITIETHOADONBANHANG WHERE IDHOADON=@ID", cmd.getConnection());
            dap.SelectCommand.Parameters.Add(new SqlParameter("@ID", mahd));
            dt = new DataTable();
            dap.Fill(dt);
            dataGridViewChiTietHoaDonBanHang.DataSource = dt;
            cmd.close();
        }

        private void btnLapBaoCaoHD_Click(object sender, EventArgs e)
        {
            string ngay1 = dateTimePickerTuNgay.Value.Day.ToString();
            string thang1 = dateTimePickerTuNgay.Value.Month.ToString();
            string nam1 = dateTimePickerTuNgay.Value.Year.ToString(); 
            string ngay2 = dateTimePickerDenNgay.Value.Day.ToString(); 
            string thang2 = dateTimePickerDenNgay.Value.Month.ToString();
            string nam2 = dateTimePickerDenNgay.Value.Year.ToString();
            string tungay = dateTimePickerTuNgay.Value.ToShortDateString();
            string denngay = dateTimePickerDenNgay.Value.ToShortDateString();
            string tongtien = Convert.ToString(tinhtongdoanhthu());
            string sl = Convert.ToString(tinhtongsoluong());
            frmInBaoCaoDoanhThuBanHang f = new frmInBaoCaoDoanhThuBanHang(ngay1, ngay2, thang1, thang2, nam1, nam2, tongtien, sl,tungay, denngay);
            f.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmd = new Sqlcommands();
            int ngay1 = dateTimePickerTuNgay.Value.Day;
            int thang1 = dateTimePickerTuNgay.Value.Month;
            int nam1 = dateTimePickerTuNgay.Value.Year;
            int ngay2 = dateTimePickerDenNgay.Value.Day;
            int thang2 = dateTimePickerDenNgay.Value.Month;
            int nam2 = dateTimePickerDenNgay.Value.Year;
            if (cmd.open())
            {
                if (kiemtrangaythangnam())
                {
                    //string s = "update DOCGIA set HoDocGia='" + 
                    //hoDocGia + "',TenLotDocGia= '" + tenLotDocGia + "',
                    //      TenDocGia='" + tenDocGia + "',GioiTinh=" + gioiTinh + ",
                    //  NgaySinh='" + ngaySinh + "',Sonha='" + soNha + "',Duong='" + duong + "'
                    //    ,Quan='" + quan + "',SoDienThoai='" + soDienThoai + "',NgayDangKi='" 
                    //+ ngayDK + "',NgayHethanDK='" + ngayHetHanDK + "' where MaDocGia='" + maDocGia + "'";
                    string[] thanso = { "ngay1", "thang1", "nam1", "ngay2", "thang2", "nam2" };
                    string[] giatri = { ngay1 + "", thang1 + "", nam1 + "", ngay2 + "", thang2 + "", nam2 + "" };
                    dt = cmd.getDataTableStoredProcedure(thanso, giatri, "BAOCAODOANHTHUBANHANG");

                    dataGridViewThongTinHoaDonBanHang.DataSource = dt;
                    //txtTongSLHD.Text = tinhtongsoluong() + "";
                }
                else
                {
                    MessageBox.Show("Thông Tin Ngày Tháng Không Hợp Lệ");
                }
            }

            cmd.close();
            txtTongSLHD.Text = tinhtongsoluong() + "";

            txtTongDoanhThuHD.Text = tinhtongdoanhthu() + "";
        }
    }
}
