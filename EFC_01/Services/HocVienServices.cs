using EFC_01.Entity;
using EFC_01.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01.Services
{
    public class HocVienServices : IHocVienServices
    {
        private readonly AppDbContext dbContext;
        public HocVienServices()
        {
            dbContext = new AppDbContext();
        }

        public void CapNhatThongTinHocVien()
        {
            Console.WriteLine("----Cập nhập thông tin học viên----");
            Console.WriteLine("Nhập ID học viên cần cập nhật");
            int hocVienId = int.Parse(Console.ReadLine());

            var hocVien = dbContext.HocVien.Find(hocVienId);
            if(hocVien == null)
            {
                Console.WriteLine("Học viên không tồn tại");
            }
            else
            {
                Console.Write("Họ tên mới: ");
                string hoTen = Console.ReadLine();
                Console.Write("Email mới: ");
                string email = Console.ReadLine();
                Console.Write("SĐT mới: ");
                string sĐT = Console.ReadLine();
                Console.Write("Địa chỉ mới: ");
                string diaChi = Console.ReadLine();
                Console.Write("Lớp mới: ");
                string lop = Console.ReadLine();

                hocVien.HoTen = hoTen;
                hocVien.Email = email;
                hocVien.SĐT = sĐT;
                hocVien.DiaChi = diaChi;
                hocVien.Lop = lop;
                dbContext.SaveChanges();
                Console.WriteLine("Cập nhập thông tin học viên thành công");
            }
        }

        public void HienThiDanhSachHocVienTheoNamSinhVaTen()
        {
            var danhSachHocVien = dbContext.HocVien.Where(x => x.NgaySinh.Year == 2002 && x.HoTen.Contains("An")).ToList();
            if(danhSachHocVien == null)
            {
                Console.WriteLine("Không có học viên sinh năm 2002 và họ tên có chứa (An) ");
            }
            else
            {
                Console.WriteLine("----Danh sách học viên sinh năm 2002 và họ tên có chứa (An)----");
                foreach(var hocVien in danhSachHocVien)
                {
                    Console.WriteLine($"Họ tên: {hocVien.HoTen}");
                    Console.WriteLine($"Năm sinh: {hocVien.NgaySinh.Year}");
                }                
            }
        }

        public void HienThiDanhSachHocVienTheoNgayDangKyMoiNhatTuTrenXuong()
        {
            var danhSachHocVien = dbContext.HocVien.OrderByDescending(x=>x.NgayDangKy).ToList();
            if(danhSachHocVien == null )
            {
                Console.WriteLine("Chưa có học viên đăng ký");
            }    
            else
            {
                Console.WriteLine("----Danh sách học viên theo ngay đăng ký mới nhất----");
                foreach(var hocVien in danhSachHocVien)
                {
                    Console.WriteLine($"Họ tên: {hocVien.HoTen}");
                    Console.WriteLine($"Ngày đăng ký: {hocVien.NgayDangKy}");
                }    
            }
        }

        public void ThemMoiHocVien()
        {
            Console.WriteLine("----Thêm mới học viên----");
            Console.Write("Họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Ngày sinh:(dd/mm/yyyy) ");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Giới tính: ");
            string gioiTinh = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("SĐT: ");
            string sĐT = Console.ReadLine();
            Console.Write("Địa chỉ: ");
            string diaChi = Console.ReadLine();
            Console.Write("Trình độ hiện tại: ");
            string trinhDoHienTai = Console.ReadLine();
            Console.Write("Lớp: ");
            string lop = Console.ReadLine();
            Console.Write("Ngày đăng ký:(dd/mm/yyyy) ");
            DateTime ngayDangKy = DateTime.Parse(Console.ReadLine());

            var hocVien = new HocVien
            {
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                Email = email,
                SĐT = sĐT,
                DiaChi = diaChi,
                TrinhDoHienTai = trinhDoHienTai,
                Lop = lop,
                NgayDangKy =ngayDangKy,
            };
            dbContext.Add(hocVien);
            dbContext.SaveChanges();
            Console.WriteLine("Thêm mới học viên thành công");
        }

        public void XoaHocVien()
        {
            Console.WriteLine("----Xóa học viên----");
            Console.WriteLine("Nhập ID học viên cần xóa");
            int hocVienId = int.Parse(Console.ReadLine());
            var hocVien = dbContext.HocVien.Find(hocVienId);
            if(hocVien == null)
            {
                Console.WriteLine("Học viên không tồn tại");
            }
            else
            {
                dbContext.HocVien.Remove(hocVien);
                dbContext.SaveChanges();
                Console.WriteLine("Xóa học viên thành công");
            }
        }
    }
}
