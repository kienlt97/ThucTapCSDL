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
	public class PSCMayTinhAccess:DatabaseAccess
	{
		public static List<PhieuSuaChua> ShowPhieuSuaChua()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadPSCMayTinh";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<PhieuSuaChua> dsPSC = new List<PhieuSuaChua>();
			while(reader.Read())
			{
				string maphieu = reader.GetString(0);
				string mamay = reader.GetString(1);
				string manv = reader.GetString(2);
				DateTime ngaysua = reader.GetDateTime(3);
				double chiphi = reader.GetDouble(4);
				PhieuSuaChua psc = new PhieuSuaChua(maphieu, mamay, manv, ngaysua, chiphi);
				dsPSC.Add(psc);
			}
			reader.Close();
			return dsPSC;
		}
		public static void Insert(PhieuSuaChua ph)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemPSCMayTinh";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = ph.MaPhieu;
			cmd.Parameters.Add("@MaMay", SqlDbType.NVarChar).Value = ph.MaMay;
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = ph.MaNV;
			cmd.Parameters.Add("@NgaySua", SqlDbType.Date).Value = ph.NgaySua;
			cmd.Parameters.Add("@ChiPhi", SqlDbType.Float).Value = ph.ChiPhi;
			 
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void UpDate(PhieuSuaChua ph)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaPSCMayTinh";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = ph.MaPhieu;
			cmd.Parameters.Add("@MaMay", SqlDbType.NVarChar).Value = ph.MaMay;
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
			cmd.CommandText = "XoaPSCMayTinh";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPhieu", SqlDbType.NVarChar).Value = ph;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
	}
}
