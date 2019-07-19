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
    public partial class FrmDoiPass : Form
    {
        public FrmDoiPass()
        {
            InitializeComponent();
        }
        public string Ma_NV_DangThaoTac;
        private void FrmDoiPass_Load(object sender, EventArgs e)
        {
            try
            {
                /// An pass
                txtPassHientai.UseSystemPasswordChar = txtPassmoi.UseSystemPasswordChar = txtNhaplaiPass.UseSystemPasswordChar = true;
                //if (Ma_NV_DangThaoTac == "NV00001")
                //{
                //    txt_User.Enabled = true;
                //    txtPassHientai.Enabled = false;
                //}
                //else
                //{
                //    //txt_User.Enabled = false;
                //    txtPassHientai.Enabled = true;
                //}
            }
            catch { }  
        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;

            else
            {
                if (txt_User.TextLength >= 10)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienPass.Checked == true)
            {
                /// Hiện pass
                txtPassHientai.UseSystemPasswordChar = txtPassmoi.UseSystemPasswordChar = txtNhaplaiPass.UseSystemPasswordChar = false;
            }
            else
            {
                /// Ẩn pass
                txtPassHientai.UseSystemPasswordChar = txtPassmoi.UseSystemPasswordChar = txtNhaplaiPass.UseSystemPasswordChar = true;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassmoi.TextLength == 0 || txtNhaplaiPass.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập thông tin đầy đủ");
                    return;

                }
                using (SqlConnection con = new SqlConnection(KetNoi.connectionstring))
                {
                    con.Open();
                    string query;
                    ////-----------------quyen admin

                    //if (Ma_NV_DangThaoTac == "NV00001")
                    //{
                        if (txt_User.TextLength == 0)
                        {
                            MessageBox.Show("Bạn chưa nhập thông tin đầy đủ");
                            return;
                        }
                        //// cau lệnh kiểm tra su tồn tại của user trong csdl TAIKHOAN

                        query = " SELECT COUNT(*) from DANG_NHAP WHERE MA_NV = '" + txt_User.Text + "'";
                        SqlCommand cmd;
                        cmd = new SqlCommand(query, con);
                        int tontai = (int)cmd.ExecuteScalar();
                        if (tontai == 1)/// co ton tại tài khoản này => có thể thay đổi pass
                        {

                            /// kiểm tra 2 lần nhập mã
                            if (txtPassmoi.Text != txtNhaplaiPass.Text)
                            {
                                MessageBox.Show("Hai mật khẩu không trùng nhau. Vui lòng kiểm tra lại");
                                return;
                            }
                            /// ---------------------------------------------------- update
                            query = "  UPDATE DANG_NHAP SET PASS = '" + txtPassmoi.Text + " ' WHERE MA_NV = '" + txt_User.Text + "'";
                            cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản này không tồn tại");
                        }
                    //}
                   
                    /// kiểm tra xem nếu kết nối còn mở thì đóng kết nối đi
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Close();
                    txt_User.Text = txtNhaplaiPass.Text = txtPassHientai.Text = txtPassmoi.Text = "";
                }
            }
            catch { }
        }
    }
}
