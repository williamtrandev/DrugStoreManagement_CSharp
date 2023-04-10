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
using System.Drawing;
using System.Drawing.Printing;
using static System.Net.WebRequestMethods;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;
using System.Globalization;
// new
namespace DrugStore
{
    public partial class FHomePage : Form
    {
        private bool isAdmin;
        private string sdtStaff;
        public FHomePage(string sdtStaff, bool isAdmin=false)
        {
            InitializeComponent();
            this.sdtStaff = sdtStaff;
            this.isAdmin = isAdmin;
        }

        BindingSource accountList = new BindingSource();
        BindingSource drugList = new BindingSource();
        BindingSource khoThuocList = new BindingSource();
        BindingSource nccList = new BindingSource();
        BindingSource customerList = new BindingSource();
        BindingSource phieuNhapList = new BindingSource();
        BindingSource drugPNHList = new BindingSource();
        BindingSource hoadonList = new BindingSource();
        BindingSource ThuocBanHangList = new BindingSource();
        BindingSource baoCaoHoaDonList = new BindingSource();
        DataTable dataTable_pnh, dataTable_banhang;
        HashSet<string> dsthuoc_pnh, dsthuoc_banhang;

        void disable()
        {
            pnl_qlnv.Visible = false;
            pnl_qlkh.Visible = false;
            pnl_qlncc.Visible = false;
            pnl_dspn.Visible = false;
            pnl_lapphieunhap.Visible = false;
            pnl_laphoadon.Visible = false;
            pnl_dmthuoc.Visible = false;
            pnl_khothuoc.Visible = false;
            pnl_bcdoanhthu.Visible = false;
            pnl_onqlnv.Visible = false;
            pnl_onqlnh.Visible = false;
            pnl_onqlbh.Visible = false;
            pnl_onqlkh.Visible = false;
            pnl_onqlncc.Visible = false;
            pnl_onbcthuoc.Visible = false;
            pnl_ondmthuoc.Visible = false;
            pnl_onkhothuoc.Visible = false;
            pnl_onbcdoanhthu.Visible = false;
            pnl_dshd_qlbh.Visible= false;
        }
        private void btn_qlnv_Click(object sender, EventArgs e)
        {
            pnl_onqlnv.Height = btn_qlnv.Height;
            pnl_onqlnv.Top = btn_qlnv.Top;
            disable();
            pnl_qlnv.Visible = true;
            pnl_onqlnv.Visible = true;
        }

        private void btn_qlnh_Click(object sender, EventArgs e)
        {
            pnl_onqlnh.Height = btn_qlnh.Height;
            pnl_onqlnh.Top = btn_qlnh.Top;
            disable();
            pnl_dspn.Visible = true;
            pnl_onqlnh.Visible = true;
        }

        private void btn_qlbh_Click(object sender, EventArgs e)
        {
            pnl_onqlbh.Height = btn_qlbh.Height;
            pnl_onqlbh.Top = btn_qlbh.Top;
            disable();
            pnl_dshd_qlbh.Visible = true;
            pnl_onqlbh.Visible = true;
        }
        private void btn_laphd_qlbh_Click(object sender, EventArgs e)
        {
            dsthuoc_banhang = new HashSet<string>();
            txt_tongTien.Text = "";
            txtb_tienKhachDua.Text = "";
            txtb_tienTraLai.Text = "";
            pnl_onqlbh.Height = btn_qlbh.Height;
            pnl_onqlbh.Top = btn_qlbh.Top;
            disable();
            pnl_laphoadon.Visible = true;
            pnl_onqlbh.Visible = true;
            tb_maHoaDon.Text = BUS.HoaDonBUS.Instance.getMaHoaDon();
            dataTable_banhang = new DataTable();
            dataTable_banhang.Columns.Add("SODK");
            dataTable_banhang.Columns.Add("TENTHUOC");
            dataTable_banhang.Columns.Add("MAPHIEU");
            dataTable_banhang.Columns.Add("GIABAN");
            dataTable_banhang.Columns.Add("SOLUONG");
            dgv_bh_hoaDon.DataSource = dataTable_banhang;
        }
        private void btn_bcdoanhthu_Click(object sender, EventArgs e)
        {
            pnl_onbcdoanhthu.Height = btn_bcdoanhthu.Height;
            pnl_onbcdoanhthu.Top = btn_bcdoanhthu.Top;

            disable();
            pnl_bcdoanhthu.Visible = true;
            pnl_onbcdoanhthu.Visible = true;
        }
        public void loadNhanVien()
        {
            accountList.DataSource = NhanVienBUS.Instance.getAllAccount();
        }
        public void loadThuoc()
        {
            drugList.DataSource = ThuocBUS.Instance.getAllDrugs();
        }
        public void loadKhoThuoc()
        {
            khoThuocList.DataSource = KhoThuocBUS.Instance.getAllKhoThuoc();
        }
        public void loadNCC()
        {
            nccList.DataSource = NhaCungCapBUS.Instance.getAllNCC();
        }
        public void loadKhachHang()
        {
            customerList.DataSource = KhachHangBUS.Instance.getAllCustomer();
        }
        public void loadPhieuNhapHang()
        {
            phieuNhapList.DataSource = PhieuNhapHangBUS.Instance.getAllPhieuNhapHang();
        }
        public void loadThuocPNH(string mancc)
        {
            drugPNHList.DataSource = ThuocBUS.Instance.getAllDrugsPNH(mancc);
        }
        public void loadHoaDon()
        {
            hoadonList.DataSource = HoaDonBUS.Instance.getAllHoaDon();
        }
        public void loadThuocBanHang()
        {
            ThuocBanHangList.DataSource = KhoThuocBUS.Instance.getAllThuocBanHang();
        }
        public void loadBaoCaoHD(String date1, String date2)
        {
            baoCaoHoaDonList.DataSource = HoaDonBUS.Instance.getAllHoaDonTheoNgay(date1, date2);
        }
        private void FHomePage_Load(object sender, EventArgs e)
        {
            if(!isAdmin)
            {
                btn_qlnv.Enabled = false;
                btn_qlncc.Enabled = false;
                btn_qlnh.Enabled = false;
                btn_themthuoc.Enabled = false;
                btn_suathuoc.Enabled = false;
                btn_xoathuoc.Enabled = false;
            }
            WindowState = FormWindowState.Maximized;
            pnl_onbcdoanhthu.Hide();
            pnl_onbcthuoc.Hide();
            pnl_onqlbh.Hide();
            pnl_onqlnh.Hide();
            pnl_onqlnv.Hide();

            dgv_nv.DataSource = accountList;
            dgv_dsthuoc.DataSource = drugList;
            dgv_dsthuockt.DataSource = khoThuocList;
            dgv_ncc.DataSource = nccList;
            dgv_qlkh.DataSource = customerList;
            dgv_dspn.DataSource = phieuNhapList;
            dgv_dsthuoc_pnh.DataSource = drugPNHList;
            dgv_dshd.DataSource = hoadonList;
            dgv_bh_danhMucThuoc.DataSource = ThuocBanHangList;
            dgv_doanhthu.DataSource = baoCaoHoaDonList;
            txt_tongTien.Text = string.Format("{0:C5}", txt_tongTien.Text);
            txtb_tienKhachDua.Text = string.Format("{0:C5}", txtb_tienKhachDua.Text);
            txtb_tienTraLai.Text = string.Format("{0:C5}", txtb_tienTraLai.Text);
            tb_tongdt.Text = string.Format("{0:C5}", txtb_tienTraLai.Text);
            loadNhanVien();
            loadThuoc();
            loadKhoThuoc();
            loadNCC();
            loadKhachHang();
            loadPhieuNhapHang();
            loadHoaDon();
            loadThuocBanHang();
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
            if (tb_timkiem.Text != "")
            {
                BindingSource tempDrugList = new BindingSource();
                string text_search = tb_timkiem.Text.ToString();
                DataTable dt = ThuocBUS.Instance.timThuoc(text_search);
                tempDrugList.DataSource = dt;
                dgv_dsthuoc.DataSource = tempDrugList;
            }

        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            dgv_dsthuoc.DataSource = drugList;
            tb_timkiem.Text = "";
        }

        private void btn_xoathuoc_Click(object sender, EventArgs e)
        {
            if(dgv_dsthuoc.RowCount > 0)
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
        }

        private void btn_dmthuoc_Click(object sender, EventArgs e)
        {
            pnl_onbcthuoc.Height = btn_bcthuoc.Height;
            pnl_onbcthuoc.Top = btn_bcthuoc.Top;
            pnl_ondmthuoc.Height = btn_dmthuoc.Height;
            pnl_ondmthuoc.Top = btn_dmthuoc.Top;
            disable();
            pnl_dmthuoc.Visible = true;
            pnl_onbcthuoc.Visible = true;
            pnl_ondmthuoc.Visible = true;
        }

        
        private void btn_khothuoc_Click(object sender, EventArgs e)
        {
            pnl_onbcthuoc.Height = btn_bcthuoc.Height;
            pnl_onbcthuoc.Top = btn_bcthuoc.Top;
            pnl_onkhothuoc.Height = btn_khothuoc.Height;
            pnl_onkhothuoc.Top = btn_khothuoc.Top;
            disable();
            pnl_khothuoc.Visible = true;
            pnl_onbcthuoc.Visible = true;
            pnl_onkhothuoc.Visible = true;
        }

        private void btn_qlkh_Click(object sender, EventArgs e)
        {
            pnl_onqlkh.Height = btn_qlkh.Height;
            pnl_onqlkh.Top = btn_qlkh.Top;
            disable();
            pnl_qlkh.Visible = true;
            pnl_onqlkh.Visible = true;
        }

        private void btn_qlncc_Click(object sender, EventArgs e)
        {
            pnl_onqlncc.Height = btn_qlncc.Height;
            pnl_onqlncc.Top = btn_qlncc.Top;
            disable();
            pnl_qlncc.Visible = true;
            pnl_onqlncc.Visible = true;
        }

        private void btn_xoancc_Click(object sender, EventArgs e)
        {
            if(dgv_ncc.RowCount > 0)
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
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            FAddKhachHang fa = new FAddKhachHang(false, this);
            fa.Show();
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            if(dgv_qlkh.RowCount != 0)
            {

                string sdt = dgv_qlkh.CurrentRow.Cells["SDT_KH"].Value.ToString();
                string name = dgv_qlkh.CurrentRow.Cells["TENKH"].Value.ToString();
                FAddKhachHang fa = new FAddKhachHang(true, this, sdt, name);
                fa.Show();
            }
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            if(dgv_qlkh.RowCount != 0)
            {
                string sdt = dgv_qlkh.CurrentRow.Cells["SDT_KH"].Value.ToString();
                DialogResult res = MessageBox.Show("Xóa khách hàng này không thể undo", "Bạn có chắc là muốn xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btn_lapHoaDon_Click(object sender, EventArgs e)
        {
            pnl_laphoadon.Visible = true;
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text != "")
            {
                string text_search = tb_timkiem.Text.ToString();
                DataTable dt = ThuocBUS.Instance.timThuoc(text_search);
                dgv_dsthuoc.DataSource = dt;
            }
            else
            {
                dgv_dsthuoc.DataSource = drugList;
            }
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            if(dgv_nv.RowCount != 0)
            {

                String sdt = dgv_nv.CurrentRow.Cells["SDT"].Value.ToString();
                String hoten = dgv_nv.CurrentRow.Cells["HOTEN"].Value.ToString();
                String diachi = dgv_nv.CurrentRow.Cells["DIACHI"].Value.ToString();
                String pass = dgv_nv.CurrentRow.Cells["PASS"].Value.ToString();
                FAddNV fa = new FAddNV(this, true, sdt, hoten, diachi, pass);
                fa.Show();
            }
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            if(dgv_nv.RowCount != 0)
            {

                string sdt = dgv_nv.CurrentRow.Cells["SDT"].Value.ToString();
                DialogResult res = MessageBox.Show("Xóa nhân viên này? Hành động này không thể undo", "Bạn có chắc là muốn xóa?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    bool check = NhanVienBUS.Instance.deleteNhanVien(sdt);
                    if (check)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        loadNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công");
                    }
                }
            }
        }

        private void btn_lapPhieuNhap_Click(object sender, EventArgs e)
        {
            dsthuoc_pnh = new HashSet<string>();
            tb_tongtiennh.Text = "";
            pnl_onqlnh.Height = btn_qlnh.Height;
            pnl_onqlnh.Top = btn_qlnh.Top;
            disable();
            tb_maphieu.Text = PhieuNhapHangBUS.Instance.getMaphieu();
            cbb_nccNH.DataSource = nccList;
            cbb_nccNH.DisplayMember = "TENNCC";
            pnl_lapphieunhap.Visible = true;
            pnl_onqlnh.Visible = true;
            dataTable_pnh = new DataTable();
            dataTable_pnh.Columns.Add("SODK");
            dataTable_pnh.Columns.Add("TENTHUOC");
            dataTable_pnh.Columns.Add("GIANHAP");
            dataTable_pnh.Columns.Add("SOLUONGNHAP");
            dataTable_pnh.Columns.Add("HSD");
            dgv_phieunh.DataSource = dataTable_pnh;
        }

        private void btn_huylapphieu_Click(object sender, EventArgs e)
        {
            pnl_onqlnh.Height = btn_qlnh.Height;
            pnl_onqlnh.Top = btn_qlnh.Top;
            disable();
            pnl_dspn.Visible = true;
            pnl_onqlnh.Visible = true;
        }

        private void cbb_nccNH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_nccNH.ValueMember = "MANCC";
            string mancc = cbb_nccNH.SelectedValue.ToString();
            loadThuocPNH(mancc);
        }
        private void tinhTongGiaNhap()
        {
            double tonggianhap = 0;
            foreach (DataGridViewRow row in dgv_phieunh.Rows)
            {
                if (row.Cells["SOLUONGNHAP"].Value.ToString() != "")
                {
                    double gianhappnh = Convert.ToDouble(row.Cells["GIANHAPPNH1"].Value);
                    int soluong = Convert.ToInt32(row.Cells["SOLUONGNHAP"].Value);
                    tonggianhap = tonggianhap + soluong * gianhappnh;
                }
                else
                {
                    MessageBox.Show("Số lượng không được để trống");
                }
            }
            tb_tongtiennh.Text = tonggianhap.ToString();
        }

        private void dgv_dsthuoc_pnh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_dsthuoc_pnh.RowCount != 0)
            {

                string sodk = dgv_dsthuoc_pnh.CurrentRow.Cells["SODKPNH"].Value.ToString();
                string tenThuoc = dgv_dsthuoc_pnh.CurrentRow.Cells["TENTHUOCPNH"].Value.ToString();
                double gianhap = Convert.ToDouble(dgv_dsthuoc_pnh.CurrentRow.Cells["GIANHAPPNH"].Value);
                int soluongnhap = 1;
                DateTime hsd = DateTime.Now;

                if (!dsthuoc_pnh.Contains(sodk))
                {
                    dsthuoc_pnh.Add(sodk);
                    dataTable_pnh.Rows.Add(sodk, tenThuoc, gianhap, soluongnhap, hsd);
                    dgv_phieunh.DataSource = dataTable_pnh;
                    tinhTongGiaNhap();
                    dgv_dsthuoc_pnh.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;
                }
            }
        }

        private void dgv_phieunh_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_phieunh.RowCount != 0)
            {

                string sodk = dgv_phieunh.CurrentRow.Cells["SODKPNH1"].Value.ToString();
                dsthuoc_pnh.Remove(sodk);
                dgv_phieunh.Rows.Remove(dgv_phieunh.CurrentRow);
                ((DataTable)dgv_phieunh.DataSource).AcceptChanges();
                tinhTongGiaNhap();
                foreach (DataGridViewRow row in dgv_dsthuoc_pnh.Rows)
                {
                    if (row.Cells["SODKPNH"].Value.ToString() == sodk)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void dgv_phieunh_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tinhTongGiaNhap();
        }
        private void btn_lappnh_Click(object sender, EventArgs e) //
        {
            if(tb_tongtiennh.Text.ToString() != "") {
                string maphieu = tb_maphieu.Text;
                DateTime nl = Convert.ToDateTime(dtp_ngaynh.Value);
                string ngaylap = nl.ToString("yyyy-MM-dd");
                double tonggianhap = Convert.ToDouble(tb_tongtiennh.Text);
                foreach (DataGridViewRow row in dgv_phieunh.Rows)
                {
                    if (row.Cells["SOLUONGNHAP"].Value.ToString() == "" || row.Cells["HSD"].Value.ToString() == "")
                    {
                        return;
                    }
                }
                bool check = PhieuNhapHangBUS.Instance.insertPhieuNhapHang(maphieu, ngaylap, tonggianhap);
                loadPhieuNhapHang();
                if (check)
                {
                    insertKhoThuoc();
                    disable();
                    pnl_dspn.Visible = true;
                    loadKhoThuoc();
                    loadThuocBanHang();
                }
            }
        }
        
        private DateTimePicker dateTimePicker;
        private void insertKhoThuoc()
        {
            string maphieu = tb_maphieu.Text;
            foreach (DataGridViewRow row in dgv_phieunh.Rows)
            {
                string sodk = Convert.ToString(row.Cells["SODKPNH1"].Value);
                int soluong = Convert.ToInt32(row.Cells["SOLUONGNHAP"].Value);
                DateTime hsddt = Convert.ToDateTime(row.Cells["HSD"].Value);
                string hsd = hsddt.ToString("yyyy-MM-dd");
                bool check = KhoThuocBUS.Instance.insertKhoThuoc(sodk, maphieu, hsd, soluong);
                bool check2 = ChiTietNhapHangBUS.Instance.insertChiTietNhapHang(maphieu, sodk, soluong);
            }
        }

        private void dgv_phieunh_CellClick(object sender, DataGridViewCellEventArgs e) //
        {
            if (e.ColumnIndex == 4)
            {
                dateTimePicker = new DateTimePicker();
                dgv_phieunh.Controls.Add(dateTimePicker);
                dateTimePicker.Format = DateTimePickerFormat.Short;
                Rectangle rectangle = dgv_phieunh.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dateTimePicker.Size = new Size(rectangle.Width, rectangle.Height);
                dateTimePicker.Location = new Point(rectangle.X, rectangle.Y);
                dateTimePicker.CloseUp += new EventHandler(datetimepicker_closeup);
                dateTimePicker.TextChanged += new EventHandler(datetimepicker_textchanged);
                dateTimePicker.Visible = true;
            }
        }

        private void datetimepicker_textchanged(object? sender, EventArgs e)
        {
            dgv_phieunh.CurrentCell.Value = dateTimePicker.Value.ToString();
        }

        private void datetimepicker_closeup(object? sender, EventArgs e)
        {
            dateTimePicker.Visible = false;
        }

        private void dgv_phieunh_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)  //
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Soluong_KeyPress);
            if (dgv_phieunh.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Soluong_KeyPress);
                }
            }
        }

        private void Soluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // END

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý học sinh";
                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                worksheet.Columns.AutoFit();
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void exportExcel(DataGridView dgv)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel |*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgv, sfd.FileName);
            }
        }
        private void btn_export_dmt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel |*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgv_dsthuoc, sfd.FileName);
            }
        }

        private void btn_themthuoc_Click_1(object sender, EventArgs e)
        {
            FAddThuoc fa = new FAddThuoc(this);
            fa.Show();
        }

        private void btn_suathuoc_Click(object sender, EventArgs e)
        {
            if(dgv_dsthuoc.RowCount > 0)
            {

                string sdk = dgv_dsthuoc.CurrentRow.Cells["SODK"].Value.ToString();
                string tenthuoc = dgv_dsthuoc.CurrentRow.Cells["TENTHUOC"].Value.ToString();
                string hoatchat = dgv_dsthuoc.CurrentRow.Cells["HOATCHAT"].Value.ToString();
                string donvitinh = dgv_dsthuoc.CurrentRow.Cells["DONVITINH"].Value.ToString();
                string qcdg = dgv_dsthuoc.CurrentRow.Cells["QUYCACHDONGGOI"].Value.ToString();
                string ncc = dgv_dsthuoc.CurrentRow.Cells["TENNCC"].Value.ToString();
                float gianhap = (float)Convert.ToDouble(dgv_dsthuoc.CurrentRow.Cells["GIANHAP"].Value);
                float giaban = (float)Convert.ToDouble(dgv_dsthuoc.CurrentRow.Cells["GIABAN"].Value);
                FAddThuoc f = new FAddThuoc(this, true, sdk, ncc, tenthuoc, hoatchat, donvitinh, qcdg, gianhap, giaban);
                f.Show();
            }
        }

        private void btn_xoathuoc_Click_1(object sender, EventArgs e)
        {
            if(dgv_dsthuoc.RowCount > 0)
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
        }

        private void btn_suancc_Click(object sender, EventArgs e)
        {
            if(dgv_ncc.RowCount > 0)
            {

                String mancc = dgv_ncc.CurrentRow.Cells["MANCC"].Value.ToString();
                String tenncc = dgv_ncc.CurrentRow.Cells["TENNCC1"].Value.ToString();
                String sdt = dgv_ncc.CurrentRow.Cells["SDTNCC"].Value.ToString();
                String diachi = dgv_ncc.CurrentRow.Cells["DIACHINCC"].Value.ToString();
                FAddNCC f = new FAddNCC(this, true, mancc, tenncc, sdt, diachi);
                f.Show();
            }
        }

        private void btn_themncc_Click(object sender, EventArgs e)
        {
            FAddNCC f = new FAddNCC(this);
            f.Show();
        }
        private void formatDate(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[3].Value = (Convert.ToDateTime(dgv.Rows[i].Cells[3].Value.ToString())).ToString("dd/MM/yyyy");
                //DateTime.ParseExact(dateInString, "M/d/yyyy", CultureInfo.InvariantCulture);
            }
        }
        private void btn_thuoc1t_Click(object sender, EventArgs e)
        {
            dgv_dsthuockt.DataSource = BUS.ThuocBUS.Instance.thongKeThuocTrongKho(0, 1);
        }

        private void btn_thuoc3t_Click(object sender, EventArgs e)
        {
            dgv_dsthuockt.DataSource = BUS.ThuocBUS.Instance.thongKeThuocTrongKho(0, 3);

        }

        private void btn_thuoc6t_Click(object sender, EventArgs e)
        {
            dgv_dsthuockt.DataSource = BUS.ThuocBUS.Instance.thongKeThuocTrongKho(0, 6);
        }

        private void btn_thuochet_Click(object sender, EventArgs e)
        {
            dgv_dsthuockt.DataSource = BUS.KhoThuocBUS.Instance.getThuocSapHetHan();

        }

        private void btn_khothuoc_exportExcel_Click(object sender, EventArgs e)
        {
            exportExcel(dgv_dsthuockt);
        }

        private void pb_reload_khothuoc_Click(object sender, EventArgs e)
        {
            dgv_dsthuockt.DataSource = khoThuocList;

        }

        private void tb_timkiemkt_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiemkt.Text != "")
            {
                string text_search = tb_timkiemkt.Text.ToString();
                DataTable dt = ThuocBUS.Instance.timThuocTrongKho(text_search);
                dgv_dsthuockt.DataSource = dt;
            }
            else
            {
                dgv_dsthuockt.DataSource = khoThuocList;

            }
        }

        private void pb_reload_dmt_Click(object sender, EventArgs e)
        {
            dgv_dsthuoc.DataSource = drugList;

        }

        private void btn_dspn_importExcel_Click(object sender, EventArgs e)
        {
            exportExcel(dgv_ctpn);
        }

        private void dgv_dspn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_dspn.Rows.Count != 0)
            {
                string maphieu = dgv_dspn.CurrentRow.Cells["MAPHIEU"].Value.ToString();
                dgv_ctpn.DataSource = ChiTietNhapHangBUS.Instance.getChiTietNhapHang(maphieu);
            }
        }

        private void tb_timkiemNH_TextChanged(object sender, EventArgs e)
        {
            if(tb_timkiemNH.Text.ToString() != "")
            {
                if (cbb_nccNH.SelectedValue != null)
                    dgv_dsthuoc_pnh.DataSource = BUS.ThuocBUS.Instance.timthuocNH(tb_timkiemNH.Text.ToString(), cbb_nccNH.SelectedValue.ToString());
            } else
            {
                dgv_dsthuoc_pnh.DataSource = drugPNHList;

            }
        }




















        // In
        

        private void btn_inphieunh_Click(object sender, EventArgs e)
        {

            
            // Thiết lập các thông số cho bản in
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            // Hiển thị hộp thoại Print Preview để xem trước bản in
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            

            // In bản in
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            // Khởi tạo biến để lưu trữ thông tin in hóa đơn
            int x = 50;
            int y = 50;
            int rowheight = 0;
            int columnwidth = 0;
            String title = "PHIẾU NHẬP HÀNG";
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            float titleX = e.PageBounds.Width / 2 - titleSize.Width / 2;
            float titleY = y;

            // Vẽ tiêu đề cho hóa đơn
            e.Graphics.DrawString(title, titleFont, Brushes.Black, new PointF(titleX, titleY));
            y += Convert.ToInt32(titleSize.Height + 50);

            // Vẽ các tên cột của bảng dữ liệu
            /*for (int i = 0; i < dgv_phieunh.Columns.Count; i++)
            {
                columnwidth = dgv_phieunh.Columns[i].Width;
                 e.Graphics.FillRectangle(Brushes.LightGray, new System.Drawing.Rectangle(x, y, columnwidth, rowheight));
                 e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(x, y, columnwidth, rowheight));
                 e.Graphics.DrawString(dgv_phieunh.Columns[i].HeaderText, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight));
                 x += columnwidth;
                
                columnwidth = dgv_phieunh.Columns[i].Width;
                e.Graphics.FillRectangle(Brushes.LightGray, new RectangleF(x, y, columnwidth, rowheight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, columnwidth, rowheight));
                string columnName = dgv_phieunh.Columns[i].HeaderText;
                Font columnFont = new Font("Arial", 12, FontStyle.Bold);
                SizeF columnSize = e.Graphics.MeasureString(columnName, columnFont);
                float columnX = x + columnwidth / 2 - columnSize.Width / 2;
                float columnY = y + rowheight / 2 - columnSize.Height / 2;
                e.Graphics.DrawString(columnName, columnFont, Brushes.Black, new PointF(columnX, columnY));
                x += columnwidth;
            } 

            // Vẽ dữ liệu cho từng hàng trong bảng
            x = 50;
            y += 30;
            for (int i = 0; i < dgv_phieunh.Rows.Count; i++)
            {
                rowheight = dgv_phieunh.Rows[i].Height;
                for (int j = 0; j < dgv_phieunh.Columns.Count; j++)
                {
                    columnwidth = dgv_phieunh.Columns[j].Width;
                    e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(x, y, columnwidth, rowheight));
                    e.Graphics.DrawString(dgv_phieunh.Rows[i].Cells[j].FormattedValue.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight));
                    x += columnwidth;
                }
                x = 50;
                y += rowheight;
            }
            */
            // tính tổng chiều rộng của các cột
            int totalColumnWidth = 0;
            for (int i = 0; i < dgv_phieunh.Columns.Count; i++)
            {
                totalColumnWidth += dgv_phieunh.Columns[i].Width;
            }

            // tính tỉ lệ thu nhỏ để lấp đầy chiều ngang trên trang in
            float scaleFactor = (float)e.MarginBounds.Width / (float)totalColumnWidth;

            // Vẽ các tên cột của bảng dữ liệu
            for (int i = 0; i < dgv_phieunh.Columns.Count; i++)
            {
                columnwidth = (int)(dgv_phieunh.Columns[i].Width * scaleFactor);
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, columnwidth, rowheight));
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 2), new Rectangle(x, y, columnwidth, rowheight));
                e.Graphics.DrawString(dgv_phieunh.Columns[i].HeaderText, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                x += columnwidth;
            }

            // Vẽ dữ liệu cho từng hàng trong bảng
            x = 50;
            y += 30;
            for (int i = 0; i < dgv_phieunh.Rows.Count; i++)
            {
                rowheight = dgv_phieunh.Rows[i].Height;
                for (int j = 0; j < dgv_phieunh.Columns.Count; j++)
                {
                    columnwidth = (int)(dgv_phieunh.Columns[j].Width * scaleFactor);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, columnwidth, rowheight));
                    e.Graphics.DrawString(dgv_phieunh.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Arial", 12), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    x += columnwidth;
                }
                x = 50;
                y += rowheight;
            }
        }

        private void btn_export_cthd_Click(object sender, EventArgs e)
        {
            exportExcel(dgv_cthd);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            pnl_onqlbh.Height = btn_qlbh.Height;
            pnl_onqlbh.Top = btn_qlbh.Top;
            disable();
            pnl_dshd_qlbh.Visible = true;
            pnl_onqlbh.Visible = true;
        }

        private void txtb_tienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if(txt_tongTien.Text != "" && txtb_tienKhachDua.Text != "")
                txtb_tienTraLai.Text = (Convert.ToDouble(txtb_tienKhachDua.Text) - Convert.ToDouble(txt_tongTien.Text)).ToString();
        }

        private void btn_luuhd_Click(object sender, EventArgs e)
        {
            if (txt_tongTien.Text.ToString() != "" && txtb_tienKhachDua.Text.ToString() != "" &&
                tb_sdt_qlbh.Text.ToString() != "")
            {
                string mahd = tb_maHoaDon.Text;
                string sdtkh = tb_sdt_qlbh.Text;
                string tenkh = tb_tenkh.Text;
                DateTime nx = Convert.ToDateTime(dtp_hoadon.Value);
                string ngayxuat = nx.ToString("yyyy-MM-dd");
                double tongtien = Convert.ToDouble(txt_tongTien.Text);
                foreach (DataGridViewRow row in dgv_bh_hoaDon.Rows)
                {
                    string sodk = row.Cells["SODK_HD"].Value.ToString();
                    string maphieu = row.Cells["MAPHIEU_HD"].Value.ToString();

                    if (row.Cells["SOLUONG_HD"].Value.ToString() == "")
                    {
                        MessageBox.Show("Chưa nhập số lượng");
                        return;
                    }
                    else if (Convert.ToInt32(row.Cells["SOLUONG_HD"].Value) > KhoThuocBUS.Instance.getSLKhoThuoc(sodk, maphieu))
                    {
                        MessageBox.Show("Số lượng trong hóa đơn nhiều hơn trong kho");
                        return;
                    }
                }

                List<string> listKH = new List<string>();
                DataTable dtkh = KhachHangBUS.Instance.getAllCustomer();
                foreach (DataRow dr in dtkh.Rows)
                {
                    listKH.Add(dr["SDT"].ToString());
                }
                if (!listKH.Contains(sdtkh))
                {
                    bool checkKH = KhachHangBUS.Instance.insertKhachHang(sdtkh, tenkh);
                }
                bool check = HoaDonBUS.Instance.insertHoaDon(mahd, sdtkh, this.sdtStaff, ngayxuat, tongtien);
                loadHoaDon();
                if (check)
                {
                    double diem = tongtien / 10000;
                    bool chechCongDiem = KhachHangBUS.Instance.updateDiem(sdtkh, diem);
                    loadKhachHang();
                    insertChiTietHoaDon();
                    loadThuocBanHang();
                    disable();
                    pnl_dshd_qlbh.Visible = true;
                    tb_sdt_qlbh.Text = "";
                    tb_tenkh.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Còn thông tin chưa được nhập");
            }
        }
        private void insertChiTietHoaDon()
        {
            string mahd = tb_maHoaDon.Text;
            foreach (DataGridViewRow row in dgv_bh_hoaDon.Rows)
            {
                string sodk = Convert.ToString(row.Cells["SODK_HD"].Value);
                string maphieu = Convert.ToString(row.Cells["MAPHIEU_HD"].Value);
                int soluong = Convert.ToInt32(row.Cells["SOLUONG_HD"].Value);
                bool check = ChiTietHoaDonBUS.Instance.insertChiTietHoaDon(mahd, sodk, soluong);
                if (check)
                {
                    bool checkUpdateSL = KhoThuocBUS.Instance.updateSoLuong(sodk, maphieu, soluong);
                }
            }
            loadKhoThuoc();
        }
        void loadSoLuongVaTongTien(String date1, String date2)
        {
            string soluong = BUS.HoaDonBUS.Instance.getSoLuongHoaDonTheoNgay(date1, date2).ToString();
            string tongtien = BUS.HoaDonBUS.Instance.getTongTien(date1, date2).ToString();
            tb_slhd.Text = soluong;
            tb_tongdt.Text = tongtien;
        }
        private void dtp_ngaykt_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(dtp_ngaybd.Value);
            string date1 = dt1.ToString("yyyy-MM-dd");
            DateTime dt2 = Convert.ToDateTime(dtp_ngaykt.Value);
            string date2 = dt2.ToString("yyyy-MM-dd");
            loadBaoCaoHD(date1, date2);
            loadSoLuongVaTongTien(date1, date2);
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            DateTime dt1 = Convert.ToDateTime(dtp_ngaybd.Value);
            string date1 = dt1.ToString("yyyy-MM-dd");
            DateTime dt2 = Convert.ToDateTime(dtp_ngaykt.Value);
            string date2 = dt2.ToString("yyyy-MM-dd");
            loadBaoCaoHD(date1, date2);
            loadSoLuongVaTongTien(date1, date2);
        }

        private void dgv_bh_hoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_bh_hoaDon.RowCount > 0)
            {

                string sodk = dgv_bh_hoaDon.CurrentRow.Cells["SODK_HD"].Value.ToString();
                string maphieu = dgv_bh_hoaDon.CurrentRow.Cells["MAPHIEU_HD"].Value.ToString();
                dsthuoc_banhang.Remove(sodk);
                dgv_bh_hoaDon.Rows.Remove(dgv_bh_hoaDon.CurrentRow);
                ((DataTable)dgv_bh_hoaDon.DataSource).AcceptChanges();
                tinhTienBanHang();
                foreach (DataGridViewRow row in dgv_bh_danhMucThuoc.Rows)
                {
                    if (row.Cells["SODK_BH"].Value.ToString() == sodk &&
                        row.Cells["MAPHIEU_BH"].Value.ToString() == maphieu)
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }

        private void dgv_bh_hoaDon_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Soluong_KeyPress);
            if (dgv_bh_hoaDon.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Soluong_KeyPress);
                }
            }
        }

        private void txtb_tienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgv_bh_hoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tinhTienBanHang();
        }

        private void tb_sdt_qlbh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgv_dshd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_dshd.Rows.Count != 0)
            {

                string mahd = dgv_dshd.CurrentRow.Cells["MAHD"].Value.ToString();
                dgv_cthd.DataSource = ChiTietHoaDonBUS.Instance.getChiTietHoaDon(mahd);
            }
        }

        private void btn_bcdoanhthu_importExcel_Click(object sender, EventArgs e)
        {
            exportExcel(dgv_doanhthu);
        }

        private void btn_thuocbanchay_Click(object sender, EventArgs e)
        {
            FThuocBanChay f = new FThuocBanChay();
            f.Show();  
        }

        private void dgv_bh_danhMucThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_bh_danhMucThuoc.RowCount > 0)
            {

                string sodk = dgv_bh_danhMucThuoc.CurrentRow.Cells["SODK_BH"].Value.ToString();
                string tenThuoc = dgv_bh_danhMucThuoc.CurrentRow.Cells["TENTHUOC_BH"].Value.ToString();
                string maphieu = dgv_bh_danhMucThuoc.CurrentRow.Cells["MAPHIEU_BH"].Value.ToString();
                double giaban = Convert.ToDouble(dgv_bh_danhMucThuoc.CurrentRow.Cells["GIABAN_BH"].Value);
                int soluongnhap = 1;

                if (!dsthuoc_banhang.Contains(sodk))
                {
                    dsthuoc_banhang.Add(sodk);
                    dataTable_banhang.Rows.Add(sodk, tenThuoc, maphieu, giaban, soluongnhap);
                    dgv_bh_hoaDon.DataSource = dataTable_banhang;
                    tinhTienBanHang();
                    dgv_bh_danhMucThuoc.CurrentRow.DefaultCellStyle.BackColor = Color.Aqua;
                }
            }
        }

        private void btn_inHoaDon_Click(object sender, EventArgs e)
        {
            // Thiết lập các thông số cho bản in
            printDocument3.DefaultPageSettings.Landscape = true;
            printDocument3.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            // Hiển thị hộp thoại Print Preview để xem trước bản in
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument3;


            // In bản in
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument3.Print();
            }
        }

        void stateLanguage(bool isVN)
        {
            if (isVN)
            {
                btn_dangxuat.Text = "Đăng xuất";
                btn_qlnv.Text = "Quản lý nhân viên";
                btn_qlnh.Text = "Quản lý nhập hàng";
                btn_qlbh.Text = "Quản lý bán hàng";
                btn_qlkh.Text = "Quản lý khách hàng";
                btn_qlncc.Text = "Quản lý nhà cung cấp";
                btn_qlnh.Text = "Quản lý nhập hàng";
                btn_bcthuoc.Text = "Quản lý thuốc";
                btn_bcdoanhthu.Text = "Báo cáo doanh thu";
                lb_designer.Text = "Thiết kế bởi";
                btn_dmthuoc.Text = "   Danh mục thuốc";
                btn_khothuoc.Text = "   Kho thuốc";
                lbl_dsnv.Text = "Danh sách nhân viên";
                btn_themnv.Text = "Thêm";
                btn_suanv.Text = "Sửa";
                btn_xoanv.Text = "Xóa";
                dgv_nv.Columns[0].HeaderText = "Số điện thoại";
                dgv_nv.Columns[1].HeaderText = "Họ tên";
                dgv_nv.Columns[2].HeaderText = "Địa chỉ";
                dgv_nv.Columns[3].HeaderText = "Mật khẩu";
                lb_qlkh.Text = "Danh sách khách hàng";
                dgv_qlkh.Columns[0].HeaderText = "Số điện thoại";
                dgv_qlkh.Columns[1].HeaderText = "Họ tên";
                dgv_qlkh.Columns[2].HeaderText = "Tích điểm";
                btn_themkh.Text = "Thêm";
                btn_suakh.Text = "Sửa";
                btn_xoakh.Text = "Xóa";
                lb_qlncc.Text = "Danh sách nhà cung cấp";
                dgv_ncc.Columns[0].HeaderText = "Mã nhà cung cấp";
                dgv_ncc.Columns[1].HeaderText = "Tên nhà cung cấp";
                dgv_ncc.Columns[2].HeaderText = "Số điện thoại";
                dgv_ncc.Columns[3].HeaderText = "Địa chỉ";
                btn_themncc.Text = "Thêm";
                btn_suancc.Text = "Sửa";
                btn_xoancc.Text = "Xóa";

                lb_dsthuockho.Text = "Danh sách thuốc trong kho";
                tb_timkiemkt.PlaceholderText = "Nhập tên thuốc";
                dgv_dsthuockt.Columns[0].HeaderText = "Số đăng ký";
                dgv_dsthuockt.Columns[1].HeaderText = "Tên thuốc";
                dgv_dsthuockt.Columns[2].HeaderText = "Mã phiếu";
                dgv_dsthuockt.Columns[3].HeaderText = "Hạn sử dụng (ngày)";
                dgv_dsthuockt.Columns[4].HeaderText = "Số lượng";
                btn_khothuoc_exportExcel.Text = "Xuất File Excel";
                btn_thuochet.Text = "Thuốc sắp hết";
                btn_thuoc6t.Text = "Thuốc còn hạn 6 tháng";
                btn_thuoc3t.Text = "Thuốc còn hạn 3 tháng";
                btn_thuoc1t.Text = "Thuốc còn hạn 1 tháng";

                lb_dsthuoc.Text = "Danh mục thuốc";
                tb_timkiem.PlaceholderText = "Nhập tên thuốc";
                dgv_dsthuoc.Columns[0].HeaderText = "Số đăng ký";
                dgv_dsthuoc.Columns[1].HeaderText = "Tên thuốc";
                dgv_dsthuoc.Columns[2].HeaderText = "Hoạt chất";
                dgv_dsthuoc.Columns[3].HeaderText = "Đơn vị tính";
                dgv_dsthuoc.Columns[4].HeaderText = "Quy cách đóng gói";
                dgv_dsthuoc.Columns[5].HeaderText = "Nhà cung cấp";
                dgv_dsthuoc.Columns[6].HeaderText = "Giá nhập";
                dgv_dsthuoc.Columns[7].HeaderText = "Giá bán";
                btn_thuocbanchay.Text = "Thống kê thuốc bán chạy trong tháng";
                btn_export_dmt.Text = "Xuất File Excel";
                btn_themthuoc.Text = "Thêm";
                btn_suathuoc.Text = "Sửa";
                btn_xoathuoc.Text = "Xóa";

                lb_bcdoanhthu.Text = "Báo cáo doanh thu";
                lb_batdaubc.Text = "Ngày bắt đầu";
                lb_ketthucbc.Text = "Ngày kết thúc";
                dgv_doanhthu.Columns[0].HeaderText = "Mã hóa đơn";
                dgv_doanhthu.Columns[1].HeaderText = "Số điện thoại khách hàng";
                dgv_doanhthu.Columns[2].HeaderText = "Ngày xuất";
                dgv_doanhthu.Columns[3].HeaderText = "Thành tiền";
                btn_bcdoanhthu_importExcel.Text = "Xuất File Excel";
                lb_slhd.Text = "Tổng hóa đơn";
                lb_tongdt.Text = "Tổng doanh thu";

                lb_dspn.Text = "Danh sách phiếu nhập hàng";
                lb_ctpn.Text = "Chi tiết phiếu nhập hàng";
                btn_lapPhieuNhap.Text = "Lập phiếu nhập hàng";
                btn_dspn_importExcel.Text = "Xuất File Excel";
                dgv_dspn.Columns[0].HeaderText = "Mã phiếu";
                dgv_dspn.Columns[1].HeaderText = "Ngày lập";
                dgv_dspn.Columns[2].HeaderText = "Tổng giá nhập";
                dgv_ctpn.Columns[0].HeaderText = "Số đăng ký";
                dgv_ctpn.Columns[1].HeaderText = "Tên thuốc";
                dgv_ctpn.Columns[2].HeaderText = "Giá nhập";
                dgv_ctpn.Columns[3].HeaderText = "Số lượng";

                lb_dmthuocnh.Text = "Danh mục thuốc";
                cbb_nccNH.Text = "Chọn nhà cung cấp";
                tb_timkiemNH.PlaceholderText = "Nhập tên thuốc";
                dgv_dsthuoc_pnh.Columns[0].HeaderText = "Số đăng ký";
                dgv_dsthuoc_pnh.Columns[1].HeaderText = "Tên thuốc";
                dgv_dsthuoc_pnh.Columns[2].HeaderText = "Hoạt chất";
                dgv_dsthuoc_pnh.Columns[3].HeaderText = "Giá nhập";
                lb_phieunh.Text = "Phiếu nhập hàng";
                lb_ngaynh.Text = "Ngày";
                lb_maphieu.Text = "Mã phiếu";
                dgv_phieunh.Columns[0].HeaderText = "Số đăng ký";
                dgv_phieunh.Columns[1].HeaderText = "Tên thuốc";
                dgv_phieunh.Columns[2].HeaderText = "Giá nhập";
                dgv_phieunh.Columns[3].HeaderText = "Số lượng";
                dgv_phieunh.Columns[4].HeaderText = "HSD";
                gb_thanhtoanhd.Text = "THANH TOÁN PHIẾU NHẬP HÀNG";
                lb_tongtiennh.Text = "Tổng tiền";
                btn_inphieunh.Text = "In phiếu";
                btn_lappnh.Text = "Lưu";
                btn_huylapphieu.Text = "Thoát";
                //CODE CUA TIEN
                lb_dshd.Text = "Danh sách hóa đơn";
                dgv_dshd.Columns[0].HeaderText = "Mã hóa đơn";
                dgv_dshd.Columns[1].HeaderText = "SDT Khách";
                dgv_dshd.Columns[2].HeaderText = "SDT Nhân viên";
                dgv_dshd.Columns[3].HeaderText = "Ngày xuất";
                dgv_dshd.Columns[4].HeaderText = "Tổng tiền";
                lb_cthd.Text = "Chi tiết hóa đơn";
                dgv_cthd.Columns[0].HeaderText = "Số đăng ký";
                dgv_cthd.Columns[1].HeaderText = "Tên thuốc";
                dgv_cthd.Columns[2].HeaderText = "Giá bán";
                dgv_cthd.Columns[3].HeaderText = "Số lượng";
                btn_laphd_qlbh.Text = "Lập hóa đơn";
                btn_export_cthd.Text = "Xuất File Excel";

                lb_tenkh.Text = "Tên khách hàng";
                lb_sdt.Text = "Số điện thoại";
                dgv_bh_danhMucThuoc.Columns[0].HeaderText = "Số đăng ký";
                dgv_bh_danhMucThuoc.Columns[1].HeaderText = "Tên thuốc";
                dgv_bh_danhMucThuoc.Columns[2].HeaderText = "Mã phiếu nhập";
                dgv_bh_danhMucThuoc.Columns[3].HeaderText = "HSD";
                dgv_bh_danhMucThuoc.Columns[4].HeaderText = "Số lượng tồn kho";
                dgv_bh_danhMucThuoc.Columns[5].HeaderText = "Giá bán";
                tb_timKiemThuoc.PlaceholderText = "Nhập tên thuốc";
                lb_bh_danhMucThuoc.Text = "Kho thuốc";
                lb_maHoaDon.Text = "Mã hóa đơn";
                gb_thanhToanHoaDon.Text = "THANH TOÁN HÓA ĐƠN";
                btn_inHoaDon.Text = "In hóa đơn";
                btn_thoat.Text = "Thoát";
                btn_luuhd.Text = "Lưu";
                lb_tralai.Text = "Trả lại";
                lb_khachdua.Text = "Khách đưa";
                lb_tongtien.Text = "Tổng tiền";
                lbl_bh_ngay.Text = "Ngày";
                lbl_hoaDonBanHang.Text = "HÓA ĐƠN BÁN HÀNG";
                dgv_bh_hoaDon.Columns[0].HeaderText = "Số đăng ký";
                dgv_bh_hoaDon.Columns[1].HeaderText = "Tên thuốc";
                dgv_bh_hoaDon.Columns[2].HeaderText = "Mã phiếu nhập";
                dgv_bh_hoaDon.Columns[3].HeaderText = "Giá bán";
                dgv_bh_hoaDon.Columns[4].HeaderText = "Số lượng";
            }
            else
            {
                btn_dangxuat.Text = "Log out";
                btn_qlnv.Text = "Staff Management";
                btn_qlnh.Text = "Order Management";
                btn_qlbh.Text = "Sale Management";
                btn_qlkh.Text = "Customer Management";
                btn_qlncc.Text = "Supplier Management";
                btn_qlnh.Text = "Import Drugs Management";
                btn_bcthuoc.Text = "Drugs Management";
                btn_bcdoanhthu.Text = "Revenue report";
                lb_designer.Text = "Design by";
                btn_dmthuoc.Text = "   Drug Formulary";
                btn_khothuoc.Text = "   Pharmacy";
                lbl_dsnv.Text = "Staff list";
                btn_themnv.Text = "Add";
                btn_suanv.Text = "Edit";
                btn_xoanv.Text = "Delete";
                dgv_nv.Columns[0].HeaderText = "Phone";
                dgv_nv.Columns[1].HeaderText = "Fullname";
                dgv_nv.Columns[2].HeaderText = "Address";
                dgv_nv.Columns[3].HeaderText = "Password";
                lb_qlkh.Text = "Customer List";
                dgv_qlkh.Columns[0].HeaderText = "Phone";
                dgv_qlkh.Columns[1].HeaderText = "Fullname";
                dgv_qlkh.Columns[2].HeaderText = "Point";
                btn_themkh.Text = "Add";
                btn_suakh.Text = "Edit";
                btn_xoakh.Text = "Delete";
                lb_qlncc.Text = "Supplier List";
                dgv_ncc.Columns[0].HeaderText = "Supplier Code";
                dgv_ncc.Columns[1].HeaderText = "Supplier Name";
                dgv_ncc.Columns[2].HeaderText = "Phone";
                dgv_ncc.Columns[3].HeaderText = "Address";
                btn_themncc.Text = "Add";
                btn_suancc.Text = "Edit";
                btn_xoancc.Text = "Delete";

                lb_dsthuockho.Text = "Drugs List In Pharmacy";
                tb_timkiemkt.PlaceholderText = "Enter drug name";
                dgv_dsthuockt.Columns[0].HeaderText = "Registration number";
                dgv_dsthuockt.Columns[1].HeaderText = "Name";
                dgv_dsthuockt.Columns[2].HeaderText = "Import ID";
                dgv_dsthuockt.Columns[3].HeaderText = "Expiry Date";
                dgv_dsthuockt.Columns[4].HeaderText = "Quantity";
                btn_khothuoc_exportExcel.Text = "Export to Excel";
                btn_thuochet.Text = "Insufficient Drugs";
                btn_thuoc6t.Text = "6 months expired medicine";
                btn_thuoc3t.Text = "3 months expired medicine";
                btn_thuoc1t.Text = "1 months expired medicine";


                lb_dsthuoc.Text = "Drug Formulary";
                tb_timkiem.PlaceholderText = "Enter drug name";
                dgv_dsthuoc.Columns[0].HeaderText = "Registration number";
                dgv_dsthuoc.Columns[1].HeaderText = "Name";
                dgv_dsthuoc.Columns[2].HeaderText = "Active Ingredient";
                dgv_dsthuoc.Columns[3].HeaderText = "Unit";
                dgv_dsthuoc.Columns[4].HeaderText = "Packing Style";
                dgv_dsthuoc.Columns[5].HeaderText = "Supplier";
                dgv_dsthuoc.Columns[6].HeaderText = "Import price";
                dgv_dsthuoc.Columns[7].HeaderText = "Sale price";
                btn_thuocbanchay.Text = "Sellers of the month";
                btn_export_dmt.Text = "Export to Excel";
                btn_themthuoc.Text = "Add";
                btn_suathuoc.Text = "Edit";
                btn_xoathuoc.Text = "Delete";

                lb_bcdoanhthu.Text = "Revenue Report";
                lb_batdaubc.Text = "Start";
                lb_ketthucbc.Text = "End";
                dgv_doanhthu.Columns[0].HeaderText = "Bill ID";
                dgv_doanhthu.Columns[1].HeaderText = "Customer's Phone";
                dgv_doanhthu.Columns[2].HeaderText = "Date";
                dgv_doanhthu.Columns[3].HeaderText = "Total";
                btn_bcdoanhthu_importExcel.Text = "Export to Excel";
                lb_slhd.Text = "Total bill";
                lb_tongdt.Text = "Total revenue";

                lb_dspn.Text = "Import coupons list";
                lb_ctpn.Text = "Detail import coupons";
                btn_lapPhieuNhap.Text = "Create import coupon";
                btn_dspn_importExcel.Text = "Export to Excel";
                dgv_dspn.Columns[0].HeaderText = "Import ID";
                dgv_dspn.Columns[1].HeaderText = "Date";
                dgv_dspn.Columns[2].HeaderText = "Total";
                dgv_ctpn.Columns[0].HeaderText = "Registration number";
                dgv_ctpn.Columns[1].HeaderText = "Name";
                dgv_ctpn.Columns[2].HeaderText = "Import price";
                dgv_ctpn.Columns[3].HeaderText = "Quantity";

                lb_dmthuocnh.Text = "Drug Formulary";
                cbb_nccNH.Text = "Choose supplier";
                tb_timkiemNH.PlaceholderText = "Enter drug name";
                dgv_dsthuoc_pnh.Columns[0].HeaderText = "Registration number";
                dgv_dsthuoc_pnh.Columns[1].HeaderText = "Name";
                dgv_dsthuoc_pnh.Columns[2].HeaderText = "Active Ingredient";
                dgv_dsthuoc_pnh.Columns[3].HeaderText = "Import price";
                lb_phieunh.Text = "Import Coupon";
                lb_ngaynh.Text = "Date";
                lb_maphieu.Text = "Import ID";
                dgv_phieunh.Columns[0].HeaderText = "Registration number";
                dgv_phieunh.Columns[1].HeaderText = "Name";
                dgv_phieunh.Columns[2].HeaderText = "Import price";
                dgv_phieunh.Columns[3].HeaderText = "Quantity";
                dgv_phieunh.Columns[4].HeaderText = "Expiry";
                gb_thanhtoanhd.Text = "PAYMENT";
                lb_tongtiennh.Text = "Total";
                btn_inphieunh.Text = "Print";
                btn_lappnh.Text = "Save";
                btn_huylapphieu.Text = "Exit";

                //CODE CUA TIEN
                lb_dshd.Text = "Bill list";
                dgv_dshd.Columns[0].HeaderText = "Bill ID";
                dgv_dshd.Columns[1].HeaderText = "Customer's Phone";
                dgv_dshd.Columns[2].HeaderText = "Staff's Phone";
                dgv_dshd.Columns[3].HeaderText = "Date";
                dgv_dshd.Columns[4].HeaderText = "Total";
                lb_cthd.Text = "Bill details";
                dgv_cthd.Columns[0].HeaderText = "Registration number";
                dgv_cthd.Columns[1].HeaderText = "Name";
                dgv_cthd.Columns[2].HeaderText = "Sale price";
                dgv_cthd.Columns[3].HeaderText = "Quantity";
                btn_laphd_qlbh.Text = "Create new bill";
                btn_export_cthd.Text = "Export to Excel";

                lb_tenkh.Text = "Customer name";
                lb_sdt.Text = "Phone number";
                dgv_bh_danhMucThuoc.Columns[0].HeaderText = "Registration number";
                dgv_bh_danhMucThuoc.Columns[1].HeaderText = "Name";
                dgv_bh_danhMucThuoc.Columns[2].HeaderText = "Import ID";
                dgv_bh_danhMucThuoc.Columns[3].HeaderText = "Expiry";
                dgv_bh_danhMucThuoc.Columns[4].HeaderText = "Quantity in stock";
                dgv_bh_danhMucThuoc.Columns[5].HeaderText = "Sale price";
                tb_timKiemThuoc.PlaceholderText = "Enter medicine name";
                lb_bh_danhMucThuoc.Text = "Drug store";
                lb_maHoaDon.Text = "Bill ID";
                gb_thanhToanHoaDon.Text = "BILL PAYMENT";
                btn_inHoaDon.Text = "Print bill";
                btn_thoat.Text = "Cancel";
                btn_luuhd.Text = "Save";
                lb_tralai.Text = "Return";
                lb_khachdua.Text = "Receive";
                lb_tongtien.Text = "Total";
                lbl_bh_ngay.Text = "Date";
                lbl_hoaDonBanHang.Text = "SALING BILL";
                dgv_bh_hoaDon.Columns[0].HeaderText = "Registration number";
                dgv_bh_hoaDon.Columns[1].HeaderText = "Name";
                dgv_bh_hoaDon.Columns[2].HeaderText = "Import ID";
                dgv_bh_hoaDon.Columns[3].HeaderText = "Sale price";
                dgv_bh_hoaDon.Columns[4].HeaderText = "Quantity";

            }
        }
        private bool isVN=true;
        private void btn_language_Click(object sender, EventArgs e)
        {
            isVN = !isVN;
            stateLanguage(isVN);
        }

        private void btn_themthuoc_lappnh_Click(object sender, EventArgs e)
        {
            cbb_nccNH.ValueMember = "MANCC";
            string ncc = cbb_nccNH.SelectedValue.ToString();

            FAddThuoc f = new FAddThuoc(this, false, "", ncc, "", "", "", "", 0, 0);
            f.Show();
        }

        private void tb_timKiemThuoc_TextChanged(object sender, EventArgs e)
        {
            String text = tb_timKiemThuoc.Text.ToString();
            if (!String.IsNullOrEmpty(text))
                dgv_bh_danhMucThuoc.DataSource = ThuocBUS.Instance.timThuocBH(text);
            else
                dgv_bh_danhMucThuoc.DataSource = ThuocBanHangList;

        }

        private void printDocument3_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Khởi tạo biến để lưu trữ thông tin in hóa đơn
            int x = 50;
            int y = 50;
            int rowheight = 0;
            int columnwidth = 0;
            String title = "HÓA ĐƠN";
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            float titleX = e.PageBounds.Width / 2 - titleSize.Width / 2;
            float titleY = y;

            // Vẽ tiêu đề cho hóa đơn
            e.Graphics.DrawString(title, titleFont, Brushes.Black, new PointF(titleX, titleY));
            y += Convert.ToInt32(titleSize.Height + 50);

            // Vẽ các tên cột của bảng dữ liệu
            /*for (int i = 0; i < dgv_phieunh.Columns.Count; i++)
            {
                columnwidth = dgv_phieunh.Columns[i].Width;
                 e.Graphics.FillRectangle(Brushes.LightGray, new System.Drawing.Rectangle(x, y, columnwidth, rowheight));
                 e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(x, y, columnwidth, rowheight));
                 e.Graphics.DrawString(dgv_phieunh.Columns[i].HeaderText, new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight));
                 x += columnwidth;
                
                columnwidth = dgv_phieunh.Columns[i].Width;
                e.Graphics.FillRectangle(Brushes.LightGray, new RectangleF(x, y, columnwidth, rowheight));
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, columnwidth, rowheight));
                string columnName = dgv_phieunh.Columns[i].HeaderText;
                Font columnFont = new Font("Arial", 12, FontStyle.Bold);
                SizeF columnSize = e.Graphics.MeasureString(columnName, columnFont);
                float columnX = x + columnwidth / 2 - columnSize.Width / 2;
                float columnY = y + rowheight / 2 - columnSize.Height / 2;
                e.Graphics.DrawString(columnName, columnFont, Brushes.Black, new PointF(columnX, columnY));
                x += columnwidth;
            } 

            // Vẽ dữ liệu cho từng hàng trong bảng
            x = 50;
            y += 30;
            for (int i = 0; i < dgv_phieunh.Rows.Count; i++)
            {
                rowheight = dgv_phieunh.Rows[i].Height;
                for (int j = 0; j < dgv_phieunh.Columns.Count; j++)
                {
                    columnwidth = dgv_phieunh.Columns[j].Width;
                    e.Graphics.DrawRectangle(Pens.Black, new System.Drawing.Rectangle(x, y, columnwidth, rowheight));
                    e.Graphics.DrawString(dgv_phieunh.Rows[i].Cells[j].FormattedValue.ToString(), new System.Drawing.Font("Arial", 12), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight));
                    x += columnwidth;
                }
                x = 50;
                y += rowheight;
            }
            */
            // tính tổng chiều rộng của các cột
            int totalColumnWidth = 0;
            for (int i = 0; i < dgv_bh_hoaDon.Columns.Count; i++)
            {
                totalColumnWidth += dgv_bh_hoaDon.Columns[i].Width;
            }

            // tính tỉ lệ thu nhỏ để lấp đầy chiều ngang trên trang in
            float scaleFactor = (float)e.MarginBounds.Width / (float)totalColumnWidth;

            // Vẽ các tên cột của bảng dữ liệu
            for (int i = 0; i < dgv_bh_hoaDon.Columns.Count; i++)
            {
                columnwidth = (int)(dgv_bh_hoaDon.Columns[i].Width * scaleFactor);
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(x, y, columnwidth, rowheight));
                e.Graphics.DrawRectangle(new Pen(Brushes.Black, 2), new Rectangle(x, y, columnwidth, rowheight));
                e.Graphics.DrawString(dgv_bh_hoaDon.Columns[i].HeaderText, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                x += columnwidth;
            }

            // Vẽ dữ liệu cho từng hàng trong bảng
            x = 50;
            y += 30;
            for (int i = 0; i < dgv_bh_hoaDon.Rows.Count; i++)
            {
                rowheight = dgv_bh_hoaDon.Rows[i].Height;
                for (int j = 0; j < dgv_bh_hoaDon.Columns.Count; j++)
                {
                    columnwidth = (int)(dgv_bh_hoaDon.Columns[j].Width * scaleFactor);
                    e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x, y, columnwidth, rowheight));
                    e.Graphics.DrawString(dgv_bh_hoaDon.Rows[i].Cells[j].FormattedValue.ToString(), new Font("Arial", 12), Brushes.Black, new RectangleF(x, y, columnwidth, rowheight), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    x += columnwidth;
                }
                x = 50;
                y += rowheight;
            }
            String total = "TỔNG TIỀN: " + txt_tongTien.Text.ToString();
            Font totalFont = new Font("Arial", 12, FontStyle.Bold);
            SizeF totalSize = e.Graphics.MeasureString(total, totalFont);
            float totalX = e.PageBounds.Width / 2 - totalSize.Width / 2;
            float totalY = y + 50;
            e.Graphics.DrawString(total, totalFont, Brushes.Red, new PointF(totalX, totalY));
            y += Convert.ToInt32(titleSize.Height + 50);
        }

        private void tinhTienBanHang()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dgv_bh_hoaDon.Rows)
            {
                if (row.Cells["SOLUONG_HD"].Value.ToString() != "")
                {
                    double giaBan = Convert.ToDouble(row.Cells["GIABAN_HD"].Value);
                    int soluong = Convert.ToInt32(row.Cells["SOLUONG_HD"].Value);
                    tongTien += soluong * giaBan;
                }
                else
                {
                    MessageBox.Show("Số lượng không được để trống");
                }
            }
            txt_tongTien.Text = tongTien.ToString();
        }

        /* private void btnSavePDF_Click(object sender, EventArgs e)
         {
             // Thiết lập các thông số cho bản in
             printDocument1.DefaultPageSettings.Landscape = true;
             printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

             // Tạo một bản in tạm thời
             MemoryStream stream = new MemoryStream();
             printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
             printDocument1.Print();

             // Lưu bản in vào file PDF
             PdfDocument pdf = new PdfDocument();
             pdf.Info.Title = "Hóa đơn bán hàng";
             PdfPage pdfPage = pdf.AddPage();
             XGraphics gfx = XGraphics.FromPdfPage(pdfPage);
             XImage image = XImage.FromStream(stream);
             gfx.DrawImage(image, 0, 0);
             string fileName = "invoice.pdf";
             pdf.Save(fileName);
             pdf.Close();
         }
        */

       /* private void btn_inphieunh_Click(object sender, EventArgs e)
        {


            // Thiết lập các thông số cho bản in
            printDocument1.DefaultPageSettings.Landscape = true;
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);

            // Hiển thị hộp thoại Print Preview để xem trước bản in
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;


            // In bản in
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
       */
    }
}
