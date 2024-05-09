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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                Global.username = txtTenTaiKhoan.Text;
                Global.password = txtMatKhau.Text;
                DBConnection conn = new DBConnection();
                string kq = conn.DangNhap(txtTenTaiKhoan.Text, txtMatKhau.Text);
                if (kq.Substring(0, 2) == "KH")
                {
                    FKhachHang KhachHang = new FKhachHang(kq);
                    this.Hide();
                    KhachHang.ShowDialog();
                    this.Close();
                }
                else if (kq.Substring(0, 2) == "CC")
                {
                    FNhanVienCapCao nvcc = new FNhanVienCapCao(kq);
                    this.Hide();
                    nvcc.ShowDialog();
                    this.Close();
                }
                else
                {
                    FNhanVien nv = new FNhanVien(kq);
                    this.Hide();
                    nv.ShowDialog();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai tài khoản hoặc mật khẩu!");
            }
            
        }

        private void linklblDangKi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FDangKy dangky = new FDangKy();
            dangky.ShowDialog();         
        }
    }
}
