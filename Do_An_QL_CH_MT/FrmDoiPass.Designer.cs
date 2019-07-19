namespace Do_An_QL_CH_MT
{
    partial class FrmDoiPass
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
            this.chkHienPass = new System.Windows.Forms.CheckBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaplaiPass = new System.Windows.Forms.TextBox();
            this.txtPassmoi = new System.Windows.Forms.TextBox();
            this.txtPassHientai = new System.Windows.Forms.TextBox();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkHienPass
            // 
            this.chkHienPass.AutoSize = true;
            this.chkHienPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHienPass.Location = new System.Drawing.Point(258, 99);
            this.chkHienPass.Name = "chkHienPass";
            this.chkHienPass.Size = new System.Drawing.Size(145, 22);
            this.chkHienPass.TabIndex = 14;
            this.chkHienPass.Text = "Hiển thị password";
            this.chkHienPass.UseVisualStyleBackColor = true;
            this.chkHienPass.CheckedChanged += new System.EventHandler(this.chkHienPass_CheckedChanged);
            // 
            // btnDongY
            // 
            this.btnDongY.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongY.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDongY.Location = new System.Drawing.Point(115, 296);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(105, 63);
            this.btnDongY.TabIndex = 12;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = false;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnexit.Location = new System.Drawing.Point(384, 296);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(105, 63);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập lại Password mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password hiện tại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "User";
            // 
            // txtNhaplaiPass
            // 
            this.txtNhaplaiPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaplaiPass.Location = new System.Drawing.Point(222, 248);
            this.txtNhaplaiPass.Name = "txtNhaplaiPass";
            this.txtNhaplaiPass.PasswordChar = '*';
            this.txtNhaplaiPass.Size = new System.Drawing.Size(280, 24);
            this.txtNhaplaiPass.TabIndex = 4;
            // 
            // txtPassmoi
            // 
            this.txtPassmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassmoi.Location = new System.Drawing.Point(222, 202);
            this.txtPassmoi.Name = "txtPassmoi";
            this.txtPassmoi.PasswordChar = '*';
            this.txtPassmoi.Size = new System.Drawing.Size(280, 24);
            this.txtPassmoi.TabIndex = 5;
            // 
            // txtPassHientai
            // 
            this.txtPassHientai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassHientai.Location = new System.Drawing.Point(222, 146);
            this.txtPassHientai.Name = "txtPassHientai";
            this.txtPassHientai.PasswordChar = '*';
            this.txtPassHientai.Size = new System.Drawing.Size(280, 24);
            this.txtPassHientai.TabIndex = 6;
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(222, 54);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(280, 24);
            this.txt_User.TabIndex = 7;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            this.txt_User.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_User_KeyPress);
            // 
            // FrmDoiPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 378);
            this.Controls.Add(this.chkHienPass);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNhaplaiPass);
            this.Controls.Add(this.txtPassmoi);
            this.Controls.Add(this.txtPassHientai);
            this.Controls.Add(this.txt_User);
            this.Name = "FrmDoiPass";
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.FrmDoiPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkHienPass;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhaplaiPass;
        private System.Windows.Forms.TextBox txtPassmoi;
        private System.Windows.Forms.TextBox txtPassHientai;
        private System.Windows.Forms.TextBox txt_User;
    }
}