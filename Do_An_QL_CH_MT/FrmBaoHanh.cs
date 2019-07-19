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
    public partial class FrmBaoHanh : Form
    {
        public FrmBaoHanh()
        {
            InitializeComponent();
        }

        private void FrmBaoHanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dA_QL_CuaHang_MayTinhDataSet1.BAOHANH' table. You can move, or remove it, as needed.
            //this.bAOHANHTableAdapter.Fill(this.dA_QL_CuaHang_MayTinhDataSet1.BAOHANH);
            hienthi();
            binding();
        }
        private void hienthi()
        {
            try
            {
                string ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string hthi = "select * from BAOHANH";
                SqlCommand cmd = new SqlCommand(hthi, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBaoHanh.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không thể tải CSDL", "Có lỗi xảy ra !!!");
            }
        }
        private void binding()
        {
            txtmakh.DataBindings.Clear();
            txtmakh.DataBindings.Add("Text", dataGridViewBaoHanh.DataSource, "MA_HD");
            txtmapc.DataBindings.Clear();
            txtmapc.DataBindings.Add("Text", dataGridViewBaoHanh.DataSource, "MA_TB");
            txtnv.DataBindings.Clear();
            txtnv.DataBindings.Add("Text", dataGridViewBaoHanh.DataSource, "MA_NVBH");
            txtnbh.DataBindings.Clear();
            txtnbh.DataBindings.Add("Text", dataGridViewBaoHanh.DataSource, "NGAY_BH");
            txttbh.DataBindings.Clear();
            txttbh.DataBindings.Add("Text", dataGridViewBaoHanh.DataSource, "NGAYTRA_BH");
            txtgchu.DataBindings.Clear();
            txtgchu.DataBindings.Add("Text", dataGridViewBaoHanh.DataSource, "GHI_CHU");
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                string add = "insert into BAOHANH values ('" + txtmakh.Text + "','" + txtnv.Text + "','" + txtmapc.Text + "','" + txtnbh.Text + "','" + txttbh.Text + "',N'" + txtgchu.Text + "')";
                cmd.Connection = sqlcon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = add;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm thành công !", "Thông báo !!!");
                hienthi();
                binding();
            }
            catch
            {
                MessageBox.Show("Không thể thêm !", "Xảy ra lỗi kiểm tra lại khóa chính");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                string hthi = "select * from BAOHANH where MA_HD= '" + txttim.Text + "'";
                SqlCommand cmd = new SqlCommand(hthi, sqlcon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewBaoHanh.DataSource = dt;
            }
            catch
            {
               MessageBox.Show("Lỗi tìm kiếm !!!");
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                string sua = @"update BAOHANH set MA_NVBH='" + txtnv.Text + "',MA_TB='" + txtmapc.Text + "',NGAY_BH='" + txtnbh.Text + "',NGAYTRA_BH='" + txttbh.Text + "',GHI_CHU='" + txtgchu.Text + "'where MA_HD='" + txtmakh.Text + "'";
                cmd.Connection = sqlcon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sua;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã sửa thành công !", "Thông báo !!!");
                hienthi();
                binding();
            }
            catch
            {
                //MessageBox.Show("Không thể sửa !", "Xảy ra lỗi");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                string ketnoi = @"Data Source=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
                SqlConnection sqlcon = new SqlConnection(ketnoi);
                sqlcon.Open();
                SqlCommand cmd = new SqlCommand();
                string del = @"delete from BAOHANH where MA_HD ='" + txtmakh.Text + "'";
                cmd.Connection = sqlcon;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = del;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công !", "Thông báo !!!");
                hienthi();
                binding();
            }
            catch
            {
                MessageBox.Show("Không thể xóa !", "Xảy ra lỗi");
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtmakh.Text = "";
            txtmapc.Text = "";
            txtgchu.Text = "";
            txtnbh.Text = "";
            txtnv.Text = "";
            txttbh.Text = "";
           
        }
    }
}
