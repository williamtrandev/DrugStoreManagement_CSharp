using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietHoaDonBUS
    {
        public static ChiTietHoaDonBUS instance;
        public static ChiTietHoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonBUS();
                }
                return instance;
            }

        }
        private ChiTietHoaDonBUS() { }
        public bool insertChiTietHoaDon(String mahd, String sodk, int soluong)
        {
            return DAO.ChiTietHoaDonDAO.Instance.insertChiTietHoaDon(mahd, sodk, soluong);
        }
        public DataTable getChiTietHoaDon(string mahd)
        {
            return DAO.ChiTietHoaDonDAO.Instance.getChiTietHoaDon(mahd);
        }
    }
}