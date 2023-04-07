using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {

        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhachHangDAO();
                }
                return instance;
            }

        }

        private KhachHangDAO()
        {
        }

        public DataTable getAllCustomer()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM KhachHang");
        }

        public bool insertKhachHang(String sdt, String name)
        {
            String query = string.Format("INSERT INTO KhachHang VALUES('{0}', N'{1}', 0)", sdt, name);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool checkExistCustomer(String phone)
        {
            String query = "SELECT * FROM KhachHang WHERE SDT = @phone";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { phone });

            if (data.Rows.Count == 0)
            {
                return false;
            }

            return true; // return an object KhachHang if exists in database
        }
        public bool deleteCustomer(String phone)
        {
            String query = string.Format("DELETE FROM KhachHang WHERE sdt='{0}'", phone);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool updateCustomer(String sdt, String name, String sdt_cu)
        {
            String query = string.Format("UPDATE KhachHang SET SDT='{0}', TENKH=N'{1}' WHERE SDT='{2}'", sdt, name, sdt_cu);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool updateDiem(String sdt, double diem)
        {
            String query = string.Format("UPDATE KhachHang SET TICHDIEM = TICHDIEM + {0} WHERE SDT='{1}'", diem, sdt);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}