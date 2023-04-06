using DAO;
using System;
using System.Collections.Generic;
using System.Data;
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
        public DataTable getAllKhoThuoc()
        {
            return DAO.KhoThuocDAO.Instance.getAllKhoThuoc();
        }
        public bool insertKhoThuoc(String sodk, String maphieu, string hsd, int soluong)
        {
            return DAO.KhoThuocDAO.Instance.insertKhoThuoc(sodk, maphieu, hsd, soluong);
        }
        public DataTable getAllThuocBanHang()
        {
            return DAO.KhoThuocDAO.Instance.getAllThuocBanHang();
        }
    }
}
