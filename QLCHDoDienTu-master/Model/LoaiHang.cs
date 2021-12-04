﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu {
	public class LoaiHang {
		public int IDLoaiHang { get; set; }
		public string TenLoaiHang { get; set; }

		public LoaiHang(LoaiHang lh)
		{
			this.IDLoaiHang = lh.IDLoaiHang;
			this.TenLoaiHang = lh.TenLoaiHang;
		}
		public LoaiHang(int IDLoaiHang_, string TenLoaiHang_) {
			this.IDLoaiHang = IDLoaiHang_;
			this.TenLoaiHang = TenLoaiHang_;
		}
	}
}
