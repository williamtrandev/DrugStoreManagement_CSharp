using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NCC_DAO
    {
        private static NCC_DAO instance;
        public static NCC_DAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NCC_DAO();
                }
                return instance;
            }

        }
        public NCC_DAO() { }

        public DataTable getAllNCC()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT MANCC, TENNCC FROM NhaCungCap");
        }
    }
}
