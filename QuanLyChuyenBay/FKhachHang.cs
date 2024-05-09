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
    public partial class FKhachHang : Form
    {
        public FKhachHang(string MaND)
        {
            this.MaKH = MaND;
            InitializeComponent();
        }
        private Form FormHienTai;
        string MaKH;
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
      

        private void btnTimChuyenBay_Click(object sender, EventArgs e)
        {
            MoForm(new FTimKiemChuyenBay(MaKH));
        }

        private void btnXemLichSu_Click(object sender, EventArgs e)
        {
            MoForm(new FLichSuDatVe(MaKH));
        }

        private void btnSoDuTaiKhoan_Click(object sender, EventArgs e)
        {
            MoForm(new FSoDuTaiKhoan(MaKH));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            FDangNhap thongTinKH = new FDangNhap();
            this.Hide();
            thongTinKH.ShowDialog();
            this.Close();
        }
    }
}
