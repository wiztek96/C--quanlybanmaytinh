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
    public partial class FrmBanHang : Form
    {
        public string ma_nv = "";
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlConnection conn;
        DataSet ds = new DataSet();
        int khoitao = 0;
        public FrmBanHang()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoi.connectionstring);
            adapter = new SqlDataAdapter("select * from THIETBI", conn);
            adapter.Fill(ds, "THIETBI");
            // tao khoa chinh
            DataColumn[] pk = new DataColumn[1];
            pk[0] = ds.Tables["THIETBI"].Columns[1];
            ds.Tables["THIETBI"].PrimaryKey = pk;
        }
        public void showDataToCombobox_MA_TB()
        {
            try
            {
                cbbMaTB.DataSource = null;
                if (ds.Tables["THIETBI"].Rows.Count != 0)
                { 

                    cbbMaTB.DataSource = ds.Tables["THIETBI"];
                    cbbMaTB.DisplayMember = "MA_TB";
                    cbbMaTB.ValueMember = "MA_TB";
                    if (cbbMaTB.Items.Count != 0)
                    {
                        cbbMaTB.SelectedItem = cbbMaTB.Items[0];
                        txtTenTB.Text = ds.Tables["THIETBI"].Rows[0][2].ToString();
                    }

                }
            }
            catch { }
        }

        private void FrmBanHang_Load(object sender, EventArgs e)
        {
            //txtMaNhanVien.Text = ma_nv;
            showDataToCombobox_MA_TB();
            dataGridView1.Rows.Clear();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount !=0)
            {
                DialogResult ok;
                ok = MessageBox.Show("Bạn có muốn đóng không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                    btnLuu_Click(sender, e);
            }
            this.Close();
        }

        private void cbbMaTB_SelectedValueChanged(object sender, EventArgs e)
        {
            if (khoitao < 2)
            {
                khoitao++;
                return;
            }

            if (cbbMaTB.SelectedItem == null)
                return;
            DataRow r = ds.Tables["THIETBI"].Rows.Find(cbbMaTB.SelectedValue.ToString());
            if (r == null)
            {
                MessageBox.Show("Chưa có mã thiết bị để bán");
                return;
            }
            txtTenTB.Text = r[2].ToString();
            txtDonGia.Text = r[7].ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }
            else
            {
                e.SuppressKeyPress = false;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (!char.IsWhiteSpace(e.KeyChar) && char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                return;
            }
            try
            {
                int x = int.Parse(txtSoLuong.Text.ToString());
            }
            catch
            {
                MessageBox.Show("Bạn phải nhập số");
                txtSoLuong.Text = "0";
            }
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            else
            {
                if (char.IsDigit(e.KeyChar) || txtTenKH.TextLength >= 59) /// không cho nhập số,quy dinh do dai cua họ tên KH lớn nhất  la 59 ky tu
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }
        public double TONGTIENHD()
        {
            int rowcount = dataGridView1.Rows.Count;
            if (rowcount == 0)
                return 0;
            double tong = 0;
            for (int i = 0; i < rowcount; i++)
            {
                tong += double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            return tong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTenKH.TextLength == 0 || txtSoLuong.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa nhập đủ thông tin");
                    return;
                }


                if (cbbMaTB.Items.Count == 0)
                {
                    MessageBox.Show("Kho chưa có thiết bị nào.Bạn hãy thêm thiết bị và sau đó lập hóa đơn bán");
                    return;
                }
                if (txtSoLuong.TextLength == 0)
                {
                    MessageBox.Show("Bạn chưa điền số lượng thiết bị trong hóa đơn");
                    return;
                }
                else
                {
                    if (int.Parse(txtSoLuong.Text) == 0)
                    {
                        MessageBox.Show("Số lượng thiết bị trong đơn hàng phải lớn hơn 0. Vui Lòng sửa lại");
                        return;
                    }
                }
                if (cbbMaTB.SelectedItem == null)
                {
                    MessageBox.Show("Mã thiết bị chưa được chọn");
                    return;
                }

                DataRow r = ds.Tables["THIETBI"].Rows.Find(cbbMaTB.SelectedValue.ToString());
                if (r == null)
                {
                    MessageBox.Show(" Không có thiết bị");
                    return;
                }
                else
                {
                    if (int.Parse(r[4].ToString()) < int.Parse(txtSoLuong.Text))
                    {
                        MessageBox.Show("Số lượng của thiết bị này không đủ để thực hiện đơn hàng.\n Hãy nhập thêm thiết bị vào kho hoặc giảm số lượng trong đơn hàng.\n Số lượng trong kho còn: " + r[4].ToString(), "Thông báo trình trạng thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                int rowcount = dataGridView1.Rows.Count;
                if (rowcount != 0)
                {
                    for (int i = 0; i < rowcount; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == cbbMaTB.SelectedValue.ToString())
                        {
                            MessageBox.Show("Thiết bị đã được thêm. Vui lòng chọn thiết bị khác hoặc sửa lại hóa đơn đã nhập");
                            return;
                        }
                    }
                }
                double thanhtien = int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text);
                dataGridView1.Rows.Add(cbbMaTB.SelectedValue.ToString(), txtTenTB.Text, int.Parse(txtSoLuong.Text), double.Parse(txtDonGia.Text), thanhtien);
                txtTongtien.Text = TONGTIENHD().ToString();
            }
            catch { }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int rowcount = dataGridView1.RowCount;
                if (rowcount == 0)
                {
                    MessageBox.Show("Đơn hàng trống.");
                    return;
                }
                DataRow r = ds.Tables["THIETBI"].Rows.Find(cbbMaTB.SelectedValue.ToString());
                if (r == null)
                {
                    MessageBox.Show(" Không có thiết bị");
                    return;
                }
                else
                {
                    if (int.Parse(r[4].ToString()) < int.Parse(txtSoLuong.Text))
                    {
                        MessageBox.Show("Số lượng của thiết bị này không đủ để thực hiện đơn hàng.\n Hãy nhập thêm thiết bị vào kho hoặc giảm số lượng trong đơn hàng.\n Số lượng trong kho còn: " + "r[4].ToString()", "Thông báo trình trạng thiết bị", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (dataGridView1.SelectedRows != null)
                {
                    dataGridView1.CurrentRow.Cells[0].Value = cbbMaTB.SelectedValue.ToString();
                    dataGridView1.CurrentRow.Cells[1].Value = txtTenTB.Text;
                    dataGridView1.CurrentRow.Cells[2].Value = txtSoLuong.Text;
                    dataGridView1.CurrentRow.Cells[3].Value = txtDonGia.Text;
                    dataGridView1.CurrentRow.Cells[4].Value = double.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text);
                    txtTongtien.Text = TONGTIENHD().ToString();

                }
            }
            catch { }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
                return;
            cbbMaTB.SelectedValue = dataGridView1.CurrentRow.Cells[0].Value;
            txtSoLuong.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           

        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = false;
            else
            {
                if (!char.IsDigit(e.KeyChar) || txtSoDienThoai.TextLength >= 11 || char.IsWhiteSpace(e.KeyChar))/// so diện thoại phải nhỏ hơn 12
                    e.Handled = true;
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbMaTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMaHoaDon.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDanhSachHoaDonBan f = new FrmDanhSachHoaDonBan();
            f.ShowDialog();
        }

        private void txtTongtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
