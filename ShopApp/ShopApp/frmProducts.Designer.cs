
namespace ShopApp
{
    partial class frmProducts
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
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCamera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReleaseyear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colprovID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNavigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMemory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colTen,
            this.colGia,
            this.colDonViTinh,
            this.colSL,
            this.colCamera,
            this.colMenory,
            this.colReleaseyear,
            this.colRAM,
            this.colDescription,
            this.colTrangThai,
            this.colprovID,
            this.colNavigation});
            this.dgvDSSP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSSP.Location = new System.Drawing.Point(0, 157);
            this.dgvDSSP.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.RowHeadersVisible = false;
            this.dgvDSSP.RowHeadersWidth = 62;
            this.dgvDSSP.RowTemplate.Height = 28;
            this.dgvDSSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSP.Size = new System.Drawing.Size(1000, 510);
            this.dgvDSSP.TabIndex = 104;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "prodID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 8;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "prodName";
            this.colTen.HeaderText = "Tên";
            this.colTen.MinimumWidth = 8;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.DataPropertyName = "prodPrice";
            this.colGia.HeaderText = "Giá";
            this.colGia.MinimumWidth = 8;
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.DataPropertyName = "prodlnit";
            this.colDonViTinh.HeaderText = "Đơn vị tính";
            this.colDonViTinh.MinimumWidth = 8;
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.DataPropertyName = "prodSL";
            this.colSL.HeaderText = "Số lượng";
            this.colSL.MinimumWidth = 8;
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colCamera
            // 
            this.colCamera.DataPropertyName = "prodCamera";
            this.colCamera.HeaderText = "Camera";
            this.colCamera.MinimumWidth = 8;
            this.colCamera.Name = "colCamera";
            this.colCamera.ReadOnly = true;
            // 
            // colMenory
            // 
            this.colMenory.DataPropertyName = "prodMenory";
            this.colMenory.HeaderText = "Menory";
            this.colMenory.MinimumWidth = 8;
            this.colMenory.Name = "colMenory";
            this.colMenory.ReadOnly = true;
            // 
            // colReleaseyear
            // 
            this.colReleaseyear.DataPropertyName = "prodReleaseYear";
            this.colReleaseyear.HeaderText = "Năm phát hành";
            this.colReleaseyear.MinimumWidth = 8;
            this.colReleaseyear.Name = "colReleaseyear";
            this.colReleaseyear.ReadOnly = true;
            // 
            // colRAM
            // 
            this.colRAM.DataPropertyName = "prodRAM";
            this.colRAM.HeaderText = "RAM";
            this.colRAM.MinimumWidth = 8;
            this.colRAM.Name = "colRAM";
            this.colRAM.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "prodDescription";
            this.colDescription.HeaderText = "Miêu tả";
            this.colDescription.MinimumWidth = 8;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // colTrangThai
            // 
            this.colTrangThai.DataPropertyName = "prodStatus";
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 8;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // colprovID
            // 
            this.colprovID.DataPropertyName = "provID";
            this.colprovID.HeaderText = "ID NCC";
            this.colprovID.MinimumWidth = 8;
            this.colprovID.Name = "colprovID";
            this.colprovID.ReadOnly = true;
            this.colprovID.Visible = false;
            // 
            // colNavigation
            // 
            this.colNavigation.DataPropertyName = "catID";
            this.colNavigation.HeaderText = "ID DM";
            this.colNavigation.MinimumWidth = 8;
            this.colNavigation.Name = "colNavigation";
            this.colNavigation.ReadOnly = true;
            this.colNavigation.Visible = false;
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
            this.panel1.TabIndex = 106;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Controls.Add(this.btnSearch);
            this.panel8.Controls.Add(this.btnReset);
            this.panel8.Location = new System.Drawing.Point(820, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(177, 96);
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
            this.btnReset.Location = new System.Drawing.Point(99, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 90);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "lấy lại danh sách";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.cboYear);
            this.panel7.Location = new System.Drawing.Point(683, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(131, 96);
            this.panel7.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Năm Phát Hành";
            // 
            // cboYear
            // 
            this.cboYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(9, 21);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(109, 21);
            this.cboYear.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.cboMemory);
            this.panel6.Location = new System.Drawing.Point(535, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(142, 96);
            this.panel6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Memory";
            // 
            // cboMemory
            // 
            this.cboMemory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboMemory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMemory.FormattingEnabled = true;
            this.cboMemory.Location = new System.Drawing.Point(9, 21);
            this.cboMemory.Name = "cboMemory";
            this.cboMemory.Size = new System.Drawing.Size(121, 21);
            this.cboMemory.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cboID);
            this.panel4.Location = new System.Drawing.Point(376, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 96);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 75);
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
            this.cboID.Size = new System.Drawing.Size(132, 21);
            this.cboID.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboPrice);
            this.panel3.Location = new System.Drawing.Point(208, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 96);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Theo giá";
            // 
            // cboPrice
            // 
            this.cboPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(9, 21);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(139, 21);
            this.cboPrice.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cboName);
            this.panel2.Location = new System.Drawing.Point(12, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 96);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 75);
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
            this.cboName.Size = new System.Drawing.Size(164, 21);
            this.cboName.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(920, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 24);
            this.btnClose.TabIndex = 108;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 47);
            this.label1.TabIndex = 137;
            this.label1.Text = "Danh sách sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProducts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMemory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCamera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMenory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReleaseyear;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colprovID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNavigation;
    }
}