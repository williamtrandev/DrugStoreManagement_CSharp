using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class Thuoc
    {
        private string sodk;
        private string tenthuoc;
        private string hoatchat;
        private string donvitinh;
        private string quycachdonggoi;
        private float gianhap;
        private float giaban;
        public Thuoc(string sodk, string tenthuoc, string hoatchat, string donvitinh, string quycachdonggoi, float gianhap, float giaban)
        {
            this.sodk = sodk;
            this.tenthuoc = tenthuoc;
            this.hoatchat = hoatchat;
            this.donvitinh= donvitinh;
            this.quycachdonggoi = quycachdonggoi;
            this.gianhap = gianhap;
            this.giaban = giaban;
        }
        public Thuoc(DataRow row)
        {
            this.SODK = row["SODK"].ToString();
            this.TENTHUOC = row["TENTHUOC"].ToString();
            this.HOATCHAT = row["HOATCHAT"].ToString();
            this.DONVITINH = row["DONVITINH"].ToString();
            this.QUYCACHDONGGOI = row["QUYCACHDONGGOI"].ToString();
            this.GIANHAP = (float)row["GIANHAP"];
            this.GIABAN = (float)row["GIABAN"];

        }
        public Thuoc()
        {

        }
        public string SODK { get => sodk; set => sodk = value; }
        public string TENTHUOC { get => tenthuoc; set => tenthuoc = value; }
        public string HOATCHAT { get => hoatchat; set => hoatchat = value; }
        public string DONVITINH { get => donvitinh; set => donvitinh = value; }
        public string QUYCACHDONGGOI { get => quycachdonggoi; set => quycachdonggoi = value; }
        public float GIANHAP { get => gianhap; set => gianhap = value; }
        public float GIABAN { get => giaban; set => giaban = value; }
    }

}
