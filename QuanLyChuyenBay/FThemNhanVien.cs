using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChuyenBay
{
    public partial class FThemNhanVien : Form
    {
        public FThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection(); 
            conn.ThemNhanVien(txtTaiKhoan.Text,txtMatKhau.Text,txtTenNhanVien.Text,txtGioiTinh.Text,txtNgaySinh.Value.ToString("yyyy/MM/dd"),txtSDT.Text,txtCCCD.Text,txtDiaChi.Text,txtLoaiNV.Text,txtLuong.Text);
        }
    }
}
