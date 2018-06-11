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
	
	public partial class frmLichTruc : UserControl 
	{
		int quyen = 0;
		public static string user = string.Empty;
		public frmLichTruc()
		{
			InitializeComponent();
 			ShowPM();
			ShowData();
			txtmalt.ReadOnly =true;
 			btnDelete.Enabled = false;
			btnfix.Enabled = false;
		}
  		NhanVienBLL svbll = new NhanVienBLL();
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

		private void cbmapm_SelectedIndexChanged(object sender, EventArgs e)
		{
			string valuePM = cbmapm.SelectedItem.ToString();
			string[] arrPM = valuePM.Split('-');
			arrAll[0] = arrPM[0];
 		}
 		 
		public void GETVALUE(string value)
		{
			txtMaNV.Text = value;
		}
		string ca = "";
		string dttruc=" ";
  		#region Database
 	//	strinsg TimKiem = null;
		List<LichTruc> listLT = new List<LichTruc>();
		List<string> lstMaLT = new List<string>();
		public void ShowData()
		{
			listLT = LichTrucBLL.ShowLichTruc();
			lvLichTruc.Items.Clear();
			foreach (LichTruc lt in listLT)
			{

				string malt = lt.MaLT;
				ListViewItem liv = new ListViewItem(lt.MaLT);
				liv.SubItems.Add(lt.MaPM);
				liv.SubItems.Add(lt.MaNV);
 				liv.SubItems.Add(lt.NgayTruc.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(lt.CaTruc);
				if(lt.TangCa ==1)
				liv.SubItems.Add("X");
				if (lt.TangCa == 0)
				liv.SubItems.Add("O");

				lstMaLT.Add(malt);
   				lvLichTruc.Items.Add(liv);
			}
 		}			
		#endregion
		private void lvLichTruc_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnAdd.Enabled = false;
			btnDelete.Enabled = true;
			btnfix.Enabled = true;
			if (lvLichTruc.SelectedIndices.Count == 0) return;
			ListViewItem liv = lvLichTruc.SelectedItems[0];
			txtmalt.Text = liv.SubItems[0].Text;
			cbmapm.Text = liv.SubItems[1].Text;
			txtMaNV.Text = liv.SubItems[2].Text;

			string[] date = liv.SubItems[3].Text.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
			dtngaytruc.Value = dt;

			string catruc = liv.SubItems[4].Text;
			if (catruc == "Chiều")
				rdchieu.Checked = true;
			if (catruc == "Sáng")
				 rdsang.Checked = true;
			if (catruc == "Tối")
				rdtoi.Checked = true;

  			string tangca = liv.SubItems[5].Text;
			if (tangca == "X")
				ckbtangca.Checked = true;
			if (tangca == "O")
				ckbtangca.Checked = false;
		}
		bool check;
		static int idx = 0;
		public static int index() { return idx; }
		
		#region Controller
		private void button1_Click(object sender, EventArgs e)
		{
			idx = 1;
			dttruc = dtngaytruc.Value.ToString("dd-MM-yyyy");
			string[] date = dttruc.Split('-');
			DateTime dt = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

			if (rdchieu.Checked == true)
			{
				ca = "Chiều";
			}
			if (rdsang.Checked == true)
			{
				ca = "Sáng";
			}
			if (rdtoi.Checked == true)
			{
				ca = "Tối";
			}
			check = LichTrucBLL.KiemTraNgayTruc(ca, dt);

			if (check == false)
			{
				MessageBox.Show("Đã tồn tại");
			}
			if (check == true)
			{
 				bool idx = true;
				Random rd = new Random();
				txtmalt.Enabled = true;
				int x = rd.Next(0, 20);
				if (x < 10)
					txtmalt.Text = "LT0" + x.ToString();
				if (x > 10)
					txtmalt.Text = "LT" + x.ToString();
				foreach (string str in lstMaLT)
				{
					if (str.Contains(txtmalt.Text))
					{
						idx = false;
						break;
					}
					idx = true;
				}
				if (idx == true)
				{
					ListViewItem liv = new ListViewItem(txtmalt.Text);
					liv.SubItems.Add(arrAll[0]);
					liv.SubItems.Add(txtMaNV.Text);
					liv.SubItems.Add(dttruc);
					liv.SubItems.Add(ca);
					if (ckbtangca.Checked == true)
					{
						liv.SubItems.Add("X");
					}
					else if (ckbtangca.Checked == false)
					{
						liv.SubItems.Add("O");
					}
 					lvLichTruc.Items.Add(liv);
				}
			}
		}
		private void button4_Click(object sender, EventArgs e)
		{
			frmThongTinNhanVien frmthongtin = new frmThongTinNhanVien();
			frmthongtin.mydata = new frmThongTinNhanVien.GETDATA(GETVALUE);
			DialogResult dr = frmthongtin.ShowDialog();
			if (dr == DialogResult.Cancel)
			{
				frmthongtin.Close();
			}
		}
		private void btnfix_Click(object sender, EventArgs e)
		{
			idx = 2;
			if (lvLichTruc.SelectedItems.Count == 0) return;
			ListViewItem liv = lvLichTruc.SelectedItems[0];
			liv.SubItems[0].Text = txtmalt.Text;
			liv.SubItems[1].Text = cbmapm.Text;
			liv.SubItems[2].Text = txtMaNV.Text;
			liv.SubItems[3].Text = dtngaytruc.Text;
			if (rdsang.Checked)
				liv.SubItems[4].Text = "Sáng";
			if (rdchieu.Checked)
				liv.SubItems[4].Text = "Chiều";
			if (rdtoi.Checked)
				liv.SubItems[4].Text = "Tối";
			if (ckbtangca.Checked)
				liv.SubItems[5].Text = "X";
			if (!ckbtangca.Checked)
				liv.SubItems[5].Text = "O";
		}
		List<LichTruc> lstXoa = new List<LichTruc>();
		private void btnDelete_Click(object sender, EventArgs e)
		{
			idx = 3;
			for (int i = 0; i < lvLichTruc.Items.Count; i++)
			{
				if (lvLichTruc.Items[i].Selected)
				{
					if (lvLichTruc.SelectedIndices.Count == 0) return;
					LichTruc lt = new LichTruc();
					ListViewItem liv = lvLichTruc.SelectedItems[0];
					lt.MaLT = liv.SubItems[0].Text;
					lt.MaPM = liv.SubItems[1].Text;
					lt.MaNV = liv.SubItems[2].Text;
					lt.NgayTruc = Convert.ToDateTime(liv.SubItems[3].Text);
					lt.CaTruc = liv.SubItems[4].Text;
					string tangca = liv.SubItems[5].Text;
					if (tangca == "X")
						lt.TangCa = 1;
					if (tangca == "O")
						lt.TangCa = 0;

					lstXoa.Add(lt);

					lvLichTruc.Items[i].Remove();
					i--;
				}
			}
		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			txtmalt.ResetText();
			cbmapm.ResetText();
			txtMaNV.ResetText();
			dtngaytruc.ResetText();
			rdchieu.Checked = false;
			rdsang.Checked = false;
			rdtoi.Checked = false;
			ckbtangca.Checked = false;

			btnAdd.Enabled = true;
			btnthongke.Enabled = true;
			btnfix.Enabled = false;
			btnDelete.Enabled = false;
			ShowData();
		}
		private void btnundo_Click(object sender, EventArgs e)
		{
			LichTruc nv = new LichTruc();
			int a = lstXoa.Count;
			for (int i = a - 1; i >= 0; i--)
			{
				ListViewItem liv = new ListViewItem(lstXoa[i].MaLT);
				liv.SubItems.Add(lstXoa[i].MaPM);
				liv.SubItems.Add(lstXoa[i].MaNV);
				liv.SubItems.Add(lstXoa[i].NgayTruc.ToString("dd-MM-yyyy"));
				liv.SubItems.Add(lstXoa[i].CaTruc);
				liv.SubItems.Add(lstXoa[i].TangCa.ToString());
 
				lvLichTruc.Items.Add(liv);
				break;
			}
			if (a > 0)
			{
				lstXoa.RemoveAt(a - 1);
			}
		}
		private void btnthongke_Click(object sender, EventArgs e)
		{

		}

  		#endregion
		#region GETDATA
		public LichTruc GETLICHTRUC()
		{

			string malt = txtmalt.Text;
			string mapm = arrAll[0];
			string manv = txtMaNV.Text;
			DateTime hbh = dtngaytruc.Value;
 			string catruc ="";
			if (rdchieu.Checked)
				catruc = "Chiều";
			if (rdsang.Checked)
				catruc = "Sáng";
			if (rdtoi.Checked)
				catruc = "Tối";

			//tăng ca
			int tangca = 0;
			if (ckbtangca.Checked)
				 tangca = 1;
			if (!ckbtangca.Checked)
				 tangca = 0;
			LichTruc lt = new LichTruc(malt, mapm, manv, hbh, catruc, tangca);
			return lt;
		}
		public string GETMALT() { return txtmalt.Text; }
		#endregion
		#region Undo
		public void Undo()
		{
			btnundo.PerformClick();
		}
		#endregion

		private void frmLichTruc_Load(object sender, EventArgs e)
		{
			quyen = NhanVienBLL.PhanQuyen(user);
			if (quyen == 0)
			{
				ShowData();
				this.splitContainer1.Panel2.Visible = false;
				lvLichTruc.Enabled = false;
			}
			else if (quyen == 1)
			{
				ShowData();
				this.splitContainer1.Panel2.Visible = true;
			}
		}
	}
}
