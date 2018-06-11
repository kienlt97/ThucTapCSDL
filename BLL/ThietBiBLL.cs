using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
	public class ThietBiBLL
	{
		public static List<ThietBi> ShowThietBi()
		{
			return ThietBiAccess.ShowThietBi();

		}
		public static void ThemTB(ThietBi tb)
		{
			ThietBiAccess.Insert(tb);
		}
		public static void SuaTB(ThietBi tb)
		{
			ThietBiAccess.UpDate(tb);
		}
		public static void XoaTB(string matb)
		{
			ThietBiAccess.Delete(matb);
		}
		public static List<ThietBi> SearchThietBi(string key, string x)
		{
			return ThietBiAccess.SearchThietBi(key, x);
		}
		public static List<NhanVien> ThongKeNV(string mapm)
		{
			return ThietBiAccess.ThongKeNV(mapm);
		}
	}
}
