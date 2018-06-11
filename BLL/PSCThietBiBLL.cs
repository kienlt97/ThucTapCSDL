using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
	public class PSCThietBiBLL
	{
		public static List<PSCThietBi> ShowPSCThietBi()
		{
			return PSCThietBiAccess.ShowPhieuSuaChuaTB();
		}
		public static void ThemPhieu(PSCThietBi ph)
		{
			PSCThietBiAccess.Insert(ph);
		}
		public static void SuaPhieu(PSCThietBi ph)
		{
			PSCThietBiAccess.UpDate(ph);
		}
		public static void XoaPhieu(string ph)
		{
			PSCThietBiAccess.Delete(ph);
		}
	}
}
