using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public static NhaCungCapDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapDAO();
                }
                return instance;
            }

        }
        public NhaCungCapDAO() { }

        public DataTable getAllNCC()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT MANCC, TENNCC, SDT, DIACHI FROM NhaCungCap");
        }
        public DataTable getAllTenNCC()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TENNCC FROM NhaCungCap");
        }
        public bool deleteNCC(String mancc)
        {
            String query = string.Format("DELETE FROM NhaCungCap WHERE MANCC='{0}'", mancc);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
