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
    public partial class frmDoiMK : Form
    {
        public frmDoiMK(string id)
        {
            InitializeComponent();
            txtUser.Text = BUS_staff_login.getName(id);
        }

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 13);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string usermoi = txtUserMoi.Text;
            string passcu = txtMkCu.Text;
            string passmoi = txtMkMoi.Text;
            if (String.IsNullOrEmpty(usermoi) || String.IsNullOrEmpty(passcu) || String.IsNullOrEmpty(passmoi))
            {
                MessageBox.Show("Không được bỏ trống trường nào");
            }
            else if (BUS_staff_login.kiemtratontai(usermoi))
            {
                MessageBox.Show("Tài khoản mới đã tồn tại");
            }
            else if (!BUS_staff_login.kiemtramatkhau(txtUser.Text, passcu))
            {
                MessageBox.Show("Mật khẩu cũ không đúng");
            }
            else if (passmoi.Length < 6)
            {
                MessageBox.Show("Mật khẩu ít nhất 6 ký tự");
            }
            else if(BUS_staff_login.update(txtUser.Text, usermoi, passmoi))
            {
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
