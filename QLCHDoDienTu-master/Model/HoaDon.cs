using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class HoaDon {
		public int IDHoaDon { get; set; }
		public DateTime NgayLapHoaDon { get; set; }
		public NhanVien NhanVien { get; set; }
		public KhachHang KhachHang { get; set; }
		public CuaHang CuaHang { get; set; }

		public HoaDon(HoaDon hd)
		{
			this.IDHoaDon = hd.IDHoaDon;
			this.NgayLapHoaDon = hd.NgayLapHoaDon;
			this.NhanVien = hd.NhanVien;
			this.KhachHang = hd.KhachHang;
			this.CuaHang = hd.CuaHang;
		}
		public HoaDon(int IDHoaDon_, DateTime NgayLapHoaDon_, NhanVien NhanVien_, KhachHang KhachHang_, CuaHang CuaHang_) {
			this.IDHoaDon = IDHoaDon_;
			this.NgayLapHoaDon = NgayLapHoaDon_;
			this.NhanVien = NhanVien_;
			this.KhachHang = KhachHang_;
			this.CuaHang = CuaHang_;
		}
		
	}
}
