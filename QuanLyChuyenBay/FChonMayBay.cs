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
    public partial class FChonMayBay : Form
    {
        public FChonMayBay()
        {
            InitializeComponent();
        }
        public string MaMB;
        private void dtgTimKiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dtgTimKiem.CurrentCell.RowIndex;
            string MaMB = dtgTimKiem.Rows[row].Cells[0].Value.ToString();
            this.MaMB = MaMB;
            this.Close();
        }

        private void FChonMayBay_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgTimKiem.DataSource = conn.ThongKeMayBay();

            dtgTimKiem.Columns[0].Width = 60;
            dtgTimKiem.Columns[0].HeaderText = "Số hiệu máy bay";
            dtgTimKiem.Columns[1].Width = 70;
            dtgTimKiem.Columns[1].HeaderText = "Hãng máy bay";
            dtgTimKiem.Columns[2].Width = 75;
            dtgTimKiem.Columns[2].HeaderText = "Năm sản xuất";
            dtgTimKiem.Columns[3].Width = 150;
            dtgTimKiem.Columns[3].HeaderText = "Tên loại";
            dtgTimKiem.Columns[4].Width = 155;
            dtgTimKiem.Columns[4].HeaderText = "Số lượng ghế";
        }
    }
}
