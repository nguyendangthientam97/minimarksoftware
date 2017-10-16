namespace QL_BanHang_DotNet
{
    partial class frmBaoCaoDoanhThu
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
            this.groupBoxThongTinHoaDonBan = new System.Windows.Forms.GroupBox();
            this.dataGridViewThongTinHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.txtTongSLHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewChiTietHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.groupBoxChiTietHDBanHang = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongDoanhThuHD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLapBaoCaoHD = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.quanLiBanHang_DotNetDataSet = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet();
            this.quanLiBanHangDotNetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLiBanHang_DotNetDataSet2 = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet2();
            this.hOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONBANHANGTableAdapter = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet2TableAdapters.HOADONBANHANGTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxThongTinHoaDonBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinHoaDonBanHang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDonBanHang)).BeginInit();
            this.groupBoxChiTietHDBanHang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHang_DotNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangDotNetDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHang_DotNetDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBANHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinHoaDonBan
            // 
            this.groupBoxThongTinHoaDonBan.Controls.Add(this.dataGridViewThongTinHoaDonBanHang);
            this.groupBoxThongTinHoaDonBan.Location = new System.Drawing.Point(31, 100);
            this.groupBoxThongTinHoaDonBan.Name = "groupBoxThongTinHoaDonBan";
            this.groupBoxThongTinHoaDonBan.Size = new System.Drawing.Size(467, 216);
            this.groupBoxThongTinHoaDonBan.TabIndex = 0;
            this.groupBoxThongTinHoaDonBan.TabStop = false;
            this.groupBoxThongTinHoaDonBan.Text = "Thông Tin Hóa Đơn Bán Hàng";
            // 
            // dataGridViewThongTinHoaDonBanHang
            // 
            this.dataGridViewThongTinHoaDonBanHang.AllowUserToAddRows = false;
            this.dataGridViewThongTinHoaDonBanHang.AllowUserToDeleteRows = false;
            this.dataGridViewThongTinHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThongTinHoaDonBanHang.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewThongTinHoaDonBanHang.Name = "dataGridViewThongTinHoaDonBanHang";
            this.dataGridViewThongTinHoaDonBanHang.ReadOnly = true;
            this.dataGridViewThongTinHoaDonBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThongTinHoaDonBanHang.Size = new System.Drawing.Size(446, 184);
            this.dataGridViewThongTinHoaDonBanHang.TabIndex = 2;
            this.dataGridViewThongTinHoaDonBanHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewThongTinHoaDonBanHang_MouseClick);
            // 
            // txtTongSLHD
            // 
            this.txtTongSLHD.Location = new System.Drawing.Point(160, 359);
            this.txtTongSLHD.Name = "txtTongSLHD";
            this.txtTongSLHD.Size = new System.Drawing.Size(100, 20);
            this.txtTongSLHD.TabIndex = 0;
            this.txtTongSLHD.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Ngày:";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(423, 359);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 47);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dateTimePickerDenNgay);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerTuNgay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(31, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 82);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(100, 41);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(248, 21);
            this.dateTimePickerDenNgay.TabIndex = 5;
            this.dateTimePickerDenNgay.ValueChanged += new System.EventHandler(this.dateTimePickerDenNgay_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến Ngày:";
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(100, 14);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(248, 21);
            this.dateTimePickerTuNgay.TabIndex = 2;
            this.dateTimePickerTuNgay.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridViewChiTietHoaDonBanHang
            // 
            this.dataGridViewChiTietHoaDonBanHang.AllowUserToAddRows = false;
            this.dataGridViewChiTietHoaDonBanHang.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHoaDonBanHang.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewChiTietHoaDonBanHang.Name = "dataGridViewChiTietHoaDonBanHang";
            this.dataGridViewChiTietHoaDonBanHang.ReadOnly = true;
            this.dataGridViewChiTietHoaDonBanHang.Size = new System.Drawing.Size(446, 184);
            this.dataGridViewChiTietHoaDonBanHang.TabIndex = 2;
            // 
            // groupBoxChiTietHDBanHang
            // 
            this.groupBoxChiTietHDBanHang.Controls.Add(this.dataGridViewChiTietHoaDonBanHang);
            this.groupBoxChiTietHDBanHang.Location = new System.Drawing.Point(510, 100);
            this.groupBoxChiTietHDBanHang.Name = "groupBoxChiTietHDBanHang";
            this.groupBoxChiTietHDBanHang.Size = new System.Drawing.Size(467, 216);
            this.groupBoxChiTietHDBanHang.TabIndex = 5;
            this.groupBoxChiTietHDBanHang.TabStop = false;
            this.groupBoxChiTietHDBanHang.Text = "Chi Tiết Hóa Đơn Bán Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tổng SL Hóa Đơn Bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tổng Doanh Thu:";
            // 
            // txtTongDoanhThuHD
            // 
            this.txtTongDoanhThuHD.Location = new System.Drawing.Point(160, 385);
            this.txtTongDoanhThuHD.Name = "txtTongDoanhThuHD";
            this.txtTongDoanhThuHD.Size = new System.Drawing.Size(100, 20);
            this.txtTongDoanhThuHD.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtTimKiem);
            this.groupBox1.Location = new System.Drawing.Point(516, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 85);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Thông Tin Hóa Đơn";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(319, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Tên Hàng";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã Hóa Đơn";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(88, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(304, 20);
            this.txtTimKiem.TabIndex = 0;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLapBaoCaoHD
            // 
            this.btnLapBaoCaoHD.Location = new System.Drawing.Point(310, 359);
            this.btnLapBaoCaoHD.Name = "btnLapBaoCaoHD";
            this.btnLapBaoCaoHD.Size = new System.Drawing.Size(84, 47);
            this.btnLapBaoCaoHD.TabIndex = 3;
            this.btnLapBaoCaoHD.Text = "Lập Báo Cáo";
            this.btnLapBaoCaoHD.UseVisualStyleBackColor = true;
            this.btnLapBaoCaoHD.Click += new System.EventHandler(this.btnLapBaoCaoHD_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(516, 359);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // quanLiBanHang_DotNetDataSet
            // 
            this.quanLiBanHang_DotNetDataSet.DataSetName = "QuanLiBanHang_DotNetDataSet";
            this.quanLiBanHang_DotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLiBanHangDotNetDataSetBindingSource
            // 
            this.quanLiBanHangDotNetDataSetBindingSource.DataSource = this.quanLiBanHang_DotNetDataSet;
            this.quanLiBanHangDotNetDataSetBindingSource.Position = 0;
            // 
            // quanLiBanHang_DotNetDataSet2
            // 
            this.quanLiBanHang_DotNetDataSet2.DataSetName = "QuanLiBanHang_DotNetDataSet2";
            this.quanLiBanHang_DotNetDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBANHANGBindingSource
            // 
            this.hOADONBANHANGBindingSource.DataMember = "HOADONBANHANG";
            this.hOADONBANHANGBindingSource.DataSource = this.quanLiBanHang_DotNetDataSet2;
            // 
            // hOADONBANHANGTableAdapter
            // 
            this.hOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 388);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1020, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLapBaoCaoHD);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTongDoanhThuHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxChiTietHDBanHang);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTongSLHD);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxThongTinHoaDonBan);
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu Bán Hàng";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.groupBoxThongTinHoaDonBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThongTinHoaDonBanHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDonBanHang)).EndInit();
            this.groupBoxChiTietHDBanHang.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHang_DotNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHangDotNetDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHang_DotNetDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBANHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinHoaDonBan;
        private System.Windows.Forms.TextBox txtTongSLHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewThongTinHoaDonBanHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewChiTietHoaDonBanHang;
        private System.Windows.Forms.GroupBox groupBoxChiTietHDBanHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongDoanhThuHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnLapBaoCaoHD;
        private System.Windows.Forms.TextBox textBox2;
        private QuanLiBanHang_DotNetDataSet quanLiBanHang_DotNetDataSet;
        private System.Windows.Forms.BindingSource quanLiBanHangDotNetDataSetBindingSource;
        private QuanLiBanHang_DotNetDataSet2 quanLiBanHang_DotNetDataSet2;
        private System.Windows.Forms.BindingSource hOADONBANHANGBindingSource;
        private QuanLiBanHang_DotNetDataSet2TableAdapters.HOADONBANHANGTableAdapter hOADONBANHANGTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}