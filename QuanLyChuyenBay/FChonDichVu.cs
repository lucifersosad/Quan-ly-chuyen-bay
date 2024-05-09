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
    public partial class FChonDichVu : Form
    {
        public FChonDichVu(ModelDatVe datVe)
        {
            this.DatVe = datVe;
            InitializeComponent();
        }
        ModelDatVe DatVe = new ModelDatVe();
        Dictionary<string, int> maDV = new Dictionary<string, int>();
        int tongtien = 0;
        private void btnLoc_Click(object sender, EventArgs e)
        {
            
            DBConnection conn = new DBConnection();
            int giatien = Int32.Parse(txtGiaTien.Text);
            dtgDichVu.DataSource = conn.TimDichVu(cboLoaiDV.Text,giatien);
            if(dtgDichVu.Columns.Count==3)
            {
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                column.HeaderText = "Chọn";
                column.Name = "Chon";
                //dtgDichVu.Columns.Add(column);
                dtgDichVu.Columns.Insert(3, column);
                dtgDichVu.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            }
            else
            {
                dtgDichVu.Columns.Remove("Chon");
                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                column.HeaderText = "Chọn";
                column.Name = "Chon";
                //dtgDichVu.Columns.Add(column);
                dtgDichVu.Columns.Insert(3, column);
                dtgDichVu.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }


        private void btnThemDV_Click(object sender, EventArgs e)
        {
           
             
             foreach (DataGridViewRow row in dtgDichVu.Rows)
             {

                if (row.Cells[3].Value != null && (bool)row.Cells[3].Value)
                {
                    if (maDV.ContainsKey(row.Cells[0].Value.ToString()))
                        maDV[row.Cells[0].Value.ToString()]++;
                    else
                        maDV.Add(row.Cells[0].Value.ToString(),1);


                    int giatien2 = Int32.Parse(row.Cells[2].Value.ToString());
                    tongtien += giatien2;
       
                    ListViewItem dichvu = new ListViewItem(row.Cells[0].Value.ToString());

                    ListViewItem.ListViewSubItem tendichvu = new ListViewItem.ListViewSubItem(dichvu, row.Cells[1].Value.ToString());
                    dichvu.SubItems.Add(tendichvu);

                    ListViewItem.ListViewSubItem giatien = new ListViewItem.ListViewSubItem(dichvu, row.Cells[2].Value.ToString());
                    dichvu.SubItems.Add(giatien);
               

                    ListViewItem.ListViewSubItem soluong = new ListViewItem.ListViewSubItem(dichvu, maDV[row.Cells[0].Value.ToString()].ToString());
                    dichvu.SubItems.Add(soluong);

                    lvDichVu.Items.Add(dichvu);
                }
             }

             foreach(ListViewItem item in lvDichVu.Items)
             {
                if (item.SubItems[0].Text == "Tổng" || item.SubItems[3].Text != maDV[item.SubItems[0].Text].ToString() )
                {
                    item.Remove();
                }
             }
           
            ListViewItem Tong = new ListViewItem("Tổng");
            ListViewItem.ListViewSubItem TienTong = new ListViewItem.ListViewSubItem(Tong, tongtien.ToString());
            ListViewItem.ListViewSubItem rong = new ListViewItem.ListViewSubItem(Tong, "");
            Tong.SubItems.Add(rong);
            Tong.SubItems.Add(TienTong);
            lvDichVu.Items.Add(Tong);
            Tong.Font = new Font(lvDichVu.Font, FontStyle.Bold);


        }

        private void txtDatVe_Click(object sender, EventArgs e)
        {
            DatVe.SetmaDV(maDV);
            DBConnection conn = new DBConnection();
            string mave=conn.ThemVeVaDichVu(DatVe);
            int sokg=Int32.Parse(txtkg.Text);
            conn.ThemHanhLy(mave, sokg);
            FVe InRaVe = new FVe(mave);
            this.Hide();
            InRaVe.ShowDialog();
            this.Close();
        }

    }
}
