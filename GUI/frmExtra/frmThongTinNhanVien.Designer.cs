namespace GUI.frmExtra
{
	partial class frmThongTinNhanVien
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
			System.Windows.Forms.ColumnHeader columnHeader2;
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lvSV = new System.Windows.Forms.ListView();
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Mã Nhân Viên";
			columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader2.Width = 100;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Chọn";
			this.columnHeader8.Width = 45;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Nhân Viên";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "GT";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 50;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày Sinh";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 100;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Lương";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Hệ Số Lương";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 100;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Chức Vụ";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader1.Width = 100;
			// 
			// lvSV
			// 
			this.lvSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1});
			this.lvSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSV.FullRowSelect = true;
			this.lvSV.GridLines = true;
			this.lvSV.HideSelection = false;
			this.lvSV.Location = new System.Drawing.Point(0, 0);
			this.lvSV.Name = "lvSV";
			this.lvSV.Size = new System.Drawing.Size(743, 288);
			this.lvSV.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvSV.TabIndex = 3;
			this.lvSV.UseCompatibleStateImageBehavior = false;
			this.lvSV.View = System.Windows.Forms.View.Details;
			this.lvSV.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvSV_ItemCheck);
 			// 
			// frmThongTinNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 288);
			this.Controls.Add(this.lvSV);
			this.DoubleBuffered = true;
			this.Name = "frmThongTinNhanVien";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thông Tin Nhân Viên";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvSV;
	}
}