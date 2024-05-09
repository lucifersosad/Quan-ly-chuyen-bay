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
    public partial class FXemPhieuChi : Form
    {
        public FXemPhieuChi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgTimKiem.DataSource = conn.XemPhieuChi(txtThoiGianDau.Value.ToString("yyyy/MM/dd"),txtThoiGianCuoi.Value.ToString("yyyy/MM/dd"));
            dtgTimKiem.Columns[0].Width = 60;
            dtgTimKiem.Columns[0].HeaderText = "Mã phiếu chi";
            dtgTimKiem.Columns[1].Width = 70;
            dtgTimKiem.Columns[1].HeaderText = "Mã máy bay";
            dtgTimKiem.Columns[2].Width = 75;
            dtgTimKiem.Columns[2].HeaderText = "Tên phí";
            dtgTimKiem.Columns[3].Width = 150;
            dtgTimKiem.Columns[3].HeaderText = "Ngày xuất phiếu";
            dtgTimKiem.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dtgTimKiem.Columns[4].Width = 155;
            dtgTimKiem.Columns[4].HeaderText = "Số tiền chi";
        }
    }
}
