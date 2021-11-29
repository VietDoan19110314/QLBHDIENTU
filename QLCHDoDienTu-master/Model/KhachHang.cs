using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class KhachHang {
		public int IDKhachHang { get; set; }
		public string TenKhachHang { get; set; }
		public string GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public string SDT { get; set; }
		public string Email { get; set; }
		public string DiaChi { get; set; }

		public KhachHang(int IDKhachHang_, string TenKhachHang_, string GioiTinh_, DateTime NgaySinh_, string SDT_, string Email_, string DiaChi_) {
			this.IDKhachHang = IDKhachHang_;
			this.TenKhachHang = TenKhachHang_;
			this.GioiTinh = GioiTinh_;
			this.NgaySinh = NgaySinh_;
			this.SDT = SDT_;
			this.Email = Email_;
			this.DiaChi = DiaChi_;
		}
		// liên kết 1-n
		public ICollection<HoaDon> dshoadon_khachhang { get; set; }
	}
}
