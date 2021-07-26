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

namespace ShopApp
{
    public partial class frmLogin : Form
    {
        //private string User = "";
        //private string Pass = "";
        frmMain frmOut;
        public frmLogin(frmMain f)
        {
            InitializeComponent();
            frmOut = f;
        }

        public frmLogin(string user, string pass)
        {

        }

        //xử lí che mắt
        int tamp = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (tamp == 0)
            {
                pbShowHidePass.Image =
                    new Bitmap(Application.StartupPath + "\\Resources\\eye-slash-solid.png");
                txtPass.PasswordChar = '●';
                tamp = 1;
                txtPass.UseSystemPasswordChar = true;
            }
            else
            {
                pbShowHidePass.Image =
                    new Bitmap(Application.StartupPath + "\\Resources\\eye-solid.png");
                tamp = 0;
                txtPass.PasswordChar = '\0';
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void picVN_Click(object sender, EventArgs e)
        {
            lblForgot.Text = "Quên Mật Khẩu?";
            lblLogin.Text = "     Đăng Nhập";
            lblRules.Text = "Điều Khoản";
            btnLogin.Text = "Đ Ă N G N H Ậ P";
        }

        private void picENG_Click(object sender, EventArgs e)
        {
            lblForgot.Text = "Forgot password?";
            lblLogin.Text = "         Login";
            lblRules.Text = "Rules shop";
            btnLogin.Text = "L O G I N";
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
            this.Font = new System.Drawing.Font(pfc.Families[0], 10);
            this.lblLogin.Font = new System.Drawing.Font(pfc.Families[0], 20, System.Drawing.FontStyle.Bold);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPass.Text;
            if (String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Đăng Nhập Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(BUS_staff_login.KiemTraDangNhap(user, pass))
            {
                MessageBox.Show("Đăng nhập thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string id = BUS_staff_login.getID(user);
                frmOut.capNhatDuLieu(BUS_staff.getName(id), BUS_staff.getVT(id), id);
                this.Close();                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Đăng Nhập Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
