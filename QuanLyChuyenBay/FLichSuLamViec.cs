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
    public partial class FLichSuLamViec : Form
    {
        public FLichSuLamViec(string manv)
        {
            InitializeComponent();
            this.manv = manv;
        }
        string manv;
        private void FLichSuLamViec_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgTimKiem.DataSource = conn.XemLichSu(manv);
            dtgTimKiem.Columns[0].Width = 60;
            dtgTimKiem.Columns[0].HeaderText = "Nơi đi";
            dtgTimKiem.Columns[1].Width = 70;
            dtgTimKiem.Columns[1].HeaderText = "Nơi đến";
            dtgTimKiem.Columns[2].Width = 100;
            dtgTimKiem.Columns[2].HeaderText = "Thới gian khởi hành";
            dtgTimKiem.Columns[3].Width = 150;
            dtgTimKiem.Columns[3].HeaderText = "Thời gian đến dự kiến";
            dtgTimKiem.Columns[4].Width = 155;
            dtgTimKiem.Columns[4].HeaderText = "Hoành thành";
        }
    }
}
