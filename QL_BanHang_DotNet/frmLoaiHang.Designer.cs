namespace QL_BanHang_DotNet
{
    partial class frmLoaiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiHang));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.listViewDanhSachLoaiHang = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxTimKiemLoaiHang = new System.Windows.Forms.GroupBox();
            this.radioButtonTen = new System.Windows.Forms.RadioButton();
            this.radioButtonMa = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBoxThongTinLoaiHang = new System.Windows.Forms.GroupBox();
            this.richTextBoxMoTa = new System.Windows.Forms.RichTextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDanhSach.SuspendLayout();
            this.groupBoxTimKiemLoaiHang.SuspendLayout();
            this.groupBoxThongTinLoaiHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.ForeColor = System.Drawing.Color.Blue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(229, 401);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.ForeColor = System.Drawing.Color.Blue;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(447, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(84, 40);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.ForeColor = System.Drawing.Color.Blue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(133, 401);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.ForeColor = System.Drawing.Color.Blue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(35, 401);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 40);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.listViewDanhSachLoaiHang);
            this.groupBoxDanhSach.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(30, 96);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(501, 182);
            this.groupBoxDanhSach.TabIndex = 18;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh Sách Loại Hàng";
            this.groupBoxDanhSach.Enter += new System.EventHandler(this.groupBoxDanhSach_Enter);
            // 
            // listViewDanhSachLoaiHang
            // 
            this.listViewDanhSachLoaiHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listViewDanhSachLoaiHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewDanhSachLoaiHang.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listViewDanhSachLoaiHang.FullRowSelect = true;
            this.listViewDanhSachLoaiHang.GridLines = true;
            this.listViewDanhSachLoaiHang.Location = new System.Drawing.Point(15, 19);
            this.listViewDanhSachLoaiHang.Name = "listViewDanhSachLoaiHang";
            this.listViewDanhSachLoaiHang.Size = new System.Drawing.Size(469, 142);
            this.listViewDanhSachLoaiHang.TabIndex = 0;
            this.listViewDanhSachLoaiHang.UseCompatibleStateImageBehavior = false;
            this.listViewDanhSachLoaiHang.View = System.Windows.Forms.View.Details;
            this.listViewDanhSachLoaiHang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewDanhSachLoaiHang_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã Loại Hàng";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Loại Hàng";
            this.columnHeader2.Width = 162;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mô Tả";
            this.columnHeader3.Width = 229;
            // 
            // groupBoxTimKiemLoaiHang
            // 
            this.groupBoxTimKiemLoaiHang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxTimKiemLoaiHang.Controls.Add(this.radioButtonTen);
            this.groupBoxTimKiemLoaiHang.Controls.Add(this.radioButtonMa);
            this.groupBoxTimKiemLoaiHang.Controls.Add(this.txtTimKiem);
            this.groupBoxTimKiemLoaiHang.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxTimKiemLoaiHang.Location = new System.Drawing.Point(28, 21);
            this.groupBoxTimKiemLoaiHang.Name = "groupBoxTimKiemLoaiHang";
            this.groupBoxTimKiemLoaiHang.Size = new System.Drawing.Size(503, 62);
            this.groupBoxTimKiemLoaiHang.TabIndex = 17;
            this.groupBoxTimKiemLoaiHang.TabStop = false;
            this.groupBoxTimKiemLoaiHang.Text = "Tìm Kiếm Loại Hàng";
            // 
            // radioButtonTen
            // 
            this.radioButtonTen.AutoSize = true;
            this.radioButtonTen.Location = new System.Drawing.Point(343, 13);
            this.radioButtonTen.Name = "radioButtonTen";
            this.radioButtonTen.Size = new System.Drawing.Size(92, 17);
            this.radioButtonTen.TabIndex = 5;
            this.radioButtonTen.Text = "Tìm Theo Tên";
            this.radioButtonTen.UseVisualStyleBackColor = true;
            this.radioButtonTen.CheckedChanged += new System.EventHandler(this.radioButtonTen_CheckedChanged);
            this.radioButtonTen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonTen_MouseClick);
            // 
            // radioButtonMa
            // 
            this.radioButtonMa.AutoSize = true;
            this.radioButtonMa.Checked = true;
            this.radioButtonMa.Location = new System.Drawing.Point(77, 13);
            this.radioButtonMa.Name = "radioButtonMa";
            this.radioButtonMa.Size = new System.Drawing.Size(88, 17);
            this.radioButtonMa.TabIndex = 5;
            this.radioButtonMa.TabStop = true;
            this.radioButtonMa.Text = "Tìm Theo Mã";
            this.radioButtonMa.UseVisualStyleBackColor = true;
            this.radioButtonMa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radioButtonMa_MouseClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTimKiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTimKiem.Location = new System.Drawing.Point(77, 36);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(351, 20);
            this.txtTimKiem.TabIndex = 4;
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // groupBoxThongTinLoaiHang
            // 
            this.groupBoxThongTinLoaiHang.Controls.Add(this.richTextBoxMoTa);
            this.groupBoxThongTinLoaiHang.Controls.Add(this.txtMa);
            this.groupBoxThongTinLoaiHang.Controls.Add(this.txtTen);
            this.groupBoxThongTinLoaiHang.Controls.Add(this.label2);
            this.groupBoxThongTinLoaiHang.Controls.Add(this.label3);
            this.groupBoxThongTinLoaiHang.Controls.Add(this.label1);
            this.groupBoxThongTinLoaiHang.Enabled = false;
            this.groupBoxThongTinLoaiHang.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxThongTinLoaiHang.Location = new System.Drawing.Point(30, 291);
            this.groupBoxThongTinLoaiHang.Name = "groupBoxThongTinLoaiHang";
            this.groupBoxThongTinLoaiHang.Size = new System.Drawing.Size(501, 89);
            this.groupBoxThongTinLoaiHang.TabIndex = 24;
            this.groupBoxThongTinLoaiHang.TabStop = false;
            this.groupBoxThongTinLoaiHang.Text = "Thông Tin Loại Hàng";
            // 
            // richTextBoxMoTa
            // 
            this.richTextBoxMoTa.Location = new System.Drawing.Point(282, 25);
            this.richTextBoxMoTa.Name = "richTextBoxMoTa";
            this.richTextBoxMoTa.Size = new System.Drawing.Size(202, 58);
            this.richTextBoxMoTa.TabIndex = 9;
            this.richTextBoxMoTa.Text = "";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(95, 22);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(100, 20);
            this.txtMa.TabIndex = 8;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(95, 63);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(100, 20);
            this.txtTen.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mô Tả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Loại Hành:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã Loại Hàng:";
            // 
            // frmLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 453);
            this.Controls.Add(this.groupBoxThongTinLoaiHang);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.groupBoxTimKiemLoaiHang);
            this.Name = "frmLoaiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Hàng";
            this.Load += new System.EventHandler(this.frmLoaiHang_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            this.groupBoxTimKiemLoaiHang.ResumeLayout(false);
            this.groupBoxTimKiemLoaiHang.PerformLayout();
            this.groupBoxThongTinLoaiHang.ResumeLayout(false);
            this.groupBoxThongTinLoaiHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.ListView listViewDanhSachLoaiHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBoxTimKiemLoaiHang;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBoxThongTinLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonTen;
        private System.Windows.Forms.RadioButton radioButtonMa;
        private System.Windows.Forms.RichTextBox richTextBoxMoTa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
    }
}