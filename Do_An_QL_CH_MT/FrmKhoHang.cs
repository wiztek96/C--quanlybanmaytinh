using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Do_An_QL_CH_MT
{
    public partial class FrmKhoHang : Form
    {
        public string Chu_vu = "";
        string query = "";
        SqlCommand cmd;
        public bool xem = false;
        public FrmKhoHang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            FrmQLNCC fm = new FrmQLNCC();
            fm.ShowDialog();
        }

        private void FrmKhoHang_Load(object sender, EventArgs e)
        {
            showDataToCombobox();
            btnHienThiALL_Click(sender, e);
            loadToDatagridview();
            //txtMaTB.Enabled = false;
            //btnLưu.Enabled = false;
            ///// để làm from thống kê hàng tồn kho
            if (xem == true)
            {
                Chu_vu = "NHÂN VIÊN";
                lbTenForm.Text = "TRÌNH TRẠNG THIẾT BỊ TRONG KHO";
            }

            /////////////////////from Thiết bị
            if (Chu_vu == "NHÂN VIÊN")
            {
                groupBox1.Enabled = false;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        DataSet DATASET_DATABASE()
        {
            DataSet data = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                {
                    con.Open();
                    query = "SELECT LOAI,MA_TB,TEN_TB,TEN_NCC,SOLUONG,TG_BAOHANH,DONGIA_MUA,DONGIA_BAN,NSX FROM THIETBI, NHACUNGCAP WHERE NHACUNGCAP.MA_NCC = THIETBI.MA_NCC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    adapter.Fill(data);
                    con.Close();
                }
            }
            catch { }

            return data;
        }
        
        public void loadToDatagridview()
        {
            try
            {
                dataGridViewKHO.DataSource = DATASET_DATABASE().Tables[0];
            }
            catch { }


        }
        public bool kiemTraMa_TB(string ma_tb)
        {
            using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
            {
                con.Open();

                int x = 0;
                ///kiem tra mã thiết bị
                query = " SELECT count(*) FROM THIETBI WHERE MA_TB = '" + ma_tb + "'";
                cmd = new SqlCommand(query, con);
                x = (int)cmd.ExecuteScalar();
                con.Close();
                if (x == 1)
                    return true;//  ton tai
                return false;

            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
             try
            {
                
            
                 using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                 {
                     con.Open();


                     if (kiemTraMa_TB(txtmatbi.Text.Trim()) == false)
                     {
                         MessageBox.Show("Không có mã thiết bị này trong kho");
                         return;
                     }
                     //// xóa toan bộ thông tin trong datagridviewThIETBI
                     int count = dataGridViewKHO.Rows.Count;
                     for (int i = count - 1; i >= 0; i--)
                     {
                         dataGridViewKHO.Rows.RemoveAt(i);
                     }
                     ////---------------------------------------
                     //// hiển thị thông tin thiết bị  cần tìm lên datagridview
                     DataSet data = new DataSet();
                     query = "SELECT LOAI,MA_TB,TEN_TB,TEN_NCC,SOLUONG,TG_BAOHANH,DONGIA_MUA,DONGIA_BAN,NSX FROM THIETBI, NHACUNGCAP WHERE MA_TB = '" + txtmatbi.Text.Trim() + "' and NHACUNGCAP.MA_NCC = THIETBI.MA_NCC";
                     SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                     adapter.Fill(data);
                     dataGridViewKHO.DataSource = data.Tables[0];
                    
                     con.Close();
                 }
            }
            catch { }
           
            
        }

        private void btnHienThiALL_Click(object sender, EventArgs e)
        {
             loadToDatagridview();
        }
         public void showDataToCombobox()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                {
                    con.Open();
                    string query = "  SELECT MA_NCC,TEN_NCC FROM NHACUNGCAP";
                    cmd = new SqlCommand(query, con);
                    SqlDataAdapter adapter;
                    adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cbbTenNCC.DataSource = table;
                    cbbTenNCC.ValueMember = "MA_NCC";
                    cbbTenNCC.DisplayMember = "TEN_NCC";
                    cbbTenNCC.SelectedItem = cbbTenNCC.Items[0];
                    con.Close();
                }
            }
            catch { }
          


        }

         private void cbbTenNCC_Click(object sender, EventArgs e)
         {
             showDataToCombobox();
         }

         private void btnXoa_Click(object sender, EventArgs e)
         {
             try
             {
                 foreach (DataGridViewRow row in dataGridViewKHO.SelectedRows)
                 {
                     DialogResult ok;
                     ok = MessageBox.Show("Bạn có muốn xóa thiết bị có mã " + dataGridViewKHO.CurrentRow.Cells[1].Value.ToString() + " khỏi hệ thống không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (ok == DialogResult.No)
                         return;
                    
                     using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                     {
                         con.Open();
                         string query = "DELETE THIETBI WHERE MA_TB = '" + dataGridViewKHO.CurrentRow.Cells[1].Value.ToString().Trim() + "'";
                         SqlCommand cmd = new SqlCommand(query, con);
                         cmd.ExecuteNonQuery();

                         dataGridViewKHO.Rows.RemoveAt(dataGridViewKHO.CurrentRow.Index);
                         con.Close();
                         MessageBox.Show("Xóa thành công");
                         loadToDatagridview();

                     }
                 }
             }
             catch { }
         }

         private void btnLưu_Click(object sender, EventArgs e)
         {
             try
             {
                 /// ---------------------------- điều kiện để thực thi
                 if (txtMaTB.TextLength != 6 || txtLoai.TextLength == 0 || txtDonGiaMua.TextLength == 0 || txtDonGiaBan.TextLength == 0 || txtSoluong.TextLength == 0 || txtTenTB.TextLength == 0 || txtThoiGianBH.TextLength == 0 || txtNSX.TextLength == 0)
                 {
                     MessageBox.Show("Vui lòng điền đây đủ thông tin");
                     return;
                 }
                 if (kiemTraMa_TB(txtMaTB.Text) == true)
                 {
                     MessageBox.Show("Mã thiết bị đã tồn tại. Vui lòng nhập mã khác");
                     return;
                 }
                 ////------------------------------------------------end điều kiện

                 using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                 {
                     con.Open();
                     int x = int.Parse(txtThoiGianBH.Text);
                     double s = double.Parse(txtDonGiaBan.Text);
                     query = " INSERT INTO THIETBI VALUES(N'" + txtLoai.Text.Trim() + "','" + txtMaTB.Text + "',N'" + txtTenTB.Text.Trim() + "','" + cbbTenNCC.SelectedValue.ToString().Trim() + "'," + int.Parse(txtSoluong.Text) + "," + int.Parse(txtThoiGianBH.Text) + "," + int.Parse(txtDonGiaMua.Text) + "," + int.Parse(txtDonGiaBan.Text) + ",N'" + txtNSX.Text + "')";
                     cmd = new SqlCommand(query, con);
                     cmd.ExecuteNonQuery();
                     /////=====================
                     con.Close();
                     MessageBox.Show("Thiết bị này đã được thêm với mã là: " + txtMaTB.Text);
                 }
                 loadToDatagridview();
                 txtMaTB.Text = txtLoai.Text = txtDonGiaMua.Text = txtDonGiaBan.Text = txtSoluong.Text = txtTenTB.Text = txtThoiGianBH.Text = txtNSX.Text = string.Empty;
             }
             catch { }
         }

         private void btnSua_Click(object sender, EventArgs e)
         {
             if (dataGridViewKHO.CurrentRow == null)
             {
                 return;

             }

            
             if (txtMaTB.Text == string.Empty || txtLoai.Text == "" || txtDonGiaMua.Text == "" || txtDonGiaBan.Text == "" || txtSoluong.Text == "" || txtTenTB.Text == "" || txtThoiGianBH.Text == "" || txtNSX.Text == string.Empty)
             {
                 MessageBox.Show("Vui lòng điền đây đủ thông tin");
                 return;
             }
            
             using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
             {
                 con.Open();
                 string query = "";
                 SqlCommand cmd;

                 ///----------------------

                 query = " UPDATE THIETBI SET TEN_TB = N'" + txtTenTB.Text.Trim() + "',MA_NCC = '" + cbbTenNCC.SelectedValue.ToString() + "',LOAI = N'" + txtLoai.Text + "', TG_BAOHANH = '" + int.Parse(txtThoiGianBH.Text) + "', DONGIA_MUA= '" + double.Parse(txtDonGiaMua.Text) + "',DONGIA_BAN='" + double.Parse(txtDonGiaBan.Text) + "' ,NSX = '" + txtNSX.Text + "'WHERE MA_TB = '" + dataGridViewKHO.CurrentRow.Cells["Column1"].Value.ToString().Trim() + "'";
                 cmd = new SqlCommand(query, con);
                 cmd.ExecuteNonQuery();
                 con.Close();
                 MessageBox.Show("Cập nhật thành công");
             }
             loadToDatagridview();
         }

         private void dataGridViewKHO_Click(object sender, EventArgs e)
         {
             if (dataGridViewKHO.RowCount != 0)
             {
                 txtMaTB.Text = dataGridViewKHO.CurrentRow.Cells["Column1"].Value.ToString();
                 txtTenTB.Text = dataGridViewKHO.CurrentRow.Cells["Column2"].Value.ToString();
                 txtLoai.Text = dataGridViewKHO.CurrentRow.Cells["Column13"].Value.ToString();
                 txtSoluong.Text = dataGridViewKHO.CurrentRow.Cells["Column15"].Value.ToString();
                 txtThoiGianBH.Text = dataGridViewKHO.CurrentRow.Cells["Column16"].Value.ToString();
                 txtDonGiaMua.Text = dataGridViewKHO.CurrentRow.Cells["Column17"].Value.ToString();
                 txtDonGiaBan.Text = dataGridViewKHO.CurrentRow.Cells["Column18"].Value.ToString();
                 txtNSX.Text = dataGridViewKHO.CurrentRow.Cells["Column19"].Value.ToString(); ;

             }
         }

         private void txtDonGiaBan_TextChanged(object sender, EventArgs e)
         {
             if (txtDonGiaBan.TextLength == 0)
                 return;
             try
             {
                 double x = double.Parse(txtDonGiaBan.Text.ToString());
             }
             catch
             {
                 MessageBox.Show("Bạn phải nhập số");
                 txtDonGiaBan.Text = "0";
             }
         }

         private void txtDonGiaMua_TextChanged(object sender, EventArgs e)
         {
             if (txtDonGiaMua.TextLength == 0)
                 return;
             try
             {
                 double x = double.Parse(txtDonGiaMua.Text.ToString());
             }
             catch
             {
                 MessageBox.Show("Bạn phải nhập số");
                 txtDonGiaMua.Text = "0";
             }
         }

         private void txtSoluong_TextChanged(object sender, EventArgs e)
         {
             if (txtSoluong.Text == "")
             {
                 return;
             }
             try
             {
                 int x = int.Parse(txtSoluong.Text.ToString());
             }
             catch
             {
                 MessageBox.Show("Bạn phải nhập số");
                 txtSoluong.Text = "0";
             }
         }

         private void cbbTenNCC_SelectedIndexChanged(object sender, EventArgs e)
         {
             txtMaTB.Enabled = true;
         }

         private void btnNhapLai_Click(object sender, EventArgs e)
         {
             txtMaTB.Text = "";
             txtLoai.Text = "";
             txtDonGiaBan.Text = "";
             txtDonGiaMua.Text = "";
             txtmatbi.Text = "";
             txtNSX.Text = "";
             txtTenTB.Text = "";
             txtThoiGianBH.Text = "";
             txtSoluong.Text = "";
         }


        
        }
    }

