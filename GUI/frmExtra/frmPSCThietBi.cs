using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI.frmExtra
{
	public partial class frmPSCThietBi : UserControl
	{
		public static int idex = 3;
		public frmPSCThietBi()
		{
			InitializeComponent();
			ShowData();
		}
		public static string manv = string.Empty;
		#region ShowData
		List<PSCThietBi> listPhieu = PSCThietBiBLL.ShowPSCThietBi();
		List<string> lstMaphieu = new List<string>();
		private void ShowData()
		{
			
			lvPhieuSuaChua.Items.Clear();
			foreach (PSCThietBi ph in listPhieu)
			{
				ListViewItem liv = new ListViewItem(ph.MaPhieu);
				liv.SubItems.Add(ph.MaTB);
				liv.SubItems.Add(ph.MaNV);
				liv.SubItems.Add(ph.NgaySua.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(ph.ChiPhi.ToString());

				lstMaphieu.Add(ph.MaPhieu);
				lvPhieuSuaChua.Items.Add(liv);
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
		public void GETMATB(string value)
		{
			txtmatb.Text = value;
		}
		#endregion
		#region Controller
		 
		// lấy mã thiết bị
		private void btnmatb_Click(object sender, EventArgs e)
		{
			frmThongTinTB frmthongtintb = new frmThongTinTB();
			frmthongtintb.mydata = new frmThongTinTB.GETDATA(GETMATB);
			DialogResult dr = frmthongtintb.ShowDialog();
			if (dr == DialogResult.Cancel)
			{
				frmthongtintb.Close();
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			key = 1;

			bool check = true;
			Random rd = new Random();
			int x = rd.Next(0, 20);
			if (x < 10)
				txtmaphieu.Text = "Phieu 0" + x.ToString();
			if (x > 10)
				txtmaphieu.Text = "Phieu" + x.ToString();
			foreach (string str in lstMaphieu)
			{
				if (str.Contains(txtmaphieu.Text))
				{
					check = false;
					break;
				}
				check = true;
			}
			if (check == true)
			{
				ListViewItem liv = new ListViewItem(txtmaphieu.Text);
				liv.SubItems.Add(txtmatb.Text);
				liv.SubItems.Add(txtmanv.Text);
				liv.SubItems.Add(dtngaysua.Text);
				liv.SubItems.Add(txtchihi.Text);
			}
		}

		private void btnfix_Click(object sender, EventArgs e)
		{
			key = 2;
			if (lvPhieuSuaChua.SelectedItems.Count == 0) return;
			ListViewItem liv = lvPhieuSuaChua.SelectedItems[0];
			liv.SubItems[0].Text = txtmaphieu.Text;
			liv.SubItems[1].Text = txtmatb.Text;
			liv.SubItems[2].Text = txtmanv.Text;
			liv.SubItems[3].Text = dtngaysua.Text;
			liv.SubItems[4].Text = txtchihi.Text;
 			
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			key = 3;
			for (int i = 0; i < lvPhieuSuaChua.Items.Count; i++)
			{
				if (lvPhieuSuaChua.Items[i].Selected)
				{
					lvPhieuSuaChua.Items[i].Remove();
					i--;
				}
			}
 		}
		#endregion
		private void lvPhieuSuaChua_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvPhieuSuaChua.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvPhieuSuaChua.SelectedItems[0];
			txtmaphieu.Text = liv.SubItems[0].Text;
  			txtmatb.Text = liv.SubItems[1].Text;
			txtmanv.Text = liv.SubItems[2].Text;

			string[] date = liv.SubItems[3].Text.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtngaysua.Value = dt;
 			txtchihi.Text = liv.SubItems[4].Text;
		}
		#region GETDATA
		public PSCThietBi GETPHIEUTB()
		{
			string maphieu = txtmaphieu.Text;
			string matb = txtmatb.Text;
			string manv = txtmanv.Text;
			DateTime ngaysua = dtngaysua.Value;
			double chiphi = double.Parse(txtchihi.Text);

			PSCThietBi phieu = new PSCThietBi(maphieu, matb, manv, ngaysua, chiphi);

			return phieu;
		}
		public string GETMATB() { return txtmatb.Text; }


		#endregion

		private void frmPSCThietBi_Load(object sender, EventArgs e)
		{
			txtmanv.Text = manv;
		}
	}
}
