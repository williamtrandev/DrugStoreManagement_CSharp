using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugStore
{
    public partial class FThuocBanChay : Form
    {
        public FThuocBanChay()
        {
            InitializeComponent();
        }

        private void FThuocBanChay_Load(object sender, EventArgs e)
        {
            dgv_dsthuocbanchay.DataSource = BUS.ThuocBUS.Instance.topThuocBanChay();
        }
    }
}
