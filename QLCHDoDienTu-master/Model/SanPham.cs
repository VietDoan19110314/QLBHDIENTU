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
		public NhaCungCap NhaCungCap { get; set; }
		public LoaiHang LoaiHang { get; set; }

		public SanPham(SanPham sp)
		{
			this.IDSanPham = sp.IDSanPham;
			this.TenSanPham = sp.TenSanPham;
			this.DonGia = sp.DonGia;
			this.ThoiHanBaoHanh = sp.ThoiHanBaoHanh;
			this.NamSanXuat = sp.NamSanXuat;
			this.NhaCungCap = sp.NhaCungCap;
			this.LoaiHang = sp.LoaiHang;
		}
		public SanPham(int IDSanPham_, string TenSanPham_, decimal DonGia_, int ThoiHanBaoHanh_, int NamSanXuat_, NhaCungCap NhaCungCap_, LoaiHang LoaiHang_) {
			this.IDSanPham = IDSanPham_;
			this.TenSanPham = TenSanPham_;
			this.DonGia = DonGia_;
			this.ThoiHanBaoHanh = ThoiHanBaoHanh_;
			this.NamSanXuat = NamSanXuat_;
			this.NhaCungCap = NhaCungCap_;
			this.LoaiHang = LoaiHang_;
		}
	}
}
