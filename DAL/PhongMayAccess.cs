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
	public class PhongMayAccess:DatabaseAccess
	{
		public static List<PhongMay> ShowPhongMay()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadPM";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<PhongMay> dsPM = new List<PhongMay>();
			while (reader.Read())// điều kiện đọc
			{
				string mapm = reader.GetString(0);
				string tenpm = reader.GetString(1);
				int soluong = reader.GetInt32(2);

				PhongMay pm = new PhongMay(mapm, tenpm, soluong);

				dsPM.Add(pm);
			}
			reader.Close();
			return dsPM;
		}
	}
}
