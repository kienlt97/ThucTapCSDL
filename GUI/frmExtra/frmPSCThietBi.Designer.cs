namespace GUI.frmExtra
{
	partial class frmPSCThietBi
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
			this.lvPhieuSuaChua = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnmatb = new System.Windows.Forms.Button();
			this.txtmanv = new System.Windows.Forms.TextBox();
			this.txtmatb = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.dtngaysua = new System.Windows.Forms.DateTimePicker();
			this.txtchihi = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnfix = new System.Windows.Forms.Button();
			this.txtmaphieu = new System.Windows.Forms.TextBox();
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
			this.splitContainer1.Panel1.Controls.Add(this.lvPhieuSuaChua);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.CausesValidation = false;
			this.splitContainer1.Panel2.Controls.Add(this.btnmatb);
			this.splitContainer1.Panel2.Controls.Add(this.txtmanv);
			this.splitContainer1.Panel2.Controls.Add(this.txtmatb);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
			this.splitContainer1.Panel2.Controls.Add(this.dtngaysua);
			this.splitContainer1.Panel2.Controls.Add(this.txtchihi);
			this.splitContainer1.Panel2.Controls.Add(this.label10);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.btnfix);
			this.splitContainer1.Panel2.Controls.Add(this.txtmaphieu);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
			this.splitContainer1.Panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer1.Size = new System.Drawing.Size(733, 529);
			this.splitContainer1.SplitterDistance = 345;
			this.splitContainer1.TabIndex = 1;
			// 
			// lvPhieuSuaChua
			// 
			this.lvPhieuSuaChua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvPhieuSuaChua.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPhieuSuaChua.FullRowSelect = true;
			this.lvPhieuSuaChua.GridLines = true;
			this.lvPhieuSuaChua.HideSelection = false;
			this.lvPhieuSuaChua.Location = new System.Drawing.Point(0, 0);
			this.lvPhieuSuaChua.Name = "lvPhieuSuaChua";
			this.lvPhieuSuaChua.Size = new System.Drawing.Size(733, 345);
			this.lvPhieuSuaChua.TabIndex = 2;
			this.lvPhieuSuaChua.UseCompatibleStateImageBehavior = false;
			this.lvPhieuSuaChua.View = System.Windows.Forms.View.Details;
			this.lvPhieuSuaChua.SelectedIndexChanged += new System.EventHandler(this.lvPhieuSuaChua_SelectedIndexChanged);
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
			// btnmatb
			// 
			this.btnmatb.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnmatb.Location = new System.Drawing.Point(376, 40);
			this.btnmatb.Name = "btnmatb";
			this.btnmatb.Size = new System.Drawing.Size(39, 23);
			this.btnmatb.TabIndex = 44;
			this.btnmatb.Text = "...";
			this.btnmatb.UseVisualStyleBackColor = false;
			this.btnmatb.Click += new System.EventHandler(this.btnmatb_Click);
			// 
			// txtmanv
			// 
			this.txtmanv.Location = new System.Drawing.Point(119, 69);
			this.txtmanv.Name = "txtmanv";
			this.txtmanv.ReadOnly = true;
			this.txtmanv.Size = new System.Drawing.Size(251, 22);
			this.txtmanv.TabIndex = 42;
			// 
			// txtmatb
			// 
			this.txtmatb.Location = new System.Drawing.Point(119, 42);
			this.txtmatb.Name = "txtmatb";
			this.txtmatb.Size = new System.Drawing.Size(251, 22);
			this.txtmatb.TabIndex = 41;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 17);
			this.label5.TabIndex = 40;
			this.label5.Text = "Mã Thiết Bị  : ";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(471, 122);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(87, 23);
			this.btnDelete.TabIndex = 39;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
			// btnfix
			// 
			this.btnfix.Location = new System.Drawing.Point(304, 122);
			this.btnfix.Name = "btnfix";
			this.btnfix.Size = new System.Drawing.Size(87, 23);
			this.btnfix.TabIndex = 26;
			this.btnfix.Text = "Sửa";
			this.btnfix.UseVisualStyleBackColor = true;
			this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
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
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(155, 122);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(87, 23);
			this.btnAdd.TabIndex = 19;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// frmPSCThietBi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmPSCThietBi";
			this.Size = new System.Drawing.Size(733, 529);
			this.Load += new System.EventHandler(this.frmPSCThietBi_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvPhieuSuaChua;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DateTimePicker dtngaysua;
		private System.Windows.Forms.TextBox txtchihi;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnfix;
		private System.Windows.Forms.TextBox txtmaphieu;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtmanv;
		private System.Windows.Forms.TextBox txtmatb;
		private System.Windows.Forms.Button btnmatb;
	}
}
