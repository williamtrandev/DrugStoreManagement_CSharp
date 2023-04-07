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
        public bool insertNCC(String mancc, String tenncc, String sdt, String diachi)
        {
            String query = string.Format("INSERT INTO NhaCungCap VALUES('{0}', N'{1}', '{2}', N'{3}')", mancc, tenncc, sdt, diachi);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool updateNCC(String mancc, String tenncc, String sdt, String diachi, String mancc_cu)
        {
            String query = string.Format("UPDATE NhaCungCap SET MANCC='{0}', TENNCC=N'{1}', SDT='{2}', DIACHI=N'{3}' WHERE MANCC='{4}'", mancc, tenncc, sdt, diachi, mancc_cu);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
