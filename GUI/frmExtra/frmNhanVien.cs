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
namespace GUI
{
	public partial class frmNhanVien : UserControl
	{
 
  		public static int Key = 0;
		int quyen = 0;
		public static string taikhoan = string.Empty;
		public frmNhanVien()
		{
			InitializeComponent();
 			txtmanv.ReadOnly = true;
			string[] item = new string[] { "Mã Nhân Viên", "Tên Nhân Viên", "Giới Tính", "Ngày Sinh",
			"Lương","Hệ Số Lương","Chức Vụ"};
			 
			for(int i = 0;i < item.Count();i++)
			{
				cbTimKiem.Items.Add(item[i]);
			}
			btnfix.Enabled = false;
			btnDelete.Enabled = false;
  		 }
		private void frmNhanVien_Load(object sender, EventArgs e)
		{
 			quyen = NhanVienBLL.PhanQuyen(taikhoan);
			if (quyen == 0)
			{
				ShowDataNV();
				this.splitContainer1.Panel2.Visible = false;
				lvSinhVien.Enabled = false;
			}
			else if(quyen ==1)
			{
				ShowData();
				this.splitContainer1.Panel2.Visible = true;
			}
		}
		#region ShowData
		string TimKiem = null;
		List<NhanVien> listNV = new List<NhanVien>();
		NhanVienBLL svbll = new NhanVienBLL();
		List<string> lstManv = new List<string>();
		public void ShowData()
		{
			txtmanv.Enabled = false;
			listNV = svbll.ShowNhanVien();
			lvSinhVien.Items.Clear();
			foreach (NhanVien nv in listNV)
			{
				ListViewItem liv = new ListViewItem(nv.MaNV);
				liv.SubItems.Add(nv.TenNV);
				liv.SubItems.Add(nv.GioiTinh.ToString());
				liv.SubItems.Add(nv.NgaySinh.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(nv.Luong.ToString());
				liv.SubItems.Add(nv.HeSoLuong.ToString());
				liv.SubItems.Add(nv.ChucVu);
				lstManv.Add(nv.MaNV);

				lvSinhVien.Items.Add(liv);
			}
		}
		public void ShowDataNV()
		{
			txtmanv.Enabled = false;
			listNV = svbll.ShowNhanVien();
			lvSinhVien.Items.Clear();
			foreach (NhanVien nv in listNV)
			{
				ListViewItem liv = new ListViewItem(nv.MaNV);
				liv.SubItems.Add(nv.TenNV);
				liv.SubItems.Add(nv.GioiTinh.ToString());
				liv.SubItems.Add(nv.NgaySinh.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(nv.ChucVu);
				lstManv.Add(nv.MaNV);

				lvSinhVien.Items.Add(liv);
			}
		}
		public void ThongKe()
		{
 			List<PhongMay> listPM = PhongMayBLL.ShowPhongMay();
			List<LichTruc> listLT = LichTrucBLL.ShowLichTruc();
			lvSinhVien.Groups.Clear();
			lvSinhVien.Items.Clear();
			foreach (PhongMay pm in listPM)
			{
				ListViewGroup lvgpm = new ListViewGroup(pm.TenPM);
				lvgpm.Tag = pm.MaPM;
				lvSinhVien.Groups.Add(lvgpm);
			}

			foreach (ListViewGroup lvg in lvSinhVien.Groups)
			{
				string mapm = lvg.Tag.ToString();

				List<NhanVien> listTK = new List<NhanVien>();
				listTK = NhanVienBLL.ThongKeNV(mapm);
				foreach (NhanVien nv in listTK)
				{
					ListViewItem liv = new ListViewItem(nv.MaNV);
					liv.SubItems.Add(nv.TenNV);
					liv.SubItems.Add(nv.GioiTinh.ToString());
					liv.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
					liv.SubItems.Add(nv.Luong.ToString());
					liv.SubItems.Add(nv.HeSoLuong.ToString());
					liv.SubItems.Add(nv.ChucVu);
					lstManv.Add(nv.MaNV);

					lvSinhVien.Items.Add(liv);
					liv.Group = lvg;
				}
			}
		}

		string[] arr = new string[2];
		List<string> Chuoicon = new List<string>();
		public void Catchuoi()
		{
			foreach (string str in lstManv)
			{
				Chuoicon.Add(str.Substring(4));
			}
		}
		#endregion

		string[] date = new string[3];
		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = false;
			btnDelete.Enabled = true;
			btnfix.Enabled = true;
			if (lvSinhVien.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvSinhVien.SelectedItems[0];
			txtmanv.Text = liv.SubItems[0].Text;
			arr[0] = txtmanv.Text;
			txttennv.Text = liv.SubItems[1].Text;
			txtgioitinh.Text = liv.SubItems[2].Text;

			string []date = liv.SubItems[3].Text.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtpNgaySinh.Value = dt;


			txtluong.Text = liv.SubItems[4].Text;
			txthesoluong.Text = liv.SubItems[5].Text;
			txtchucvu.Text = liv.SubItems[6].Text;
 		}
		static int idx = 0;
		public static int index() { return idx; }
		#region Controller
		int a;
		private void btnundo_Click(object sender, EventArgs e)
		{
 			a = lstXoa.Count;
			for (int i = a - 1; i >= 0; i--)
			{
				ListViewItem liv = new ListViewItem(lstXoa[i].MaNV);
				liv.SubItems.Add(lstXoa[i].TenNV);
				liv.SubItems.Add(lstXoa[i].GioiTinh.ToString());
				liv.SubItems.Add(lstXoa[i].NgaySinh.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(lstXoa[i].Luong.ToString());
				liv.SubItems.Add(lstXoa[i].HeSoLuong.ToString());
				liv.SubItems.Add(lstXoa[i].ChucVu);

				lvSinhVien.Items.Add(liv);
				break;
			}
			if (a > 0)
			{
				lstXoa.RemoveAt(a - 1);
			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			idx = 2;
			 
			//	this.splitContainer1.Panel2.Visible = true;
				bool check = true;
				Random rd = new Random();
				txtmanv.Enabled = true;
				int x = rd.Next(1000, 9999);
				foreach (string str in Chuoicon)
				{
					if (int.Parse(str) == x)
					{
						check = false;
					}
					check = true;
				}
				if (check == true)
				{
					txtmanv.Text = "1515" + x.ToString();
				}
				ListViewItem liv = new ListViewItem(txtmanv.Text);
				liv.SubItems.Add(txttennv.Text);
				liv.SubItems.Add(txtgioitinh.Text);
				liv.SubItems.Add(dtpNgaySinh.Text);
				liv.SubItems.Add(txtluong.Text);
				liv.SubItems.Add(txthesoluong.Text);
				liv.SubItems.Add(txtchucvu.Text);
				lvSinhVien.Items.Add(liv);
 		}

		private void btnfix_Click(object sender, EventArgs e)
		{
			idx = 1;
			if (lvSinhVien.SelectedItems.Count == 0) return;
			ListViewItem liv = lvSinhVien.SelectedItems[0];
			liv.SubItems[0].Text = txtmanv.Text;
			liv.SubItems[1].Text = txttennv.Text;
			liv.SubItems[2].Text = txtgioitinh.Text;
			liv.SubItems[3].Text = dtpNgaySinh.Text;
			liv.SubItems[4].Text = txtluong.Text;
			liv.SubItems[5].Text = txthesoluong.Text;
			liv.SubItems[6].Text = txtchucvu.Text;

		}
		List<NhanVien> lstXoa = new List<NhanVien>();
		 
		private void btnDelete_Click(object sender, EventArgs e)
		{
			idx = 3;
			for (int i = 0; i < lvSinhVien.Items.Count; i++)
			{
				if (lvSinhVien.Items[i].Selected)
				{
					if (lvSinhVien.SelectedIndices.Count == 0) return;
					NhanVien nv = new NhanVien();
					ListViewItem liv = lvSinhVien.SelectedItems[0];
					nv.MaNV = liv.SubItems[0].Text;
					nv.TenNV = liv.SubItems[1].Text;
					nv.GioiTinh = liv.SubItems[2].Text;

					string[] date = liv.SubItems[3].Text.Split('-');
					DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
					dtpNgaySinh.Value = dt;

					nv.NgaySinh = dt;
					nv.Luong = Convert.ToDouble(liv.SubItems[4].Text);
					nv.HeSoLuong = Convert.ToDouble(liv.SubItems[5].Text);
					nv.ChucVu = liv.SubItems[6].Text;
					lstXoa.Add(nv);

					lvSinhVien.Items[i].Remove();
					i--;
 				}
			}
		}
		private void btnthongke_Click(object sender, EventArgs e)
		{
			
			ThongKe();
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			btnAdd.Enabled = true;
			btnfix.Enabled = false;
			btnDelete.Enabled = false;
			txtmanv.ResetText();
			txttennv.ResetText();
			txtgioitinh.ResetText();
			txtluong.ResetText();
			txthesoluong.ResetText();
			txtchucvu.ResetText();
			cbTimKiem.ResetText();
			dtpNgaySinh.ResetText();
			ShowData();

		}
		#endregion
		#region GETDATA
		public NhanVien GETNHANVIEN()
		{
			string ma = txtmanv.Text;
			string ten = txttennv.Text;
			string gt = txtgioitinh.Text;
			DateTime ns = dtpNgaySinh.Value;
			double luong = double.Parse(txtluong.Text);
			double hsl = double.Parse(txthesoluong.Text);
			string chucvu = txtchucvu.Text;
			NhanVien nv = new NhanVien(ma, ten, gt, ns, luong, hsl, chucvu);
			return nv;
		}
 		public string GETMANV() { return txtmanv.Text; }
		#endregion
		public void Undo()
		{
			btnundo.PerformClick();
		}
		#region Tìm Kiếm
		private void cbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimKiem = cbTimKiem.SelectedItem.ToString();
		}
		public void XuatTimKiem(List<NhanVien> ListNV)
		{
			lvSinhVien.Items.Clear();
			foreach (NhanVien nv in listNV)
			{
				ListViewItem liv = new ListViewItem(nv.MaNV);
				liv.SubItems.Add(nv.TenNV);
				liv.SubItems.Add(nv.GioiTinh.ToString());
				liv.SubItems.Add(nv.NgaySinh.ToString());
				liv.SubItems.Add(nv.Luong.ToString());
				liv.SubItems.Add(nv.HeSoLuong.ToString());
				liv.SubItems.Add(nv.ChucVu);
				lstManv.Add(nv.MaNV);

				lvSinhVien.Items.Add(liv);
			}
		}
		private void btntimkiem_Click(object sender, EventArgs e)
		{
			string ma = txttimkiem.Text;

			if (TimKiem == "Mã Nhân Viên")
			{
				listNV = NhanVienBLL.SearchNhanVien("MaNV", ma);
				XuatTimKiem(listNV);
			}
			if (TimKiem == "Tên Nhân Viên")
			{
 				listNV = NhanVienBLL.SearchNhanVien("TenNV", ma);
				XuatTimKiem(listNV);
			}
			if (TimKiem == "Giới Tính")
			{
 				listNV = NhanVienBLL.SearchNhanVien("GioiTinh", ma);
				XuatTimKiem(listNV);
			}
			if (TimKiem == "Ngày Sinh")
			{
 				listNV = NhanVienBLL.SearchNhanVien("NgaySinh", ma);
				XuatTimKiem(listNV);
			}
			if (TimKiem == "Lương")
			{
 				listNV = NhanVienBLL.SearchNhanVien("Luong", ma);
				XuatTimKiem(listNV);
			}
			if (TimKiem == "Hệ Số Lương")
			{
 				listNV = NhanVienBLL.SearchNhanVien("HeSoLuong", ma);
				XuatTimKiem(listNV);
			}
			if (TimKiem == "Chức Vụ")
			{
 				listNV = NhanVienBLL.SearchNhanVien("ChucVu", ma);
				XuatTimKiem(listNV);
			}
		}

		#endregion

	}
}
