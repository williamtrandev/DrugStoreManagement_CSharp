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
        public int getSLKhoThuoc(string sodk, string maphieu)
        {
            DataTable sl_tab = DAO.KhoThuocDAO.Instance.getKhoThuoc(sodk, maphieu);
            int sl = Convert.ToInt32(sl_tab.Rows[0][0]);
            return sl;
        }
        public bool insertKhoThuoc(String sodk, String maphieu, string hsd, int soluong)
        {
            return DAO.KhoThuocDAO.Instance.insertKhoThuoc(sodk, maphieu, hsd, soluong);
        }
        public DataTable getAllThuocBanHang()
        {
            return DAO.KhoThuocDAO.Instance.getAllThuocBanHang();
        }
        public bool updateSoLuong(String sodk, String maphieu, int soluong)
        {
            return DAO.KhoThuocDAO.Instance.updateSoLuong(sodk, maphieu, soluong);
        }
        public DataTable getThuocSapHetHan()
        {
            return DAO.KhoThuocDAO.Instance.getThuocSapHetHan();
        }
    }
}
