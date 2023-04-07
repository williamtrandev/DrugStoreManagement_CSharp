using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        private string mancc;
        private string tenncc;

        public NhaCungCap(string mancc, string tenncc)
        {
            this.mancc = mancc;
            this.tenncc = tenncc;
        }

        public string Mancc { get => mancc; set => mancc = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
    }
}
