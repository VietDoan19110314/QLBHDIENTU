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

		public HoaDon(int IDHoaDon_, DateTime NgayLapHoaDon_, NhanVien NhanVien_, KhachHang KhachHang_, CuaHang CuaHang_) {
			this.IDHoaDon = IDHoaDon_;
			this.NgayLapHoaDon = NgayLapHoaDon_;
			this.NhanVien = NhanVien_;
			this.KhachHang = KhachHang_;
			this.CuaHang = CuaHang_;
		}
        // liên kết 1-1
        public KhachHang KHACHHANG { get; set; }
        public NhanVien NHANVIEN { get; set; }
        public CuaHang CUAHANG { get; set; }
        public ChiTietHoaDon CHITIETHOADON { get; set; }
    }
}
