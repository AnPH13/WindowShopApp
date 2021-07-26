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
    public partial class frmDonBan : Form
    {
        private string id = "";
        public frmDonBan(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmDonBan_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 10);

            cbbOption.SelectedIndex = 0;
            cboLbl.SelectedIndex = 0;

            dgvDSSP.DataSource = BUS_Product.getDSSP();

            dgvCli.DataSource = BUS_Client.getDSKH();

            txtSearch.DataSource = BUS_Product.getDSSP();
            txtSearch.DisplayMember = "prodName";
            txtSearch.ValueMember = "prodName";
            txtSearch.SelectedIndex = -1;

            cboSearch.DataSource = BUS_Client.getDSKH();
            cboSearch.DisplayMember = "cliName";
            cboSearch.ValueMember = "cliName";
            cboSearch.SelectedIndex = -1;
            lblNhanVienID.Text = this.id;
            lblNhanVienTen.Text = BUS_staff.getName(id);
            lblPhone.Text = BUS_staff.getSDT(id);
        }

        private void btnResetSp_Click(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = BUS_Product.getDSSP();

        }

        private void btnResetKh_Click(object sender, EventArgs e)
        {
            dgvCli.DataSource = BUS_Client.getDSKH();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvDSSP.DataSource = BUS_Product.search(cbbOption.SelectedIndex, txtSearch.Text);

            int intRow = ((DataTable)dgvDSSP.DataSource).Rows.Count;
            if (intRow == 0)
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\x.jpg");
            }
            else
            {
                pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\v.png");
            }
        }

        private void cboSearch_TextChanged(object sender, EventArgs e)
        {
            dgvCli.DataSource = BUS_Client.search(cboLbl.SelectedIndex, cboSearch.Text);
            int intRow = ((DataTable)dgvCli.DataSource).Rows.Count;
            if (intRow == 0)
            {
                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Resources\\x.jpg");
            }
            else
            {
                pictureBox2.Image = new Bitmap(Application.StartupPath + "\\Resources\\v.png");
            }
        }

        private void dgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvDSSP.SelectedRows[0];
            txtTenDienThoai.Text = r.Cells["colTen"].Value.ToString();
            txtIDprod.Text = r.Cells["colID"].Value.ToString();
            txtGiaDienThoai.Text = r.Cells["colGia"].Value.ToString();

        }

        private void dgvCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvCli.SelectedRows[0];
            txtTenkh.Text = r.Cells["cliName"].Value.ToString();
            txtDiachikh.Text = r.Cells["cliAddress"].Value.ToString();
            txtBuudienkh.Text = r.Cells["cliPostOfficeCode"].Value.ToString();
            txtIdkh.Text = r.Cells["cliID"].Value.ToString();
            txtSDT.Text = r.Cells["cliPhone"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DTO_orderr od = new DTO_orderr();
            od.ordDescription = txtAbout.Text;
            od.cliID = txtIdkh.Text;
            od.staID = lblNhanVienID.Text;
            od.ordStatus = true;

            ///
            DTO_information_order io = new DTO_information_order();
            io.prodID = txtIDprod.Text;
            io.infoOrderSL = Convert.ToInt32(txtSoLuong.Text);
            io.infoOrderPrice = Convert.ToInt32(txtGiaDienThoai.Text);
            if (String.IsNullOrEmpty(od.ordDescription) || String.IsNullOrEmpty(od.cliID) || String.IsNullOrEmpty(od.staID) || String.IsNullOrEmpty(txtSoLuong.Text) || String.IsNullOrEmpty(txtGiaDienThoai.Text))
            {
                if (BUS_orderr.nhapOrder(od, io))
                {
                    MessageBox.Show("Nhập thành công");
                }
                else
                {
                    MessageBox.Show("nhập thất bại");
                }
            }
            else
            {
                MessageBox.Show("không được bỏ trống trường nào");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void reset() 
        {
            txtAbout.Clear();
            txtSearch.Text = "";
            txtTenDienThoai.Clear();
            txtIdkh.Clear();
            txtGiaDienThoai.Clear();
            txtIDprod.Clear();
            txtSoLuong.Clear();
            cboDonVi.SelectedIndex = 0;
            cboSearch.Text = "";
            txtTenkh.Clear();
            txtBuudienkh.Clear();
            txtDiachikh.Clear();
            txtSDT.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
