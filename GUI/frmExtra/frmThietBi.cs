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
	public partial class frmThietBi : UserControl
	{
		public static int key = 3;
		public frmThietBi()
		{
			InitializeComponent();
			ShowPM();
			ShowData();
			string[] item = new string[] { "Mã Thiết", "Tên Thiết Bị", "Tình Trạng",
			"Hạn Bảo Hành","Số lần bảo hành" ,"Mã phòng máy"};

			for (int i = 0; i < item.Count(); i++)
			{
				cbTimKiemTB.Items.Add(item[i]);
			}
		}
		#region ShowData
		List<ThietBi> listTB = new List<ThietBi>();
		List<string> lstMaTB = new List<string>();
		public void ShowData()
		{
			txtmatb.Enabled = false;
			listTB = ThietBiBLL.ShowThietBi();
			lvThietBi.Items.Clear();
			foreach (ThietBi tb in listTB)
			{
				ListViewItem liv = new ListViewItem(tb.MaTB);
				liv.SubItems.Add(tb.TenTB);
				liv.SubItems.Add(tb.TinhTrang);
				liv.SubItems.Add(tb.HanBH.ToString("dd-MM-yyyyy"));
				liv.SubItems.Add(tb.solanBH.ToString());
				liv.SubItems.Add(tb.MaPM.ToString());

				lstMaTB.Add(tb.MaTB);
				lvThietBi.Items.Add(liv);
			}
		}
		private void ShowPM()
		{
			List<PhongMay> listPM = PhongMayBLL.ShowPhongMay();
			cbmaPM.Items.Clear();
			foreach (PhongMay pm in listPM)
			{
				string mapm = pm.MaPM;
				string tenpm = pm.TenPM;

				cbmaPM.Items.Add(mapm + "-" + tenpm);
			}
		}
		string[] arrAll = new string[2];
		private void cbmapm_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string valuePM = cbmaPM.SelectedItem.ToString();
			string[] arrPM = valuePM.Split('-');
			arrAll[0] = arrPM[0];
		}
		#endregion
		static int idx = 0;
		public static int index()
		{
			return idx;
		}
		#region Cotroller
		private void btnResetTB_Click(object sender, EventArgs e)
		{
			btnAddTB.Enabled = true;
			btnDeleteTB.Enabled = false;
			btnfixTB.Enabled = false;
			txtmatb.ResetText();
			txttentb.ResetText();
			txttinhtrang.ResetText();
 			dtpNgayBH.ResetText();
			txtsolanbh.ResetText();
			cbmaPM.ResetText();
			txttimkiemTB.ResetText();
			ShowData();
		}

		private void btnAddTB_Click(object sender, EventArgs e)
		{
			idx = 1;
			bool check = true;
			string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			string Mamay = "";
			Random random = new Random();

			for (int i = 0; i < 4; i++)
			{
				Mamay += chars[random.Next(chars.Length)].ToString();
			}
			 txtmatb.Text = Mamay;
			foreach (string x in lstMaTB)
			{
				if (x.Contains(txtmatb.Text))
				{
					check = false;
					break;
				}
				check = true;
			}
			if (check == true)
			{
				ListViewItem liv = new ListViewItem(txtmatb.Text);
				liv.SubItems.Add(txttentb.Text);
				liv.SubItems.Add(txttinhtrang.Text);
 				liv.SubItems.Add(dtpNgayBH.Text);
				liv.SubItems.Add(txtsolanbh.Text);
				liv.SubItems.Add(cbmaPM.Text);
				lvThietBi.Items.Add(liv);
			}
		}
		
		private void btnfixTB_Click(object sender, EventArgs e)
		{
			idx = 2;
			if (lvThietBi.SelectedItems.Count == 0) return;
			ListViewItem liv = lvThietBi.SelectedItems[0];
			liv.SubItems[0].Text = txtmatb.Text;
			liv.SubItems[1].Text = txttentb.Text;
			liv.SubItems[2].Text = txttinhtrang.Text;
			liv.SubItems[3].Text = dtpNgayBH.Text;
			liv.SubItems[4].Text = txtsolanbh.Text;
			liv.SubItems[5].Text = cbmaPM.Text;
  		}
		List<ThietBi> lstXoa = new List<ThietBi>();
		private void btnDeleteTB_Click(object sender, EventArgs e)
		{
			idx = 3;
			for (int i = 0; i < lvThietBi.Items.Count; i++)
			{
				if (lvThietBi.Items[i].Selected)
				{
					if (lvThietBi.SelectedIndices.Count == 0) return;
					ThietBi tb = new ThietBi();
					ListViewItem liv = lvThietBi.SelectedItems[0];
					tb.MaTB = liv.SubItems[0].Text;
					tb.TenTB = liv.SubItems[1].Text;
					tb.TinhTrang = liv.SubItems[2].Text;
 
 					string[] date = liv.SubItems[3].Text.Split('-');
					DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

					tb.HanBH = dt;
					tb.solanBH = Convert.ToInt32(liv.SubItems[3].Text);
					tb.MaPM = liv.SubItems[4].Text;

					lstXoa.Add(tb);
					lvThietBi.Items[i].Remove();
					i--;
				}
			}
		}

		private void btnundoTB_Click(object sender, EventArgs e)
		{
			int a = lstXoa.Count;
			for (int i = a - 1; i >= 0; i--)
			{
				ListViewItem liv = new ListViewItem(lstXoa[i].MaTB);
				liv.SubItems.Add(lstXoa[i].TenTB);
				liv.SubItems.Add(lstXoa[i].TinhTrang);
				liv.SubItems.Add(lstXoa[i].HanBH.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(lstXoa[i].solanBH.ToString());
 				liv.SubItems.Add(lstXoa[i].MaPM);

				lvThietBi.Items.Add(liv);
				break;
			}
			if (a > 0)
			{
				lstXoa.RemoveAt(a - 1);
			}
		}
		private void btnthongkeTB_Click(object sender, EventArgs e)
		{

		}
		#endregion
 		private void lvThietBi_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAddTB.Enabled = false;
			btnDeleteTB.Enabled = true;
			btnfixTB.Enabled = true;
			if (lvThietBi.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvThietBi.SelectedItems[0];
			txtmatb.Text = liv.SubItems[0].Text;
			//	arr[0] = txtmamay.Text;
			txttentb.Text = liv.SubItems[1].Text;
			txttinhtrang.Text = liv.SubItems[2].Text;

 			string[] date = liv.SubItems[3].Text.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtpNgayBH.Value = dt;

			txtsolanbh.Text = liv.SubItems[4].Text;
			cbmaPM.Text = liv.SubItems[5].Text;
		}
		#region Undo
		public void Undo()
		{
			btnundoTB.PerformClick();
		}
		#endregion
		#region Tìm kiếm
		string TimKiem = "";
		private void cbTimKiemTB_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimKiem = cbTimKiemTB.SelectedItem.ToString();
		}
		private void btntimkiemTB_Click(object sender, EventArgs e)
		{
			string ma = txttimkiemTB.Text;

			if (TimKiem == "Mã Thiết Bị")
			{
				listTB = ThietBiBLL.SearchThietBi("MaTB", ma);
				XuatTimKiem(listTB);
			}
			if (TimKiem == "Tên Thiết Bị")
			{
				listTB = ThietBiBLL.SearchThietBi("TenTB", ma);
				XuatTimKiem(listTB);
			}
 			if (TimKiem == "Tình Trạng")
			{
				listTB = ThietBiBLL.SearchThietBi("TinhTrang", ma);
				XuatTimKiem(listTB);
			}
			if (TimKiem == "Hạn Bảo Hành")
			{
				listTB = ThietBiBLL.SearchThietBi("HanBH", ma);
				XuatTimKiem(listTB);
			}
			if (TimKiem == "Số lần bảo hành")
			{
				listTB = ThietBiBLL.SearchThietBi("SolanBH", ma);
				XuatTimKiem(listTB);
			}
			if (TimKiem == "Mã phòng máy")
			{
				listTB = ThietBiBLL.SearchThietBi("MaPM", ma);
				XuatTimKiem(listTB);
			}
		}
		public void XuatTimKiem(List<ThietBi> ListTB)
		{
			lvThietBi.Items.Clear();
			foreach (ThietBi tb in listTB)
			{
				ListViewItem liv = new ListViewItem(tb.MaTB);
				liv.SubItems.Add(tb.TenTB);
				liv.SubItems.Add(tb.TinhTrang);
				liv.SubItems.Add(tb.HanBH.ToString("dd-MM-yyyyy"));
				liv.SubItems.Add(tb.solanBH.ToString());
				liv.SubItems.Add(tb.MaPM.ToString());

				lstMaTB.Add(tb.MaTB);
				lvThietBi.Items.Add(liv);
			}
		}
		#endregion
		#region GETDATA
		public ThietBi GETTHIETBI()
		{

			string ma = txtmatb.Text;
			string ten = txttentb.Text;
 			string ttrang = txttinhtrang.Text;
			DateTime hbh = dtpNgayBH.Value;
			int slbh = int.Parse(txtsolanbh.Text);
			string mapm = cbmaPM.Text;
			ThietBi tb = new ThietBi(ma, ten,ttrang, hbh, slbh, mapm);
			return tb;
		}
		public string GETMATB() { return txtmatb.Text; }
		#endregion

	}
}
