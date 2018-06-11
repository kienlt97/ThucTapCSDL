using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class MayTinh
	{
		public string MaMay { get; set; }
		public string TenMay { get; set; }
		public string RAM { get; set; }
		public string HDD { get; set; }
		public string TinhTrang { get; set; }
		public DateTime HanBH { get; set; }
		public int SolanBH { get; set; }
		public string MaPM { get; set; }

		public MayTinh() { }
		 
		public MayTinh(string _MaMay,string _TenMay,string _RAM,string _HDD , string _TinhTrang,DateTime _HanBH,int _SolanBH , string _MaPM)
		{
			MaMay = _MaMay;
			TenMay = _TenMay;
			RAM = _RAM;
			HDD = _HDD;
			TinhTrang = _TinhTrang;
			HanBH = _HanBH;
			SolanBH = _SolanBH;
			MaPM = _MaPM;
		}
	}
}
 