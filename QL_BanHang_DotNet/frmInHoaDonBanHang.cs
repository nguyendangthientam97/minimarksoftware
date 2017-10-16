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
    public partial class frmInHoaDonBanHang : Form
    {
        private string idhd;
        string ngayhd;
        string tongtien;
        string khachdua;
        string thoilai;
        public frmInHoaDonBanHang(string id,string date,string tong,string khachdua,string thoi)
        {
            this.idhd = id;this.ngayhd = date;this.tongtien = tong;this.khachdua = khachdua;this.thoilai = thoi;
            InitializeComponent();

        }

        private void frmInHoaDonBanHang_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] pra =
               new Microsoft.Reporting.WinForms.ReportParameter[]
               {
                    new Microsoft.Reporting.WinForms.ReportParameter("pIDHD",idhd),
                     new Microsoft.Reporting.WinForms.ReportParameter("pNgayHD",ngayhd),
                      new Microsoft.Reporting.WinForms.ReportParameter("pTongTien",tongtien),
                       new Microsoft.Reporting.WinForms.ReportParameter("pKhachDua",khachdua),
                   new Microsoft.Reporting.WinForms.ReportParameter("pThoiLai",thoilai),


               };
            this.reportViewerHoaDonBanHang.LocalReport.SetParameters(pra);

            // TODO: This line of code loads data into the 'QuanLiBanHang_DotNetDataSet3.CHITIETHOADONBANHANG' table. You can move, or remove it, as needed.
            this.CHITIETHOADONBANHANGTableAdapter.Fill(this.QuanLiBanHang_DotNetDataSet1.CHITIETHOADONBANHANG, Convert.ToInt32(idhd));

            this.reportViewerHoaDonBanHang.RefreshReport();

        }

        private void reportViewerHoaDonBanHang_Load(object sender, EventArgs e)
        {
         
        }
    }
}
