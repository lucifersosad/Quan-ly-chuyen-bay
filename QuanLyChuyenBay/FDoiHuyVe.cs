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
    public partial class FDoiHuyVe : Form
    {
        public FDoiHuyVe()
        {
            InitializeComponent();
        }

        private void FDoiHuyVe_Load(object sender, EventArgs e)
        {
            cbxSelect.Text = "Đổi vé";
            DBConnection conn = new DBConnection();
            dtgXuLyYeuCau.DataSource = conn.InXuLyVe();
            dtgXuLyYeuCau.Columns[0].Width = 90;
            dtgXuLyYeuCau.Columns[0].HeaderText = "Mã yêu cầu";
            dtgXuLyYeuCau.Columns[1].Width = 90;
            dtgXuLyYeuCau.Columns[1].HeaderText = "Mã vé";
            dtgXuLyYeuCau.Columns[2].Width = 95;
            dtgXuLyYeuCau.Columns[2].HeaderText = "Loại yêu cầu";
            dtgXuLyYeuCau.Columns[3].Width = 100;
            dtgXuLyYeuCau.Columns[3].HeaderText = "Thời gian yêu cầu";
            dtgXuLyYeuCau.Columns[4].Width = 100;
            dtgXuLyYeuCau.Columns[4].HeaderText = "Ghi chú";
            txtMaVe.Text = "";
            txtChuyenBay.Text = "";
            txtSoGhe.Text = "";
        }

        private void cbxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxSelect.Text=="Hủy vé"|| cbxSelect.Text == "Từ chối yêu cầu")
            {
                lblMaChuyenBay.Visible = false;
                txtChuyenBay.Visible = false;
                lblSoGhe.Visible = false;
                txtSoGhe.Visible = false;
            }
            else
            {
                lblMaChuyenBay.Visible = true;
                txtChuyenBay.Visible = true;
                lblSoGhe.Visible = true;
                txtSoGhe.Visible = true;
            }
        }

     

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            try
            {
                if (cbxSelect.Text == "Đổi vé")
                {
                    conn.DoiVe(txtMaVe.Text, txtChuyenBay.Text, txtSoGhe.Text);
                }
                else if (cbxSelect.Text == "Hủy vé")
                {
                    conn.XoaVe(txtMaVe.Text);
                }
                else
                {
                    conn.TuChoiYC(txtMaVe.Text);
                }
                MessageBox.Show("Xử lý thành công!");
                FDoiHuyVe_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
