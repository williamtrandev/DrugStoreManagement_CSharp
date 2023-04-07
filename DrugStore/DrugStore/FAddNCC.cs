using BUS;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DrugStore
{
    public partial class FAddNCC : Form
    {
        FHomePage fhp;
        private bool action;
        private string mancc, tenncc, sdt, diachi;
        public FAddNCC(FHomePage fhp)
        {
            InitializeComponent();
            this.fhp = fhp;
        }
        public FAddNCC(FHomePage fhp, bool action, string mancc, string tenncc, string sdt, string diachi)
        {
            InitializeComponent();
            this.fhp = fhp;
            this.action = action;
            this.mancc = mancc;
            this.tenncc = tenncc;
            this.sdt = sdt;
            this.diachi = diachi;
        }

        private void pb_luu_Click(object sender, EventArgs e)
        {
            String mancc = tb_mancc.Text.ToString();
            String tenncc = tb_tenncc.Text.ToString();
            String sdt = tb_sdtncc.Text.ToString();
            String diachi = tb_diachincc.Text.ToString();
            if (!action)
            {
                bool check = NhaCungCapBUS.Instance.insertNCC(mancc, tenncc, sdt, diachi);
                if (check)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    fhp.loadNCC();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp không thành công");
                }
            }
            else
            {
                bool check = NhaCungCapBUS.Instance.updateNCC(mancc, tenncc, sdt, diachi, this.mancc);
                if (check)
                {
                    MessageBox.Show("Thay đổi nhà cung cấp thành công");
                    fhp.loadNCC();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Thay đổi nhà cung cấp không thành công");
                }
            }
        }

        private void pb_huy_Click(object sender, EventArgs e)
        {

        }

        private void FAddNCC_Load(object sender, EventArgs e)
        {
            pb_luu.Parent = pb_thongtinncc;
            pb_huy.Parent = pb_thongtinncc;
            pb_luu.BackColor = Color.Transparent;
            pb_huy.BackColor = Color.Transparent;
            if(action)
            {
                tb_mancc.Text = this.mancc;
                tb_tenncc.Text = this.tenncc;
                tb_sdtncc.Text = this.sdt;
                tb_diachincc.Text = this.diachi;
            }
        }
    }
}
