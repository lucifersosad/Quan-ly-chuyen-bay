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
    public partial class FTimKiemChuyenBay : Form
    {
        public FTimKiemChuyenBay(string MaKH)
        {
            DatVe.SetMaNguoiDat(MaKH);
            InitializeComponent();
        }
        public FTimKiemChuyenBay()
        {
            InitializeComponent();
        }
        ModelDatVe DatVe = new ModelDatVe();
        public string MaCB;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnTimChuyenBay_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection(); 

            if(cboDiemDen.Text==cboDiemDi.Text)
            {
                MessageBox.Show("Vui lòng chọn điểm đi và điểm đến khác nhau", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if(cboDiemDen.Text=="")
            {
                MessageBox.Show("Vui lòng chọn điểm đến", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(cboDiemDi.Text=="")
            {
                dtgTimKiem.DataSource = conn.TimChuyenBay("Khong", cboDiemDen.Text, dtpThoiGianDi.Value.Date);
                dtgTimKiem.Columns[0].Width = 60;
                dtgTimKiem.Columns[0].HeaderText = "Mã chuyến";
                dtgTimKiem.Columns[1].Width = 70;
                dtgTimKiem.Columns[1].HeaderText = "Nơi đi";
                dtgTimKiem.Columns[2].Width = 75;
                dtgTimKiem.Columns[2].HeaderText = "Nơi đến";
                dtgTimKiem.Columns[3].Width = 150;
                dtgTimKiem.Columns[3].HeaderText = "Thời gian khởi hành";
                dtgTimKiem.Columns[4].Width = 155;
                dtgTimKiem.Columns[4].HeaderText = "Thời gian đến dự kiến";
                dtgTimKiem.Columns[5].Width = 76;
                dtgTimKiem.Columns[5].HeaderText = "Phổ thông";
                dtgTimKiem.Columns[6].Width = 77;
                dtgTimKiem.Columns[6].HeaderText = "Phổ thông ĐB";
                dtgTimKiem.Columns[7].Width = 76;
                dtgTimKiem.Columns[7].HeaderText = "Thương gia";
            }
            else
            {
                dtgTimKiem.DataSource = conn.TimChuyenBay(cboDiemDi.Text, cboDiemDen.Text, dtpThoiGianDi.Value.Date);
                dtgTimKiem.Columns[0].Width = 60;
                dtgTimKiem.Columns[0].HeaderText = "Mã chuyến";
                dtgTimKiem.Columns[1].Width = 70;
                dtgTimKiem.Columns[1].HeaderText = "Nơi đi";
                dtgTimKiem.Columns[2].Width = 75;
                dtgTimKiem.Columns[2].HeaderText = "Nơi đến";
                dtgTimKiem.Columns[3].Width = 150;
                dtgTimKiem.Columns[3].HeaderText = "Thời gian khởi hành";
                dtgTimKiem.Columns[4].Width = 155;
                dtgTimKiem.Columns[4].HeaderText = "Thời gian đến dự kiến";
                dtgTimKiem.Columns[5].Width = 76;
                dtgTimKiem.Columns[5].HeaderText = "Phổ thông";
                dtgTimKiem.Columns[6].Width = 77;
                dtgTimKiem.Columns[6].HeaderText = "Phổ thông ĐB";
                dtgTimKiem.Columns[7].Width = 76;
                dtgTimKiem.Columns[7].HeaderText = "Thương gia";

            }
        }
        
        private void dtgTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DatVe.GetMaNguoiDat()==null)
            {
                int row = dtgTimKiem.CurrentCell.RowIndex;
                string MaCB = dtgTimKiem.Rows[row].Cells[0].Value.ToString();
                this.MaCB = MaCB;
                this.Close();
            }
            else
            {
                int row = dtgTimKiem.CurrentCell.RowIndex;
                string MaCB = dtgTimKiem.Rows[row].Cells[0].Value.ToString();
                DatVe.SetMaCB(MaCB);
                FXemThongTinKH thongTinKH = new FXemThongTinKH(DatVe);
                this.Hide();
                thongTinKH.ShowDialog();
                this.Close();
            }
        }
    }
}
