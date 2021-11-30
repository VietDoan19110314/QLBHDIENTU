using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void taoDSLoaiHang()
        {
            loaiHangs.Add(new LoaiHang(1, "Laptop"));
            loaiHangs.Add(new LoaiHang(2, "Dien thoai di dong"));
            loaiHangs.Add(new LoaiHang(3, "Tivi"));
            loaiHangs.Add(new LoaiHang(4, "Tu lanh"));
            loaiHangs.Add(new LoaiHang(5, "May giat"));
            loaiHangs.Add(new LoaiHang(6, "May dieu hoa"));
        }
        public static void taoDSSanPham()
        {
            sanPhams.Add(new SanPham(01, "Laptop Asus", 16000000, 1, 2021, 001, 1));
            sanPhams.Add(new SanPham(25, "Laptop Asus 1", 17000000, 1, 2021, 002, 1));
            sanPhams.Add(new SanPham(02, "Macbook", 42900000, 2, 2021, 001, 1));
            sanPhams.Add(new SanPham(03, "Laptop Dell", 10999000, 2, 2020, 002, 1));
            sanPhams.Add(new SanPham(04, "Laptop Lenovo", 18699000, 2, 2021, 002, 1));
            sanPhams.Add(new SanPham(05, "Dien thoai Iphone", 33990000, 2, 2021, 001, 2));
            sanPhams.Add(new SanPham(06, "Dien thoai Samsung", 14990000, 1, 2021, 002, 2));
            sanPhams.Add(new SanPham(07, "Dien thoai Oppo", 19990000, 1, 2021, 001, 2));
            sanPhams.Add(new SanPham(08, "Dien thoai Samsung 1", 5290000, 2, 2020, 002, 2));
            sanPhams.Add(new SanPham(09, "Dien thoai Iphone 1", 32500000, 2, 2020, 001, 2));
            sanPhams.Add(new SanPham(10, "Dien thoai Lenovo", 2600000, 2, 2019, 002, 2));
            sanPhams.Add(new SanPham(11, "Tivi LG", 11200000, 1, 2021, 003, 3));
            sanPhams.Add(new SanPham(12, "Tivi SamSung", 25000000, 2, 2021, 003, 3));
            sanPhams.Add(new SanPham(13, "Tivi Android Sony", 15800000, 2, 2021, 003, 3));
            sanPhams.Add(new SanPham(14, "Tu lanh Sanyo", 4600000, 1, 2021, 003, 4));
            sanPhams.Add(new SanPham(15, "Tu lanh Panasonic", 12500000, 2, 2021, 003, 4));
            sanPhams.Add(new SanPham(16, "Tu lanh Toshiba", 19300000, 2, 2021, 004, 4));
            sanPhams.Add(new SanPham(17, "Tu lanh Sharp", 7500000, 2, 2018, 004, 4));
            sanPhams.Add(new SanPham(18, "May giat Panasonic", 7500000, 2, 2019, 003, 5));
            sanPhams.Add(new SanPham(19, "May giat Toshiba", 10090000, 2, 2018, 003, 5));
            sanPhams.Add(new SanPham(20, "May giat Sharp", 6290000, 2, 2017, 003, 5));
            sanPhams.Add(new SanPham(21, "May dieu hoa Casper", 12950000, 2, 2021, 004, 5));
            sanPhams.Add(new SanPham(26, "May dieu hoa Casper 1", 13000000, 2, 2021, 003, 5));
            sanPhams.Add(new SanPham(22, "May dieu hoa Panasonic", 15960000, 2, 2021, 004, 5));
            sanPhams.Add(new SanPham(23, "May dieu hoa Toshiba", 6800000, 2, 2020, 004, 5));
            sanPhams.Add(new SanPham(24, "May dieu hoa LG", 9490000, 2, 2021, 004, 5));
        }
        public static void taoDSNhaCungCap()
        {
            nhaCungCaps.Add(new NhaCungCap(001, "Nha cung cap Hoai Phong", "A24 Cong Quynh, Phuong Nguyen Cu Trinh, Quan 1, Thanh pho Ho Chi Minh", "0925306345", "hoaiphong@gmail.com"));
            nhaCungCaps.Add(new NhaCungCap(002, "Nha cung cap Dien Tu VIP", "151, Duong Nguyen Du, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh", "0936368581", "dienmayVIP@gmail.com"));
            nhaCungCaps.Add(new NhaCungCap(003, "Nha cung cap Techbot", "Kim Giang, Phuong Dai Kim, Quan Hoang Mai, Ha Noi", "0905644699", "techbot@gmail.com"));
            nhaCungCaps.Add(new NhaCungCap(004, "Nha cung cap Intelligent", "So 175 duong Thich Quang Duc, Phuong Chanh Nghia, TP. Thu Dau Mot, Binh Duong.", "0912345678", "intelligent@gmail.com"));
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
        public static void taoDSThanNhan()
        {
            DateTime dt1 = new DateTime(1965, 11, 21, 11, 41, 27);
            thanNhans.Add(new ThanNhan(00001, "Nguyen Manh Cuong", "Bo", "Nam", dt1, 000001));
            DateTime dt2 = new DateTime(1969, 3, 28, 13, 11, 1);
            thanNhans.Add(new ThanNhan(00002, "Le Thi Hong", "Me", "Nu", dt2, 000003));
            DateTime dt3 = new DateTime(1961, 7, 6, 5, 31, 11);
            thanNhans.Add(new ThanNhan(00003, "Tran Hoang Long", "Bo", "Nam", dt3, 000002));
            DateTime dt4 = new DateTime(1961, 8, 7, 6, 32, 12);
            thanNhans.Add(new ThanNhan(00004, "Dinh Nguyen Bao", "Bo", "Nam", dt4, 000004));
            DateTime dt5 = new DateTime(1954, 5, 13, 6, 59, 4);
            thanNhans.Add(new ThanNhan(00005, "To Ngoc Anh", "Me", "Nu", dt5, 000005));
            DateTime dt6 = new DateTime(1955, 6, 14, 2, 59, 2);
            thanNhans.Add(new ThanNhan(00006, "Tran Dang Khoa", "Bo", "Nam", dt6, 000006));
            DateTime dt7 = new DateTime(1966, 12, 12, 11, 23, 34);
            thanNhans.Add(new ThanNhan(00007, "Doan Van Chinh", "Bo", "Nam", dt7, 000007));
            DateTime dt8 = new DateTime(1968, 10, 10, 11, 23, 34);
            thanNhans.Add(new ThanNhan(00008, "Doan Ngoc Phuong Linh", "Me", "Nu", dt8, 000008));
        }
        public static void taoDSNhanVien()
        {
            DateTime dt1 = new DateTime(1999, 12, 22, 9, 39, 25);
            DateTime dt2 = new DateTime(2015, 3, 11, 14, 39, 25);
            nhanViens.Add(new NhanVien(000001, "Nguyen Manh Hung", "Nam", dt1, "416 Kim Nguu, Phuong Vinh Tuy, Quan Hai Ba Trung, Ha Noi", dt2, 10000000, 0000001));
            DateTime dt3 = new DateTime(2000, 5, 22, 9, 38, 21);
            DateTime dt4 = new DateTime(2016, 4, 12, 10, 50, 21);
            nhanViens.Add(new NhanVien(000002, "Tran Tieu Vy", "Nu", dt3, "123, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minh", dt4, 9000000, 0000002));
            DateTime dt5 = new DateTime(2001, 8, 1, 10, 1, 1);
            DateTime dt6 = new DateTime(2018, 11, 2, 3, 5, 3);
            nhanViens.Add(new NhanVien(000003, "Nguyen Manh Son", "Nam", dt5, "416 Kim Nguu, Phuong Vinh Tuy, Quan Hai Ba Trung, Ha Noi", dt6, 11000000, 0000001));
            nhanViens.Add(new NhanVien(000006, "Tran Thi Linh", "Nu", dt5, "124, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minhi", dt6, 11002000, 0000002));
            DateTime dt7 = new DateTime(2001, 10, 11, 6, 12, 13);
            DateTime dt8 = new DateTime(2017, 12, 23, 3, 23, 31);
            nhanViens.Add(new NhanVien(000004, "Dinh Bao Long", "Nam", dt7, "456, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minh", dt8, 10500000, 0000002));
            DateTime dt9 = new DateTime(2000, 5, 11, 6, 12, 13);
            DateTime dt10 = new DateTime(2017, 7, 21, 3, 25, 5);
            nhanViens.Add(new NhanVien(000005, "To Van Dien", "Nam", dt9, "457, quan Cau Giay, Ha Noi", dt10, 11500000, 0000003));
            DateTime dt11 = new DateTime(2001, 6, 12, 4, 4, 4);
            DateTime dt12 = new DateTime(2019, 5, 5, 5, 5, 5);
            nhanViens.Add(new NhanVien(000007, "Doan Van Huy", "Nam", dt11, "468, quan Cau Giay, Ha Noi", dt12, 7500000, 0000003));
            DateTime dt13 = new DateTime(2000, 7, 7, 7, 7, 7);
            DateTime dt14 = new DateTime(2020, 8, 8, 8, 8, 8);
            nhanViens.Add(new NhanVien(000008, "Doan Van Chien", "Nam", dt13, "468, quan Cau Giay, Ha Noi", dt14, 7600000, 0000003));
        }
        public static void taoDSCuaHang()
        {
            cuaHangs.Add(new CuaHang(0000001, "245, quan Cau Giay, Ha Noi", "0979796721", "fpt@gmail.com"));
            cuaHangs.Add(new CuaHang(0000002, "123, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh", "0932331414", "tgdd@gmail.com"));
            cuaHangs.Add(new CuaHang(0000003, "226 Phuong Dai Kim, Quan Hoang Mai, Ha Noi", "0928294422", "vuphong@gmail.com"));

        }
        public static void taoDSKho()
        {
            khos.Add(new Kho(0000001, 01, 10));
            khos.Add(new Kho(0000001, 03, 30));
            khos.Add(new Kho(0000001, 04, 42));
            khos.Add(new Kho(0000001, 06, 27));
            khos.Add(new Kho(0000001, 08, 23));
            khos.Add(new Kho(0000001, 10, 50));
            khos.Add(new Kho(0000001, 02, 11));
            khos.Add(new Kho(0000001, 05, 12));
            khos.Add(new Kho(0000001, 07, 13));
            khos.Add(new Kho(0000001, 09, 14));
            khos.Add(new Kho(0000002, 01, 15));
            khos.Add(new Kho(0000002, 03, 16));
            khos.Add(new Kho(0000002, 04, 17));
            khos.Add(new Kho(0000002, 06, 18));
            khos.Add(new Kho(0000002, 02, 19));
            khos.Add(new Kho(0000002, 05, 19));
            khos.Add(new Kho(0000002, 07, 19));
            khos.Add(new Kho(0000002, 08, 19));
            khos.Add(new Kho(0000002, 09, 19));
            khos.Add(new Kho(0000002, 10, 19));
            khos.Add(new Kho(0000003, 11, 20));
            khos.Add(new Kho(0000003, 12, 10));
            khos.Add(new Kho(0000003, 13, 11));
            khos.Add(new Kho(0000003, 14, 10));
            khos.Add(new Kho(0000003, 15, 10));
            khos.Add(new Kho(0000003, 18, 13));
            khos.Add(new Kho(0000003, 19, 14));
            khos.Add(new Kho(0000003, 20, 20));
            khos.Add(new Kho(0000003, 21, 12));
        }
        public static void taoDSHoaDon()
        {
            DateTime dt1 = new DateTime(2021, 12, 22, 9, 39, 25);
            hoaDons.Add(new HoaDon(100, dt1, 000001, 0001, 0000001));
            DateTime dt2 = new DateTime(2021, 3, 11, 14, 39, 25);
            hoaDons.Add(new HoaDon(101, dt2, 000003, 0002, 0000001));
            DateTime dt3 = new DateTime(2021, 5, 22, 9, 38, 21);
            hoaDons.Add(new HoaDon(102, dt3, 000003, 0003, 0000001));
            DateTime dt4 = new DateTime(2021, 6, 12, 12, 00, 00);
            hoaDons.Add(new HoaDon(103, dt4, 000002, 0001, 0000002));
            DateTime dt5 = new DateTime(2021, 1, 3, 3, 03, 20);
            hoaDons.Add(new HoaDon(104, dt5, 000002, 0002, 0000002));
            DateTime dt6 = new DateTime(2021, 9, 4, 2, 03, 10);
            hoaDons.Add(new HoaDon(105, dt6, 000002, 0005, 0000002));
            DateTime dt7 = new DateTime(2021, 10, 4, 2, 04, 10);
            hoaDons.Add(new HoaDon(106, dt7, 000006, 0003, 0000002));
            DateTime dt8 = new DateTime(2021, 11, 5, 3, 05, 11);
            hoaDons.Add(new HoaDon(107, dt8, 000004, 0004, 0000002));
            DateTime dt9 = new DateTime(2021, 12, 6, 4, 06, 12);
            hoaDons.Add(new HoaDon(108, dt9, 000005, 0005, 0000003));
            DateTime dt10 = new DateTime(2021, 1, 7, 5, 07, 13);
            hoaDons.Add(new HoaDon(109, dt10, 000007, 0001, 0000003));
            DateTime dt11 = new DateTime(2021, 2, 8, 4, 08, 14);
            hoaDons.Add(new HoaDon(110, dt11, 000007, 0002, 0000003));
        }
        public static void taoDSChiTietHoaDon()
        {
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 07, 2, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 01, 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 02, 5, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 03, 3, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 04, 4, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 05, 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(100, 06, 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 01, 2, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 07, 4, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 08, 8, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 09, 9, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 03, 2, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 04, 3, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 05, 1, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(101, 06, 2, 20));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 01, 4, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 02, 3, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 03, 6, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 04, 7, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 05, 9, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 06, 10, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(102, 07, 1, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(103, 01, 9, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(103, 02, 8, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(103, 03, 7, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(103, 04, 6, 30));
            chiTietHoaDons.Add(new ChiTietHoaDon(104, 05, 5, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(104, 06, 4, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(104, 07, 3, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(105, 08, 1, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(105, 09, 3, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(105, 10, 4, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(105, 01, 7, 35));
            chiTietHoaDons.Add(new ChiTietHoaDon(106, 10, 20, 10));
            chiTietHoaDons.Add(new ChiTietHoaDon(107, 01, 1, 0));
            chiTietHoaDons.Add(new ChiTietHoaDon(107, 03, 2, 0));
            chiTietHoaDons.Add(new ChiTietHoaDon(108, 11, 1, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(108, 12, 2, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(108, 13, 3, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(108, 14, 4, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(108, 15, 5, 15));
            chiTietHoaDons.Add(new ChiTietHoaDon(109, 16, 6, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(109, 17, 7, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(109, 18, 8, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(109, 19, 9, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(109, 20, 10, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(109, 21, 11, 13));
            chiTietHoaDons.Add(new ChiTietHoaDon(110, 22, 12, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(110, 23, 13, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(110, 24, 14, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(110, 11, 15, 40));
            chiTietHoaDons.Add(new ChiTietHoaDon(110, 12, 16, 40));
        }
        // LINQ 1
        // Đoàn Quốc việt 19110314
        // Câu 1: Xuất ra thông tin các cửa hàng chỉ bán điện thoại và laptop
        public static void Cau1()
        {
            var onlyPhoneAndLaps =
                from ch in cuaHangs
                join k in khos on ch.IDCuaHang equals k.IDCuaHang
                join sp in sanPhams on k.IDSanPham equals sp.IDSanPham
                where sp.IDSanPham >= 1 && sp.IDSanPham <= 10
                group ch by new { ch.IDCuaHang, ch.DiaChi, ch.SDT, ch.Email } into q
                select new { IDCuahang = q.Key.IDCuaHang, Diachi = q.Key.DiaChi, SoDienThoai = q.Key.SDT, Email = q.Key.Email };
            Console.WriteLine("Bài làm của Đoàn Quốc Việt, mssv: 19110314");
            Console.WriteLine("---------------------------------------------------------------------");
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
            var onlyPhoneAndLapCuahangs =
                sanPhams
                .Join(
                    khos,
                    i => i.IDSanPham,
                    j => j.IDSanPham,
                    (i, j) => new
                    {
                        MaCuaHang = j.IDCuaHang,
                        MaSanPham = j.IDSanPham
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
                join nv in nhanViens on tn.IDNhanVien equals nv.IDNhanVien
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
            var ngThanOfNVLuongCaoNhats =
                nhanViens
                .Join(
                    thanNhans,
                    i => i.IDNhanVien,
                    j => j.IDNhanVien,
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
                Console.WriteLine("Tên sản phẩm: {0}, đơn giá: {1}", sapXepGiam.TenSanPham, sapXepGiam.DonGia);
            }

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // Câu 3 dùng Lambda
        public static void Cau3Lambda()
        {
            var sapXepGiams =
                sanPhams
                .OrderByDescending(sp => sp.DonGia)
                .Select(i => new { i.TenSanPham, i.DonGia });
            foreach (var sapXepGiam in sapXepGiams)
            {
                Console.WriteLine("Tên sản phẩm: {0}, đơn giá: {1}", sapXepGiam.TenSanPham, sapXepGiam.DonGia);
            }
            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        // câu 4: Xuất ra mã và tên sản phẩm được cung cấp bởi nhà cung cấp Dien Tu VIP và nhà cung cấp Hoai Phong
        public static void Cau4()
        {
            var tenMH1s =
                from ncc in nhaCungCaps
                join sp in sanPhams on ncc.IDNhaCungCap equals sp.IDNhaCungCap
                where ncc.TenNhaCungCap == "Nha cung cap Dien Tu VIP"
                select new { MaSanPham = sp.IDSanPham, TenSanPham = sp.TenSanPham };
            var tenMH2s =
                from ncc in nhaCungCaps
                join sp in sanPhams on ncc.IDNhaCungCap equals sp.IDNhaCungCap
                where ncc.TenNhaCungCap == "Nha cung cap Hoai Phong"
                select new { MaSanPham = sp.IDSanPham, TenSanPham = sp.TenSanPham };
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
            var tenMH1s =
                nhaCungCaps
                .Join(
                     sanPhams,
                    i => i.IDNhaCungCap,
                    j => j.IDNhaCungCap,
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
                    j => j.IDNhaCungCap,
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
                 join sp in sanPhams on lh.IDLoaiHang equals sp.IDLoaiHang
                 join k in khos on sp.IDSanPham equals k.IDSanPham
                 join ch in cuaHangs on k.IDCuaHang equals ch.IDCuaHang
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
            var TatCaLHCuahang3s =
                cuaHangs
                .Join(
                    khos,
                    i => i.IDCuaHang,
                    j => j.IDCuaHang,
                    (i, j) => new
                    {
                        MaCuaHang = j.IDCuaHang,
                        MaSanPham = j.IDSanPham
                    })
                .Join(
                    sanPhams,
                    i => i.MaSanPham,
                    j => j.IDSanPham,
                    (i, j) => new
                    {
                        MaCuaHang = i.MaCuaHang,
                        MaSanPham = j.IDSanPham,
                        MaLoaiHang = j.IDLoaiHang
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
        }           
        // Câu 6: Tìm tên sản phẩm bán chậm nhất của cửa hàng 0000002 (ít người mua nhất)
        public static void Cau6()
        {
            // Bước 1: Tìm tên tất cả các sản phẩm mà cửa hàng mã 0000002 bán
            var AllCuaHang2s =
                 from sp in sanPhams
                 join k in khos on sp.IDSanPham equals k.IDSanPham
                 join ch in cuaHangs on k.IDCuaHang equals ch.IDCuaHang
                 where ch.IDCuaHang == 0000002
                 select new { MaSanPham = sp.IDSanPham, TenSanPham = sp.TenSanPham };
            Console.WriteLine("Câu 5: Xuất ra thông tin các loại hàng mà cửa hàng có mã 0000003 bán");
           

            Console.WriteLine("---------------------------------------------------------------------" + "\n");
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            taoDSLoaiHang();
            taoDSSanPham();
            taoDSKhachHang();
            taoDSThanNhan();
            taoDSChiTietHoaDon();
            taoDSCuaHang();
            taoDSHoaDon();
            taoDSKho();
            taoDSNhaCungCap();
            taoDSNhanVien();

            // Phần bài của Đoàn Quốc Việt
            //Cau1();
            //Cau1Lambda();
            //Cau2();
            //Cau2Lambda();
            //Cau3();
            //Cau3Lambda();
            Cau4();
            Cau4Lambda();
            //Cau5();
            //Cau5Lambda();
            Console.ReadKey();

        }
    }
}