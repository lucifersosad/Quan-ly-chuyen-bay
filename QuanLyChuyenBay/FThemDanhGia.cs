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
    public partial class FThemDanhGia : Form
    {
        public FThemDanhGia(string maKH, string maCB)
        {
            this.MaCB = maCB;
            this.MaKH = maKH;
            InitializeComponent();
        }
        string MaKH;
        string MaCB;
        private void button1_Click(object sender, EventArgs e)
        {
          
            DBConnection conn = new DBConnection();
            conn.ThemDanhGia(MaKH, MaCB, cbxDiem.Text, txtNhanXet.Text);
            this.Close();

        }
    }
}
