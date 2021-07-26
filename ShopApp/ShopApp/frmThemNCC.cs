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
    public partial class frmThemNCC : Form
    {
        public frmThemNCC()
        {
            InitializeComponent();
            dgvNCCNhap.DataSource = BUS_provider.load();
        }

        private void frmThemNCC_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 10);
        }
        private DTO_provider stringTxt()
        {
            DTO_provider pr = new DTO_provider();
            pr.provAddress = txtDiaChi.Text;
            pr.provCountry = txtCountry.Text;
            pr.provDescription = textBox4.Text;
            pr.provFullName = txtTenDayDuNCC.Text;
            pr.provName = txtTen.Text;
            pr.provPhone = txtPhone.Text;
            pr.provPostOfficeCode = txtCode.Text;
            pr.status = true;
            return pr;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_provider pr = stringTxt();
            if(String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtCountry.Text) || String.IsNullOrEmpty(textBox4.Text)
                || String.IsNullOrEmpty(txtTenDayDuNCC.Text) || String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtTen.Text)
                || String.IsNullOrEmpty(txtPhone.Text)
                )
            {
                MessageBox.Show("không được bỏ trống trường nào");
            }
            else
            {
                if (BUS_provider.add(pr))
                {
                    MessageBox.Show("thêm thành công");
                    reset();
                }
                else
                {
                    MessageBox.Show("thêm thất bại");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DTO_provider pr = stringTxt();
            pr.provID = txtID.Text;
            if (String.IsNullOrEmpty(txtDiaChi.Text) || String.IsNullOrEmpty(txtCountry.Text) || String.IsNullOrEmpty(textBox4.Text)
                || String.IsNullOrEmpty(txtTenDayDuNCC.Text) || String.IsNullOrEmpty(txtCode.Text) || String.IsNullOrEmpty(txtTen.Text)
                || String.IsNullOrEmpty(txtPhone.Text)
                )
            {
                MessageBox.Show("không được bỏ trống trường nào");
            }
            else if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Phải chọn hàng để sửa");
            }
            else
            {
                if (BUS_provider.edit(pr))
                {
                    MessageBox.Show("sửa thành công");
                    reset();
                }
                else
                {
                    MessageBox.Show("sửa thất bại");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Phải chọn hàng để xoá");
            }
            else
            {
                if (BUS_provider.del(txtID.Text))
                {
                    MessageBox.Show("xoá thành công");
                    reset();
                }
                else
                {
                    MessageBox.Show("xoá thất bại");
                }
            }
        }

        private void dgvNCCNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvNCCNhap.SelectedRows[0];
            txtCode.Text = r.Cells["colCode"].Value.ToString();
            txtCountry.Text = r.Cells["colQuocGia"].Value.ToString();
            txtDiaChi.Text = r.Cells["colAddress"].Value.ToString();
            txtID.Text = r.Cells["colID"].Value.ToString();
            txtPhone.Text = r.Cells["colPhone"].Value.ToString();
            txtTen.Text = r.Cells["colName"].Value.ToString();
            txtTenDayDuNCC.Text = r.Cells["colFullName"].Value.ToString();
            textBox4.Text = r.Cells["colMieuTa"].Value.ToString();
        }
        private void reset()
        {
            dgvNCCNhap.DataSource = BUS_provider.load();
            txtCode.Text = "";
            txtCountry.Text = "";
            txtDiaChi.Text = "";
            txtID.Text = "";
            txtPhone.Text = "";
            txtTen.Text = "";
            txtTenDayDuNCC.Text = "";
            textBox4.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
