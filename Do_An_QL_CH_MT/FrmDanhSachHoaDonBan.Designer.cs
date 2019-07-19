namespace Do_An_QL_CH_MT
{
    partial class FrmDanhSachHoaDonBan
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
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.btnHienall_B = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLoc_M = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTongtien_M = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2ChiTietBan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2ChiTietBan)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaHDB.Location = new System.Drawing.Point(329, 154);
            this.txtMaHDB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(301, 27);
            this.txtMaHDB.TabIndex = 16;
            this.txtMaHDB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHDB_KeyPress);
            // 
            // btnHienall_B
            // 
            this.btnHienall_B.BackColor = System.Drawing.Color.Gray;
            this.btnHienall_B.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHienall_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienall_B.ForeColor = System.Drawing.Color.White;
            this.btnHienall_B.Location = new System.Drawing.Point(804, 135);
            this.btnHienall_B.Margin = new System.Windows.Forms.Padding(4);
            this.btnHienall_B.Name = "btnHienall_B";
            this.btnHienall_B.Size = new System.Drawing.Size(88, 58);
            this.btnHienall_B.TabIndex = 17;
            this.btnHienall_B.Text = "Hiện tất cả";
            this.btnHienall_B.UseVisualStyleBackColor = false;
            this.btnHienall_B.Click += new System.EventHandler(this.btnHienall_B_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(215, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tìm mã thiết bị";
            // 
            // btnLoc_M
            // 
            this.btnLoc_M.BackColor = System.Drawing.Color.Gray;
            this.btnLoc_M.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc_M.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc_M.ForeColor = System.Drawing.Color.White;
            this.btnLoc_M.Location = new System.Drawing.Point(694, 137);
            this.btnLoc_M.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoc_M.Name = "btnLoc_M";
            this.btnLoc_M.Size = new System.Drawing.Size(88, 58);
            this.btnLoc_M.TabIndex = 18;
            this.btnLoc_M.Text = "Lọc";
            this.btnLoc_M.UseVisualStyleBackColor = false;
            this.btnLoc_M.Click += new System.EventHandler(this.btnLoc_M_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTongtien_M);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dataGridView2ChiTietBan);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(99, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 371);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thiết bị trong hóa đơn";
            // 
            // txtTongtien_M
            // 
            this.txtTongtien_M.Enabled = false;
            this.txtTongtien_M.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.txtTongtien_M.Location = new System.Drawing.Point(420, 300);
            this.txtTongtien_M.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongtien_M.Name = "txtTongtien_M";
            this.txtTongtien_M.Size = new System.Drawing.Size(214, 27);
            this.txtTongtien_M.TabIndex = 15;
            this.txtTongtien_M.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 304);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng tiền của hóa đơn";
            // 
            // dataGridView2ChiTietBan
            // 
            this.dataGridView2ChiTietBan.AllowUserToAddRows = false;
            this.dataGridView2ChiTietBan.AllowUserToDeleteRows = false;
            this.dataGridView2ChiTietBan.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2ChiTietBan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView2ChiTietBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2ChiTietBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dataGridView2ChiTietBan.GridColor = System.Drawing.Color.Navy;
            this.dataGridView2ChiTietBan.Location = new System.Drawing.Point(7, 38);
            this.dataGridView2ChiTietBan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2ChiTietBan.Name = "dataGridView2ChiTietBan";
            this.dataGridView2ChiTietBan.ReadOnly = true;
            this.dataGridView2ChiTietBan.RowHeadersVisible = false;
            this.dataGridView2ChiTietBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2ChiTietBan.Size = new System.Drawing.Size(890, 237);
            this.dataGridView2ChiTietBan.TabIndex = 11;
            this.dataGridView2ChiTietBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2ChiTietBan_CellContentClick);
            this.dataGridView2ChiTietBan.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2ChiTietBan_ColumnHeaderMouseClick);
            this.dataGridView2ChiTietBan.Click += new System.EventHandler(this.dataGridView2ChiTietBan_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 40;
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
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LOAI";
            this.Column4.HeaderText = "Loại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NSX";
            this.Column5.HeaderText = "NSX";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            this.Column7.DataPropertyName = "DONGIA";
            this.Column7.HeaderText = "Đơn giá";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "THANHTIEN";
            this.Column8.HeaderText = "Thành tiền";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MA_HDB";
            this.Column9.HeaderText = "MA_hd";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(88, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 53);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hóa đơn bán hàng";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gray;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(908, 135);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 58);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmDanhSachHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 626);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaHDB);
            this.Controls.Add(this.btnHienall_B);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLoc_M);
            this.Name = "FrmDanhSachHoaDonBan";
            this.Text = "Danh sách hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.FrmDanhSachHoaDonBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2ChiTietBan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Button btnHienall_B;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLoc_M;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2ChiTietBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.TextBox txtTongtien_M;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}