using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietHoaDonDAO
    {
        public static ChiTietHoaDonDAO instance;
        public static ChiTietHoaDonDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietHoaDonDAO();
                }
                return instance;
            }

        }
        private ChiTietHoaDonDAO() { }
        public bool insertChiTietHoaDon(String mahd, String sodk, int soluong)
        {
            String query = string.Format("INSERT INTO ChiTietHoaDon VALUES('{0}', '{1}', {2})", mahd, sodk, soluong);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable getChiTietHoaDon(string mahd)
        {
            String query = string.Format("SELECT Thuoc.SODK, TENTHUOC, GIABAN, SOLUONGBAN FROM ChiTietHoaDon CTHD JOIN Thuoc ON Thuoc.SODK = CTHD.SODK WHERE MAHD = '{0}'", mahd);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}