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
    public partial class FrmCDTaiKhoan : Form
    {
        string path = @"DataSource=(local);Initial Catalog=DA_QL_CuaHang_MayTinh;Integrated Security=True";
        SqlConnection sqlcon;
        DataSet ds = new DataSet();
        public FrmCDTaiKhoan()
        {
            InitializeComponent();
            sqlcon = new SqlConnection(KetNoi.connectionstring);
            SqlDataAdapter da = new SqlDataAdapter("select * from TK_NHANVIEN", sqlcon);
            da.Fill(ds, "TK_NHANVIEN");
        }
        //public void showDataToCombobox_MA_TB()
        //{
        //    try
        //    {
        //        cbbchucvu.DataSource = null;
        //        if (ds.Tables["TK_NHANVIEN"].Rows.Count != 0)
        //        {

        //            cbbchucvu.DataSource = ds.Tables["TK_NHANVIEN"];
        //            cbbchucvu.DisplayMember = "CV";
        //            cbbchucvu.ValueMember = "CV";
        //            if (cbbchucvu.Items.Count != 0)
        //            {
        //                cbbchucvu.SelectedItem = cbbchucvu.Items[0];


        //            }
        //        }
        //    }
        //    catch { }
        //}

       

        private void FrmCDTaiKhoan_Load(object sender, EventArgs e)
        {
            //showDataToCombobox_MA_TB();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           
        }

        private void rdbTaoMoi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbXoa_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
           
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                
                txtpass.UseSystemPasswordChar = txtNhapLaiPass.UseSystemPasswordChar = false;
            }
            else
            {
                
                txtpass.UseSystemPasswordChar = txtNhapLaiPass.UseSystemPasswordChar = true;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon = new SqlConnection(path);
                sqlcon.Open();
                string a = txtpass.Text;
                string b = txtNhapLaiPass.Text;
                if (a == b)
                {
                    string str = "select count(*) from TK_NHANVIEN where TK = '" + txtUser.Text + "' ";
                    if ((txtUser.Text) == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (txtpass.Text == "")
                    {
                        MessageBox.Show("Bạn chưa nhập mật khẩu", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand com = new SqlCommand(str, sqlcon);
                        int i = Convert.ToInt16(com.ExecuteScalar());
                        com.Dispose();
                        if (i == 0)
                        {
                            MessageBox.Show("Tài khoản đã được đăng kí. Vui lòng dùng tên khác!", "Thông báo", MessageBoxButtons.OKCancel);
                            txtUser.Focus();
                            txtpass.Text = "";
                            txtUser.Text = "";
                        }
                        else if (i != 0)
                        {
                            string s = "insert into TK_NHANVIEN values ('" + txtUser.Text + "','" + txtpass.Text + "')";
                            SqlCommand comm = new SqlCommand(s, sqlcon);
                            comm.ExecuteNonQuery();
                            comm.Dispose();
                            MessageBox.Show("Đăng kí thành công","Thông báo",MessageBoxButtons.OKCancel);


                            this.Hide();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu của bạn không khớp", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtpass.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thao tác không thực hiện được. Vui Lòng kiểm tra lại","Thông báo",MessageBoxButtons.OKCancel);
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
