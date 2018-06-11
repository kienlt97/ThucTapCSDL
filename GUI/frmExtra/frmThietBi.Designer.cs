namespace GUI.frmExtra
{
	partial class frmThietBi
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
			System.Windows.Forms.ColumnHeader columnHeader2;
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lvThietBi = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.cbmaPM = new System.Windows.Forms.ComboBox();
			this.btnResetTB = new System.Windows.Forms.Button();
			this.cbTimKiemTB = new System.Windows.Forms.ComboBox();
			this.btntimkiemTB = new System.Windows.Forms.Button();
			this.txttimkiemTB = new System.Windows.Forms.TextBox();
			this.btnthongkeTB = new System.Windows.Forms.Button();
			this.btnundoTB = new System.Windows.Forms.Button();
			this.btnDeleteTB = new System.Windows.Forms.Button();
			this.dtpNgayBH = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.txtsolanbh = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txttinhtrang = new System.Windows.Forms.TextBox();
			this.btnfixTB = new System.Windows.Forms.Button();
			this.txttentb = new System.Windows.Forms.TextBox();
			this.txtmatb = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddTB = new System.Windows.Forms.Button();
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Mã Thiết Bị";
			columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader2.Width = 100;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lvThietBi);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.CausesValidation = false;
			this.splitContainer1.Panel2.Controls.Add(this.cbmaPM);
			this.splitContainer1.Panel2.Controls.Add(this.btnResetTB);
			this.splitContainer1.Panel2.Controls.Add(this.cbTimKiemTB);
			this.splitContainer1.Panel2.Controls.Add(this.btntimkiemTB);
			this.splitContainer1.Panel2.Controls.Add(this.txttimkiemTB);
			this.splitContainer1.Panel2.Controls.Add(this.btnthongkeTB);
			this.splitContainer1.Panel2.Controls.Add(this.btnundoTB);
			this.splitContainer1.Panel2.Controls.Add(this.btnDeleteTB);
			this.splitContainer1.Panel2.Controls.Add(this.dtpNgayBH);
			this.splitContainer1.Panel2.Controls.Add(this.label6);
			this.splitContainer1.Panel2.Controls.Add(this.txtsolanbh);
			this.splitContainer1.Panel2.Controls.Add(this.label9);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.txttinhtrang);
			this.splitContainer1.Panel2.Controls.Add(this.btnfixTB);
			this.splitContainer1.Panel2.Controls.Add(this.txttentb);
			this.splitContainer1.Panel2.Controls.Add(this.txtmatb);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.btnAddTB);
			this.splitContainer1.Size = new System.Drawing.Size(722, 458);
			this.splitContainer1.SplitterDistance = 270;
			this.splitContainer1.TabIndex = 1;
			// 
			// lvThietBi
			// 
			this.lvThietBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
			this.lvThietBi.Size = new System.Drawing.Size(722, 270);
			this.lvThietBi.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvThietBi.TabIndex = 2;
			this.lvThietBi.UseCompatibleStateImageBehavior = false;
			this.lvThietBi.View = System.Windows.Forms.View.Details;
			this.lvThietBi.SelectedIndexChanged += new System.EventHandler(this.lvThietBi_SelectedIndexChanged);
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
			// cbmaPM
			// 
			this.cbmaPM.FormattingEnabled = true;
			this.cbmaPM.Location = new System.Drawing.Point(454, 38);
			this.cbmaPM.Name = "cbmaPM";
			this.cbmaPM.Size = new System.Drawing.Size(162, 21);
			this.cbmaPM.TabIndex = 46;
			// 
			// btnResetTB
			// 
			this.btnResetTB.Location = new System.Drawing.Point(20, 131);
			this.btnResetTB.Name = "btnResetTB";
			this.btnResetTB.Size = new System.Drawing.Size(69, 26);
			this.btnResetTB.TabIndex = 45;
			this.btnResetTB.Text = "Reset";
			this.btnResetTB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnResetTB.UseVisualStyleBackColor = true;
			this.btnResetTB.Click += new System.EventHandler(this.btnResetTB_Click);
			// 
			// cbTimKiemTB
			// 
			this.cbTimKiemTB.FormattingEnabled = true;
			this.cbTimKiemTB.Location = new System.Drawing.Point(347, 99);
			this.cbTimKiemTB.Name = "cbTimKiemTB";
			this.cbTimKiemTB.Size = new System.Drawing.Size(92, 21);
			this.cbTimKiemTB.TabIndex = 44;
			this.cbTimKiemTB.SelectedIndexChanged += new System.EventHandler(this.cbTimKiemTB_SelectedIndexChanged);
			// 
			// btntimkiemTB
			// 
			this.btntimkiemTB.Location = new System.Drawing.Point(623, 98);
			this.btntimkiemTB.Name = "btntimkiemTB";
			this.btntimkiemTB.Size = new System.Drawing.Size(62, 23);
			this.btntimkiemTB.TabIndex = 43;
			this.btntimkiemTB.Text = "Tìm Kiếm";
			this.btntimkiemTB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btntimkiemTB.UseVisualStyleBackColor = true;
			this.btntimkiemTB.Click += new System.EventHandler(this.btntimkiemTB_Click);
			// 
			// txttimkiemTB
			// 
			this.txttimkiemTB.Location = new System.Drawing.Point(456, 98);
			this.txttimkiemTB.Name = "txttimkiemTB";
			this.txttimkiemTB.Size = new System.Drawing.Size(160, 20);
			this.txttimkiemTB.TabIndex = 42;
			// 
			// btnthongkeTB
			// 
			this.btnthongkeTB.Location = new System.Drawing.Point(532, 130);
			this.btnthongkeTB.Name = "btnthongkeTB";
			this.btnthongkeTB.Size = new System.Drawing.Size(66, 26);
			this.btnthongkeTB.TabIndex = 41;
			this.btnthongkeTB.Text = "Thống Kê";
			this.btnthongkeTB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnthongkeTB.UseVisualStyleBackColor = true;
			this.btnthongkeTB.Click += new System.EventHandler(this.btnthongkeTB_Click);
			// 
			// btnundoTB
			// 
			this.btnundoTB.Location = new System.Drawing.Point(432, 130);
			this.btnundoTB.Name = "btnundoTB";
			this.btnundoTB.Size = new System.Drawing.Size(65, 26);
			this.btnundoTB.TabIndex = 40;
			this.btnundoTB.Text = "Undo";
			this.btnundoTB.UseVisualStyleBackColor = true;
			this.btnundoTB.Click += new System.EventHandler(this.btnundoTB_Click);
			// 
			// btnDeleteTB
			// 
			this.btnDeleteTB.Location = new System.Drawing.Point(321, 130);
			this.btnDeleteTB.Name = "btnDeleteTB";
			this.btnDeleteTB.Size = new System.Drawing.Size(63, 26);
			this.btnDeleteTB.TabIndex = 39;
			this.btnDeleteTB.Text = "Xóa";
			this.btnDeleteTB.UseVisualStyleBackColor = true;
			this.btnDeleteTB.Click += new System.EventHandler(this.btnDeleteTB_Click);
			// 
			// dtpNgayBH
			// 
			this.dtpNgayBH.CustomFormat = "dd-MM-yyyy";
			this.dtpNgayBH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgayBH.Location = new System.Drawing.Point(106, 101);
			this.dtpNgayBH.Name = "dtpNgayBH";
			this.dtpNgayBH.Size = new System.Drawing.Size(177, 20);
			this.dtpNgayBH.TabIndex = 37;
			this.dtpNgayBH.Value = new System.DateTime(2018, 4, 25, 15, 38, 25, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(356, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = "Mã Phòng Máy  : ";
			// 
			// txtsolanbh
			// 
			this.txtsolanbh.Location = new System.Drawing.Point(456, 7);
			this.txtsolanbh.Name = "txtsolanbh";
			this.txtsolanbh.Size = new System.Drawing.Size(160, 20);
			this.txtsolanbh.TabIndex = 33;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(356, 41);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 13);
			this.label9.TabIndex = 30;
			this.label9.Text = "Tên Sinh Viên : ";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(356, 14);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 13);
			this.label10.TabIndex = 29;
			this.label10.Text = "Số lần bảo hành  : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Tên Thiết Bị : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Tình Trạng : ";
			// 
			// txttinhtrang
			// 
			this.txttinhtrang.Location = new System.Drawing.Point(106, 71);
			this.txttinhtrang.Name = "txttinhtrang";
			this.txttinhtrang.Size = new System.Drawing.Size(177, 20);
			this.txttinhtrang.TabIndex = 25;
			// 
			// btnfixTB
			// 
			this.btnfixTB.Location = new System.Drawing.Point(219, 130);
			this.btnfixTB.Name = "btnfixTB";
			this.btnfixTB.Size = new System.Drawing.Size(64, 26);
			this.btnfixTB.TabIndex = 26;
			this.btnfixTB.Text = "Sửa";
			this.btnfixTB.UseVisualStyleBackColor = true;
			this.btnfixTB.Click += new System.EventHandler(this.btnfixTB_Click);
			// 
			// txttentb
			// 
			this.txttentb.Location = new System.Drawing.Point(106, 44);
			this.txttentb.Name = "txttentb";
			this.txttentb.Size = new System.Drawing.Size(177, 20);
			this.txttentb.TabIndex = 24;
			// 
			// txtmatb
			// 
			this.txtmatb.Location = new System.Drawing.Point(106, 13);
			this.txtmatb.Name = "txtmatb";
			this.txtmatb.ReadOnly = true;
			this.txtmatb.Size = new System.Drawing.Size(177, 20);
			this.txtmatb.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Ngày bảo hành : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Mã Thiết Bị :";
			// 
			// btnAddTB
			// 
			this.btnAddTB.Location = new System.Drawing.Point(109, 130);
			this.btnAddTB.Name = "btnAddTB";
			this.btnAddTB.Size = new System.Drawing.Size(63, 26);
			this.btnAddTB.TabIndex = 19;
			this.btnAddTB.Text = "Thêm";
			this.btnAddTB.UseVisualStyleBackColor = true;
			this.btnAddTB.Click += new System.EventHandler(this.btnAddTB_Click);
			// 
			// frmThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmThietBi";
			this.Size = new System.Drawing.Size(722, 458);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvThietBi;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button btnResetTB;
		private System.Windows.Forms.ComboBox cbTimKiemTB;
		private System.Windows.Forms.Button btntimkiemTB;
		private System.Windows.Forms.TextBox txttimkiemTB;
		private System.Windows.Forms.Button btnthongkeTB;
		private System.Windows.Forms.Button btnundoTB;
		private System.Windows.Forms.Button btnDeleteTB;
		private System.Windows.Forms.DateTimePicker dtpNgayBH;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtsolanbh;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txttinhtrang;
		private System.Windows.Forms.Button btnfixTB;
		private System.Windows.Forms.TextBox txttentb;
		private System.Windows.Forms.TextBox txtmatb;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddTB;
		private System.Windows.Forms.ComboBox cbmaPM;
	}
}
