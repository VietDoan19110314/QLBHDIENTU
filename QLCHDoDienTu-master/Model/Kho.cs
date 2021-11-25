using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class Kho {
		public int IDCuaHang { get; set; }
		public int IDSanPham { get; set; }
		public int SoLuong { get; set; }

		public Kho(int IDCuaHang_, int IDSanPham_, int SoLuong_) {
			this.IDCuaHang = IDCuaHang_;
			this.IDSanPham = IDSanPham_;
			this.SoLuong = SoLuong_;
		}
		// liên kết 1-1
		public CuaHang CUAHANG { get; set; }
		//liên kết 1-n
		public ICollection<SanPham> dssanpham_kho { get; set; }
	}
}
