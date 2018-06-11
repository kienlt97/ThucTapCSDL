using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
	public class LichTrucAccess: DatabaseAccess
	{
		public static List<LichTruc> ShowLichTruc()
		{
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "LoadLichTruc";
			cmd.Connection = conn;

			SqlDataReader reader = cmd.ExecuteReader();
			List<LichTruc> dsLT = new List<LichTruc>();
			while (reader.Read())// điều kiện đọc
			{
				string malt = reader.GetString(0);
				string mapm = reader.GetString(1);
				string manv = reader.GetString(2);
				DateTime ngaytruc = reader.GetDateTime(3);
				string catruc = reader.GetString(4);
				int tangca = reader.GetInt32(5);

				LichTruc lt = new LichTruc( malt,  mapm,  manv,  ngaytruc,  catruc,  tangca);

				dsLT.Add(lt);
			}
			reader.Close();
			return dsLT;
		}
		public static void Insert(LichTruc lt)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "ThemLT";
			cmd.Connection = conn;
			//( MaLT ,MaPM , MaNV ,NgayTruc , CaTruc ,TangCa)
			OpenConnection();
			cmd.Parameters.Add("@MaLT", SqlDbType.NVarChar).Value = lt.MaLT;
			cmd.Parameters.Add("@MaPM", SqlDbType.NVarChar).Value = lt.MaPM;
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = lt.MaNV;
			cmd.Parameters.Add("@NgayTruc", SqlDbType.Date).Value = lt.NgayTruc;
			cmd.Parameters.Add("@CaTruc", SqlDbType.NVarChar).Value = lt.CaTruc;
			cmd.Parameters.Add("@TangCa", SqlDbType.Float).Value = lt.TangCa;
 			cmd.ExecuteNonQuery();
			CloseConnection();
		}

		public static void UpDate(LichTruc lt)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "SuaLT";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaLT", SqlDbType.NVarChar).Value = lt.MaLT;
			cmd.Parameters.Add("@MaPM", SqlDbType.NVarChar).Value = lt.MaPM;
			cmd.Parameters.Add("@MaNV", SqlDbType.NVarChar).Value = lt.MaNV;
			cmd.Parameters.Add("@NgayTruc", SqlDbType.Date).Value = lt.NgayTruc;
			cmd.Parameters.Add("@CaTruc", SqlDbType.NVarChar).Value = lt.CaTruc;
			cmd.Parameters.Add("@TangCa", SqlDbType.Float).Value = lt.TangCa;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static void Delete(string malt)
		{

			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "XoaLT";
			cmd.Connection = conn;

			OpenConnection();
			cmd.Parameters.Add("@MaLT", SqlDbType.NChar).Value = malt;
			cmd.ExecuteNonQuery();
			CloseConnection();
		}
		public static bool KiemTraNgayTruc(string CTruc, DateTime NTruc)
		{
			bool check = true;
			OpenConnection();
			SqlCommand cmd = new SqlCommand();
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.CommandText = "KiemTraCaTruc";
			cmd.Connection = conn;

			cmd.Parameters.Add("@CaTruc", SqlDbType.NVarChar).Value = CTruc;
			cmd.Parameters.Add("@NgayTruc", SqlDbType.Date).Value = NTruc;
			SqlDataReader reader = cmd.ExecuteReader();
 			while (reader.Read())
			{
				check = false; // đọc đc 1 đối tượng tồnt tại
			}
			reader.Close();
			return check;
		}
	}
}
