namespace GUI.frmExtra
{
	partial class frmThongTinMayTinh
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
			this.lvMayTinh = new System.Windows.Forms.ListView();
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Mã Máy ";
			columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader2.Width = 80;
			// 
			// lvMayTinh
			// 
			this.lvMayTinh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1,
            this.columnHeader8});
			this.lvMayTinh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvMayTinh.FullRowSelect = true;
			this.lvMayTinh.GridLines = true;
			this.lvMayTinh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvMayTinh.HideSelection = false;
			this.lvMayTinh.Location = new System.Drawing.Point(0, 0);
			this.lvMayTinh.Name = "lvMayTinh";
			this.lvMayTinh.Size = new System.Drawing.Size(614, 284);
			this.lvMayTinh.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvMayTinh.TabIndex = 3;
			this.lvMayTinh.UseCompatibleStateImageBehavior = false;
			this.lvMayTinh.View = System.Windows.Forms.View.Details;
			this.lvMayTinh.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvMayTinh_ItemCheck);
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Chọn";
			this.columnHeader9.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Máy";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "RAM";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 50;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "HDD";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 80;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Tình Trạng";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 80;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Hạn BH";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 100;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Số lần BH";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Mã PM";
			this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader8.Width = 100;
			// 
			// frmThongTinMayTinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(614, 284);
			this.Controls.Add(this.lvMayTinh);
			this.Name = "frmThongTinMayTinh";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thông Tin Máy Tính";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvMayTinh;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
	}
}