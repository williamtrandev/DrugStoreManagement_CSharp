using BUS;
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
        private bool action;
        private string sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi;
        private float gianhap, giaban;
        public FAddThuoc(FHomePage fhp)
        {
            InitializeComponent();
            this.fhp = fhp;
        }
        public FAddThuoc(FHomePage fhp, bool action, string sodk, string mancc, string tenthuoc, string hoatchat, string donvitinh, string quycachdonggoi, float gianhap, float giaban)
        {
            InitializeComponent();
            this.fhp = fhp;
            this.action = action;
            this.sodk = sodk;
            this.mancc = mancc;
            this.tenthuoc = tenthuoc;
            this.hoatchat = hoatchat;
            this.donvitinh = donvitinh;
            this.quycachdonggoi = quycachdonggoi;
            this.gianhap = gianhap;
            this.giaban = giaban;
        }

        private void pb_luu_Click(object sender, EventArgs e)
        {
            String sodk = tb_sodk.Text.ToString();
            String mancc = tb_mancc.Text.ToString();
            String tenthuoc = tb_tenthuoc.Text.ToString();
            String hoatchat = tb_hoatchat.Text.ToString();
            String donvitinh = tb_dvt.Text.ToString();
            String quycachdonggoi = tb_qcdg.Text.ToString();

            if (sodk == "" || mancc == "" || tenthuoc == "" || hoatchat == "" || donvitinh == "" || quycachdonggoi == "" || tb_gianhap.Text.ToString() == "" || tb_giaban.Text.ToString() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }
            float gianhap = (float)Convert.ToDouble(tb_gianhap.Text);
            float giaban = (float)Convert.ToDouble(tb_giaban.Text);
            if (!action)
            {
                bool check = ThuocBUS.Instance.insertThuoc(sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban);
                if (check)
                {
                    MessageBox.Show("Thêm thuốc thành công");
                    fhp.loadThuoc();
                    fhp.loadThuocPNH(mancc);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm thuốc không thành công");
                }
            }
            else
            {
                bool check = ThuocBUS.Instance.updateThuoc(sodk, mancc, tenthuoc, hoatchat, donvitinh, quycachdonggoi, gianhap, giaban, this.sodk);
                if (check)
                {
                    MessageBox.Show("Thay đổi thuốc thành công");
                    fhp.loadThuoc();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thay đổi thuốc không thành công");
                }
            }
        }

        private void FAddThuoc_Load(object sender, EventArgs e)
        {
            pb_luu.Parent = pb_thongtinthuoc;
            pb_huy.Parent = pb_thongtinthuoc;
            pb_luu.BackColor = Color.Transparent;
            pb_huy.BackColor = Color.Transparent;
            if (action)
            {
                tb_sodk.Text = this.sodk;
                tb_tenthuoc.Text = this.tenthuoc;
                tb_mancc.Text = this.mancc;
                tb_hoatchat.Text = this.hoatchat;
                tb_qcdg.Text = this.quycachdonggoi;
                tb_dvt.Text = this.donvitinh;
                tb_gianhap.Text = this.gianhap.ToString();
                tb_giaban.Text = this.giaban.ToString();
            }
            else
            {
                tb_mancc.Text = this.mancc;
            }
        }

        private void pb_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
