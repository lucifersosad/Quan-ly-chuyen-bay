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
            txtMaMB.Text = MaMB;
        }

        private void FNhapChuyenBay_Load(object sender, EventArgs e)
        {
            loadChuyenBay(DateTime.Now.ToString("yyyy/MM/dd"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBConnection conn = new DBConnection();
                if (!checkAddFlight())
                {
                    return;
                }
                else
                {
                    String startTime = NgayKhoiHanh.Value.ToString("yyyy/MM/dd HH:mm:ss");
                    String endTime = NgayDenDuKien.Value.ToString("yyyy/MM/dd HH:mm:ss");
                    conn.themChuyenBay(txtNoiDi.Text, txtNoiDen.Text, startTime, endTime, txtMaMB.Text);
                    loadChuyenBay(NgayKhoiHanh.Value.ToString("yyyy/MM/dd"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            loadChuyenBay(txtNgay.Value.ToString("yyyy/MM/dd"));  
        }

        private Boolean checkAddFlight()
        {
            if (NgayKhoiHanh.Value <= DateTime.Now)
            {
                MessageBox.Show("Ngày khởi hành phải lớn hơn thời điểm hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (NgayDenDuKien.Value <= NgayKhoiHanh.Value)
            {
                MessageBox.Show("Thời gian đến dự kiến phải lớn hơn thời gian khởi hành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtNoiDi.Text) || string.IsNullOrEmpty(txtNoiDen.Text) || string.IsNullOrEmpty(txtMaMB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNoiDi.Text == txtNoiDen.Text)
            {
                MessageBox.Show("Nơi đi và nơi đến phải khác nhau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void loadChuyenBay(String ngay)
        {
            try
            {
                DBConnection conn = new DBConnection();
                DataTable flightDt = conn.InChuyenBay(ngay);
                loadData(flightDt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void loadData(DataTable dt)
        {
            dtgXemChuyenBay.DataSource = dt;
            dtgXemChuyenBay.Columns[0].Width = 60;
            dtgXemChuyenBay.Columns[0].HeaderText = "Mã chuyến";
            dtgXemChuyenBay.Columns[1].Width = 60;
            dtgXemChuyenBay.Columns[1].HeaderText = "Số hiệu";
            dtgXemChuyenBay.Columns[2].Visible = false;
            dtgXemChuyenBay.Columns[3].HeaderText = "Nơi đi";
            dtgXemChuyenBay.Columns[3].Width = 75;
            dtgXemChuyenBay.Columns[4].HeaderText = "Nơi đến";
            dtgXemChuyenBay.Columns[4].Width = 75;
            dtgXemChuyenBay.Columns[5].Width = 120;
            dtgXemChuyenBay.Columns[5].HeaderText = "Thời gian khởi hành";
            dtgXemChuyenBay.Columns[6].Width = 120;
            dtgXemChuyenBay.Columns[6].HeaderText = "Thời gian đến dự kiến";
            dtgXemChuyenBay.Columns[7].Visible = false;
            dtgXemChuyenBay.Columns[8].HeaderText = "Trạng thái";
            dtgXemChuyenBay.Columns[8].Width = 90;
        }
    }
}
