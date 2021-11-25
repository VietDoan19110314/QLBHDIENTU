using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCHDoDienTu
{
    public class QLCHDoDienTu
    {
        static LoaiHang[] loaiHangs;
        static ChiTietHoaDon[] chiTietHoaDons;
        static CuaHang[] cuaHangs;
        static HoaDon[] hoaDons;
        static KhachHang[] khachHangs;
        static Kho[] khos;
        static NhaCungCap[] nhaCungCaps;
        static NhanVien[] nhanViens;
        static SanPham[] sanPhams;
        static ThanNhan[] thanNhans;
        public static void taoDSLoaiHang()
        {
            loaiHangs = new LoaiHang[6];
            loaiHangs[0] = new LoaiHang(1, "Laptop");
            loaiHangs[1] = new LoaiHang(2, "Dien thoai di dong");
            loaiHangs[2] = new LoaiHang(3, "Tivi");
            loaiHangs[3] = new LoaiHang(4, "Tu lanh");
            loaiHangs[4] = new LoaiHang(5, "May giat");
            loaiHangs[5] = new LoaiHang(6, "May dieu hoa");
        }
        public static void taoDSSanPham()
        {
            sanPhams = new SanPham[26];
            sanPhams[0] = new SanPham(01, "Laptop Asus", 16000000, 1, 2021, 001, 1);
            sanPhams[1] = new SanPham(01, "Laptop Asus", 15000000, 1, 2021, 002, 1);
            sanPhams[2] = new SanPham(02, "Macbook", 42900000, 2, 2021, 001, 1);
            sanPhams[3] = new SanPham(03, "Laptop Dell", 10999000, 2, 2020, 002, 1);
            sanPhams[4] = new SanPham(04, "Laptop Lenovo", 18699000, 2, 2021, 002, 1);
            sanPhams[5] = new SanPham(05, "Dien thoai Iphone", 33990000, 2, 2021, 001, 2);
            sanPhams[6] = new SanPham(06, "Dien thoai Samsung", 14990000, 1, 2021, 002, 2);
            sanPhams[7] = new SanPham(07, "Dien thoai Oppo", 19990000, 1, 2021, 001, 2);
            sanPhams[8] = new SanPham(08, "Dien thoai Samsung 1", 5290000, 2, 2020, 002, 2);
            sanPhams[9] = new SanPham(09, "Dien thoai Iphone 1", 32500000, 2, 2020, 001, 2);
            sanPhams[10] = new SanPham(10, "Dien thoai Lenovo", 2600000, 2, 2019, 002, 2);
            sanPhams[11] = new SanPham(11, "Tivi LG", 11200000, 1, 2021, 003, 3);
            sanPhams[12] = new SanPham(12, "Tivi SamSung", 25000000, 2, 2021, 003, 3);
            sanPhams[13] = new SanPham(13, "Tivi Android Sony", 15800000, 2, 2021, 003, 3);
            sanPhams[14] = new SanPham(14, "Tu lanh Sanyo", 4600000, 1, 2021, 003, 4);
            sanPhams[15] = new SanPham(15, "Tu lanh Panasonic", 12500000, 2, 2021, 003, 4);
            sanPhams[16] = new SanPham(16, "Tu lanh Toshiba", 19300000, 2, 2021, 004, 4);
            sanPhams[17] = new SanPham(17, "Tu lanh Sharp", 7500000, 2, 2018, 004, 4);
            sanPhams[18] = new SanPham(18, "May giat Panasonic", 7500000, 2, 2019, 003, 5);
            sanPhams[19] = new SanPham(19, "May giat Toshiba", 10090000, 2, 2018, 003, 5);
            sanPhams[20] = new SanPham(20, "May giat Sharp", 6290000, 2, 2017, 003, 5);
            sanPhams[21] = new SanPham(21, "May dieu hoa Casper", 12950000, 2, 2021, 004, 5);
            sanPhams[22] = new SanPham(21, "May dieu hoa Casper", 13000000, 2, 2021, 003, 5);
            sanPhams[23] = new SanPham(22, "May dieu hoa Panasonic", 15960000, 2, 2021, 004, 5);
            sanPhams[24] = new SanPham(23, "May dieu hoa Toshiba", 6800000, 2, 2020, 004, 5);
            sanPhams[25] = new SanPham(24, "May dieu hoa LG", 9490000, 2, 2021, 004, 5);
        }
        public static void taoDSNhaCungCap()
        {
            nhaCungCaps = new NhaCungCap[4];
            nhaCungCaps[0] = new NhaCungCap(001, "Nha cung cap Hoai Phong", "A24 Cong Quynh, Phuong Nguyen Cu Trinh, Quan 1, Thanh pho Ho Chi Minh", "0925306345", "hoaiphong@gmail.com");
            nhaCungCaps[1] = new NhaCungCap(002, "Nha cung cap Dien Tu VIP", "151, Duong Nguyen Du, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh", "0936368581", "dienmayVIP@gmail.com");
            nhaCungCaps[2] = new NhaCungCap(003, "Nha cung cap Techbot", "Kim Giang, Phuong Dai Kim, Quan Hoang Mai, Ha Noi", "0905644699", "techbot@gmail.com");
            nhaCungCaps[3] = new NhaCungCap(004, "Nha cung cap Intelligent", "So 175 duong Thich Quang Duc, Phuong Chanh Nghia, TP. Thu Dau Mot, Binh Duong.", "0912345678", "intelligent@gmail.com");
        }
        public static void taoDSKhachHang()
        {
            khachHangs = new KhachHang[5];
            DateTime dt1 = new DateTime(1993, 12, 20, 10, 40, 26);
            khachHangs[0] = new KhachHang(0001, "Nguyen Van Nam", "Nam", dt1, "0973144226", "namnv@gmail.com", "215B Mai Xuan Thuong, Phuong 6, Quan 6, Thanh pho Ho Chi Minh");
            DateTime dt2 = new DateTime(1995, 6, 5, 4, 30, 10);
            khachHangs[1] = new KhachHang(0002, "Le Thi Tuyet", "Nu", dt2, "0941279287", "tuyetlt@gmail.com", "DH409, KP Ba Tri, P, Tan Uyen, Binh Duong");
            DateTime dt3 = new DateTime(1998, 2, 27, 12, 10, 0);
            khachHangs[2] = new KhachHang(0003, "Nguyen Minh Chien", "Nam", dt3, "0951216329", "chiennm@gmail.com", "65 Tan Huong, Phuong Tan Quy, Quan Tan Phu, TPHCM");
            DateTime dt4 = new DateTime(2000, 4, 12, 5, 58, 3);
            khachHangs[3] = new KhachHang(0004, "Tran Nguyen Vu", "Nam", dt4, "0978126445", "vutn@gmail.com", "Nguyen Van Luong, Phuong 17, Quan Go Vap, TPHCM");
            DateTime dt5 = new DateTime(1998, 6, 5, 1, 59, 22);
            khachHangs[4] = new KhachHang(0005, "Nguyen Thi Nga", "Nu", dt5, "0988667889", "ngant@gmail.com", "191 Van Chuong, Phuong Van Chuong, Quan Dong Da, Ha Noi");
        }
        public static void taoDSThanNhan()
        {
            thanNhans = new ThanNhan[8];
            DateTime dt1 = new DateTime(1965, 11, 21, 11, 41, 27);
            thanNhans[0] = new ThanNhan(00001, "Nguyen Manh Cuong", "Bo", "Nam", dt1, 000001);
            thanNhans[1] = new ThanNhan(00001, "Nguyen Manh Cuong", "Bo", "Nam", dt1, 000003);
            DateTime dt2 = new DateTime(1969, 3, 28, 13, 11, 1);
            thanNhans[2] = new ThanNhan(00002, "Le Thi Hong", "Me", "Nu", dt2, 000001);
            thanNhans[3] = new ThanNhan(00002, "Le Thi Hong", "Me", "Nu", dt2, 000003);
            DateTime dt3 = new DateTime(1961, 7, 6, 5, 31, 11);
            thanNhans[4] = new ThanNhan(00003, "Tran Hoang Long", "Bo", "Nam", dt3, 000002);
            DateTime dt4 = new DateTime(1961, 8, 7, 6, 32, 12);
            thanNhans[5] = new ThanNhan(00004, "Dinh Nguyen Bao", "Bo", "Nam", dt4, 000004);
            DateTime dt5 = new DateTime(1954, 5, 13, 6, 59, 4);
            thanNhans[6] = new ThanNhan(00005, "To Ngoc Anh", "Me", "Nu", dt5, 000005);
            DateTime dt6 = new DateTime(1955, 6, 14, 2, 59, 2);
            thanNhans[6] = new ThanNhan(00006, "Tran Dang Khoa", "Bo", "Nam", dt6, 000006);
            DateTime dt7 = new DateTime(1966, 12, 12, 11, 23, 34);
            thanNhans[6] = new ThanNhan(00007, "Doan Van Chinh", "Bo", "Nam", dt7, 000007);
            thanNhans[7] = new ThanNhan(00007, "Doan Van Chinh", "Bo", "Nam", dt7, 000008);
        }
        public static void taoDSNhanVien()
        {
            nhanViens = new NhanVien[10];
            DateTime dt1 = new DateTime(1999, 12, 22, 9, 39, 25);
            DateTime dt2 = new DateTime(2015, 3, 11, 14, 39, 25);
            nhanViens[0] = new NhanVien(000001, "Nguyen Manh Hung", "Nam", dt1, "416 Kim Nguu, Phuong Vinh Tuy, Quan Hai Ba Trung, Ha Noi", dt2, 10000000, 0000001);
            DateTime dt3 = new DateTime(2000, 5, 22, 9, 38, 21);
            DateTime dt4 = new DateTime(2016, 4, 12, 10, 50, 21);
            nhanViens[1] = new NhanVien(000002, "Tran Tieu Vy", "Nu", dt3, "123, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minh", dt4, 9000000, 0000002);
            DateTime dt5 = new DateTime(2001, 8, 1, 10, 1, 1);
            DateTime dt6 = new DateTime(2018, 11, 2, 3, 5, 3);
            nhanViens[2] = new NhanVien(000003, "Nguyen Manh Son", "Nam", dt5, "416 Kim Nguu, Phuong Vinh Tuy, Quan Hai Ba Trung, Ha Noi", dt6, 11000000, 0000001);
            nhanViens[3] = new NhanVien(000006, "Tran Thi Linh", "Nu", dt5, "124, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minhi", dt6, 11002000, 0000002);
            DateTime dt7 = new DateTime(2001, 10, 11, 6, 12, 13);
            DateTime dt8 = new DateTime(2017, 12, 23, 3, 23, 31);
            nhanViens[4] = new NhanVien(000004, "Dinh Bao Long", "Nam", dt7, "456, Phuong Ben Thanh, Quan 1, tp. Ho Chi Minh", dt8, 10500000, 0000002);
            DateTime dt9 = new DateTime(2000, 5, 11, 6, 12, 13);
            DateTime dt10 = new DateTime(2017, 7, 21, 3, 25, 5);
            nhanViens[5] = new NhanVien(000005, "To Van Dien", "Nam", dt9, "457, quan Cau Giay, Ha Noi", dt10, 11500000, 0000003);
            DateTime dt11 = new DateTime(2001, 6, 12, 4, 4, 4);
            DateTime dt12 = new DateTime(2019, 5, 5, 5, 5, 5);
            nhanViens[6] = new NhanVien(000007, "Doan Van Huy", "Nam", dt11, "468, quan Cau Giay, Ha Noi", dt12, 7500000, 0000003);
            DateTime dt13 = new DateTime(2000, 7, 7, 7, 7, 7);
            DateTime dt14 = new DateTime(2020, 8, 8, 8, 8, 8);
            nhanViens[7] = new NhanVien(000008, "Doan Van Chien", "Nam", dt13, "468, quan Cau Giay, Ha Noi", dt14, 7600000, 0000003); 
        }
        public static void taoDSCuaHang()
        {
            cuaHangs = new CuaHang[3];
            cuaHangs[0] = new CuaHang(0000001, "245, quan Cau Giay, Ha Noi", "0979796721", "fpt@gmail.com");
            cuaHangs[1] = new CuaHang(0000002, "123, Phuong Ben Thanh, Quan 1, Thanh pho Ho Chi Minh", "0932331414", "tgdd@gmail.com");
            cuaHangs[2] = new CuaHang(0000003, "226 Phuong Dai Kim, Quan Hoang Mai, Ha Noi", "0928294422", "vuphong@gmail.com");
           
        }
        public static void taoDSKho()
        {
            khos = new Kho[20];
            khos[0] = new Kho(0000001, 01, 10);
            khos[1] = new Kho(0000001, 02, 11);
            khos[2] = new Kho(0000001, 05, 12);
            khos[3] = new Kho(0000001, 07, 13);
            khos[4] = new Kho(0000001, 09, 14);
            khos[5] = new Kho(0000002, 01, 15);
            khos[6] = new Kho(0000002, 03, 16);
            khos[7] = new Kho(0000002, 04, 17);
            khos[8] = new Kho(0000002, 06, 18);
            khos[9] = new Kho(0000002, 08, 19);
            khos[10] = new Kho(0000002, 10, 19);
            khos[11] = new Kho(0000003, 11, 20);
            khos[12] = new Kho(0000003, 12, 10);
            khos[13] = new Kho(0000003, 13, 11);
            khos[14] = new Kho(0000003, 14, 10);
            khos[15] = new Kho(0000003, 15, 10);
            khos[16] = new Kho(0000003, 18, 13);
            khos[17] = new Kho(0000003, 19, 14);
            khos[18] = new Kho(0000003, 20, 20);
            khos[19] = new Kho(0000003, 21, 12);
        }
        public static void taoDSHoaDon()
        {
            hoaDons = new HoaDon[11];
            DateTime dt1 = new DateTime(2021, 12, 22, 9, 39, 25);
            hoaDons[0] = new HoaDon(100, dt1, 000001, 0001, 0000001);
            DateTime dt2 = new DateTime(2021, 3, 11, 14, 39, 25);
            hoaDons[1] = new HoaDon(101, dt2, 000003, 0002, 0000001);
            DateTime dt3 = new DateTime(2021, 5, 22, 9, 38, 21);
            hoaDons[2] = new HoaDon(102, dt3, 000003, 0003, 0000001);
            DateTime dt4 = new DateTime(2021, 6, 12, 12, 00, 00);
            hoaDons[3] = new HoaDon(103, dt4, 000002, 0001, 0000002);
            DateTime dt5 = new DateTime(2021, 1, 3, 3, 03, 20);
            hoaDons[4] = new HoaDon(104, dt5, 000002, 0002, 0000002);
            DateTime dt6 = new DateTime(2021, 9, 4, 2, 03, 10);
            hoaDons[5] = new HoaDon(105, dt6, 000002, 0005, 0000002);
            DateTime dt7 = new DateTime(2021, 10, 4, 2, 04, 10);
            hoaDons[6] = new HoaDon(106, dt7, 000006, 0003, 0000002);
            DateTime dt8 = new DateTime(2021, 11, 5, 3, 05, 11);
            hoaDons[7] = new HoaDon(107, dt8, 000004, 0004, 0000002);
            DateTime dt9 = new DateTime(2021, 12, 6, 4, 06, 12);
            hoaDons[8] = new HoaDon(108, dt9, 000005, 0005, 0000003);
            DateTime dt10 = new DateTime(2021, 1, 7, 5, 07, 13);
            hoaDons[9] = new HoaDon(109, dt10, 000007, 0001, 0000003);
            DateTime dt11 = new DateTime(2021, 2, 8, 4, 08, 14);
            hoaDons[10] = new HoaDon(110, dt11, 000007, 0002, 0000003);
        }
        public static void taoDSChiTietHoaDon()
        {
            chiTietHoaDons = new ChiTietHoaDon[11];
            chiTietHoaDons[0] = new ChiTietHoaDon(100, 01, 1, 10);
            chiTietHoaDons[1] = new ChiTietHoaDon(101, 02, 1, 20);
            chiTietHoaDons[2] = new ChiTietHoaDon(102, 05, 1, 10);
            chiTietHoaDons[3] = new ChiTietHoaDon(103, 03, 1, 30);
            chiTietHoaDons[4] = new ChiTietHoaDon(104, 06, 1, 10);
            chiTietHoaDons[5] = new ChiTietHoaDon(105, 08, 1, 35);
            chiTietHoaDons[6] = new ChiTietHoaDon(106, 10, 1, 10);
            chiTietHoaDons[7] = new ChiTietHoaDon(107, 01, 1, 0);
            chiTietHoaDons[8] = new ChiTietHoaDon(108, 11, 1, 15);
            chiTietHoaDons[9] = new ChiTietHoaDon(109, 12, 2, 13);
            chiTietHoaDons[10] = new ChiTietHoaDon(110, 13, 3, 40);
        }
        // LINQ 1
        /*public static void hienTatCaLoaiHang()
        {
            var dssanpham_loaihang = loaiHangs.Select(lh => new { lh.IDLoaiHang, lh.TenLoaiHang });
            foreach (var loha in dssanpham_loaihang)
            {
                Console.WriteLine("{0}-{1}", loha.IDLoaiHang, loha.TenLoaiHang);
            }
        }*/
        public static void hienTatCaSanPham()
       {
           var dsloaihang_sanpham = sanPhams.Select(sp => new { sp.IDSanPham, sp.TenSanPham, sp.DonGia, sp.ThoiHanBaoHanh, sp.NamSanXuat, sp.IDNhaCungCap, sp.IDLoaiHang });
           foreach (var saph in dsloaihang_sanpham)
           {
               Console.WriteLine("{0}-{1}", saph.IDSanPham, saph.TenSanPham, saph.DonGia, saph.ThoiHanBaoHanh, saph.NamSanXuat, saph.IDNhaCungCap, saph.IDLoaiHang);
           }
       }
        public static void hienTatCaKhachHang()
        {
            var dshoadon_khachhang = khachHangs.Select(kh => new { kh.IDKhachHang, kh.TenKhachHang, kh.GioiTinh, kh.NgaySinh, kh.SDT, kh.Email, kh.DiaChi });
            foreach (var khha in dshoadon_khachhang)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}-{6}", khha.IDKhachHang, khha.TenKhachHang, khha.GioiTinh, khha.NgaySinh, khha.SDT, khha.Email, khha.DiaChi);
            }
        }
        public static void hienTatCaThanNhan()
        {
            var dsnhanvien_thannhan = thanNhans.Select(tn => new { tn.IDThanNhan, tn.TenThanNhan, tn.QuanHe, tn.GioiTinh, tn.NgaySinh, tn.IDNhanVien });
            foreach (var thnh in dsnhanvien_thannhan)
            {
                Console.WriteLine("{0}-{1}-{2}-{3}-{4}-{5}", thnh.IDThanNhan, thnh.TenThanNhan, thnh.QuanHe, thnh.GioiTinh, thnh.NgaySinh, thnh.IDNhanVien);
            }
        }

        static void Main(string[] args)
        {
            //taoDSLoaiHang();
            //taoDSSanPham();
            //taoDSKhachHang();
            taoDSThanNhan();
            //hienTatCaLoaiHang();
            //hienTatCaSanPham();
            //hienTatCaKhachHang();
            hienTatCaThanNhan();
            Console.ReadKey();
            /*List<ChiTietHoaDon> chiTietHoaDons = new List<ChiTietHoaDon>();
            List<CuaHang> cuaHangs = new List<CuaHang>();
            List<HoaDon> hoaDons = new List<HoaDon>();
            List<KhachHang> khachHangs = new List<KhachHang>();
            List<Kho> khos = new List<Kho>();
            List<LoaiHang> loaiHangs = new List<LoaiHang>();
            List<NhaCungCap> nhaCungCaps = new List<NhaCungCap>();
            List<NhanVien> nhanViens = new List<NhanVien>();
            List<SanPham> sanPhams = new List<SanPham>();
            List<ThanNhan> thanNhans = new List<ThanNhan>();
        }*/
        }
    }
}
