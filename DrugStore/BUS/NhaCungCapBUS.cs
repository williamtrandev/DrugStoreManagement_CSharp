using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private static NhaCungCapBUS instance;
        public static NhaCungCapBUS Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBUS();
                }
                return instance;
            }

        }
        public bool deleteNCC(String mancc)
        {
            return DAO.NhaCungCapDAO.Instance.deleteNCC(mancc);
        }
        public DataTable getAllNCC()
        {
            return DAO.NhaCungCapDAO.Instance.getAllNCC();
        }
        //public DataTable getAllTenNCC()
        //{
        //    return DAO.NhaCungCapDAO.Instance.getAllTenNCC();
        //}
        public bool insertNCC(String mancc, String tenncc, String sdt, String diachi)
        {
            return DAO.NhaCungCapDAO.Instance.insertNCC(mancc, tenncc, sdt, diachi);
        }
        public bool updateNCC(String mancc, String tenncc, String sdt, String diachi, String mancc_cu)
        {
            return DAO.NhaCungCapDAO.Instance.updateNCC(mancc, tenncc, sdt, diachi, mancc_cu);
        }
    }
}
