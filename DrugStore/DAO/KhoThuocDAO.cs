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
            return DataProvider.Instance.ExecuteQuery("SELECT Thuoc.SODK, Thuoc.TENTHUOC, MAPHIEU, HSD, SOLUONG FROM KhoThuoc JOIN Thuoc ON Thuoc.SODK = KhoThuoc.SODK WHERE DATEDIFF(DAY, GETDATE(), HSD) >= 0 AND SOLUONG > 0");
        }
        public DataTable getKhoThuoc(string sodk, string maphieu)
        {
            String query = string.Format("SELECT SOLUONG FROM KhoThuoc WHERE SODK = '{0}' AND MAPHIEU = '{1}'", sodk, maphieu);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable getAllThuocBanHang()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT Thuoc.SODK, Thuoc.TENTHUOC, MAPHIEU, HSD, SOLUONG, GIABAN FROM KhoThuoc JOIN Thuoc ON Thuoc.SODK = KhoThuoc.SODK WHERE DATEDIFF(DAY, GETDATE(), HSD) >= 0 AND SOLUONG > 0");
        }
        public bool insertKhoThuoc(String sodk, String maphieu, string hsd, int soluong)
        {
            String query = string.Format("INSERT INTO KhoThuoc VALUES('{0}', '{1}', '{2}', {3})", sodk, maphieu, hsd, soluong);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool updateSoLuong(String sodk, String maphieu, int soluong)
        {
            String query = string.Format("UPDATE KhoThuoc SET SOLUONG = SOLUONG - {0} WHERE SODK = '{1}' AND MAPHIEU = '{2}'", soluong, sodk, maphieu);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable getThuocSapHetHan()
        {
            String query = string.Format("SELECT Thuoc.SODK, Thuoc.TENTHUOC, MAPHIEU, HSD, SOLUONG FROM KhoThuoc JOIN Thuoc ON Thuoc.SODK = KhoThuoc.SODK WHERE DATEDIFF(DAY, GETDATE(), HSD) >= 0 AND (SOLUONG BETWEEN 1 AND 100)");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
