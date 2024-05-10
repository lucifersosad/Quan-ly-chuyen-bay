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
    public partial class FSoDuTaiKhoan : Form
    {
        public FSoDuTaiKhoan(string maKH)
        {
            this.MaKH = maKH;
            InitializeComponent();
        }
        string MaKH;

        private void FSoDuTaiKhoan_Load(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            loadTaiKhoanNH();
            loadMaTaiKhoanNH();
            int sodu=conn.HienThiSoDu(MaKH);
            txtSoDu.Text=KieuTien(sodu.ToString())+" VNĐ";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoTaiKhoan.Text != "" && txtSoTienNap.Text != "")
                {
                    DBConnection conn = new DBConnection();
                    int tien = Int32.Parse(txtSoTienNap.Text);
                    if (tien <= 0)
                    {
                        MessageBox.Show("Số tiền nạp phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    conn.NapTien(MaKH, tien);
                    MessageBox.Show("Nạp tiền thành công!");
                    int sodu = conn.HienThiSoDu(MaKH);
                    txtSoDu.Text = KieuTien(sodu.ToString()) + " VNĐ";
                    txtSoTienNap.ResetText();
                }
                else
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch 
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

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

        private void loadTaiKhoanNH()
        {
            DBConnection conn = new DBConnection();
            DataSet dsTaiKhoan = conn.XemTaiKhoanNganHang(MaKH);
            DataTable dtTaiKhoan = dsTaiKhoan.Tables[0];

            if (dtTaiKhoan.Rows.Count == 0 ) 
            {
                MessageBox.Show("Bạn chưa có tài khoản ngân hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cbNganHang.DataSource = dtTaiKhoan;
            cbNganHang.DisplayMember = "TenRutGon";
            cbNganHang.ValueMember = "SoTaiKhoanNH";
        }

        private void loadMaTaiKhoanNH()
        {
            if (cbNganHang.SelectedValue != null && !string.IsNullOrEmpty(cbNganHang.SelectedValue.ToString()))
            {
                txtSoTaiKhoan.Text = cbNganHang.SelectedValue.ToString();
            }
            else
            {
                txtSoTaiKhoan.Text = ""; 
            }
        }

        private void cbNganHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadMaTaiKhoanNH();
        }

    }
}
