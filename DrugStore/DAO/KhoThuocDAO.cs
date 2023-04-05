using System;
using System.Collections.Generic;
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
        public bool insertKhoThuoc(String maphieu, String sodk, int soluong, string hsd)
        {
            String query = string.Format("INSERT INTO KhoThuoc VALUES('{0}', '{1}', {2}, '{3}')", maphieu, sodk, soluong, hsd);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
