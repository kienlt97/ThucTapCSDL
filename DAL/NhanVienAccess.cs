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
	public class NhanVienAccess:DatabaseAccess
	{
		public static List<NhanVien> ShowNhanVien()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadNhanVien";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<NhanVien> dsNV = new List<NhanVien>();
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

				dsNV.Add(nv);
			}
			reader.Close();
			return dsNV;
		}
		public static void Insert(NhanVien nv)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemNV";
			cmd.Connection = conn;
 			OpenConnection();
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
			cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
			cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
			cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
			cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = nv.Luong;
			cmd.Parameters.Add("@HSLuong", SqlDbType.Float).Value = nv.HeSoLuong;
			cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}

		public static void UpDate(NhanVien nv)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "suaNV";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
			cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nv.TenNV;
			cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = nv.GioiTinh;
			cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = nv.NgaySinh;
			cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = nv.Luong;
			cmd.Parameters.Add("@HSLuong", SqlDbType.Float).Value = nv.HeSoLuong;
			cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nv.ChucVu;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void Delete(NhanVien nv)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "xoaNV";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = nv.MaNV;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
 
		public static List<NhanVien> SearchNhanVien(string key,string x)
		{
			
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "SELECT * FROM dbo.NhanVien WHERE "+ key + " LIKE N'%"+ x + "%'";
			//cmd.CommandText = "TimKiemNV";
			cmd.Connection = conn;

			OpenConnection();
			//cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = nv.MaNV;
			SqlDataReader reader = cmd.ExecuteReader();
			List<NhanVien> dsNV = new List<NhanVien>();
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

				dsNV.Add(nv);
			}
			reader.Close();
			return dsNV;
		}


		public static List<NhanVien> ThongKeNV (string MaPM)
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
		public static int PhanQuyen(string tk)
		{
			int quyen = 0;

			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "PhanQuyen";
			cmd.Connection = conn;

			cmd.Parameters.Add("@TaiKhoan", SqlDbType.NVarChar).Value = tk;

			SqlDataReader reader = cmd.ExecuteReader();
 			while (reader.Read())
			{
				quyen = reader.GetInt32(0);
			}
			reader.Close();
			return quyen;
		}

		public static string LayTen(string manv)
		{
			string name = "";
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LayTen";
			cmd.Connection = conn;

			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = manv;

			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				name = reader.GetString(0);
			}
			reader.Close();
			return name;
		}
	}
}
