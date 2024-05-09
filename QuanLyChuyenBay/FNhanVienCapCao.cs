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
    public partial class FNhanVienCapCao : Form
    {
        public FNhanVienCapCao(string manhanvien)
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
        private void btnThongKeMayBay_Click(object sender, EventArgs e)
        {
            MoForm(new FThongKeMayBay());
        }

        private void btnXemPhieuChi_Click(object sender, EventArgs e)
        {

            MoForm(new FXemPhieuChi());
        }

        private void btnXemTienVe_Click(object sender, EventArgs e)
        {
            FXemTienVe xemtienve = new FXemTienVe();
            xemtienve.ShowDialog();
        }

        private void btnNhapPhanCong_Click(object sender, EventArgs e)
        {
            FNhapPhanCong nhapphancong = new FNhapPhanCong();
            nhapphancong.ShowDialog();
        }

        private void btnNhapChuyenBay_Click(object sender, EventArgs e)
        {
            FNhapChuyenBay nhapChuyenBay = new FNhapChuyenBay();
            nhapChuyenBay.ShowDialog();
        }

        private void btnDoiHuyVe_Click(object sender, EventArgs e)
        {
            FDoiHuyVe doiHuyVe = new FDoiHuyVe();
            doiHuyVe.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap thongTinKH = new FDangNhap();
            this.Hide();
            thongTinKH.ShowDialog();
            this.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {

            FThemNhanVien themNhanVien = new FThemNhanVien();
            themNhanVien.ShowDialog();
        }
    }
}
