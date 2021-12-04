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
		public NhanVien NhanVien { get; set; }

		public ThanNhan(ThanNhan tn)
		{
			this.IDThanNhan = tn.IDThanNhan;
			this.TenThanNhan = tn.TenThanNhan;
			this.QuanHe = tn.QuanHe;
			this.GioiTinh = tn.GioiTinh;
			this.NgaySinh = tn.NgaySinh;
			this.NhanVien = tn.NhanVien;
		}

		public ThanNhan(int IDThanNhan_, string TenThanNhan_, string QuanHe_, string GioiTinh_, DateTime NgaySinh_, NhanVien NhanVien_) {
			this.IDThanNhan = IDThanNhan_;
			this.TenThanNhan = TenThanNhan_;
			this.QuanHe = QuanHe_;
			this.GioiTinh = GioiTinh_;
			this.NgaySinh = NgaySinh_;
			this.NhanVien = NhanVien_;
		}
	}
}
