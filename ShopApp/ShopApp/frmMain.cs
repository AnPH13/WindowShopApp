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

namespace ShopApp
{
    public partial class frmMain : Form
    {
        private int quyen = 0;
        private string id;
        public frmMain()
        {
            //this.User, this.Pass
            InitializeComponent();
            if (!kiemtratontai("frmLogin"))
            {
                frmLogin f = new frmLogin(this);
                hienthimpi(f);
                this.disable();
                btnClose.Visible = false;
             //   pictureBox1.Image = new System.Drawing.Bitmap(Application.StartupPath + "\\Resources\\account.png");
                lblName.Text = "Tài Khoản";
                lblViTri.Text = "Error";
                btnDangXuat.Visible = false;
            }
        }

        internal void capNhatDuLieu(string user, string pass, string id)
        {
            lblName.Text = user;
            lblViTri.Text = pass;
            this.id = id;
            btnDangXuat.Visible = true;
            this.enable();
        }

        private void hienthimpi(Form f)
        {
            try
            {
                foreach (Form frm in this.MdiChildren)
                { frm.Hide(); }

                f.MdiParent = this;
                f.ShowIcon = false;
                f.ControlBox = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.MaximizeBox = false;
                f.WindowState = FormWindowState.Normal;
                f.Dock = DockStyle.Right;
                btnClose.Visible = true; 
                f.Show();
            }
            catch(Exception)
            {
                return;
            }
        }

        private bool kiemtratontai(string fromName)
        {
            try
            {
                foreach (Form f in this.MdiChildren)
                {
                    if (f.Name == fromName)
                    {
                        hienthimpi(f);
                        return true;
                    }
                }
            }
            catch(Exception)
            {
                return false;
            }
            return false;
        }

        private void disable()
        {
            this.btnDonNhap.Enabled = false;
            this.btnDonBan.Enabled = false;
            this.btnDSSP.Enabled = false;
            this.btnTaoTK.Enabled = false;
            this.btnDSNV.Enabled = false;
            this.btnThemNCC.Enabled = false;
            this.btnDSNCC.Enabled = false;
            this.btnBaoTri.Enabled = false;
            this.btnKhachHang.Enabled = false;
            this.btnDoiMK.Enabled = false;
        }

        private void enable()
        {
            this.btnDonNhap.Enabled = true;
            this.btnDonBan.Enabled = true;
            this.btnDSSP.Enabled = true;
            this.btnTaoTK.Enabled = true;
            this.btnDSNV.Enabled = true;
            this.btnThemNCC.Enabled = true;
            this.btnDSNCC.Enabled = true;
            this.btnBaoTri.Enabled = true;
            this.btnKhachHang.Enabled = true;
            this.btnDoiMK.Enabled = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
                pfc.AddFontFile(@"0178-LNTH-DURALITH.ttf");
                panel1.Font = new System.Drawing.Font(pfc.Families[0], 12);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDonNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmThemSP"))
                {
                    frmThemSP f = new frmThemSP();
                    hienthimpi(f);
                }
            }catch(Exception)
            {
                return;
            }
        }

        private void btnDonBan_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmDonBan"))
                {
                    frmDonBan f = new frmDonBan(this.id);
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDSSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmProducts"))
                {
                    frmProducts f = new frmProducts();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmThemNV"))
                {
                    frmThemNV f = new frmThemNV();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDSNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmDanhSachNV"))
                {
                    frmDanhSachNV f = new frmDanhSachNV();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmThemNCC"))
                {
                    frmThemNCC f = new frmThemNCC();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmNCC"))
                {
                    frmNCC f = new frmNCC();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmBaoTri"))
                {
                    frmBaoTri f = new frmBaoTri();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                //this.Close();
                Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form frm in this.MdiChildren)
                { frm.Hide(); }
                btnClose.Visible = false;
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmLogin"))
                {
                    foreach (Form frm in this.MdiChildren)
                    { frm.Close(); }
                    frmLogin f = new frmLogin(this);
                    hienthimpi(f);
                    lblName.Text = "Tài Khoản Khách";
                    lblViTri.Text = "Error";
                    disable();
                    btnClose.Visible = false;
                    btnDangXuat.Visible = false;
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmKhachHang"))
                {
                    frmKhachHang f = new frmKhachHang();
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!kiemtratontai("frmDoiMK"))
                {
                    frmDoiMK f = new frmDoiMK(this.id);
                    hienthimpi(f);
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
