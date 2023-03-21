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
    public partial class FAddNV : Form
    {
        public FAddNV()
        {
            InitializeComponent();
        }

        private void FAddNV_Load(object sender, EventArgs e)
        {
            pb_luu.Parent = pb_thongtinnv;
            pb_huy.Parent = pb_thongtinnv;
            pb_luu.BackColor = Color.Transparent;
            pb_huy.BackColor = Color.Transparent;
        }
    }
}
