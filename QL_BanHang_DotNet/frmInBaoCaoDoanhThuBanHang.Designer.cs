namespace QL_BanHang_DotNet
{
    partial class frmInBaoCaoDoanhThuBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerBaoCaoDoanhThuBanHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLiBanHang_DotNetDataSet3 = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet3();
            this.HOADONBANHANGTableAdapter = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet3TableAdapters.HOADONBANHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBANHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiBanHang_DotNetDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBaoCaoDoanhThuBanHang
            // 
            reportDataSource1.Name = "DataSetBaoCaoHoaDonBanHang";
            reportDataSource1.Value = this.HOADONBANHANGBindingSource;
            this.reportViewerBaoCaoDoanhThuBanHang.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerBaoCaoDoanhThuBanHang.LocalReport.ReportEmbeddedResource = "QL_BanHang_DotNet.CaoCaoDoanhThuBanHang.rdlc";
            this.reportViewerBaoCaoDoanhThuBanHang.Location = new System.Drawing.Point(3, 12);
            this.reportViewerBaoCaoDoanhThuBanHang.Name = "reportViewerBaoCaoDoanhThuBanHang";
            this.reportViewerBaoCaoDoanhThuBanHang.Size = new System.Drawing.Size(697, 383);
            this.reportViewerBaoCaoDoanhThuBanHang.TabIndex = 0;
            this.reportViewerBaoCaoDoanhThuBanHang.Load += new System.EventHandler(this.reportViewerBaoCaoDoanhThuBanHang_Load);
            // 
            // HOADONBANHANGBindingSource
            // 
            this.HOADONBANHANGBindingSource.DataMember = "HOADONBANHANG";
            this.HOADONBANHANGBindingSource.DataSource = this.QuanLiBanHang_DotNetDataSet3;
            // 
            // QuanLiBanHang_DotNetDataSet3
            // 
            this.QuanLiBanHang_DotNetDataSet3.DataSetName = "QuanLiBanHang_DotNetDataSet3";
            this.QuanLiBanHang_DotNetDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HOADONBANHANGTableAdapter
            // 
            this.HOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmInBaoCaoDoanhThuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 407);
            this.Controls.Add(this.reportViewerBaoCaoDoanhThuBanHang);
            this.Name = "frmInBaoCaoDoanhThuBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Bao Cao Doanh Thu Ban Hang";
            this.Load += new System.EventHandler(this.frmInBaoCaoDoanhThuBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HOADONBANHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiBanHang_DotNetDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerBaoCaoDoanhThuBanHang;
        private System.Windows.Forms.BindingSource HOADONBANHANGBindingSource;
        private QuanLiBanHang_DotNetDataSet3 QuanLiBanHang_DotNetDataSet3;
        private QuanLiBanHang_DotNetDataSet3TableAdapters.HOADONBANHANGTableAdapter HOADONBANHANGTableAdapter;
    }
}