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
	public class ThietBiAccess : DatabaseAccess
	{
		public static List<ThietBi> ShowThietBi()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadThietBi";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<ThietBi> dsTB = new List<ThietBi>();
			while (reader.Read())// điều kiện đọc
			{
				string matb = reader.GetString(0);
				string tentb = reader.GetString(1);
				string tinhtrang = reader.GetString(2);
				DateTime ngaybh = reader.GetDateTime(3);
				int solanbh = reader.GetInt32(4);
				string mapm = reader.GetString(5);
 
				ThietBi tb = new ThietBi(matb, tentb, tinhtrang, ngaybh, solanbh, mapm);

				dsTB.Add(tb);
			}
			reader.Close();
			return dsTB;
		}
		public static void Insert(ThietBi tb)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemTB";
			cmd.Connection = conn;
			OpenConnection();

			cmd.Parameters.Add("@MaTB", SqlDbType.NVarChar).Value = tb.MaTB;
			cmd.Parameters.Add("@TenTB", SqlDbType.NVarChar).Value = tb.TenTB;
			cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tb.TinhTrang;
			cmd.Parameters.Add("@HanBH", SqlDbType.Date).Value = tb.HanBH;
			cmd.Parameters.Add("@SolanBH", SqlDbType.Int).Value = tb.solanBH;
			cmd.Parameters.Add("@MaPM", SqlDbType.VarChar).Value = tb.MaPM;
 			cmd.ExecuteNonQuery();
			CloseConnection();
		}

		public static void UpDate(ThietBi tb)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaTB";
			cmd.Connection = conn;

			OpenConnection();

			cmd.Parameters.Add("@MaTB", SqlDbType.NVarChar).Value = tb.MaTB;
			cmd.Parameters.Add("@TenTB", SqlDbType.NVarChar).Value = tb.TenTB;
			cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = tb.TinhTrang;
			cmd.Parameters.Add("@HanBH", SqlDbType.Date).Value = tb.HanBH;
			cmd.Parameters.Add("@SolanBH", SqlDbType.Int).Value = tb.solanBH;
			cmd.Parameters.Add("@MaPM", SqlDbType.VarChar).Value = tb.MaPM;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void Delete(string matb)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaTB";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaTB", SqlDbType.NVarChar).Value = matb;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
	  
		public static List<ThietBi> SearchThietBi(string key, string x)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "SELECT * FROM dbo.ThietBi WHERE " + key + " LIKE N'%" + x + "%'";
			//cmd.CommandText = "TimKiemNV";
			cmd.Connection = conn;

			OpenConnection();
			//cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
			SqlDataReader reader = cmd.ExecuteReader();
			List<ThietBi> dsTB = new List<ThietBi>();
			while (reader.Read())// điều kiện đọc
			{
				string matb = reader.GetString(0);
				string tentb = reader.GetString(1);
				string tinhtrang = reader.GetString(2);
				DateTime ngaybh = reader.GetDateTime(3);
				int solanbh = reader.GetInt32(4);
				string mapm = reader.GetString(5);

				ThietBi tb = new ThietBi(matb, tentb, tinhtrang, ngaybh, solanbh, mapm);

				dsTB.Add(tb);
			}
			reader.Close();
			return dsTB;
		}


		public static List<NhanVien> ThongKeNV(string MaPM)
		{
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThongKeNV";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaPM", SqlDbType.NVarChar).Value = MaPM;
			//cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
			SqlDataReader reader = cmd.ExecuteReader();
			List<NhanVien> ListTKNV = new List<NhanVien>();
			while (reader.Read())// điều kiện đọc
			{
				string manv = reader.GetString(0);
				string tennv = reader.GetString(1);
				string gt = reader.GetString(2);
				DateTime ns = reader.GetDateTime(3);
				double luong = reader.GetDouble(4);
				double hsl = reader.GetDouble(5);
				string chucvu = reader.GetString(6);

				NhanVien nv = new NhanVien(manv, tennv, gt, ns, luong, hsl, chucvu);
				ListTKNV.Add(nv);
			}
			reader.Close();
			return ListTKNV;
		}
	}
}
