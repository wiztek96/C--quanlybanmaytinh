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
    public partial class FrmMENU : Form
    {
        Timer t = new Timer();

        public FrmMENU()
        {
            InitializeComponent();
        }

        

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBanHang fm = new FrmBanHang();
            fm.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhapHang fm = new FrmNhapHang();
            fm.ShowDialog();
        }

        private void qLNCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLNCC fm = new FrmQLNCC();
            fm.ShowDialog();
        }

        private void qLNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQLNV fm = new FrmQLNV();
            fm.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult th;
            th = (MessageBox.Show("Bạn có muốn thoát","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question));
            if(th == DialogResult.OK)
            {
                this.Close();
                Application.Exit();

            }
        }
        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";
            if(hh < 10){
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            lbgio.Text = time;
        }
        private void đổiPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDoiPass fm = new FrmDoiPass();
            fm.ShowDialog();
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
        int x = 15, y = 150, a = 1;
        Random ra = new Random();
        //private void timer2_Tick(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        x += a;
        //        //lb_cuahang.Location = new Point(x,y);
        //        if(x >= 600)
        //        {
        //            a = -1;
        //          //  lb_cuahang.ForeColor = Color.FromArgb(ra.Next(0, 255), ra.Next(0, 255), ra.Next(0, 255));
        //        }
        //        if (x <= 12)
        //        {
        //            a = 1;
        //            //lb_cuahang.ForeColor = Color.FromArgb(ra.Next(0, 255), ra.Next(0, 255), ra.Next(0, 255));
        //        }
        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //   // lbgio.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " giây";
            
        //}
       

        private void FrmMENU_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            //lb_cuahang.BackColor = Color.Transparent;
            lbgio.BackColor = Color.Transparent;
            lbngay.BackColor = Color.Transparent;
            lbngay.Text = "Ngày " + DateTime.Now.Day.ToString() + ", Tháng " + DateTime.Now.Month.ToString() + ", Năm " + DateTime.Now.Year.ToString();
            //lbgio.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString() + " giây";
        }

        private void khóaTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCDTaiKhoan fm = new FrmCDTaiKhoan();
            fm.ShowDialog();
        }

        private void khoHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoHang fm = new FrmKhoHang();
            fm.ShowDialog();
        }

        private void bảoHànhThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaoHanh fm = new FrmBaoHanh();
            fm.ShowDialog();
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

        private void lbngay_Click(object sender, EventArgs e)
        {

        }

        private void thêmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCDTaiKhoan f = new FrmCDTaiKhoan();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

       

       
    }
}
