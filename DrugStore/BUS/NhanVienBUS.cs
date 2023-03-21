using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienBUS();
                }
                return instance;
            }

        }

        public NhanVienBUS()
        {

        }
        public NhanVien checkAccount(String phone, String pass)
        {
            return DAO.NhanVienDAO.Instance.checkAccount(phone, pass);
        }
        public bool checkExistAccount(String phone)
        {
            return DAO.NhanVienDAO.Instance.checkExistAccount(phone);
        }
        public bool insertAccountNhanVien(String sdt, String name, String diachi, String pass)
        {
            return DAO.NhanVienDAO.Instance.insertAccountNhanVien(sdt, name, diachi, pass);
        }
    }

}
