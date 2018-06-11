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
	public partial class frmThongTinMayTinh : Form
	{
		public frmThongTinMayTinh()
		{
			InitializeComponent();
			ShowData();
			lvMayTinh.CheckBoxes = true;
		}
		#region ShowData
		List<MayTinh> listMT = new List<MayTinh>();
 		public void ShowData()
		{
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

 				lvMayTinh.Items.Add(liv);
			}
		}
		#endregion
		public delegate void GETDATA(string data);
		public GETDATA mydata;
		string lstma = "";
 		private void lvMayTinh_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (lvMayTinh.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvMayTinh.SelectedItems[0];
			string mamay = liv.SubItems[0].Text;
			lstma +=  mamay + ",";
 			mydata(lstma);
 		}
 	}
}
