using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI.frmExtra
{
	public partial class frmThongTinTB : Form
	{
		public frmThongTinTB()
		{
			InitializeComponent();
			ShowData();
			lvThietBi.CheckBoxes = true;
		}
		List<ThietBi> listTB = new List<ThietBi>();
 		public void ShowData()
		{
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

 				lvThietBi.Items.Add(liv);
			}
		}
		public delegate void GETDATA(string data);
		public GETDATA mydata;
 
 		private void lvThietBi_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (lvThietBi.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvThietBi.SelectedItems[0];
			string matb = liv.SubItems[1].Text;
			mydata(matb);
		}
	}
}
