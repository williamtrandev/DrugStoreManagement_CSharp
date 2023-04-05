using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
namespace DrugStore
{
    public partial class FAddNV : Form
    {
        private bool action;
        private string sdt, ten, diachi, pass;
        FHomePage fhp;
        public FAddNV(FHomePage fhp, bool action = false, string sdt="", string ten="", string diachi="", string pass="")
        {
            InitializeComponent();
            this.fhp = fhp;
            this.action = action;
            this.sdt = sdt;
            this.ten = ten;
            this.diachi = diachi;
            this.pass = pass;
        }

        private void FAddNV_Load(object sender, EventArgs e)
        {
            pb_luu.Parent = pb_thongtinnv;
            pb_huy.Parent = pb_thongtinnv;
            lb_validate_sdt.Parent = pb_thongtinnv;
            lb_validate_diachi.Parent = pb_thongtinnv;
            lb_validate_ten.Parent = pb_thongtinnv;
            lb_validate_pass.Parent = pb_thongtinnv;
            pb_luu.BackColor = Color.Transparent;
            pb_huy.BackColor = Color.Transparent;
            lb_validate_sdt.BackColor = Color.Transparent;
            lb_validate_ten.BackColor = Color.Transparent;
            lb_validate_diachi.BackColor = Color.Transparent;
            lb_validate_pass.BackColor = Color.Transparent;
            lb_validate_ten.Text = "";
            lb_validate_sdt.Text = "";
            lb_validate_diachi.Text = "";
            lb_validate_pass.Text = "";
            if(action)
            {
                tb_sdt.Text = this.sdt;
                tb_tennv.Text = this.ten;
                tb_diachi.Text = this.diachi;
                tb_matkhau.Text = this.pass;
            }
        }

        private void pb_luu_Click(object sender, EventArgs e)
        {
            if(tb_sdt.Text == "")
            {
                lb_validate_sdt.Text = "Số điện thoại chưa nhập";
                return;
            }
            if (tb_tennv.Text == "")
            {
                lb_validate_ten.Text = "Tên nhân viên chưa nhập";
                return;
            }
            if (tb_diachi.Text == "")
            {
                lb_validate_diachi.Text = "Địa chỉ chưa nhập";
                return;
            }
            if (tb_matkhau.Text == "")
            {
                lb_validate_pass.Text = "Mật khẩu chưa nhập";
                return;
            }
            String sdt = tb_sdt.Text.ToString();
            String ten = tb_tennv.Text.ToString(); 
            String diachi = tb_diachi.Text.ToString();
            String matkhau = tb_matkhau.Text.ToString();
            if (NhanVienBUS.Instance.checkExistAccount(sdt))
            {
                lb_validate_sdt.Text = "Số điện thoại tồn tại!";
                return;
            }
            if(action)
            {
                bool check = NhanVienBUS.Instance.updateAccountNhanVien(sdt, diachi, ten, matkhau, this.sdt);
            }
            else
            {
                bool check = NhanVienBUS.Instance.insertAccountNhanVien(sdt, diachi, ten, matkhau);
                if (check)
                {
                    MessageBox.Show("Đăng kí thành công");
                    fhp.loadNhanVien();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng kí không thành công");
                }
            }
        }

        private void pb_huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
