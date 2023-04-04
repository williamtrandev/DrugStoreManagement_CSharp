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
        BindingSource nccList = new BindingSource();
        BindingSource customerList = new BindingSource();

        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            pnl_onqlnv.Height = btn_qlnv.Height;
            pnl_onqlnv.Top = btn_qlnv.Top;
            pnl_qlnv.Visible = true;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = false;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlnv.Visible = true;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_qlnh_Click(object sender, EventArgs e)
        {
            pnl_onqlnh.Height = btn_qlnh.Height;
            pnl_onqlnh.Top = btn_qlnh.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = true;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = true;
            pnl_onqlbh.Visible = false;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_qlbh_Click(object sender, EventArgs e)
        {
            pnl_onqlbh.Height = btn_qlbh.Height;
            pnl_onqlbh.Top = btn_qlbh.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = true;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = false;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = true;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_bcdoanhthu_Click(object sender, EventArgs e)
        {
            pnl_onbcdoanhthu.Height = btn_bcdoanhthu.Height;
            pnl_onbcdoanhthu.Top = btn_bcdoanhthu.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = false;
            pnl_bcdoanhthu.Visible = true;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
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
        public void loadNCC()
        {
            nccList.DataSource = NhaCungCapDAO.Instance.getAllNCC();
        }
        public void loadKhachHang()
        {
            customerList.DataSource = KhachHangBUS.Instance.getAllCustomer();
        }
        private void FHomePage_Load(object sender, EventArgs e)
        {
            pnl_onbcdoanhthu.Hide();
            pnl_onbcthuoc.Hide();
            pnl_onqlbh.Hide();
            pnl_onqlnh.Hide();
            pnl_onqlnv.Hide();
            
            dgv_nv.DataSource = accountList;
            dgv_dsthuoc.DataSource = drugList;
            dgv_ncc.DataSource = nccList;
            dgv_qlkh.DataSource = customerList;
            loadNhanVien();
            loadThuoc();
            loadNCC();
            loadKhachHang();
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
                dgv_dsthuoc.DataSource= tempDrugList;
            } 

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dgv_dsthuoc.DataSource = drugList;
            tb_timkiem.Text = "";
        }

        private void btn_xoathuoc_Click(object sender, EventArgs e)
        {
            string sodk = dgv_dsthuoc.CurrentRow.Cells["SODK"].Value.ToString();
            string tenthuoc = dgv_dsthuoc.CurrentRow.Cells["TENTHUOC"].Value.ToString();
            DialogResult res = MessageBox.Show("Xóa thuốc này thì mọi hóa đơn liên quan đến thuốc này cũng sẽ bị xóa. Hành động này không thể undo", "Bạn có chắc là muốn xóa: " + tenthuoc, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btn_dmthuoc_Click(object sender, EventArgs e)
        {
            pnl_onbcthuoc.Height = btn_bcthuoc.Height;
            pnl_onbcthuoc.Top = btn_bcthuoc.Top;
            pnl_ondmthuoc.Height = btn_dmthuoc.Height;
            pnl_ondmthuoc.Top = btn_dmthuoc.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = true;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = false;
            pnl_qlkh.Visible = false;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = true;
            pnl_ondmthuoc.Visible = true;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_khothuoc_Click(object sender, EventArgs e)
        {
            pnl_onbcthuoc.Height = btn_bcthuoc.Height;
            pnl_onbcthuoc.Top = btn_bcthuoc.Top;
            pnl_onkhothuoc.Height = btn_khothuoc.Height;
            pnl_onkhothuoc.Top = btn_khothuoc.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = true;
            pnl_laphoadon.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = false;
            pnl_qlkh.Visible = false;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = true;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = true;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            pnl_onqlkh.Height = btn_qlkh.Height;
            pnl_onqlkh.Top = btn_qlkh.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_qlnh.Visible = false;
            pnl_qlkh.Visible = true;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlkh.Visible = true;
            pnl_onqlncc.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_qlncc_Click(object sender, EventArgs e)
        {
            pnl_onqlncc.Height = btn_qlncc.Height;
            pnl_onqlncc.Top = btn_qlncc.Top;
            pnl_qlnv.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_qlkh.Visible=false;
            pnl_qlncc.Visible = true;
            pnl_qlnh.Visible = false;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlncc.Visible = true;
            pnl_onqlkh.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
        }

        private void btn_xoancc_Click(object sender, EventArgs e)
        {
            string mancc = dgv_ncc.CurrentRow.Cells["MANCC"].Value.ToString();
            string tenncc = dgv_ncc.CurrentRow.Cells["TENNCC1"].Value.ToString();
            DialogResult res = MessageBox.Show("Xóa nhà cung cấp này thì mọi phiếu nhập hàng và thuốc có liên quan sẽ bị xóa. Hành động này không thể undo", "Bạn có chắc là muốn xóa: " + tenncc, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                bool xoaThuoc = ThuocBUS.Instance.deleteThuocNCC(mancc);
                if (xoaThuoc) { }
                bool check = NhaCungCapBUS.Instance.deleteNCC(mancc);
                if (check)
                {
                    loadNCC();
                    loadThuoc();
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp không thành công");
                }
            }
            if (res == DialogResult.Cancel)
            {

            }
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            FAddKhachHang fa = new FAddKhachHang(false, this);
            fa.Show();
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            string sdt = dgv_qlkh.CurrentRow.Cells["SDT_KH"].Value.ToString();
            string name = dgv_qlkh.CurrentRow.Cells["TENKH"].Value.ToString();
            FAddKhachHang fa = new FAddKhachHang(true, this, sdt, name);
            fa.Show();
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            string sdt = dgv_qlkh.CurrentRow.Cells["SDT_KH"].Value.ToString();
            DialogResult res = MessageBox.Show("Xóa thuốc khách hàng này không thể undo", "Bạn có chắc là muốn xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                bool check = KhachHangBUS.Instance.deleteCustomer(sdt);
                if (check)
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    loadKhachHang();
                }
                else
                {
                    MessageBox.Show("Xóa khách hàng không thành công");
                }
            }
        }
    }
}
