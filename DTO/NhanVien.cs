using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class NhanVien
	{
		public string MaNV { get; set; }
		public string TenNV { get; set; }
		public string GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public double Luong { get; set; }
		public double HeSoLuong { get; set; }
		public string ChucVu { get; set; }
		public NhanVien()
		{

		}
		 
		public NhanVien(string ma,string ten, string gt,DateTime ns, double luong, double hsluong,string chucvu)
		{
			MaNV = ma;
			TenNV = ten;
			GioiTinh = gt;
			NgaySinh = ns;
			Luong = luong;
			HeSoLuong = hsluong;
			ChucVu = chucvu;
		}
		public NhanVien(string ma)
		{ MaNV = ma; }
	}
}
