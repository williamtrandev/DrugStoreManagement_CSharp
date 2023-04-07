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
    public partial class FAddKhachHang : Form
    {   
        private bool isEdit;
        private string sdt, name;
        private FHomePage fhp;
        public FAddKhachHang(bool isEdit, FHomePage fhp, string sdt="", string name="")
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.sdt = sdt;
            this.name = name;
            this.fhp = fhp;
        }

        private void pb_btn_edit_Click(object sender, EventArgs e)
        {
            string sdt = tb_phone_add.Text.ToString();
            string name = tb_name_add.Text.ToString();
            if (sdt == "")
            {
                lb_msg_phone.Text = "Số điện thoại chưa nhập!";
                return;
            }
            if (name == "")
            {
                lb_msg_name.Text = "Tên khách hàng chưa nhập!";
                return;
            }
            bool check = BUS.KhachHangBUS.Instance.checkExistCustomer(sdt);
            if (!check)
            {
                if(this.sdt != sdt)
                {
                    bool checkUpdate = BUS.KhachHangBUS.Instance.updateCustomer(sdt, name, this.sdt);
                    if (checkUpdate)
                    {
                        MessageBox.Show("Thay đổi thông tin khách hàng thành công", "Thành công");
                        fhp.loadKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thông tin khách hàng thất bại", "Thất bại");
                    }
                }
                
            }
            else
            {
                lb_msg_phone.Text = "Số điện thoại đã được sử dụng!";
                return;
            }
        }

        private void pb_btn_add_Click(object sender, EventArgs e)
        {
            string sdt = tb_phone_add.Text.ToString();
            string name = tb_name_add.Text.ToString();
            if (sdt == "")
            {
                lb_msg_phone.Text = "Số điện thoại chưa nhập!";
                return;
            }
            if(name == "")
            {
                lb_msg_name.Text = "Tên khách hàng chưa nhập!";
                return;
            }
            bool check = BUS.KhachHangBUS.Instance.checkExistCustomer(sdt);
            if(!check)
            {
                bool checkInsert = BUS.KhachHangBUS.Instance.insertKhachHang(sdt, name);
                if(checkInsert)
                {
                    MessageBox.Show("Thêm khách hàng thành công", "Thành công");
                    fhp.loadKhachHang();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Thêm khách hàng thất bại", "Thất bại");
                }
            } else
            {
                lb_msg_phone.Text = "Số điện thoại đã được sử dụng!";
                return;
            }
        }
        private void FAddKhachHang_Load(object sender, EventArgs e)
        {
            pb_btn_add.Parent = pb_add_kh;
            pb_btn_edit.Parent = pb_add_kh;
            pb_btn_add.BackColor = Color.Transparent;
            pb_btn_edit.BackColor = Color.Transparent;
            lb_msg_name.Parent = pb_add_kh;
            lb_msg_phone.Parent = pb_add_kh;
            lb_msg_name.BackColor = Color.Transparent;
            lb_msg_phone.BackColor = Color.Transparent;
            lb_msg_name.Text = "";
            lb_msg_phone.Text = "";
            if (isEdit)
            {
                pb_btn_add.Visible= false;
                pb_btn_edit.Visible= true;
                tb_phone_add.Text = this.sdt;
                tb_name_add.Text = this.name;
            } else
            {
                pb_btn_add.Visible = true;
                pb_btn_edit.Visible = false;
                
            }
        }
    }
}
