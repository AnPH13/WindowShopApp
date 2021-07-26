using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;

namespace ShopApp
{
    public partial class frmDanhSachNV : Form
    {
        public frmDanhSachNV()
        {
            InitializeComponent();
        }

        private void frmDanhSachNV_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 10);
            btnReset.Font = new Font(pfc.Families[0], 13);

            dgvNhanVien.DataSource = BUS_staff.getDSNV();
            chkStatus.Checked = true;
            cboSDT.DataSource = BUS_staff.getDSNV(); ;
            cboID.DataSource = BUS_staff.getDSNV(); ;
            cboAddress.DataSource = BUS_staff.getDSNV(); ;
            cboName.DataSource = BUS_staff.getDSNV();

            cboName.DisplayMember = "staName";
            cboName.ValueMember = "staName";

            cboAddress.DisplayMember = "staAddress";
            cboAddress.ValueMember = "staAddress";

            cboID.DisplayMember = "staID";
            cboID.ValueMember = "staID";

            cboSDT.DisplayMember = "staPhone";
            cboSDT.ValueMember = "staPhone";

            cboName.SelectedIndex = cboAddress.SelectedIndex  = cboID.SelectedIndex = cboSDT.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = BUS_staff.search(chkStatus.Checked, cboName.Text, cboAddress.Text, cboID.Text, cboSDT.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = BUS_staff.getDSNV();
        }
    }
}
