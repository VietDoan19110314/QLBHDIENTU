using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class NhanVien {
		public int IDNhanVien { get; set; }
		public string TenNhanVien { get; set; }
		public string GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string DiaChi { get; set; }
		public DateTime NgayBatDauLam { get; set; }
		public decimal LuongThang { get; set; }
		public CuaHang CuaHang { get; set; }

		public NhanVien(int IDNhanVien_, string TenNhanVien_, string GioiTinh_, DateTime NgaySinh_, string DiaChi_, DateTime NgayBatDauLam_, decimal LuongThang_, CuaHang CuaHang_) {
			this.IDNhanVien = IDNhanVien_;
			this.TenNhanVien = TenNhanVien_;
			this.GioiTinh = GioiTinh_;
			this.NgaySinh = NgaySinh_;
			this.DiaChi = DiaChi_;
			this.NgayBatDauLam = NgayBatDauLam_;
			this.LuongThang = LuongThang_;
			this.CuaHang = CuaHang_;
		}
	}
}
