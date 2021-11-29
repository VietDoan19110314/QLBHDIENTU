using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class LoaiHang {
		public int IDLoaiHang { get; set; }
		public string TenLoaiHang { get; set; }

		public LoaiHang(int IDLoaiHang_, string TenLoaiHang_) {
			this.IDLoaiHang = IDLoaiHang_;
			this.TenLoaiHang = TenLoaiHang_;
		}
		// plural liên kết 1-n
		public ICollection<SanPham> dssanpham_loaihang { get; set; }
	}
}
