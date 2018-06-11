namespace GUI.frmExtra
{
	partial class frmThongTinCaNhan
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
			this.txtThongTinCaNhan = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtThongTinCaNhan
			// 
			this.txtThongTinCaNhan.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtThongTinCaNhan.Location = new System.Drawing.Point(0, 0);
			this.txtThongTinCaNhan.Multiline = true;
			this.txtThongTinCaNhan.Name = "txtThongTinCaNhan";
			this.txtThongTinCaNhan.Size = new System.Drawing.Size(722, 458);
			this.txtThongTinCaNhan.TabIndex = 0;
			// 
			// frmThongTinCaNhan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtThongTinCaNhan);
			this.Name = "frmThongTinCaNhan";
			this.Size = new System.Drawing.Size(722, 458);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtThongTinCaNhan;
	}
}
