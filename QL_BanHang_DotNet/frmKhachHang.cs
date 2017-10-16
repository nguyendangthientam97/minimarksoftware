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
    public partial class frmKhachHang : Form
    {
        SqlCommand cmd;
        SqlConnection con = new SqlConnection(@"
        Data Source=THIENTAM\SQLEXPRESS;Initial Catalog
        =QuanLiBanHang_DotNet;Integrated Security=True");
        SqlDataAdapter sda;
        DataTable tb;
        SqlCommandBuilder cbl;
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadThongTinKhachHang()
        {
            con.Open();
            string que = "SElect *FROM LOAIKHACHHANG WHERE IDLOAIKHACHHANG=@ID";
            sda = new SqlDataAdapter(que, con);
            sda.SelectCommand.Parameters.Add(new SqlParameter("@ID", txtMaNV.Text));
            
            tb = new DataTable();
            sda.Fill(tb);
            dataGridViewKhacHAng.DataSource = tb;
            con.Close();
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            LoadThongTinKhachHang();

        }
    }
}
