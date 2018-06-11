namespace GUI.frmExtra
{
	partial class frmLichTruc
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
			System.Windows.Forms.ColumnHeader columnHeader1;
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lvLichTruc = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdchieu = new System.Windows.Forms.RadioButton();
			this.rdtoi = new System.Windows.Forms.RadioButton();
			this.rdsang = new System.Windows.Forms.RadioButton();
			this.txtmalt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnthongke = new System.Windows.Forms.Button();
			this.btnundo = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnfix = new System.Windows.Forms.Button();
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.dtngaytruc = new System.Windows.Forms.DateTimePicker();
			this.ckbtangca = new System.Windows.Forms.CheckBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbmapm = new System.Windows.Forms.ComboBox();
			columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Mã Phòng Máy";
			columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			columnHeader1.Width = 150;
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
			this.splitContainer1.Panel1.Controls.Add(this.lvLichTruc);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.splitContainer1.Panel2.CausesValidation = false;
			this.splitContainer1.Panel2.Controls.Add(this.panel1);
			this.splitContainer1.Panel2.Controls.Add(this.txtmalt);
			this.splitContainer1.Panel2.Controls.Add(this.label6);
			this.splitContainer1.Panel2.Controls.Add(this.btnReset);
			this.splitContainer1.Panel2.Controls.Add(this.btnthongke);
			this.splitContainer1.Panel2.Controls.Add(this.btnundo);
			this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
			this.splitContainer1.Panel2.Controls.Add(this.btnfix);
			this.splitContainer1.Panel2.Controls.Add(this.txtMaNV);
			this.splitContainer1.Panel2.Controls.Add(this.button4);
			this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
			this.splitContainer1.Panel2.Controls.Add(this.dtngaytruc);
			this.splitContainer1.Panel2.Controls.Add(this.ckbtangca);
			this.splitContainer1.Panel2.Controls.Add(this.label4);
			this.splitContainer1.Panel2.Controls.Add(this.label5);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Panel2.Controls.Add(this.cbmapm);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(794, 529);
			this.splitContainer1.SplitterDistance = 311;
			this.splitContainer1.TabIndex = 0;
			// 
			// lvLichTruc
			// 
			this.lvLichTruc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.lvLichTruc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLichTruc.FullRowSelect = true;
			this.lvLichTruc.GridLines = true;
			this.lvLichTruc.HideSelection = false;
			this.lvLichTruc.Location = new System.Drawing.Point(0, 0);
			this.lvLichTruc.Name = "lvLichTruc";
			this.lvLichTruc.Size = new System.Drawing.Size(794, 311);
			this.lvLichTruc.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lvLichTruc.TabIndex = 0;
			this.lvLichTruc.UseCompatibleStateImageBehavior = false;
			this.lvLichTruc.View = System.Windows.Forms.View.Details;
			this.lvLichTruc.SelectedIndexChanged += new System.EventHandler(this.lvLichTruc_SelectedIndexChanged);
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Mã Lịch Trực";
			this.columnHeader6.Width = 80;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã Nhân Viên";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày Trực";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 150;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ca Trực ";
			this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Tăng Ca";
			this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader5.Width = 100;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdchieu);
			this.panel1.Controls.Add(this.rdtoi);
			this.panel1.Controls.Add(this.rdsang);
			this.panel1.Location = new System.Drawing.Point(469, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(82, 74);
			this.panel1.TabIndex = 58;
			// 
			// rdchieu
			// 
			this.rdchieu.AutoSize = true;
			this.rdchieu.Location = new System.Drawing.Point(13, 27);
			this.rdchieu.Name = "rdchieu";
			this.rdchieu.Size = new System.Drawing.Size(52, 17);
			this.rdchieu.TabIndex = 56;
			this.rdchieu.Text = "Chiều";
			this.rdchieu.UseVisualStyleBackColor = true;
			// 
			// rdtoi
			// 
			this.rdtoi.AutoSize = true;
			this.rdtoi.Location = new System.Drawing.Point(13, 52);
			this.rdtoi.Name = "rdtoi";
			this.rdtoi.Size = new System.Drawing.Size(40, 17);
			this.rdtoi.TabIndex = 57;
			this.rdtoi.Text = "Tối";
			this.rdtoi.UseVisualStyleBackColor = true;
			// 
			// rdsang
			// 
			this.rdsang.AutoSize = true;
			this.rdsang.Location = new System.Drawing.Point(13, 6);
			this.rdsang.Name = "rdsang";
			this.rdsang.Size = new System.Drawing.Size(50, 17);
			this.rdsang.TabIndex = 55;
			this.rdsang.Text = "Sáng";
			this.rdsang.UseVisualStyleBackColor = true;
			// 
			// txtmalt
			// 
			this.txtmalt.Location = new System.Drawing.Point(133, 17);
			this.txtmalt.Name = "txtmalt";
			this.txtmalt.Size = new System.Drawing.Size(219, 20);
			this.txtmalt.TabIndex = 54;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 19);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 13);
			this.label6.TabIndex = 53;
			this.label6.Text = "Mã Lịch Trực  : ";
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(28, 151);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(72, 23);
			this.btnReset.TabIndex = 52;
			this.btnReset.Text = "Reset";
			this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnthongke
			// 
			this.btnthongke.Location = new System.Drawing.Point(549, 152);
			this.btnthongke.Name = "btnthongke";
			this.btnthongke.Size = new System.Drawing.Size(72, 23);
			this.btnthongke.TabIndex = 51;
			this.btnthongke.Text = "Thống Kê";
			this.btnthongke.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnthongke.UseVisualStyleBackColor = true;
			this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
			// 
			// btnundo
			// 
			this.btnundo.Location = new System.Drawing.Point(438, 151);
			this.btnundo.Name = "btnundo";
			this.btnundo.Size = new System.Drawing.Size(72, 23);
			this.btnundo.TabIndex = 50;
			this.btnundo.Text = "Undo";
			this.btnundo.UseVisualStyleBackColor = true;
			this.btnundo.Click += new System.EventHandler(this.btnundo_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(325, 150);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(72, 23);
			this.btnDelete.TabIndex = 49;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnfix
			// 
			this.btnfix.Location = new System.Drawing.Point(222, 151);
			this.btnfix.Name = "btnfix";
			this.btnfix.Size = new System.Drawing.Size(72, 23);
			this.btnfix.TabIndex = 47;
			this.btnfix.Text = "Sửa";
			this.btnfix.UseVisualStyleBackColor = true;
			this.btnfix.Click += new System.EventHandler(this.btnfix_Click);
			// 
			// txtMaNV
			// 
			this.txtMaNV.Location = new System.Drawing.Point(133, 73);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(219, 20);
			this.txtMaNV.TabIndex = 16;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.button4.Location = new System.Drawing.Point(358, 70);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(39, 23);
			this.button4.TabIndex = 14;
			this.button4.Text = "...";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(124, 151);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(72, 23);
			this.btnAdd.TabIndex = 11;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.button1_Click);
			// 
			// dtngaytruc
			// 
			this.dtngaytruc.CustomFormat = "dd-MM-yyyy";
			this.dtngaytruc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtngaytruc.Location = new System.Drawing.Point(124, 112);
			this.dtngaytruc.Name = "dtngaytruc";
			this.dtngaytruc.Size = new System.Drawing.Size(228, 20);
			this.dtngaytruc.TabIndex = 9;
			// 
			// ckbtangca
			// 
			this.ckbtangca.Location = new System.Drawing.Point(494, 85);
			this.ckbtangca.Name = "ckbtangca";
			this.ckbtangca.Size = new System.Drawing.Size(30, 30);
			this.ckbtangca.TabIndex = 8;
			this.ckbtangca.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(424, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Tăng Ca : ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(421, 18);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Ca Trực : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Ngày Trực : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mã Nhân Viên  : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mã Phòng Máy : ";
			// 
			// cbmapm
			// 
			this.cbmapm.FormattingEnabled = true;
			this.cbmapm.Location = new System.Drawing.Point(133, 43);
			this.cbmapm.Name = "cbmapm";
			this.cbmapm.Size = new System.Drawing.Size(219, 21);
			this.cbmapm.TabIndex = 0;
			this.cbmapm.SelectedIndexChanged += new System.EventHandler(this.cbmapm_SelectedIndexChanged);
			// 
			// frmLichTruc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmLichTruc";
			this.Size = new System.Drawing.Size(794, 529);
			this.Load += new System.EventHandler(this.frmLichTruc_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvLichTruc;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtngaytruc;
		private System.Windows.Forms.CheckBox ckbtangca;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ComboBox cbmapm;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnthongke;
		private System.Windows.Forms.Button btnundo;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnfix;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TextBox txtmalt;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rdtoi;
		private System.Windows.Forms.RadioButton rdchieu;
		private System.Windows.Forms.RadioButton rdsang;
		private System.Windows.Forms.Panel panel1;
	}
}
