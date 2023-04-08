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
        public DataTable getAllHoaDonTheoNgay(String date1, String date2)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM HoaDon WHERE NGAYXUAT BETWEEN @date1 AND @date2", new object[] { date1, date2 });
        }
        public bool insertHoaDon(String mahd, String sdt, String sdtStaff, String ngayxuat, double tongtien)
        {
            String query = string.Format("INSERT INTO HoaDon VALUES('{0}', '{1}', '{2}', '{3}', {4})", mahd, sdt, sdtStaff, ngayxuat, tongtien);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public string getMaHoaDon()
        {
            string res = Convert.ToString(DataProvider.Instance.ExecuteScalar("SELECT dbo.func_taoMaHoaDon()"));
            return res;
        }
        public double getTongTien(String date1, String date2)
        {
            string query = string.Format("select sum(tongtien) from HoaDon where ngayxuat between '{0}' and '{1}'", date1, date2);
            object total = DataProvider.Instance.ExecuteScalar(query);
            if (total != System.DBNull.Value)
                return Convert.ToDouble(total);    
            else 
                return 0.0;
            
        }
        public int getSoLuongHoaDonTheoNgay(String date1, String date2)
        {
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM HoaDon WHERE NGAYXUAT BETWEEN @date1 AND @date2", new object[] { date1, date2 });
        }
    }
}
