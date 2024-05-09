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
    public partial class FLichSuDatVe : Form
    {
        string manguoidi;
        public FLichSuDatVe(string manguoidi)
        {
            this.manguoidi = manguoidi;
            InitializeComponent();
        }

        private void FLichSuDatVe_Load(object sender, EventArgs e)
        {
            DBConnection conn=new DBConnection();
            dtgLichSuDatVe.DataSource = conn.LichSuDatVe(manguoidi);
            dtgLichSuDatVe.Columns[0].Width = 60;
            dtgLichSuDatVe.Columns[0].HeaderText = "Mã vé";
            dtgLichSuDatVe.Columns[1].Width = 60;
            dtgLichSuDatVe.Columns[1].HeaderText = "Số ghế";
            dtgLichSuDatVe.Columns[2].Width = 120;
            dtgLichSuDatVe.Columns[2].HeaderText = "Loại vé";
            dtgLichSuDatVe.Columns[3].Width = 100;
            dtgLichSuDatVe.Columns[3].HeaderText = "Ngày mua";
            dtgLichSuDatVe.Columns[4].Width = 90;
            dtgLichSuDatVe.Columns[4].HeaderText = "Tổng chi phí";
            dtgLichSuDatVe.Columns[5].Width = 90;
            dtgLichSuDatVe.Columns[5].HeaderText = "Nơi đi";
            dtgLichSuDatVe.Columns[6].Width = 100;
            dtgLichSuDatVe.Columns[6].HeaderText = "Nơi đến";
            dtgLichSuDatVe.Columns[7].Width = 200;
            dtgLichSuDatVe.Columns[7].HeaderText = "Thời gian đi";
            dtgLichSuDatVe.Columns[8].Width = 145;
            dtgLichSuDatVe.Columns[8].HeaderText = "Thời gian đến";
            dtgLichSuDatVe.Columns[9].Width = 50;
            dtgLichSuDatVe.Columns[9].HeaderText = "Mã chuyến";
        }

        private void dtgLichSuDatVe_DoubleClick(object sender, EventArgs e)
        {
            int row = dtgLichSuDatVe.CurrentCell.RowIndex;
            string loaive= dtgLichSuDatVe.Rows[row].Cells[2].Value.ToString();
            string MaVe = dtgLichSuDatVe.Rows[row].Cells[0].Value.ToString();
            string MaCB = dtgLichSuDatVe.Rows[row].Cells[9].Value.ToString();
            if(loaive=="hạng phổ thông")
                MessageBox.Show("Loại vé của bạn không thể đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
    
                MessageBoxManager.Yes = "Đổi vé";
                MessageBoxManager.No = "Hủy vẻ";
                MessageBoxManager.Cancel = "Đánh giá";
                MessageBoxManager.Register();
                DialogResult dialogResult = MessageBox.Show("Xin lựa chọn yêu cầu của bạn!", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if(dialogResult == DialogResult.Yes)
                {
                    FDoiVe doive = new FDoiVe(MaVe, MaCB);
                    this.Hide();
                    doive.ShowDialog();
                    this.Close();
                }
                else if(dialogResult == DialogResult.No)
                {
                    DBConnection conn = new DBConnection();
                    conn.ThemYeuCauXoaVe(MaVe);
                    MessageBox.Show("Đã gửi yêu cầu hủy vé!");
                    this.Close();
                }
                else
                {
                    FThemDanhGia thongTinKH = new FThemDanhGia(manguoidi,MaCB);
                    this.Hide();
                    thongTinKH.ShowDialog();
                    this.Close();
                }
                MessageBoxManager.Unregister();
            }
        }
    }
}
