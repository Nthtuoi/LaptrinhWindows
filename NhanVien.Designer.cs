namespace BTVN
{
    partial class NhanVien
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
            this.lblMsnv = new System.Windows.Forms.Label();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMsnv = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMsnv
            // 
            this.lblMsnv.AutoSize = true;
            this.lblMsnv.Location = new System.Drawing.Point(54, 49);
            this.lblMsnv.Name = "lblMsnv";
            this.lblMsnv.Size = new System.Drawing.Size(55, 20);
            this.lblMsnv.TabIndex = 0;
            this.lblMsnv.Text = "MSNV";
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Location = new System.Drawing.Point(54, 157);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(122, 20);
            this.lblTenNV.TabIndex = 1;
            this.lblTenNV.Text = "Ten Nhan Vien: ";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(54, 256);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(124, 20);
            this.lblLuong.TabIndex = 2;
            this.lblLuong.Text = "Luong Can Ban:";
            // 
            // txtMsnv
            // 
            this.txtMsnv.Location = new System.Drawing.Point(277, 49);
            this.txtMsnv.Name = "txtMsnv";
            this.txtMsnv.Size = new System.Drawing.Size(279, 26);
            this.txtMsnv.TabIndex = 3;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(277, 151);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(279, 26);
            this.txtTen.TabIndex = 4;
            // 
            // txtLuong
            // 
            this.txtLuong.Location = new System.Drawing.Point(277, 250);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(279, 26);
            this.txtLuong.TabIndex = 5;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(277, 344);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(88, 35);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Dong y";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(468, 344);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(88, 34);
            this.btnBoQua.TabIndex = 7;
            this.btnBoQua.Text = "Bo Qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMsnv);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.lblMsnv);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMsnv;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.TextBox txtMsnv;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}