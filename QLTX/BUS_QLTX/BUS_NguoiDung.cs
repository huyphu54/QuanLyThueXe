using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QLTX;
using DTO_QLTX;

namespace BUS_QLTX
{
    public class BUS_NguoiDung
    {
        DAL_NguoiDung dalNguoiDung = new DAL_NguoiDung();
        public NguoiDung layNguoiDung (string username, string password)
        {
            return dalNguoiDung.layNguoiDung(username, password);   
        }
        public List<NguoiDung> LayDanhSachNguoiDung()
        {
            return dalNguoiDung.LayDanhSachNguoiDung();
        }
        public void ThemNguoiDung(NguoiDung nguoiDung)
        {
            dalNguoiDung.ThemNguoiDung(nguoiDung);
        }
        public void SuaNguoiDung(NguoiDung nguoiDung)
        {
            dalNguoiDung.SuaNguoiDung(nguoiDung);
        }

        public bool XoaNguoiDung(int maNguoiDung)
        {
            return dalNguoiDung.XoaNguoiDung(maNguoiDung); // Gọi phương thức từ lớp DAL để xóa người dùng
        }


    }

}
