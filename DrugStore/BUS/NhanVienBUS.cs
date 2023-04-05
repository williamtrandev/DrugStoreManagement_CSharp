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
        public DataTable getAllAccount()
        {
            return DAO.NhanVienDAO.Instance.getAllAccount();
        }
        public NhanVien checkAccount(String phone, String pass)
        {
            return DAO.NhanVienDAO.Instance.checkAccount(phone, pass);
        }
        public bool checkExistAccount(String phone)
        {
            return DAO.NhanVienDAO.Instance.checkExistAccount(phone);
        }
        public bool insertAccountNhanVien(String sdt, String diachi, String name,  String pass)
        {
            return DAO.NhanVienDAO.Instance.insertAccountNhanVien(sdt, diachi, name, pass);
        }
        public bool updateAccountNhanVien(String sdt, String diachi, String name,  String pass, String sdt_cu)
        {
            return DAO.NhanVienDAO.Instance.updateAccountNhanVien(sdt, diachi, name, pass, sdt_cu);
        }
        public bool deleteNhanVien(String sdt)
        {
            return DAO.NhanVienDAO.Instance.deleteNhanVien(sdt);
        }
    }

}
