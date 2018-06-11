namespace GUI.frmExtra
{
	partial class frmPSCMayTinh
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
			this.lvPSCMT = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnmamay = new System.Windows.Forms.Button();
			this.txtmanv = new System.Windows.Forms.TextBox();
			this.txtmamay = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDeleteMT = new System.Windows.Forms.Button();
			this.dtngaysua = new System.Windows.Forms.DateTimePicker();
			this.txtchihi = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnEditMT = new System.Windows.Forms.Button();
			this.txtmaphieu = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddMT = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Mã Phiếu ";
			columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader2.Width = 120;
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
			this.splitContainer1.Panel1.Controls.Add(this.lvPSCMT);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.CausesValidation = false;
			this.splitContainer1.Panel2.Controls.Add(this.btnReset);
			this.splitContainer1.Panel2.Controls.Add(this.btnmamay);
			this.splitContainer1.Panel2.Controls.Add(this.txtmanv);
			this.splitContainer1.Panel2.Controls.Add(this.txtmamay);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.btnDeleteMT);
			this.splitContainer1.Panel2.Controls.Add(this.dtngaysua);
			this.splitContainer1.Panel2.Controls.Add(this.txtchihi);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.btnEditMT);
			this.splitContainer1.Panel2.Controls.Add(this.txtmaphieu);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.btnAddMT);
			this.splitContainer1.Panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer1.Size = new System.Drawing.Size(733, 529);
			this.splitContainer1.SplitterDistance = 345;
			this.splitContainer1.TabIndex = 2;
			// 
			// lvPSCMT
			// 
			this.lvPSCMT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvPSCMT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPSCMT.FullRowSelect = true;
			this.lvPSCMT.GridLines = true;
			this.lvPSCMT.HideSelection = false;
			this.lvPSCMT.Location = new System.Drawing.Point(0, 0);
			this.lvPSCMT.Name = "lvPSCMT";
			this.lvPSCMT.Size = new System.Drawing.Size(733, 345);
			this.lvPSCMT.TabIndex = 2;
			this.lvPSCMT.UseCompatibleStateImageBehavior = false;
			this.lvPSCMT.View = System.Windows.Forms.View.Details;
			this.lvPSCMT.SelectedIndexChanged += new System.EventHandler(this.lvPSCMT_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Mã Máy";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 120;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Mã Nhân Viên";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 150;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày Sửa";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 150;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Chi Phí";
			this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader6.Width = 150;
			// 
			// btnmamay
			// 
			this.btnmamay.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnmamay.Location = new System.Drawing.Point(376, 40);
			this.btnmamay.Name = "btnmamay";
			this.btnmamay.Size = new System.Drawing.Size(39, 23);
			this.btnmamay.TabIndex = 44;
			this.btnmamay.Text = "...";
			this.btnmamay.UseVisualStyleBackColor = false;
			this.btnmamay.Click += new System.EventHandler(this.btnmamay_Click);
			// 
			// txtmanv
			// 
			this.txtmanv.Location = new System.Drawing.Point(119, 69);
			this.txtmanv.Name = "txtmanv";
			this.txtmanv.ReadOnly = true;
			this.txtmanv.Size = new System.Drawing.Size(251, 22);
			this.txtmanv.TabIndex = 42;
			// 
			// txtmamay
			// 
			this.txtmamay.Location = new System.Drawing.Point(119, 42);
			this.txtmamay.Name = "txtmamay";
			this.txtmamay.Size = new System.Drawing.Size(251, 22);
			this.txtmamay.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 17);
			this.label5.TabIndex = 40;
			this.label5.Text = "Mã Máy Tính  : ";
			// 
			// btnDeleteMT
			// 
			this.btnDeleteMT.Location = new System.Drawing.Point(471, 122);
			this.btnDeleteMT.Name = "btnDeleteMT";
			this.btnDeleteMT.Size = new System.Drawing.Size(87, 23);
			this.btnDeleteMT.TabIndex = 39;
			this.btnDeleteMT.Text = "Xóa";
			this.btnDeleteMT.UseVisualStyleBackColor = true;
			this.btnDeleteMT.Click += new System.EventHandler(this.btnDeleteMT_Click);
			// 
			// dtngaysua
			// 
			this.dtngaysua.CustomFormat = "dd-MM-yyyy";
			this.dtngaysua.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtngaysua.Location = new System.Drawing.Point(511, 47);
			this.dtngaysua.Name = "dtngaysua";
			this.dtngaysua.Size = new System.Drawing.Size(200, 22);
			this.dtngaysua.TabIndex = 37;
			// 
			// txtchihi
			// 
			this.txtchihi.Location = new System.Drawing.Point(511, 13);
			this.txtchihi.Name = "txtchihi";
			this.txtchihi.Size = new System.Drawing.Size(200, 22);
			this.txtchihi.TabIndex = 33;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(434, 20);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 17);
			this.label10.TabIndex = 29;
			this.label10.Text = "Chi Phí  : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 74);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 17);
			this.label4.TabIndex = 27;
			this.label4.Text = "Mã Nhân Viên : ";
			// 
			// btnEditMT
			// 
			this.btnEditMT.Location = new System.Drawing.Point(304, 122);
			this.btnEditMT.Name = "btnEditMT";
			this.btnEditMT.Size = new System.Drawing.Size(87, 23);
			this.btnEditMT.TabIndex = 26;
			this.btnEditMT.Text = "Sửa";
			this.btnEditMT.UseVisualStyleBackColor = true;
			this.btnEditMT.Click += new System.EventHandler(this.btnEditMT_Click);
			// 
			// txtmaphieu
			// 
			this.txtmaphieu.Location = new System.Drawing.Point(119, 13);
			this.txtmaphieu.Name = "txtmaphieu";
			this.txtmaphieu.ReadOnly = true;
			this.txtmaphieu.Size = new System.Drawing.Size(251, 22);
			this.txtmaphieu.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(434, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "Ngày Sửa : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 16);
			this.label2.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(30, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Mã Phiếu  : ";
			// 
			// btnAddMT
			// 
			this.btnAddMT.Location = new System.Drawing.Point(155, 122);
			this.btnAddMT.Name = "btnAddMT";
			this.btnAddMT.Size = new System.Drawing.Size(87, 23);
			this.btnAddMT.TabIndex = 19;
			this.btnAddMT.Text = "Thêm";
			this.btnAddMT.UseVisualStyleBackColor = true;
			this.btnAddMT.Click += new System.EventHandler(this.btnAddMT_Click);
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(36, 122);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(87, 23);
			this.btnReset.TabIndex = 45;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// frmPSCMayTinh
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmPSCMayTinh";
			this.Size = new System.Drawing.Size(733, 529);
			this.Load += new System.EventHandler(this.frmPSCMayTinh_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvPSCMT;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button btnmamay;
		private System.Windows.Forms.TextBox txtmanv;
		private System.Windows.Forms.TextBox txtmamay;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnDeleteMT;
		private System.Windows.Forms.DateTimePicker dtngaysua;
		private System.Windows.Forms.TextBox txtchihi;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnEditMT;
		private System.Windows.Forms.TextBox txtmaphieu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddMT;
		private System.Windows.Forms.Button btnReset;
	}
}
