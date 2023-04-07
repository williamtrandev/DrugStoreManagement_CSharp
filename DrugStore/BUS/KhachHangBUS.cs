using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangBUS();
                }
                return instance;
            }

        }

        public KhachHangBUS()
        {

        }
        public DataTable getAllCustomer()
        {
            return DAO.KhachHangDAO.Instance.getAllCustomer();
        }
        public bool insertKhachHang(String sdt, String name)
        {
            return DAO.KhachHangDAO.Instance.insertKhachHang(sdt, name);
        }
        public bool checkExistCustomer(String phone)
        {
            return DAO.KhachHangDAO.Instance.checkExistCustomer(phone);
        }
        public bool deleteCustomer(String sdt)
        {
            return DAO.KhachHangDAO.Instance.deleteCustomer(sdt);
        }
        public bool updateCustomer(String sdt, String name, String sdt_cu)
        {
            return DAO.KhachHangDAO.Instance.updateCustomer(sdt, name, sdt_cu);
        }
        public bool updateDiem(String sdt, double diem)
        {
            return DAO.KhachHangDAO.Instance.updateDiem(sdt, diem);
        }
    }

}
