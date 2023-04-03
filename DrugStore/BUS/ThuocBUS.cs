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
    }

}
