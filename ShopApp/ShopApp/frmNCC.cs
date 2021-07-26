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
using System.Data;
using System.Data.SqlClient;

namespace ShopApp
{
    public partial class frmNCC : Form
    {
        public frmNCC()
        {
            InitializeComponent();
            dgvNCC.DataSource = BUS_provider.load();
            cboAddress.DataSource = BUS_provider.load();
            cboCountry.DataSource = BUS_provider.load();
            cboID.DataSource = BUS_provider.load();
            cboName.DataSource = BUS_provider.load();
            cboPhone.DataSource = BUS_provider.load();

            cboAddress.DisplayMember = "provAddress";
            cboAddress.ValueMember = "provAddress";

            cboCountry.DisplayMember = "provCountry";
            cboCountry.ValueMember = "provCountry";

            cboID.DisplayMember = "provID";
            cboID.ValueMember = "provID";

            cboName.DisplayMember = "provFullName";
            cboName.ValueMember = "provFullName";

            cboPhone.DisplayMember = "provPhone";
            cboPhone.ValueMember = "provPhone";

        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 10);
            cboAddress.Text = "";
            cboCountry.Text = "";
            cboID.Text = "";
            cboName.Text = "";
            cboPhone.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvNCC.DataSource = BUS_provider.search(cboAddress.Text, cboCountry.Text, cboID.Text, cboName.Text, cboPhone.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvNCC.DataSource = BUS_provider.load();
            cboAddress.Text = "";
            cboCountry.Text = "";
            cboID.Text = "";
            cboName.Text = "";
            cboPhone.Text = "";
        }
    }
}
