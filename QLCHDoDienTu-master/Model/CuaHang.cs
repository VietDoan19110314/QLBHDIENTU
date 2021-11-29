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

		public CuaHang(int IDCuaHang_, string DiaChi_, string SDT_, string Email_) {
			this.IDCuaHang = IDCuaHang_;
			this.DiaChi = DiaChi_;
			this.SDT = SDT_;
			this.Email = Email_;
		}
		// liên kết 1-1
		public Kho KHO { get; set; }
		// liên kết 1-n
		public ICollection<NhanVien> dsnhanvien_cuahang { get; set; }
	}
}
