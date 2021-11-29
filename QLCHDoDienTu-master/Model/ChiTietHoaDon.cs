using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class ChiTietHoaDon {
		public int IDHoaDon { get; set; }
		public int IDSanPham { get; set; }
		public int SoLuong { get; set; }
		public decimal GiamGia { get; set; }

		public ChiTietHoaDon(int IDHoaDon_, int IDSanPham_, int SoLuong_, decimal GiamGia_) {
			this.IDHoaDon = IDHoaDon_;
			this.IDSanPham = IDSanPham_;
			this.SoLuong = SoLuong_;
			this.GiamGia = GiamGia_;
		}
        //liên kết 1-1
        public HoaDon HOADON { get; set; }
        //		//liên kết 1-n
        public ICollection<SanPham> dssanpham_chitiethoadon { get; set; }
    }
}
