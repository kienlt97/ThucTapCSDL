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
	public class MayTinhAccess : DatabaseAccess
	{
		public static List<MayTinh> ShowMayTinh()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadMay";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<MayTinh> dsMT = new List<MayTinh>();
			while (reader.Read())// điều kiện đọc
			{
				string mamay = reader.GetString(0);
				string tenmay = reader.GetString(1);
				string RAM = reader.GetString(2);
				string HDD = reader.GetString(3);
				string tinhtrang = reader.GetString(4);
				DateTime hbh = reader.GetDateTime(5);
				int solanbh = reader.GetInt32(6);
				string mapm = reader.GetString(7);
 
				MayTinh mt = new MayTinh(mamay, tenmay, RAM, HDD, tinhtrang, hbh, solanbh, mapm);

				dsMT.Add(mt);
			}
			reader.Close();
			return dsMT;
		}
		public static void Insert(MayTinh mt)
		{
			//( MaMay ,TenMay , Ram ,HDD ,TinhTrang ,HanBH ,SolanBH ,MaPM)
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemMT";
			cmd.Connection = conn;
			OpenConnection();
			cmd.Parameters.Add("@MaMay", SqlDbType.NVarChar).Value = mt.MaMay;
			cmd.Parameters.Add("@TenMay", SqlDbType.NVarChar).Value = mt.TenMay;
			cmd.Parameters.Add("@Ram", SqlDbType.NVarChar).Value = mt.RAM;
			cmd.Parameters.Add("@HDD", SqlDbType.NVarChar).Value = mt.HDD;
			cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = mt.TinhTrang;
			cmd.Parameters.Add("@HanBH", SqlDbType.Date).Value = mt.HanBH;
			cmd.Parameters.Add("@SolanBH", SqlDbType.Int).Value = mt.SolanBH;
			cmd.Parameters.Add("@MaPM", SqlDbType.NVarChar).Value = mt.MaPM;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void UpDate(MayTinh mt)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaMT";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaMay", SqlDbType.NVarChar).Value = mt.MaMay;
			cmd.Parameters.Add("@TenMay", SqlDbType.NVarChar).Value = mt.TenMay;
			cmd.Parameters.Add("@Ram", SqlDbType.NVarChar).Value = mt.RAM;
			cmd.Parameters.Add("@HDD", SqlDbType.NVarChar).Value = mt.HDD;
			cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = mt.TinhTrang;
			cmd.Parameters.Add("@HanBH", SqlDbType.Date).Value = mt.HanBH;
			cmd.Parameters.Add("@SolanBH", SqlDbType.Int).Value = mt.SolanBH;
			cmd.Parameters.Add("@MaPM", SqlDbType.NVarChar).Value = mt.MaPM;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void Delete(string mamay)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaMT";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaMay", SqlDbType.NVarChar).Value = mamay;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}

		public static List<MayTinh> SearchMayTinh(string key, string x)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "SELECT * FROM dbo.May WHERE " + key + " LIKE N'%" + x + "%'";
 			cmd.Connection = conn;

			OpenConnection();
 			SqlDataReader reader = cmd.ExecuteReader();
			List<MayTinh> dsMT = new List<MayTinh>();
			while (reader.Read())// điều kiện đọc
			{
				string mamay = reader.GetString(0);
				string tenmay = reader.GetString(1);
				string ram = reader.GetString(2);
				string hdd = reader.GetString(3);
				string tinhtrang = reader.GetString(4);
				DateTime hbh = reader.GetDateTime(5);
				int solanbh = reader.GetInt32(6);
				string mapm = reader.GetString(7);
 
				MayTinh mt = new MayTinh(mamay, tenmay, ram, hdd, tinhtrang, hbh, solanbh,mapm);

				dsMT.Add(mt);
			}
			reader.Close();
			return dsMT;
		}


		//public static List<NhanVien> ThongKeNV(string MaPM)
		//{
		//	SqlCommand cmd = new SqlCommand();
		//	cmd.CommandType = CommandType.StoredProcedure;
		//	cmd.CommandText = "ThongKeNV";
		//	cmd.Connection = conn;

		//	OpenConnection();
		//	cmd.Parameters.Add("@MaPM", SqlDbType.NVarChar).Value = MaPM;
		//	//cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
		//	SqlDataReader reader = cmd.ExecuteReader();
		//	List<NhanVien> ListTKNV = new List<NhanVien>();
		//	while (reader.Read())// điều kiện đọc
		//	{
		//		string manv = reader.GetString(0);
		//		string tennv = reader.GetString(1);
		//		string gt = reader.GetString(2);
		//		DateTime ns = reader.GetDateTime(3);
		//		double luong = reader.GetDouble(4);
		//		double hsl = reader.GetDouble(5);
		//		string chucvu = reader.GetString(6);

		//		NhanVien nv = new NhanVien(manv, tennv, gt, ns, luong, hsl, chucvu);
		//		ListTKNV.Add(nv);
		//	}
		//	reader.Close();
		//	return ListTKNV;
		//}
		 
 
	}
}
