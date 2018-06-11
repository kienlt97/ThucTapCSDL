using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
	public class PhongMayBLL
	{
		public static List<PhongMay> ShowPhongMay()
		{
			return PhongMayAccess.ShowPhongMay();
		}
	}
}
