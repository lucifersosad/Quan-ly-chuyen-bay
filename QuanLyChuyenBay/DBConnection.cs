using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace QuanLyChuyenBay
{
    public class DBConnection
    {

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-GHTIJPNK;Initial Catalog=DoAnSapCuoi;Integrated Security=True");

        SqlConnection connAd = new SqlConnection("Data Source=LAPTOP-GHTIJPNK;Initial Catalog=DoAnSapCuoi;Integrated Security=True");

        //Ham
        public DataTable TimChuyenBay(string noidi, string noiden, DateTime thoigian)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("Select * from TimKiemChuyenBay(N'{0}',N'{1}','{2}')", noidi, noiden, thoigian.ToString("yyyy/MM/dd"));
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        //Ham
        public string DangNhap(string user, string pass)
        {
            try
            {
                connAd.Open();
                string sqlStr = String.Format("declare @result nvarchar(100)  set @result=dbo.DangNhap('{0}','{1}') select @result", user, pass);
                SqlCommand lenh = new SqlCommand(sqlStr, connAd);
                string ma = (string)lenh.ExecuteScalar() as string;
                return ma;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "BỊ LỖI!";
            }
            finally { connAd.Close(); }
        }
        //procedure
        public DataSet LayThongTin(string MaKH)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec LayThongTin '{0}'", MaKH);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        //procedure
        public DataSet CheckThongTin(string CCCD)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec CheckThongTin '{0}'", CCCD);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        //procedure
        public string ThemKhachHang(string HoTen, string DiaChi, string SDT, string GioiTinh, string NgaySinh, string CCCD)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("declare @ma nvarchar(100),@stt int\r\nselect @stt=max(convert(int,SUBSTRING(MaKH,3,9999))) \r\nfrom KhachHang \r\nset @stt=@stt+1\r\nSET @ma = 'KH'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                string ma = (string)lenh.ExecuteScalar() as string;
                string sqlInsert = String.Format("exec ThemKhachHang '{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}'", ma, HoTen, NgaySinh, SDT, DiaChi, GioiTinh, CCCD);
                SqlCommand lenh2 = new SqlCommand(sqlInsert, conn);
                lenh2.ExecuteNonQuery();
                return ma;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        //procedure
        public bool CheckSDT(string SDT)
        {
            conn.Open();
            string sqlStr = String.Format("exec CheckSDT '{0}'", SDT);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataSet dt = new DataSet();
            adapter.Fill(dt);
            conn.Close();
            if (dt.Tables[0].Rows.Count != 0)
                return false;
            return true;
        }
        //procedure
        public DataSet InThongTinVe(string MaCB)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec InThongTinVe '{0}'", MaCB);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }

        //procedure
        public string LayGhe(string MaCB)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec LayGhe '{0}'", MaCB);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                string ghe = (string)lenh.ExecuteScalar() as string;
                return ghe;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //Ham
        public DataTable TimDichVu(string LoaiDV, int GiaTien)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("Select MaDV,TenDV,GiaTien from TimDichVu(N'{0}','{1}')", LoaiDV, GiaTien);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public string ThemVeVaDichVu(ModelDatVe datVe)
        {
            conn.Open();
            string ma;
            try
            {
                string sqlStr1 = String.Format("declare @ma nvarchar(100),@stt int\r\nselect @stt=max(convert(int,SUBSTRING(MaVe,3,9999))) \r\nfrom VeMayBay \r\nset @stt=@stt+1\r\nSET @ma = 'VE'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                SqlCommand lenh1 = new SqlCommand(sqlStr1, conn);
                ma = (string)lenh1.ExecuteScalar() as string;
            }
            catch (Exception ex)
            {
                ma = "VE1";
            }
            try
            {
                string sql = "DECLARE @bangdv AS BangDichVu "; string temp = "";
                foreach (KeyValuePair<string, int> entry in datVe.GetmaDV())
                {
                    temp = String.Format("insert into @bangdv(MADV,SOLUONG) values ('{0}',{1}) ", entry.Key, entry.Value);
                    sql = sql + temp;
                }
                string sqlStr = String.Format("exec ThemVeVaDichVu '{0}','{1}','{2}','{3}',N'{4}','{5}',@bangdv", datVe.GetMaNguoiDat(), datVe.GetMaNguoiDi(), datVe.GetMaCB(), datVe.GetSoGhe(), datVe.GetLoaiVe(), DateTime.Now.ToString("yyyy/MM/dd"));
                sql = sql + sqlStr;
                SqlCommand lenh = new SqlCommand(sql, conn);
                conn.InfoMessage += connection_InfoMessage;
                lenh.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ma;
        }
        //procedre
        public void ThemHanhLy(string mave, int sokg)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec TinhTienHanhLy '{0}','{1}'", sokg, mave);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                //MessageBox.Show("dat hanh ly roi");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public DataSet XuatVe(string MaVe)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("Select * from VeMayBay where MaVe='{0}'", MaVe);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        //Ham
        public DataTable LichSuDatVe(string MaNguoiDi)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("Select * from dbo.XemLichSu('{0}')", MaNguoiDi);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void DoiVe(int soghe, string macb, string mave)
        {
            try
            {
                conn.Open();
                string ma;
                try
                {
                    string sqlStr1 = String.Format("declare @ma nvarchar(100),@stt int\r\nselect @stt=max(convert(int,SUBSTRING(MaYC,3,9999))) \r\nfrom XuLyVe \r\nset @stt=@stt+1\r\nSET @ma = 'YC'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                    SqlCommand lenh1 = new SqlCommand(sqlStr1, conn);
                    ma = (string)lenh1.ExecuteScalar() as string;
                }
                catch (Exception ex)
                {
                    ma = "YC01";
                }
                string ghichu = "Đổi sang chuyến bay: " + macb + " với số ghế: " + soghe;
                DateTime ngay = DateTime.Now;
                string sqlStr = String.Format("insert into XuLyVe values('{0}','{1}',N'Đổi vé','{2}',N'{3}')", ma, mave, ngay.ToString("yyyy/MM/dd hh:mm:ss"), ghichu);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void ThemYeuCauXoaVe(string mave)
        {
            try
            {
                conn.Open();
                string ma;
                try
                {
                    string sqlStr1 = String.Format("declare @ma nvarchar(100),@stt int\r\nselect @stt=max(convert(int,SUBSTRING(MaYC,3,9999))) \r\nfrom XuLyVe \r\nset @stt=@stt+1\r\nSET @ma = 'YC'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                    SqlCommand lenh1 = new SqlCommand(sqlStr1, conn);
                    ma = (string)lenh1.ExecuteScalar() as string;
                }
                catch (Exception ex)
                {
                    ma = "YC01";
                }

                DateTime ngay = DateTime.Now;
                string sqlStr = String.Format("insert into XuLyVe values('{0}','{1}',N'Hủy vé','{2}',null)", ma, mave, ngay.ToString("yyyy/MM/dd hh:mm:ss"));
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public int HienThiSoDu(string MaKH)
        {
            try
            {
                conn.Open();
                string sqlStr1 = String.Format("select SoDuKhaDung from TaiKhoan where MaKH='{0}'", MaKH);
                SqlCommand lenh1 = new SqlCommand(sqlStr1, conn);
                object result = lenh1.ExecuteScalar();
                int ma = Convert.ToInt32(result);
                return ma;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
            finally { conn.Close(); }
        }
        public void NapTien(string MaKH, int tien)
        {
            try
            {
                conn.Open();

                string sqlStr1 = String.Format("update TaiKhoan set SoDuKhaDung=SoDuKhaDung+'{0}' where MaKH='{1}'", tien, MaKH);
                SqlCommand lenh1 = new SqlCommand(sqlStr1, conn);
                lenh1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        //procedure
        public void ThemDanhGia(string MaKH, string MaCB, string SoDiem, string NhanXet)
        {
            try
            {
                conn.Open();
                int diem = Int32.Parse(SoDiem);
                string sqlStr = String.Format("exec ThemDanhGia '{0}','{1}',{2},'{3}'", MaKH, MaCB, diem, NhanXet);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                MessageBox.Show("Thêm đánh giá thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn đã thêm đánh giá cho chuyến bay này rồi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally { conn.Close(); }
        }
        public DataTable ThongKeMayBay()
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from V_XemMayBay");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        //Ham
        public DataTable XemPhieuChi(string thoigiandau, string thoigiancuoi)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from dbo.XemPhieuChi('{0}','{1}')", thoigiandau, thoigiancuoi);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        static void connection_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show(e.Message);
        }
        //Ham
        public string XemTienVe(string thang, string nam)
        {
            try
            {
                conn.Open();
                int thang1 = Int32.Parse(thang);
                int nam1 = Int32.Parse(nam);
                string sqlStr = String.Format("select dbo.XemTienVe({0},{1})", thang1, nam1);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                object result = lenh.ExecuteScalar();
                int ma = Convert.ToInt32(result);
                return ma.ToString();
            }
            catch (Exception ex)
            {
                return "0";
            }
            finally { conn.Close(); }
        }
        //Ham
        public DataTable XemTienLuong(string thoigiandau, string thoigiancuoi, string manhanvien)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from dbo.XemTienLuong('{0}','{1}','{2}')", thoigiandau, thoigiancuoi, manhanvien);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        //Ham
        public DataTable XemLichSu(string manhanvien)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from dbo.XemLichSuNV('{0}')", manhanvien);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataTable XemPhanCong(string ngay, string manhanvien)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec XemPhanCong '{0}','{1}'", ngay, manhanvien);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataTable NhapPhanCong(string ngay)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec NhapPhanCong '{0}'", ngay);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void AddPhanCong(string machuyenbay, string manv)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("insert into PhanCong values('{0}','{1}',N'Đang chờ hoàn thành')", machuyenbay, manv);
                SqlCommand lenh2 = new SqlCommand(sqlStr, conn);
                lenh2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void UpdatePhanCong(string machuyenbaycu, string manvcu, string machuyenbay, string manv, string trangthai)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("update PhanCong set MaChuyenBay='{0}',MaNhanVien='{1}',HoanThanh=N'{2}' where MaChuyenBay='{3}' and MaNhanVien = '{4}' ", machuyenbay, manv, trangthai, machuyenbaycu, manvcu);
                SqlCommand lenh2 = new SqlCommand(sqlStr, conn);
                lenh2.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void AddChuyenBay(string noidi, string noiden, string thoigiankhoihanh, string thoigiandendukien, string mamaybay)
        {
            try
            {
                conn.Open();
                string ma;
                try
                {
                    string sqlStr2 = String.Format("declare @ma nvarchar(100),@stt int\r\nselect @stt=max(convert(int,SUBSTRING(MaChuyenBay,3,9999))) \r\nfrom ChuyenBay \r\nset @stt=@stt+1\r\nSET @ma = 'CB'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                    SqlCommand lenh2 = new SqlCommand(sqlStr2, conn);
                    ma = (string)lenh2.ExecuteScalar() as string;
                }
                catch (Exception ex)
                {
                    ma = "CB1";
                }
                string sqlStr = String.Format("insert into ChuyenBay values('{0}',N'{1}',N'{2}','{3}','{4}',null,N'Chờ cất cánh')", ma, noidi, noiden, thoigiankhoihanh, thoigiandendukien);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                string sqlStr1 = String.Format("insert into ThamGia values('{0}','{1}')", mamaybay, ma);
                SqlCommand lenh1 = new SqlCommand(sqlStr1, conn);
                lenh1.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public DataTable InChuyenBay(string ngay)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from ChuyenBay where CONVERT(DATE,ThoiGianKhoiHanh)='{0}'", ngay);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void DoiVe(string mave, string macb, string soghe)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec DoiVe '{0}','{1}','{2}'", mave, macb, soghe);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void XoaVe(string mave)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("exec XoaVe '{0}'", mave);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public DataTable InXuLyVe()
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from XuLyVe");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public void TuChoiYC(string mave)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("delete from XuLyVe where '{0}'=MaVe", mave);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void DangKy(string HoTen, string DiaChi, string SDT, string GioiTinh, string NgaySinh, string CCCD, string tennguoidung, string matkhau)
        {
            try
            {
                connAd.Open();
                string sqlStr = String.Format("declare @ma nvarchar(100),@stt int\r\nselect @stt=max(convert(int,SUBSTRING(MaKH,3,9999))) \r\nfrom KhachHang \r\nset @stt=@stt+1\r\nSET @ma = 'KH'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                SqlCommand lenh = new SqlCommand(sqlStr, connAd);
                string ma = (string)lenh.ExecuteScalar() as string;
                if (ma == null)
                    ma = "KH01";
                string sqlInsert = String.Format("exec ThemKhachHang '{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}',N'{6}'", ma, HoTen, NgaySinh, SDT, DiaChi, GioiTinh, CCCD);
                SqlCommand lenh2 = new SqlCommand(sqlInsert, connAd);
                lenh2.ExecuteNonQuery();
                //---------------------------------------//
                string MaTaiKhoan = ma.Substring(2);
                MaTaiKhoan = "TKKH" + MaTaiKhoan;

                string sqlStr1 = String.Format("insert into TaiKhoan values('{0}','{1}',N'Khách hàng','{2}',{3},'{4}')", tennguoidung, matkhau, MaTaiKhoan, 0, ma);
                SqlCommand lenh1 = new SqlCommand(sqlStr1, connAd);
                lenh1.ExecuteNonQuery();

                string sqlStr3 = String.Format("exec PhanQuyen '{0}','{1}',N'Khách hàng'", tennguoidung, matkhau);
                SqlCommand lenh3 = new SqlCommand(sqlStr3, connAd);
                lenh3.ExecuteNonQuery();
                //--------------------------------------//

                string sqlTheKH = String.Format("declare @ma nvarchar(100),@stt int select @stt=max(convert(int,SUBSTRING(MaThe,4,9999))) from TheKhachHang set @stt=@stt+1 SET @ma = 'THE'+ CONVERT(NVARCHAR(100), @stt) select @ma");
                SqlCommand lenh4 = new SqlCommand(sqlTheKH, connAd);
                string mathe = (string)lenh4.ExecuteScalar() as string;
                if (mathe == null)
                    ma = "THE01";

                string sqlThemThe = String.Format("insert into TheKhachHang values('{0}',N'Đồng',0,'{1}')", mathe, ma);
                SqlCommand lenh5 = new SqlCommand(sqlThemThe, connAd);
                lenh5.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connAd.Close(); }
        }
        public void ThemNhanVien(string tk, string pass, string tennv, string gioitinh, string ngaysinh, string sdt, string cccd, string diachi, string loainv, string luong)
        {
            try
            {
                conn.Open();
                int luongg = Int32.Parse(luong);
                string sqlStr = String.Format("exec ThemNhanVien '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}'", tk, pass, tennv, gioitinh, ngaysinh, sdt, cccd, diachi, loainv, luongg);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }

        public DataSet XemTaiKhoanNganHang(String MaKH)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from TaiKhoanNH where MaKH = '{0}'", MaKH);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataSet XemMaTaiKhoanNganHang(String MaKH)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("select * from TaiKhoanNH where MaTaiKhoanKH = '{0}'", MaKH);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally { conn.Close(); }
        }
        public DataTable TaoBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;
        }
        public void ThemPhieuChi(string MaPhieuChi, string MaMayBay, string TenPhi, string NgayXuatPhieu, string SoTienChi)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("insert into PhieuChi values (N'{0}',N'{1}',N'{2}','{3}',{4})",MaPhieuChi,MaMayBay,TenPhi,NgayXuatPhieu,SoTienChi);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                MessageBox.Show("Thêm phiếu chi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void SuaPhieuChi(string MaPhieuChi, string MaMayBay, string TenPhi, string NgayXuatPhieu, string SoTienChi)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("update PhieuChi set MaMB=N'{0}',TenPhi=N'{1}',NgayXuatPhieu='{2}',SoTienChi={3} where MaPhieuChi=N'{4}'", MaMayBay, TenPhi, NgayXuatPhieu, SoTienChi, MaPhieuChi);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                MessageBox.Show("Sửa phiếu chi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
        public void XoaPhieuChi(string MaPhieuChi)
        {
            try
            {
                conn.Open();
                string sqlStr = String.Format("delete from PhieuChi where MaPhieuChi=N'{0}'", MaPhieuChi);
                SqlCommand lenh = new SqlCommand(sqlStr, conn);
                lenh.ExecuteNonQuery();
                MessageBox.Show("Xóa phiếu chi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }
        }
    }
    
}
