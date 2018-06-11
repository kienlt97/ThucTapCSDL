using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
	public class LichTrucBLL
	{
		public static List<LichTruc> ShowLichTruc()
		{
			return LichTrucAccess.ShowLichTruc();
		}
		public static void ThemLT(LichTruc lt)
		{
			LichTrucAccess.Insert(lt);
		}
		public static void SuaLT(LichTruc lt)
		{
			LichTrucAccess.UpDate(lt);
		}
		public static void XoaLT(string malt)
		{
			LichTrucAccess.Delete(malt);
		}
		public static Boolean KiemTraNgayTruc(string CTruc, DateTime NTruc)
		{
			return LichTrucAccess.KiemTraNgayTruc( CTruc, NTruc);
		}
	}
}
