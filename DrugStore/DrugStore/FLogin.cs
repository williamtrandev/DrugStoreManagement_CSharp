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
            // Xoa nen trang cua cac picture box
            pb_minus.BackColor = Color.Transparent;
            pb_close.BackColor = Color.Transparent;
            pb_login.BackColor = Color.Transparent;

        }
    }
}