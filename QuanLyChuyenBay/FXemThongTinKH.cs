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
    public partial class FXemThongTinKH : Form
    {
        public FXemThongTinKH(ModelDatVe DatVe)
        {
            this.DatVe= DatVe;
            InitializeComponent();
        }

       

        ModelDatVe DatVe=new ModelDatVe();
        string MaNguoiDi;
     

        private void FXemThongTinKH_Load(object sender, EventArgs e)
        {
            rbtnTuDat.Checked = true;
            if(rbtnTuDat.Checked == true)
            {
                string MaKH=DatVe.GetMaNguoiDat();
                DBConnection conn = new DBConnection();
                DataSet dt = conn.LayThongTin(MaKH);
                txtHoTen.Text = dt.Tables[0].Rows[0][1].ToString();
                DateTime NgaySinh = (DateTime)dt.Tables[0].Rows[0][2];
                txtNgaySinh.Text = NgaySinh.ToString("dd/MM/yyyy");
                txtSDT.Text = dt.Tables[0].Rows[0][3].ToString();
                txtDiaChi.Text = dt.Tables[0].Rows[0][4].ToString();
                txtGioiTinh.Text = dt.Tables[0].Rows[0][5].ToString();
                txtCCCD.Text = dt.Tables[0].Rows[0][6].ToString();
                txtHoTen.ReadOnly = true;
                txtNgaySinh.ReadOnly = true; 
                txtSDT.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                txtGioiTinh.ReadOnly = true;
            }
            
        }

        private void rbtnTuDat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnTuDat.Checked == true)
            {
                string MaKH = DatVe.GetMaNguoiDat();
                DBConnection conn = new DBConnection();
                DataSet dt = conn.LayThongTin(MaKH);
                txtHoTen.Text = dt.Tables[0].Rows[0][1].ToString();
                DateTime NgaySinh = (DateTime)dt.Tables[0].Rows[0][2];
                txtNgaySinh.Text = NgaySinh.ToString("dd/MM/yyyy");
                txtSDT.Text = dt.Tables[0].Rows[0][3].ToString();
                txtDiaChi.Text = dt.Tables[0].Rows[0][4].ToString();
                txtGioiTinh.Text = dt.Tables[0].Rows[0][5].ToString();
                txtCCCD.Text = dt.Tables[0].Rows[0][6].ToString();
                txtHoTen.ReadOnly = true;
                txtNgaySinh.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtCCCD.ReadOnly = true;
                txtGioiTinh.ReadOnly = true;
               
            }
        }

        private void rbtnDatDum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDatDum.Checked == true)
            {
                txtHoTen.Text = "";
                txtNgaySinh.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtGioiTinh.Text = "";
                txtCCCD.Text = "";
                txtHoTen.ReadOnly = false;
                txtNgaySinh.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtCCCD.ReadOnly = false;
                txtGioiTinh.ReadOnly = false;
               
            }
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            DBConnection conn = new DBConnection();
            DataSet dt = conn.CheckThongTin(txtCCCD.Text);

            if(txtCCCD.Text=="")
            {
                lblBaoLoi.Text = "Vui lòng nhập CCCD trước";
                lblBaoLoi.ForeColor = Color.Red;
            }
            else if (txtCCCD.Text.All(char.IsDigit) == false || (txtCCCD.Text.Length<12 && txtCCCD.Text.Length>0))
            {
                lblBaoLoi.Text = "Vui lòng nhập đúng định dạng CCCD";
                lblBaoLoi.ForeColor = Color.Red;
            }
            else
            {
                lblBaoLoi.Text = "";
            }
            if (lblBaoLoi.Text=="" && dt.Tables[0].Rows.Count!=0)
            {
                txtHoTen.Text = dt.Tables[0].Rows[0][1].ToString();
                DateTime NgaySinh = (DateTime)dt.Tables[0].Rows[0][2];
                txtNgaySinh.Text = NgaySinh.ToString("dd/MM/yyyy");
                txtSDT.Text = dt.Tables[0].Rows[0][3].ToString();
                txtDiaChi.Text = dt.Tables[0].Rows[0][4].ToString();
                txtGioiTinh.Text = dt.Tables[0].Rows[0][5].ToString();
                txtCCCD.Text = dt.Tables[0].Rows[0][6].ToString();
                txtHoTen.ReadOnly = true;
                txtNgaySinh.ReadOnly = true;
                txtSDT.ReadOnly = true;
                txtDiaChi.ReadOnly = true;
                txtGioiTinh.ReadOnly = true;
                MaNguoiDi= dt.Tables[0].Rows[0][0].ToString();
            }
            else
            {
                txtHoTen.Text = "";
                txtNgaySinh.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";
                txtGioiTinh.Text = "";
                txtHoTen.ReadOnly = false;
                txtNgaySinh.ReadOnly = false;
                txtSDT.ReadOnly = false;
                txtDiaChi.ReadOnly = false;
                txtGioiTinh.ReadOnly = false;
            }
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if(txtHoTen.Text!="" && txtNgaySinh.Text!="" 
                && txtGioiTinh.Text!="" && txtSDT.Text!=""&&txtDiaChi.Text!=""&&lblBaoLoi.Text=="" && lblLoiSDT.Text=="")
            {
                if(txtHoTen.ReadOnly==true)
                {
                    DatVe.SetMaNguoiDi(MaNguoiDi);
                }
                else
                {
                    DateTime ngaysinh=DateTime.Parse(txtNgaySinh.Text);
                    DBConnection conn = new DBConnection();
                    MaNguoiDi=conn.ThemKhachHang(txtHoTen.Text, txtDiaChi.Text, txtSDT.Text, txtGioiTinh.Text,ngaysinh.ToString("yyyy/MM/dd"),txtCCCD.Text);
                    DatVe.SetMaNguoiDi(MaNguoiDi);
                }

                FThongTinVe thongTinVe = new FThongTinVe(DatVe);
                this.Hide();
                thongTinVe.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

            DBConnection conn = new DBConnection();
            if (txtSDT.Text.All(char.IsDigit) == false || (txtSDT.Text.Length != 10 && txtSDT.Text.Length >0))
            {
                lblLoiSDT.Text = "Vui lòng nhập đúng định dạng SDT!";
                lblLoiSDT.ForeColor = Color.Red;
            }
            else if (conn.CheckSDT(txtSDT.Text) == false && rbtnTuDat.Checked!=true)
            {
                lblLoiSDT.Text = "Số đã được sử dụng!";
                lblLoiSDT.ForeColor = Color.Red;
            }
            else
                lblLoiSDT.Text = "";
        }
    }
}
