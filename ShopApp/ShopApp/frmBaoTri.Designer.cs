
namespace ShopApp
{
    partial class frmBaoTri
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTaomoi = new System.Windows.Forms.Button();
            this.grbHoadon = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnInhoadon = new System.Windows.Forms.Button();
            this.txtThanhtien = new System.Windows.Forms.TextBox();
            this.txtDichvu = new System.Windows.Forms.TextBox();
            this.txtNhaptensp = new System.Windows.Forms.TextBox();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.txtTenKh = new System.Windows.Forms.TextBox();
            this.lblThanhtien = new System.Windows.Forms.Label();
            this.lblThongtinbaotri = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            this.grbDichvu = new System.Windows.Forms.GroupBox();
            this.ckcMatlung = new System.Windows.Forms.CheckBox();
            this.ckcChansac = new System.Windows.Forms.CheckBox();
            this.ckcManhinh = new System.Windows.Forms.CheckBox();
            this.ckcPin = new System.Windows.Forms.CheckBox();
            this.ckcEpkinh = new System.Windows.Forms.CheckBox();
            this.grbThongtinsp = new System.Windows.Forms.GroupBox();
            this.cbbThuonghieu = new System.Windows.Forms.ComboBox();
            this.lblThuonghieu = new System.Windows.Forms.Label();
            this.txtTensp = new System.Windows.Forms.TextBox();
            this.lblTensanpham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbHoadon.SuspendLayout();
            this.grbDichvu.SuspendLayout();
            this.grbThongtinsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(783, 496);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 32);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnTaomoi
            // 
            this.btnTaomoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTaomoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaomoi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTaomoi.Location = new System.Drawing.Point(695, 398);
            this.btnTaomoi.Name = "btnTaomoi";
            this.btnTaomoi.Size = new System.Drawing.Size(169, 68);
            this.btnTaomoi.TabIndex = 18;
            this.btnTaomoi.Text = "Tạo mới";
            this.btnTaomoi.UseVisualStyleBackColor = false;
            // 
            // grbHoadon
            // 
            this.grbHoadon.Controls.Add(this.btnXoa);
            this.grbHoadon.Controls.Add(this.btnInhoadon);
            this.grbHoadon.Controls.Add(this.txtThanhtien);
            this.grbHoadon.Controls.Add(this.txtDichvu);
            this.grbHoadon.Controls.Add(this.txtNhaptensp);
            this.grbHoadon.Controls.Add(this.btnTinhtien);
            this.grbHoadon.Controls.Add(this.txtTenKh);
            this.grbHoadon.Controls.Add(this.lblThanhtien);
            this.grbHoadon.Controls.Add(this.lblThongtinbaotri);
            this.grbHoadon.Controls.Add(this.lblMakh);
            this.grbHoadon.ForeColor = System.Drawing.Color.DarkRed;
            this.grbHoadon.Location = new System.Drawing.Point(105, 328);
            this.grbHoadon.Name = "grbHoadon";
            this.grbHoadon.Size = new System.Drawing.Size(529, 229);
            this.grbHoadon.TabIndex = 17;
            this.grbHoadon.TabStop = false;
            this.grbHoadon.Text = "Hóa đơn";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoa.ForeColor = System.Drawing.Color.DarkRed;
            this.btnXoa.Location = new System.Drawing.Point(355, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 28);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnInhoadon
            // 
            this.btnInhoadon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnInhoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInhoadon.ForeColor = System.Drawing.Color.DarkRed;
            this.btnInhoadon.Location = new System.Drawing.Point(201, 168);
            this.btnInhoadon.Name = "btnInhoadon";
            this.btnInhoadon.Size = new System.Drawing.Size(115, 28);
            this.btnInhoadon.TabIndex = 14;
            this.btnInhoadon.Text = "In hóa đơn";
            this.btnInhoadon.UseVisualStyleBackColor = false;
            // 
            // txtThanhtien
            // 
            this.txtThanhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtThanhtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhtien.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtThanhtien.ForeColor = System.Drawing.Color.DarkRed;
            this.txtThanhtien.Location = new System.Drawing.Point(201, 118);
            this.txtThanhtien.Name = "txtThanhtien";
            this.txtThanhtien.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtThanhtien.Size = new System.Drawing.Size(235, 22);
            this.txtThanhtien.TabIndex = 13;
            // 
            // txtDichvu
            // 
            this.txtDichvu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtDichvu.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDichvu.Location = new System.Drawing.Point(201, 92);
            this.txtDichvu.Name = "txtDichvu";
            this.txtDichvu.Size = new System.Drawing.Size(235, 22);
            this.txtDichvu.TabIndex = 10;
            this.txtDichvu.Text = "Dịch vụ bảo trì";
            // 
            // txtNhaptensp
            // 
            this.txtNhaptensp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtNhaptensp.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNhaptensp.Location = new System.Drawing.Point(201, 67);
            this.txtNhaptensp.Name = "txtNhaptensp";
            this.txtNhaptensp.Size = new System.Drawing.Size(235, 22);
            this.txtNhaptensp.TabIndex = 9;
            this.txtNhaptensp.Text = "Tên sản phẩm";
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnTinhtien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTinhtien.ForeColor = System.Drawing.Color.DarkRed;
            this.btnTinhtien.Location = new System.Drawing.Point(82, 168);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(79, 28);
            this.btnTinhtien.TabIndex = 12;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = false;
            // 
            // txtTenKh
            // 
            this.txtTenKh.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKh.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTenKh.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTenKh.Location = new System.Drawing.Point(201, 38);
            this.txtTenKh.Name = "txtTenKh";
            this.txtTenKh.Size = new System.Drawing.Size(235, 22);
            this.txtTenKh.TabIndex = 4;
            // 
            // lblThanhtien
            // 
            this.lblThanhtien.AutoSize = true;
            this.lblThanhtien.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhtien.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblThanhtien.ForeColor = System.Drawing.Color.Black;
            this.lblThanhtien.Location = new System.Drawing.Point(69, 122);
            this.lblThanhtien.Name = "lblThanhtien";
            this.lblThanhtien.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThanhtien.Size = new System.Drawing.Size(73, 16);
            this.lblThanhtien.TabIndex = 3;
            this.lblThanhtien.Text = "Thành tiền ";
            // 
            // lblThongtinbaotri
            // 
            this.lblThongtinbaotri.AutoSize = true;
            this.lblThongtinbaotri.BackColor = System.Drawing.Color.Transparent;
            this.lblThongtinbaotri.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblThongtinbaotri.ForeColor = System.Drawing.Color.Black;
            this.lblThongtinbaotri.Location = new System.Drawing.Point(65, 68);
            this.lblThongtinbaotri.Name = "lblThongtinbaotri";
            this.lblThongtinbaotri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThongtinbaotri.Size = new System.Drawing.Size(112, 16);
            this.lblThongtinbaotri.TabIndex = 2;
            this.lblThongtinbaotri.Text = "Thông tin bảo trì :";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.BackColor = System.Drawing.Color.Transparent;
            this.lblMakh.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblMakh.ForeColor = System.Drawing.Color.Black;
            this.lblMakh.Location = new System.Drawing.Point(67, 38);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMakh.Size = new System.Drawing.Size(103, 16);
            this.lblMakh.TabIndex = 1;
            this.lblMakh.Text = "Tên khách hàng ";
            // 
            // grbDichvu
            // 
            this.grbDichvu.Controls.Add(this.ckcMatlung);
            this.grbDichvu.Controls.Add(this.ckcChansac);
            this.grbDichvu.Controls.Add(this.ckcManhinh);
            this.grbDichvu.Controls.Add(this.ckcPin);
            this.grbDichvu.Controls.Add(this.ckcEpkinh);
            this.grbDichvu.ForeColor = System.Drawing.Color.DarkRed;
            this.grbDichvu.Location = new System.Drawing.Point(638, 128);
            this.grbDichvu.Name = "grbDichvu";
            this.grbDichvu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbDichvu.Size = new System.Drawing.Size(233, 185);
            this.grbDichvu.TabIndex = 16;
            this.grbDichvu.TabStop = false;
            this.grbDichvu.Text = "Dịch vụ bảo trì";
            // 
            // ckcMatlung
            // 
            this.ckcMatlung.AutoSize = true;
            this.ckcMatlung.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcMatlung.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcMatlung.Location = new System.Drawing.Point(13, 109);
            this.ckcMatlung.Name = "ckcMatlung";
            this.ckcMatlung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckcMatlung.Size = new System.Drawing.Size(77, 20);
            this.ckcMatlung.TabIndex = 11;
            this.ckcMatlung.Text = "Mặt lưng";
            this.ckcMatlung.UseVisualStyleBackColor = true;
            // 
            // ckcChansac
            // 
            this.ckcChansac.AutoSize = true;
            this.ckcChansac.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcChansac.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcChansac.Location = new System.Drawing.Point(120, 71);
            this.ckcChansac.Name = "ckcChansac";
            this.ckcChansac.Size = new System.Drawing.Size(79, 20);
            this.ckcChansac.TabIndex = 7;
            this.ckcChansac.Text = "Chân sạc";
            this.ckcChansac.UseVisualStyleBackColor = true;
            // 
            // ckcManhinh
            // 
            this.ckcManhinh.AutoSize = true;
            this.ckcManhinh.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcManhinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcManhinh.Location = new System.Drawing.Point(13, 71);
            this.ckcManhinh.Name = "ckcManhinh";
            this.ckcManhinh.Size = new System.Drawing.Size(79, 20);
            this.ckcManhinh.TabIndex = 6;
            this.ckcManhinh.Text = "Màn hình";
            this.ckcManhinh.UseVisualStyleBackColor = true;
            // 
            // ckcPin
            // 
            this.ckcPin.AutoSize = true;
            this.ckcPin.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcPin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcPin.Location = new System.Drawing.Point(120, 32);
            this.ckcPin.Name = "ckcPin";
            this.ckcPin.Size = new System.Drawing.Size(44, 20);
            this.ckcPin.TabIndex = 5;
            this.ckcPin.Text = "Pin";
            this.ckcPin.UseVisualStyleBackColor = true;
            // 
            // ckcEpkinh
            // 
            this.ckcEpkinh.AutoSize = true;
            this.ckcEpkinh.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.ckcEpkinh.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ckcEpkinh.Location = new System.Drawing.Point(13, 32);
            this.ckcEpkinh.Name = "ckcEpkinh";
            this.ckcEpkinh.Size = new System.Drawing.Size(68, 20);
            this.ckcEpkinh.TabIndex = 4;
            this.ckcEpkinh.Text = "Ép kính";
            this.ckcEpkinh.UseVisualStyleBackColor = true;
            // 
            // grbThongtinsp
            // 
            this.grbThongtinsp.Controls.Add(this.cbbThuonghieu);
            this.grbThongtinsp.Controls.Add(this.lblThuonghieu);
            this.grbThongtinsp.Controls.Add(this.txtTensp);
            this.grbThongtinsp.Controls.Add(this.lblTensanpham);
            this.grbThongtinsp.ForeColor = System.Drawing.Color.DarkRed;
            this.grbThongtinsp.Location = new System.Drawing.Point(105, 128);
            this.grbThongtinsp.Name = "grbThongtinsp";
            this.grbThongtinsp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbThongtinsp.Size = new System.Drawing.Size(528, 185);
            this.grbThongtinsp.TabIndex = 15;
            this.grbThongtinsp.TabStop = false;
            this.grbThongtinsp.Text = "Thông tin sản phẩm";
            // 
            // cbbThuonghieu
            // 
            this.cbbThuonghieu.AutoCompleteCustomSource.AddRange(new string[] {
            "Samsung",
            "Iphone",
            "Xiaomi",
            "Nokia",
            "OPPO"});
            this.cbbThuonghieu.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cbbThuonghieu.FormattingEnabled = true;
            this.cbbThuonghieu.Items.AddRange(new object[] {
            "Samsung",
            "Iphone",
            "Xiaomi",
            "Nokia",
            "OPPO"});
            this.cbbThuonghieu.Location = new System.Drawing.Point(201, 44);
            this.cbbThuonghieu.Name = "cbbThuonghieu";
            this.cbbThuonghieu.Size = new System.Drawing.Size(235, 22);
            this.cbbThuonghieu.TabIndex = 9;
            // 
            // lblThuonghieu
            // 
            this.lblThuonghieu.AutoSize = true;
            this.lblThuonghieu.BackColor = System.Drawing.Color.Transparent;
            this.lblThuonghieu.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblThuonghieu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblThuonghieu.Location = new System.Drawing.Point(79, 44);
            this.lblThuonghieu.Name = "lblThuonghieu";
            this.lblThuonghieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThuonghieu.Size = new System.Drawing.Size(84, 16);
            this.lblThuonghieu.TabIndex = 0;
            this.lblThuonghieu.Text = "Thương hiệu ";
            // 
            // txtTensp
            // 
            this.txtTensp.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTensp.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTensp.Location = new System.Drawing.Point(201, 81);
            this.txtTensp.Name = "txtTensp";
            this.txtTensp.Size = new System.Drawing.Size(235, 22);
            this.txtTensp.TabIndex = 8;
            // 
            // lblTensanpham
            // 
            this.lblTensanpham.AutoSize = true;
            this.lblTensanpham.BackColor = System.Drawing.Color.Transparent;
            this.lblTensanpham.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lblTensanpham.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTensanpham.Location = new System.Drawing.Point(79, 85);
            this.lblTensanpham.Name = "lblTensanpham";
            this.lblTensanpham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTensanpham.Size = new System.Drawing.Size(94, 16);
            this.lblTensanpham.TabIndex = 1;
            this.lblTensanpham.Text = "Tên sản phẩm ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 47);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nhập đơn bán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmBaoTri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTaomoi);
            this.Controls.Add(this.grbHoadon);
            this.Controls.Add(this.grbDichvu);
            this.Controls.Add(this.grbThongtinsp);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBaoTri";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoTri_Load);
            this.grbHoadon.ResumeLayout(false);
            this.grbHoadon.PerformLayout();
            this.grbDichvu.ResumeLayout(false);
            this.grbDichvu.PerformLayout();
            this.grbThongtinsp.ResumeLayout(false);
            this.grbThongtinsp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTaomoi;
        private System.Windows.Forms.GroupBox grbHoadon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInhoadon;
        private System.Windows.Forms.TextBox txtThanhtien;
        private System.Windows.Forms.TextBox txtDichvu;
        private System.Windows.Forms.TextBox txtNhaptensp;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.TextBox txtTenKh;
        private System.Windows.Forms.Label lblThanhtien;
        private System.Windows.Forms.Label lblThongtinbaotri;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.GroupBox grbDichvu;
        private System.Windows.Forms.CheckBox ckcMatlung;
        private System.Windows.Forms.CheckBox ckcChansac;
        private System.Windows.Forms.CheckBox ckcManhinh;
        private System.Windows.Forms.CheckBox ckcPin;
        private System.Windows.Forms.CheckBox ckcEpkinh;
        private System.Windows.Forms.GroupBox grbThongtinsp;
        private System.Windows.Forms.ComboBox cbbThuonghieu;
        private System.Windows.Forms.Label lblThuonghieu;
        private System.Windows.Forms.TextBox txtTensp;
        private System.Windows.Forms.Label lblTensanpham;
        private System.Windows.Forms.Label label1;
    }
}