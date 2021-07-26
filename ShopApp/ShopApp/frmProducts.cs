using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace ShopApp
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
            dgvDSSP.DataSource = BUS_Product.getDSSP();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 10);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = cboName.Text;
            string price = cboPrice.Text;
            string id = cboID.Text;
            string memory = cboMemory.Text;
            string year = cboYear.Text;
            dgvDSSP.DataSource = BUS_Product.getSearch(name, price, id, memory, year);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = BUS_Product.getDSSP();
            cboID.Text = "";
            cboMemory.Text = "";
            cboName.Text = "";
            cboPrice.Text = "";
            cboYear.Text = "";
        }
    }
}
