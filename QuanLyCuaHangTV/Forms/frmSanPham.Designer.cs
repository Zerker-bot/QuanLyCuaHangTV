namespace QuanLyCuaHangTV.Forms
{
    partial class frmSanPham
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            txtTenSanPham = new TextBox();
            label3 = new Label();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtMoTa = new TextBox();
            cboLoaiSanPham = new ComboBox();
            cboHangSanXuat = new ComboBox();
            btnDoiAnh = new Button();
            picHinhAnh = new PictureBox();
            numSoLuong = new NumericUpDown();
            numGiaBan = new NumericUpDown();
            dataGridView = new DataGridView();
            IDSP = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            TenLoai = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            DoPhanGiai = new DataGridViewTextBoxColumn();
            KichThuoc = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            numGiaNhap = new NumericUpDown();
            label4 = new Label();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            cboTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            txtDoPhanGiai = new TextBox();
            label5 = new Label();
            label9 = new Label();
            txtKichThuoc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(260, 77);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 1;
            label1.Text = "Phân loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(260, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 23);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm:";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(260, 40);
            txtTenSanPham.Margin = new Padding(4, 5, 4, 5);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(448, 31);
            txtTenSanPham.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(420, 75);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 23);
            label3.TabIndex = 6;
            label3.Text = "Hãng sãn xuất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(877, 77);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(98, 23);
            label6.TabIndex = 20;
            label6.Text = "Giá bán:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(592, 76);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 18;
            label8.Text = "Số lượng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(277, 140);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(175, 23);
            label7.TabIndex = 23;
            label7.Text = "Mô tả sản phẩm:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(260, 168);
            txtMoTa.Margin = new Padding(4, 5, 4, 5);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(801, 99);
            txtMoTa.TabIndex = 24;
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(260, 104);
            cboLoaiSanPham.Margin = new Padding(4, 5, 4, 5);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(152, 31);
            cboLoaiSanPham.TabIndex = 25;
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(420, 104);
            cboHangSanXuat.Margin = new Padding(4, 5, 4, 5);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(164, 31);
            cboHangSanXuat.TabIndex = 26;
            // 
            // btnDoiAnh
            // 
            btnDoiAnh.BackColor = Color.FromArgb(23, 162, 184);
            btnDoiAnh.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDoiAnh.Location = new Point(17, 226);
            btnDoiAnh.Margin = new Padding(4, 5, 4, 5);
            btnDoiAnh.Name = "btnDoiAnh";
            btnDoiAnh.Size = new Size(235, 41);
            btnDoiAnh.TabIndex = 27;
            btnDoiAnh.Text = "Đổi ảnh";
            btnDoiAnh.UseVisualStyleBackColor = false;
            btnDoiAnh.Click += btnDoiAnh_Click;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BackgroundImageLayout = ImageLayout.Zoom;
            picHinhAnh.BorderStyle = BorderStyle.Fixed3D;
            picHinhAnh.Location = new Point(17, 13);
            picHinhAnh.Margin = new Padding(4, 5, 4, 5);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(235, 203);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 29;
            picHinhAnh.TabStop = false;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(592, 104);
            numSoLuong.Margin = new Padding(4, 5, 4, 5);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(109, 31);
            numSoLuong.TabIndex = 30;
            numSoLuong.ThousandsSeparator = true;
            // 
            // numGiaBan
            // 
            numGiaBan.Location = new Point(877, 105);
            numGiaBan.Margin = new Padding(4, 5, 4, 5);
            numGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaBan.Name = "numGiaBan";
            numGiaBan.Size = new Size(184, 31);
            numGiaBan.TabIndex = 31;
            numGiaBan.ThousandsSeparator = true;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Consolas", 12F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { IDSP, TenSanPham, TenLoai, TenHangSanXuat, DoPhanGiai, KichThuoc, SoLuong, GiaNhap, GiaBan, HinhAnh });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 12F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.Location = new Point(17, 318);
            dataGridView.Margin = new Padding(4, 5, 4, 5);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(1044, 519);
            dataGridView.TabIndex = 32;
            dataGridView.CellFormatting += dataGridView_CellFormatting_1;
            // 
            // IDSP
            // 
            IDSP.DataPropertyName = "ID";
            IDSP.HeaderText = "ID";
            IDSP.MinimumWidth = 6;
            IDSP.Name = "IDSP";
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // TenLoai
            // 
            TenLoai.DataPropertyName = "TenLoai";
            TenLoai.HeaderText = "Phân loại";
            TenLoai.MinimumWidth = 6;
            TenLoai.Name = "TenLoai";
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "Hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            // 
            // DoPhanGiai
            // 
            DoPhanGiai.DataPropertyName = "DoPhanGiai";
            DoPhanGiai.HeaderText = "Độ phân giải";
            DoPhanGiai.MinimumWidth = 6;
            DoPhanGiai.Name = "DoPhanGiai";
            // 
            // KichThuoc
            // 
            KichThuoc.DataPropertyName = "KichThuoc";
            KichThuoc.HeaderText = "Kích Thước";
            KichThuoc.MinimumWidth = 6;
            KichThuoc.Name = "KichThuoc";
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            SoLuong.HeaderText = "Số lượng";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            // 
            // GiaNhap
            // 
            GiaNhap.DataPropertyName = "GiaNhap";
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 6;
            GiaNhap.Name = "GiaNhap";
            // 
            // GiaBan
            // 
            GiaBan.DataPropertyName = "GiaBan";
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            // 
            // numGiaNhap
            // 
            numGiaNhap.Location = new Point(877, 41);
            numGiaNhap.Margin = new Padding(4, 5, 4, 5);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(184, 31);
            numGiaNhap.TabIndex = 33;
            numGiaNhap.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(877, 13);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 34;
            label4.Text = "Giá nhập:";
            // 
            // btnHuyBo
            // 
            btnHuyBo.Anchor = AnchorStyles.Right;
            btnHuyBo.BackColor = Color.Black;
            btnHuyBo.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuyBo.ForeColor = Color.White;
            btnHuyBo.Image = Properties.Resources.cancel;
            btnHuyBo.ImageAlign = ContentAlignment.MiddleLeft;
            btnHuyBo.Location = new Point(1069, 767);
            btnHuyBo.Margin = new Padding(4, 3, 4, 3);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 70);
            btnHuyBo.TabIndex = 39;
            btnHuyBo.Text = "Huỷ bỏ";
            btnHuyBo.TextAlign = ContentAlignment.MiddleRight;
            btnHuyBo.UseVisualStyleBackColor = false;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.Anchor = AnchorStyles.Right;
            btnLuu.BackColor = Color.Black;
            btnLuu.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Image = Properties.Resources.save;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(1069, 681);
            btnLuu.Margin = new Padding(4, 3, 4, 3);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 70);
            btnLuu.TabIndex = 38;
            btnLuu.Text = "Lưu  ";
            btnLuu.TextAlign = ContentAlignment.MiddleRight;
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Right;
            btnXoa.BackColor = Color.FromArgb(220, 53, 69);
            btnXoa.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = Properties.Resources.delete;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(1069, 187);
            btnXoa.Margin = new Padding(4, 3, 4, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 70);
            btnXoa.TabIndex = 37;
            btnXoa.Text = "Xoá  ";
            btnXoa.TextAlign = ContentAlignment.MiddleRight;
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Right;
            btnSua.BackColor = Color.Orange;
            btnSua.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Properties.Resources.edit;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(1069, 98);
            btnSua.Margin = new Padding(4, 3, 4, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 70);
            btnSua.TabIndex = 36;
            btnSua.Text = "Sửa  ";
            btnSua.TextAlign = ContentAlignment.MiddleRight;
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(40, 167, 69);
            btnThem.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Image = Properties.Resources.add2;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(1069, 12);
            btnThem.Margin = new Padding(4, 3, 4, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 70);
            btnThem.TabIndex = 35;
            btnThem.Text = "Thêm ";
            btnThem.TextAlign = ContentAlignment.MiddleRight;
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(cboTimKiem);
            panel1.Controls.Add(txtTimKiem);
            panel1.Location = new Point(17, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(1044, 35);
            panel1.TabIndex = 40;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.search1;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // cboTimKiem
            // 
            cboTimKiem.FlatStyle = FlatStyle.Flat;
            cboTimKiem.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTimKiem.FormattingEnabled = true;
            cboTimKiem.ItemHeight = 20;
            cboTimKiem.Location = new Point(851, 3);
            cboTimKiem.Name = "cboTimKiem";
            cboTimKiem.Size = new Size(190, 28);
            cboTimKiem.TabIndex = 30;
            cboTimKiem.SelectedIndexChanged += cboTimKiem_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.None;
            txtTimKiem.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(43, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(802, 20);
            txtTimKiem.TabIndex = 29;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // txtDoPhanGiai
            // 
            txtDoPhanGiai.Location = new Point(716, 40);
            txtDoPhanGiai.Margin = new Padding(4, 5, 4, 5);
            txtDoPhanGiai.Name = "txtDoPhanGiai";
            txtDoPhanGiai.Size = new Size(146, 31);
            txtDoPhanGiai.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(716, 13);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 42;
            label5.Text = "Độ phân giải:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 12F, FontStyle.Bold);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(716, 77);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 43;
            label9.Text = "Kích thước:";
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.Location = new Point(716, 105);
            txtKichThuoc.Margin = new Padding(4, 5, 4, 5);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.Size = new Size(146, 31);
            txtKichThuoc.TabIndex = 44;
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 226, 229);
            ClientSize = new Size(1232, 853);
            Controls.Add(txtKichThuoc);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(txtDoPhanGiai);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(numGiaNhap);
            Controls.Add(btnHuyBo);
            Controls.Add(numGiaBan);
            Controls.Add(btnLuu);
            Controls.Add(numSoLuong);
            Controls.Add(btnXoa);
            Controls.Add(cboHangSanXuat);
            Controls.Add(btnSua);
            Controls.Add(cboLoaiSanPham);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(label7);
            Controls.Add(dataGridView);
            Controls.Add(label6);
            Controls.Add(picHinhAnh);
            Controls.Add(label8);
            Controls.Add(btnDoiAnh);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtTenSanPham);
            Controls.Add(label2);
            Font = new Font("Consolas", 12F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm";
            Load += frmSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtTenSanPham;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label7;
        private TextBox txtMoTa;
        private ComboBox cboLoaiSanPham;
        private ComboBox cboHangSanXuat;
        private Button btnDoiAnh;
        private PictureBox picHinhAnh;
        private NumericUpDown numSoLuong;
        private NumericUpDown numGiaBan;
        private DataGridView dataGridView;
        private NumericUpDown numGiaNhap;
        private Label label4;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Panel panel1;
        private PictureBox pictureBox1;
        private ComboBox cboTimKiem;
        private TextBox txtTimKiem;
        private DataGridViewTextBoxColumn IDSP;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn TenLoai;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn DoPhanGiai;
        private DataGridViewTextBoxColumn KichThuoc;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewImageColumn HinhAnh;
        private TextBox txtDoPhanGiai;
        private Label label5;
        private Label label9;
        private TextBox txtKichThuoc;
    }
}
