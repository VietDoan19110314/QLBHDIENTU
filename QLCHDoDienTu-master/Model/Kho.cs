using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class Kho {
		public CuaHang CuaHang { get; set; }
		public SanPham SanPham { get; set; }
		public int SoLuong { get; set; }

		public Kho(CuaHang CuaHang_, SanPham SanPham_, int SoLuong_) {
			this.CuaHang = CuaHang_;
			this.SanPham = SanPham_;
			this.SoLuong = SoLuong_;
		}
	}
}
