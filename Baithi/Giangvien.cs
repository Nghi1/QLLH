using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baithi
{
    [Serializable]
    class Giangvien
    {
        public string MaGiangvien;
        public string TenGiangvien;
        public string ChuyenNganh;
        public string TrinhDo;
        public string LopDangGiang;
        public Giangvien()
        {

            MaGiangvien = "";
            TenGiangvien = "";
            ChuyenNganh = "";
            TrinhDo = "";
            LopDangGiang = "";
        }
        public Giangvien(string MaGV, string TenGV, string CN, string TD, string LDG)
        {

            MaGiangvien = MaGV;
            TenGiangvien = TenGV;
            ChuyenNganh = CN;
            TrinhDo = TD;
            LopDangGiang = LDG;
        }
    }
}
