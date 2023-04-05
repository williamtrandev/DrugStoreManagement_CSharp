using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietNhapHangBUS
    {
        public static ChiTietNhapHangBUS instance;
        public static ChiTietNhapHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietNhapHangBUS();
                }
                return instance;
            }
        }
        public ChiTietNhapHangBUS() { }
        public bool insertChiTietNhapHang(String maphieu, String sodk, int soluong)
        {
            return DAO.ChiTietNhapHangDAO.Instance.insertChiTietNhapHang(maphieu, sodk, soluong);
        }
    }
}
