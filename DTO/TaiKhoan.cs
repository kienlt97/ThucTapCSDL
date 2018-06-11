using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
	public class TaiKhoan
	{
		public string UserName { get; set; }

		public string Pass { get; set; }
		public string quyen { get; set; }

		public TaiKhoan(string us ,string pass)
		{
			UserName = us;
			Pass = pass;
		}
		public TaiKhoan(string us )
		{
			UserName = us;
		}
	}
}
