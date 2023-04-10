using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public DataTable getAllDrugsPNH(string mancc)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT SODK, TENTHUOC, HOATCHAT, GIANHAP FROM Thuoc WHERE MANCC = @mancc", new object[] { mancc });
        }
        public bool insertThuoc(String sodk, String mancc, String tenthuoc, String hoatchat, String donvitinh, String quycachdonggoi, float gianhap, float giaban)
        {
            String query = string.Format("INSERT INTO Thuoc VALUES('{0}', '{1}', N'{2}', N'{3}', N'{4}', N'{5}', {6}, {7})", sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable timThuoc(String tenthuoc)
        {
            String query = String.Format("SELECT t.SODK, t.TENTHUOC, t.HOATCHAT, t.DONVITINH, t.QUYCACHDONGGOI, ncc.TENNCC, t.GIANHAP, t.GIABAN FROM Thuoc t JOIN NhaCungCap ncc ON t.MANCC=ncc.MANCC WHERE t.TENTHUOC LIKE N'{0}%'", tenthuoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool deleteThuoc(String sodk)
        {
            String query = string.Format("DELETE FROM Thuoc WHERE sodk='{0}'", sodk);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool deleteThuocNCC(String mancc)
        {
            String query = string.Format("DELETE FROM Thuoc WHERE MANCC='{0}'", mancc);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable thongKeThuocTrongKho(int hsd1, int hsd2)
        {
            String query = "select t.SODK, t.TENTHUOC, kt.MAPHIEU, HSD, kt.SOLUONG from Thuoc t join KhoThuoc kt ON t.SODK = kt.SODK WHERE DATEDIFF(month,GETDATE(),kt.HSD) BETWEEN @hsd1 AND @hsd2 AND kt.SOLUONG > 0";
            return DataProvider.Instance.ExecuteQuery(query, new object[] { hsd1, hsd2 });
        }
        public DataTable timThuocTrongKho(String tenthuoc)
        {
            String query = String.Format("SELECT Thuoc.SODK, Thuoc.TENTHUOC, MAPHIEU, HSD, SOLUONG FROM KhoThuoc JOIN Thuoc ON Thuoc.SODK = KhoThuoc.SODK WHERE (DATEDIFF(MONTH, GETDATE(), HSD) BETWEEN 0 AND {0}) AND Thuoc.TENTHUOC LIKE N'{1}%' AND SOLUONG > 0", Int32.MaxValue, tenthuoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable timThuocBH(String tenthuoc)
        {
            String query = String.Format("SELECT Thuoc.SODK, Thuoc.TENTHUOC, MAPHIEU, HSD, SOLUONG, GIABAN FROM KhoThuoc JOIN Thuoc ON Thuoc.SODK = KhoThuoc.SODK WHERE (DATEDIFF(MONTH, GETDATE(), HSD) BETWEEN 0 AND {0}) AND Thuoc.TENTHUOC LIKE N'{1}%' AND SOLUONG > 0", Int32.MaxValue, tenthuoc);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool updateThuoc(String sodk, String mancc, String tenthuoc, String hoatchat, String donvitinh, String quycachdonggoi, float gianhap, float giaban, String sodk_cu)
        {
            String query = string.Format("update Thuoc SET SODK='{0}', MANCC='{1}', TENTHUOC=N'{2}', HOATCHAT=N'{3}', DONVITINH=N'{4}', QUYCACHDONGGOI=N'{5}', GIANHAP={6}, GIABAN={7} WHERE SODK='{8}'", sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban, sodk_cu);
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public DataTable timthuocNH(String tenthuoc, String tenncc)
        {
            String query = String.Format("select t.SODK, t.TENTHUOC, t.HOATCHAT, t.GIANHAP from Thuoc t JOIN NhaCungCap ncc ON t.MANCC = ncc.MANCC where t.TENTHUOC like N'{0}%' and ncc.MANCC=N'{1}'", tenthuoc, tenncc);
            return DataProvider.Instance.ExecuteQuery(query);

        }
        public DataTable topThuocBanChay()
        {
            String query = String.Format("SELECT THUOC.SODK, THUOC.TENTHUOC, THUOC.DONVITINH, THUOC.GIANHAP, THUOC.GIABAN, Thuoc.HOATCHAT, SUM(CHITIETHOADON.SOLUONGBAN) AS SOLUONGBAN\r\nFROM THUOC\r\nJOIN CHITIETHOADON ON THUOC.SODK = CHITIETHOADON.SODK\r\nGROUP BY THUOC.SODK, THUOC.TENTHUOC, THUOC.DONVITINH, Thuoc.HOATCHAT, THUOC.GIANHAP, THUOC.GIABAN\r\nORDER BY SOLUONGBAN DESC");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}