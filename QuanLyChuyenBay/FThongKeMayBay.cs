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
    public partial class FThongKeMayBay : Form
    {
        public FThongKeMayBay()
        {
            InitializeComponent();
        }

        private void FThongKeMayBay_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            dtgInMayBay.DataSource = conn.ThongKeMayBay();

            dtgInMayBay.Columns[0].Width = 60;
            dtgInMayBay.Columns[0].HeaderText = "Số hiệu máy bay";
            dtgInMayBay.Columns[1].Width = 70;
            dtgInMayBay.Columns[1].HeaderText = "Hãng máy bay";
            dtgInMayBay.Columns[2].Width = 75;
            dtgInMayBay.Columns[2].HeaderText = "Năm sản xuất";
            dtgInMayBay.Columns[3].Width = 150;
            dtgInMayBay.Columns[3].HeaderText = "Tên loại";
            dtgInMayBay.Columns[4].Width = 155;
            dtgInMayBay.Columns[4].HeaderText = "Số lượng ghế";
        }
    }
}
