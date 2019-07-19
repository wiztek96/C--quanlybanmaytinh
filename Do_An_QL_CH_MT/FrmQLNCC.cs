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
    public partial class FrmQLNCC : Form
    {
        
        public FrmQLNCC()
        {
            InitializeComponent();
            //InitializeComponent();

        }
         SqlConnection sqlcon;
         DataSet ds;
        

        private void FrmQLNCC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dA_QL_CuaHang_MayTinhDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            //this.nHACUNGCAPTableAdapter.Fill(this.dA_QL_CuaHang_MayTinhDataSet.NHACUNGCAP);
            try
            {
                //Bước 1: kết nối
                string ketnoi;
                ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string strsql = "select * from NHACUNGCAP";
                SqlDataAdapter da = new SqlDataAdapter(strsql, sqlcon);
                ds = new DataSet();
                da.Fill(ds);
                dataGridView1DS_NCC.DataSource = ds.Tables[0];
                //Hiện thị dữ liệu ra textbox
                txtMaNCC.DataBindings.Add("Text", ds.Tables[0], "MA_NCC");
                txtTenNCC.DataBindings.Add("Text", ds.Tables[0], "TEN_NCC");
                txtDiaChi.DataBindings.Add("Text", ds.Tables[0], "DIACHI");
                txtSoDienThoai.DataBindings.Add("Text", ds.Tables[0], "DIENTHOAI");
                txtEmail.DataBindings.Add("Text", ds.Tables[0], "EMAIL");

            }
            catch
            {
               // MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
         private void hienthi()
        {
            string strsql1 = "select * from NHACUNGCAP";
            SqlDataAdapter da = new SqlDataAdapter(strsql1, sqlcon);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1DS_NCC.DataSource = ds.Tables[0];

        }


        private void btnThemQLNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnThemQLNCC.Text == "UNLOCK")
                {
                    txtMaNCC.Text = txtTenNCC.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = string.Empty;
                    btnThemQLNCC.Text = "LOCK";
                    btnLuu.Enabled = true;
                   // txtMaNCC.Enabled = true;
                }
                else
                {
                    txtMaNCC.Text = txtTenNCC.Text = txtDiaChi.Text = txtEmail.Text = txtSoDienThoai.Text = string.Empty;
                    btnThemQLNCC.Text = "UNLOCK";
                    btnLuu.Enabled = false;
                    //txtMaNCC.Enabled = false;

                }
            }
            catch { }
        }
       

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql;
                strsql = "insert into NHACUNGCAP values('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDiaChi.Text + "','"+txtSoDienThoai.Text+"','"+txtEmail.Text+"')";
                SqlCommand sqlcom = new SqlCommand(strsql, sqlcon);
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Đã thêm dữ liệu thành công", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
               // btnnhaplai_Click(sender, e);
            }
            catch
            {
                MessageBox.Show("Chưa thêm được đã có Mã NCC này!", "Thêm dữ liệu",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

        }

        private void btnSuaQLNCC_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql;
                strsql = "update NHACUNGCAP set MA_NCC = N'" + txtTenNCC.Text + "', DIACHI = N'" + txtDiaChi.Text + "',DIENTHOAI = '"+txtSoDienThoai.Text+"',EMAIL = '"+txtEmail.Text+"' where MA_NCC='" + txtMaNCC.Text + "'";
                SqlCommand sqlcom = new SqlCommand(strsql, sqlcon);
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật thành công", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
            }
            catch
            {
                MessageBox.Show("Chưa cập nhập được dữ liệu", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1DS_NCC_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void XoaQLNCC_Click(object sender, EventArgs e)
        {
            try
            {
                string strsql;
                strsql = "Delete from NHACUNGCAP where MA_NCC='" + txtMaNCC.Text + "'";
                MessageBox.Show("Mã Nhà cung cấp:" + txtMaNCC.Text);
                SqlCommand sqlcom = new SqlCommand(strsql, sqlcon);
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Đã xóa dữ liệu thành công", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hienthi();
            }
            catch
            {
                MessageBox.Show("Chưa xóa được dữ liệu!", "Xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1DS_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dataGridView1DS_NCC.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView1DS_NCC.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dataGridView1DS_NCC.CurrentRow.Cells[2].Value.ToString();
            txtSoDienThoai.Text = dataGridView1DS_NCC.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1DS_NCC.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string hthi = "select * from NHACUNGCAP where MA_NCC= '" + txtTimKiem.Text + "'";
                SqlCommand cmd = new SqlCommand(hthi, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1DS_NCC.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Lỗi tìm kiếm !!!");
            }
        }
    }
}

    

