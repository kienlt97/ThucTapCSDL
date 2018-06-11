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
using GUI.frmExtra;
namespace GUI
{
	public partial class FormMain : Form
	{
		public static string manv = string.Empty;
		public FormMain()
		{
			InitializeComponent();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			string name = NhanVienBLL.LayTen(manv);
			lblTen.Text = name;
		}

		private void btnthoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		int n;
		Panel pnlNV = new Panel();
		Panel pnlQL = new Panel();
		Panel pnlDK = new Panel();
		Panel pnlLopHoc = new Panel();
		Panel pnlDN = new Panel();
		#region DrawPanel
		public void drawMenu()
		{
			btnThongTinNV.ForeColor = Color.Black;
			btnQuanLy.ForeColor = Color.Black;
			btnDangKiTH.ForeColor = Color.Black;
			btnthongtinLop.ForeColor = Color.Black;
			btnDangNhap.ForeColor = Color.Black;

			pnlNV.Hide();
			pnlQL.Hide();
			pnlDK.Hide();
			pnlLopHoc.Hide();
			pnlDN.Hide();

			btnThongTinNV.Location = new Point(36, 149);
			btnQuanLy.Location = new Point(36, 204);
			btnDangKiTH.Location = new Point(36, 259);
			btnthongtinLop.Location = new Point(36, 313);
			btnDangNhap.Location = new Point(36, 368);

			btnThongTinNV.Size = new Size(170, 49);
			btnQuanLy.Size = new Size(170, 49);
			btnDangKiTH.Size = new Size(170, 49);
			btnthongtinLop.Size = new Size(170, 49);
			btnDangNhap.Size = new Size(170, 49);

		}
		public void drawPanelNV()
		{
			
			pnlNV.Size = new Size(171, 130);
			pnlNV.Location = new Point(36, 200);
			pnlNV.BackColor = Color.Transparent; 
			this.Controls.Add(pnlNV);

			Button btnNV = new Button();
			btnNV.Text = "Nhân Viên";
			btnNV.Location = new Point(13, 6);
			btnNV.Size = new Size(137, 37);
			btnNV.BackColor = Color.Transparent;
			btnNV.BackgroundImage = Properties.Resources.b1;
			btnNV.BackgroundImageLayout = ImageLayout.Stretch;
			btnNV.FlatAppearance.BorderSize = 0;
			btnNV.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnNV.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnNV.FlatStyle = FlatStyle.Flat;
			btnNV.MouseMove += BtnNV_MouseMove;
			btnNV.MouseLeave += BtnNV_MouseLeave;
			btnNV.Click += BtnNV_Click;
			pnlNV.Controls.Add(btnNV);

			Button btnGV = new Button();
			btnGV.Text = "Giáo Viên";
			btnGV.Location = new Point(13, 49);
			btnGV.Size = new Size(137, 37);
			btnGV.BackColor = Color.Transparent;
			btnGV.BackgroundImage = Properties.Resources.b1;
			btnGV.FlatStyle = FlatStyle.Flat;
			btnGV.BackgroundImageLayout = ImageLayout.Stretch;
			btnGV.FlatAppearance.BorderSize = 0;
			btnGV.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnGV.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnGV.MouseMove += BtnGV_MouseMove;
			btnGV.MouseLeave += BtnGV_MouseLeave;
			pnlNV.Controls.Add(btnGV);

			Button btnLuong = new Button();
			btnLuong.Text = "Thông Tin Cá Nhân";
			btnLuong.Location = new Point(13, 92);
			btnLuong.Size = new Size(137, 37);
			btnLuong.BackColor = Color.Transparent;
			btnLuong.BackgroundImage = Properties.Resources.b1;
			btnLuong.FlatStyle = FlatStyle.Flat;
			btnLuong.BackgroundImageLayout = ImageLayout.Stretch;
			btnLuong.FlatAppearance.BorderSize = 0;
			btnLuong.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnLuong.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnLuong.MouseMove += BtnLuong_MouseMove;
			btnLuong.MouseLeave += BtnLuong_MouseLeave;
			btnLuong.Click += BtnLuong_Click;
			pnlNV.Controls.Add(btnLuong);
		}

		
		public void drawPanelQL()
		{
				
				pnlQL.Size = new Size(175, 171);
				pnlQL.Location = new Point(36, 259);
				pnlQL.BackColor = Color.Transparent;
				this.Controls.Add(pnlQL);

				Button btnTbi = new Button();
				btnTbi.Text = "Thông Tin Thiết Bị";
				btnTbi.Location = new Point(21, 2);
				btnTbi.Size = new Size(137, 37);
				btnTbi.BackColor = Color.Transparent;
				btnTbi.BackgroundImage = Properties.Resources.b1;
				btnTbi.BackgroundImageLayout = ImageLayout.Stretch;
				btnTbi.FlatAppearance.BorderSize = 0;
				btnTbi.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btnTbi.FlatAppearance.MouseOverBackColor = Color.Transparent;
				btnTbi.FlatStyle = FlatStyle.Flat;
				btnTbi.MouseLeave += BtnTbi_MouseLeave;
				btnTbi.MouseMove += BtnTbi_MouseMove;
				btnTbi.Click += BtnTbi_Click;
				pnlQL.Controls.Add(btnTbi);

				Button btnPhieuTbi = new Button();
				btnPhieuTbi.Text = "Phiếu Sửa Thiết Bị";
				btnPhieuTbi.Location = new Point(21, 47);
				btnPhieuTbi.Size = new Size(137, 37);
				btnPhieuTbi.BackColor = Color.Transparent;
				btnPhieuTbi.BackgroundImage = Properties.Resources.b1;
				btnPhieuTbi.BackgroundImageLayout = ImageLayout.Stretch;
				btnPhieuTbi.FlatAppearance.BorderSize = 0;
				btnPhieuTbi.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btnPhieuTbi.FlatAppearance.MouseOverBackColor = Color.Transparent;
				btnPhieuTbi.FlatStyle = FlatStyle.Flat;
				btnPhieuTbi.MouseMove += BtnPhieuTbi_MouseMove;
				btnPhieuTbi.MouseLeave += BtnPhieuTbi_MouseLeave;
				btnPhieuTbi.Click += BtnPhieuTbi_Click;
				pnlQL.Controls.Add(btnPhieuTbi);

				Button btnMayTinh = new Button();
				btnMayTinh.Text = "Thông Tin Máy Tính";
				btnMayTinh.Location = new Point(21, 90);
				btnMayTinh.Size = new Size(137, 37);
				btnMayTinh.BackColor = Color.Transparent;
				btnMayTinh.BackgroundImage = Properties.Resources.b1;
				btnMayTinh.BackgroundImageLayout = ImageLayout.Stretch;
				btnMayTinh.FlatAppearance.BorderSize = 0;
				btnMayTinh.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btnMayTinh.FlatAppearance.MouseOverBackColor = Color.Transparent;
				btnMayTinh.FlatStyle = FlatStyle.Flat;
				btnMayTinh.MouseLeave += BtnMayTinh_MouseLeave;
				btnMayTinh.MouseMove += BtnMayTinh_MouseMove;
				btnMayTinh.Click += BtnMayTinh_Click;
				pnlQL.Controls.Add(btnMayTinh);

				Button btnPhieuMT = new Button();
				btnPhieuMT.Text = "Phiếu Sửa Máy Tính";
				btnPhieuMT.Location = new Point(21, 133);
				btnPhieuMT.Size = new Size(137, 37);
				btnPhieuMT.BackColor = Color.Transparent;
				btnPhieuMT.BackgroundImage = Properties.Resources.b1;
				btnPhieuMT.BackgroundImageLayout = ImageLayout.Stretch;
				btnPhieuMT.FlatAppearance.BorderSize = 0;
				btnPhieuMT.FlatAppearance.MouseDownBackColor = Color.Transparent;
				btnPhieuMT.FlatAppearance.MouseOverBackColor = Color.Transparent;
				btnPhieuMT.FlatStyle = FlatStyle.Flat;
				btnPhieuMT.MouseMove += BtnPhieuMT_MouseMove;
				btnPhieuMT.MouseLeave += BtnPhieuMT_MouseLeave;
				btnPhieuMT.Click += BtnPhieuMT_Click;
				pnlQL.Controls.Add(btnPhieuMT);
		}

		
		public void drawPanelDangKi()
		{
			
			pnlDK.Size = new Size(171, 178);
			pnlDK.Location = new Point(29, 314);
			pnlDK.BackColor = Color.Transparent;
			this.Controls.Add(pnlDK);

			Button btnLichTruc = new Button();
			btnLichTruc.Text = "Lịch Trực";
			btnLichTruc.Location = new Point(21, 4);
			btnLichTruc.Size = new Size(137, 37);
			btnLichTruc.BackColor = Color.Transparent;
			btnLichTruc.BackgroundImage = Properties.Resources.b1;
			btnLichTruc.BackgroundImageLayout = ImageLayout.Stretch;
			btnLichTruc.FlatAppearance.BorderSize = 0;
			btnLichTruc.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnLichTruc.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnLichTruc.FlatStyle = FlatStyle.Flat;
			btnLichTruc.MouseLeave += BtnLichTruc_MouseLeave;
			btnLichTruc.MouseMove += BtnLichTruc_MouseMove;
			btnLichTruc.Click += BtnLichTruc_Click;
			pnlDK.Controls.Add(btnLichTruc);

			Button btnPhieuTbi = new Button();
			btnPhieuTbi.Text = "Phiếu Đăng Kí";
			btnPhieuTbi.Location = new Point(21, 49);
			btnPhieuTbi.Size = new Size(137, 37);
			btnPhieuTbi.BackColor = Color.Transparent;
			btnPhieuTbi.BackgroundImage = Properties.Resources.b1;
			btnPhieuTbi.BackgroundImageLayout = ImageLayout.Stretch;
			btnPhieuTbi.FlatAppearance.BorderSize = 0;
			btnPhieuTbi.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnPhieuTbi.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnPhieuTbi.FlatStyle = FlatStyle.Flat;
			btnPhieuTbi.MouseMove += BtnPhieuTbi_MouseMove1;
			btnPhieuTbi.MouseLeave += BtnPhieuTbi_MouseLeave1;
			pnlDK.Controls.Add(btnPhieuTbi);

			Button btnMayTinh = new Button();
			btnMayTinh.Text = "Thông Tin Đăng Kí";
			btnMayTinh.Location = new Point(21, 92);
			btnMayTinh.Size = new Size(137, 37);
			btnMayTinh.BackColor = Color.Transparent;
			btnMayTinh.BackgroundImage = Properties.Resources.b1;
			btnMayTinh.BackgroundImageLayout = ImageLayout.Stretch;
			btnMayTinh.FlatAppearance.BorderSize = 0;
			btnMayTinh.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnMayTinh.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnMayTinh.FlatStyle = FlatStyle.Flat;
			btnMayTinh.MouseLeave += BtnMayTinh_MouseLeave1;
			btnMayTinh.MouseMove += BtnMayTinh_MouseMove1;
			pnlDK.Controls.Add(btnMayTinh);

			Button btnPhieuMT = new Button();
			btnPhieuMT.Text = "Ca Trực";
			btnPhieuMT.Location = new Point(21, 135);
			btnPhieuMT.Size = new Size(137, 37);
			btnPhieuMT.BackColor = Color.Transparent;
			btnPhieuMT.BackgroundImage = Properties.Resources.b1;
			btnPhieuMT.BackgroundImageLayout = ImageLayout.Stretch;
			btnPhieuMT.FlatAppearance.BorderSize = 0;
			btnPhieuMT.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnPhieuMT.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnPhieuMT.FlatStyle = FlatStyle.Flat;
			btnPhieuMT.MouseMove += BtnPhieuMT_MouseMove1;
			btnPhieuMT.MouseLeave += BtnPhieuMT_MouseLeave1;
			pnlDK.Controls.Add(btnPhieuMT);
		}

	

		public void drawPanelThongTinLop()
		{
			
			pnlLopHoc.Size = new Size(171, 94);
			pnlLopHoc.Location = new Point(35, 369);
			pnlLopHoc.BackColor = Color.Transparent;
			this.Controls.Add(pnlLopHoc);

			Button btnLH = new Button();
			btnLH.Text = "Thông Tin Lớp Học";
			btnLH.Location = new Point(17, 5);
			btnLH.Size = new Size(137, 37);
			btnLH.BackColor = Color.Transparent;
			btnLH.BackgroundImage = Properties.Resources.b1;
			btnLH.BackgroundImageLayout = ImageLayout.Stretch;
			btnLH.FlatAppearance.BorderSize = 0;
			btnLH.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnLH.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnLH.FlatStyle = FlatStyle.Flat;
			btnLH.MouseLeave += BtnLH_MouseLeave;
			btnLH.MouseMove += BtnLH_MouseMove;
			pnlLopHoc.Controls.Add(btnLH);

			Button btnMH = new Button();
			btnMH.Text = "Thông Tin Môn Học";
			btnMH.Location = new Point(17, 48);
			btnMH.Size = new Size(137, 37);
			btnMH.BackColor = Color.Transparent;
			btnMH.BackgroundImage = Properties.Resources.b1;
			btnMH.BackgroundImageLayout = ImageLayout.Stretch;
			btnMH.FlatAppearance.BorderSize = 0;
			btnMH.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnMH.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnMH.FlatStyle = FlatStyle.Flat;
			btnMH.MouseMove += BtnMH_MouseMove;
			btnMH.MouseLeave += BtnMH_MouseLeave;
			pnlLopHoc.Controls.Add(btnMH);

		}
		
		public void drawPanelDangNhap()
		{
			
			pnlDN.Size = new Size(174, 99);
			pnlDN.Location = new Point(32, 423);
			pnlDN.BackColor = Color.Transparent;
			this.Controls.Add(pnlDN);

			Button btnDN = new Button();
			btnDN.Text = "Đăng Xuất";
			btnDN.Location = new Point(22, 10);
			btnDN.Size = new Size(137, 37);
			btnDN.BackColor = Color.Transparent;
			btnDN.BackgroundImage = Properties.Resources.b1;
			btnDN.BackgroundImageLayout = ImageLayout.Stretch;
			btnDN.FlatAppearance.BorderSize = 0;
			btnDN.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnDN.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnDN.FlatStyle = FlatStyle.Flat;
			btnDN.MouseLeave += BtnDN_MouseLeave;
			btnDN.MouseMove += BtnDN_MouseMove;
			btnDangNhap.Click += BtnDangNhap_Click;
			pnlDN.Controls.Add(btnDN);

			Button btnDMK = new Button();
			btnDMK.Text = "Đổi Mật Khẩu";
			btnDMK.Location = new Point(22, 53);
			btnDMK.Size = new Size(137, 37);
			btnDMK.BackColor = Color.Transparent;
			btnDMK.BackgroundImage = Properties.Resources.b1;
			btnDMK.BackgroundImageLayout = ImageLayout.Stretch;
			btnDMK.FlatAppearance.BorderSize = 0;
			btnDMK.FlatAppearance.MouseDownBackColor = Color.Transparent;
			btnDMK.FlatAppearance.MouseOverBackColor = Color.Transparent;
			btnDMK.FlatStyle = FlatStyle.Flat;
			btnDMK.MouseMove += BtnDMK_MouseMove;
			btnDMK.MouseLeave += BtnDMK_MouseLeave;
			btnDMK.Click += BtnDMK_Click
				;
			pnlDN.Controls.Add(btnDMK);

		}

		private void BtnDangNhap_Click(object sender, EventArgs e)
		{
		  
		}

		#endregion
		#region Menu

		private void btnThongTinNV_Click(object sender, EventArgs e)
		{
			if (n == 0)
			{
				btnThongTinNV.ForeColor = Color.DarkMagenta;
				btnQuanLy.Location = new Point(36, 335);
				btnDangKiTH.Location = new Point(36, 390);
				btnthongtinLop.Location = new Point(36, 445);
				btnDangNhap.Location = new Point(36, 500);

				drawPanelNV();
				pnlNV.Show();
				n = 1;
			}
			else if (n==1)
			{
				drawMenu();
				n = 0;
			}
		}

		private void btnQuanLy_Click(object sender, EventArgs e)
		{
			if (n == 0)
			{
				btnQuanLy.ForeColor = Color.DarkMagenta;
				btnDangKiTH.Location = new Point(36, 436);
				btnthongtinLop.Location = new Point(36, 492);
				btnDangNhap.Location = new Point(36, 546);

				drawPanelQL();
				pnlQL.Show();
				n = 1;
			}
			else if (n == 1)
			{
				drawMenu();
				n = 0;
			}
		}

		private void btnDangKiTH_Click(object sender, EventArgs e)
		{
			if (n == 0)
			{
				btnDangKiTH.ForeColor = Color.DarkMagenta;
				btnthongtinLop.Location = new Point(30, 500);
				btnDangNhap.Location = new Point(30, 555);

				drawPanelDangKi();
				pnlDK.Show();
				n = 1;
			}
			else if (n == 1)
			{
				drawMenu();
				n = 0;
			}
		}


		private void btnthongtinLop_Click(object sender, EventArgs e)
		{
			if (n == 0)
			{
				btnthongtinLop.ForeColor = Color.DarkMagenta;
				btnDangNhap.Location = new Point(36, 468);

				drawPanelThongTinLop();
				pnlLopHoc.Show();
				n = 1;
			}
			else if (n == 1)
			{
				drawMenu();
				n = 0;
			}
		}

		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			if (n == 0)
			{
				btnDangNhap.ForeColor = Color.DarkMagenta;

				drawPanelDangNhap();
				pnlDN.Show();
				n = 1;
			}
			else if (n == 1)
			{
				drawMenu();
				n = 0;
			}
		}
		private void lblTen_Click(object sender, EventArgs e)
		{
			frmThongTinCaNhan frmTTCN = new frmThongTinCaNhan();
			panel_showdata.Controls.Clear();
			frmTTCN.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmTTCN);
		}
		frmPSCMayTinh frmPSCMT = new frmPSCMayTinh();
		private void BtnPhieuMT_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
			frmPSCMT.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmPSCMT);
		}
		frmMayTinh frmMT = new frmMayTinh();
		private void BtnMayTinh_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
			frmMT.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmMT);
		}
		frmPSCThietBi frmPSCTB = new frmPSCThietBi();
		private void BtnPhieuTbi_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
			frmPSCTB.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmPSCTB);
		}
		frmThietBi frmTB = new frmThietBi();
		private void BtnTbi_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
			frmTB.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmTB);

 		}
		private void BtnLuong_Click(object sender, EventArgs e)
		{

		}
		frmNhanVien frmNV = new frmNhanVien();
		private void BtnNV_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
			frmNV.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmNV);
		}

		frmLichTruc frmlt = new frmLichTruc();
		private void BtnLichTruc_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
 			frmlt.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmlt);
		}
		frmDoiMK frmdmk = new frmDoiMK();
		private void BtnDMK_Click(object sender, EventArgs e)
		{
			panel_showdata.Controls.Clear();
			frmdmk.Dock = DockStyle.Fill;
			panel_showdata.Controls.Add(frmdmk);
		}
		#endregion
		#region EventButton
		private void lblTen_MouseHover(object sender, EventArgs e)
		{
			lblTen.Font = new Font(lblTen.Font, FontStyle.Underline);
		}

		private void lblTen_MouseLeave(object sender, EventArgs e)
		{
			lblTen.Font = new Font(lblTen.Font, FontStyle.Regular);
		}
		private void BtnDMK_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnDMK_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnDN_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnDN_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}
		private void BtnMH_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnMH_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnLH_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnLH_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuMT_MouseLeave1(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuMT_MouseMove1(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnMayTinh_MouseMove1(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112; ;
		}

		private void BtnMayTinh_MouseLeave1(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuTbi_MouseLeave1(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuTbi_MouseMove1(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnLichTruc_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnLichTruc_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}
		private void BtnPhieuMT_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuMT_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnMayTinh_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnMayTinh_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuTbi_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnPhieuTbi_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnTbi_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnTbi_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}
		private void BtnLuong_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnLuong_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnGV_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnGV_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}

		private void BtnNV_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.b1;
		}

		private void BtnNV_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
		}
		private void btnThongTinNV_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources._133;
		}

		private void btnThongTinNV_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.xanh;
		}

		private void btnQuanLy_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources._133;
		}

		private void btnQuanLy_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.xanh;
		}

		private void btnDangKiTH_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources._133;
		}

		private void btnthongtinLop_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources._133;
		}

		private void btnthongtinLop_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.xanh;
		}

		private void btnDangNhap_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.xanh;
		}

		private void btnDangNhap_MouseMove(object sender, MouseEventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources._133;
		}

		private void btnDangKiTH_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackgroundImage = Properties.Resources.xanh;
		}
		#endregion
		 

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int x, y, z, a, b, c;
			x = frmNhanVien.index();
			y = frmMayTinh.index();
			z = frmThietBi.index();
			a = frmPSCThietBi.setkey();
			b = frmLichTruc.index();
			c = frmPSCMayTinh.setkey();
			switch (x)
			{

				case 1:
					NhanVienBLL.SuaNV(frmNV.GETNHANVIEN());
  					MessageBox.Show("sửa nhân viên thành công!");
					break;
				case 2:

					// tạo tài khoản mật khẩu bằng đúng mã nhân viên
					string pass = frmNV.GETMANV();
					byte[] bytes = Encoding.UTF8.GetBytes(pass);
					var encodedData = Convert.ToBase64String(bytes);
					TaiKhoan tk = new TaiKhoan(frmNV.GETMANV(), encodedData);

					NhanVienBLL.ThemNV(frmNV.GETNHANVIEN());
					//đưa tài khoản vào cơ sở dữ liệu
					TaiKhoanBLL.ThemTaiKhoan(tk);
					MessageBox.Show("Thêm nhân viên thành công!");
 					break;
				case 3:
 					NhanVien nv2 = new NhanVien(frmNV.GETMANV());
					NhanVienBLL.XoaNV(nv2);
					TaiKhoanBLL.XoaTaiKhoan(frmNV.GETMANV());
					MessageBox.Show("Xóa nhân viên thành công!");
 					break;
			}
			switch (y)
			{

				case 1:
					MayTinhBLL.ThemNV(frmMT.GETMAYTINH());
					MessageBox.Show("thêm máy tính thành công!");
					break;
				case 2:
					MayTinhBLL.SuaNV(frmMT.GETMAYTINH());
					MessageBox.Show("sửa thông tin thành công!");
					break;
				case 3:
					string mamay = (frmMT.GETMAMAY());
					MayTinhBLL.XoaNV(mamay);
 					MessageBox.Show("Xóa thành công!");
					break;
			}
			switch (z)
			{

				case 1:
					ThietBiBLL.ThemTB(frmTB.GETTHIETBI());
					MessageBox.Show("thêm thiết bị thành công!");
					break;
				case 2:
					ThietBiBLL.SuaTB(frmTB.GETTHIETBI());
					MessageBox.Show("sửa thông tin thành công!");
					break;
				case 3:
					string mamay = (frmTB.GETMATB());
					ThietBiBLL.XoaTB(mamay);
					MessageBox.Show("Xóa thành công!");
					break;
			}
			switch (a)
			{

				case 1:
					PSCThietBiBLL.ThemPhieu(frmPSCTB.GETPHIEUTB());
					MessageBox.Show("thêm thiết bị thành công!");
					break;
				case 2:
					PSCThietBiBLL.SuaPhieu(frmPSCTB.GETPHIEUTB());
					MessageBox.Show("sửa thông tin thành công!");
					break;
				case 3:
					string mamay = (frmPSCTB.GETMATB());
					PSCThietBiBLL.XoaPhieu(mamay);
					MessageBox.Show("Xóa thành công!");
					break;
			}
			switch (b)
			{

				case 1:
					LichTrucBLL.ThemLT(frmlt.GETLICHTRUC());
					MessageBox.Show("thêm thiết bị thành công!");
					break;
				case 2:
					LichTrucBLL.SuaLT(frmlt.GETLICHTRUC());
					MessageBox.Show("sửa thông tin thành công!");
					break;
				case 3:
					string malt = (frmlt.GETMALT());
					LichTrucBLL.XoaLT(malt);
					MessageBox.Show("Xóa thành công!");
					break;
			}
			switch (c)
			{

				case 1:
					PSCMayTinhBLL.ThemPhieu(frmPSCMT.GETPHIEUMT());
					MessageBox.Show("thêm thiết bị thành công!");
					break;
				case 2:
					PSCMayTinhBLL.SuaPhieu(frmPSCMT.GETPHIEUMT());
					MessageBox.Show("sửa thông tin thành công!");
					break;
				case 3:
					string malt = (frmPSCMT.GETMAMT());
					PSCMayTinhBLL.XoaPhieu(malt);
					MessageBox.Show("Xóa thành công!");
					break;
			}
		}

		private void undoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			int x,y;
			x = frmNhanVien.Key;
			y = frmMayTinh.key;
			if(x == 0)
			{
				frmNV.Undo();
			}
			if (y == 4)
			{
				frmMT.Undo();
			}
			if (y == 4)
			{
				frmTB.Undo();
			}
		}

		
	}
}
