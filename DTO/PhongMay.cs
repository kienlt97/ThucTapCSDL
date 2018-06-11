using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhongMay
	{
		public string MaPM { get; set; }
		public string TenPM { get; set; }

		public int Solg { get; set; }

		public PhongMay (string ma,string ten,int sl)
		{
			MaPM = ma;
			TenPM = ten;
			Solg = sl;
		}
		public PhongMay(string ma)
		{
			MaPM = ma;
		}
	}
}
