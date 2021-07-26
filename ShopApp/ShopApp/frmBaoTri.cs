using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class frmBaoTri : Form
    {
        public frmBaoTri()
        {
            InitializeComponent();
        }

        private void frmBaoTri_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 13);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
