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
using static System.Net.WebRequestMethods;

namespace DrugStore
{
    public partial class FHomePage : Form
    {
        public FHomePage()
        {
            InitializeComponent();
        }

        BindingSource accountList = new BindingSource();
        BindingSource drugList = new BindingSource();

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            pnl_onqlnv.Height = btn_qlnv.Height;
            pnl_onqlnv.Top = btn_qlnv.Top;
            pnl_qlnv.Visible = true;
            pl_bcthuoc.Visible = false;
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
            pl_bcthuoc.Visible = false;
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
            pl_bcthuoc.Visible = false;
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
            pl_bcthuoc.Visible = true;
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
            pl_bcthuoc.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = true;
        }
        public void loadNhanVien()
        {
            accountList.DataSource = NhanVienDAO.Instance.getAllAccount();
        }
        public void loadThuoc()
        {
            drugList.DataSource = ThuocDAO.Instance.getAllDrugs();
        }
        private void FHomePage_Load(object sender, EventArgs e)
        {
            pnl_onbcdoanhthu.Hide();
            pnl_onbcthuoc.Hide();
            pnl_onqlbh.Hide();
            pnl_onqlnh.Hide();
            pnl_onqlnv.Hide();
            tab_nv.DataSource = accountList;
            tab_dsthuoc.DataSource = drugList;
            loadNhanVien();
            loadThuoc();
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            FAddNV fa = new FAddNV(this);
            fa.Show();
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            this.Close();
            FLogin f = new FLogin();
            f.Show();
        }

        private void btn_themthuoc_Click(object sender, EventArgs e)
        {
            FAddThuoc fa = new FAddThuoc(this);
            fa.Show();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if(tb_timkiem.Text != "") {
                BindingSource tempDrugList = new BindingSource();
                string text_search = tb_timkiem.Text.ToString();
                DataTable dt = ThuocBUS.Instance.timThuoc(text_search);
                tempDrugList.DataSource = dt;
                tab_dsthuoc.DataSource= tempDrugList;
            } 

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            tab_dsthuoc.DataSource = drugList;
            tb_timkiem.Text = "";
        }

        private void btn_xoathuoc_Click(object sender, EventArgs e)
        {
            string sodk = tab_dsthuoc.CurrentRow.Cells["SODK"].Value.ToString();
            string tenthuoc = tab_dsthuoc.CurrentRow.Cells["TENTHUOC"].Value.ToString();
            DialogResult res = MessageBox.Show("Bạn có chắc là muốn xóa: "+tenthuoc, "Xác nhận xóa thuốc", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {             
                bool check = ThuocBUS.Instance.deleteThuoc(sodk);
                if (check)
                {
                    MessageBox.Show("Xóa thuốc thành công");
                    loadThuoc();
                }
                else
                {
                    MessageBox.Show("Xóa thuốc không thành công");
                }
            }
            if (res == DialogResult.Cancel)
            {
                
            }
        }
    }
}
