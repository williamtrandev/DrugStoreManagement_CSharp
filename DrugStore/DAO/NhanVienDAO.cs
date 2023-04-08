using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class NhanVienDAO
    {

        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVienDAO();
                }
                return instance;
            }

        }

        private NhanVienDAO()
        {
        }
        public NhanVien checkAccount(String phone, String pass)    // Check whether exist an account of user to login
        {
            String query = "proc_Login @sodt , @pass";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone, pass });

            if (data.Rows.Count == 0)
            {
                return null;
            }

            return new NhanVien(data.Rows[0]); // return an object KhachHang if exists in database 
        }
        public DataTable getAllAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SDT, DIACHI, HOTEN, PASS FROM NhanVien WHERE SDT != 'admin'");
        }
        public bool checkExistAccount(String phone)
        {
            String query = "SELECT * FROM NhanVien WHERE SDT = @phone";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });

            if (data.Rows.Count == 0)
            {
                return false;
            }

            return true; // return an object NhanVien if exists in database
        }
        public bool insertAccountNhanVien(String sdt, String diachi, String name, String pass)
        {
            String query = string.Format("INSERT INTO NhanVien VALUES('{0}', N'{1}', N'{2}', '{3}')", sdt, diachi, name, pass);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool updateAccountNhanVien(String sdt, String diachi, String name, String pass, String sdt_cu)
        {
            String query = string.Format("UPDATE NhanVien SET SDT='{0}', DIACHI='{1}', HOTEN='{2}', PASS='{3}'", sdt, diachi, name, pass);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool deleteNhanVien(String sdt)
        {
            String query = string.Format("DELETE FROM NhanVien WHERE SDT='{0}'", sdt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}