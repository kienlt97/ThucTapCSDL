using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class NgayTruc
	{
		public string NTruc { get; set; }
		public string CTruc { get; set; }

		public NgayTruc()
		{

		}
		public NgayTruc(string _NTruc,string _CTruc)
		{
			NTruc = _NTruc;
			CTruc = _CTruc;
		}
	}
}
