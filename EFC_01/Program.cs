using EFC_01.IServices;
using EFC_01.Services;

void Main()
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Console.InputEncoding = System.Text.Encoding.UTF8;
    IHocVienServices hocVienService = new HocVienServices();

    Console.WriteLine("------------------------------QUẢN LÝ HỌC VIÊN(EFC-01)------------------------------");
    Console.WriteLine("1. Hiển thị danh sách học viên theo thứ tự ngày đăng ký mới nhất từ trên xuống dưới");
    Console.WriteLine("2. Hiển thị danh sách những học viên sinh năm 2002 và có tên chứa (An)");
    Console.WriteLine("3. Thêm mới 1 học viên");
    Console.WriteLine("4. Cập nhật thông tin học viên");
    Console.WriteLine("5. Xóa học viên");
    Console.WriteLine("6. Thoát chương trình");
    Console.WriteLine();
    string choice;
    do
    {
        Console.WriteLine();
        Console.Write("Chọn chức năng(1-6): ");
        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                hocVienService.HienThiDanhSachHocVienTheoNgayDangKyMoiNhatTuTrenXuong();
                break;
            case "2":
                hocVienService.HienThiDanhSachHocVienTheoNamSinhVaTen();
                break;
            case "3":
                hocVienService.ThemMoiHocVien();
                break;
            case "4":
                hocVienService.CapNhatThongTinHocVien();
                break;
            case "5":
                hocVienService.XoaHocVien();
                break;
            case "6":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                break;
        }
    } while (choice != "6");

}
Main();