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
    public partial class FrmDanhSachHoaDonNhap : Form
    {
        SqlConnection con;
        DataSet datasett;/// chua toan bo chi tiet cua hoa don 
        DataTable table;/// chua chi tiet cua hoa don theo ma hoa don
        public string mahoadon = "";
        public FrmDanhSachHoaDonNhap()
        {
            InitializeComponent();
            con = new SqlConnection(KetNoi.connectionstring);
            datasett = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT DISTINCT MA_HDM,CHITIET_HDM.MA_TB,TEN_TB,NSX,LOAI,CHITIET_HDM.SOLUONG,CHITIET_HDM.DONGIA_MUA,THANHTIEN FROM THIETBI,CHITIET_HDM,NHACUNGCAP WHERE CHITIET_HDM.MA_TB = THIETBI.MA_TB", con);
            adapter.Fill(datasett);
        }
        public void showToData()
        {
            try
            {
                table = null;
                if (datasett.Tables[0].Rows.Count == 0)
                    return;
                //DataColumn[] pk = new DataColumn[1];
                //pk[0] = dataset.Tables[0].Columns[0];
                //dataset.Tables[0].PrimaryKey = pk;
                if (txtmahdM.TextLength == 0)
                {
                    table = null;
                    return;
                }
                DataRow[] r = datasett.Tables[0].Select("MA_HDM = '" + txtmahdM.Text.ToString().Trim() + "'");

                if (r.Count() == 0)
                    return;
                table = r.CopyToDataTable();/// dua du lieu da loc vao table
                dataGridView1DSCHITIET_HDM.DataSource = table;
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView1DSCHITIET_HDM.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }

        }

        private void btnHienall_M_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1DSCHITIET_HDM.DataSource = datasett.Tables[0];
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView1DSCHITIET_HDM.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
        }

        private void FrmDanhSachHoaDonNhap_Load(object sender, EventArgs e)
        {
            if (mahoadon != "")
            {
                txtmahdM.Text = mahoadon;
                btnLoc_M_Click(sender, e);
                btnHienall_M.Enabled = false;
                txtmahdM.Enabled = false;

            }
        }

        private void txtmahdM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (char.IsControl(e.KeyChar))
                e.Handled = false;
            /// quy dinh do dai cua mã hóa đơn bán la 10 ky tu
            else
            {
                if (txtmahdM.TextLength >= 10)
                    e.Handled = true;
                else
                {
                    string s = e.KeyChar.ToString();
                    s = s.ToUpper();
                    e.KeyChar = char.Parse(s);
                }
            }
        }

        private void btnLoc_M_Click(object sender, EventArgs e)
        {
            if (txtmahdM.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã thiết bị");
                return;
            }
            showToData();
            if (dataGridView1DSCHITIET_HDM.RowCount == 0)
            {
                MessageBox.Show("Không có mã hóa đơn này");
                return;
            }
        }

        private void dataGridView1DSCHITIET_HDM_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                for (int i = 1; i <= rowcount; i++)
                {
                    dataGridView1DSCHITIET_HDM.Rows[i - 1].Cells[0].Value = i;
                }
            }
            catch { }
           
        }

        private void dataGridView1DSCHITIET_HDM_DataSourceChanged(object sender, EventArgs e)
        {
            try
            {
                int rowcount = dataGridView1DSCHITIET_HDM.RowCount;
                double Tongtienban = 0;
                for (int i = 0; i < rowcount; i++)
                {
                    Tongtienban += double.Parse(dataGridView1DSCHITIET_HDM.Rows[i].Cells[8].Value.ToString());
                }
                txtTongtien_M.Text = Tongtienban.ToString();
            }
            catch { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult t;
            t = (MessageBox.Show("Bạn có chắc chắn muốn thoát","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question));
            if (t == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}
