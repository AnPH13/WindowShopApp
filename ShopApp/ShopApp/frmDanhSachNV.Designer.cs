
namespace ShopApp
{
    partial class frmDanhSachNV
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSDT = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMieuTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 102);
            this.panel1.TabIndex = 139;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Controls.Add(this.btnSearch);
            this.panel8.Controls.Add(this.btnReset);
            this.panel8.Location = new System.Drawing.Point(739, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(258, 96);
            this.panel8.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.BackgroundImage = global::ShopApp.Properties.Resources.SearchIcon;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(20, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 62);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Navy;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.Location = new System.Drawing.Point(138, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 90);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "lấy lại danh sách";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.chkStatus);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Location = new System.Drawing.Point(595, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(138, 96);
            this.panel7.TabIndex = 3;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(37, 25);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(55, 17);
            this.chkStatus.TabIndex = 2;
            this.chkStatus.Text = "active";
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Theo trạng thái";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.cboSDT);
            this.panel6.Location = new System.Drawing.Point(447, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(142, 96);
            this.panel6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Theo số điện thoại";
            // 
            // cboSDT
            // 
            this.cboSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSDT.FormattingEnabled = true;
            this.cboSDT.Location = new System.Drawing.Point(9, 21);
            this.cboSDT.Name = "cboSDT";
            this.cboSDT.Size = new System.Drawing.Size(121, 21);
            this.cboSDT.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cboID);
            this.panel4.Location = new System.Drawing.Point(299, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(142, 96);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Theo ID";
            // 
            // cboID
            // 
            this.cboID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(7, 21);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(127, 21);
            this.cboID.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboAddress);
            this.panel3.Location = new System.Drawing.Point(151, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 96);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Theo địa chỉ";
            // 
            // cboAddress
            // 
            this.cboAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboAddress.FormattingEnabled = true;
            this.cboAddress.Location = new System.Drawing.Point(9, 21);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(121, 21);
            this.cboAddress.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 96);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Theo tên";
            // 
            // cboName
            // 
            this.cboName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(9, 21);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 21);
            this.cboName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 47);
            this.label1.TabIndex = 140;
            this.label1.Text = "Danh sách nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeight = 34;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colNgaySinh,
            this.colDiaChi,
            this.colSoDienThoai,
            this.colGioiTinh,
            this.colMieuTa,
            this.colTrangThai,
            this.colLuong,
            this.colViTri});
            this.dgvNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 154);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.RowTemplate.Height = 28;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1000, 513);
            this.dgvNhanVien.TabIndex = 141;
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colID.DataPropertyName = "staID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.Width = 43;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "staName";
            this.colTen.FillWeight = 70.74236F;
            this.colTen.HeaderText = "Tên ";
            this.colTen.MinimumWidth = 8;
            this.colTen.Name = "colTen";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "staBirthday";
            this.colNgaySinh.FillWeight = 116.9471F;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 8;
            this.colNgaySinh.Name = "colNgaySinh";
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "staAddress";
            this.colDiaChi.FillWeight = 93.0826F;
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MinimumWidth = 8;
            this.colDiaChi.Name = "colDiaChi";
            // 
            // colSoDienThoai
            // 
            this.colSoDienThoai.DataPropertyName = "staPhone";
            this.colSoDienThoai.FillWeight = 139.5039F;
            this.colSoDienThoai.HeaderText = "Số điện thoại";
            this.colSoDienThoai.MinimumWidth = 8;
            this.colSoDienThoai.Name = "colSoDienThoai";
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "staSex";
            this.colGioiTinh.FillWeight = 101.8741F;
            this.colGioiTinh.HeaderText = "Giới tính";
            this.colGioiTinh.MinimumWidth = 8;
            this.colGioiTinh.Name = "colGioiTinh";
            // 
            // colMieuTa
            // 
            this.colMieuTa.DataPropertyName = "staDescription";
            this.colMieuTa.FillWeight = 93.18156F;
            this.colMieuTa.HeaderText = "Miêu tả";
            this.colMieuTa.MinimumWidth = 8;
            this.colMieuTa.Name = "colMieuTa";
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "staStatus";
            this.colTrangThai.FillWeight = 115.7041F;
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            // 
            // colLuong
            // 
            this.colLuong.DataPropertyName = "staSalary";
            this.colLuong.FillWeight = 91.75641F;
            this.colLuong.HeaderText = "Lương ";
            this.colLuong.MinimumWidth = 8;
            this.colLuong.Name = "colLuong";
            // 
            // colViTri
            // 
            this.colViTri.DataPropertyName = "staPosition";
            this.colViTri.FillWeight = 77.20785F;
            this.colViTri.HeaderText = "Vị trí";
            this.colViTri.MinimumWidth = 8;
            this.colViTri.Name = "colViTri";
            // 
            // frmDanhSachNV
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDanhSachNV";
            this.Text = "frmDanhSachNV";
            this.Load += new System.EventHandler(this.frmDanhSachNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSDT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMieuTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colViTri;
    }
}