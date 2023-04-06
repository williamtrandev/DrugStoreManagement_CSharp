using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChiTietNhapHangDAO
    {
        public static ChiTietNhapHangDAO instance;
        public static ChiTietNhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChiTietNhapHangDAO();
                }
                return instance;
            }

        }
        private ChiTietNhapHangDAO() { }
        public bool insertChiTietNhapHang(String maphieu, String sodk, int soluong)
        {
            String query = string.Format("INSERT INTO ChiTietNhapHang VALUES('{0}', '{1}', {2})", maphieu, sodk, soluong);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable getChiTietNhapHang(string maphieu)
        {
            String query = string.Format("SELECT Thuoc.SODK, TENTHUOC, GIANHAP, SOLUONGNHAP FROM ChiTietNhapHang CTNH JOIN Thuoc ON Thuoc.SODK = CTNH.SODK WHERE MAPHIEU = '{0}'", maphieu);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
