using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI.frmExtra
{
	public partial class frmPSCMayTinh : UserControl
	{
		public delegate void GETDATA();
		public frmPSCMayTinh()
		{
			InitializeComponent();
			ShowData();
			btnAddMT.Enabled = true;
			btnEditMT.Enabled = false;
			btnDeleteMT.Enabled = false;
		}
		
		#region ShowData
		List<PhieuSuaChua> listPhieuMT = PSCMayTinhBLL.ShowPhieuSuaChua();
		List<string> lstMaphieu = new List<string>();
		private void ShowData()
		{
			lvPSCMT.Items.Clear();
			foreach (PhieuSuaChua ph in listPhieuMT)
			{
				ListViewItem liv = new ListViewItem(ph.MaPhieu);
				liv.SubItems.Add(ph.MaMay);
				liv.SubItems.Add(ph.MaNV);
				liv.SubItems.Add(ph.NgaySua.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(ph.ChiPhi.ToString());

				lstMaphieu.Add(ph.MaPhieu);
				lvPSCMT.Items.Add(liv);
			}
		}
		static int key = 0;
		public static int setkey()
		{
			return key;
		}
		public void GETVALUE(string value)
		{
			txtmanv.Text = value;
		}
		public void GETMAMT(string value)
		{
			txtmamay.Text = value;
 		}
 		#endregion
		#region Controller

		// lấy mã máy tính
		public static string manv = string.Empty;
 		
		private void btnmamay_Click(object sender, EventArgs e)
		{
			frmThongTinMayTinh frmthongtinmt = new frmThongTinMayTinh();
			frmthongtinmt.mydata = new frmThongTinMayTinh.GETDATA(GETMAMT);
			DialogResult dr = frmthongtinmt.ShowDialog();
			if (dr == DialogResult.Cancel)
			{
				frmthongtinmt.Close();
			}
		}
		private void btnAddMT_Click(object sender, EventArgs e)
		{
			key = 1;
			bool check = true;
			Random rd = new Random();
 			int x = rd.Next(0, 20);
			if (x < 10)
				txtmaphieu.Text = "P0" + x.ToString();
			if (x > 10)
				txtmaphieu.Text = "P" + x.ToString();
			foreach (string str in lstMaphieu)
			{
				if (str.Contains(txtmaphieu.Text))
				{
					check = false;
					break;
				}
				check = true;
			}
			if(check == true)
			{
				ListViewItem liv = new ListViewItem(txtmaphieu.Text);
				liv.SubItems.Add(txtmamay.Text);
				liv.SubItems.Add(txtmanv.Text);
				liv.SubItems.Add(dtngaysua.Text);
				liv.SubItems.Add(txtchihi.Text);
				lvPSCMT.Items.Add(liv);
			}
 		}
		private void btnEditMT_Click(object sender, EventArgs e)
		{
			key = 2;
			if (lvPSCMT.SelectedItems.Count == 0) return;
			ListViewItem liv = lvPSCMT.SelectedItems[0];
			liv.SubItems[0].Text = txtmaphieu.Text;
			liv.SubItems[1].Text = txtmamay.Text;
			liv.SubItems[2].Text = txtmanv.Text;
			liv.SubItems[3].Text = dtngaysua.Text;
			liv.SubItems[4].Text = txtchihi.Text;
		}

		private void btnDeleteMT_Click(object sender, EventArgs e)
		{
			key = 3;
			for (int i = 0; i < lvPSCMT.Items.Count; i++)
			{
				if (lvPSCMT.Items[i].Selected)
				{
					lvPSCMT.Items[i].Remove();
					i--;
				}
			}
		}
		#endregion
		private void lvPSCMT_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAddMT.Enabled = false;
			btnEditMT.Enabled = true;
			btnDeleteMT.Enabled = true;
			if (lvPSCMT.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvPSCMT.SelectedItems[0];
			txtmaphieu.Text = liv.SubItems[0].Text;
			txtmamay.Text = liv.SubItems[1].Text;
			txtmanv.Text = liv.SubItems[2].Text;

			string[] date = liv.SubItems[3].Text.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtngaysua.Value = dt;
			txtchihi.Text = liv.SubItems[4].Text;
		}
		#region GETDATA
		public PhieuSuaChua GETPHIEUMT()
		{
			string maphieu = txtmaphieu.Text;
			string mamay = txtmamay.Text;
			string manv = txtmanv.Text;
			DateTime ngaysua = dtngaysua.Value;
			double chiphi = double.Parse(txtchihi.Text);

			PhieuSuaChua phieu = new PhieuSuaChua(maphieu, mamay, manv, ngaysua, chiphi);

			return phieu;
		}
		public string GETMAMT() { return txtmaphieu.Text; }

		#endregion

		private void frmPSCMayTinh_Load(object sender, EventArgs e)
		{
			txtmanv.Text = manv;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			btnEditMT.Enabled = false;
			btnAddMT.Enabled = true;
			btnDeleteMT.Enabled = false;
			txtmaphieu.ResetText();
			txtmamay.ResetText();
			txtmanv.ResetText();
			txtchihi.ResetText();
			dtngaysua.ResetText();
		}
	}
}
