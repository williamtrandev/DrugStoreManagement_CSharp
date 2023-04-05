using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhoThuocBUS
    {
        public KhoThuocBUS() { }
        public static KhoThuocBUS instance;
        public static KhoThuocBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoThuocBUS();
                }
                return instance;
            }
        }
        public bool insertKhoThuoc(String maphieu, String sodk, int soluong, string hsd)
        {
            return DAO.KhoThuocDAO.Instance.insertKhoThuoc(maphieu,sodk,soluong,hsd);
        }
    }
}
