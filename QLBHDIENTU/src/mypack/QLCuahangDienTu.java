package mypack;

import java.util.ArrayList;
import java.util.List;

public class QLCuahangDienTu {
	public static List<LoaiHang> dsLoaiHang = new ArrayList<>();
	public static List<NhaCungCap> dsnhacungcap = new ArrayList<>();
	public static List<SanPham> dsSanPham = new ArrayList<>();
	public static List<LoaiHang> createDSLoaiHang() {
		dsLoaiHang.add(
				new LoaiHang(
						1,
						"Laptop"));
		dsLoaiHang.add(
				new LoaiHang(
						2,		
						"Dien thoai di dong"));
		dsLoaiHang.add(
				new LoaiHang(
						3,		
						"Tivi"));
		dsLoaiHang.add(
				new LoaiHang(
						4,		
						"Tu lanh"));
		dsLoaiHang.add(
				new LoaiHang(
						5,		
						"May giat"));
		dsLoaiHang.add(
				new LoaiHang(
						6,		
						"May dieu hoa"));

		return dsLoaiHang;
	}
	public static List<NhaCungCap> createDSNhaCungCap() {
		dsnhacungcap.add(
				new NhaCungCap(
						1,
						"Nha cung cap Hoai Phong",
						"A24 Cong Quynh, Phuong Nguyen Cu Trinh, Quan 1, Thanh pho Ho Chi Minh",
						"0925306345",
						"hoaiphong@gmail.com"));
		dsnhacungcap.add(
				new NhaCungCap(
						2,
						"Nha cung cap Dien Tu VIP",
						"151, Duong Nguyen Du, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh",
						"0936368581",
						"dienmayVIP@gmail.com"));
		dsnhacungcap.add(
				new NhaCungCap(
						3,
						"Nha cung cap Techbot",
						"Kim Giang, Phuong Dai Kim, Quan Hoang Mai, Ha Noi",
						"0905644699",
						"techbot@gmail.com"));
		dsnhacungcap.add(
				new NhaCungCap(
						4,
						"Nha cung cap Intelligent",
						"So 175 duong Thich Quang Duc, Phuong Chanh Nghia, TP. Thu Dau Mot, Binh Duong.",
						"0912345678",
						"intelligent@gmail.com"));
		return dsnhacungcap;
	}

	public static List<SanPham> createDSSanPham() {
		dsSanPham.add(
				new SanPham(
						1,
						"Laptop Asus",
						16000000,
						1,
						2021,
						dsnhacungcap.get(0),
						dsLoaiHang.get(0)
						));



		return dsSanPham;
	}

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		createDSLoaiHang();
		createDSNhaCungCap();
		createDSSanPham();
	}

}
