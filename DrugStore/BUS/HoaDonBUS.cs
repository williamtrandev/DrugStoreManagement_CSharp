using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HoaDonBUS();
                }
                return instance;
            }

        }

        public HoaDonBUS()
        {

        }
        public DataTable getAllHoaDon()
        {
            return DAO.HoaDonDAO.Instance.getAllHoaDon();
        }
        public DataTable getAllHoaDonTheoNgay(String date1, String date2)
        {
            if (date1 == "" || date2 == "")
                return null;
            return DAO.HoaDonDAO.Instance.getAllHoaDonTheoNgay(date1, date2);
        }
        public bool insertHoaDon(String mahd, String sdt, String ngayxuat, double tongtien)
        {
            if(mahd == "" || sdt == "" || ngayxuat == "") 
            { 
                return false; 
            }
            return DAO.HoaDonDAO.Instance.insertHoaDon(mahd, sdt, ngayxuat, tongtien);
        }
        public string getMaHoaDon()
        {
            return DAO.HoaDonDAO.Instance.getMaHoaDon();
        }
        public double getTongTien(String date1, String date2)
        {
            if(date1 == "" || date2 == "")
               return 0.0;
            return DAO.HoaDonDAO.Instance.getTongTien(date1, date2);
        }
        public int getSoLuongHoaDonTheoNgay(String date1, String date2)
        {
            if (date1 == "" || date2 == "")
                return 0;
            return (int)DataProvider.Instance.ExecuteScalar("SELECT COUNT(*) FROM HoaDon WHERE NGAYXUAT BETWEEN @date1 AND @date2", new object[] { date1, date2 });
        }
    } 
}
