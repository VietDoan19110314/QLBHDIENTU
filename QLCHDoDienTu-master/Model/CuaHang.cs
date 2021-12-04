using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class CuaHang {
		public int IDCuaHang { get; set; }
		public string DiaChi { get; set; }
		public string SDT { get; set; }
		public string Email { get; set; }

		public CuaHang(CuaHang ch)
		{
			this.IDCuaHang = ch.IDCuaHang;
			this.DiaChi = ch.DiaChi;
			this.SDT = ch.SDT;
			this.Email = ch.Email;
		}

		public CuaHang(int IDCuaHang_, string DiaChi_, string SDT_, string Email_) {
			this.IDCuaHang = IDCuaHang_;
			this.DiaChi = DiaChi_;
			this.SDT = SDT_;
			this.Email = Email_;
		}
	}
}
