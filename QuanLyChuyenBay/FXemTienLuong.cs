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
    public partial class FXemTienLuong : Form
    {
        public FXemTienLuong(string manhanvien)
        {
            this.manhanvien = manhanvien;
            InitializeComponent();
        }
        string manhanvien;
        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgTimKiem.DataSource = conn.XemTienLuong(txtThoiGianDau.Value.ToString("yyyy/MM/dd"), txtThoiGianCuoi.Value.ToString("yyyy/MM/dd"),manhanvien);
            dtgTimKiem.Columns[0].Width = 60;
            dtgTimKiem.Columns[0].HeaderText = "Mã chuyến bay";
            dtgTimKiem.Columns[1].Width = 100;
            dtgTimKiem.Columns[1].HeaderText = "Thời gian khởi hành";
            dtgTimKiem.Columns[2].Width = 100;
            dtgTimKiem.Columns[2].HeaderText = "Thời gian kết thúc";
            dtgTimKiem.Columns[3].Width = 100;
            dtgTimKiem.Columns[3].HeaderText = "Số giờ bay";
            dtgTimKiem.Columns[4].Width = 100;
            dtgTimKiem.Columns[4].HeaderText = "Số tiền";
        }
    }
}
