namespace QL_BanHang_DotNet
{
    partial class frmInHoaDonBanHang
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
            this.CHITIETHOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLiBanHang_DotNetDataSet1 = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet1();
            this.reportViewerHoaDonBanHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CHITIETHOADONBANHANGTableAdapter = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet1TableAdapters.CHITIETHOADONBANHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHOADONBANHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiBanHang_DotNetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CHITIETHOADONBANHANGBindingSource
            // 
            this.CHITIETHOADONBANHANGBindingSource.DataMember = "CHITIETHOADONBANHANG";
            this.CHITIETHOADONBANHANGBindingSource.DataSource = this.QuanLiBanHang_DotNetDataSet1;
            // 
            // QuanLiBanHang_DotNetDataSet1
            // 
            this.QuanLiBanHang_DotNetDataSet1.DataSetName = "QuanLiBanHang_DotNetDataSet1";
            this.QuanLiBanHang_DotNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewerHoaDonBanHang
            // 
            reportDataSource1.Name = "DataSetInHoaDonBanHang";
            reportDataSource1.Value = this.CHITIETHOADONBANHANGBindingSource;
            this.reportViewerHoaDonBanHang.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerHoaDonBanHang.LocalReport.ReportEmbeddedResource = "QL_BanHang_DotNet.rpInHoaDonBanHang.rdlc";
            this.reportViewerHoaDonBanHang.Location = new System.Drawing.Point(4, 1);
            this.reportViewerHoaDonBanHang.Name = "reportViewerHoaDonBanHang";
            this.reportViewerHoaDonBanHang.Size = new System.Drawing.Size(578, 449);
            this.reportViewerHoaDonBanHang.TabIndex = 0;
            this.reportViewerHoaDonBanHang.Load += new System.EventHandler(this.reportViewerHoaDonBanHang_Load);
            // 
            // CHITIETHOADONBANHANGTableAdapter
            // 
            this.CHITIETHOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmInHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 462);
            this.Controls.Add(this.reportViewerHoaDonBanHang);
            this.Name = "frmInHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmInHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CHITIETHOADONBANHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLiBanHang_DotNetDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerHoaDonBanHang;
        private System.Windows.Forms.BindingSource CHITIETHOADONBANHANGBindingSource;
        private QuanLiBanHang_DotNetDataSet1 QuanLiBanHang_DotNetDataSet1;
        private QuanLiBanHang_DotNetDataSet1TableAdapters.CHITIETHOADONBANHANGTableAdapter CHITIETHOADONBANHANGTableAdapter;
    }
}