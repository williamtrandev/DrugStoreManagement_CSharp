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
        public DataTable getAllPhieuNhapHang()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT MAPHIEU, NGAYLAP, TONGGIANHAP FROM PhieuNhapHang");
        }
    }
}
