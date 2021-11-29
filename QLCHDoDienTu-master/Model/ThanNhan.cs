using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class ThanNhan {
		public int IDThanNhan { get; set; }
		public string TenThanNhan { get; set; }
		public string QuanHe { get; set; }
		public string GioiTinh { get; set; }
		public DateTime NgaySinh { get; set; }
		public int IDNhanVien { get; set; }

		public ThanNhan(int IDThanNhan_, string TenThanNhan_, string QuanHe_, string GioiTinh_, DateTime NgaySinh_, int IDNhanVien_) {
			this.IDThanNhan = IDThanNhan_;
			this.TenThanNhan = TenThanNhan_;
			this.QuanHe = QuanHe_;
			this.GioiTinh = GioiTinh_;
			this.NgaySinh = NgaySinh_;
			this.IDNhanVien = IDNhanVien_;
		}
		// liên kết 1-n
		public ICollection<NhanVien> dsnhanvien_thannhan { get; set; }
	}
}
