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
    public partial class FVe : Form
    {
        public FVe(string MaVe)
        {
            this.mave = MaVe;
            InitializeComponent();
        }
        string mave;
        
        private void FVe_Load(object sender, EventArgs e)
        {
            try
            {
                DBConnection conn = new DBConnection();
                DataSet dt = conn.XuatVe(mave);
                txtMaVe.Text = dt.Tables[0].Rows[0][0].ToString();
                txtMaNguoiDat.Text = dt.Tables[0].Rows[0][1].ToString();
                txtMaNguoiDi.Text = dt.Tables[0].Rows[0][2].ToString();
                txtMaChuyenBay.Text = dt.Tables[0].Rows[0][3].ToString();
                txtSoGhe.Text = dt.Tables[0].Rows[0][4].ToString();
                txtLoaiVe.Text = dt.Tables[0].Rows[0][5].ToString();
                DateTime NgayMua = (DateTime)dt.Tables[0].Rows[0][6];
                txtNgayMua.Text = NgayMua.ToString("dd/MM/yyyy");
                txtTienVe.Text = KieuTien(dt.Tables[0].Rows[0][7].ToString());
                txtPhiDichVu.Text = KieuTien(dt.Tables[0].Rows[0][8].ToString());
                txtTongChiPhi.Text = KieuTien(dt.Tables[0].Rows[0][9].ToString());

            }
            catch
            {
                this.Close();
            }
        }

        private void btnVeTrangChu_Click(object sender, EventArgs e)
        {
            FKhachHang khachHang = new FKhachHang(txtMaNguoiDat.Text);
            this.Hide();
            khachHang.ShowDialog();
            this.Close();
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
