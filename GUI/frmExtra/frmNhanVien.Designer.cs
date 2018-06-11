namespace GUI
{
	partial class frmNhanVien
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
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnReset = new System.Windows.Forms.Button();
			this.cbTimKiem = new System.Windows.Forms.ComboBox();
			this.btntimkiem = new System.Windows.Forms.Button();
			this.txttimkiem = new System.Windows.Forms.TextBox();
			this.btnthongke = new System.Windows.Forms.Button();
			this.btnundo = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtchucvu = new System.Windows.Forms.TextBox();
			this.txthesoluong = new System.Windows.Forms.TextBox();
			this.txtluong = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtgioitinh = new System.Windows.Forms.TextBox();
			this.btnfix = new System.Windows.Forms.Button();
			this.txttennv = new System.Windows.Forms.TextBox();
			this.txtmanv = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Mã Nhân Viên";
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
			this.splitContainer1.Panel1.Controls.Add(this.lvSinhVien);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.CausesValidation = false;
			this.splitContainer1.Panel2.Controls.Add(this.btnReset);
			this.splitContainer1.Panel2.Controls.Add(this.cbTimKiem);
			this.splitContainer1.Panel2.Controls.Add(this.btntimkiem);
			this.splitContainer1.Panel2.Controls.Add(this.txttimkiem);
			this.splitContainer1.Panel2.Controls.Add(this.btnthongke);
			this.splitContainer1.Panel2.Controls.Add(this.btnundo);
			this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
			this.splitContainer1.Panel2.Controls.Add(this.dtpNgaySinh);
			this.splitContainer1.Panel2.Controls.Add(this.label6);
			this.splitContainer1.Panel2.Controls.Add(this.label7);
			this.splitContainer1.Panel2.Controls.Add(this.txtchucvu);
			this.splitContainer1.Panel2.Controls.Add(this.txthesoluong);
			this.splitContainer1.Panel2.Controls.Add(this.txtluong);
			this.splitContainer1.Panel2.Controls.Add(this.label9);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.txtgioitinh);
			this.splitContainer1.Panel2.Controls.Add(this.btnfix);
			this.splitContainer1.Panel2.Controls.Add(this.txttennv);
			this.splitContainer1.Panel2.Controls.Add(this.txtmanv);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
 			this.splitContainer1.Size = new System.Drawing.Size(722, 458);
			this.splitContainer1.SplitterDistance = 270;
			this.splitContainer1.TabIndex = 0;
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader1});
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(0, 0);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(722, 270);
			this.lvSinhVien.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvSinhVien.TabIndex = 2;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tên Nhân Viên";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 200;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giới Tính";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 100;
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
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(20, 131);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 45;
			this.btnReset.Text = "Reset";
			this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// cbTimKiem
			// 
			this.cbTimKiem.FormattingEnabled = true;
			this.cbTimKiem.Location = new System.Drawing.Point(347, 99);
			this.cbTimKiem.Name = "cbTimKiem";
			this.cbTimKiem.Size = new System.Drawing.Size(94, 21);
			this.cbTimKiem.TabIndex = 44;
			this.cbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cbTimKiem_SelectedIndexChanged);
			// 
			// btntimkiem
			// 
			this.btntimkiem.Location = new System.Drawing.Point(645, 101);
			this.btntimkiem.Name = "btntimkiem";
			this.btntimkiem.Size = new System.Drawing.Size(61, 23);
			this.btntimkiem.TabIndex = 43;
			this.btntimkiem.Text = "Tìm Kiếm";
			this.btntimkiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btntimkiem.UseVisualStyleBackColor = true;
			this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
			// 
			// txttimkiem
			// 
			this.txttimkiem.Location = new System.Drawing.Point(456, 98);
			this.txttimkiem.Name = "txttimkiem";
			this.txttimkiem.Size = new System.Drawing.Size(183, 20);
			this.txttimkiem.TabIndex = 42;
			// 
			// btnthongke
			// 
			this.btnthongke.Location = new System.Drawing.Point(547, 130);
			this.btnthongke.Name = "btnthongke";
			this.btnthongke.Size = new System.Drawing.Size(75, 23);
			this.btnthongke.TabIndex = 41;
			this.btnthongke.Text = "Thống Kê";
			this.btnthongke.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnthongke.UseVisualStyleBackColor = true;
			this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
			// 
			// btnundo
			// 
			this.btnundo.Location = new System.Drawing.Point(437, 130);
			this.btnundo.Name = "btnundo";
			this.btnundo.Size = new System.Drawing.Size(75, 23);
			this.btnundo.TabIndex = 40;
			this.btnundo.Text = "Undo";
			this.btnundo.UseVisualStyleBackColor = true;
			this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(321, 130);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 39;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// dtpNgaySinh
			// 
			this.dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
			this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgaySinh.Location = new System.Drawing.Point(106, 101);
			this.dtpNgaySinh.Name = "dtpNgaySinh";
			this.dtpNgaySinh.Size = new System.Drawing.Size(200, 20);
			this.dtpNgaySinh.TabIndex = 37;
			this.dtpNgaySinh.Value = new System.DateTime(2018, 4, 25, 15, 38, 25, 0);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(356, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 13);
			this.label6.TabIndex = 34;
			this.label6.Text = " Hệ Số Lương  : ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(356, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 35;
			this.label7.Text = "Chức Vụ : ";
			// 
			// txtchucvu
			// 
			this.txtchucvu.Location = new System.Drawing.Point(456, 65);
			this.txtchucvu.Name = "txtchucvu";
			this.txtchucvu.Size = new System.Drawing.Size(183, 20);
			this.txtchucvu.TabIndex = 31;
			// 
			// txthesoluong
			// 
			this.txthesoluong.Location = new System.Drawing.Point(456, 38);
			this.txthesoluong.Name = "txthesoluong";
			this.txthesoluong.Size = new System.Drawing.Size(183, 20);
			this.txthesoluong.TabIndex = 32;
			// 
			// txtluong
			// 
			this.txtluong.Location = new System.Drawing.Point(456, 7);
			this.txtluong.Name = "txtluong";
			this.txtluong.Size = new System.Drawing.Size(183, 20);
			this.txtluong.TabIndex = 33;
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
			this.label10.Size = new System.Drawing.Size(49, 13);
			this.label10.TabIndex = 29;
			this.label10.Text = "Lương  : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 28;
			this.label5.Text = "Tên Nhân Viên : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 27;
			this.label4.Text = "Giới Tính : ";
			// 
			// txtgioitinh
			// 
			this.txtgioitinh.Location = new System.Drawing.Point(106, 71);
			this.txtgioitinh.Name = "txtgioitinh";
			this.txtgioitinh.Size = new System.Drawing.Size(200, 20);
			this.txtgioitinh.TabIndex = 25;
			// 
			// btnfix
			// 
			this.btnfix.Location = new System.Drawing.Point(219, 130);
			this.btnfix.Name = "btnfix";
			this.btnfix.Size = new System.Drawing.Size(75, 23);
			this.btnfix.TabIndex = 26;
			this.btnfix.Text = "Sửa";
			this.btnfix.UseVisualStyleBackColor = true;
			this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
			// 
			// txttennv
			// 
			this.txttennv.Location = new System.Drawing.Point(106, 44);
			this.txttennv.Name = "txttennv";
			this.txttennv.Size = new System.Drawing.Size(200, 20);
			this.txttennv.TabIndex = 24;
			// 
			// txtmanv
			// 
			this.txtmanv.Location = new System.Drawing.Point(106, 13);
			this.txtmanv.Name = "txtmanv";
			this.txtmanv.Size = new System.Drawing.Size(200, 20);
			this.txtmanv.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 22;
			this.label3.Text = "Ngày Sinh : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 21;
			this.label2.Text = "Tên Sinh Viên : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Mã Nhân Viên : ";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(109, 130);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmNhanVien";
			this.Size = new System.Drawing.Size(722, 458);
			this.Load += new System.EventHandler(this.frmNhanVien_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ComboBox cbTimKiem;
		private System.Windows.Forms.Button btntimkiem;
		private System.Windows.Forms.TextBox txttimkiem;
		private System.Windows.Forms.Button btnthongke;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtchucvu;
		private System.Windows.Forms.TextBox txthesoluong;
		private System.Windows.Forms.TextBox txtluong;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtgioitinh;
		private System.Windows.Forms.Button btnfix;
		private System.Windows.Forms.TextBox txttennv;
		private System.Windows.Forms.TextBox txtmanv;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnundo;
	}
}
