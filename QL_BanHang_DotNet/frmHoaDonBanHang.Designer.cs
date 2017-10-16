namespace QL_BanHang_DotNet
{
    partial class frmHoaDonBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBanHang));
            this.btnGhiHang = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuyPhieu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInBill = new System.Windows.Forms.Button();
            this.dataGridViewChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.panelGhiMatHang = new System.Windows.Forms.Panel();
            this.cboDonViTinh = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.panelThanhTien = new System.Windows.Forms.Panel();
            this.richTextBoxTonThanhToan = new System.Windows.Forms.RichTextBox();
            this.txtThueVat = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThoiLai = new System.Windows.Forms.TextBox();
            this.txtKhachDua = new System.Windows.Forms.TextBox();
            this.groupBoxHoaDon = new System.Windows.Forms.GroupBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.cboLoaiKhach = new System.Windows.Forms.ComboBox();
            this.datetimeHoaDon = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDNV = new System.Windows.Forms.TextBox();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.quanLiBanHang_DotNetDataSet = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSet();
            this.cHITIETHOADONBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETHOADONBANHANGTableAdapter = new QL_BanHang_DotNet.QuanLiBanHang_DotNetDataSetTableAdapters.CHITIETHOADONBANHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDonHang)).BeginInit();
            this.panelGhiMatHang.SuspendLayout();
            this.panelThanhTien.SuspendLayout();
            this.groupBoxHoaDon.SuspendLayout();
            this.groupBoxChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHang_DotNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBANHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGhiHang
            // 
            this.btnGhiHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGhiHang.ForeColor = System.Drawing.Color.Blue;
            this.btnGhiHang.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiHang.Image")));
            this.btnGhiHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhiHang.Location = new System.Drawing.Point(879, 3);
            this.btnGhiHang.Name = "btnGhiHang";
            this.btnGhiHang.Size = new System.Drawing.Size(97, 50);
            this.btnGhiHang.TabIndex = 31;
            this.btnGhiHang.Text = "Ghi";
            this.btnGhiHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhiHang.UseVisualStyleBackColor = false;
            this.btnGhiHang.Click += new System.EventHandler(this.btnGhiHang_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDong.ForeColor = System.Drawing.Color.Blue;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(888, 455);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(97, 40);
            this.btnDong.TabIndex = 32;
            this.btnDong.Text = "Đóng";
            this.btnDong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLamMoi.ForeColor = System.Drawing.Color.Blue;
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(327, 455);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(97, 40);
            this.btnLamMoi.TabIndex = 33;
            this.btnLamMoi.Text = "Tạo Mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(114, 455);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuyPhieu
            // 
            this.btnHuyPhieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuyPhieu.ForeColor = System.Drawing.Color.Blue;
            this.btnHuyPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyPhieu.Image")));
            this.btnHuyPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuyPhieu.Location = new System.Drawing.Point(215, 455);
            this.btnHuyPhieu.Name = "btnHuyPhieu";
            this.btnHuyPhieu.Size = new System.Drawing.Size(97, 40);
            this.btnHuyPhieu.TabIndex = 35;
            this.btnHuyPhieu.Text = "Hủy Phiếu";
            this.btnHuyPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuyPhieu.UseVisualStyleBackColor = false;
            this.btnHuyPhieu.Click += new System.EventHandler(this.btnHuyPhieu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(18, 455);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 36;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInBill
            // 
            this.btnInBill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInBill.ForeColor = System.Drawing.Color.Blue;
            this.btnInBill.Image = ((System.Drawing.Image)(resources.GetObject("btnInBill.Image")));
            this.btnInBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInBill.Location = new System.Drawing.Point(436, 455);
            this.btnInBill.Name = "btnInBill";
            this.btnInBill.Size = new System.Drawing.Size(91, 40);
            this.btnInBill.TabIndex = 37;
            this.btnInBill.Text = "In Bill";
            this.btnInBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInBill.UseVisualStyleBackColor = false;
            this.btnInBill.Click += new System.EventHandler(this.btnInBill_Click);
            // 
            // dataGridViewChiTietDonHang
            // 
            this.dataGridViewChiTietDonHang.AllowUserToAddRows = false;
            this.dataGridViewChiTietDonHang.AllowUserToDeleteRows = false;
            this.dataGridViewChiTietDonHang.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietDonHang.Location = new System.Drawing.Point(238, 19);
            this.dataGridViewChiTietDonHang.Name = "dataGridViewChiTietDonHang";
            this.dataGridViewChiTietDonHang.ReadOnly = true;
            this.dataGridViewChiTietDonHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewChiTietDonHang.Size = new System.Drawing.Size(573, 118);
            this.dataGridViewChiTietDonHang.TabIndex = 29;
            this.dataGridViewChiTietDonHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewChiTietDonHang_MouseClick);
            // 
            // panelGhiMatHang
            // 
            this.panelGhiMatHang.Controls.Add(this.cboDonViTinh);
            this.panelGhiMatHang.Controls.Add(this.txtSoLuong);
            this.panelGhiMatHang.Controls.Add(this.label10);
            this.panelGhiMatHang.Controls.Add(this.label17);
            this.panelGhiMatHang.Controls.Add(this.label15);
            this.panelGhiMatHang.Controls.Add(this.btnGhiHang);
            this.panelGhiMatHang.Controls.Add(this.label9);
            this.panelGhiMatHang.Controls.Add(this.label8);
            this.panelGhiMatHang.Controls.Add(this.txtTenHang);
            this.panelGhiMatHang.Controls.Add(this.txtMaHang);
            this.panelGhiMatHang.Controls.Add(this.txtDonGia);
            this.panelGhiMatHang.ForeColor = System.Drawing.Color.Blue;
            this.panelGhiMatHang.Location = new System.Drawing.Point(12, 216);
            this.panelGhiMatHang.Name = "panelGhiMatHang";
            this.panelGhiMatHang.Size = new System.Drawing.Size(979, 61);
            this.panelGhiMatHang.TabIndex = 28;
            // 
            // cboDonViTinh
            // 
            this.cboDonViTinh.FormattingEnabled = true;
            this.cboDonViTinh.Location = new System.Drawing.Point(494, 16);
            this.cboDonViTinh.Name = "cboDonViTinh";
            this.cboDonViTinh.Size = new System.Drawing.Size(65, 21);
            this.cboDonViTinh.TabIndex = 32;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(815, 16);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(44, 20);
            this.txtSoLuong.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(755, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Số Lượng:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(433, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Đơn Vị Tính:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(562, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Đơn Giá Bán:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên Hàng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Hàng:";
            // 
            // txtTenHang
            // 
            this.txtTenHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTenHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenHang.Location = new System.Drawing.Point(231, 16);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(195, 20);
            this.txtTenHang.TabIndex = 2;
            this.txtTenHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenHang_KeyDown);
            // 
            // txtMaHang
            // 
            this.txtMaHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaHang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaHang.Enabled = false;
            this.txtMaHang.Location = new System.Drawing.Point(63, 16);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(89, 20);
            this.txtMaHang.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(639, 16);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(111, 20);
            this.txtDonGia.TabIndex = 2;
            // 
            // panelThanhTien
            // 
            this.panelThanhTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelThanhTien.Controls.Add(this.richTextBoxTonThanhToan);
            this.panelThanhTien.Controls.Add(this.txtThueVat);
            this.panelThanhTien.Controls.Add(this.txtChietKhau);
            this.panelThanhTien.Controls.Add(this.label3);
            this.panelThanhTien.Controls.Add(this.label19);
            this.panelThanhTien.Controls.Add(this.label12);
            this.panelThanhTien.Controls.Add(this.label18);
            this.panelThanhTien.Controls.Add(this.label11);
            this.panelThanhTien.Controls.Add(this.label14);
            this.panelThanhTien.Controls.Add(this.label7);
            this.panelThanhTien.Controls.Add(this.txtThoiLai);
            this.panelThanhTien.Controls.Add(this.txtKhachDua);
            this.panelThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelThanhTien.Location = new System.Drawing.Point(715, 15);
            this.panelThanhTien.Name = "panelThanhTien";
            this.panelThanhTien.Size = new System.Drawing.Size(276, 198);
            this.panelThanhTien.TabIndex = 27;
            // 
            // richTextBoxTonThanhToan
            // 
            this.richTextBoxTonThanhToan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxTonThanhToan.Location = new System.Drawing.Point(112, 83);
            this.richTextBoxTonThanhToan.Name = "richTextBoxTonThanhToan";
            this.richTextBoxTonThanhToan.Size = new System.Drawing.Size(142, 38);
            this.richTextBoxTonThanhToan.TabIndex = 3;
            this.richTextBoxTonThanhToan.Text = "";
            // 
            // txtThueVat
            // 
            this.txtThueVat.Location = new System.Drawing.Point(112, 53);
            this.txtThueVat.Name = "txtThueVat";
            this.txtThueVat.Size = new System.Drawing.Size(142, 20);
            this.txtThueVat.TabIndex = 2;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(112, 22);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(142, 20);
            this.txtChietKhau.TabIndex = 2;
            this.txtChietKhau.TextChanged += new System.EventHandler(this.txtChietKhau_TextChanged);
            this.txtChietKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtChietKhau_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thối Lại:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(258, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Khách Đưa:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Thuế(VAT):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "%";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Chiết Khấu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tổng Thành Tiên:";
            // 
            // txtThoiLai
            // 
            this.txtThoiLai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtThoiLai.Location = new System.Drawing.Point(112, 153);
            this.txtThoiLai.Name = "txtThoiLai";
            this.txtThoiLai.Size = new System.Drawing.Size(142, 20);
            this.txtThoiLai.TabIndex = 2;
            // 
            // txtKhachDua
            // 
            this.txtKhachDua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtKhachDua.Location = new System.Drawing.Point(112, 127);
            this.txtKhachDua.Name = "txtKhachDua";
            this.txtKhachDua.Size = new System.Drawing.Size(142, 20);
            this.txtKhachDua.TabIndex = 2;
            this.txtKhachDua.TextChanged += new System.EventHandler(this.txtKhachDua_TextChanged);
            // 
            // groupBoxHoaDon
            // 
            this.groupBoxHoaDon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxHoaDon.Controls.Add(this.btnLapPhieu);
            this.groupBoxHoaDon.Controls.Add(this.cboLoaiKhach);
            this.groupBoxHoaDon.Controls.Add(this.datetimeHoaDon);
            this.groupBoxHoaDon.Controls.Add(this.txtDiaChi);
            this.groupBoxHoaDon.Controls.Add(this.label13);
            this.groupBoxHoaDon.Controls.Add(this.txtSDT);
            this.groupBoxHoaDon.Controls.Add(this.txtTenKhach);
            this.groupBoxHoaDon.Controls.Add(this.label16);
            this.groupBoxHoaDon.Controls.Add(this.txtIDNV);
            this.groupBoxHoaDon.Controls.Add(this.txtMaHDBan);
            this.groupBoxHoaDon.Controls.Add(this.label6);
            this.groupBoxHoaDon.Controls.Add(this.label2);
            this.groupBoxHoaDon.Controls.Add(this.label5);
            this.groupBoxHoaDon.Controls.Add(this.label4);
            this.groupBoxHoaDon.Controls.Add(this.label1);
            this.groupBoxHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxHoaDon.Location = new System.Drawing.Point(12, 12);
            this.groupBoxHoaDon.Name = "groupBoxHoaDon";
            this.groupBoxHoaDon.Size = new System.Drawing.Size(696, 198);
            this.groupBoxHoaDon.TabIndex = 26;
            this.groupBoxHoaDon.TabStop = false;
            this.groupBoxHoaDon.Text = "Thông Tin Hóa Đơn Bán Hàng";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLapPhieu.ForeColor = System.Drawing.Color.Blue;
            this.btnLapPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.Image")));
            this.btnLapPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLapPhieu.Location = new System.Drawing.Point(435, 96);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(142, 61);
            this.btnLapPhieu.TabIndex = 21;
            this.btnLapPhieu.Text = "Lập Phiếu";
            this.btnLapPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // cboLoaiKhach
            // 
            this.cboLoaiKhach.FormattingEnabled = true;
            this.cboLoaiKhach.Location = new System.Drawing.Point(122, 58);
            this.cboLoaiKhach.Name = "cboLoaiKhach";
            this.cboLoaiKhach.Size = new System.Drawing.Size(142, 21);
            this.cboLoaiKhach.TabIndex = 4;
            // 
            // datetimeHoaDon
            // 
            this.datetimeHoaDon.Location = new System.Drawing.Point(435, 59);
            this.datetimeHoaDon.Name = "datetimeHoaDon";
            this.datetimeHoaDon.Size = new System.Drawing.Size(142, 20);
            this.datetimeHoaDon.TabIndex = 3;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(122, 153);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(142, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Địa Chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(122, 117);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(142, 20);
            this.txtSDT.TabIndex = 2;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(122, 88);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(142, 20);
            this.txtTenKhach.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "SĐT Khách Hàng:";
            // 
            // txtIDNV
            // 
            this.txtIDNV.Location = new System.Drawing.Point(435, 28);
            this.txtIDNV.Name = "txtIDNV";
            this.txtIDNV.Size = new System.Drawing.Size(142, 20);
            this.txtIDNV.TabIndex = 2;
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(122, 24);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.Size = new System.Drawing.Size(142, 20);
            this.txtMaHDBan.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Loại Khách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Hóa Đơn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HD Bán Lẻ:";
            // 
            // groupBoxChiTietHoaDon
            // 
            this.groupBoxChiTietHoaDon.Controls.Add(this.dataGridViewChiTietDonHang);
            this.groupBoxChiTietHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBoxChiTietHoaDon.Location = new System.Drawing.Point(12, 288);
            this.groupBoxChiTietHoaDon.Name = "groupBoxChiTietHoaDon";
            this.groupBoxChiTietHoaDon.Size = new System.Drawing.Size(979, 161);
            this.groupBoxChiTietHoaDon.TabIndex = 39;
            this.groupBoxChiTietHoaDon.TabStop = false;
            this.groupBoxChiTietHoaDon.Text = "Chi Tiết Hóa Đơn Bán Hàng";
            // 
            // quanLiBanHang_DotNetDataSet
            // 
            this.quanLiBanHang_DotNetDataSet.DataSetName = "QuanLiBanHang_DotNetDataSet";
            this.quanLiBanHang_DotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cHITIETHOADONBANHANGBindingSource
            // 
            this.cHITIETHOADONBANHANGBindingSource.DataMember = "CHITIETHOADONBANHANG";
            this.cHITIETHOADONBANHANGBindingSource.DataSource = this.quanLiBanHang_DotNetDataSet;
            // 
            // cHITIETHOADONBANHANGTableAdapter
            // 
            this.cHITIETHOADONBANHANGTableAdapter.ClearBeforeFill = true;
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 507);
            this.Controls.Add(this.groupBoxChiTietHoaDon);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuyPhieu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnInBill);
            this.Controls.Add(this.panelGhiMatHang);
            this.Controls.Add(this.panelThanhTien);
            this.Controls.Add(this.groupBoxHoaDon);
            this.Name = "frmHoaDonBanHang";
            this.Text = "Hóa Đơn Bán Lẻ";
            this.Load += new System.EventHandler(this.frmHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietDonHang)).EndInit();
            this.panelGhiMatHang.ResumeLayout(false);
            this.panelGhiMatHang.PerformLayout();
            this.panelThanhTien.ResumeLayout(false);
            this.panelThanhTien.PerformLayout();
            this.groupBoxHoaDon.ResumeLayout(false);
            this.groupBoxHoaDon.PerformLayout();
            this.groupBoxChiTietHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.quanLiBanHang_DotNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBANHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGhiHang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuyPhieu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInBill;
        private System.Windows.Forms.DataGridView dataGridViewChiTietDonHang;
        private System.Windows.Forms.Panel panelGhiMatHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Panel panelThanhTien;
        private System.Windows.Forms.RichTextBox richTextBoxTonThanhToan;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThoiLai;
        private System.Windows.Forms.TextBox txtKhachDua;
        private System.Windows.Forms.GroupBox groupBoxHoaDon;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.ComboBox cboLoaiKhach;
        private System.Windows.Forms.DateTimePicker datetimeHoaDon;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIDNV;
        private System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxChiTietHoaDon;
        private System.Windows.Forms.ComboBox cboDonViTinh;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThueVat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private QuanLiBanHang_DotNetDataSet quanLiBanHang_DotNetDataSet;
        private System.Windows.Forms.BindingSource cHITIETHOADONBANHANGBindingSource;
        private QuanLiBanHang_DotNetDataSetTableAdapters.CHITIETHOADONBANHANGTableAdapter cHITIETHOADONBANHANGTableAdapter;
    }
}