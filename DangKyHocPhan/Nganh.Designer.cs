﻿
namespace DangKyHocPhan
{
    partial class Nganh
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboThuocKhoa = new System.Windows.Forms.ComboBox();
            this.lblThuocKhoa = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.btnThemNganh = new System.Windows.Forms.Button();
            this.lblMaNganh = new System.Windows.Forms.Label();
            this.btnSuaNganh = new System.Windows.Forms.Button();
            this.lblTenNganh = new System.Windows.Forms.Label();
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.dKHPDataSet = new DangKyHocPhan.DKHPDataSet();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.KHOATableAdapter();
            this.dgvDSNganh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.khoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngànhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboThuocKhoa);
            this.groupBox1.Controls.Add(this.lblThuocKhoa);
            this.groupBox1.Controls.Add(this.txtMaNganh);
            this.groupBox1.Controls.Add(this.btnThemNganh);
            this.groupBox1.Controls.Add(this.lblMaNganh);
            this.groupBox1.Controls.Add(this.btnSuaNganh);
            this.groupBox1.Controls.Add(this.lblTenNganh);
            this.groupBox1.Controls.Add(this.btnXoaNganh);
            this.groupBox1.Controls.Add(this.txtTenNganh);
            this.groupBox1.Location = new System.Drawing.Point(277, 78);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(285, 161);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngành đào tạo";
            // 
            // cboThuocKhoa
            // 
            this.cboThuocKhoa.FormattingEnabled = true;
            this.cboThuocKhoa.Location = new System.Drawing.Point(103, 86);
            this.cboThuocKhoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboThuocKhoa.Name = "cboThuocKhoa";
            this.cboThuocKhoa.Size = new System.Drawing.Size(177, 24);
            this.cboThuocKhoa.TabIndex = 4;
            this.cboThuocKhoa.SelectedValueChanged += new System.EventHandler(this.cboThuocKhoa_SelectedIndexChanged);
            // 
            // lblThuocKhoa
            // 
            this.lblThuocKhoa.AutoSize = true;
            this.lblThuocKhoa.Location = new System.Drawing.Point(11, 89);
            this.lblThuocKhoa.Name = "lblThuocKhoa";
            this.lblThuocKhoa.Size = new System.Drawing.Size(87, 17);
            this.lblThuocKhoa.TabIndex = 10;
            this.lblThuocKhoa.Text = "Thuộc khoa:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(103, 30);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(177, 22);
            this.txtMaNganh.TabIndex = 2;
            // 
            // btnThemNganh
            // 
            this.btnThemNganh.Location = new System.Drawing.Point(211, 123);
            this.btnThemNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemNganh.Name = "btnThemNganh";
            this.btnThemNganh.Size = new System.Drawing.Size(69, 23);
            this.btnThemNganh.TabIndex = 5;
            this.btnThemNganh.Text = "Thêm";
            this.btnThemNganh.UseVisualStyleBackColor = true;
            this.btnThemNganh.Click += new System.EventHandler(this.btnThemNganh_Click);
            // 
            // lblMaNganh
            // 
            this.lblMaNganh.AutoSize = true;
            this.lblMaNganh.Location = new System.Drawing.Point(11, 33);
            this.lblMaNganh.Name = "lblMaNganh";
            this.lblMaNganh.Size = new System.Drawing.Size(75, 17);
            this.lblMaNganh.TabIndex = 1;
            this.lblMaNganh.Text = "Mã ngành:";
            // 
            // btnSuaNganh
            // 
            this.btnSuaNganh.Location = new System.Drawing.Point(136, 123);
            this.btnSuaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSuaNganh.Name = "btnSuaNganh";
            this.btnSuaNganh.Size = new System.Drawing.Size(69, 23);
            this.btnSuaNganh.TabIndex = 6;
            this.btnSuaNganh.Text = "Sửa";
            this.btnSuaNganh.UseVisualStyleBackColor = true;
            this.btnSuaNganh.Click += new System.EventHandler(this.btnSuaNganh_Click);
            // 
            // lblTenNganh
            // 
            this.lblTenNganh.AutoSize = true;
            this.lblTenNganh.Location = new System.Drawing.Point(11, 62);
            this.lblTenNganh.Name = "lblTenNganh";
            this.lblTenNganh.Size = new System.Drawing.Size(81, 17);
            this.lblTenNganh.TabIndex = 3;
            this.lblTenNganh.Text = "Tên ngành:";
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.Location = new System.Drawing.Point(61, 123);
            this.btnXoaNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(69, 23);
            this.btnXoaNganh.TabIndex = 7;
            this.btnXoaNganh.Text = "Xóa";
            this.btnXoaNganh.UseVisualStyleBackColor = true;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(103, 58);
            this.txtTenNganh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(177, 22);
            this.txtTenNganh.TabIndex = 3;
            // 
            // dKHPDataSet
            // 
            this.dKHPDataSet.DataSetName = "DKHPDataSet";
            this.dKHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dKHPDataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // dgvDSNganh
            // 
            this.dgvDSNganh.AllowUserToAddRows = false;
            this.dgvDSNganh.AllowUserToDeleteRows = false;
            this.dgvDSNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNganh.ColumnHeadersHeight = 29;
            this.dgvDSNganh.Location = new System.Drawing.Point(12, 244);
            this.dgvDSNganh.Name = "dgvDSNganh";
            this.dgvDSNganh.ReadOnly = true;
            this.dgvDSNganh.RowHeadersWidth = 51;
            this.dgvDSNganh.RowTemplate.Height = 24;
            this.dgvDSNganh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNganh.Size = new System.Drawing.Size(776, 194);
            this.dgvDSNganh.TabIndex = 10;
            this.dgvDSNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNganh_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ NGÀNH ĐẢO TẠO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khoaToolStripMenuItem,
            this.ngànhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // khoaToolStripMenuItem
            // 
            this.khoaToolStripMenuItem.Name = "khoaToolStripMenuItem";
            this.khoaToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.khoaToolStripMenuItem.Text = "Khoa";
            this.khoaToolStripMenuItem.Click += new System.EventHandler(this.khoaToolStripMenuItem_Click);
            // 
            // ngànhToolStripMenuItem
            // 
            this.ngànhToolStripMenuItem.Name = "ngànhToolStripMenuItem";
            this.ngànhToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ngànhToolStripMenuItem.Text = "Ngành";
            // 
            // Nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSNganh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Nganh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ngành đào tạo";
            this.Load += new System.EventHandler(this.Nganh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboThuocKhoa;
        private System.Windows.Forms.Label lblThuocKhoa;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Button btnThemNganh;
        private System.Windows.Forms.Label lblMaNganh;
        private System.Windows.Forms.Button btnSuaNganh;
        private System.Windows.Forms.Label lblTenNganh;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private DKHPDataSet dKHPDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DKHPDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.DataGridView dgvDSNganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem khoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngànhToolStripMenuItem;
    }
}