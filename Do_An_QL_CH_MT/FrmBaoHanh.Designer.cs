namespace Do_An_QL_CH_MT
{
    partial class FrmBaoHanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txttim = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtnv = new System.Windows.Forms.TextBox();
            this.dA_QL_CuaHang_MayTinhDataSet1 = new Do_An_QL_CH_MT.DA_QL_CuaHang_MayTinhDataSet1();
            this.txttbh = new System.Windows.Forms.TextBox();
            this.txtmapc = new System.Windows.Forms.TextBox();
            this.txtnbh = new System.Windows.Forms.TextBox();
            this.txtgchu = new System.Windows.Forms.TextBox();
            this.txtmakh = new System.Windows.Forms.TextBox();
            this.bAOHANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBaoHanh = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnmod = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.bAOHANHTableAdapter = new Do_An_QL_CH_MT.DA_QL_CuaHang_MayTinhDataSet1TableAdapters.BAOHANHTableAdapter();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dA_QL_CuaHang_MayTinhDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOHANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoHanh)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(213, 113);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(200, 29);
            this.txttim.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tìm kiếm hóa đơn :";
            // 
            // btnTim
            // 
            this.btnTim.BackgroundImage = global::Do_An_QL_CH_MT.Properties.Resources.search;
            this.btnTim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(454, 102);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 55);
            this.btnTim.TabIndex = 23;
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtnv
            // 
            this.txtnv.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dA_QL_CuaHang_MayTinhDataSet1, "BAOHANH.MA_NVBH", true));
            this.txtnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnv.Location = new System.Drawing.Point(159, 259);
            this.txtnv.Name = "txtnv";
            this.txtnv.Size = new System.Drawing.Size(157, 29);
            this.txtnv.TabIndex = 38;
            // 
            // dA_QL_CuaHang_MayTinhDataSet1
            // 
            this.dA_QL_CuaHang_MayTinhDataSet1.DataSetName = "DA_QL_CuaHang_MayTinhDataSet1";
            this.dA_QL_CuaHang_MayTinhDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txttbh
            // 
            this.txttbh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dA_QL_CuaHang_MayTinhDataSet1, "BAOHANH.NGAYTRA_BH", true));
            this.txttbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttbh.Location = new System.Drawing.Point(159, 463);
            this.txttbh.Name = "txttbh";
            this.txttbh.Size = new System.Drawing.Size(157, 29);
            this.txttbh.TabIndex = 37;
            // 
            // txtmapc
            // 
            this.txtmapc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dA_QL_CuaHang_MayTinhDataSet1, "BAOHANH.MA_TB", true));
            this.txtmapc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmapc.Location = new System.Drawing.Point(159, 327);
            this.txtmapc.Name = "txtmapc";
            this.txtmapc.Size = new System.Drawing.Size(157, 29);
            this.txtmapc.TabIndex = 36;
            // 
            // txtnbh
            // 
            this.txtnbh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dA_QL_CuaHang_MayTinhDataSet1, "BAOHANH.NGAY_BH", true));
            this.txtnbh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnbh.Location = new System.Drawing.Point(159, 395);
            this.txtnbh.Name = "txtnbh";
            this.txtnbh.Size = new System.Drawing.Size(157, 29);
            this.txtnbh.TabIndex = 35;
            // 
            // txtgchu
            // 
            this.txtgchu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dA_QL_CuaHang_MayTinhDataSet1, "BAOHANH.GHI_CHU", true));
            this.txtgchu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgchu.Location = new System.Drawing.Point(159, 531);
            this.txtgchu.Name = "txtgchu";
            this.txtgchu.Size = new System.Drawing.Size(157, 29);
            this.txtgchu.TabIndex = 34;
            // 
            // txtmakh
            // 
            this.txtmakh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bAOHANHBindingSource, "MA_HD", true));
            this.txtmakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmakh.Location = new System.Drawing.Point(159, 191);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.Size = new System.Drawing.Size(157, 29);
            this.txtmakh.TabIndex = 33;
            // 
            // bAOHANHBindingSource
            // 
            this.bAOHANHBindingSource.DataMember = "BAOHANH";
            this.bAOHANHBindingSource.DataSource = this.dA_QL_CuaHang_MayTinhDataSet1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ghi chú :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Trả bảo hành :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày bảo hành:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã TB :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Mã NVBH :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã HD :";
            // 
            // dataGridViewBaoHanh
            // 
            this.dataGridViewBaoHanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBaoHanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBaoHanh.Location = new System.Drawing.Point(341, 218);
            this.dataGridViewBaoHanh.Name = "dataGridViewBaoHanh";
            this.dataGridViewBaoHanh.Size = new System.Drawing.Size(775, 230);
            this.dataGridViewBaoHanh.TabIndex = 39;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(606, 109);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(91, 41);
            this.btnadd.TabIndex = 40;
            this.btnadd.Text = "Thêm";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnmod
            // 
            this.btnmod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmod.Location = new System.Drawing.Point(720, 109);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(91, 41);
            this.btnmod.TabIndex = 41;
            this.btnmod.Text = "Sửa";
            this.btnmod.UseVisualStyleBackColor = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(833, 109);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(91, 41);
            this.btndel.TabIndex = 42;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // bAOHANHTableAdapter
            // 
            this.bAOHANHTableAdapter.ClearBeforeFill = true;
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapLai.Location = new System.Drawing.Point(730, 506);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(91, 41);
            this.btnNhapLai.TabIndex = 43;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(2, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 57);
            this.panel1.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(437, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 33);
            this.label7.TabIndex = 0;
            this.label7.Text = "Bảo Hành";
            // 
            // FrmBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridViewBaoHanh);
            this.Controls.Add(this.txtnv);
            this.Controls.Add(this.txttbh);
            this.Controls.Add(this.txtmapc);
            this.Controls.Add(this.txtnbh);
            this.Controls.Add(this.txtgchu);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label9);
            this.Name = "FrmBaoHanh";
            this.Text = "FrmBaoHanh";
            this.Load += new System.EventHandler(this.FrmBaoHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dA_QL_CuaHang_MayTinhDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bAOHANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBaoHanh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtnv;
        private System.Windows.Forms.TextBox txttbh;
        private System.Windows.Forms.TextBox txtmapc;
        private System.Windows.Forms.TextBox txtnbh;
        private System.Windows.Forms.TextBox txtgchu;
        private System.Windows.Forms.TextBox txtmakh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBaoHanh;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnmod;
        private System.Windows.Forms.Button btndel;
        private DA_QL_CuaHang_MayTinhDataSet1 dA_QL_CuaHang_MayTinhDataSet1;
        private System.Windows.Forms.BindingSource bAOHANHBindingSource;
        private DA_QL_CuaHang_MayTinhDataSet1TableAdapters.BAOHANHTableAdapter bAOHANHTableAdapter;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;

    }
}