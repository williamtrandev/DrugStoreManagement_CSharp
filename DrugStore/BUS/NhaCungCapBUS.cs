using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;
        public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBUS();
                }
                return instance;
            }

        }
        public bool deleteNCC(String mancc)
        {
            return DAO.NhaCungCapDAO.Instance.deleteNCC(mancc);
        }
    }
}
