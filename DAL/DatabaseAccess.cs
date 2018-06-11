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
	public class DatabaseAccess
	{
		// tạo chuỗi kết nối
		static string Strcon = @"Server =DESKTOP-2NN1U31\SQLEXPRESS; Database = PhongMay ; Integrated Security = True";
		public static SqlConnection conn = null;
		public static void OpenConnection()
		{
			if (conn == null) // kiểm tra có kết nối chưa..chưa kết nối thì sẽ khởi tạo kết nối
				conn = new SqlConnection(Strcon);
			if (conn.State == ConnectionState.Closed)
				conn.Open();
		}
		public static void CloseConnection()
		{
			if (conn != null && conn.State == ConnectionState.Open)
				conn.Close();
		}

	}
}
