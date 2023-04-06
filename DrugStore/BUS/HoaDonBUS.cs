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
        public bool insertHoaDon(String mahd, String sdt, String ngayxuat, float tongtien)
        {
            return DAO.HoaDonDAO.Instance.insertHoaDon(mahd, sdt, ngayxuat, tongtien);
        }
        public string getMaHoaDon()
        {
            return DAO.HoaDonDAO.Instance.getMaHoaDon();
        }
    }

}
