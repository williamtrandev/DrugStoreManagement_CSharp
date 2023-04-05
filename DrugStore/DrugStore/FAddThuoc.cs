using BUS;
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DrugStore
{
    public partial class FAddThuoc : Form
    {
        FHomePage fhp;
        public FAddThuoc(FHomePage fhp)
        {
            InitializeComponent();
            this.fhp = fhp;
        }

        private void pb_luu_Click(object sender, EventArgs e)
        {
            String sodk = tb_sodk.Text.ToString();
            String mancc = tb_mancc.Text.ToString();
            String tenthuoc = tb_tenthuoc.Text.ToString();
            String hoatchat = tb_hoatchat.Text.ToString();
            String donvitinh = tb_dvt.Text.ToString();
            String quycachdonggoi = tb_qcdg.Text.ToString();
            float gianhap = (float)Convert.ToDouble(tb_gianhap.Text);
            float giaban = (float)Convert.ToDouble(tb_giaban.Text);

            bool check = ThuocBUS.Instance.insertThuoc(sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban);
            if (check)
            {
                MessageBox.Show("Thêm thuốc thành công");
                fhp.loadThuoc();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Thêm thuốc không thành công");
            }
        }

        private void FAddThuoc_Load(object sender, EventArgs e)
        {
            pb_luu.Parent = pb_thongtinthuoc;
            pb_huy.Parent = pb_thongtinthuoc;
            pb_luu.BackColor = Color.Transparent;
            pb_huy.BackColor = Color.Transparent;
        }

        private void pb_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
