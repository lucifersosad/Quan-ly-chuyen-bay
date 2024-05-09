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
    public partial class FDangKy : Form
    {
        public FDangKy()
        {
            InitializeComponent();
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            conn.DangKy(txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, rbtnNam.Checked ? "Nam" : "Nữ", dtpNgaySinh.Value.ToString("yyyy/MM/dd"), txtCCCD.Text, txtTenTaiKhoan.Text, txtMatKhau.Text);
            MessageBox.Show("Đăng ký thành công");
            this.Close();
        }
    }
}
