using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
	public class PSCMayTinhBLL
	{
		public static List<PhieuSuaChua> ShowPhieuSuaChua()
		{
			return PSCMayTinhAccess.ShowPhieuSuaChua();
		}
		public static void ThemPhieu(PhieuSuaChua ph)
		{
			PSCMayTinhAccess.Insert(ph);
		}
		public static void SuaPhieu(PhieuSuaChua ph)
		{
			PSCMayTinhAccess.UpDate(ph);
		}
		public static void XoaPhieu(string ph)
		{
			PSCMayTinhAccess.Delete(ph);
		}
		 
	}
}
