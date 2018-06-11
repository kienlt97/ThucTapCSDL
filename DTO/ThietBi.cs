using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class ThietBi
	{
	
		public string MaTB { get; set; }
		public string TenTB { get; set; }
		public string TinhTrang { get; set; }
		public DateTime HanBH { get; set; }
		public int solanBH { get; set; }
		public string MaPM { get; set; }

		public ThietBi() { }
		public ThietBi (string _MaTB,string _TenTB,string _TinhTrang,DateTime _HanBH,int _solanBH,string _MaPM)
		{
			MaTB = _MaTB;
			TenTB = _TenTB;
			TinhTrang = _TinhTrang;
			HanBH = _HanBH;
			solanBH = _solanBH;
			MaPM = _MaTB;
		}
	}
}
