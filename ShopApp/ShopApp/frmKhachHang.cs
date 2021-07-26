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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void load()
        {
            dgvKhachHang.DataSource = BUS_Client.getDSKH();
            txtAddress.Text = "";
            txtCountry.Text = "";
            txtID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPostOffice.Text = "";
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = BUS_Client.getDSKH();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = dgvKhachHang.SelectedRows[0];
            txtAddress.Text = r.Cells["colAddress"].Value.ToString();
            txtCountry.Text = r.Cells["colQuocGia"].Value.ToString();
            txtID.Text = r.Cells["colID"].Value.ToString();
            txtName.Text = r.Cells["colFullName"].Value.ToString();
            txtPhone.Text = r.Cells["colPhone"].Value.ToString();
            txtPostOffice.Text = r.Cells["colCode"].Value.ToString();
        }
        private bool kiemtra()
        {
            if (String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtPhone.Text) || String.IsNullOrEmpty(txtPostOffice.Text) || String.IsNullOrEmpty(txtCountry.Text) || String.IsNullOrEmpty(txtAddress.Text))
            {
                return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DTO_client cli = new DTO_client();
            cli.cliName = txtName.Text;
            cli.cliAddress = txtAddress.Text;
            cli.cliCountry = txtCountry.Text;
            cli.cliPostOfficeCode = txtPostOffice.Text;
            cli.cliPhone = txtPhone.Text;
            try
            {
                if(kiemtra())
                {
                    MessageBox.Show("không được bỏ trống trường nào");
                }
                else if (BUS_Client.addClient(cli))
                {
                    MessageBox.Show("Thêm Thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DTO_client cli = new DTO_client();
            cli.cliID = txtID.Text;
            cli.cliName = txtName.Text;
            cli.cliAddress = txtAddress.Text;
            cli.cliCountry = txtCountry.Text;
            cli.cliPostOfficeCode = txtPostOffice.Text;
            cli.cliPhone = txtPhone.Text;
            try
            {
                if (kiemtra())
                {
                    MessageBox.Show("không được bỏ trống trường nào");
                }
                else if(txtID.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn dòng nào");
                }
                else if (BUS_Client.editClient(cli))
                {
                    MessageBox.Show("Sửa thành công");
                    load();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            catch (Exception)
            {
                return;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = dgvKhachHang.SelectedRows[0].Cells["colID"].Value.ToString();
            if (BUS_Client.delClient(id)) 
            {
                MessageBox.Show("xoá thành công");
                load();
            }
            else
            {
                MessageBox.Show("Xoá thất bại");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
