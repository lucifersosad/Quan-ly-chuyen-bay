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
    public partial class FNhanVien : Form
    {
        public FNhanVien(string manhanvien)
        {
            this.manhanvien = manhanvien;
            InitializeComponent();
        }
        string manhanvien;
        private Form FormHienTai; 
        private void MoForm(Form FormCanMo)
        {
            if (FormHienTai != null)
                FormHienTai.Close();
            FormHienTai = FormCanMo;
            FormCanMo.TopLevel = false;
            FormCanMo.FormBorderStyle = FormBorderStyle.None;
            FormCanMo.Dock = DockStyle.Fill;
            panelHienThi.Controls.Add(FormCanMo);
            panelHienThi.Tag = FormCanMo;
            FormCanMo.BringToFront();
            FormCanMo.Show();
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap thongTinKH = new FDangNhap();
            this.Hide();
            thongTinKH.ShowDialog();
            this.Close();
        }

        private void btnXemTienLuong_Click(object sender, EventArgs e)
        {
            FXemTienLuong xemtienve = new FXemTienLuong(manhanvien);
            xemtienve.ShowDialog();
        }

        private void btnLichSuLamViec_Click(object sender, EventArgs e)
        {
            FLichSuLamViec lslv = new FLichSuLamViec(manhanvien);
            lslv.ShowDialog();

        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            FCaLamViec calamviec = new FCaLamViec(manhanvien);
            calamviec.ShowDialog(); 
        }
    }
}
