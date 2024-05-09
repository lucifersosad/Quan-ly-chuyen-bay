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
    public partial class FNhapChuyenBay : Form
    {
        public FNhapChuyenBay()
        {
            InitializeComponent();
        }
        public string MaMB;
        private void btnChon_Click(object sender, EventArgs e)
        {
            FChonMayBay chonMayBay = new FChonMayBay();
            chonMayBay.ShowDialog();
            this.MaMB = chonMayBay.MaMB;
            FNhapChuyenBay_Load(sender, e);
        }

        private void FNhapChuyenBay_Load(object sender, EventArgs e)
        {
            txtMaMB.Text = MaMB;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection conn = new DBConnection();
                conn.AddChuyenBay(txtNoiDi.Text, txtNoiDen.Text, NgayKhoiHanh.Value.ToString("yyyy/MM/dd hh:mm:ss"), NgayDenDuKien.Value.ToString("yyyy/MM/dd hh:mm:ss"), txtMaMB.Text);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgXemChuyenBay.DataSource = conn.InChuyenBay(NgayKhoiHanh.Value.ToString("yyyy/MM/dd"));
            dtgXemChuyenBay.Columns[0].Width = 60;
            dtgXemChuyenBay.Columns[0].HeaderText = "Mã chuyến";
            dtgXemChuyenBay.Columns[1].Width = 70;
            dtgXemChuyenBay.Columns[1].HeaderText = "Nơi đi";
            dtgXemChuyenBay.Columns[2].Width = 75;
            dtgXemChuyenBay.Columns[2].HeaderText = "Nơi đến";
            dtgXemChuyenBay.Columns[3].Width = 120;
            dtgXemChuyenBay.Columns[3].HeaderText = "Thời gian khởi hành";
            dtgXemChuyenBay.Columns[4].Width = 120;
            dtgXemChuyenBay.Columns[4].HeaderText = "Thời gian đến dự kiến";
            dtgXemChuyenBay.Columns[5].Visible = false;
            dtgXemChuyenBay.Columns[6].Width = 90;
            dtgXemChuyenBay.Columns[6].HeaderText = "Trạng thái";
        }
    }
}
