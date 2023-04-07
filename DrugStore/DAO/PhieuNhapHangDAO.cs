using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PhieuNhapHangDAO
    {
        public static PhieuNhapHangDAO instance;
        public static PhieuNhapHangDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PhieuNhapHangDAO();
                }
                return instance;
            }

        }
        private PhieuNhapHangDAO() { }
        public DataTable getAllPhieuNhapHang()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT MAPHIEU, NGAYLAP, TONGGIANHAP FROM PhieuNhapHang");
        }
        public string getMaphieu()
        {
            string res = Convert.ToString(DataProvider.Instance.ExecuteScalar("SELECT dbo.func_taoMaPhieu()"));
            return res;
        }
        public bool insertPhieuNhapHang(String maphieu, string ngaylap, double tonggianhap)
        {
            String query = string.Format("INSERT INTO PhieuNhapHang VALUES('{0}', '{1}', {2})", maphieu, ngaylap, tonggianhap);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
