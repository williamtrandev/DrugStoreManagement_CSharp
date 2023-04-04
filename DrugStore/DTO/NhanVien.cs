using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private string sdt;
        private string name;
        private string pass;
        public NhanVien(string sdt, string name, string pass)
        {
            this.sdt = sdt;
            this.name = name;
            this.pass = pass;
        }
        public NhanVien(DataRow row)
        {
            this.SDT = row["SDT"].ToString();
            this.NAME = row["HOTEN"].ToString();
            this.PASS = row["PASS"].ToString();
        }
        public NhanVien()
        {

        }
        public string SDT { get => sdt; set => sdt = value; }
        public string NAME { get => name; set => name = value; }
        public string PASS { get => pass; set => pass = value; }
    }
}
