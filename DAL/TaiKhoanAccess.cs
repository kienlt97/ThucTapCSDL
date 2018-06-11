using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
	public class TaiKhoanAccess : DatabaseAccess
	{
		public static void ThemTaiKhoan(TaiKhoan tk)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemTaiKhoan";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value =tk.UserName;
			cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = tk.Pass;

			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void SuaMatKhau(TaiKhoan tk)
		{
 			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaMatKhau";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = tk.UserName;
			cmd.Parameters.Add("@MatKhau", SqlDbType.NVarChar).Value = tk.Pass;

			cmd.ExecuteNonQuery();
			CloseConnection();
 			
		}
		public static void XoaTaiKhoan(string tk)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaTaiKhoan";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = tk;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		
		
	}
}
