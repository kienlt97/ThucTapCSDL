namespace GUI.frmExtra
{
	partial class frmDoiMK
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btndoimatkhau = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtnhaplaimk = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtmatkhaumoi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtmatkhau = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.btnHuy);
			this.groupBox1.Controls.Add(this.btndoimatkhau);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtnhaplaimk);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtmatkhaumoi);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtmatkhau);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(141, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(461, 357);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thay Đổi Mật Khẩu";
			// 
			// btnHuy
			// 
			this.btnHuy.Location = new System.Drawing.Point(324, 277);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(118, 37);
			this.btnHuy.TabIndex = 7;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = true;
			// 
			// btndoimatkhau
			// 
			this.btndoimatkhau.Location = new System.Drawing.Point(183, 277);
			this.btndoimatkhau.Name = "btndoimatkhau";
			this.btndoimatkhau.Size = new System.Drawing.Size(112, 37);
			this.btndoimatkhau.TabIndex = 6;
			this.btndoimatkhau.Text = "Xác Nhận";
			this.btndoimatkhau.UseVisualStyleBackColor = true;
			this.btndoimatkhau.Click += new System.EventHandler(this.btndoimatkhau_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(191, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nhập Lại Mật Khẩu :";
			// 
			// txtnhaplaimk
			// 
			this.txtnhaplaimk.Location = new System.Drawing.Point(213, 206);
			this.txtnhaplaimk.Name = "txtnhaplaimk";
			this.txtnhaplaimk.Size = new System.Drawing.Size(229, 30);
			this.txtnhaplaimk.TabIndex = 4;
			this.txtnhaplaimk.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 151);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật Khẩu Mới : ";
			// 
			// txtmatkhaumoi
			// 
			this.txtmatkhaumoi.Location = new System.Drawing.Point(213, 147);
			this.txtmatkhaumoi.Name = "txtmatkhaumoi";
			this.txtmatkhaumoi.Size = new System.Drawing.Size(229, 30);
			this.txtmatkhaumoi.TabIndex = 2;
			this.txtmatkhaumoi.UseSystemPasswordChar = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 99);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Mật Khẩu Cũ : ";
			// 
			// txtmatkhau
			// 
			this.txtmatkhau.Location = new System.Drawing.Point(213, 92);
			this.txtmatkhau.Name = "txtmatkhau";
			this.txtmatkhau.Size = new System.Drawing.Size(229, 30);
			this.txtmatkhau.TabIndex = 0;
			this.txtmatkhau.UseSystemPasswordChar = true;
			// 
			// frmDoiMK
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.groupBox1);
			this.Name = "frmDoiMK";
			this.Size = new System.Drawing.Size(794, 529);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btndoimatkhau;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtnhaplaimk;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtmatkhaumoi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtmatkhau;
	}
}
