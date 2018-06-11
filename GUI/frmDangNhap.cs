using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}
		 
		
		string Strcon = @"Server =DESKTOP-2NN1U31\SQLEXPRESS; Database = PhongMay ; Integrated Security = True";
		SqlConnection conn = null;
		FormMain frmmain = new FormMain();
  		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			 
			if (conn == null) // kiểm tra có kết nối chưa..chưa kết nối thì sẽ khởi tạo kết nối
				conn = new SqlConnection(Strcon);
			if (conn.State == ConnectionState.Closed)
				conn.Open();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "DangNhap";
			cmd.Connection = conn;
			//151505156
			string pass = txtmatkhau.Text;
 			byte[] bytes = Encoding.UTF8.GetBytes(pass);
			var encodedData = Convert.ToBase64String(bytes);

			frmExtra.frmDoiMK.user = txttaikhoan.Text;
			frmNhanVien.taikhoan = txttaikhoan.Text;
			frmExtra.frmPSCMayTinh.manv = txttaikhoan.Text;
			frmExtra.frmPSCThietBi.manv = txttaikhoan.Text;
			frmExtra.frmLichTruc.user = txttaikhoan.Text;

			FormMain.manv = txttaikhoan.Text;
			cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = txttaikhoan.Text;
			cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = encodedData;
			SqlDataReader reader = cmd.ExecuteReader();
			
 			if (reader.Read())// điều kiện đọc
			{
				this.Hide();
				frmmain.ShowDialog();
		 
			}
			else
			{
				MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng !");
			}
			reader.Close();

		 
		}
	 
 		private void frmDangNhap_Load(object sender, EventArgs e)
		{
			txttaikhoan.Text = Properties.Settings.Default.taikhoan;
			txtmatkhau.Text = Properties.Settings.Default.matkhau;
		}
 
	}
}
