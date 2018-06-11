namespace GUI.frmExtra
{
	partial class frmThongTinTB
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
			this.lvThietBi = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Mã Thiết Bị";
			columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader2.Width = 100;
			// 
			// lvThietBi
			// 
			this.lvThietBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lvThietBi.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvThietBi.FullRowSelect = true;
			this.lvThietBi.GridLines = true;
			this.lvThietBi.HideSelection = false;
			this.lvThietBi.Location = new System.Drawing.Point(0, 0);
			this.lvThietBi.Name = "lvThietBi";
			this.lvThietBi.Size = new System.Drawing.Size(641, 299);
			this.lvThietBi.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvThietBi.TabIndex = 3;
			this.lvThietBi.UseCompatibleStateImageBehavior = false;
			this.lvThietBi.View = System.Windows.Forms.View.Details;
			this.lvThietBi.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvThietBi_ItemCheck);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Chọn";
			this.columnHeader1.Width = 50;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Thiết Bị";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Tình Trạng";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 150;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày Bảo Hành";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số Lần BH";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Mã Phòng Máy";
			this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader7.Width = 100;
			// 
			// frmThongTinTB
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(641, 299);
			this.Controls.Add(this.lvThietBi);
			this.Name = "frmThongTinTB";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thông Tin Thiết Bị";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvThietBi;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
	}
}