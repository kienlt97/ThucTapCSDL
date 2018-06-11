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
	public class PSCThietBiAccess : DatabaseAccess
	{
		public static List<PSCThietBi> ShowPhieuSuaChuaTB()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadPSCThietBi";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<PSCThietBi> dsPSC = new List<PSCThietBi>();
			while (reader.Read())
			{
				string maphieu = reader.GetString(0);
				string matb = reader.GetString(1);
				string manv = reader.GetString(2);
				DateTime ngaysua = reader.GetDateTime(3);
				double chiphi = reader.GetDouble(4);
				PSCThietBi psc = new PSCThietBi(maphieu, matb, manv, ngaysua, chiphi);
				dsPSC.Add(psc);
			}
			reader.Close();
			return dsPSC;
		}
		public static void Insert(PSCThietBi ph)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemPSCThietBi";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = ph.MaPhieu;
			cmd.Parameters.Add("@MaTB", SqlDbType.NVarChar).Value = ph.MaTB;
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = ph.MaNV;
			cmd.Parameters.Add("@NgaySua", SqlDbType.Date).Value = ph.NgaySua;
			cmd.Parameters.Add("@ChiPhi", SqlDbType.Float).Value = ph.ChiPhi;

			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void UpDate(PSCThietBi ph)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaPSCThietBi";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = ph.MaPhieu;
			cmd.Parameters.Add("@MaTB", SqlDbType.NVarChar).Value = ph.MaTB;
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = ph.MaNV;
			cmd.Parameters.Add("@NgaySua", SqlDbType.Date).Value = ph.NgaySua;
			cmd.Parameters.Add("@ChiPhi", SqlDbType.Float).Value = ph.ChiPhi;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void Delete(string ph)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaPSCThietBi";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = ph;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
	}
}
