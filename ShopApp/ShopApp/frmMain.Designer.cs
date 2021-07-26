
namespace ShopApp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBaoTri = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDSNCC = new System.Windows.Forms.Button();
            this.btnThemNCC = new System.Windows.Forms.Button();
            this.btnDSSP = new System.Windows.Forms.Button();
            this.btnDonBan = new System.Windows.Forms.Button();
            this.btnDonNhap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDSNV = new System.Windows.Forms.Button();
            this.btnTaoTK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblViTri = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabDonHang = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabDonHang.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.tabDonHang);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 720);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.btnThoat);
            this.groupBox5.Location = new System.Drawing.Point(3, 646);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 71);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thoát";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Location = new System.Drawing.Point(6, 19);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(249, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnBaoTri);
            this.groupBox4.Location = new System.Drawing.Point(3, 571);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 69);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bảo trì";
            // 
            // btnBaoTri
            // 
            this.btnBaoTri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBaoTri.FlatAppearance.BorderSize = 0;
            this.btnBaoTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoTri.Location = new System.Drawing.Point(6, 19);
            this.btnBaoTri.Name = "btnBaoTri";
            this.btnBaoTri.Size = new System.Drawing.Size(249, 40);
            this.btnBaoTri.TabIndex = 5;
            this.btnBaoTri.Text = "Bảo Trì";
            this.btnBaoTri.UseVisualStyleBackColor = false;
            this.btnBaoTri.Click += new System.EventHandler(this.btnBaoTri_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnDSNCC);
            this.groupBox3.Controls.Add(this.btnThemNCC);
            this.groupBox3.Location = new System.Drawing.Point(3, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 118);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhà cung cấp";
            // 
            // btnDSNCC
            // 
            this.btnDSNCC.BackColor = System.Drawing.Color.Green;
            this.btnDSNCC.FlatAppearance.BorderSize = 0;
            this.btnDSNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNCC.Location = new System.Drawing.Point(6, 65);
            this.btnDSNCC.Name = "btnDSNCC";
            this.btnDSNCC.Size = new System.Drawing.Size(249, 40);
            this.btnDSNCC.TabIndex = 5;
            this.btnDSNCC.Text = "Danh sách nhà cung cấp";
            this.btnDSNCC.UseVisualStyleBackColor = false;
            this.btnDSNCC.Click += new System.EventHandler(this.btnDSNCC_Click);
            // 
            // btnThemNCC
            // 
            this.btnThemNCC.BackColor = System.Drawing.Color.Green;
            this.btnThemNCC.FlatAppearance.BorderSize = 0;
            this.btnThemNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemNCC.Location = new System.Drawing.Point(6, 19);
            this.btnThemNCC.Name = "btnThemNCC";
            this.btnThemNCC.Size = new System.Drawing.Size(249, 40);
            this.btnThemNCC.TabIndex = 5;
            this.btnThemNCC.Text = "Thêm nhà cung cấp";
            this.btnThemNCC.UseVisualStyleBackColor = false;
            this.btnThemNCC.Click += new System.EventHandler(this.btnThemNCC_Click);
            // 
            // btnDSSP
            // 
            this.btnDSSP.BackColor = System.Drawing.Color.Green;
            this.btnDSSP.FlatAppearance.BorderSize = 0;
            this.btnDSSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSSP.Location = new System.Drawing.Point(5, 98);
            this.btnDSSP.Name = "btnDSSP";
            this.btnDSSP.Size = new System.Drawing.Size(249, 40);
            this.btnDSSP.TabIndex = 5;
            this.btnDSSP.Text = "Danh sách sản phẩm";
            this.btnDSSP.UseVisualStyleBackColor = false;
            this.btnDSSP.Click += new System.EventHandler(this.btnDSSP_Click);
            // 
            // btnDonBan
            // 
            this.btnDonBan.BackColor = System.Drawing.Color.Green;
            this.btnDonBan.FlatAppearance.BorderSize = 0;
            this.btnDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonBan.Location = new System.Drawing.Point(5, 52);
            this.btnDonBan.Name = "btnDonBan";
            this.btnDonBan.Size = new System.Drawing.Size(249, 40);
            this.btnDonBan.TabIndex = 5;
            this.btnDonBan.Text = "Đơn bán";
            this.btnDonBan.UseVisualStyleBackColor = false;
            this.btnDonBan.Click += new System.EventHandler(this.btnDonBan_Click);
            // 
            // btnDonNhap
            // 
            this.btnDonNhap.BackColor = System.Drawing.Color.Green;
            this.btnDonNhap.FlatAppearance.BorderSize = 0;
            this.btnDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonNhap.Location = new System.Drawing.Point(5, 6);
            this.btnDonNhap.Name = "btnDonNhap";
            this.btnDonNhap.Size = new System.Drawing.Size(249, 40);
            this.btnDonNhap.TabIndex = 5;
            this.btnDonNhap.Text = "Đơn Nhập";
            this.btnDonNhap.UseVisualStyleBackColor = false;
            this.btnDonNhap.Click += new System.EventHandler(this.btnDonNhap_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnDSNV);
            this.groupBox1.Controls.Add(this.btnTaoTK);
            this.groupBox1.Location = new System.Drawing.Point(3, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // btnDSNV
            // 
            this.btnDSNV.BackColor = System.Drawing.Color.Green;
            this.btnDSNV.FlatAppearance.BorderSize = 0;
            this.btnDSNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDSNV.Location = new System.Drawing.Point(6, 65);
            this.btnDSNV.Name = "btnDSNV";
            this.btnDSNV.Size = new System.Drawing.Size(249, 40);
            this.btnDSNV.TabIndex = 5;
            this.btnDSNV.Text = "Danh sách nhân viên";
            this.btnDSNV.UseVisualStyleBackColor = false;
            this.btnDSNV.Click += new System.EventHandler(this.btnDSNV_Click);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.BackColor = System.Drawing.Color.Green;
            this.btnTaoTK.FlatAppearance.BorderSize = 0;
            this.btnTaoTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoTK.Location = new System.Drawing.Point(6, 19);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(249, 40);
            this.btnTaoTK.TabIndex = 5;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.UseVisualStyleBackColor = false;
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnDangXuat);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblViTri);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 129);
            this.panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::ShopApp.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Location = new System.Drawing.Point(112, 86);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(142, 37);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.Location = new System.Drawing.Point(109, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(129, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Phạm Hoàng An";
            // 
            // lblViTri
            // 
            this.lblViTri.AutoSize = true;
            this.lblViTri.Location = new System.Drawing.Point(109, 38);
            this.lblViTri.Name = "lblViTri";
            this.lblViTri.Size = new System.Drawing.Size(54, 13);
            this.lblViTri.TabIndex = 3;
            this.lblViTri.Text = "Giám Đốc";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(1193, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabDonHang
            // 
            this.tabDonHang.Controls.Add(this.tabPage1);
            this.tabDonHang.Controls.Add(this.tab2);
            this.tabDonHang.Location = new System.Drawing.Point(3, 138);
            this.tabDonHang.Name = "tabDonHang";
            this.tabDonHang.SelectedIndex = 0;
            this.tabDonHang.Size = new System.Drawing.Size(264, 172);
            this.tabDonHang.TabIndex = 148;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDSSP);
            this.tabPage1.Controls.Add(this.btnDonNhap);
            this.tabPage1.Controls.Add(this.btnDonBan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(256, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Đơn hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.btnDoiMK);
            this.tab2.Controls.Add(this.btnKhachHang);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(256, 146);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Tài Khoản";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Location = new System.Drawing.Point(4, 18);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(249, 40);
            this.btnKhachHang.TabIndex = 5;
            this.btnKhachHang.Text = "Danh sách khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMK.Location = new System.Drawing.Point(3, 78);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(249, 40);
            this.btnDoiMK.TabIndex = 5;
            this.btnDoiMK.Text = "Đổi thông tin đăng nhập";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1282, 720);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabDonHang.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblViTri;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoTK;
        private System.Windows.Forms.Button btnDSSP;
        private System.Windows.Forms.Button btnDonBan;
        private System.Windows.Forms.Button btnDonNhap;
        private System.Windows.Forms.Button btnDSNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDSNCC;
        private System.Windows.Forms.Button btnThemNCC;
        private System.Windows.Forms.Button btnBaoTri;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabDonHang;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Button btnKhachHang;
    }
}