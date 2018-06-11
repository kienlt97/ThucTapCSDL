using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class LichTruc
	{
 
		public string MaLT { get; set; }
		public string MaPM { get; set; }
		public string MaNV { get; set; }
		public	DateTime NgayTruc { get; set; }
		public string CaTruc { get; set; }
		public int TangCa { get; set; }
		public LichTruc (string malt,string mapm,string manv, DateTime ngaytruc,string catruc,int tangca)
		{
			MaLT = malt;
			MaPM = mapm;
			MaNV = manv;
			NgayTruc = ngaytruc;
			CaTruc = catruc;
			TangCa = tangca;
		}
		public LichTruc (string malt)
		{
			MaLT = malt;
		}
		public LichTruc()
		{

		}
	}
}
