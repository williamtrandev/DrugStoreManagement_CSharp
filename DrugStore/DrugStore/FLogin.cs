using BUS;
using DTO;
namespace DrugStore
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        private void pb_close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pb_minus_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void FLogin_Load(object sender, EventArgs e)
        {
            pb_minus.Parent = pb_background_form;
            pb_close.Parent = pb_background_form;
            pb_login.Parent = pb_background_form;
            pb_phone.Parent = pb_background_form;
            pb_pass.Parent = pb_background_form;
            lb_msg.Parent = pb_background_form;
            lb_validate_phone.Parent = pb_background_form;
            lb_validate_pass.Parent = pb_background_form;
            // Xoa nen trang cua cac picture box
            pb_minus.BackColor = Color.Transparent;
            pb_close.BackColor = Color.Transparent;
            pb_login.BackColor = Color.Transparent;
            pb_phone.BackColor = Color.Transparent;
            pb_pass.BackColor = Color.Transparent;
            lb_msg.BackColor = Color.Transparent;
            lb_validate_phone.BackColor = Color.Transparent;
            lb_validate_pass.BackColor= Color.Transparent;

        }
        private static bool isClick = false;
        private void pb_pass_Click(object sender, EventArgs e)
        {
            isClick = !isClick;
            tb_pass.UseSystemPasswordChar = isClick;
        }
        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            lb_validate_phone.Text = "";
        }
        private void tb_pass_TextChanged(object sender, EventArgs e)
        {
            lb_validate_pass.Text = "";
        }
        private void tb_phone_Click(object sender, EventArgs e)
        {
            tb_phone.SelectAll();
            lb_validate_phone.Text = "";
            lb_validate_pass.Text = "";
            lb_msg.Text = "";
        }
        private void tb_pass_Click(object sender, EventArgs e)
        {
            tb_pass.SelectAll();
            lb_validate_phone.Text = "";
            lb_validate_pass.Text = "";
            lb_msg.Text = "";
        }

        private void pb_login_Click(object sender, EventArgs e)
        {
            if (tb_phone.Text == "")   // Show message to user
            {
                lb_validate_phone.Text = "Số điện thoại chưa nhập!";
                tb_phone.Focus();     // Focus on input textbox for user
                return;
            }
            if (tb_pass.Text == "")    // Show message to user
            {
                lb_validate_pass.Text = "Mật khẩu chưa nhập!";
                tb_pass.Focus();
                return;
            }
            // validating user account
            this.ActiveControl = null;
            String sdt = tb_phone.Text.ToString();
            String pass = tb_pass.Text.ToString();
            NhanVien nv = null;
            nv = NhanVienBUS.Instance.checkAccount(sdt, pass);
            if (nv != null)
            {
                
                this.Hide();
                Loading f;
                if (sdt=="admin")
                {
                   f = new Loading(true, sdt);
                } else
                {
                    f = new Loading(false, sdt);
                }
                f.Show();
            }
            else
            {
                lb_msg.Text = "Sai tên tài khoản hoặc mật khẩu!";
            }
        }

        
    }
}