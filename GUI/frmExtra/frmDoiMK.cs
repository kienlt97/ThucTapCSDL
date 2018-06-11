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
	public partial class frmDoiMK : UserControl
	{
		public frmDoiMK()
		{
			InitializeComponent();
		}
		public static string user = string.Empty;
		private void btndoimatkhau_Click(object sender, EventArgs e)
		{

			if (txtmatkhau.Text == txtmatkhaumoi.Text)
			{
				MessageBox.Show("Không được đặt lại mật khẩu hiện tại!");
			}	
			else if(txtmatkhaumoi.Text != txtnhaplaimk.Text)
			{
				MessageBox.Show("Mật khẩu không chùng khớp!");
			}
			else
			{
				string mkmoi = txtmatkhaumoi.Text;

  				byte[] bytes = Encoding.UTF8.GetBytes(mkmoi);
				var encodedData = Convert.ToBase64String(bytes);
 				TaiKhoan tk = new TaiKhoan(user, encodedData);

				TaiKhoanBLL.SuaMatKhau(tk);
				MessageBox.Show("Đổi mật khẩu thành công!");
			}
		}

		 
	}
}
