using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
	public class NhanVienBLL
	{
		
		public List<NhanVien> ShowNhanVien()
		{
			return NhanVienAccess.ShowNhanVien();
			
		}
		public static void ThemNV(NhanVien nv)
		{
			NhanVienAccess.Insert(nv);
		}
		public static void SuaNV(NhanVien nv)
		{
			NhanVienAccess.UpDate(nv);
		}
		public static void XoaNV(NhanVien nv)
		{
			NhanVienAccess.Delete(nv);
		}
		public static List<NhanVien> SearchNhanVien(string key,string x)
		{
			return NhanVienAccess.SearchNhanVien(key,x);
		}
		public static List<NhanVien> ThongKeNV(string mapm)
		{
			return NhanVienAccess.ThongKeNV(mapm);
		}
		public static int PhanQuyen(string tk)
		{
			return NhanVienAccess.PhanQuyen(tk);
		}
		public static string LayTen(string manv)
		{
			return NhanVienAccess.LayTen(manv);
		}
	}
}
