using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace QLCHDoDienTu
{
    public class QLCHDoDienTu
    {
        static List<LoaiHang> loaiHangs = new List<LoaiHang>();
        static List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
        static List<CuaHang> cuaHangs = new List<CuaHang>();
        static List<HoaDon> hoaDons = new List<HoaDon>();
        static List<KhachHang> khachHangs = new List<KhachHang>();
        static List<Kho> khos = new List<Kho>();
        static List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
        static List<NhanVien> nhanViens = new List<NhanVien>();
        static List<SanPham> sanPhams = new List<SanPham>();
        static List<ThanNhan> thanNhans = new List<ThanNhan>();
        static CultureInfo ci = new CultureInfo("vi-VN");
        public static void taoDSLoaiHang()
        {
            loaiHangs.Add(new LoaiHang(1, "Laptop"));
            loaiHangs.Add(new LoaiHang(2, "Dien thoai di dong"));
            loaiHangs.Add(new LoaiHang(3, "Tivi"));
            loaiHangs.Add(new LoaiHang(4, "Tu lanh"));
            loaiHangs.Add(new LoaiHang(5, "May giat"));
            loaiHangs.Add(new LoaiHang(6, "May dieu hoa"));
        }
        public static void taoDSNhaCungCap()
        {
            nhaCungCaps.Add(new NhaCungCap(001, "Nha cung cap Hoai Phong", "A24 Cong Quynh, Phuong Nguyen Cu Trinh, Quan 1, Thanh pho Ho Chi Minh", "0925306345", "hoaiphong@gmail.com"));
            nhaCungCaps.Add(new NhaCungCap(002, "Nha cung cap Dien Tu VIP", "151, Duong Nguyen Du, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh", "0936368581", "dienmayVIP@gmail.com"));
            nhaCungCaps.Add(new NhaCungCap(003, "Nha cung cap Techbot", "Kim Giang, Phuong Dai Kim, Quan Hoang Mai, Ha Noi", "0905644699", "techbot@gmail.com"));
            nhaCungCaps.Add(new NhaCungCap(004, "Nha cung cap Intelligent", "So 175 duong Thich Quang Duc, Phuong Chanh Nghia, TP. Thu Dau Mot, Binh Duong.", "0912345678", "intelligent@gmail.com"));
        }
        public static void taoDSSanPham()
        {
            sanPhams.Add(new SanPham(01, "Laptop Asus", 16000000, 1, 2021, nhaCungCaps[0], loaiHangs[0]));
            sanPhams.Add(new SanPham(02, "Macbook", 42900000, 2, 2021, nhaCungCaps[0], loaiHangs[0]));
            sanPhams.Add(new SanPham(03, "Laptop Dell", 10999000, 2, 2020, nhaCungCaps[1], loaiHangs[0]));
            sanPhams.Add(new SanPham(04, "Laptop Lenovo", 18699000, 2, 2021, nhaCungCaps[1], loaiHangs[0]));
            sanPhams.Add(new SanPham(05, "Dien thoai Iphone", 33990000, 2, 2021, nhaCungCaps[0], loaiHangs[1]));
            sanPhams.Add(new SanPham(06, "Dien thoai Samsung", 14990000, 1, 2021, nhaCungCaps[1], loaiHangs[0]));
            sanPhams.Add(new SanPham(07, "Dien thoai Oppo", 19990000, 1, 2021, nhaCungCaps[0], loaiHangs[1]));
            sanPhams.Add(new SanPham(08, "Dien thoai Samsung 1", 5290000, 2, 2020, nhaCungCaps[1], loaiHangs[1]));
            sanPhams.Add(new SanPham(09, "Dien thoai Iphone 1", 32500000, 2, 2020, nhaCungCaps[0], loaiHangs[1]));
            sanPhams.Add(new SanPham(10, "Dien thoai Lenovo", 2600000, 2, 2019, nhaCungCaps[1], loaiHangs[1]));
            sanPhams.Add(new SanPham(11, "Tivi LG", 11200000, 1, 2021, nhaCungCaps[2], loaiHangs[2]));
            sanPhams.Add(new SanPham(12, "Tivi SamSung", 25000000, 2, 2021, nhaCungCaps[2], loaiHangs[2]));
            sanPhams.Add(new SanPham(13, "Tivi Android Sony", 15800000, 2, 2021, nhaCungCaps[2], loaiHangs[2]));
            sanPhams.Add(new SanPham(14, "Tu lanh Sanyo", 4600000, 1, 2021, nhaCungCaps[2], loaiHangs[3]));
            sanPhams.Add(new SanPham(15, "Tu lanh Panasonic", 12500000, 2, 2021, nhaCungCaps[2], loaiHangs[3]));
            sanPhams.Add(new SanPham(16, "Tu lanh Toshiba", 19300000, 2, 2021, nhaCungCaps[3], loaiHangs[3]));
            sanPhams.Add(new SanPham(17, "Tu lanh Sharp", 7500000, 2, 2018, nhaCungCaps[3], loaiHangs[3]));
            sanPhams.Add(new SanPham(18, "May giat Panasonic", 7500000, 2, 2019, nhaCungCaps[2], loaiHangs[4]));
            sanPhams.Add(new SanPham(19, "May giat Toshiba", 10090000, 2, 2018, nhaCungCaps[2], loaiHangs[4]));
            sanPhams.Add(new SanPham(20, "May giat Sharp", 6290000, 2, 2017, nhaCungCaps[2], loaiHangs[4]));
            sanPhams.Add(new SanPham(21, "May dieu hoa Casper", 12950000, 2, 2021, nhaCungCaps[3], loaiHangs[4]));
            sanPhams.Add(new SanPham(22, "May dieu hoa Panasonic", 15960000, 2, 2021, nhaCungCaps[3], loaiHangs[4]));
            sanPhams.Add(new SanPham(23, "May dieu hoa Toshiba", 6800000, 2, 2020, nhaCungCaps[3], loaiHangs[4]));
            sanPhams.Add(new SanPham(24, "May dieu hoa LG", 9490000, 2, 2021, nhaCungCaps[3], loaiHangs[4]));
            sanPhams.Add(new SanPham(25, "Laptop Asus 1", 17000000, 1, 2021, nhaCungCaps[1], loaiHangs[0]));
            sanPhams.Add(new SanPham(26, "May dieu hoa Casper 1", 13000000, 2, 2021, nhaCungCaps[2], loaiHangs[4]));
        }

        public static void taoDSKhachHang()
        {
            DateTime dt1 = new DateTime(1993, 12, 20, 10, 40, 26);
            khachHangs.Add(new KhachHang(0001, "Nguyen Van Nam", "Nam", dt1, "0973144226", "namnv@gmail.com", "215B Mai Xuan Thuong, Phuong 6, Quan 6, Thanh pho Ho Chi Minh"));
            DateTime dt2 = new DateTime(1995, 6, 5, 4, 30, 10);
            khachHangs.Add(new KhachHang(0002, "Le Thi Tuyet", "Nu", dt2, "0941279287", "tuyetlt@gmail.com", "DH409, KP Ba Tri, P, Tan Uyen, Binh Duong"));
            DateTime dt3 = new DateTime(1998, 2, 27, 12, 10, 0);
            khachHangs.Add(new KhachHang(0003, "Nguyen Minh Chien", "Nam", dt3, "0951216329", "chiennm@gmail.com", "65 Tan Huong, Phuong Tan Quy, Quan Tan Phu, TPHCM"));
            DateTime dt4 = new DateTime(2000, 4, 12, 5, 58, 3);
            khachHangs.Add(new KhachHang(0004, "Tran Nguyen Vu", "Nam", dt4, "0978126445", "vutn@gmail.com", "Nguyen Van Luong, Phuong 17, Quan Go Vap, TPHCM"));
            DateTime dt5 = new DateTime(1998, 6, 5, 1, 59, 22);
            khachHangs.Add(new KhachHang(0005, "Nguyen Thi Nga", "Nu", dt5, "0988667889", "ngant@gmail.com", "191 Van Chuong, Phuong Van Chuong, Quan Dong Da, Ha Noi"));
        }
        public static void taoDSCuaHang()
        {
            cuaHangs.Add(new CuaHang(0000001, "245, quan Cau Giay, Ha Noi", "0979796721", "fpt@gmail.com"));
            cuaHangs.Add(new CuaHang(0000002, "123, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh", "0932331414", "tgdd@gmail.com"));
            cuaHangs.Add(new CuaHang(0000003, "226 Phuong Dai Kim, Quan Hoang Mai, Ha Noi", "0928294422", "vuphong@gmail.com"));

        }
        public static void taoDSNhanVien()
        {
            DateTime dt1 = new DateTime(1999, 12, 22, 9, 39, 25);
            DateTime dt2 = new DateTime(2015, 3, 11, 14, 39, 25);
            nhanViens.Add(new NhanVien(000001, "Nguyen Manh Hung", "Nam", dt1, "416 Kim Nguu, Phuong Vinh Tuy, Quan Hai Ba Trung, Ha Noi", dt2, 10000000, cuaHangs[0]));
            DateTime dt3 = new DateTime(2000, 5, 22, 9, 38, 21);
            DateTime dt4 = new DateTime(2016, 4, 12, 10, 50, 21);
            nhanViens.Add(new NhanVien(000002, "Tran Tieu Vy", "Nu", dt3, "123, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minh", dt4, 9000000, cuaHangs[1]));
            DateTime dt5 = new DateTime(2001, 8, 1, 10, 1, 1);
            DateTime dt6 = new DateTime(2018, 11, 2, 3, 5, 3);
            nhanViens.Add(new NhanVien(000003, "Nguyen Manh Son", "Nam", dt5, "416 Kim Nguu, Phuong Vinh Tuy, Quan Hai Ba Trung, Ha Noi", dt6, 11000000, cuaHangs[0]));
            DateTime dt7 = new DateTime(2001, 10, 11, 6, 12, 13);
            DateTime dt8 = new DateTime(2017, 12, 23, 3, 23, 31);
            nhanViens.Add(new NhanVien(000004, "Dinh Bao Long", "Nam", dt7, "456, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minh", dt8, 10500000, cuaHangs[1]));
            DateTime dt9 = new DateTime(2000, 5, 11, 6, 12, 13);
            DateTime dt10 = new DateTime(2017, 7, 21, 3, 25, 5);
            nhanViens.Add(new NhanVien(000005, "To Van Dien", "Nam", dt9, "457, quan Cau Giay, Ha Noi", dt10, 11500000, cuaHangs[2]));
            nhanViens.Add(new NhanVien(000006, "Tran Thi Linh", "Nu", dt5, "124, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minhi", dt6, 11002000, cuaHangs[1]));
            DateTime dt11 = new DateTime(2001, 6, 12, 4, 4, 4);
            DateTime dt12 = new DateTime(2019, 5, 5, 5, 5, 5);
            nhanViens.Add(new NhanVien(000007, "Doan Van Huy", "Nam", dt11, "468, quan Cau Giay, Ha Noi", dt12, 7500000, cuaHangs[2]));
            DateTime dt13 = new DateTime(2000, 7, 7, 7, 7, 7);
            DateTime dt14 = new DateTime(2020, 8, 8, 8, 8, 8);
            nhanViens.Add(new NhanVien(000008, "Doan Van Chien", "Nam", dt13, "468, quan Cau Giay, Ha Noi", dt14, 7600000, cuaHangs[2]));
        }
        public static void taoDSThanNhan()
        {
            DateTime dt1 = new DateTime(1965, 11, 21, 11, 41, 27);
            thanNhans.Add(new ThanNhan(00001, "Nguyen Manh Cuong", "Bo", "Nam", dt1, nhanViens[0]));
            DateTime dt2 = new DateTime(1969, 3, 28, 13, 11, 1);
            thanNhans.Add(new ThanNhan(00002, "Le Thi Hong", "Me", "Nu", dt2, nhanViens[2]));
            DateTime dt3 = new DateTime(1961, 7, 6, 5, 31, 11);
            thanNhans.Add(new ThanNhan(00003, "Tran Hoang Long", "Bo", "Nam", dt3, nhanViens[1]));
            DateTime dt4 = new DateTime(1961, 8, 7, 6, 32, 12);
            thanNhans.Add(new ThanNhan(00004, "Dinh Nguyen Bao", "Bo", "Nam", dt4, nhanViens[3]));
            DateTime dt5 = new DateTime(1954, 5, 13, 6, 59, 4);
            thanNhans.Add(new ThanNhan(00005, "To Ngoc Anh", "Me", "Nu", dt5, nhanViens[4]));
            DateTime dt6 = new DateTime(1955, 6, 14, 2, 59, 2);
            thanNhans.Add(new ThanNhan(00006, "Tran Dang Khoa", "Bo", "Nam", dt6, nhanViens[5]));
            DateTime dt7 = new DateTime(1966, 12, 12, 11, 23, 34);
            thanNhans.Add(new ThanNhan(00007, "Doan Van Chinh", "Bo", "Nam", dt7, nhanViens[6]));
            DateTime dt8 = new DateTime(1968, 10, 10, 11, 23, 34);
            thanNhans.Add(new ThanNhan(00008, "Doan Ngoc Phuong Linh", "Me", "Nu", dt8, nhanViens[7]));
        }
        public static void taoDSKho()
        {
            khos.Add(new Kho(cuaHangs[0], sanPhams[0], 10));
            khos.Add(new Kho(cuaHangs[0], sanPhams[2], 30));
            khos.Add(new Kho(cuaHangs[0], sanPhams[3], 42));
            khos.Add(new Kho(cuaHangs[0], sanPhams[5], 27));
            khos.Add(new Kho(cuaHangs[0], sanPhams[7], 23));
            khos.Add(new Kho(cuaHangs[0], sanPhams[9], 50));
            khos.Add(new Kho(cuaHangs[0], sanPhams[1], 11));
            khos.Add(new Kho(cuaHangs[0], sanPhams[4], 12));
            khos.Add(new Kho(cuaHangs[0], sanPhams[6], 13));
            khos.Add(new Kho(cuaHangs[0], sanPhams[8], 14));
            khos.Add(new Kho(cuaHangs[1], sanPhams[0], 15));
            khos.Add(new Kho(cuaHangs[1], sanPhams[2], 16));
            khos.Add(new Kho(cuaHangs[1], sanPhams[3], 17));
            khos.Add(new Kho(cuaHangs[1], sanPhams[5], 18));
            khos.Add(new Kho(cuaHangs[1], sanPhams[1], 19));
            khos.Add(new Kho(cuaHangs[1], sanPhams[4], 19));
            khos.Add(new Kho(cuaHangs[1], sanPhams[6], 19));
            khos.Add(new Kho(cuaHangs[1], sanPhams[7], 19));
            khos.Add(new Kho(cuaHangs[1], sanPhams[8], 19));
            khos.Add(new Kho(cuaHangs[1], sanPhams[9], 19));
            khos.Add(new Kho(cuaHangs[2], sanPhams[10], 20));
            khos.Add(new Kho(cuaHangs[2], sanPhams[11], 10));
            khos.Add(new Kho(cuaHangs[2], sanPhams[12], 11));
            khos.Add(new Kho(cuaHangs[2], sanPhams[13], 10));
            khos.Add(new Kho(cuaHangs[2], sanPhams[14], 10));
            khos.Add(new Kho(cuaHangs[2], sanPhams[17], 13));
            khos.Add(new Kho(cuaHangs[2], sanPhams[18], 14));
            khos.Add(new Kho(cuaHangs[2], sanPhams[19], 20));
            khos.Add(new Kho(cuaHangs[2], sanPhams[20], 12));
        }
        public static void taoDSHoaDon()
        {
            DateTime dt1 = new DateTime(2021, 12, 22, 9, 39, 25);
            hoaDons.Add(new HoaDon(100, dt1, nhanViens[0], khachHangs[0], cuaHangs[0]));
            DateTime dt2 = new DateTime(2021, 3, 11, 14, 39, 25);
            hoaDons.Add(new HoaDon(101, dt2, nhanViens[2], khachHangs[1], cuaHangs[0]));
            DateTime dt3 = new DateTime(2021, 5, 22, 9, 38, 21);
            hoaDons.Add(new HoaDon(102, dt3, nhanViens[2], khachHangs[2], cuaHangs[0]));
            DateTime dt4 = new DateTime(2021, 6, 12, 12, 00, 00);
            hoaDons.Add(new HoaDon(103, dt4, nhanViens[1], khachHangs[0], cuaHangs[1]));
            DateTime dt5 = new DateTime(2021, 1, 3, 3, 03, 20);
            hoaDons.Add(new HoaDon(104, dt5, nhanViens[1], khachHangs[1], cuaHangs[1]));
            DateTime dt6 = new DateTime(2021, 9, 4, 2, 03, 10);
            hoaDons.Add(new HoaDon(105, dt6, nhanViens[1], khachHangs[4], cuaHangs[1]));
            DateTime dt7 = new DateTime(2021, 10, 4, 2, 04, 10);
            hoaDons.Add(new HoaDon(106, dt7, nhanViens[5], khachHangs[2], cuaHangs[1]));
            DateTime dt8 = new DateTime(2021, 11, 5, 3, 05, 11);
            hoaDons.Add(new HoaDon(107, dt8, nhanViens[3], khachHangs[3], cuaHangs[1]));
            DateTime dt9 = new DateTime(2021, 12, 6, 4, 06, 12);
            hoaDons.Add(new HoaDon(108, dt9, nhanViens[4], khachHangs[4], cuaHangs[2]));
            DateTime dt10 = new DateTime(2021, 1, 7, 5, 07, 13);
            hoaDons.Add(new HoaDon(109, dt10, nhanViens[6], khachHangs[0], cuaHangs[2]));
            DateTime dt11 = new DateTime(2021, 2, 8, 4, 08, 14);
            hoaDons.Add(new HoaDon(110, dt11, nhanViens[6], khachHangs[1], cuaHangs[2]));
        }
        public static void taoDSChiTietHoaDon()
        {
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[6], 2, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[0], 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[1], 5, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[2], 3, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[3], 4, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[4], 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[0], sanPhams[5], 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[0], 2, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[6], 4, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[7], 8, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[8], 9, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[2], 2, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[3], 3, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[4], 1, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[1], sanPhams[5], 2, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[0], 4, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[1], 3, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[2], 6, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[3], 7, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[4], 9, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[5], 10, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[2], sanPhams[6], 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[3], sanPhams[0], 9, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[3], sanPhams[1], 8, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[3], sanPhams[2], 7, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[3], sanPhams[3], 6, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[4], sanPhams[4], 5, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[4], sanPhams[5], 4, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[4], sanPhams[6], 3, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[5], sanPhams[7], 1, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[5], sanPhams[8], 3, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[5], sanPhams[9], 4, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[5], sanPhams[0], 7, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[6], sanPhams[9], 20, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[7], sanPhams[0], 1, 0));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[7], sanPhams[2], 2, 0));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[8], sanPhams[10], 1, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[8], sanPhams[11], 2, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[8], sanPhams[12], 3, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[8], sanPhams[13], 4, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[8], sanPhams[14], 5, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[9], sanPhams[15], 6, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[9], sanPhams[16], 7, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[9], sanPhams[17], 8, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[9], sanPhams[18], 9, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[9], sanPhams[19], 10, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[9], sanPhams[20], 11, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[10], sanPhams[21], 12, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[10], sanPhams[22], 13, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[10], sanPhams[23], 14, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[10], sanPhams[10], 15, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(hoaDons[10], sanPhams[11], 16, 40));
        }
        //// LINQ 1
        //// Đoàn Quốc việt 19110314
        //// Câu 1: Xuất ra thông tin các cửa hàng chỉ bán điện thoại và laptop
        public static void Cau1()
        {
            var onlyPhoneAndLaps =
                from ch in cuaHangs
                join k in khos on ch.IDCuaHang equals k.CuaHang.IDCuaHang
                join sp in sanPhams on k.SanPham.IDSanPham equals sp.IDSanPham
                where sp.IDSanPham >= 1 && sp.IDSanPham <= 10
                group ch by new { ch.IDCuaHang, ch.DiaChi, ch.SDT, ch.Email } into q
                select new { IDCuahang = q.Key.IDCuaHang, Diachi = q.Key.DiaChi, SoDienThoai = q.Key.SDT, Email = q.Key.Email };
            Console.WriteLine("Câu 1: Xuất ra thông tin các cửa hàng chỉ bán điện thoại và laptop");
            foreach (var onlyPhoneAndLap in onlyPhoneAndLaps)
            {
                Console.WriteLine("Cửa hàng có ID:{0}, địa chỉ: {1}, số điện thoại: {2}, email: {3}", onlyPhoneAndLap.IDCuahang, onlyPhoneAndLap.Diachi, onlyPhoneAndLap.SoDienThoai, onlyPhoneAndLap.Email);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // Câu 1 dùng Lambda
        public static void Cau1Lambda()
        {
            Console.WriteLine("Câu 1 Lambda:");
            var onlyPhoneAndLapCuahangs =
                sanPhams
                .Join(
                    khos,
                    i => i.IDSanPham,
                    j => j.SanPham.IDSanPham,
                    (i, j) => new
                    {
                        MaCuaHang = j.CuaHang.IDCuaHang,
                        MaSanPham = j.SanPham.IDSanPham
                    })
                .Join(
                    cuaHangs,
                    i => i.MaCuaHang,
                    j => j.IDCuaHang,
                    (i, j) => new
                    {
                        MaSanPham = i.MaSanPham,
                        MaCuaHang = i.MaCuaHang,
                        DiaChi = j.DiaChi,
                        SDT = j.SDT,
                        Email = j.Email
                    })
                .Where(k => (k.MaSanPham >= 1 && k.MaSanPham <= 10))
                .Select(i => new { i.MaCuaHang, i.DiaChi, i.SDT, i.Email }).Distinct();
            foreach (var onlyPhoneAndLapCuahang in onlyPhoneAndLapCuahangs)
            {
                Console.WriteLine("Cửa hàng có ID:{0}, địa chỉ: {1}, số điện thoại: {2}, email: {3}", onlyPhoneAndLapCuahang.MaCuaHang, onlyPhoneAndLapCuahang.DiaChi, onlyPhoneAndLapCuahang.SDT, onlyPhoneAndLapCuahang.Email);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // Câu 2: Xuất ra thông tin người thân của nhân viên có lương cao nhất
        public static void Cau2()
        {
            var ngThanOfNVLuongCaoNhats =
                from tn in thanNhans
                join nv in nhanViens on tn.NhanVien.IDNhanVien equals nv.IDNhanVien
                where nv.LuongThang == (from b in nhanViens
                                        select b.LuongThang).Max()
                select new { TenThanNhan = tn.TenThanNhan, QuanHe = tn.QuanHe, GioiTinh = tn.GioiTinh, NgaySinh = tn.NgaySinh, TenNhanVien = nv.TenNhanVien };
            Console.WriteLine("Câu 2: Xuất ra thông tin người thân của nhân viên có lương cao nhất");
            foreach (var ngThanOfNVLuongCaoNhat in ngThanOfNVLuongCaoNhats)
            {
                Console.WriteLine("Nhân viên có lương tháng cao nhất tên: {0} có thân nhân: {1}, có quan hệ: {2} với nhân viên, giới tính: {3}, ngày sinh: {4}", ngThanOfNVLuongCaoNhat.TenNhanVien, ngThanOfNVLuongCaoNhat.TenThanNhan, ngThanOfNVLuongCaoNhat.QuanHe, ngThanOfNVLuongCaoNhat.GioiTinh, ngThanOfNVLuongCaoNhat.NgaySinh);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // Câu 2 dùng Lambda
        public static void Cau2Lambda()
        {
            Console.WriteLine("Câu 2 Lambda:");
            var ngThanOfNVLuongCaoNhats =
                nhanViens
                .Join(
                    thanNhans,
                    i => i.IDNhanVien,
                    j => j.NhanVien.IDNhanVien,
                    (i, j) => new
                    {
                        TenThanNhan = j.TenThanNhan,
                        QuanHe = j.QuanHe,
                        GioiTinh = j.GioiTinh,
                        NgaySinh = j.NgaySinh,
                        TenNhanVien = i.TenNhanVien,
                        LuongThang = i.LuongThang
                    })
                .Where(k => k.LuongThang == nhanViens.Select(a => a.LuongThang).Max())
                .Select(i => new { i.TenNhanVien, i.TenThanNhan, i.QuanHe, i.GioiTinh, i.NgaySinh }).Distinct();
            foreach (var ngThanOfNVLuongCaoNhat in ngThanOfNVLuongCaoNhats)
            {
                Console.WriteLine("Nhân viên có lương tháng cao nhất tên: {0} có thân nhân: {1}, có quan hệ: {2} với nhân viên, giới tính: {3}, ngày sinh: {4}", ngThanOfNVLuongCaoNhat.TenNhanVien, ngThanOfNVLuongCaoNhat.TenThanNhan, ngThanOfNVLuongCaoNhat.QuanHe, ngThanOfNVLuongCaoNhat.GioiTinh, ngThanOfNVLuongCaoNhat.NgaySinh);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // câu 3: Sắp xếp thông tin các sản phẩm có giá giảm dần
        public static void Cau3()
        {
            var sapXepGiams =
                from sp in sanPhams
                orderby sp.DonGia descending
                select sp;
            Console.WriteLine("Câu 3: Sắp xếp thông tin các sản phẩm có giá giảm dần");
            foreach (var sapXepGiam in sapXepGiams)
            {
                Console.WriteLine("Tên sản phẩm: {0}, đơn giá: {1} đồng", sapXepGiam.TenSanPham, sapXepGiam.DonGia);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // Câu 3 dùng Lambda
        public static void Cau3Lambda()
        {
            Console.WriteLine("Câu 3 Lamnda:");
            var sapXepGiams =
                sanPhams
                .OrderByDescending(sp => sp.DonGia)
                .Select(i => new { i.TenSanPham, i.DonGia });
            foreach (var sapXepGiam in sapXepGiams)
            {
                Console.WriteLine("Tên sản phẩm: {0}, đơn giá: {1} đồng", sapXepGiam.TenSanPham, sapXepGiam.DonGia);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // câu 4: Xuất ra mã và tên sản phẩm được cung cấp bởi nhà cung cấp Dien Tu VIP và nhà cung cấp Hoai Phong
        public static void Cau4()
        {
            // Bước 1: Tìm thông tin các sản phẩm được cung cấp bởi nhà cung cấp Dien Tu VIP
            var tenMH1s =
                from ncc in nhaCungCaps
                join sp in sanPhams on ncc.IDNhaCungCap equals sp.NhaCungCap.IDNhaCungCap
                where ncc.TenNhaCungCap == "Nha cung cap Dien Tu VIP"
                select new { MaSanPham = sp.IDSanPham, TenSanPham = sp.TenSanPham };

            // Bước 2: Tìm thông tin các sản phẩm được cung cấp bởi nhà cung cấp Hoai Phong
            var tenMH2s =
                from ncc in nhaCungCaps
                join sp in sanPhams on ncc.IDNhaCungCap equals sp.NhaCungCap.IDNhaCungCap
                where ncc.TenNhaCungCap == "Nha cung cap Hoai Phong"
                select new { MaSanPham = sp.IDSanPham, TenSanPham = sp.TenSanPham };

            // Bước 3: Kết hợp cả 2 lại
            var kq = tenMH1s.Concat(tenMH2s);
            Console.WriteLine("Câu 4: Xuất ra mã và tên các sản phẩm được cung cấp bởi nhà cung cấp Dien Tu VIP và nhà cung cấp Hoai Phong");
            foreach (var a in kq)
            {
                Console.WriteLine("Mã sản phẩm: {0}, tên sản phẩm: {1}", a.MaSanPham, a.TenSanPham);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // Câu 4 dùng Lambda
        public static void Cau4Lambda()
        {
            Console.WriteLine("Câu 4 Lambda:");
            var tenMH1s =
                nhaCungCaps
                .Join(
                     sanPhams,
                    i => i.IDNhaCungCap,
                    j => j.NhaCungCap.IDNhaCungCap,
                    (i, j) => new
                    {
                        NhaCungCap = i.TenNhaCungCap,
                        MaSanPham = j.IDSanPham,
                        TenSanPham = j.TenSanPham
                    })
                .Select(i => new { i.MaSanPham, i.TenSanPham, i.NhaCungCap })
                .Where(k => k.NhaCungCap == "Nha cung cap Dien Tu VIP");

            var tenMH2s =
                nhaCungCaps
                .Join(
                     sanPhams,
                    i => i.IDNhaCungCap,
                    j => j.NhaCungCap.IDNhaCungCap,
                    (i, j) => new
                    {
                        NhaCungCap = i.TenNhaCungCap,
                        MaSanPham = j.IDSanPham,
                        TenSanPham = j.TenSanPham
                    })
                .Select(i => new { i.MaSanPham, i.TenSanPham, i.NhaCungCap })
                .Where(k => k.NhaCungCap == "Nha cung cap Hoai Phong");

            var kq = tenMH1s.Concat(tenMH2s);
            foreach (var a in kq)
            {
                Console.WriteLine("Mã sản phẩm: {0}, tên sản phẩm: {1}", a.MaSanPham, a.TenSanPham);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // câu 5: Xuất ra thông tin các loại hàng mà cửa hàng có mã 0000003 bán
        public static void Cau5()
        {
            var LHCuaHang3s =
                (from lh in loaiHangs
                 join sp in sanPhams on lh.IDLoaiHang equals sp.LoaiHang.IDLoaiHang
                 join k in khos on sp.IDSanPham equals k.SanPham.IDSanPham
                 join ch in cuaHangs on k.CuaHang.IDCuaHang equals ch.IDCuaHang
                 where ch.IDCuaHang == 0000003
                 select new { MaLoaiHang = lh.IDLoaiHang, TenLoaiHang = lh.TenLoaiHang }).Distinct();
            Console.WriteLine("Câu 5: Xuất ra thông tin các loại hàng mà cửa hàng có mã 0000003 bán");
            foreach (var a in LHCuaHang3s)
            {
                Console.WriteLine("Mã loại hàng: {0}, tên loại hàng: {1}", a.MaLoaiHang, a.TenLoaiHang);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // Câu 5 dùng lambda
        public static void Cau5Lambda()
        {
            Console.WriteLine("Câu 5 Lambda:");
            var TatCaLHCuahang3s =
                cuaHangs
                .Join(
                    khos,
                    i => i.IDCuaHang,
                    j => j.CuaHang.IDCuaHang,
                    (i, j) => new
                    {
                        MaCuaHang = j.CuaHang.IDCuaHang,
                        MaSanPham = j.SanPham.IDSanPham
                    })
                .Join(
                    sanPhams,
                    i => i.MaSanPham,
                    j => j.IDSanPham,
                    (i, j) => new
                    {
                        MaCuaHang = i.MaCuaHang,
                        MaSanPham = j.IDSanPham,
                        MaLoaiHang = j.LoaiHang.IDLoaiHang
                    })
                .Join(
                    loaiHangs,
                    i => i.MaLoaiHang,
                    j => j.IDLoaiHang,
                    (i, j) => new
                    {
                        MaCuaHang = i.MaCuaHang,
                        MaLoaiHang = j.IDLoaiHang,
                        TenLoaiHang = j.TenLoaiHang
                    })
                .Where(k => k.MaCuaHang == 0000003)
                .Select(i => new { i.MaLoaiHang, i.TenLoaiHang }).Distinct();
            foreach (var TatCaLHCuahang3 in TatCaLHCuahang3s)
            {
                Console.WriteLine("Mã loại hàng: {0}, tên loại hàng: {1}", TatCaLHCuahang3.MaLoaiHang, TatCaLHCuahang3.TenLoaiHang);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // Câu 6: Xuất ra tình trạng bảo hành của từng sản phẩm đến thời điểm hiện tại, sau đó chỉ xuất thông tin của sản phẩm hết hạn bảo hành đầu tiên, thứ hai và cuối cùng
        public static void Cau6()
        {
            Console.WriteLine("Câu 6:  Xuất ra tình trạng bảo hành của từng sản phẩm đến thời điểm hiện tại, sau đó chỉ xuất thông tin của sản phẩm hết hạn bảo hành đầu tiên, thứ hai và cuối cùng");
            Console.WriteLine();
            DateTime now = DateTime.Now;
            int year = now.Year;
            var baoHanhConLais =
                from sp in sanPhams
                select new { MaSanPham = sp.IDSanPham, TenSanPham = sp.TenSanPham, ThoiGianConLai = year - (sp.NamSanXuat + sp.ThoiHanBaoHanh) };
            Console.WriteLine("Danh sách tình trạng bảo hành của tất cả sản phẩm:");
            foreach (var baoHanhConLai in baoHanhConLais)
            {
                if (baoHanhConLai.ThoiGianConLai <= 0)
                {
                    Console.WriteLine("Mã sản phẩm: {0}, tên sản phẩm: {1}, còn thời hạn bảo hành", baoHanhConLai.MaSanPham, baoHanhConLai.TenSanPham);

                }
                else
                    Console.WriteLine("Mã sản phẩm: {0}, tên sản phẩm: {1}, hết hạn bảo hành", baoHanhConLai.MaSanPham, baoHanhConLai.TenSanPham);
            }

            // Sản phẩm hết thời hạn bảo hành đầu tiên trong danh sách
            var dauTien =
                (from bhcl in baoHanhConLais
                 where bhcl.ThoiGianConLai > 0
                 select new { MaSanPham = bhcl.MaSanPham, TenSanPham = bhcl.TenSanPham, bhcl.ThoiGianConLai }).First();
            Console.WriteLine();
            Console.WriteLine("Sản phẩm đầu tiên hết hạn bảo hành có mã sản phẩm: {0}, tên sản phẩm: {1}, hết hạn bảo hành", dauTien.MaSanPham, dauTien.TenSanPham);

            // Sản phẩm hết thời hạn bảo hành thứ hai trong danh sách
            var thuHai =
                 (from bhcl in baoHanhConLais
                  where bhcl.ThoiGianConLai > 0
                  select new { MaSanPham = bhcl.MaSanPham, TenSanPham = bhcl.TenSanPham, bhcl.ThoiGianConLai }).Skip(1).Take(1).Single();
            Console.WriteLine("Sản phẩm thứ hai hết hạn bảo hành có mã sản phẩm: {0}, tên sản phẩm: {1}, hết hạn bảo hành", thuHai.MaSanPham, thuHai.TenSanPham);

            // Sản phẩm hết thời hạn bảo hành cuối cùng trong danh sách
            var cuoiCung =
               (from bhcl in baoHanhConLais
                where bhcl.ThoiGianConLai > 0
                orderby bhcl.MaSanPham descending
                select new { MaSanPham = bhcl.MaSanPham, TenSanPham = bhcl.TenSanPham, bhcl.ThoiGianConLai }).First();
            Console.WriteLine("Sản phẩm cuối cùng hết hạn bảo hành có mã sản phẩm: {0}, tên sản phẩm: {1}, hết hạn bảo hành", cuoiCung.MaSanPham, cuoiCung.TenSanPham);
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // Câu 7: Tìm thông tin sản phẩm bán chậm nhất của cửa hàng 0000002 (ít người mua nhất)
        public static void Cau7()
        {
            // Bước 1: Tìm thông tin của các sản phẩm mà cửa hàng mã 0000002 bán
            var tatCaSPCuaHang2s =
                 from sp in sanPhams
                 join k in khos on sp.IDSanPham equals k.SanPham.IDSanPham
                 join ch in cuaHangs on k.CuaHang.IDCuaHang equals ch.IDCuaHang
                 where ch.IDCuaHang == 0000002
                 group sp by new { sp.IDSanPham, sp.TenSanPham, ch.IDCuaHang } into q
                 select new { MaSanPham = q.Key.IDSanPham, TenSanPham = q.Key.TenSanPham, MaCuaHang = q.Key.IDCuaHang };

            // Bước 2: Đếm số lượng người mua theo mỗi loại sản phẩm của cửa hàng 0000002
            var DemNguoiMuas =
                from a in tatCaSPCuaHang2s
                join hd in hoaDons on a.MaCuaHang equals hd.CuaHang.IDCuaHang
                group a by new { a.TenSanPham, a.MaSanPham } into g
                select new { MaSanPham = g.Key.MaSanPham, TenSanPham = g.Key.TenSanPham, SoNguoiMua = g.Key.TenSanPham.Count() };

            // Bước 3: Tìm sản phẩm có số lượng người mua nhỏ nhất
            var kqs =
                from b in DemNguoiMuas
                where (b.SoNguoiMua == (from c in DemNguoiMuas
                                        select c.SoNguoiMua).Min())
                select new { b.MaSanPham, b.TenSanPham, b.SoNguoiMua };

            Console.WriteLine("Câu 7: Tìm tên sản phẩm bán chậm nhất của cửa hàng 0000002 (ít người mua nhất)");
            foreach (var kq in kqs)
            {
                Console.WriteLine("Mã sản phẩm: {0}, tên sản phẩm: {1}, số người mua: {2}", kq.MaSanPham, kq.TenSanPham, kq.SoNguoiMua);
            }


            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // Câu 8: Tính giá tiền trung bình của mỗi hóa đơn.
        public static void Cau8()
        {
            // Bước 1: Tính giá tiền mỗi mặt hàng trong chi tiết hóa đơn
            var giaTienMoiMatHangs =
                 from cthd in chiTietHoaDons
                 select new { MaDonHang = cthd.HoaDon.IDHoaDon, GiaTien = (cthd.SoLuong * cthd.SanPham.DonGia) - (cthd.SoLuong * cthd.SanPham.DonGia * (cthd.GiamGia / 100)) };

            // Bước 2: Tính tổng tiền của tất cả các hóa đơn
            decimal TongTien = 0;
            foreach (var giaTienMoiMatHang in giaTienMoiMatHangs)
            {
                TongTien += giaTienMoiMatHang.GiaTien;
            }

            // Bước 3: Tính số lượng hóa đơn
            var demSoHoaDons =
                 from hd in hoaDons
                 select hd.IDHoaDon;
            decimal dem = 0;
            foreach (var demSoHoaDon in demSoHoaDons)
            {
                dem++;
            }
            // Bước 4: Tính giá trung bình mỗi hóa đơn
            decimal giaTrungBinhCacHoaDons = TongTien / dem;
            Console.WriteLine("Câu 8: Tính giá tiền trung bình của mỗi hóa đơn");
            Console.WriteLine("Giá tiền trung bình của mỗi hóa đơn là: {0} đồng", Math.Round(giaTrungBinhCacHoaDons));
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // Câu 9: Thông tin tất cả khách hàng được nhân viên có hơn 3 năm kinh nghiệm tính tiền
        public static void Cau9()
        {
            DateTime now = DateTime.Now;
            int year = now.Year;

            // Bước 1: Tính số năm kinh nghiệm của từng nhân viên
            var soNamKNTungNhanViens =
                 from nv in nhanViens
                 select new { MaNhanVien = nv.IDNhanVien, TenNhanVien = nv.TenNhanVien, SoNamKinhNghiem = (year - nv.NgayBatDauLam.Year) };

            // Bước 2: Tìm nhân viên có trên 3 năm kinh nghiệm
            var thongTinNhanVienTren3NamKinhNghiems =
                from snkntnv in soNamKNTungNhanViens
                group snkntnv by new { snkntnv.MaNhanVien, snkntnv.SoNamKinhNghiem, snkntnv.TenNhanVien } into q
                where q.Key.SoNamKinhNghiem > 3
                select new { MaNhanVien = q.Key.MaNhanVien, TenNhanVien = q.Key.TenNhanVien, SoNamKinhNghiem = q.Key.SoNamKinhNghiem };

            // Bước 3: Tìm thông tin khách hàng được nhân viên có trên 3 năm kinh nghiệm tính tiền
            var thongTinKHs =
                 from ttnv3n in thongTinNhanVienTren3NamKinhNghiems
                 join hd in hoaDons on ttnv3n.MaNhanVien equals hd.NhanVien.IDNhanVien
                 join kh in khachHangs on hd.KhachHang.IDKhachHang equals kh.IDKhachHang
                 group kh by new { kh.IDKhachHang, kh.TenKhachHang } into q
                 select new { MaKhachHang = q.Key.IDKhachHang, TenKhachHang = q.Key.TenKhachHang };
            Console.WriteLine("Câu 9: Thông tin tất cả khách hàng được nhân viên có hơn 3 năm kinh nghiệm tính tiền");
            foreach (var thongTinKH in thongTinKHs)
            {
                Console.WriteLine("Khách hàng có mã: {0}, tên là: {1}", thongTinKH.MaKhachHang, thongTinKH.TenKhachHang);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // Câu 10: Kiểm tra xem có nhân viên nào không bán được đơn hàng nào không? Nếu có hạ 50% lương và xuất ra thông tin nhân viên đó
        public static void Cau10()
        {
            Console.WriteLine("Câu 10: Kiểm tra xem có nhân viên nào không bán được đơn hàng nào không? Nếu có hạ 50% lương và xuất ra thông tin nhân viên đó");
            // Bước 1: Kiểm tra xem có nhân viên nào không bán được đơn hàng nào không?
            var kTras =
                (from nv in nhanViens
                 join hd in hoaDons on nv.IDNhanVien equals hd.NhanVien.IDNhanVien
                 group nv by new { nv.IDNhanVien, nv.TenNhanVien } into q
                 select new { MaNhanVien = q.Key.IDNhanVien, TenNhanVien = q.Key.TenNhanVien, SoHoaDon = q.Count() }).All(q => q.SoHoaDon == 0);
            if (kTras == true)
            {
                Console.WriteLine("Tất cả nhân viên đều bán được ít nhất 1 hóa đơn");
            }
            else
            {
                Console.WriteLine("Có nhân viên không bán được hóa đơn nào");
            }

            // Bước 2: Tìm danh sách các nhân viên bán được ít nhất 1 hóa đơn
            var hoaDonNhanViens =
                from nv in nhanViens
                join hd in hoaDons on nv.IDNhanVien equals hd.NhanVien.IDNhanVien
                group nv by new { nv.IDNhanVien, nv.TenNhanVien, nv.LuongThang } into q
                select new { MaNhanVien = q.Key.IDNhanVien, TenNhanVien = q.Key.TenNhanVien, LuongThang = q.Key.LuongThang };

            // Bước 3: Tìm thông tin của toàn bộ nhân viên 
            var infoNhanViens =
                from nv in nhanViens
                select new { MaNhanVien = nv.IDNhanVien, TenNhanVien = nv.TenNhanVien, LuongThang = nv.LuongThang };

            // Bước 4: Tìm thông tin của nhân viên mà không bán được hóa đơn nào
            var koDonHangs = infoNhanViens.Except(hoaDonNhanViens);

            // Bước 5: Hạ 50% lương của nhân viên đó
            var kqs =
                from kdh in koDonHangs
                select new { MaNhanVien = kdh.MaNhanVien, TenNhanVien = kdh.TenNhanVien, LuongBanDau = kdh.LuongThang, HaLuong = kdh.LuongThang * 50 / 100 };

            foreach (var kq in kqs)
            {
                Console.WriteLine("Đó là nhân viên có mã: {0}, tên là: {1}, lương ban đầu: {2} đồng, lương sau khi hạ: {3} đồng", kq.MaNhanVien, kq.TenNhanVien, kq.LuongBanDau, kq.HaLuong);
            }
        }
        // ↓ ↓ ↓ Nguyen Thanh Viet's Section ↓ ↓ ↓
        // 11.	Thông tin các nhà cung cấp có sản phẩm máy giặt.
        public static void Cau11(string tenLoaiHang)
        {

            var query = from nc in nhaCungCaps
                        join sp in sanPhams
                        on nc.IDNhaCungCap equals sp.NhaCungCap.IDNhaCungCap
                        join lh in loaiHangs
                        on sp.LoaiHang.IDLoaiHang equals lh.IDLoaiHang
                        where lh.TenLoaiHang == tenLoaiHang
                        select nc;

            Console.WriteLine("\n11. Thông tin các nhà cung cấp có sản phẩm {0}.", tenLoaiHang);
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in query.Distinct())
            {
                Console.WriteLine("ID: {0} | Ten NCC: {1} | SDT: {2} | Email: {3} | Dia Chi: {4}",
                    n.IDNhaCungCap, n.TenNhaCungCap, n.SDT, n.Email, n.DiaChi);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 11. lambda
        public static void Cau11_lambda(string tenLoaiHang)
        {
            var result = nhaCungCaps
               .Join(
                  sanPhams,
                  nc => nc.IDNhaCungCap,
                  sp => sp.NhaCungCap.IDNhaCungCap,
                  (nc, sp) =>
                     new {
                         NhaCungCap = nc,
                         SanPham = sp
                     }
               )
               .Join(
                  loaiHangs,
                  nc_sp => nc_sp.SanPham.LoaiHang.IDLoaiHang,
                  lh => lh.IDLoaiHang,
                  (nc_sp, lh) =>
                     new {
                         NhaCungCap_SanPham = nc_sp,
                         LoaiHang = lh
                     }
               )
               .Where(n => n.LoaiHang.TenLoaiHang == tenLoaiHang)

               .Select(n => n.NhaCungCap_SanPham.NhaCungCap);

            Console.WriteLine("11. Viet bang lambda");
            Console.WriteLine("---------------------------------------------------------------------");
            result.Distinct().ToList().ForEach(n => Console.WriteLine("ID: {0} | Ten NCC: {1} | SDT: {2} | Email: {3} | Dia Chi: {4}",
                n.IDNhaCungCap, n.TenNhaCungCap, n.SDT, n.Email, n.DiaChi));
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 12. Thông tin sản phẩm là điện thoại có giá > 10tr, sắp xếp tăng dần theo giá thành
        public static void Cau12(string loaiHang, decimal giaTien)
        {

            var query = from sp in sanPhams
                        join lh in loaiHangs
                        on sp.LoaiHang.IDLoaiHang equals lh.IDLoaiHang
                        where lh.TenLoaiHang == loaiHang && sp.DonGia > giaTien
                        orderby sp.DonGia ascending
                        select sp;

            Console.WriteLine("12. Thông tin sản phẩm là {0} có giá > {1}, sắp xếp tăng dần theo giá thành.", loaiHang, giaTien.ToString("C0", ci));
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in query.Distinct())
            {
                Console.WriteLine("ID: {0} | Ten SP: {1} | Don Gia: {2} | Thoi Han Bao Hanh: {3} nam | Nam SX: {4}",
                    n.IDSanPham, n.TenSanPham, n.DonGia.ToString("C0", ci), n.ThoiHanBaoHanh, n.NamSanXuat);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 12. lambda
        public static void Cau12_lambda(string loaiHang, decimal giaTien)
        {
            var result = sanPhams
                .Join(
                    loaiHangs,
                    sp => sp.LoaiHang.IDLoaiHang,
                    lh => lh.IDLoaiHang,
                    (sp, lh) =>
                    new {
                        SanPham = sp,
                        LoaiHang = lh
                    }
                )
                .Where(sp_lh => sp_lh.SanPham.DonGia > giaTien)

                .Where(sp_lh => sp_lh.LoaiHang.TenLoaiHang == loaiHang)

                .OrderBy(sp_lh => sp_lh.SanPham.DonGia)

                .Select(sp_lh => sp_lh.SanPham);

            Console.WriteLine("12. Viet bang lambda.");
            Console.WriteLine("---------------------------------------------------------------------");
            result.ToList().ForEach(n => Console.WriteLine("ID: {0} | Ten SP: {1} | Don Gia: {2} | Thoi Han Bao Hanh: {3} nam | Nam SX: {4}",
                n.IDSanPham, n.TenSanPham, n.DonGia.ToString("C0", ci), n.ThoiHanBaoHanh, n.NamSanXuat));
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 13. Thông tin sản phẩm sắp hết (tổng số lượng trong các kho < 15 sp)
        public static void Cau13(int nail)
        {

            var query = from sp in sanPhams
                        join k in khos
                        on sp.IDSanPham equals k.SanPham.IDSanPham
                        group k.SoLuong by new
                        {
                            sp.IDSanPham,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.ThoiHanBaoHanh,
                            sp.NamSanXuat
                        }
                        into gr
                        select gr;

            var result = from q in query
                         where q.Sum() < nail
                         select q;

            Console.WriteLine("13. Thông tin sản phẩm sắp hết (tổng số lượng trong các kho < {0} sp)", nail);
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in result)
            {
                Console.WriteLine("ID: {0} | Ten SP: {1} | Don Gia: {2} | Thoi Han Bao Hanh: {3} nam | Nam SX: {4} | Tong SL con trong Kho: {5}",
                    n.Key.IDSanPham, n.Key.TenSanPham, n.Key.DonGia.ToString("C0", ci), n.Key.ThoiHanBaoHanh, n.Key.NamSanXuat, n.Sum());
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");

        }

        // 13. lambda
        public static void Cau13_lambda(int nail)
        {
            var result = sanPhams
               .Join(
                  khos,
                  sp => sp.IDSanPham,
                  k => k.SanPham.IDSanPham,
                  (sp, k) =>
                     new {
                         sp = sp,
                         k = k
                     }
               )
               .GroupBy(
                  sp_k =>
                     new {
                         IDSanPham = sp_k.sp.IDSanPham,
                         TenSanPham = sp_k.sp.TenSanPham,
                         DonGia = sp_k.sp.DonGia,
                         ThoiHanBaoHanh = sp_k.sp.ThoiHanBaoHanh,
                         NamSanXuat = sp_k.sp.NamSanXuat
                     },
                  sp_k => sp_k.k.SoLuong
               )
               .Select(gr => gr)

               .Where(gr => gr.Sum() < nail);

            Console.WriteLine("13. Viet bang lambda.");
            Console.WriteLine("---------------------------------------------------------------------");
            result.ToList().ForEach(n => Console.WriteLine("ID: {0} | Ten SP: {1} | Don Gia: {2} | Thoi Han Bao Hanh: {3} nam | Nam SX: {4} | Tong SL con trong Kho: {5}",
                n.Key.IDSanPham, n.Key.TenSanPham, n.Key.DonGia.ToString("C0", ci), n.Key.ThoiHanBaoHanh, n.Key.NamSanXuat, n.Sum()));
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 14. Thông tin 3 nhân viên có lương cao nhất
        public static void Cau14(int num)
        {

            var query = from nv in nhanViens
                        orderby nv.LuongThang descending
                        select nv;

            var result = query.Take(num);

            Console.WriteLine("14. Thông tin {0} nhân viên có lương cao nhất", num);
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in result)
            {
                Console.WriteLine("ID: {0} | Ten: {1} | Luong: {5} | Gioi: {2} | Ngay Sinh: {3} | Ngay Bat Dau Lam Viec: {4} | Dia Chi: {6}",
                    n.IDNhanVien, n.TenNhanVien, n.GioiTinh, n.NgaySinh.ToString("dd/MM/yyyy"), n.NgayBatDauLam.ToString("dd/MM/yyyy"), n.LuongThang.ToString("C0", ci), n.DiaChi);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 14. lambda
        public static void Cau14_lambda(int num)
        {
            var result = nhanViens
                .OrderByDescending(nv => nv.LuongThang)
                .Take(num);

            Console.WriteLine("14. Viet bang lambda.");
            Console.WriteLine("---------------------------------------------------------------------");
            result.ToList().ForEach(n => Console.WriteLine("ID: {0} | Ten: {1} | Luong: {5} | Gioi: {2} | Ngay Sinh: {3} | Ngay Bat Dau Lam Viec: {4} | Dia Chi: {6}",
                n.IDNhanVien, n.TenNhanVien, n.GioiTinh, n.NgaySinh.ToString("dd/MM/yyyy"), n.NgayBatDauLam.ToString("dd/MM/yyyy"), n.LuongThang.ToString("C0", ci), n.DiaChi));
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 15. Thông tin các hoá đơn được lập sau từ tháng 5/2021 đến nay
        public static void Cau15(DateTime date)
        {

            var query = from hd in hoaDons
                        where DateTime.Compare(date, hd.NgayLapHoaDon) <= 0
                        join nv in nhanViens
                        on hd.NhanVien.IDNhanVien equals nv.IDNhanVien
                        join kh in khachHangs
                        on hd.KhachHang.IDKhachHang equals kh.IDKhachHang
                        select new
                        {
                            hd,
                            nv,
                            kh
                        };

            Console.WriteLine("15. Thông tin các hoá đơn được lập sau từ {0} đến nay", date.ToString("dd/MM/yyyy"));
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in query)
            {
                Console.WriteLine("ID: {0} | Ngay Lap Hoa Don {1} | ID Cua Hang: {2} | Khach Mua Hang: {3} | NV Ban Hang: {4}",
                    n.hd.IDHoaDon, n.hd.NgayLapHoaDon.ToString("dd/MM/yyyy"), n.hd.CuaHang.IDCuaHang, n.kh.TenKhachHang, n.nv.TenNhanVien);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 15. lambda
        public static void Cau15_lambda(DateTime date)
        {
            var result = hoaDons
               .Where(hd => (DateTime.Compare(date, hd.NgayLapHoaDon) <= 0))
               .Join(
                  nhanViens,
                  hd => hd.NhanVien.IDNhanVien,
                  nv => nv.IDNhanVien,
                  (hd, nv) =>
                     new {
                         hd = hd,
                         nv = nv
                     }
               )
               .Join(
                  khachHangs,
                  temp0 => temp0.hd.KhachHang.IDKhachHang,
                  kh => kh.IDKhachHang,
                  (temp0, kh) =>
                     new {
                         hd = temp0.hd,
                         nv = temp0.nv,
                         kh = kh
                     }
               );

            Console.WriteLine("15. Viet bang lambda.");
            Console.WriteLine("---------------------------------------------------------------------");
            result.ToList().ForEach(n => Console.WriteLine("ID: {0} | Ngay Lap Hoa Don {1} | ID Cua Hang: {2} | Khach Mua Hang: {3} | NV Ban Hang: {4}",
                n.hd.IDHoaDon, n.hd.NgayLapHoaDon.ToString("dd/MM/yyyy"), n.hd.CuaHang.IDCuaHang, n.kh.TenKhachHang, n.nv.TenNhanVien));
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 16. Thông tin nhân viên bán được tổng số lượng sản phẩm nhiều nhất
        public static void Cau16()
        {

            var query = from nv in nhanViens
                        join hd in hoaDons
                        on nv.IDNhanVien equals hd.NhanVien.IDNhanVien
                        join ct in chiTietHoaDons
                        on hd.IDHoaDon equals ct.HoaDon.IDHoaDon
                        group ct.SoLuong by new
                        {
                            nv.IDNhanVien,
                            nv.TenNhanVien,
                            nv.GioiTinh,
                            nv.NgaySinh,
                            nv.NgayBatDauLam,
                            nv.LuongThang
                        }
                        into gr
                        select gr;

            var result = from qr in query
                         orderby qr.Sum() descending
                         select qr;

            Console.WriteLine("16. Thông tin nhân viên bán được tổng số lượng sản phẩm nhiều nhất.");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in result.Take(1))
            {
                Console.WriteLine("ID: {0} | Ten NV: {1} | Tong So SP Da Ban: {2} | Gioi: {3} | Ngay Sinh: {4} | Luong: {5} | Ngay Bat Dau Lam: {6}",
                    n.Key.IDNhanVien, n.Key.TenNhanVien, n.Sum(), n.Key.GioiTinh, n.Key.NgaySinh.ToString("dd/MM/yyyy"), n.Key.LuongThang.ToString("C0", ci), n.Key.NgayBatDauLam.ToString("dd/MM/yyy"));
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 17. Thông tin 10 sản phẩm bán chạy nhất.
        public static void Cau17(int num)
        {

            var query = from sp in sanPhams
                        join ct in chiTietHoaDons
                        on sp.IDSanPham equals ct.SanPham.IDSanPham
                        group ct.SoLuong by new
                        {
                            sp.IDSanPham,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.ThoiHanBaoHanh,
                            sp.NamSanXuat
                        }
                        into gr
                        select gr;

            var result = from qr in query
                         orderby qr.Sum() descending
                         select qr;

            Console.WriteLine("17. Thông tin {0} sản phẩm bán chạy nhất.", num);
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in result.Take(num))
            {
                Console.WriteLine("ID: {0} | Ten SP: {1} | So Luong Ban: {2} | Don Gia: {3} | Thoi Han Bao Hanh: {4} nam | Nam SX: {5}",
                    n.Key.IDSanPham, n.Key.TenSanPham, n.Sum(), n.Key.DonGia.ToString("C0", ci), n.Key.ThoiHanBaoHanh, n.Key.NamSanXuat);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 18. Tính số tiền lương tháng mỗi cửa hàng cần phải trả cho nhân viên.
        public static void Cau18()
        {
            var query = from ch in cuaHangs
                        join nv in nhanViens
                        on ch.IDCuaHang equals nv.CuaHang.IDCuaHang
                        group nv.LuongThang by new
                        {
                            ch.IDCuaHang,
                            ch.DiaChi,
                            ch.SDT,
                            ch.Email
                        }
                        into gr
                        select gr;

            Console.WriteLine("18. Tính số tiền lương tháng mỗi cửa hàng cần phải trả cho nhân viên.");
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in query)
            {
                Console.WriteLine("ID Cua Hang: {0} | Luong Cua NV: {1} | SDT: {2} | Email {3} | Dia Chi: {4}",
                    n.Key.IDCuaHang, n.Sum().ToString("C0", ci), n.Key.SDT, n.Key.Email, n.Key.DiaChi);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 19. Thông tin sản phẩm và số lượng sp cần phải nhập thêm vào kho để tổng số lượng của mỗi sản phẩm có trong kho là 40.
        public static void Cau19(int num)
        {

            var query = from sp in sanPhams
                        join k in khos
                        on sp.IDSanPham equals k.SanPham.IDSanPham
                        group k.SoLuong by new
                        {
                            sp.IDSanPham,
                            sp.TenSanPham,
                            sp.DonGia,
                            sp.ThoiHanBaoHanh,
                            sp.NamSanXuat
                        }
                        into gr
                        select gr;

            var result = from qr in query
                         where qr.Sum() < num
                         select qr;


            Console.WriteLine("19. Thông tin sản phẩm và số lượng sp cần phải nhập thêm vào kho để tổng số lượng của mỗi sản phẩm có trong kho là {0}.", num);
            Console.WriteLine("---------------------------------------------------------------------");
            foreach (var n in result)
            {
                Console.WriteLine("Can Nhap Them: {5} san pham | ID: {0} | Ten SP: {1} | Don Gia: {2} | Thoi Han Bao Hanh: {3} nam | Nam SX: {4}",
                    n.Key.IDSanPham, n.Key.TenSanPham, n.Key.DonGia.ToString("C0", ci), n.Key.ThoiHanBaoHanh, n.Key.NamSanXuat, num - n.Sum());
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // 20. Tổng doanh thu trong năm 2021
        public static void Cau20(int year)
        {

            decimal doanhThu = 0m;

            var query = from hd in hoaDons
                        where hd.NgayLapHoaDon.Year == year
                        join ct in chiTietHoaDons
                        on hd.IDHoaDon equals ct.HoaDon.IDHoaDon
                        select ct;


            foreach (var sp in query)
            {
                doanhThu += sp.SanPham.DonGia * sp.SoLuong * (100 - sp.GiamGia) / 100;
            }

            Console.WriteLine("20. Tổng doanh thu trong năm {0}.", year);
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Tong doanh thu cua cong ty trong nam {1} la: {0}", doanhThu.ToString("C0", ci), year);
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }

        // ↑ ↑ ↑ Nguyen Thanh Viet's Section ↑ ↑ ↑

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            taoDSLoaiHang();
            taoDSNhaCungCap();
            taoDSKhachHang();
            taoDSCuaHang();
            taoDSSanPham();
            taoDSNhanVien();
            taoDSThanNhan();
            taoDSHoaDon();
            taoDSKho();
            taoDSChiTietHoaDon();

            // Phần bài của Đoàn Quốc Việt
            Console.WriteLine("Bài làm của Đoàn Quốc Việt, mssv: 19110314");
            Console.WriteLine("---------------------------------------------------------------------");
            Cau1();
            Cau1Lambda();
            Cau2();
            Cau2Lambda();
            Cau3();
            Cau3Lambda();
            Cau4();
            Cau4Lambda();
            Cau5();
            Cau5Lambda();
            Cau6();
            Cau7();
            Cau8();
            Cau9();
            Cau10();

            //Nguyen Thanh Viet
            Cau11("May giat");
            Cau11_lambda("May giat");
            Cau12("Dien thoai di dong", 1E7m);
            Cau12_lambda("Dien thoai di dong", 1E7m);
            Cau13(15);
            Cau13_lambda(15);
            Cau14(3);
            Cau14_lambda(3);
            Cau15(new DateTime(2021, 5, 1));
            Cau15_lambda(new DateTime(2021, 5, 1));
            Cau16();
            Cau17(10);
            Cau18();
            Cau19(40);
            Cau20(2021);
            Console.ReadKey();

        }
    }
}