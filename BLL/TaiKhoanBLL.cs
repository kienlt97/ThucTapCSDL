using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
	public class TaiKhoanBLL
	{
		public static void ThemTaiKhoan(TaiKhoan tk)
		{
			TaiKhoanAccess.ThemTaiKhoan(tk);
		}
		public static void  XoaTaiKhoan(string tk)
		{
			TaiKhoanAccess.XoaTaiKhoan(tk);
		}
		public static void SuaMatKhau(TaiKhoan tk)
		{
			 TaiKhoanAccess.SuaMatKhau(tk);
		}
		
	}
}
