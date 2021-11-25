using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class NhaCungCap {
		public int IDNhaCungCap { get; set; }
		public string TenNhaCungCap { get; set; }
		public string DiaChi { get; set; }
		public string SDT { get; set; }
		public string Email { get; set; }

		public NhaCungCap(int IDNhaCungCap_, string TenNhaCungCap_, string DiaChi_, string SDT_, string Email_) {
			this.IDNhaCungCap = IDNhaCungCap_;
			this.TenNhaCungCap = TenNhaCungCap_;
			this.DiaChi = DiaChi_;
			this.SDT = SDT_;
			this.Email = Email_;
		}
		//public ICollection<SanPham> dssanpham_nhacungcap { get; set; }
	}
}
