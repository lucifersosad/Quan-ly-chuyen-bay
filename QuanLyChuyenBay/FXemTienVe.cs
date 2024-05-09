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
    public partial class FXemTienVe : Form
    {
        public FXemTienVe()
        {
            InitializeComponent();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            string tien=conn.XemTienVe(txtThang.Text, txtNam.Text);
            txtTongTien.Text =KieuTien(tien);
        }
        public string KieuTien(string input)
        {
            string a = input;
            string b = "";
            int dem = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                b = b + a[i];
                dem++;
                if (dem % 3 == 0 && i != 0)
                    b = b + ".";
            }
            a = "";
            for (int i = b.Length - 1; i >= 0; i--)
            {
                a = a + b[i];
            }
            return a;
        }
    }
}
