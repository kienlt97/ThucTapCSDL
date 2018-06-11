using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PhieuSuaChua
	{
		public string MaPhieu { get; set; }
		public string MaMay { get; set; }
		public string MaNV { get; set; }
		public DateTime NgaySua { get; set; }
		public Double ChiPhi { get; set; }

		public PhieuSuaChua (string map , string mamay,string manv , DateTime ngaysua,double chiphi)
		{
			MaPhieu = map;
			MaMay = mamay;
			MaNV = manv;
			NgaySua = ngaysua;
			ChiPhi = chiphi;
		}
		public PhieuSuaChua() { }
		 
	}
}
