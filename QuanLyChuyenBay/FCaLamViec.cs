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
    public partial class FCaLamViec : Form
    {
        public FCaLamViec(string manhanvien)
        {
            InitializeComponent();
            this.manhanvien = manhanvien;
        }
        string manhanvien;
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgPhanCong.DataSource = conn.XemPhanCong(txtNgay.Value.ToString("yyyy/MM/dd"), manhanvien);
            dtgPhanCong.Columns[0].Width = 100;
            dtgPhanCong.Columns[0].HeaderText = "Mã chuyến bay";
            dtgPhanCong.Columns[1].Width = 100;
            dtgPhanCong.Columns[1].HeaderText = "Thời gian khởi hành";
            dtgPhanCong.Columns[2].Width = 100;
            dtgPhanCong.Columns[2].HeaderText = "Nơi đi";
            dtgPhanCong.Columns[3].Width = 100;
            dtgPhanCong.Columns[3].HeaderText = "Nơi đến";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNgay_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
