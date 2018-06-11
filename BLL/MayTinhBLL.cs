using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
	public class MayTinhBLL
	{
		public static List<MayTinh> ShowMayTinh()
		{
			return MayTinhAccess.ShowMayTinh();
		}
		public static List<MayTinh> SearchMayTinh(string key, string x)
		{
			return MayTinhAccess.SearchMayTinh(key, x);
		}
		public static void ThemNV(MayTinh mt)
		{
			MayTinhAccess.Insert(mt);
		}
		public static void SuaNV(MayTinh mt)
		{
			MayTinhAccess.UpDate(mt);
		}
		public static void XoaNV(string mamay)
		{
			MayTinhAccess.Delete(mamay);
		}
	}
}
