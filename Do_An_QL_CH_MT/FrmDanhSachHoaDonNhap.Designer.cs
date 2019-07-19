namespace Do_An_QL_CH_MT
{
    partial class FrmDanhSachHoaDonNhap
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
            this.btnHienall_M = new System.Windows.Forms.Button();
            this.btnLoc_M = new System.Windows.Forms.Button();
            this.txtmahdM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongtien_M = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1DSCHITIET_HDM = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DSCHITIET_HDM)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHienall_M
            // 
            this.btnHienall_M.BackColor = System.Drawing.Color.Gray;
            this.btnHienall_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienall_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnHienall_M.ForeColor = System.Drawing.Color.White;
            this.btnHienall_M.Location = new System.Drawing.Point(755, 147);
            this.btnHienall_M.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienall_M.Name = "btnHienall_M";
            this.btnHienall_M.Size = new System.Drawing.Size(77, 55);
            this.btnHienall_M.TabIndex = 23;
            this.btnHienall_M.Text = "Hiện tất cả";
            this.btnHienall_M.UseVisualStyleBackColor = false;
            this.btnHienall_M.Click += new System.EventHandler(this.btnHienall_M_Click);
            // 
            // btnLoc_M
            // 
            this.btnLoc_M.BackColor = System.Drawing.Color.Gray;
            this.btnLoc_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoc_M.ForeColor = System.Drawing.Color.White;
            this.btnLoc_M.Location = new System.Drawing.Point(633, 148);
            this.btnLoc_M.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc_M.Name = "btnLoc_M";
            this.btnLoc_M.Size = new System.Drawing.Size(79, 53);
            this.btnLoc_M.TabIndex = 24;
            this.btnLoc_M.Text = "Lọc";
            this.btnLoc_M.UseVisualStyleBackColor = false;
            this.btnLoc_M.Click += new System.EventHandler(this.btnLoc_M_Click);
            // 
            // txtmahdM
            // 
            this.txtmahdM.Location = new System.Drawing.Point(321, 168);
            this.txtmahdM.Margin = new System.Windows.Forms.Padding(4);
            this.txtmahdM.Name = "txtmahdM";
            this.txtmahdM.Size = new System.Drawing.Size(240, 20);
            this.txtmahdM.TabIndex = 22;
            this.txtmahdM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmahdM_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongtien_M);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView1DSCHITIET_HDM);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(148, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(976, 349);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thiết bị trong hóa đơn";
            // 
            // txtTongtien_M
            // 
            this.txtTongtien_M.Enabled = false;
            this.txtTongtien_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongtien_M.Location = new System.Drawing.Point(333, 296);
            this.txtTongtien_M.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien_M.Name = "txtTongtien_M";
            this.txtTongtien_M.Size = new System.Drawing.Size(214, 27);
            this.txtTongtien_M.TabIndex = 25;
            this.txtTongtien_M.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tổng tiền của hóa đơn";
            // 
            // dataGridView1DSCHITIET_HDM
            // 
            this.dataGridView1DSCHITIET_HDM.AllowUserToAddRows = false;
            this.dataGridView1DSCHITIET_HDM.AllowUserToDeleteRows = false;
            this.dataGridView1DSCHITIET_HDM.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1DSCHITIET_HDM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1DSCHITIET_HDM.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1DSCHITIET_HDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1DSCHITIET_HDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column10,
            this.Column8});
            this.dataGridView1DSCHITIET_HDM.GridColor = System.Drawing.Color.Navy;
            this.dataGridView1DSCHITIET_HDM.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1DSCHITIET_HDM.MultiSelect = false;
            this.dataGridView1DSCHITIET_HDM.Name = "dataGridView1DSCHITIET_HDM";
            this.dataGridView1DSCHITIET_HDM.ReadOnly = true;
            this.dataGridView1DSCHITIET_HDM.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1DSCHITIET_HDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1DSCHITIET_HDM.Size = new System.Drawing.Size(964, 258);
            this.dataGridView1DSCHITIET_HDM.TabIndex = 22;
            this.dataGridView1DSCHITIET_HDM.DataSourceChanged += new System.EventHandler(this.dataGridView1DSCHITIET_HDM_DataSourceChanged);
            this.dataGridView1DSCHITIET_HDM.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1DSCHITIET_HDM_ColumnHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MA_TB";
            this.Column2.HeaderText = "Mã thiết bị";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TEN_TB";
            this.Column3.HeaderText = "Tên thiết bị";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "LOAI";
            this.Column5.HeaderText = "Loại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NSX";
            this.Column4.HeaderText = "NSX";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SOLUONG";
            this.Column6.HeaderText = "Số lượng";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DONNGIA_MUA";
            this.Column7.HeaderText = "Đơn giá mua";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "THANHTIEN";
            this.Column10.HeaderText = "Thành tiền";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MA_HDM";
            this.Column8.HeaderText = "MA_HD";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(878, 146);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 55);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(148, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 53);
            this.panel1.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(327, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách hóa đơn nhập hàng";
            // 
            // FrmDanhSachHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHienall_M);
            this.Controls.Add(this.btnLoc_M);
            this.Controls.Add(this.txtmahdM);
            this.Controls.Add(this.label1);
            this.Name = "FrmDanhSachHoaDonNhap";
            this.Text = "Danh sách hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.FrmDanhSachHoaDonNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1DSCHITIET_HDM)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHienall_M;
        private System.Windows.Forms.Button btnLoc_M;
        private System.Windows.Forms.TextBox txtmahdM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongtien_M;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1DSCHITIET_HDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}