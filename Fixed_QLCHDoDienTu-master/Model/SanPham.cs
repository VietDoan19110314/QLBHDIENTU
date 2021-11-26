using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class SanPham {
		public int IDSanPham { get; set; }
		public string TenSanPham { get; set; }
		public decimal DonGia { get; set; }
		public int ThoiHanBaoHanh { get; set; }
		public int NamSanXuat { get; set; }
		public int IDNhaCungCap { get; set; }
		public int IDLoaiHang { get; set; }

		public SanPham(int IDSanPham_, string TenSanPham_, decimal DonGia_, int ThoiHanBaoHanh_, int NamSanXuat_, int IDNhaCungCap_, int IDLoaiHang_) {
			this.IDSanPham = IDSanPham_;
			this.TenSanPham = TenSanPham_;
			this.DonGia = DonGia_;
			this.ThoiHanBaoHanh = ThoiHanBaoHanh_;
			this.NamSanXuat = NamSanXuat_;
			this.IDNhaCungCap = IDNhaCungCap_;
			this.IDLoaiHang = IDLoaiHang_;
		}
		//liên kết 1-1
		//public LoaiHang LOAIHANG { get; set; }
		//public ChiTietHoaDon CHITIETHOADON { get; set; }
		//public Kho KHO { get; set; }
		////liên kết 1-n
		//public ICollection<NhaCungCap> dsnhacungcap_sanpham { get; set; }
	}
}
