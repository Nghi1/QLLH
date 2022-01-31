using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi
{
    [Serializable]
    class Lophoc
    {

        public string MaLop;
        public string TenLop;
        public string Khoa;
        public string NghanhHoc;
        public string MonHoc;
        public string HocKy;
        public string GiangVien;
        public string SoluongSinhvien;
        public Lophoc()
        {

            MaLop = "";
            TenLop = "";
            Khoa = "";
            NghanhHoc = "";
            MonHoc = "";
            HocKy = "";
            GiangVien = "";
            SoluongSinhvien = "";
        }
        public Lophoc(string Mlop, string Tlop, string Kh, string Nganh, string Mon, string HKy, string Gvien, string SlSinhvien)
        {

            MaLop = Mlop;
            TenLop = Tlop;
            Khoa = Kh;
            NghanhHoc = Nganh;
            MonHoc = Mon;
            HocKy = HKy;
            GiangVien = Gvien;
            SoluongSinhvien = SlSinhvien;
        }
    }
}
