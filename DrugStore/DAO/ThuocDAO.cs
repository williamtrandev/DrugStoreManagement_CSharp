using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class ThuocDAO
    {

        private static ThuocDAO instance;

        public static ThuocDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThuocDAO();
                }
                return instance;
            }

        }

        private ThuocDAO()
        {
        }
        
        public DataTable getAllDrugs()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SODK, TENTHUOC, HOATCHAT, DONVITINH, QUYCACHDONGGOI, TENNCC, GIANHAP, GIABAN FROM Thuoc JOIN NhaCungCap ON Thuoc.MANCC = NhaCungCap.MANCC");
        }
        public bool insertThuoc(String sodk, String mancc, String tenthuoc, String hoatchat, String donvitinh, String quycachdonggoi, float gianhap, float giaban)
        {
            String query = string.Format("INSERT INTO Thuoc VALUES('{0}', '{1}', N'{2}', N'{3}', N'{4}', N'{5}', {6}, {7})", sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable timThuoc(String tenthuoc)
        {
            String query = "SELECT * FROM Thuoc WHERE TENTHUOC = @tenthuoc";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { tenthuoc });
        }
        public bool deleteThuoc(String sodk)
        {
            String query = string.Format("DELETE FROM Thuoc WHERE sodk='{0}'", sodk);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}