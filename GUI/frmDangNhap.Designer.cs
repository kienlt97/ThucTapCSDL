namespace GUI
{
	partial class frmDangNhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.chkluutaikhoan = new System.Windows.Forms.CheckBox();
			this.txtmatkhau = new System.Windows.Forms.TextBox();
			this.txttaikhoan = new System.Windows.Forms.TextBox();
			this.btnDangNhap = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tài Khoản";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Mật Khẩu";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.chkluutaikhoan);
			this.groupBox1.Controls.Add(this.txtmatkhau);
			this.groupBox1.Controls.Add(this.txttaikhoan);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(125, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(260, 133);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Đăng Nhập";
			// 
			// chkluutaikhoan
			// 
			this.chkluutaikhoan.AutoSize = true;
			this.chkluutaikhoan.Checked = true;
			this.chkluutaikhoan.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkluutaikhoan.Location = new System.Drawing.Point(9, 103);
			this.chkluutaikhoan.Name = "chkluutaikhoan";
			this.chkluutaikhoan.Size = new System.Drawing.Size(203, 21);
			this.chkluutaikhoan.TabIndex = 3;
			this.chkluutaikhoan.Text = "Lưu Tài Khoản và Mật Khẩu";
			this.chkluutaikhoan.UseVisualStyleBackColor = true;
			// 
			// txtmatkhau
			// 
			this.txtmatkhau.Location = new System.Drawing.Point(85, 67);
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.Size = new System.Drawing.Size(159, 23);
			this.txtmatkhau.TabIndex = 2;
			this.txtmatkhau.UseSystemPasswordChar = true;
			// 
			// txttaikhoan
			// 
			this.txttaikhoan.Location = new System.Drawing.Point(85, 27);
			this.txttaikhoan.Name = "txttaikhoan";
			this.txttaikhoan.Size = new System.Drawing.Size(159, 23);
			this.txttaikhoan.TabIndex = 1;
			// 
			// btnDangNhap
			// 
			this.btnDangNhap.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.btnDangNhap.AllowDrop = true;
			this.btnDangNhap.Location = new System.Drawing.Point(146, 163);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new System.Drawing.Size(75, 23);
			this.btnDangNhap.TabIndex = 4;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(262, 165);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(75, 23);
			this.btnHuy.TabIndex = 5;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(94, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// frmDangNhap
			// 
			this.AcceptButton = this.btnDangNhap;
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(397, 200);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnDangNhap);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "frmDangNhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng Nhập";
			this.Load += new System.EventHandler(this.frmDangNhap_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chkluutaikhoan;
		private System.Windows.Forms.TextBox txtmatkhau;
		private System.Windows.Forms.TextBox txttaikhoan;
		private System.Windows.Forms.Button btnDangNhap;
		private System.Windows.Forms.Button btnHuy;
	}
}