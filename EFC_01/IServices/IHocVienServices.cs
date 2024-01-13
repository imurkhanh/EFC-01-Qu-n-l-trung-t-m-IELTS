using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_01.IServices
{
    public interface IHocVienServices
    {
        void HienThiDanhSachHocVienTheoNgayDangKyMoiNhatTuTrenXuong();
        void HienThiDanhSachHocVienTheoNamSinhVaTen();
        void ThemMoiHocVien();
        void CapNhatThongTinHocVien();
        void XoaHocVien();
    }
}
