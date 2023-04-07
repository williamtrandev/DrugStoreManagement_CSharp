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
    public partial class Loading : Form
    {
        private bool isAdmin;
        public Loading(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(10);
            if(progressBar.Value >= 100)
            {
                FHomePage f = new FHomePage(isAdmin);
                f.Show();
                this.Close();
            }
        }
    }
}
