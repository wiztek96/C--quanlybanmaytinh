using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_An_QL_CH_MT
{
    public partial class FrmMENU2 : Form
    {
        public FrmMENU2()
        {
            InitializeComponent();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang f = new FrmBanHang();
            f.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhapHang f = new FrmNhapHang();
            f.ShowDialog();
        }

        private void qLNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLNCC f = new FrmQLNCC();
            f.ShowDialog();
        }

        private void qLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLNV f = new FrmQLNV();
            f.ShowDialog();
        }

        private void bảoHànhThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoHanh f = new FrmBaoHanh();
            f.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoHang f = new FrmKhoHang();
            f.ShowDialog();
        }

        private void chiTiếtHóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhSachHoaDonBan f = new FrmDanhSachHoaDonBan();
            f.ShowDialog();
        }

        private void chiTiếtHóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDanhSachHoaDonNhap f = new FrmDanhSachHoaDonNhap();
            f.ShowDialog();
        }

        private void đổiPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiPass f = new FrmDoiPass();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ok;
            ok = MessageBox.Show(" Bạn có muốn thoát không ?", "Thông báo ?!?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok == DialogResult.Yes)
                Application.Exit();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ok;
                ok = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    this.Hide();
                    DangNhap f = new DangNhap();
                    f.ShowDialog();

                }
            }
            catch { }
        }
    }
}
