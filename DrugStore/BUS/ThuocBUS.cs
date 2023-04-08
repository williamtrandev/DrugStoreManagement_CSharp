using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuocBUS
    {
        private static ThuocBUS instance;
        public static ThuocBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ThuocBUS();
                }
                return instance;
            }

        }

        public ThuocBUS()
        {

        }
        public DataTable getAllDrugs()
        {
            return DAO.ThuocDAO.Instance.getAllDrugs();
        }
        public DataTable getAllDrugsPNH(string mancc)
        {
            return DAO.ThuocDAO.Instance.getAllDrugsPNH(mancc);
        }
        public bool insertThuoc(String sodk, String mancc, String tenthuoc, String hoatchat, String donvitinh, String quycachdonggoi, float gianhap, float giaban)
        {
            return DAO.ThuocDAO.Instance.insertThuoc(sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban);
        }
        public DataTable timThuoc(String tenthuoc)
        {
            return DAO.ThuocDAO.Instance.timThuoc(tenthuoc);
        }
        public bool deleteThuoc(String sodk)
        {
            return DAO.ThuocDAO.Instance.deleteThuoc(sodk);
        }
        public bool deleteThuocNCC(String mancc)
        {
            return DAO.ThuocDAO.Instance.deleteThuocNCC(mancc);
        }
        public DataTable thongKeThuocTrongKho(int hsd1, int hsd2)
        {
            return DAO.ThuocDAO.Instance.thongKeThuocTrongKho(hsd1, hsd2);
        }
        public DataTable timThuocTrongKho(string textSearch)
        {
            return DAO.ThuocDAO.Instance.timThuocTrongKho(textSearch);
        }
        public DataTable timThuocBH(String tenthuoc)
        {
            return DAO.ThuocDAO.Instance.timThuocBH(tenthuoc);
        }
        public bool updateThuoc(String sodk, String mancc, String tenthuoc, String hoatchat, String donvitinh, String quycachdonggoi, float gianhap, float giaban, String sodk_cu)
        {
            return DAO.ThuocDAO.Instance.updateThuoc(sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban, sodk_cu);
        }
        public DataTable timthuocNH(String tenthuoc, String tenncc)
        {
            return DAO.ThuocDAO.Instance.timthuocNH(tenthuoc, tenncc);
        }
        public DataTable topThuocBanChay()
        {
            return DAO.ThuocDAO.Instance.topThuocBanChay();

        }
    }

}
