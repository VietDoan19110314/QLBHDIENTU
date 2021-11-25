using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class HoaDon {
		public int IDHoaDon { get; set; }
		public DateTime NgayLapHoaDon { get; set; }
		public int IDNhanVien { get; set; }
		public int IDKhachHang { get; set; }
		public int IDCuaHang { get; set; }

		public HoaDon(int IDHoaDon_, DateTime NgayLapHoaDon_, int IDNhanVien_, int IDKhachHang_, int IDCuaHang_) {
			this.IDHoaDon = IDHoaDon_;
			this.NgayLapHoaDon = NgayLapHoaDon_;
			this.IDNhanVien = IDNhanVien_;
			this.IDKhachHang = IDKhachHang_;
			this.IDCuaHang = IDCuaHang_;
		}
        // liên kết 1-1
        //		public KhachHang KHACHHANG { get; set; }
        //		public NhanVien NHANVIEN { get; set; }
        //		public CuaHang CUAHANG { get; set; }
        //		public ChiTietHoaDon CHITIETHOADON { get; set; }
    }
}
