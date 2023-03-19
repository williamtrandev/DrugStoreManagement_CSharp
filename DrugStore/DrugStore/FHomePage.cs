using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homepage
{
    public partial class FHomPage : Form
    {
        public FHomPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            pnl_onqlnv.Height = btn_qlnv.Height;
            pnl_onqlnv.Top = btn_qlnv.Top;
            pnl_qlnv.Visible = true;
            pnl_onqlnv.Visible = true;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_qlnh_Click(object sender, EventArgs e)
        {
            pnl_onqlnh.Height = btn_qlnh.Height;
            pnl_onqlnh.Top = btn_qlnh.Top;
            pnl_qlnv.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = true;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_qlbh_Click(object sender, EventArgs e)
        {
            pnl_onqlbh.Height = btn_qlbh.Height;
            pnl_onqlbh.Top = btn_qlbh.Top;
            pnl_qlnv.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = true;
            pnl_onbcthuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_bcthuoc_Click(object sender, EventArgs e)
        {
            pnl_onbcthuoc.Height = btn_bcthuoc.Height;
            pnl_onbcthuoc.Top = btn_bcthuoc.Top;
            pnl_qlnv.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = true;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_bcdoanhthu_Click(object sender, EventArgs e)
        {
            pnl_onbcdoanhthu.Height = btn_bcdoanhthu.Height;
            pnl_onbcdoanhthu.Top = btn_bcdoanhthu.Top;
            pnl_qlnv.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = true;
        }
    }
}
