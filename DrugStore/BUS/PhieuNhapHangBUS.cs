using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapHangBUS
    {
        public PhieuNhapHangBUS() { }
        private static PhieuNhapHangBUS instance;
        public static PhieuNhapHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuNhapHangBUS();
                }
                return instance;
            }
        }
        public DataTable getAllPhieuNhapHang()
        {
            return DAO.PhieuNhapHangDAO.Instance.getAllPhieuNhapHang();
        }
    }
}
