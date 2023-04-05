using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapHang
    {
        private string maphieu;
        private string ngaylap;
        private float tonggianhap;

        public PhieuNhapHang(string maphieu, string ngaylap, float tonggianhap)
        {
            this.maphieu = maphieu;
            this.ngaylap = ngaylap;
            this.tonggianhap = tonggianhap;
        }

        public string Maphieu { get => maphieu; set => maphieu = value; }
        public string Ngaylap { get => ngaylap; set => ngaylap = value; }
        public float Tonggianhap { get => tonggianhap; set => tonggianhap = value; }
    }
}
