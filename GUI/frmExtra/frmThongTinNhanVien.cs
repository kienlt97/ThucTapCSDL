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
	public partial class frmThongTinNhanVien : Form
	{
		public frmThongTinNhanVien()
		{
			InitializeComponent();
			ShowData();
			lvSV.CheckBoxes = true;
 		}
		List<NhanVien> listNV = new List<NhanVien>();
		NhanVienBLL svbll = new NhanVienBLL();
 		public void ShowData()
		{
 			listNV = svbll.ShowNhanVien();
			lvSV.Items.Clear();
			foreach (NhanVien nv in listNV)
			{
				ListViewItem liv = new ListViewItem();
				liv.SubItems.Add(nv.MaNV);
				liv.SubItems.Add(nv.TenNV);
				liv.SubItems.Add(nv.GioiTinh.ToString());
				liv.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyyy"));
				liv.SubItems.Add(nv.Luong.ToString());
				liv.SubItems.Add(nv.HeSoLuong.ToString());
				liv.SubItems.Add(nv.ChucVu);
 
				lvSV.Items.Add(liv);
			}
		}
		public delegate void GETDATA(string data);
		public GETDATA mydata;
  		private void lvSV_ItemCheck(object sender, ItemCheckEventArgs e)
		{
				if (lvSV.SelectedIndices.Count == 0) return;
				ListViewItem liv = lvSV.SelectedItems[0];
				string manva = liv.SubItems[1].Text;
				mydata(manva);
 		}
 
	}
}
