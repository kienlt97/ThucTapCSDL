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
	public partial class frmMayTinh : UserControl
	{
		public static int key = 4;
		public frmMayTinh()
		{
			InitializeComponent();
			ShowData();
			ShowPM();
			string[] item = new string[] { "Mã Máy Tính", "Tên Máy Tính", "RAM", "Hệ Điều Hành",
			"Tình Trạng","Hạn Bảo Hành","Số lần bảo hành" ,"Mã phòng máy"};

			for (int i = 0; i < item.Count(); i++)
			{
				cbTimKiemMay.Items.Add(item[i]);
			}
			//bt.Enabled = false;
		//	btnDelete.Enabled = false;
		}
		#region ShowData
		List<MayTinh> listMT = new List<MayTinh>();
		List<string> lstMaMay = new List<string>();
		public void ShowData()
		{
			txtmamay.Enabled = false;
			listMT = MayTinhBLL.ShowMayTinh();
			lvMayTinh.Items.Clear();
			foreach (MayTinh mt in listMT)
			{
				ListViewItem liv = new ListViewItem(mt.MaMay);
				liv.SubItems.Add(mt.TenMay);
				liv.SubItems.Add(mt.RAM);
				liv.SubItems.Add(mt.HDD);
				liv.SubItems.Add(mt.TinhTrang);
				liv.SubItems.Add(mt.HanBH.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(mt.SolanBH.ToString());
				liv.SubItems.Add(mt.MaPM);

				lstMaMay.Add(mt.MaMay);
				lvMayTinh.Items.Add(liv);
			}
		}
		private void ShowPM()
		{
			List<PhongMay> listPM = PhongMayBLL.ShowPhongMay();
			cbmapm.Items.Clear();
			foreach (PhongMay pm in listPM)
			{
				string mapm = pm.MaPM;
				string tenpm = pm.TenPM;

				cbmapm.Items.Add(mapm + "-" + tenpm);
			}
		}
		string[] arrAll = new string[2];
		private void cbmapm_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			string valuePM = cbmapm.SelectedItem.ToString();
			string[] arrPM = valuePM.Split('-');
			arrAll[0] = arrPM[0];
		}
		#endregion
		static int idx = 0;
		public static int index()
		{
			return idx;
		}
		#region Controller
		private void btnAddMT_Click(object sender, EventArgs e)
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
			txtmamay.Text = Mamay;
			foreach (string x in lstMaMay)
			{
				if(x.Contains(txtmamay.Text))
				{
					check = false;
					break;
 				}
				check = true;
			}
			if(check == true)
			{
				ListViewItem liv = new ListViewItem(txtmamay.Text);
				liv.SubItems.Add(txttenmay.Text);
				liv.SubItems.Add(txtRAM.Text);
				liv.SubItems.Add(txtHDD.Text);
				liv.SubItems.Add(txttinhtrangmay.Text);
				liv.SubItems.Add(dtpNgayBHmay.Text);
				liv.SubItems.Add(txtsolanbhmay.Text);
				liv.SubItems.Add(cbmapm.Text);
				lvMayTinh.Items.Add(liv);
			}
		}
		private void btnEditMT_Click(object sender, EventArgs e)
		{
			idx = 2;
			if (lvMayTinh.SelectedItems.Count == 0) return;
			ListViewItem liv = lvMayTinh.SelectedItems[0];
			liv.SubItems[0].Text = txtmamay.Text;
			liv.SubItems[1].Text = txttenmay.Text;
			liv.SubItems[2].Text = txtRAM.Text;
			liv.SubItems[3].Text = txtHDD.Text;
			liv.SubItems[4].Text = txttinhtrangmay.Text;
			liv.SubItems[5].Text = dtpNgayBHmay.Text;
			liv.SubItems[6].Text = txtsolanbhmay.Text;
			liv.SubItems[7].Text = cbmapm.Text;
 		}
		
		List<MayTinh> lstXoa = new List<MayTinh>();
		private void btnDeleteMT_Click(object sender, EventArgs e)
		{
			idx = 3;
			for (int i = 0; i < lvMayTinh.Items.Count; i++)
			{
				if (lvMayTinh.Items[i].Selected)
				{
					if (lvMayTinh.SelectedIndices.Count == 0) return;
					MayTinh mt = new MayTinh();
					ListViewItem liv = lvMayTinh.SelectedItems[0];
					mt.MaMay = liv.SubItems[0].Text;
					mt.TenMay = liv.SubItems[1].Text;
					mt.RAM = liv.SubItems[2].Text;
					mt.HDD = liv.SubItems[3].Text;

					mt.TinhTrang = liv.SubItems[4].Text;
					string[] date = liv.SubItems[5].Text.Split('-');
					DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
 
					mt.HanBH = dt;
					mt.SolanBH = Convert.ToInt32(liv.SubItems[6].Text);
					mt.MaPM = liv.SubItems[7].Text;

 					lstXoa.Add(mt);
					lvMayTinh.Items[i].Remove();
					i--;
				}
			}
		}
		private void btnundoMT_Click(object sender, EventArgs e)
		{
			int a = lstXoa.Count;
			for (int i = a - 1; i >= 0; i--)
			{
				ListViewItem liv = new ListViewItem(lstXoa[i].MaMay);
				liv.SubItems.Add(lstXoa[i].TenMay);
				liv.SubItems.Add(lstXoa[i].RAM);
				liv.SubItems.Add(lstXoa[i].HDD);
				liv.SubItems.Add(lstXoa[i].TinhTrang);
				liv.SubItems.Add(lstXoa[i].HanBH.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(lstXoa[i].SolanBH.ToString());
 				liv.SubItems.Add(lstXoa[i].MaPM);

				lvMayTinh.Items.Add(liv);
				break;
			}
			if (a > 0)
			{
				lstXoa.RemoveAt(a - 1);
			}
		}
		private void btnResetMT_Click(object sender, EventArgs e)
		{
			btnAddMT.Enabled = true;
			btnEditMT.Enabled = false;
			btnDeleteMT.Enabled = false;
			txtmamay.ResetText();
			txttenmay.ResetText();
			txtRAM.ResetText();
			txtHDD.ResetText();
			txttinhtrangmay.ResetText();
			dtpNgayBHmay.ResetText();
			txtsolanbhmay.ResetText();
			cbmapm.ResetText();
			txttimkiemMay.ResetText();
			ShowData();
		}
		
		#endregion
		private void lvMayTinh_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAddMT.Enabled = false;
			btnDeleteMT.Enabled = true;
			btnEditMT.Enabled = true;
			if (lvMayTinh.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvMayTinh.SelectedItems[0];
			txtmamay.Text = liv.SubItems[0].Text;
			//	arr[0] = txtmamay.Text;
			txttenmay.Text = liv.SubItems[1].Text;
			txtRAM.Text = liv.SubItems[2].Text;
			txtHDD.Text = liv.SubItems[3].Text;
			txttinhtrangmay.Text = liv.SubItems[4].Text;
			string[] date = liv.SubItems[5].Text.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtpNgayBHmay.Value = dt;
			txtsolanbhmay.Text = liv.SubItems[6].Text;
			cbmapm.Text = liv.SubItems[7].Text;
 		}
		#region Undo
		public void Undo()
		{
			btnundoMT.PerformClick();
		}
		#endregion
		#region Tìm Kiếm
		string TimKiem = "";
		private void cbTimKiemMay_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimKiem = cbTimKiemMay.SelectedItem.ToString();
		}
		 
		private void btntimkiemTB_Click(object sender, EventArgs e)
		{
			string ma = txttimkiemMay.Text;

			if (TimKiem == "Mã Máy Tính")
			{
				listMT = MayTinhBLL.SearchMayTinh("MaMay", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "Tên Máy Tính")
			{
				listMT = MayTinhBLL.SearchMayTinh("TenMay", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "RAM")
			{
				listMT = MayTinhBLL.SearchMayTinh("Ram", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "Hệ Điều Hành")
			{
				listMT = MayTinhBLL.SearchMayTinh("HDD", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "Tình Trạng")
			{
				listMT = MayTinhBLL.SearchMayTinh("TinhTrang", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "Hạn Bảo Hành")
			{
				listMT = MayTinhBLL.SearchMayTinh("HanBH", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "Số lần bảo hành")
			{
				listMT = MayTinhBLL.SearchMayTinh("SolanBH", ma);
				XuatTimKiem(listMT);
			}
			if (TimKiem == "Mã phòng máy")
			{
				listMT = MayTinhBLL.SearchMayTinh("MaPM", ma);
				XuatTimKiem(listMT);
			}
		}
		public void XuatTimKiem(List<MayTinh> ListMT)
		{
			lvMayTinh.Items.Clear();
			foreach (MayTinh mt in ListMT)
			{
				ListViewItem liv = new ListViewItem(mt.MaMay);
				liv.SubItems.Add(mt.TenMay);
				liv.SubItems.Add(mt.RAM);
				liv.SubItems.Add(mt.HDD);
				liv.SubItems.Add(mt.TinhTrang);
				liv.SubItems.Add(mt.HanBH.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(mt.SolanBH.ToString());
				liv.SubItems.Add(mt.MaPM);

 				lvMayTinh.Items.Add(liv);
			}
		}
		#endregion
		#region GETDATA
		public MayTinh GETMAYTINH()
		{
			
			string ma = txtmamay.Text;
			string ten = txttenmay.Text;
			string ram = txtRAM.Text;
			string hdd = txtHDD.Text;
			string ttrang = txttinhtrangmay.Text;
			DateTime hbh = dtpNgayBHmay.Value;
			int slbh = int.Parse(txtsolanbhmay.Text);
			string mapm = cbmapm.Text;
			MayTinh mt = new MayTinh(ma, ten, ram,hdd,ttrang,hbh,slbh,mapm);
			return mt;
		}
		public string GETMAMAY() { return txtmamay.Text; }
		#endregion
  	}
}
