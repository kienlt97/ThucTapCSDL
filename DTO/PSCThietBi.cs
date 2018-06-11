using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class PSCThietBi
	{

		public string MaPhieu { get; set; }
		public string MaTB { get; set; }
		public string MaNV { get; set; }
		public DateTime NgaySua { get; set; }
		public Double ChiPhi { get; set; }

		public PSCThietBi(string map, string matb, string manv, DateTime ngaysua, double chiphi)
		{
			MaPhieu = map;
			MaTB = matb;
			MaNV = manv;
			NgaySua = ngaysua;
			ChiPhi = chiphi;
		}
		public PSCThietBi() { }

	}
}
