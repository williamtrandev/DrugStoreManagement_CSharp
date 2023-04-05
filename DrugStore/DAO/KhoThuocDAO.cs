using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhoThuocDAO
    {
        private KhoThuocDAO() { }
        public static KhoThuocDAO instance;
        public static KhoThuocDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KhoThuocDAO();
                }
                return instance;
            }
        }
        public DataTable getAllKhoThuoc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT Thuoc.SODK, Thuoc.TENTHUOC, MAPHIEU, HSD, SOLUONG FROM KhoThuoc JOIN Thuoc ON Thuoc.SODK = KhoThuoc.SODK");
        }
        public bool insertKhoThuoc(String sodk, String maphieu, string hsd, int soluong)
        {
            String query = string.Format("INSERT INTO KhoThuoc VALUES('{0}', '{1}', '{2}', {3})", sodk, maphieu, hsd, soluong);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
