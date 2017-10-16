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
    public partial class frmInBaoCaoDoanhThuBanHang : Form
    {
        string ngay1, thang1, nam1, ngay2, thang2, nam2;
        string tongtien;
        string sl;
        string tungay;
        string denngay;
        public frmInBaoCaoDoanhThuBanHang(string n1,string n2,string t1,string t2,string nam1,string nam2,string tong,string
            sl,string tu,string den)
        {
            this.ngay1 = n1;this.ngay2 = n2;this.thang1 = t1;this.thang2 = t2;this.nam1 = nam1;this.nam2 = nam2;
            this.tongtien = tong;this.sl = sl;this.tungay = tu;this.denngay = den;
            InitializeComponent();
        }

        private void frmInBaoCaoDoanhThuBanHang_Load(object sender, EventArgs e)
        {

            Microsoft.Reporting.WinForms.ReportParameter[] pra =
             new Microsoft.Reporting.WinForms.ReportParameter[]
             {
                    new Microsoft.Reporting.WinForms.ReportParameter("tungay",tungay),
                     new Microsoft.Reporting.WinForms.ReportParameter("denngay",denngay),
                      new Microsoft.Reporting.WinForms.ReportParameter("tongtien",tongtien),
                       new Microsoft.Reporting.WinForms.ReportParameter("tongsl",sl),
                   new Microsoft.Reporting.WinForms.ReportParameter("ngay1",ngay1),
                                      new Microsoft.Reporting.WinForms.ReportParameter("thang1",thang1),
                   new Microsoft.Reporting.WinForms.ReportParameter("nam1",nam1),
                   new Microsoft.Reporting.WinForms.ReportParameter("ngay2",ngay2),
                   new Microsoft.Reporting.WinForms.ReportParameter("thang2",thang2),
                   new Microsoft.Reporting.WinForms.ReportParameter("nam2",nam2),



             };
            this.reportViewerBaoCaoDoanhThuBanHang.LocalReport.SetParameters(pra);
            this.HOADONBANHANGTableAdapter.Fill(this.QuanLiBanHang_DotNetDataSet3.HOADONBANHANG, Convert.ToInt32(ngay1),
                 Convert.ToInt32(ngay2), Convert.ToInt32(thang1), Convert.ToInt32(thang2), Convert.ToInt32(nam1), Convert.ToInt32(nam2)
                 );

            this.reportViewerBaoCaoDoanhThuBanHang.RefreshReport();
        }

        private void reportViewerBaoCaoDoanhThuBanHang_Load(object sender, EventArgs e)
        {

        }
    }
}
