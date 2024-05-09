using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyChuyenBay
{
    public partial class FThongTinVe : Form
    {

        public FThongTinVe(ModelDatVe datVe)
        {
            this.DatVe = datVe;
            InitializeComponent();
        }
        public FThongTinVe(string maVe,string MaCB)
        {
            this.mave = maVe;
            this.MaCB = MaCB;
            InitializeComponent();
        }
        ModelDatVe DatVe = new ModelDatVe();
        private System.Windows.Forms.Button lastClickedButton = null;
        string mave;
        string MaCB;
        private void FThongTinVe_Load(object sender, EventArgs e)
        {
            string cb;
            rbtnPhoThong.Checked = true;
            DBConnection conn = new DBConnection();
            DataSet dt = new DataSet();
            if (mave == null)
                cb = DatVe.GetMaCB();
            else
                cb = MaCB;
            dt = conn.InThongTinVe(cb);
            txtMaChuyenBay.Text = dt.Tables[0].Rows[0][0].ToString();
            txtNoiDi.Text = dt.Tables[0].Rows[0][1].ToString();
            txtNoiDen.Text= dt.Tables[0].Rows[0][2].ToString();
            DateTime ThoiGianKH = (DateTime)dt.Tables[0].Rows[0][3];
            txtThoiGianKH.Text = ThoiGianKH.ToString("dd/MM/yyyy");
            DateTime ThoiGianDen = (DateTime)dt.Tables[0].Rows[0][4];
            txtThoiGianDen.Text = ThoiGianDen.ToString("dd/MM/yyyy");
            txtHang.Text= dt.Tables[0].Rows[0][10].ToString();
            //----------------
            string ghe= conn.LayGhe(cb);
            int TongSoGhe = ghe.Length;
            foreach (Control button in this.panel1.Controls)
            {
                if (button is System.Windows.Forms.Button btn)
                {
                    string stt = button.Text;
                    int sothutu = Int32.Parse(stt)-1;
                    if (sothutu < TongSoGhe)
                    {
                        if (ghe[sothutu] == '1')
                        {
                            button.BackColor = Color.Red;
                            button.Enabled = false;
                        }
                        else button.BackColor = Color.White;
                    }
                    else button.Visible = false;
                }
            }
        }

        public void Button_Click(object sender, EventArgs e)
        {
            var currentButton = sender as System.Windows.Forms.Button;
            currentButton.BackColor = Color.LightBlue;
            if (lastClickedButton != null && lastClickedButton!=currentButton)
            {
                lastClickedButton.BackColor = Color.White;
            }
            lastClickedButton = currentButton;

        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if(lastClickedButton==null)
            {
                MessageBox.Show("Vui lòng chọn số ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int SoGhe = Int32.Parse(lastClickedButton.Text.ToString());
                DatVe.SetSoGhe(SoGhe);
                if (rbtnPhoThong.Checked == true)
                {
                    DatVe.SetLoaiVe("hạng phổ thông");
                }
                else if (rbtnPhoThongDB.Checked == true)
                {
                    DatVe.SetLoaiVe("hạng phổ thông đặc biệt");
                }
                else DatVe.SetLoaiVe("hạng thương gia");

                FChonDichVu chonDichVu = new FChonDichVu(DatVe);
                this.Hide();
                chonDichVu.ShowDialog();
                this.Close();
            }

        }
    }
}
