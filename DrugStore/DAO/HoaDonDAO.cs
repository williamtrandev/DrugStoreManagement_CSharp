using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonDAO();
                }
                return instance;
            }

        }
        public HoaDonDAO() { }

        public DataTable getAllHoaDon()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon");
        }
        public bool insertHoaDon(String mahd, String sdt, String ngayxuat, double tongtien)
        {
            String query = string.Format("INSERT INTO HoaDon VALUES('{0}', '{1}', '{2}', {3})", mahd, sdt, ngayxuat, tongtien);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public string getMaHoaDon()
        {
            string res = Convert.ToString(DataProvider.Instance.ExecuteScalar("SELECT dbo.func_taoMaHoaDon()"));
            return res;
        }
    }
}
