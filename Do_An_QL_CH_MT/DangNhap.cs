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
    public partial class DangNhap : Form
    {
        public delegate void sendMessage(string message);
        public event sendMessage sendMessageEvent;
        public DangNhap()
        {
            InitializeComponent();
            txtUser.Focus();
        }
        int sai = 5;
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show(" Bạn có muốn thoát không ?", "Bạn phải đăng nhập để sử dụng ?!?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUser.Focus();

            txtPass.UseSystemPasswordChar = true;
            lbdangnhap.BackColor = Color.Transparent;
            lbpass.BackColor = Color.Transparent;
            lbuser.BackColor = Color.Transparent;
            btnDangNhap.BackColor = Color.Transparent;
            btnThoat.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            ChkHienPass.BackColor = Color.Transparent;
        }

        private void ChkHienPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkHienPass.Checked == true)
                txtPass.UseSystemPasswordChar = false;//// kí tự nhập vào không mã hóa 
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(KetNoi.connectionstring);
                con.Open();
                //string query = "SELECT COUNT(*) FROM DANG_NHAP WHERE MA_NV='" + txtUser.Text + "' AND PASS ='" + txtPass.Text + " ' ";
                //SqlCommand cmd = new SqlCommand(query, con);
                //SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
                //DataTable datatable = new DataTable();
                //sqlda.Fill(datatable);
                //if (datatable.Rows[0][0].ToString() == "1")
                //{
                //    ///// đăng nhập thành công
                //    if (sendMessageEvent != null)
                //    {
                //        sendMessageEvent(txtUser.Text);
                //        con.Close();
                //        this.Close();
                //    }
                //    this.Hide();
                //    MessageBox.Show("Bạn đăng nhập thành công","Thông báo",MessageBoxButtons.OK);
                //    FrmMENU fm = new FrmMENU();
                //    fm.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("User hoặc pass đã sai. Vui lòng xem lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
                //con.Close();
                //return;
                if (txtUser.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập tên tài khoản. Mời bạn kiểm tra lại", "Thông báo", MessageBoxButtons.OKCancel);
                    txtUser.Focus();
                }
                else if (txtPass.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mật khẩu. Mời bạn kiểm tra lại", "Thông báo", MessageBoxButtons.OKCancel);
                    txtPass.Focus();
                }
                string taikhoan = "select count(*) from CHU_CUA_HANG where TK='" + txtUser.Text + "' and MK='" + txtPass.Text + "'";
                SqlCommand sqlcom = new SqlCommand(taikhoan, con);
                int i = Convert.ToInt16(sqlcom.ExecuteScalar());
                sqlcom.Dispose();

                string tk = "select count(*) from TK_NHANVIEN where TK='" + txtUser.Text + "' and MK='" + txtPass.Text + "'";
                SqlCommand com = new SqlCommand(tk, con);
                int j = Convert.ToInt16(com.ExecuteScalar());
                sqlcom.Dispose();
                if (sai > 0)
                {
                    if (i != 0)
                    {
                        this.Hide();
                        MessageBox.Show("XIN CHÀO ÔNG CHỦ !!!","####### Chào mừng quay trở lại ######", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        FrmMENU f = new FrmMENU();
                        f.ShowDialog();
                    }
                    else if (j != 0)
                    {
                        this.Hide();
                        MessageBox.Show("Bạn đã đăng nhập vào tài khoản NHÂN VIÊN ","Hạn chế quyền !!!" ,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        FrmMENU2 f = new FrmMENU2();
                        f.ShowDialog();
                        
                    }
                    else
                    {
                        sai = sai - 1;
                        MessageBox.Show("Username hoặc Password sai! Bạn còn " + sai + " lần đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtUser.Text = "";
                        this.txtPass.Text = "";
                        this.txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã hết lượt truy cập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Đã có lỗi xảy ra. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua MA_NV la 6 ky tu
            else
            {
                if (txtUser.TextLength >= 8)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lbdangnhap.Left <= this.Width)
            {
                lbdangnhap.Left = lbdangnhap.Left + 10;
            }
            else
            {
                lbdangnhap.Left -= lbdangnhap.Width; 
            }
        }

        private void lbdangnhap_Click(object sender, EventArgs e)
        {

        }

    }
}
