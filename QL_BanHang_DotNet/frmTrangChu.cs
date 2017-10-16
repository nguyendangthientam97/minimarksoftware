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
    public partial class frmTrangChu : Form
    {   
        public frmTrangChu()
        {
            InitializeComponent();
        }
        private frmMatHang fmatHang;
        private frmLoaiHang floaiHang;
        private frmNhaCungCap fnhaCungCap;
        private frmNhaSanXuat fNhaSanXuat;
        private frmNhanvien fnhanVien;
        private frmNhanvien fkhacHang;
        private frmHangGiamGia fhangGiamGia;
        private frmHoaDonBanHang fhoaDonBan;
        private frmHoaDonNhapHang fhoaDonNhapHang;
        private frmBaoCaoDonDacHang fbaoCaoDacHang;
        private frmBaoCaoHoaDonBanHang fbaoCaoBanHang;
        private frmGioiThieuThongTinSanPham fGioiThieu;
        
        public Boolean CheckForm(string frm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(frm))
                {
                    return true;
                }

            }
            return false;
        }
        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmMatHang") == true)
            {
                fmatHang.Activate();
            }
            else
            {
                fmatHang = new frmMatHang();
                fmatHang.MdiParent = this;
                fmatHang.Show();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // check form

        

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CheckForm("frmLoaiHang"))
                floaiHang.Activate();
            else
            {
                floaiHang = new frmLoaiHang();
                floaiHang.MdiParent = this;
                floaiHang.Show();
            }
        }

        private void nhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmNhaSanXuat"))
                fNhaSanXuat.Activate();
            else
            {
                fNhaSanXuat = new frmNhaSanXuat();
                fNhaSanXuat.MdiParent = this;
                fNhaSanXuat.Show();
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (CheckForm("frmNhanVien"))
                fnhanVien.Activate();
            else
            {
                fnhanVien = new frmNhanvien();
                fnhanVien.MdiParent = this;
                fnhanVien.Show();
            }
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmKhachHang"))
                fkhacHang.Activate();
            else
            {
                fkhacHang = new frmNhanvien();
                fkhacHang.MdiParent = this;
                fkhacHang.Show();
            }
        }



        private void hàngGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmHangGiamGia"))
                fhangGiamGia.Activate();
            else
            {
                fhangGiamGia = new frmHangGiamGia();
                fhangGiamGia.MdiParent = this;
                fhangGiamGia.Show();
            }
        }

      

        private void hóaĐơnBánHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmHoaDonBanHang"))
                fhoaDonBan.Activate();
            else
            {
                fhoaDonBan = new frmHoaDonBanHang();
                fhoaDonBan.MdiParent = this;
                fhoaDonBan.Show();
            }
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmHoaDonNhapHang"))
                fhoaDonNhapHang.Activate();
            else
            {
                fhoaDonNhapHang = new frmHoaDonNhapHang();
                fhoaDonNhapHang.MdiParent = this;
                fhoaDonNhapHang.Show();
            }
        }

     
        private void hóaĐơnBánHàngToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (CheckForm("frmBaoCaoHoaDonBanHang"))
                fbaoCaoBanHang.Activate();
            else
            {
                fbaoCaoBanHang = new frmBaoCaoHoaDonBanHang();
                fbaoCaoBanHang.MdiParent = this;
                fbaoCaoBanHang.Show();
            }
        }

        private void đơnĐặcHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

    

        

        

        private void thôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (CheckForm("frmGioiThieuThongTinSanPham"))
                fGioiThieu.Activate();
            else
            {
                fGioiThieu = new frmGioiThieuThongTinSanPham();
                fGioiThieu.MdiParent = this;
                fGioiThieu.Show();
            }
        }

        private void hướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đang Cập Nhập:");
        }

        private void nhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmNhaCungCap"))
                fnhaCungCap.Activate();
            else
            {
                fnhaCungCap = new frmNhaCungCap();
                fnhaCungCap.MdiParent = this;
                fnhaCungCap.Show();
            }
        }

        private void nhàSảnXuấtToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmNhaSanXuat"))
                fNhaSanXuat.Activate();
            else
            {
                fNhaSanXuat = new frmNhaSanXuat();
                fNhaSanXuat.MdiParent = this;
                fNhaSanXuat.Show();
            }
        }

        private void nhânViênToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmNhanVien"))
                fnhanVien.Activate();
            else
            {
                fnhanVien = new frmNhanvien();
                fnhanVien.MdiParent = this;
                fnhanVien.Show();
            }
        }

        private void kháchHàngToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmKhachHang"))
                fkhacHang.Activate();
            else
            {
                fkhacHang = new frmNhanvien();
                fkhacHang.MdiParent = this;
                fkhacHang.Show();
            }
        }

        private void hóaĐơnBánHàngToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmHoaDonBanHang"))
                fhoaDonBan.Activate();
            else
            {
                fhoaDonBan = new frmHoaDonBanHang();
                fhoaDonBan.MdiParent = this;
                fhoaDonBan.Show();
            }
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmHoaDonNhapHang"))
                fhoaDonNhapHang.Activate();
            else
            {
                fhoaDonNhapHang = new frmHoaDonNhapHang();
                fhoaDonNhapHang.MdiParent = this;
                fhoaDonNhapHang.Show();
            }
        }

        private void đơnĐặcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void thôngTinSảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmGioiThieuThongTinSanPham"))
                fGioiThieu.Activate();
            else
            {
                fGioiThieu = new frmGioiThieuThongTinSanPham();
                fGioiThieu.MdiParent = this;
                fGioiThieu.Show();
            }
        }

        private void mặtHàngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CheckForm("frmMatHang"))
                fGioiThieu.Activate();
            else
            {
                fmatHang = new frmMatHang();
                fmatHang.MdiParent = this;
                fmatHang.Show();
            }
        }

        private void quảnLíNhậpXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
