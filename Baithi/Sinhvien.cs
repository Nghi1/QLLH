using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi
{
    [Serializable]
    class Sinhvien
    {
        public string MaSinhvien;
        public string HoTen;
        public string NamSinh;
        public string DiaChi;
        public string NganhHoc;
        public string LopDangHoc;
        public Sinhvien()
        {

            MaSinhvien = "";
            HoTen = "";
            NamSinh = "";
            DiaChi = "";
            NganhHoc = "";
            LopDangHoc = "";
        }
        public Sinhvien(string Msv, string ten, string nam, string Dchi, string Nganh, string Ldanghoc)
        {

            MaSinhvien = Msv;
            HoTen = ten;
            NamSinh = nam;
            DiaChi = Dchi;
            NganhHoc = Nganh;
            LopDangHoc = Ldanghoc;
        }
    }
}
