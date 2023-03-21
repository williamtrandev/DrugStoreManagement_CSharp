using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return DataProvider.Instance.ExecuteQuery("SELECT SDT AS [Số điện thoại], DIACHI AS [Địa chỉ],HOTEN AS [Họ và tên], PASS AS [Mật khẩu] FROM NhanVien");
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
        public bool insertAccountNhanVien(String sdt, String name, String diachi, String pass)
        {
            String query = string.Format("INSERT INTO NhanVien VALUES('{0}', N'{1}', N'{2}', '{3}')", sdt, name, diachi, pass);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}