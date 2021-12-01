using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class ChiTietHoaDon {
		public HoaDon HoaDon { get; set; }
		public SanPham SanPham { get; set; }
		public int SoLuong { get; set; }
		public decimal GiamGia { get; set; }

		public ChiTietHoaDon(HoaDon HoaDon_, SanPham SanPham_, int SoLuong_, decimal GiamGia_) {
			this.HoaDon = HoaDon_;
			this.SanPham = SanPham_;
			this.SoLuong = SoLuong_;
			this.GiamGia = GiamGia_;
		}
    }
}
