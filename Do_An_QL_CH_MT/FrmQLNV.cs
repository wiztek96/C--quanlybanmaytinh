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
    public partial class FrmQLNV : Form
    {
        
        //SqlCommand cmd;
        //SqlDataAdapter adapter;
        //SqlConnection conn;
        //DataSet ds = new DataSet();
        SqlConnection con;
        public string manv = "";
        public FrmQLNV()
        {
            InitializeComponent();
        }
        //public void showDataToCombobox_ChucVu()
        //{
        //    try
        //    {
        //        cbbCV.DataSource = null;
        //        if (ds.Tables["NHANVIEN"].Rows.Count != 0)
        //        {

        //            cbbCV.DataSource = ds.Tables["NHANVIEN"];
        //            cbbCV.DisplayMember = "CHUCVU";
        //            cbbCV.ValueMember = "CHUCVU";
        //            if (cbbCV.Items.Count != 0)
        //            {
        //                cbbCV.SelectedItem = cbbCV.Items[0];
        //                //txtTenTB.Text = ds.Tables["THIETBI"].Rows[0][2].ToString();
        //            }

        //        }
        //    }
        //    catch { }
        //}
        //public void showDataToCombobox_GioiTinh()
        //{
        //    try
        //    {
        //        cbbGioiTinh.DataSource = null;
        //        if (ds.Tables["NHANVIEN"].Rows.Count != 0)
        //        {

        //            cbbGioiTinh.DataSource = ds.Tables["NHANVIEN"];
        //            cbbGioiTinh.DisplayMember = "GIOITINH";
        //            cbbGioiTinh.ValueMember = "GIOITINH";
        //            if (cbbGioiTinh.Items.Count != 0)
        //            {
        //                cbbGioiTinh.SelectedItem = cbbCV.Items[0];
                        
        //            }

        //        }
        //    }
        //    catch { }
       // }
        DataSet DATASET_DATABASE()
        {
            DataSet data = new DataSet();
            try
            {
                using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                {
                    con.Open();

                    string query;
                    query = "SELECT * FROM NHANVIEN";
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
                dataGridView_DSNhanVien.DataSource = DATASET_DATABASE().Tables[0];
                int x = dataGridView_DSNhanVien.RowCount;
                for (int i = 1; i <= x; i++)
                {
                    dataGridView_DSNhanVien.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }


        }
        private void FrmQLNV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dA_QL_CuaHang_MayTinhDataSet.NHANVIEN' table. You can move, or remove it, as needed.
           // this.nHANVIENTableAdapter.Fill(this.dA_QL_CuaHang_MayTinhDataSet.NHANVIEN);
            //showDataToCombobox_ChucVu();
            dataGridView_DSNhanVien.Rows.Clear();
           // showDataToCombobox_GioiTinh();
            //cbbCV.SelectedItem = "NHÂN VIÊN";
 
            //txtMaNV.Text = dataGridView_DSNhanVien.CurrentRow.Cells[0].Value.ToString();
            //txtHoTen.Text = dataGridView_DSNhanVien.CurrentRow.Cells[1].Value.ToString();
            //txtDiaChi.Text = dataGridView_DSNhanVien.CurrentRow.Cells[2].Value.ToString();
           // txtDThoai.Text = dataGridView_DSNhanVien.CurrentRow.Cells[2].Value.ToString();
           // cbbCV.Text = dataGridView_DSNhanVien.CurrentRow.Cells[2].Value.ToString();
            
            //hkGTinh.Text = dataGridView_DSNhanVien.CurrentRow.Cells[2].Value.ToString();
            cbbCV.SelectedItem = "NHÂN VIÊN";
            btnLuu.Enabled = false;
            txtMaNV.Enabled = false;
            if (manv != "NV00001")
            {
                btnSua.Enabled = false;
               // btnThem.Enabled = false;
               // btnXoa.Enabled = false;
            }
            loadToDatagridview();
            
        }
        
       
        private void btnThoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            //txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;
            //txtMaNV.Enabled = true;
            //btnLuu.Enabled = true;
            //btnThem.Enabled = false;
            //cbbCV.Enabled = true;
        }

        private void txtDThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                if (!char.IsDigit(e.KeyChar) || txtDThoai.TextLength >= 11 || char.IsWhiteSpace(e.KeyChar))/// so diện thoại phải nhỏ hơn 12
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                /// ---------------------------- điều kiện để thực thi
                if (txtMaNV.TextLength == 0 || txtDThoai.TextLength == 0 || txtDiaChi.TextLength == 0 || txtHoTen.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng điền đây đủ thông tin");
                    return;
                }
               
                using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                {
                    con.Open();
                    string query = "";
                    SqlCommand cmd;
                    int x = 0;
                    ///kiem tra trung mã nhan viên
                    query = " select COUNT(*)  from NHANVIEN where MA_NV = '" + txtMaNV.Text + "'";
                    cmd = new SqlCommand(query, con);
                    x = (int)cmd.ExecuteScalar();
                    if (x == 1)
                    {
                        MessageBox.Show("Mã nhân viên này đã tồn tại");
                        return;
                    }
                    ///----------------------
                    if (chkGTinh.Checked == true)
                        query = " insert into NHANVIEN values ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + "NAM" + "',N'" + dateTimePicker1Ngaysinh.Value.ToString() + "','" + txtDThoai.Text + "',N'" + txtDiaChi.Text + "',N'" + cbbCV.SelectedItem.ToString() + "')";
                    else
                        query = " insert into NHANVIEN values ('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + "NỮ" + "',N'" + dateTimePicker1Ngaysinh.Value.ToString() + "','" + txtDThoai.Text + "',N'" + txtDiaChi.Text + "',N'" + cbbCV.SelectedItem.ToString() + "')";

                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thành công");
                }
                loadToDatagridview();
                txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;
                btnLuu.Enabled = false;
               btnThem.Enabled = true;
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                /// ---------------------------- điều kiện để thực thi
                if (txtDThoai.TextLength == 0 || txtDiaChi.TextLength == 0 || txtHoTen.TextLength == 0)
                {
                    MessageBox.Show("Vui lòng điền đây đủ thông tin");
                    return;
                }
                ////------------------------------------------------end điều kiện
                //try
                //{
                using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                {
                    con.Open();
                    string query = "";
                    SqlCommand cmd;

                    ///----------------------

                    if (chkGTinh.Checked == true)
                        query = " UPDATE NHANVIEN SET TEN_NV = N'" + txtHoTen.Text + "',GIOITINH = N'NAM',NGAYSINH = '" + dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy") + " ',DIACHI =N'" + txtDiaChi.Text + "',CHUCVU = N'" + cbbCV.SelectedItem.ToString() + "' WHERE MA_NV = '" + txtMaNV.Text + "'";
                    else
                        query = " UPDATE NHANVIEN SET TEN_NV = N'" + txtHoTen.Text + "',GIOITINH = N'NỮ',NGAYSINH = '" + dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy") + " ',DIACHI =N'" + txtDiaChi.Text + "',CHUCVU = N'" + cbbCV.SelectedItem.ToString() + "' WHERE MA_NV = '" + txtMaNV.Text + "'";
                    //MessageBox.Show(txtMaNV.Text +"\n"+ txtHoTen.Text+"\n" + txtDThoai.Text+ "\n" +txtDiaChi.Text +"\n"+ cbbCV.SelectedItem.ToString() +"\n"+ dateTimePicker1Ngaysinh.Value.ToString("dd/MM/yyyy"));
                    cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thành công");
                }
                loadToDatagridview();
                txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;

            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    foreach (DataGridViewRow row in dataGridView_DSNhanVien.SelectedRows)
            //    {

            //        DialogResult ok;
            //        ok = MessageBox.Show("Bạn có muốn xóa nhân viên có mã " + dataGridView_DSNhanVien.CurrentRow.Cells[1].Value.ToString() + " ra khổi hệ thống không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //        if (ok == DialogResult.OK)
            //        {

            //            using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
            //            {
            //                con.Open();
                           
            //                string query = " select COUNT(*)  from HOADON_MUA where MA_NV = '" + txtMaNV.Text.ToString().Trim() + "'";
            //                SqlCommand cmd = new SqlCommand(query, con);
            //                int x = (int)cmd.ExecuteScalar();
            //                if (x != 1)
            //                {
            //                    MessageBox.Show("Chưa thể xóa nhân viên này. \nThông tin của nhân viên này có liên quan đến dữ liệu tồn tại trong cơ sở dữ liệu");
            //                    return;
            //                }

            //                query = " select COUNT(*)  from HOADON_BAN where MA_NV = '" + txtMaNV.Text.ToString().Trim() + "'";
            //                cmd = new SqlCommand(query, con);
            //                //x = (int)cmd.ExecuteScalar();
            //                //MessageBox.Show(x.ToString());
            //                //if (x != 0)
            //                //{
            //                //    MessageBox.Show("Chưa thể xóa nhân viên này. \nThông tin của nhân viên này có liên quan đến dữ liệu tồn tại trong cơ sở dữ liệu", "Thông báo");
            //                //    return;
            //                //}
            //                //// -----------------------------------------
            //                query = "DELETE FROM NHANVIEN WHERE MA_NV = '" + dataGridView_DSNhanVien.CurrentRow.Cells[1].Value.ToString() + "";
            //                cmd = new SqlCommand(query, con);
            //                cmd.ExecuteNonQuery();
            //                dataGridView_DSNhanVien.Rows.RemoveAt(dataGridView_DSNhanVien.CurrentRow.Index);
            //                con.Close();
            //                MessageBox.Show("Thành Công");
            //                loadToDatagridview();
            //            }
            //        }
            //    }
            //}
            //catch { }
            
        }
        private void cbbCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtMaNV.Enabled = true;
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua MA_NV la 6 ky tu
            else
            {
                if (txtMaNV.TextLength >= 12)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }

            }
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                if (char.IsDigit(e.KeyChar) || txtHoTen.TextLength >= 59) /// không cho nhập số,quy dinh do dai cua họ tên NV lớn nhất  la 29 ky tu
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtDiaChi.TextLength >= 99 && char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void dataGridView_DSNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView_DSNhanVien.SelectedRows)
                {

                    txtMaNV.Text = row.Cells[1].Value.ToString();
                    txtHoTen.Text = row.Cells[2].Value.ToString();
                    if (row.Cells[3].Value.ToString() == "NAM")
                        chkGTinh.Checked = true;
                    else
                        chkGTinh.Checked = false;
                    string date = row.Cells[4].Value.ToString();
                    DateTime x = new DateTime(int.Parse(date.Substring(6, 4)), int.Parse(date.Substring(3, 2)), int.Parse(date.Substring(0, 2)));
                    dateTimePicker1Ngaysinh.Value = x;
                    txtDThoai.Text = row.Cells[5].Value.ToString();
                    txtDiaChi.Text = row.Cells[6].Value.ToString();
                    cbbCV.SelectedItem = row.Cells[7].Value.ToString();
                    if (txtMaNV.Text.ToString().Trim() == "NV0001")/// không thể chỉnh sửa chức vụ của nhân viên có mã "NV0001"
                    {
                        cbbCV.Enabled = false;
                    }
                    else
                        cbbCV.Enabled = true;
                }

            }
            catch { }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            txtMaNV.Text = txtHoTen.Text = txtDiaChi.Text = txtDThoai.Text = string.Empty;
            txtMaNV.Enabled = true;
            btnLuu.Enabled = true;
            btnSua.Enabled = true;
           // btnXoa.Enabled = true;
            btnThem.Enabled = true;
            cbbCV.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (laqlnv.Left <= this.Width)
            {
                laqlnv.Left = laqlnv.Left + 10;
            }
            else
            {
                laqlnv.Left -= laqlnv.Width;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=DESKTOP-QQK2U38\SQLEXPRESS;Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string hthi = "select * from NHANVIEN where MA_NV= '" + txtTimKiem.Text + "'";
                SqlCommand cmd = new SqlCommand(hthi, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_DSNhanVien.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm !!!");
            }
        }

    }
}
